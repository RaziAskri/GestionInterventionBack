using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Poulina.MSpanne.Data.Migrations
{
    public partial class ajout_prior_idmach : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "priorité",
                table: "Type_panne",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "id_machine",
                table: "Panne",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "priorité",
                table: "Type_panne");

            migrationBuilder.DropColumn(
                name: "id_machine",
                table: "Panne");
        }
    }
}
