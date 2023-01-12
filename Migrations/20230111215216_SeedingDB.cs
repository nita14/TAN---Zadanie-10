using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentApp.Migrations
{
    public partial class SeedingDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Studies",
                columns: new[] { "IdStudy", "Name", "Type" },
                values: new object[] { 1, "S1", "S" });

            migrationBuilder.InsertData(
                table: "Studies",
                columns: new[] { "IdStudy", "Name", "Type" },
                values: new object[] { 2, "S2", "Z" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "IdStudent", "FirstName", "IndexNumber", "LastName", "StudyId", "StudyYear" },
                values: new object[] { 1, "A", "S11", "AA", 1, 1 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "IdStudent", "FirstName", "IndexNumber", "LastName", "StudyId", "StudyYear" },
                values: new object[] { 2, "B", "S12", "BB", 1, 2 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "IdStudent", "FirstName", "IndexNumber", "LastName", "StudyId", "StudyYear" },
                values: new object[] { 3, "C", "S13", "CC", 2, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "IdStudent",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "IdStudent",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "IdStudent",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Studies",
                keyColumn: "IdStudy",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Studies",
                keyColumn: "IdStudy",
                keyValue: 2);
        }
    }
}
