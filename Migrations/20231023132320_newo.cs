using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CollegeManagement.Migrations
{
    /// <inheritdoc />
    public partial class newo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_CourseId1",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_CourseId1",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CourseId1",
                table: "Students");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "Students",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "CourseId", "Name", "RegistrationNumber", "SubjectId" },
                values: new object[,]
                {
                    { 1, 19, 5, "Student 1", "REG001", null },
                    { 2, 24, 2, "Student 2", "REG002", null },
                    { 3, 24, 3, "Student 3", "REG003", null },
                    { 4, 20, 2, "Student 4", "REG004", null },
                    { 5, 20, 2, "Student 5", "REG005", null },
                    { 6, 24, 3, "Student 6", "REG006", null },
                    { 7, 21, 4, "Student 7", "REG007", null },
                    { 8, 24, 5, "Student 8", "REG008", null },
                    { 9, 22, 1, "Student 9", "REG009", null },
                    { 10, 20, 5, "Student 10", "REG010", null },
                    { 11, 19, 5, "Student 11", "REG011", null },
                    { 12, 22, 3, "Student 12", "REG012", null },
                    { 13, 23, 2, "Student 13", "REG013", null },
                    { 14, 20, 4, "Student 14", "REG014", null },
                    { 15, 24, 5, "Student 15", "REG015", null },
                    { 16, 24, 3, "Student 16", "REG016", null },
                    { 17, 22, 5, "Student 17", "REG017", null },
                    { 18, 21, 2, "Student 18", "REG018", null },
                    { 19, 20, 3, "Student 19", "REG019", null },
                    { 20, 18, 1, "Student 20", "REG020", null },
                    { 21, 23, 3, "Student 21", "REG021", null },
                    { 22, 18, 2, "Student 22", "REG022", null },
                    { 23, 23, 2, "Student 23", "REG023", null },
                    { 24, 19, 3, "Student 24", "REG024", null },
                    { 25, 24, 1, "Student 25", "REG025", null },
                    { 26, 18, 1, "Student 26", "REG026", null },
                    { 27, 20, 4, "Student 27", "REG027", null },
                    { 28, 20, 1, "Student 28", "REG028", null },
                    { 29, 21, 1, "Student 29", "REG029", null },
                    { 30, 22, 4, "Student 30", "REG030", null },
                    { 31, 19, 4, "Student 31", "REG031", null },
                    { 32, 20, 2, "Student 32", "REG032", null },
                    { 33, 18, 3, "Student 33", "REG033", null },
                    { 34, 20, 1, "Student 34", "REG034", null },
                    { 35, 23, 3, "Student 35", "REG035", null },
                    { 36, 23, 1, "Student 36", "REG036", null },
                    { 37, 18, 1, "Student 37", "REG037", null },
                    { 38, 20, 4, "Student 38", "REG038", null },
                    { 39, 24, 3, "Student 39", "REG039", null },
                    { 40, 22, 4, "Student 40", "REG040", null },
                    { 41, 20, 3, "Student 41", "REG041", null },
                    { 42, 19, 1, "Student 42", "REG042", null },
                    { 43, 19, 4, "Student 43", "REG043", null },
                    { 44, 24, 1, "Student 44", "REG044", null },
                    { 45, 24, 1, "Student 45", "REG045", null },
                    { 46, 20, 4, "Student 46", "REG046", null },
                    { 47, 20, 5, "Student 47", "REG047", null },
                    { 48, 18, 4, "Student 48", "REG048", null },
                    { 49, 22, 5, "Student 49", "REG049", null },
                    { 50, 22, 3, "Student 50", "REG050", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_CourseId",
                table: "Students",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_CourseId",
                table: "Students",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_CourseId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_CourseId",
                table: "Students");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.AlterColumn<string>(
                name: "CourseId",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CourseId1",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_CourseId1",
                table: "Students",
                column: "CourseId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_CourseId1",
                table: "Students",
                column: "CourseId1",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
