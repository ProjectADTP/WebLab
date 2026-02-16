using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebLab.Models;

namespace WebLab.Controllers
{
    public class ObjectsController : ApiController
    {
        private AppDbContext db = new AppDbContext();

        [HttpGet]
        public IHttpActionResult GetObjects()
        {
            return Ok(db.Objects.ToList());
        }

        [HttpPost]
        public IHttpActionResult CreateObject(ObjectModel obj)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            db.Objects.Add(obj);
            db.SaveChanges();

            return Ok(obj);
        }
    }
}