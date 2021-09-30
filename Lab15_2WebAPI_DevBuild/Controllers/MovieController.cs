using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab15_2WebAPI_DevBuild.Models;

namespace Lab15_2WebAPI_DevBuild.Controllers

    ////Antonio--for clarity--only the readones are ones that we can see the data if we just put the url path in the browser 
    ///when running this, right? unless u use something like postman???

{
    [Route("api/movie")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        //readall
        //https://localhost:44391/api/movie/readall
        [HttpGet("readall")]
        public List<Movie> readall()
        {
            return DAL.ReadAllMovies();
        }


        //readone
       // https://localhost:44391/api/movie/readone?id=3
        [HttpGet("readone")]
        public Movie readone(int id)
        {
            return DAL.ReadOneMovie(id);
        }

        //readone by cat
        //https://localhost:44391/api/movie/readbycat?category=ACTION
        [HttpGet("readbycat")]
        public List<Movie> readbycat(string category)
        {
            return DAL.ReadAllbyCategory(category);
        }

        //add
        //https://localhost:44391/api/movie/add
        [HttpPost("add")]
        public Movie addMovie(Movie mov)
        {
            return DAL.AddMovie(mov);
        }

        //delete
        //https://localhost:44391/api/movie/delete?id=10
        [HttpDelete("delete")]
        public bool deleteMovie(int id)
        {
            return DAL.DeleteMovie(id);
        }


        //update
       // https://localhost:44391/api/movie/update
        [HttpPut("update")]
        public Movie updateMovie(Movie mov)
        {
            return DAL.UpdateMovie(mov);
        }

    }
}
