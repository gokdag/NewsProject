using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsProject.Migrations
{
    public partial class ReportUpg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SourceUrl",
                table: "Reports",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SourceUrl",
                table: "Reports");
        }
    }
}
