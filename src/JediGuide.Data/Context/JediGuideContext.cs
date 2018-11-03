using System.IO;
using JediGuide.Data.Mappings;
using JediGuide.Core.Entities;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace JediGuide.Data.Context
{
    public class JediGuideContext : DbContext
    {
        public DbSet<Planet> Planets { get; set; }

        public JediGuideContext() { }

        public JediGuideContext(DbContextOptions<JediGuideContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PlanetMap());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                optionsBuilder.UseMySql(config.GetConnectionString("JediGuideConn"));

            }
        }
    }
}