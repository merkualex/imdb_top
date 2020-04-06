using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace imdb_top.Models
{
    public class DBContext : DbContext
    {
        public DBContext()
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Serial> Serials { get; set; }
        public DbSet<Genre> Genres { get; set; }


    }
}