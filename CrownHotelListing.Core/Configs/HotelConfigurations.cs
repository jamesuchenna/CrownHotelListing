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
    public class HotelConfigurations : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Diamond Image",
                    Address = "Alagbaka Akure",
                    CountryId = 1,
                    Rating = 3.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Royal",
                    Address = "Toronto district",
                    CountryId = 2,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Eagles",
                    Address = "Washington Avenue",
                    CountryId = 3,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 4,
                    Name = "Queen",
                    Address = "Burkingham lane",
                    CountryId = 4,
                    Rating = 4.7
                }
            );
        }
    }
}
