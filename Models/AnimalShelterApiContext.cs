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
              new Animal { AnimalId = 1, Name = "Bob", Taxonomy = "Dog", Breed = "Golden Retriever", Age = 7, Gender = "Male", IsFixed = true },
              new Animal { AnimalId = 2, Name = "Fred", Taxonomy = "Dog", Breed = "Labrador", Age = 2, Gender = "Male", IsFixed = false },
              new Animal { AnimalId = 3, Name = "Sally", Taxonomy = "Cat", Breed = "Tuxedo", Age = 2, Gender = "Female", IsFixed = false }
              );
        }

        public DbSet<Animal> Animals { get; set; }
    }
}
