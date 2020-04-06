using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace imdb_top.Models
{
    public class Movie
    {
        public byte Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Release { get; set; }

        public float Imdb { get; set; }

        public Genre Genre { get; set; }

        [Required]
        public byte GenreId { get; set; }

    }
}