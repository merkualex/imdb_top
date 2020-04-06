using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using imdb_top.Models;
using System.Data.Entity;
using imdb_top.ViewModels;

namespace imdb_top.Controllers
{
    public class HomeController : Controller
    {
        private DBContext _context;
        public HomeController()
        {
            _context = new DBContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(g => g.Genre).ToList();
            var serials = _context.Serials.Include(g => g.Genre).ToList();

            var viewModel = new IndexViewModel
            {
                Movies = movies,
                Serials = serials
            };

            return View(viewModel);
        }
    }
}