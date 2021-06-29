using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Camplify.Data.Migrations
{
    public partial class CheckListAddedd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ChecklistId",
                table: "Photo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Checklist",
                columns: table => new
                {
                    ChecklistId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDemage = table.Column<bool>(type: "bit", nullable: false),
                    MyProperty = table.Column<int>(type: "int", nullable: false),
                    DemageDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DemageOccurDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checklist", x => x.ChecklistId);
                });

            migrationBuilder.CreateTable(
                name: "DemageCategory",
                columns: table => new
                {
                    DemageCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChecklistId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DemageCategory", x => x.DemageCategoryId);
                    table.ForeignKey(
                        name: "FK_DemageCategory_Checklist_ChecklistId",
                        column: x => x.ChecklistId,
                        principalTable: "Checklist",
                        principalColumn: "ChecklistId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photo_ChecklistId",
                table: "Photo",
                column: "ChecklistId");

            migrationBuilder.CreateIndex(
                name: "IX_DemageCategory_ChecklistId",
                table: "DemageCategory",
                column: "ChecklistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Checklist_ChecklistId",
                table: "Photo",
                column: "ChecklistId",
                principalTable: "Checklist",
                principalColumn: "ChecklistId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Checklist_ChecklistId",
                table: "Photo");

            migrationBuilder.DropTable(
                name: "DemageCategory");

            migrationBuilder.DropTable(
                name: "Checklist");

            migrationBuilder.DropIndex(
                name: "IX_Photo_ChecklistId",
                table: "Photo");

            migrationBuilder.DropColumn(
                name: "ChecklistId",
                table: "Photo");
        }
    }
}
