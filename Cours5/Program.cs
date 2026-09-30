using Cours5;
using Cours5.Models;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        using(Exercice8dbContext dbContext = new Exercice8dbContext())
        {
            try
            {
                //Partie 2
                Client client = new Client()
                {
                    Nom = "Pierre",
                    Courriel = "pierre@hotmail.com"
                };

                dbContext.Clients.Add(client);

                dbContext.SaveChanges();

                //Partie 3
                Pays etatsUnis = dbContext.Pays
                    .First(p => p.Nom == "États-Unis");

                Client clientAjout = new Client()
                {
                    Nom = "Marie",
                    Courriel = "marie@hotmail.com",
                    Pays = etatsUnis
                };

                client.Adresses.Add(new Adress()
                {
                    NoCivique = 123,
                    Rue = "Main Street",
                });

                client.Adresses.Add(new Adress()
                {
                    NoCivique = 456,
                    Rue = "Broadway",
                });

                dbContext.Clients.Add(clientAjout);

                dbContext.SaveChanges();

                //partie 3
                Client mathieu = dbContext.Clients
                    .First(c => c.Nom == "Mathieu");

                Pays canada = dbContext.Pays
                    .First(p => p.Nom == "Canada");

                mathieu.Courriel = "NouveauCourriel@hotmail.com";
                mathieu.Pays = canada;

                dbContext.SaveChanges();

                Client felix = dbContext.Clients
                    .First(c => c.Nom == "Félix");

                foreach (Adress adresse in felix.Adresses)
                {
                    adresse.NoCivique = 9999;
                }

                dbContext.SaveChanges();

                //Partie 4
                dbContext.Pays.Remove(canada);
                dbContext.SaveChanges();

                dbContext.Clients.Remove(mathieu);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
    }
}