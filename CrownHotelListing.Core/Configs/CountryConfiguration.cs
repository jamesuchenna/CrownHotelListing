using CrownHotelListing.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrownHotelListing.Core.Configs
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
                new Country
                {
                    Id = 1,
                    Name = "Nigeria",
                    ShortName = "NGR"
                },
                new Country
                {
                    Id = 2,
                    Name = "Canada",
                    ShortName = "CAD"
                },
                new Country
                {
                    Id = 3,
                    Name = "United States of America",
                    ShortName = "USA"
                },
                new Country
                {
                    Id = 4,
                    Name = "England",
                    ShortName = "ENG"
                }
            );
        }
    }
}
