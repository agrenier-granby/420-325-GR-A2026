using Cours6.Models;
using Microsoft.EntityFrameworkCore;

namespace Cours6;

public partial class Exercice9dbContext : DbContext
{
    public Exercice9dbContext()
    {
    }

    public Exercice9dbContext(DbContextOptions<Exercice9dbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Client> Clients { get; set; }
    public virtual DbSet<Pays> Pays { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Exercice9db;Trusted_Connection=true;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
