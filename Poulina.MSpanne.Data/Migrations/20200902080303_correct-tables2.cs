using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Poulina.MSpanne.Data.Migrations
{
    public partial class correcttables2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Externe",
                columns: table => new
                {
                    id_externe = table.Column<Guid>(nullable: false),
                    id_fournisseur = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Externe", x => x.id_externe);
                });

            migrationBuilder.CreateTable(
                name: "Interne",
                columns: table => new
                {
                    id_interne = table.Column<Guid>(nullable: false),
                    matricule = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interne", x => x.id_interne);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Externe");

            migrationBuilder.DropTable(
                name: "Interne");
        }
    }
}
