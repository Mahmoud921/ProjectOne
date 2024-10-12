using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Online.Migrations
{
    /// <inheritdoc />
    public partial class addLessonandHours : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Hours",
                table: "Courses",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "Lesson",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hours",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Lesson",
                table: "Courses");
        }
    }
}
