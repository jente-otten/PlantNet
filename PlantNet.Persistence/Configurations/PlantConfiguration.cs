using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlantNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantNet.Persistence.Configurations
{
    public class PlantConfiguration : IEntityTypeConfiguration<Plant>
    {
        public void Configure(EntityTypeBuilder<Plant> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.SpeciesId);
            builder.Property(x => x.LocationId);
                
        }
    }
}
