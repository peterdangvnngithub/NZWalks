using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext: DbContext
    {
        public NZWalksDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) {

        }

        public DbSet<Difficulty> Difficulties { get; set; }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Walk> Walks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for Difficulties
            // Easy, Medium, Hard

            var dificulties = new List<Difficulty>()
            {
                new Difficulty()
                {
                    Id = Guid.Parse("345E77A3-6EBA-40D2-BB34-C34BDFC911AE"),
                    Name = "Easy"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("382AC86B-D290-44CD-8DFA-681DE06B3EAF"),
                    Name = "Medium"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("2B7EF3E5-2A5E-4F63-8E06-1ADCC0833591"),
                    Name = "Hard"
                }
            };

            //Seed difficulties to the database
            modelBuilder.Entity<Difficulty>().HasData(dificulties);

            // Seed data for Regions
            var regions = new List<Region>
            {
                new Region()
                {
                    Id = Guid.Parse($"{Guid.NewGuid().ToString()}"),
                    Name = "Auckland",
                    Code = "AKL",
                    RegionImageUrl = "https://c8.alamy.com/comp/P26WFD/auckland-new-zealand-line-icon-with-red-ribbon-isolated-on-white-auckland-landmark-emblem-print-label-symbol-auckland-tv-tower-pictogram-w-P26WFD.jpg"
                },
                new Region()
                {
                    Id = Guid.Parse($"{Guid.NewGuid().ToString()}"),
                    Name = "Wellington Region",
                    Code = "WLG",
                    RegionImageUrl = "https://www.shutterstock.com/image-vector/wellington-new-zealand-flat-icon-250nw-742465774.jpg"
                }
            };

            modelBuilder.Entity<Region>().HasData(regions);
        }
    }
}
