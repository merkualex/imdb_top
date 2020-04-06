using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using imdb_top.Models;

namespace imdb_top.Controllers.api
{
    public class MovieController : ApiController
    {
        private DBContext _context;
        public MovieController()
        {
            _context = new DBContext();
        }
        [HttpGet]
        public List<Movie> GetMovies()
        {
            return _context.Movies.ToList();
        }

        [HttpGet]
        public Movie GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return movie;
        } 
    }
}
