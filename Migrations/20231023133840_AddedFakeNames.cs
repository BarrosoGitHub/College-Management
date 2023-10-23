using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CollegeManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddedFakeNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 20, 2, "Yesenia Konopelski" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Mr. Willy Pfeffer");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 23, 1, "Prof. Kelsie Kirlin" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 18, 3, "Ms. Avis Murray I" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "Name" },
                values: new object[] { 24, "Mrs. Derrick O'Keefe" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 18, 5, "Ethan Bartoletti III" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 18, 3, "Matt Swift" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 21, 2, "Elissa Wolf" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 23, 2, "Verner Bruen" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 19, 3, "Matteo Smitham" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 20, 4, "Dr. Jevon Bradtke Jr." });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 18, 2, "Lucie Wilfredo Greenfelder V" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 24, 5, "Ms. Aiyana Katelin Beatty III" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 19, 3, "Prof. Terence Homenick DVM" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 19, 2, "Osvaldo Kiehn" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 21, 2, "Abbigail Johnson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 20, 4, "Toni Johnston" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Age", "Name" },
                values: new object[] { 20, "Miss Ezequiel Legros Sr." });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 19, 4, "Magdalen Ziemann" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 22, 2, "Mr. Violet Wisozk MD" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 19, 5, "Aracely Schowalter" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 22, 3, "Gerhard Gorczany" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CourseId", "Name" },
                values: new object[] { 1, "Kenna Goyette" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 23, 5, "Dr. Ralph Schinner" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 19, 3, "Henri Denesik" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 24, 2, "Lavern Kling" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CourseId", "Name" },
                values: new object[] { 5, "Heidi Olson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Age", "Name" },
                values: new object[] { 23, "Bulah Batz DDS" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CourseId", "Name" },
                values: new object[] { 5, "Emory Bosco" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 23, 1, "Maud Streich V" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CourseId", "Name" },
                values: new object[] { 5, "Marguerite Kihn" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CourseId", "Name" },
                values: new object[] { 4, "Kaia Carson Ortiz II" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Age", "Name" },
                values: new object[] { 19, "Prof. Antwon Gus Hessel" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 24, 2, "Ms. Baylee Priscilla Ondricka II" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 35,
                column: "Name",
                value: "Ms. Ed Adalberto Jacobson");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Age", "Name" },
                values: new object[] { 22, "Lavada Crist" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 23, 3, "Bell Nolan" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 23, 5, "Antwon Graham MD" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 19, 2, "Larry Johnston" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Age", "Name" },
                values: new object[] { 21, "Antonetta Schinner" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CourseId", "Name" },
                values: new object[] { 5, "Prof. Araceli Major Hoeger II" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 24, 4, "Prof. Adonis Kerluke" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 20, 2, "Dr. Burley Cayla Bauch IV" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 20, 4, "Ms. Estefania Macejkovic" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 18, 5, "Miss Chandler Chris Leannon III" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 21, 1, "Prof. Madonna Mary Hartmann" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 18, 1, "Cierra Welch" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 20, 3, "Miss Olin Crona MD" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 23, 3, "Zella Sporer" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 23, 5, "Ms. Jacinto Mossie Schroeder IV" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 19, 5, "Student 1" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Student 2");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 24, 3, "Student 3" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 20, 2, "Student 4" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "Name" },
                values: new object[] { 20, "Student 5" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 24, 3, "Student 6" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 21, 4, "Student 7" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 24, 5, "Student 8" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 22, 1, "Student 9" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 20, 5, "Student 10" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 19, 5, "Student 11" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 22, 3, "Student 12" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 23, 2, "Student 13" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 20, 4, "Student 14" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 24, 5, "Student 15" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 24, 3, "Student 16" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 22, 5, "Student 17" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Age", "Name" },
                values: new object[] { 21, "Student 18" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 20, 3, "Student 19" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 18, 1, "Student 20" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 23, 3, "Student 21" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 18, 2, "Student 22" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CourseId", "Name" },
                values: new object[] { 2, "Student 23" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 19, 3, "Student 24" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 24, 1, "Student 25" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 18, 1, "Student 26" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CourseId", "Name" },
                values: new object[] { 4, "Student 27" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Age", "Name" },
                values: new object[] { 20, "Student 28" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CourseId", "Name" },
                values: new object[] { 1, "Student 29" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 22, 4, "Student 30" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CourseId", "Name" },
                values: new object[] { 4, "Student 31" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CourseId", "Name" },
                values: new object[] { 2, "Student 32" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Age", "Name" },
                values: new object[] { 18, "Student 33" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 20, 1, "Student 34" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 35,
                column: "Name",
                value: "Student 35");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Age", "Name" },
                values: new object[] { 23, "Student 36" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 18, 1, "Student 37" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 20, 4, "Student 38" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 24, 3, "Student 39" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Age", "Name" },
                values: new object[] { 22, "Student 40" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CourseId", "Name" },
                values: new object[] { 3, "Student 41" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 19, 1, "Student 42" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 19, 4, "Student 43" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 24, 1, "Student 44" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 24, 1, "Student 45" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 20, 4, "Student 46" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 20, 5, "Student 47" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 18, 4, "Student 48" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 22, 5, "Student 49" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 22, 3, "Student 50" });
        }
    }
}
