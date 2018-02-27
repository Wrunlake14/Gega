using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Vega.Models;

namespace Vega.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
       
        public DbSet<Make> Makes { get; set; }
// real not need it is in the Makes class. only need if direct query
        public DbSet<Model> Models { get; set; }
       public DbSet<Feature> Features { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        // error checking
        public DbSet<Model> Modles { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleFeature>().HasKey(vf =>
            new { vf.VehicleId, vf.FeatureId });
            

            base.OnModelCreating(modelBuilder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
