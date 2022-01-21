using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Species = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Breed = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Gender = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Breed", "Gender", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 5, "Siamese", "Female", "Jackie", "Cat" },
                    { 2, 10, "German Shephard", "Male", "Buddy", "Dog" },
                    { 3, 1, "Orange Tabby", "Male", "Milo", "Cat" },
                    { 4, 2, "Siberian Husky", "Female", "Margo", "Dog" },
                    { 5, 3, "Labrador", "Female", "Suzie", "Dog" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
