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

        public DbSet<Animal> Animals { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Animal>()
            .HasData(
                new Animal { AnimalId = 1, Name = "Jackie", Species = "Cat", Age = 5, Breed = "Siamese", Gender = "Female"},
                new Animal { AnimalId = 2, Name = "Buddy", Species = "Dog", Age = 10, Breed = "German Shephard", Gender = "Male"},
                new Animal { AnimalId = 3, Name = "Milo", Species = "Cat", Age = 1, Breed = "Orange Tabby", Gender = "Male"},
                new Animal { AnimalId = 4, Name = "Margo", Species = "Dog", Age = 2, Breed = "Siberian Husky", Gender = "Female"},
                new Animal { AnimalId = 5, Name = "Suzie", Species = "Dog", Age = 3, Breed = "Labrador", Gender = "Female"}
            );
        }
    }
}