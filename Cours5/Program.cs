using Cours5;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        using(Exercice8dbContext dbContext = new Exercice8dbContext())
        {
            var clients = dbContext.Clients
                .Include(p => p.Pays)
                .ToList();

            foreach (var client in clients) {
                Console.WriteLine(client.Nom);
                Console.WriteLine(client.Courriel);
                Console.WriteLine(client.Pays.Nom);
            }
            
        }
    }
}