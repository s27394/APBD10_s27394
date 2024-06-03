using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeFirstDemo.Migrations
{
    /// <inheritdoc />
    public partial class addtherestofthesamples : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "PK_category", "name" },
                values: new object[,]
                {
                    { 1, "TestCat1" },
                    { 2, "TestCat2" },
                    { 3, "TestCat3" }
                });

            migrationBuilder.InsertData(
                table: "Shopping_Carts",
                columns: new[] { "FK_account", "FK_product", "amount" },
                values: new object[,]
                {
                    { 1, 1, 13 },
                    { 2, 3, 2 },
                    { 3, 2, 5 }
                });

            migrationBuilder.InsertData(
                table: "Products_Categories",
                columns: new[] { "FK_category", "FK_product" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products_Categories",
                keyColumns: new[] { "FK_category", "FK_product" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Products_Categories",
                keyColumns: new[] { "FK_category", "FK_product" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Products_Categories",
                keyColumns: new[] { "FK_category", "FK_product" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Shopping_Carts",
                keyColumns: new[] { "FK_account", "FK_product" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Shopping_Carts",
                keyColumns: new[] { "FK_account", "FK_product" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Shopping_Carts",
                keyColumns: new[] { "FK_account", "FK_product" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "PK_category",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "PK_category",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "PK_category",
                keyValue: 3);
        }
    }
}
