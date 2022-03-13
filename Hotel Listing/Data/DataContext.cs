using Hotel_Listing.DataEntity;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Listing.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Country> Countries { set; get; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country{
                    Id = 1,
                    Name ="India",
                    ShortName ="IN"
                },
                new Country
                {
                    Id = 2,
                    Name = "United Kingdom",
                    ShortName = "UK"
                },
                new Country
                {
                    Id = 3,
                    Name = "United States",
                    ShortName = "US"
                }
                );
            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Taj India",
                    Address ="test 1",
                    Rating=4.2,
                    CountryId=1
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Taj UK",
                    Address = "test 2",
                    Rating = 3.8,
                    CountryId = 2
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Taj US",
                    Address = "test 3",
                    Rating = 4.5,
                    CountryId = 3
                }
                );
        }
    }
}
