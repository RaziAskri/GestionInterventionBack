using Microsoft.EntityFrameworkCore.Migrations;

namespace Poulina.MSpanne.Data.Migrations
{
    public partial class datefin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "dateFin",
                table: "Intervention",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "etatIntervention",
                table: "Intervention",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dateFin",
                table: "Intervention");

            migrationBuilder.DropColumn(
                name: "etatIntervention",
                table: "Intervention");
        }
    }
}
