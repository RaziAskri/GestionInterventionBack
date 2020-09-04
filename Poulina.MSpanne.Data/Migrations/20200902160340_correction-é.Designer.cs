﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ms_Panne.Domain.Poulina.MSpanne.Domain.Data;

namespace Poulina.MSpanne.Data.Migrations
{
    [DbContext(typeof(PoulinaDbContext))]
    [Migration("20200902160340_correction-é")]
    partial class correctioné
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ms_Panne.Domain.Poulina.MSpanne.Domain.Models.Externe", b =>
                {
                    b.Property<Guid>("id_externe")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("id_fournisseur")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("id_intervention")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id_externe");

                    b.ToTable("Externe");
                });

            modelBuilder.Entity("Ms_Panne.Domain.Poulina.MSpanne.Domain.Models.Interne", b =>
                {
                    b.Property<Guid>("id_interne")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("id_intervention")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("matricule")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id_interne");

                    b.ToTable("Interne");
                });

            modelBuilder.Entity("Ms_Panne.Domain.Poulina.MSpanne.Domain.Models.Intervention", b =>
                {
                    b.Property<Guid>("id_intervention")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("date_intervention")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description_intervention")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("duree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("idTypeIntervention")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("id_panne")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id_intervention");

                    b.HasIndex("idTypeIntervention");

                    b.HasIndex("id_panne");

                    b.ToTable("Intervention");
                });

            modelBuilder.Entity("Ms_Panne.Domain.Poulina.MSpanne.Domain.Models.Panne", b =>
                {
                    b.Property<Guid>("id_panne")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("etat_panne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("id_machine")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("id_type_panne")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id_panne");

                    b.HasIndex("id_type_panne");

                    b.ToTable("Panne");
                });

            modelBuilder.Entity("Ms_Panne.Domain.Poulina.MSpanne.Domain.Models.Type_intervention", b =>
                {
                    b.Property<Guid>("id_type_intervention")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("etat_intervention")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type_intervention")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_type_intervention");

                    b.ToTable("Type_intervention");
                });

            modelBuilder.Entity("Ms_Panne.Domain.Poulina.MSpanne.Domain.Models.Type_panne", b =>
                {
                    b.Property<Guid>("id_type_panne")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("label")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("priorite")
                        .HasColumnType("int");

                    b.HasKey("id_type_panne");

                    b.ToTable("Type_panne");
                });

            modelBuilder.Entity("Ms_Panne.Domain.Poulina.MSpanne.Domain.Models.Intervention", b =>
                {
                    b.HasOne("Ms_Panne.Domain.Poulina.MSpanne.Domain.Models.Type_intervention", "Type_intervention")
                        .WithMany("Interventions")
                        .HasForeignKey("idTypeIntervention")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ms_Panne.Domain.Poulina.MSpanne.Domain.Models.Panne", "Panne")
                        .WithMany("Interventions")
                        .HasForeignKey("id_panne")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ms_Panne.Domain.Poulina.MSpanne.Domain.Models.Panne", b =>
                {
                    b.HasOne("Ms_Panne.Domain.Poulina.MSpanne.Domain.Models.Type_panne", "Type_panne")
                        .WithMany("Pannes")
                        .HasForeignKey("id_type_panne")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
