using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Poulina.MSpanne.Data.Migrations
{
    public partial class bigcorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Intervention_Panne_Panneid_panne",
                table: "Intervention");

            migrationBuilder.DropForeignKey(
                name: "FK_Intervention_Type_intervention_Type_interventionid_type_intervention",
                table: "Intervention");

            migrationBuilder.DropForeignKey(
                name: "FK_Panne_Intervention_Interventionid_intervention",
                table: "Panne");

            migrationBuilder.DropForeignKey(
                name: "FK_Type_intervention_Intervention_Interventionid_intervention",
                table: "Type_intervention");

            migrationBuilder.DropForeignKey(
                name: "FK_Type_panne_Panne_Panneid_panne",
                table: "Type_panne");

            migrationBuilder.DropIndex(
                name: "IX_Type_panne_Panneid_panne",
                table: "Type_panne");

            migrationBuilder.DropIndex(
                name: "IX_Type_intervention_Interventionid_intervention",
                table: "Type_intervention");

            migrationBuilder.DropIndex(
                name: "IX_Panne_Interventionid_intervention",
                table: "Panne");

            migrationBuilder.DropIndex(
                name: "IX_Intervention_Panneid_panne",
                table: "Intervention");

            migrationBuilder.DropIndex(
                name: "IX_Intervention_Type_interventionid_type_intervention",
                table: "Intervention");

            migrationBuilder.DropColumn(
                name: "Panneid_panne",
                table: "Type_panne");

            migrationBuilder.DropColumn(
                name: "Interventionid_intervention",
                table: "Type_intervention");

            migrationBuilder.DropColumn(
                name: "Interventionid_intervention",
                table: "Panne");

            migrationBuilder.DropColumn(
                name: "Panneid_panne",
                table: "Intervention");

            migrationBuilder.DropColumn(
                name: "Type_interventionid_type_intervention",
                table: "Intervention");

            migrationBuilder.DropColumn(
                name: "type_intervention",
                table: "Intervention");

            migrationBuilder.AddColumn<Guid>(
                name: "idTypeIntervention",
                table: "Intervention",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Panne_id_type_panne",
                table: "Panne",
                column: "id_type_panne");

            migrationBuilder.CreateIndex(
                name: "IX_Intervention_idTypeIntervention",
                table: "Intervention",
                column: "idTypeIntervention");

            migrationBuilder.CreateIndex(
                name: "IX_Intervention_id_panne",
                table: "Intervention",
                column: "id_panne");

            migrationBuilder.AddForeignKey(
                name: "FK_Intervention_Type_intervention_idTypeIntervention",
                table: "Intervention",
                column: "idTypeIntervention",
                principalTable: "Type_intervention",
                principalColumn: "id_type_intervention",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Intervention_Panne_id_panne",
                table: "Intervention",
                column: "id_panne",
                principalTable: "Panne",
                principalColumn: "id_panne",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Panne_Type_panne_id_type_panne",
                table: "Panne",
                column: "id_type_panne",
                principalTable: "Type_panne",
                principalColumn: "id_type_panne",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Intervention_Type_intervention_idTypeIntervention",
                table: "Intervention");

            migrationBuilder.DropForeignKey(
                name: "FK_Intervention_Panne_id_panne",
                table: "Intervention");

            migrationBuilder.DropForeignKey(
                name: "FK_Panne_Type_panne_id_type_panne",
                table: "Panne");

            migrationBuilder.DropIndex(
                name: "IX_Panne_id_type_panne",
                table: "Panne");

            migrationBuilder.DropIndex(
                name: "IX_Intervention_idTypeIntervention",
                table: "Intervention");

            migrationBuilder.DropIndex(
                name: "IX_Intervention_id_panne",
                table: "Intervention");

            migrationBuilder.DropColumn(
                name: "idTypeIntervention",
                table: "Intervention");

            migrationBuilder.AddColumn<Guid>(
                name: "Panneid_panne",
                table: "Type_panne",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Interventionid_intervention",
                table: "Type_intervention",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Interventionid_intervention",
                table: "Panne",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Panneid_panne",
                table: "Intervention",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Type_interventionid_type_intervention",
                table: "Intervention",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "type_intervention",
                table: "Intervention",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Type_panne_Panneid_panne",
                table: "Type_panne",
                column: "Panneid_panne");

            migrationBuilder.CreateIndex(
                name: "IX_Type_intervention_Interventionid_intervention",
                table: "Type_intervention",
                column: "Interventionid_intervention");

            migrationBuilder.CreateIndex(
                name: "IX_Panne_Interventionid_intervention",
                table: "Panne",
                column: "Interventionid_intervention");

            migrationBuilder.CreateIndex(
                name: "IX_Intervention_Panneid_panne",
                table: "Intervention",
                column: "Panneid_panne");

            migrationBuilder.CreateIndex(
                name: "IX_Intervention_Type_interventionid_type_intervention",
                table: "Intervention",
                column: "Type_interventionid_type_intervention");

            migrationBuilder.AddForeignKey(
                name: "FK_Intervention_Panne_Panneid_panne",
                table: "Intervention",
                column: "Panneid_panne",
                principalTable: "Panne",
                principalColumn: "id_panne",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Intervention_Type_intervention_Type_interventionid_type_intervention",
                table: "Intervention",
                column: "Type_interventionid_type_intervention",
                principalTable: "Type_intervention",
                principalColumn: "id_type_intervention",
                onDelete: ReferentialAction.Restrict);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Type_panne_Panne_Panneid_panne",
                table: "Type_panne",
                column: "Panneid_panne",
                principalTable: "Panne",
                principalColumn: "id_panne",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
