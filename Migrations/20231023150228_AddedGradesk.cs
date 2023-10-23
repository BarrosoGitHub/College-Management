using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CollegeManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddedGradesk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "CourseAverage",
                table: "Students",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Age", "CourseAverage", "CourseId", "Name" },
                values: new object[] { 23, 0m, 5, "Dr. Myriam Bayer II" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Age", "CourseAverage", "Name" },
                values: new object[] { 22, 0m, "Jasper Ondricka" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Age", "CourseAverage", "CourseId", "Name" },
                values: new object[] { 20, 0m, 4, "Chelsie Kovacek Jr." });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Age", "CourseAverage", "CourseId", "Name" },
                values: new object[] { 19, 0m, 1, "Lula Crooks" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Age", "CourseAverage", "CourseId", "Name" },
                values: new object[] { 21, 0m, 5, "Coleman Anderson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Age", "CourseAverage", "CourseId", "Name" },
                values: new object[] { 24, 0m, 3, "Nathan Walsh" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Age", "CourseAverage", "CourseId", "Name" },
                values: new object[] { 22, 0m, 4, "Dr. Maia Lukas Konopelski" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Age", "CourseAverage", "CourseId", "Name" },
                values: new object[] { 18, 0m, 5, "Lambert Ines Romaguera II" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CourseAverage", "CourseId", "Name" },
                values: new object[] { 0m, 1, "Lavinia Stroman" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Age", "CourseAverage", "CourseId", "Name" },
                values: new object[] { 20, 0m, 2, "Ora Buckridge" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CourseAverage", "CourseId", "Name" },
                values: new object[] { 0m, 1, "Prof. Aurelie Marco Klein" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Age", "CourseAverage", "CourseId", "Name" },
                values: new object[] { 19, 0m, 4, "Niko Langosh" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Age", "CourseAverage", "CourseId", "Name" },
                values: new object[] { 21, 0m, 1, "Lonie Hane" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Age", "CourseAverage", "CourseId", "Name" },
                values: new object[] { 23, 0m, 1, "Mr. Fletcher Roberts MD" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Age", "CourseAverage", "CourseId", "Name" },
                values: new object[] { 23, 0m, 4, "Rosendo Towne" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Age", "CourseAverage", "CourseId", "Name" },
                values: new object[] { 24, 0m, 3, "Rogelio Larson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Age", "CourseAverage", "CourseId", "Name" },
                values: new object[] { 19, 0m, 1, "Jeanie Jennings Graham DVM" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Age", "CourseAverage", "CourseId", "Name" },
                values: new object[] { 21, 0m, 3, "Mr. Lindsey Keenan Mayer DDS" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Age", "CourseAverage", "CourseId", "Name" },
                values: new object[] { 20, 0m, 1, "Marcelo Michale Labadie Jr." });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CourseAverage", "Name" },
                values: new object[] { 0m, "Jane Zieme" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Age", "CourseAverage", "Name" },
                values: new object[] { 20, 0m, "Edgar Glover Jr." });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Age", "CourseAverage", "CourseId", "Name" },
                values: new object[] { 20, 0m, 5, "Dominic Nikolaus DDS" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Age", "CourseAverage", "CourseId", "Name" },
                values: new object[] { 22, 0m, 4, "Everette Rempel" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Age", "CourseAverage", "Name" },
                values: new object[] { 21, 0m, "Jonathan Kuphal" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Age", "CourseAverage", "CourseId", "Name" },
                values: new object[] { 22, 0m, 5, "Dayne Oma Nikolaus Sr." });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Age", "CourseAverage", "CourseId", "Name" },
                values: new object[] { 22, 0m, 1, "Ms. Arnulfo Kamren Sporer" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Age", "CourseAverage", "Name" },
                values: new object[] { 18, 0m, "Dr. Jarrell Pfeffer" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Age", "CourseAverage", "CourseId", "Name" },
                values: new object[] { 20, 0m, 2, "Maudie Rempel" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Age", "CourseAverage", "CourseId", "Name" },
                values: new object[] { 24, 0m, 4, "Ms. Walter Nickolas Kshlerin" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Age", "CourseAverage", "CourseId", "Name" },
                values: new object[] { 24, 0m, 3, "Jace Brekke" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Age", "CourseAverage", "Name" },
                values: new object[] { 23, 0m, "Ottilie Bergstrom" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Age", "CourseAverage", "CourseId", "Name" },
                values: new object[] { 18, 0m, 5, "Lukas Hartmann" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Age", "CourseAverage", "Name" },
                values: new object[] { 21, 0m, "Miss Pablo Hyatt" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CourseAverage", "CourseId", "Name" },
                values: new object[] { 0m, 1, "Arlo Nienow" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Age", "CourseAverage", "Name" },
                values: new object[] { 20, 0m, "Julie Pagac" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Age", "CourseAverage", "CourseId", "Name" },
                values: new object[] { 18, 0m, 2, "Aurelia Langworth" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Age", "CourseAverage", "CourseId", "Name" },
                values: new object[] { 21, 0m, 4, "Santos Casper DDS" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Age", "CourseAverage", "CourseId", "Name" },
                values: new object[] { 24, 0m, 2, "Mr. Phoebe Oswald Becker" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CourseAverage", "CourseId", "Name" },
                values: new object[] { 0m, 4, "Katelin Hayes" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Age", "CourseAverage", "CourseId", "Name" },
                values: new object[] { 23, 0m, 5, "May Sibyl Price Sr." });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Age", "CourseAverage", "CourseId", "Name" },
                values: new object[] { 22, 0m, 3, "Velva Mayer" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Age", "CourseAverage", "CourseId", "Name" },
                values: new object[] { 21, 0m, 2, "Ivah Ritchie" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CourseAverage", "CourseId", "Name" },
                values: new object[] { 0m, 1, "Marion Aufderhar" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Age", "CourseAverage", "CourseId", "Name" },
                values: new object[] { 22, 0m, 1, "Miss Tod Beier" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Age", "CourseAverage", "CourseId", "Name" },
                values: new object[] { 24, 0m, 4, "Sophia Jeff Cole Jr." });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Age", "CourseAverage", "CourseId", "Name" },
                values: new object[] { 23, 0m, 3, "Caterina Bernhard" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Age", "CourseAverage", "CourseId", "Name" },
                values: new object[] { 19, 0m, 3, "Theresia Schamberger V" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Age", "CourseAverage", "CourseId", "Name" },
                values: new object[] { 21, 0m, 2, "Judge Wintheiser" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Age", "CourseAverage", "CourseId", "Name" },
                values: new object[] { 20, 0m, 2, "Rebecca King" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Age", "CourseAverage", "Name" },
                values: new object[] { 18, 0m, "Ms. Jailyn Lloyd Sawayn V" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseAverage",
                table: "Students");

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
                columns: new[] { "Age", "Name" },
                values: new object[] { 24, "Mr. Willy Pfeffer" });

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
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 24, 2, "Mrs. Derrick O'Keefe" });

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
                columns: new[] { "CourseId", "Name" },
                values: new object[] { 2, "Verner Bruen" });

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
                columns: new[] { "CourseId", "Name" },
                values: new object[] { 4, "Dr. Jevon Bradtke Jr." });

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
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 20, 2, "Miss Ezequiel Legros Sr." });

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
                column: "Name",
                value: "Mr. Violet Wisozk MD");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Age", "Name" },
                values: new object[] { 19, "Aracely Schowalter" });

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
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 23, 1, "Kenna Goyette" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Age", "Name" },
                values: new object[] { 23, "Dr. Ralph Schinner" });

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
                columns: new[] { "Age", "Name" },
                values: new object[] { 20, "Heidi Olson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 23, 1, "Bulah Batz DDS" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 21, 5, "Emory Bosco" });

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
                columns: new[] { "Age", "Name" },
                values: new object[] { 19, "Marguerite Kihn" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 20, 4, "Kaia Carson Ortiz II" });

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
                columns: new[] { "CourseId", "Name" },
                values: new object[] { 2, "Ms. Baylee Priscilla Ondricka II" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Age", "Name" },
                values: new object[] { 23, "Ms. Ed Adalberto Jacobson" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 22, 1, "Lavada Crist" });

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
                columns: new[] { "CourseId", "Name" },
                values: new object[] { 2, "Larry Johnston" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 21, 4, "Antonetta Schinner" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Age", "CourseId", "Name" },
                values: new object[] { 20, 5, "Prof. Araceli Major Hoeger II" });

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
                columns: new[] { "CourseId", "Name" },
                values: new object[] { 2, "Dr. Burley Cayla Bauch IV" });

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
                columns: new[] { "Age", "Name" },
                values: new object[] { 23, "Ms. Jacinto Mossie Schroeder IV" });
        }
    }
}
