using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using imdb_top.Models;

namespace imdb_top.ViewModels
{
    public class IndexViewModel
    {
        public List<Movie> Movies { get; set; }
        public List<Serial> Serials { get; set; }
    }
}