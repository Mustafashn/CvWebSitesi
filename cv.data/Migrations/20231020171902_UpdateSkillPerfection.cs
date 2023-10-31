using Microsoft.EntityFrameworkCore.Migrations;

namespace cv.data.Migrations
{
    public partial class UpdateSkillPerfection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Perfection",
                table: "Skills",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Perfection",
                table: "Skills");
        }
    }
}
