using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelterApi.Migrations
{
    public partial class TestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Breed", "Gender", "IsFixed", "Name", "Taxonomy" },
                values: new object[,]
                {
                    { 4, 11, "Poodle", "Male", true, "Oliver", "Dog" },
                    { 5, 5, "Pomeranian", "Female", true, "Lola", "Dog" },
                    { 6, 2, "Tuxedo", "Male", true, "Bruce", "Cat" },
                    { 7, 200, "Humpback", "Male", false, "Jay", "Whale" },
                    { 8, 30, "Orangutan", "Male", false, "Chad", "Great Ape" },
                    { 9, 7, "Weasel", "Male", true, "Rich", "Mustelidae" },
                    { 10, 8, "Bullfrog", "Male", false, "Xyronic", "Frog" },
                    { 11, 31, "Elephant Seal", "Male", false, "Conway", "Seal" },
                    { 12, 28, "Silverback", "Male", false, "Derrick", "Gorilla" },
                    { 13, 25, "Pangolin", "Male", true, "Jon", "Manidae" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 13);
        }
    }
}
