using System;
using System.Collections.Generic;
using Cours5.Models;
using Microsoft.EntityFrameworkCore;

namespace Cours5;

public partial class Exercice8dbContext : DbContext
{
    public Exercice8dbContext()
    {
    }

    public Exercice8dbContext(DbContextOptions<Exercice8dbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Adress> Adresses { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Pays> Pays { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Exercice8db;Trusted_Connection=true;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Adress>(entity =>
        {
            entity.HasKey(e => e.AdresseId);

            entity.Property(e => e.Rue).HasMaxLength(255);

            entity.HasOne(d => d.Client).WithMany(p => p.Adresses)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("FK_Adresses_Clients");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Clients");

            entity.Property(e => e.Nom).HasMaxLength(25);

            entity.HasOne(d => d.Pays).WithMany(p => p.Clients)
                .HasForeignKey(d => d.PaysId)
                .HasConstraintName("FK_dbo.Clients_dbo.Pays_PaysId");
        });

        modelBuilder.Entity<Pays>(entity =>
        {
            entity.HasKey(e => e.PaysId).HasName("PK_dbo.Pays");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
