using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using imdb_top.Models;
using System.Data.Entity;

namespace imdb_top.Controllers
{
    public class MovieController : Controller
    {
        private DBContext _context;
        public MovieController()
        {
            _context = new DBContext();
        }

        // GET: Movie
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Info(int id)
        {
            var movie = _context.Movies.Include(g => g.Genre).SingleOrDefault(m => m.Id == id);
            return View(movie);
        }
    }
}