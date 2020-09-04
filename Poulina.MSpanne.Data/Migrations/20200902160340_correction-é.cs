using Microsoft.EntityFrameworkCore.Migrations;

namespace Poulina.MSpanne.Data.Migrations
{
    public partial class correctioné : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "durée",
                table: "Intervention");

            migrationBuilder.AddColumn<string>(
                name: "duree",
                table: "Intervention",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "duree",
                table: "Intervention");

            migrationBuilder.AddColumn<string>(
                name: "durée",
                table: "Intervention",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
