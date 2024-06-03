using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CodeFirstDemo.Migrations
{
    /// <inheritdoc />
    public partial class addsamplesandfixdecimalformat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "PK_account", "email", "first_name", "last_name", "phone", "FK_role" },
                values: new object[,]
                {
                    { 1, "janek.janeczek@protonmail.com", "Janek", "Janeczek", "111111111", 1 },
                    { 2, "test.test@gmail.com", "test", "test", "222222222", 2 },
                    { 3, "wololo.wololo@gmail.com", "wololo", "wololo", "333333333", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "PK_account",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "PK_account",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "PK_account",
                keyValue: 3);
        }
    }
}
