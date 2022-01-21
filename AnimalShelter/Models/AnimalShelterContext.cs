// using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : DbContext
    {
        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
            : base(options)
        {
        }

        public DbSet<AdoptAnimal> AdoptAnimals { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AdoptAnimal>()
            .HasData(
                new AdoptAnimal { AnimalId = 1, Name = "Jackie", Species = "Cat", Age = 5, Breed = "Siamese", Gender = "Female"},
                new AdoptAnimal { AnimalId = 2, Name = "Buddy", Species = "Dog", Age = 10, Breed = "German Shephard", Gender = "Male"},
                new AdoptAnimal { AnimalId = 3, Name = "Milo", Species = "Cat", Age = 1, Breed = "Orange Tabby", Gender = "Male"},
                new AdoptAnimal { AnimalId = 4, Name = "Margo", Species = "Dog", Age = 2, Breed = "Siberian Husky", Gender = "Female"},
                new AdoptAnimal { AnimalId = 5, Name = "Suzie", Species = "Dog", Age = 3, Breed = "Labrador", Gender = "Female"}
            );
        }
    }
}