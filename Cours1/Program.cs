using Cours1;

internal class Program
{
    private static void Main(string[] args)
    {
        using (TestEFCoreDbContext dbContext = new TestEFCoreDbContext())
        {
            Console.WriteLine("Suppression des comptes");
            dbContext.Comptes.RemoveRange(dbContext.Comptes);

            Console.WriteLine("Création de comptes");

            Compte c1 = new Compte();
            c1.Solde = 500;
            Compte c2 = new Compte();
            c2.Solde = 1000;
            Compte c3 = new Compte();
            c3.Solde = 1500;
            dbContext.Comptes.Add(c1);
            dbContext.Comptes.Add(c2);
            dbContext.Comptes.Add(c3);

            dbContext.SaveChanges();

            Console.WriteLine("Affichage des comptes");
            List<Compte> comptes = dbContext.Comptes.ToList();
            foreach (Compte compte in comptes)
            {
                Console.WriteLine($"{compte.Id} - {compte.Solde}");
            }

        }
    }
}