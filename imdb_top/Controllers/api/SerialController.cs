using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using imdb_top.Models;
using System.Data.Entity;

namespace imdb_top.Controllers.api
{
    public class SerialController : ApiController
    {
        private DBContext _context;
        public SerialController()
        {
            _context = new DBContext();
        }
        [HttpGet]
        public List<Serial> GetMovies()
        {
            return _context.Serials.Include(g => g.Genre).ToList();
        }

        [HttpGet]
        public Serial GetMovie(int id)
        {
            var serial = _context.Serials.SingleOrDefault(s => s.Id == id);

            if (serial == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return serial;
        }
    }
}
