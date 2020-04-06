using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using imdb_top.Models;
using System.Data.Entity;

namespace imdb_top.Controllers
{
    public class SerialController : Controller
    {
        private DBContext _context;

        public SerialController()
        {
            _context = new DBContext();
        }
        // GET: Serial
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Info(int id)
        {
            var serial = _context.Serials.Include(g => g.Genre).SingleOrDefault(s => s.Id == id);

            return View(serial);
        }
    }
}