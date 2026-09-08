using Microsoft.EntityFrameworkCore;

namespace Cours1
{
    public class TestEFCoreDbContext : DbContext
    {
        public DbSet<Compte> Comptes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // connexion string pour se connecter à votre BD
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TestEFCore;Trusted_Connection=true;Trust Server Certificate=true;MultipleActiveResultSets=true;Integrated Security=true;");
        }
    }
}
