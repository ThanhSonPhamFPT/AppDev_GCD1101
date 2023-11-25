using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookShopWeb.Migrations
{
    /// <inheritdoc />
    public partial class seedingBookTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Microsoft", 1, "Basic start", 10.0, "Programming" },
                    { 2, "BTEC", 2, "Enhancing", 14.0, "Advanced Programming" },
                    { 3, "Greenwich", 3, "Not easy", 15.0, "Data Structures" },
                    { 4, "Microsoft", 4, "Full Application", 20.0, "App Dev" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
