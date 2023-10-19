using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CollegeManagement.Migrations
{
    /// <inheritdoc />
    public partial class _6Migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseSubjects",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseSubjects", x => new { x.CourseId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_CourseSubjects_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseSubjects_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CourseSubjects",
                columns: new[] { "CourseId", "SubjectId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 6 },
                    { 2, 3 },
                    { 2, 5 },
                    { 2, 6 },
                    { 3, 1 },
                    { 3, 4 },
                    { 3, 7 },
                    { 4, 4 },
                    { 4, 6 },
                    { 4, 8 },
                    { 5, 5 },
                    { 5, 7 },
                    { 5, 9 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseSubjects_SubjectId",
                table: "CourseSubjects",
                column: "SubjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseSubjects");
        }
    }
}
