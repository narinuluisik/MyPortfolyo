using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPortfolyo.Migrations
{
    public partial class AddTitleAndUnitToDashboardMetrics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "DashboardMetrics",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "DashboardMetrics",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "DashboardMetrics");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "DashboardMetrics");
        }

    }
}
