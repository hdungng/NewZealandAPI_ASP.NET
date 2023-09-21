using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> dbContextOptions) : base(dbContextOptions)
        { }

        public DbSet<Difficulty> Difficulties { get; set; }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Walk> Walks { get; set; }

        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed the data for Difficulty
            // Easy/ Medium / Hard
            var difficulties = new List<Difficulty>()
            {
                new Difficulty()
                {
                    Id = Guid.Parse("85a475dc-7179-4e62-87e4-97e50846089c"),
                    Name = "Easy"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("62880fd8-c0eb-4af8-8313-43dcb87581ae"),
                    Name = "Medium"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("b5e79ee9-126d-421d-beda-4764b359fff6"),
                    Name = "Hard"
                }
            };

            // Seed difficulties to the database
            modelBuilder.Entity<Difficulty>().HasData(difficulties);


            // Seed data for Region
            var regions = new List<Region>
            {
                new Region()
                {
                    Id = Guid.Parse("47f44064-be12-464b-a4d6-bd64fba761f5"),
                    Name = "Auckland",
                    Code = "AKL",
                    RegionImageUrl = "https://a.cdn-hotels.com/gdcs/production133/d294/4e4195aa-b9ca-42cd-923f-e8a65c8c5c7b.jpg?impolicy=fcrop&w=800&h=533&q=medium"
                },
                new Region()
                {
                    Id = Guid.Parse("365c016a-8771-47bc-a434-6b75946f985b"),
                    Name = "Wellington",
                    Code = "WGN",
                    RegionImageUrl = "https://tec.edu.vn/wp-content/uploads/2022/12/179180-Wellington.jpg"
                },
                new Region()
                {
                    Id = Guid.Parse("488ccb62-37a8-4e23-88bc-4ba742cb53dd"),
                    Name = "Nelson",
                    Code = "NSN",
                    RegionImageUrl = "https://d27k8xmh3cuzik.cloudfront.net/wp-content/uploads/2018/11/Places-to-Visit-in-Nelson-OG-min.jpg"
                },
                new Region()
                {
                    Id = Guid.Parse("c9eeb2a5-5f77-47a8-8625-907d7921d763"),
                    Name = "Southland",
                    Code = "NSN",
                    RegionImageUrl = "https://www.newzealand.com/assets/Tourism-NZ/Other/img-1536012255-9458-6899-2653996258_835f78284f_o__aWxvdmVrZWxseQo_CropResizeWzEyMDAsNjMwLDc1LCJqcGciXQ.jpg"
                },
            };

            modelBuilder.Entity<Region>().HasData(regions);
        }
    }
}
