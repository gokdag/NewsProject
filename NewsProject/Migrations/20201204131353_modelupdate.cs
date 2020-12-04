using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsProject.Migrations
{
    public partial class modelupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IMageUrl",
                table: "Reports",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IMageUrl",
                table: "Reports");
        }
    }
}
