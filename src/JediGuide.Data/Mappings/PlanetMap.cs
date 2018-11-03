using JediGuide.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JediGuide.Data.Mappings
{
    public class PlanetMap : IEntityTypeConfiguration<Planet>
    {
        public void Configure(EntityTypeBuilder<Planet> builder)
        {
            builder.ToTable("Planet");

            builder.HasKey(x=> x.Id);

            builder.Property(x => x.Name)
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(x => x.Terrain)
                .HasMaxLength(255)
                .IsRequired();
            
            builder.Property(x => x.Wheater)
                .HasMaxLength(255)
                .IsRequired();
        }
    }
}