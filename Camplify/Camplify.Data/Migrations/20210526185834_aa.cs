using Microsoft.EntityFrameworkCore.Migrations;

namespace Camplify.Data.Migrations
{
    public partial class aa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DemageCategory");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Checklist");

            migrationBuilder.AddColumn<int>(
                name: "ChecklistId",
                table: "Category",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Category_ChecklistId",
                table: "Category",
                column: "ChecklistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Checklist_ChecklistId",
                table: "Category",
                column: "ChecklistId",
                principalTable: "Checklist",
                principalColumn: "ChecklistId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Checklist_ChecklistId",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_ChecklistId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "ChecklistId",
                table: "Category");

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Checklist",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DemageCategory",
                columns: table => new
                {
                    DemageCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    ChecklistId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DemageCategory", x => x.DemageCategoryId);
                    table.ForeignKey(
                        name: "FK_DemageCategory_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DemageCategory_Checklist_ChecklistId",
                        column: x => x.ChecklistId,
                        principalTable: "Checklist",
                        principalColumn: "ChecklistId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DemageCategory_CategoryId",
                table: "DemageCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_DemageCategory_ChecklistId",
                table: "DemageCategory",
                column: "ChecklistId");
        }
    }
}
