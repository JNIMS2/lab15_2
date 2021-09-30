using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Lab15_2WebAPI_DevBuild.Models
{
    [Table("movie")]

    public class Movie
    {
        [Key]
        public int id { get; set; }
        public string category { get; set; }
        public string title { get; set;}
        public string director { get; set; }
        public string starring { get; set; }

    }
}
