using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CollegeManagement.Migrations
{
    /// <inheritdoc />
    public partial class _4Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Electrical Engineering" },
                    { 2, "Computer Science" },
                    { 3, "Mechanical Engineering" },
                    { 4, "Civil Engineering" },
                    { 5, "Chemical Engineering" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "ProfessorId" },
                values: new object[,]
                {
                    { 1, "Mathematics", 10 },
                    { 2, "Physics", 2 },
                    { 3, "Computer Science", 1 },
                    { 4, "Mechanics", 3 },
                    { 5, "Chemistry", 6 },
                    { 6, "Logic Systems", 7 },
                    { 7, "Termodynamics", 8 },
                    { 8, "Economy", 9 },
                    { 9, "Probability", 4 },
                    { 10, "Programming", 5 }
                });
        }
    }
}
