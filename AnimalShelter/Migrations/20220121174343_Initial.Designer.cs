// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    [Migration("20220121174343_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AnimalShelter.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Gender")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Species")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 5,
                            Breed = "Siamese",
                            Gender = "Female",
                            Name = "Jackie",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 10,
                            Breed = "German Shephard",
                            Gender = "Male",
                            Name = "Buddy",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 1,
                            Breed = "Orange Tabby",
                            Gender = "Male",
                            Name = "Milo",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 2,
                            Breed = "Siberian Husky",
                            Gender = "Female",
                            Name = "Margo",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 3,
                            Breed = "Labrador",
                            Gender = "Female",
                            Name = "Suzie",
                            Species = "Dog"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
