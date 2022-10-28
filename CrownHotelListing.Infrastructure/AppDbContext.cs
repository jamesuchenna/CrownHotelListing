using CrownHotelListing.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrownHotelListing.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
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
            builder.Entity<Hotel>().HasData(
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
