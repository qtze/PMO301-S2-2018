using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityMatchingWebsite.Migrations
{
    public partial class dataseed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "FirstName", "LegalSurname", "Surname" },
                values: new object[] { "29/02/2000", "James", "Franks", "Franks" });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "FirstName", "LegalSurname", "Surname" },
                values: new object[] { "23/11/1980", "Eric", "Harden", "Harden" });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateOfBirth", "FirstName", "LegalSurname", "Surname" },
                values: new object[] { "23/11/1980", "James", "Samson", "Samson" });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateOfBirth", "FirstName", "LegalSurname", "Surname" },
                values: new object[] { "16/08/1977", "Guy", "Hammer", "Hammer" });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "FirstName", "LegalSurname", "Surname" },
                values: new object[] { "Sam", "Swanson", "Swanson" });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateOfBirth", "FirstName", "Surname" },
                values: new object[] { "6/08/1977", "Sarah", "Morgan" });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateOfBirth", "FirstName", "LegalSurname", "Surname" },
                values: new object[] { "13/03/1966", "Hugh", "Mungus", "Mungus" });

            migrationBuilder.UpdateData(
                table: "PersonTwo",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "FirstName", "LegalSurname", "Surname" },
                values: new object[] { "	29/02/2000", "Sam", "Hammer", "Hammer" });

            migrationBuilder.UpdateData(
                table: "PersonTwo",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "FirstName", "LegalSurname", "Surname" },
                values: new object[] { "23/11/1989", "Joe", "Swanson", "Swanson" });

            migrationBuilder.UpdateData(
                table: "PersonTwo",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateOfBirth", "FirstName", "LegalSurname", "Surname" },
                values: new object[] { "23/11/1980", "Eric", "Jones", "Jones" });

            migrationBuilder.UpdateData(
                table: "PersonTwo",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateOfBirth", "FirstName" },
                values: new object[] { "16/08/1977", "Emily" });

            migrationBuilder.UpdateData(
                table: "PersonTwo",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "LegalSurname", "Surname" },
                values: new object[] { "Swanson", "Swanson" });

            migrationBuilder.UpdateData(
                table: "PersonTwo",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateOfBirth", "FirstName", "LegalSurname", "Surname" },
                values: new object[] { "23/11/1970", "Rebecca", "Mungus", "Ferguson" });

            migrationBuilder.UpdateData(
                table: "PersonTwo",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateOfBirth", "FirstName", "LegalSurname", "Surname" },
                values: new object[] { "16/08/1962", "Sarah", "Franks", "Harris" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "FirstName", "LegalSurname", "Surname" },
                values: new object[] { "13/03/1997", "Steve", "Smith", "Smith" });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "FirstName", "LegalSurname", "Surname" },
                values: new object[] { "13/03/1997", "Steve", "Smith", "Smith" });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateOfBirth", "FirstName", "LegalSurname", "Surname" },
                values: new object[] { "13/03/1997", "Steve", "Smith", "Smith" });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateOfBirth", "FirstName", "LegalSurname", "Surname" },
                values: new object[] { "13/03/1997", "Steve", "Smith", "Smith" });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "FirstName", "LegalSurname", "Surname" },
                values: new object[] { "Steve", "Smith", "Smith" });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateOfBirth", "FirstName", "Surname" },
                values: new object[] { "13/03/1997", "Steve", "Smith" });

            migrationBuilder.UpdateData(
                table: "Person",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateOfBirth", "FirstName", "LegalSurname", "Surname" },
                values: new object[] { "13/03/1997", "Steve", "Smith", "Smith" });

            migrationBuilder.UpdateData(
                table: "PersonTwo",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "FirstName", "LegalSurname", "Surname" },
                values: new object[] { "13/03/1997", "Steve", "Smith", "Smith" });

            migrationBuilder.UpdateData(
                table: "PersonTwo",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "FirstName", "LegalSurname", "Surname" },
                values: new object[] { "13/03/1997", "Steve", "Smith", "Smith" });

            migrationBuilder.UpdateData(
                table: "PersonTwo",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateOfBirth", "FirstName", "LegalSurname", "Surname" },
                values: new object[] { "13/03/1997", "Steve", "Smith", "Smith" });

            migrationBuilder.UpdateData(
                table: "PersonTwo",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateOfBirth", "FirstName" },
                values: new object[] { "13/03/1997", "Steve" });

            migrationBuilder.UpdateData(
                table: "PersonTwo",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "LegalSurname", "Surname" },
                values: new object[] { "Smith", "Smith" });

            migrationBuilder.UpdateData(
                table: "PersonTwo",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DateOfBirth", "FirstName", "LegalSurname", "Surname" },
                values: new object[] { "13/03/1997", "Steve", "Smith", "Smith" });

            migrationBuilder.UpdateData(
                table: "PersonTwo",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DateOfBirth", "FirstName", "LegalSurname", "Surname" },
                values: new object[] { "13/03/1997", "Steve", "Smith", "Smith" });
        }
    }
}
