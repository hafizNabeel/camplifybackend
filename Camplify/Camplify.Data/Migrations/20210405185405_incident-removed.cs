using Microsoft.EntityFrameworkCore.Migrations;

namespace Camplify.Data.Migrations
{
    public partial class incidentremoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Incident_IncidentId",
                table: "Vehicle");

            migrationBuilder.DropTable(
                name: "Incident");

            migrationBuilder.DropIndex(
                name: "IX_Vehicle_IncidentId",
                table: "Vehicle");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Incident",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Awning = table.Column<bool>(type: "bit", nullable: false),
                    Cleaning = table.Column<bool>(type: "bit", nullable: false),
                    DamageOccured = table.Column<bool>(type: "bit", nullable: false),
                    DatesOfIncident = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExternalFixture = table.Column<bool>(type: "bit", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MechanicId = table.Column<int>(type: "int", nullable: false),
                    Refuelling = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tolls = table.Column<bool>(type: "bit", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incident", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_IncidentId",
                table: "Vehicle",
                column: "IncidentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Incident_IncidentId",
                table: "Vehicle",
                column: "IncidentId",
                principalTable: "Incident",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
