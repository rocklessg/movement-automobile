using Microsoft.EntityFrameworkCore;
using movement_auto_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movement_auto_data.DbContexts
{
    public class MovementDbContext : DbContext
    {
        public MovementDbContext(DbContextOptions<MovementDbContext> options)
            : base(options)
        {

        }

        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<AutoMake> AutoMakes { get; set; }
        public DbSet<AutoModel> AutoModels { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Image> Images { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleFeature>().HasKey(vehicleFeature =>
             new {vehicleFeature.VehicleId});
        }


    }
}
