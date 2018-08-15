using JediGuide.Models.Entities;
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
        }
    }
}