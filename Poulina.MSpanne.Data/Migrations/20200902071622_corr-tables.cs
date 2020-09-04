using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Poulina.MSpanne.Data.Migrations
{
    public partial class corrtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "id_fournisseur",
                table: "Type_intervention");

            migrationBuilder.DropColumn(
                name: "matricule",
                table: "Type_intervention");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Type_intervention");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "id_fournisseur",
                table: "Type_intervention",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "matricule",
                table: "Type_intervention",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Type_intervention",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
