using Microsoft.EntityFrameworkCore.Migrations;

namespace Camplify.Data.Migrations
{
    public partial class photoUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Checklist_ChecklistId",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Checklist_ChecklistId",
                table: "Photo");

            migrationBuilder.DropIndex(
                name: "IX_Category_ChecklistId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "IncidentID",
                table: "Photo");

            migrationBuilder.DropColumn(
                name: "ChecklistId",
                table: "Category");

            migrationBuilder.AlterColumn<int>(
                name: "ChecklistId",
                table: "Photo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DemageCategory_ChecklistId",
                table: "DemageCategory",
                column: "ChecklistId");

            migrationBuilder.AddForeignKey(
                name: "FK_DemageCategory_Checklist_ChecklistId",
                table: "DemageCategory",
                column: "ChecklistId",
                principalTable: "Checklist",
                principalColumn: "ChecklistId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Checklist_ChecklistId",
                table: "Photo",
                column: "ChecklistId",
                principalTable: "Checklist",
                principalColumn: "ChecklistId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DemageCategory_Checklist_ChecklistId",
                table: "DemageCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Checklist_ChecklistId",
                table: "Photo");

            migrationBuilder.DropIndex(
                name: "IX_DemageCategory_ChecklistId",
                table: "DemageCategory");

            migrationBuilder.AlterColumn<int>(
                name: "ChecklistId",
                table: "Photo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "IncidentID",
                table: "Photo",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Checklist_ChecklistId",
                table: "Photo",
                column: "ChecklistId",
                principalTable: "Checklist",
                principalColumn: "ChecklistId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
