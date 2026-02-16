using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebLab.Models;

namespace WebLab.Controllers
{
    public class BeaconsController : ApiController
    {
        private AppDbContext db = new AppDbContext();

        [HttpGet]
        public IHttpActionResult GetBeacons()
        {
            return Ok(db.Beacons.ToList());
        }

        [HttpPost]
        public IHttpActionResult CreateBeacon(BeaconModel beacon)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            db.Beacons.Add(beacon);
            db.SaveChanges();

            return Ok(beacon);
        }
    }
}