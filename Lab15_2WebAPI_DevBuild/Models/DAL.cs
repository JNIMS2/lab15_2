using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using MySql.Data;
using MySql.Data.MySqlClient;
using Dapper;

namespace Lab15_2WebAPI_DevBuild.Models
{
    public class DAL
    {
        public static MySqlConnection DB;

        //get all movies:
        public static List<Movie> ReadAllMovies()
        {
            return DB.GetAll<Movie>().ToList();
        }

        //get one movie:
        //should i change id to be title and make title the primary key?????
        public static Movie ReadOneMovie(int id)
        {
            return DB.Get<Movie>(id);
        }

        //get movies of a category:

        public static List<Movie> ReadAllbyCategory(string category)
        {
            Object myparams = new { theCat = category };
            string sql = "select * from movie where category = @theCat";

            List<Movie> mov = DB.Query<Movie>(sql, myparams).ToList();
            return mov;
        }

        //delete a movie:
        public static bool DeleteMovie(int id)
        {
            Movie mov = new Movie() { id = id };
            DB.Delete<Movie>(mov);
            return true;
        }
        //what do we normally return here^^^^??



        //add a movie:
        public static Movie AddMovie(Movie mov)
        {
            DB.Insert<Movie>(mov);
            return mov;
        }



        //update a movie:
        public static Movie UpdateMovie(Movie mov)
        {
            DB.Update<Movie>(mov);
                return mov;
        }

    }
}
