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
              new Animal { AnimalId = 4, Name = "Oliver", Taxonomy = "Dog", Breed = "Poodle", Age = 11, Gender = "Male", IsFixed = true }
              new Animal { AnimalId = 5, Name = "Lola", Taxonomy = "Dog", Breed = "Pomeranian", Age = 5, Gender = "Female", IsFixed = true }
              new Animal { AnimalId = 6, Name = "Bruce", Taxonomy = "Cat", Breed = "Tuxedo", Age = 2, Gender = "Male", IsFixed = true }
              new Animal { AnimalId = 7, Name = "Jay", Taxonomy = "Whale", Breed = "Humpback", Age = 200, Gender = "Male", IsFixed = false }
              new Animal { AnimalId = 8, Name = "Chad", Taxonomy = "Great Ape", Breed = "Orangutan", Age = 30, Gender = "Male", IsFixed = false }
              new Animal { AnimalId = 9, Name = "Rich", Taxonomy = "Mustelidae", Breed = "Weasel", Age = 7, Gender = "Male", IsFixed = true }
              new Animal { AnimalId = 10, Name = "Xyronic", Taxonomy = "Frog", Breed = "Bullfrog", Age = 8, Gender = "Male", IsFixed = false }
              new Animal { AnimalId = 11, Name = "Conway", Taxonomy = "Seal", Breed = "Elephant Seal", Age = 31, Gender = "Male", IsFixed = false }
              new Animal { AnimalId = 12, Name = "Derrick", Taxonomy = "Gorilla", Breed = "Silverback", Age = 28, Gender = "Male", IsFixed = false }
              new Animal { AnimalId = 13, Name = "Jon", Taxonomy = "Manidae", Breed = "Pangolin", Age = 25, Gender = "Male", IsFixed = true }
              );
        }

        public DbSet<Animal> Animals { get; set; }
    }
}
