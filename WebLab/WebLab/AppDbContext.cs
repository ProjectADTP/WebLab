using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebLab.Models;

namespace WebLab
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("DefaultConnection") { }

        public DbSet<ObjectModel> Objects { get; set; }
        public DbSet<BeaconModel> Beacons { get; set; }
    }
}