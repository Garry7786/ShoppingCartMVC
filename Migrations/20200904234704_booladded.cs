using Microsoft.EntityFrameworkCore.Migrations;

namespace ShoppingCartMVCProject.Migrations
{
    public partial class booladded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isFreeThisWeek",
                table: "Courses",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isFreeThisWeek",
                table: "Courses");
        }
    }
}
