using Microsoft.EntityFrameworkCore;

namespace AnimalShelterAPI.Models
{
    public class AnimalShelterAPIContext : DbContext
    {

        public DbSet<Animal> Animals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"server=localhost;user id=root;password=epicodus;port=3306;database=wildlife_park;");

        public AnimalShelterAPIContext(DbContextOptions options) : base(options)
        {

        }
        public AnimalShelterAPIContext()
        {

        }

    }
}