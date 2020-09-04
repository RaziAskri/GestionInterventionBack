using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Poulina.MSpanne.Data.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Panne",
                columns: table => new
                {
                    id_panne = table.Column<Guid>(nullable: false),
                    état_panne = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    id_type_panne = table.Column<Guid>(nullable: false),
                    Interventionid_intervention = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Panne", x => x.id_panne);
                });

            migrationBuilder.CreateTable(
                name: "Type_panne",
                columns: table => new
                {
                    id_type_panne = table.Column<Guid>(nullable: false),
                    label = table.Column<string>(nullable: true),
                    Panneid_panne = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type_panne", x => x.id_type_panne);
                    table.ForeignKey(
                        name: "FK_Type_panne_Panne_Panneid_panne",
                        column: x => x.Panneid_panne,
                        principalTable: "Panne",
                        principalColumn: "id_panne",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Type_intervention",
                columns: table => new
                {
                    id_type_intervention = table.Column<Guid>(nullable: false),
                    état_intervention = table.Column<string>(nullable: true),
                    type_intervention = table.Column<string>(nullable: true),
                    Interventionid_intervention = table.Column<Guid>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    id_fournisseur = table.Column<Guid>(nullable: true),
                    matricule = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Type_intervention", x => x.id_type_intervention);
                });

            migrationBuilder.CreateTable(
                name: "Intervention",
                columns: table => new
                {
                    id_intervention = table.Column<Guid>(nullable: false),
                    date_intervention = table.Column<string>(nullable: true),
                    description_intervention = table.Column<string>(nullable: true),
                    id_panne = table.Column<Guid>(nullable: false),
                    Panneid_panne = table.Column<Guid>(nullable: true),
                    type_intervention = table.Column<Guid>(nullable: false),
                    Type_interventionid_type_intervention = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intervention", x => x.id_intervention);
                    table.ForeignKey(
                        name: "FK_Intervention_Panne_Panneid_panne",
                        column: x => x.Panneid_panne,
                        principalTable: "Panne",
                        principalColumn: "id_panne",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Intervention_Type_intervention_Type_interventionid_type_intervention",
                        column: x => x.Type_interventionid_type_intervention,
                        principalTable: "Type_intervention",
                        principalColumn: "id_type_intervention",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Intervention_Panneid_panne",
                table: "Intervention",
                column: "Panneid_panne");

            migrationBuilder.CreateIndex(
                name: "IX_Intervention_Type_interventionid_type_intervention",
                table: "Intervention",
                column: "Type_interventionid_type_intervention");

            migrationBuilder.CreateIndex(
                name: "IX_Panne_Interventionid_intervention",
                table: "Panne",
                column: "Interventionid_intervention");

            migrationBuilder.CreateIndex(
                name: "IX_Type_intervention_Interventionid_intervention",
                table: "Type_intervention",
                column: "Interventionid_intervention");

            migrationBuilder.CreateIndex(
                name: "IX_Type_panne_Panneid_panne",
                table: "Type_panne",
                column: "Panneid_panne");

            migrationBuilder.AddForeignKey(
                name: "FK_Panne_Intervention_Interventionid_intervention",
                table: "Panne",
                column: "Interventionid_intervention",
                principalTable: "Intervention",
                principalColumn: "id_intervention",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Type_intervention_Intervention_Interventionid_intervention",
                table: "Type_intervention",
                column: "Interventionid_intervention",
                principalTable: "Intervention",
                principalColumn: "id_intervention",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Intervention_Panne_Panneid_panne",
                table: "Intervention");

            migrationBuilder.DropForeignKey(
                name: "FK_Intervention_Type_intervention_Type_interventionid_type_intervention",
                table: "Intervention");

            migrationBuilder.DropTable(
                name: "Type_panne");

            migrationBuilder.DropTable(
                name: "Panne");

            migrationBuilder.DropTable(
                name: "Type_intervention");

            migrationBuilder.DropTable(
                name: "Intervention");
        }
    }
}
