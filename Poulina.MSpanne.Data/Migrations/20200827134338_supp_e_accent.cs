using Microsoft.EntityFrameworkCore.Migrations;

namespace Poulina.MSpanne.Data.Migrations
{
    public partial class supp_e_accent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "priorité",
                table: "Type_panne");

            migrationBuilder.DropColumn(
                name: "état_intervention",
                table: "Type_intervention");

            migrationBuilder.DropColumn(
                name: "état_panne",
                table: "Panne");

            migrationBuilder.AddColumn<int>(
                name: "priorite",
                table: "Type_panne",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "etat_intervention",
                table: "Type_intervention",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "etat_panne",
                table: "Panne",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "priorite",
                table: "Type_panne");

            migrationBuilder.DropColumn(
                name: "etat_intervention",
                table: "Type_intervention");

            migrationBuilder.DropColumn(
                name: "etat_panne",
                table: "Panne");

            migrationBuilder.AddColumn<int>(
                name: "priorité",
                table: "Type_panne",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "état_intervention",
                table: "Type_intervention",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "état_panne",
                table: "Panne",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
