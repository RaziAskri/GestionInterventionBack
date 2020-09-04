using Microsoft.EntityFrameworkCore;
using Ms_Panne.Domain.Poulina.MSpanne.Domain.Models;
using NUnit.Framework;
using System;




namespace Ms_Panne.Domain.Poulina.MSpanne.Domain.Data
{
    public class PoulinaDbContext : DbContext
    {
        public PoulinaDbContext()
        {
        }
        public PoulinaDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Panne> Panne { get; set; }
        public DbSet<Type_panne> Type_panne { get; set; }
        public DbSet<Intervention> Intervention { get; set; }
        public DbSet<Type_intervention> Type_intervention { get; set; }
        public DbSet<Interne> Interne { get; set; }
        public DbSet<Externe> Externe { get; set; }







        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Panne>().ToTable("Panne");
            modelBuilder.Entity<Type_panne>().ToTable("Type_panne");
            modelBuilder.Entity<Intervention>().ToTable("Intervention");
            modelBuilder.Entity<Type_intervention>().ToTable("Type_intervention");
            modelBuilder.Entity<Interne>().ToTable("Interne");
            modelBuilder.Entity<Externe>().ToTable("Externe");


          

            modelBuilder.Entity<Panne>()
                        .HasOne(c => c.Type_panne)
                        .WithMany(e => e.Pannes)
                        .HasForeignKey(a=>a.id_type_panne);

            modelBuilder.Entity<Panne>()
                        .HasMany(c => c.Interventions)
                        .WithOne(e => e.Panne)
                        .HasForeignKey(a => a.id_panne);


            modelBuilder.Entity<Intervention>()
                        .HasOne(c => c.Panne)
                        .WithMany(e => e.Interventions)
                        .HasForeignKey(a=>a.id_panne);


            modelBuilder.Entity<Intervention>()
                        .HasOne(c => c.Type_intervention)
                        .WithMany(e => e.Interventions)
                        .HasForeignKey(a=>a.idTypeIntervention);

            modelBuilder.Entity<Type_intervention>()
                        .HasMany(a => a.Interventions)
                        .WithOne(b => b.Type_intervention)
                        .HasForeignKey(c => c.idTypeIntervention);


            modelBuilder.Entity<Type_panne>()
                        .HasMany(a => a.Pannes)
                        .WithOne(c => c.Type_panne)
                        .HasForeignKey(b => b.id_type_panne);

            




        }

    }
}
