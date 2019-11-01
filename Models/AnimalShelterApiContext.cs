using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
    public class AnimalShelterApiContext : DbContext
    {
        public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Animal>()
              .HasData(
                  //new Animal { AnimalId = 1, Name = "Matilda", Species = "Woolly Mammoth", Age = 7, Gender = "Female" },
              );
        }

        public DbSet<Animal> Animals { get; set; }
    }
}