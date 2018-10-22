using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityMatchingWebsite.Migrations
{
    public partial class dataseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "ID", "DateOfBirth", "FirstName", "LegalSurname", "Surname" },
                values: new object[,]
                {
                    { 1, "13/03/1997", "Steve", "Smith", "Smith" },
                    { 2, "13/03/1997", "Steve", "Smith", "Smith" },
                    { 3, "13/03/1997", "Steve", "Smith", "Smith" },
                    { 4, "13/03/1997", "Steve", "Smith", "Smith" },
                    { 5, "13/03/1997", "Steve", "Smith", "Smith" },
                    { 6, "13/03/1997", "Steve", "Smith", "Smith" },
                    { 7, "13/03/1997", "Steve", "Smith", "Smith" },
                    { 8, "13/03/1997", "Steve", "Smith", "Smith" }
                });

            migrationBuilder.InsertData(
                table: "PersonTwo",
                columns: new[] { "ID", "DateOfBirth", "FirstName", "LegalSurname", "Surname" },
                values: new object[,]
                {
                    { 1, "13/03/1997", "Steve", "Smith", "Smith" },
                    { 2, "13/03/1997", "Steve", "Smith", "Smith" },
                    { 3, "13/03/1997", "Steve", "Smith", "Smith" },
                    { 4, "13/03/1997", "Steve", "Smith", "Smith" },
                    { 5, "13/03/1997", "Steve", "Smith", "Smith" },
                    { 6, "13/03/1997", "Steve", "Smith", "Smith" },
                    { 7, "13/03/1997", "Steve", "Smith", "Smith" },
                    { 8, "13/03/1997", "Steve", "Smith", "Smith" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PersonTwo",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PersonTwo",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PersonTwo",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PersonTwo",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PersonTwo",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PersonTwo",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PersonTwo",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PersonTwo",
                keyColumn: "ID",
                keyValue: 8);
        }
    }
}
