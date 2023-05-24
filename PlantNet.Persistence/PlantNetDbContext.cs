using Microsoft.EntityFrameworkCore;
using PlantNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantNet.Persistence
{
    public class PlantNetDbContext : DbContext
    {
        public PlantNetDbContext(DbContextOptions<PlantNetDbContext> options) : base(options)
        {

        }

        public DbSet<Species> Species { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Plant> Plants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PlantNetDbContext).Assembly);
        }
    }
}
