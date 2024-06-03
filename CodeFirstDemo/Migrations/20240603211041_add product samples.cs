using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeFirstDemo.Migrations
{
    /// <inheritdoc />
    public partial class addproductsamples : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "PK_product", "depth", "height", "name", "weight", "width" },
                values: new object[,]
                {
                    { 1, 1.4m, 1.3m, "test31", 0m, 2.2m },
                    { 2, 1.3m, 1.1m, "test1", 0m, 2.1m },
                    { 3, 1.8m, 1.9m, "test3", 0m, 2.0m },
                    { 4, 1.6m, 7.1m, "test4", 0m, 2.1m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "PK_product",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "PK_product",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "PK_product",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "PK_product",
                keyValue: 4);
        }
    }
}
