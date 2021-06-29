using Microsoft.EntityFrameworkCore.Migrations;

namespace Camplify.Data.Migrations
{
    public partial class CategoryAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "DemageCategory");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "DemageCategory",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
