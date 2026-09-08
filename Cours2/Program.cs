using Point = Cours2.Point;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("===== Exercice 1 - Partie 1 =====");

        Console.Write("Entrez votre prénom et votre nom : ");
        string nomPrenom = Console.ReadLine()!;

        Console.Write("Entrez votre âge : ");
        string age = Console.ReadLine()!;

        string nomModifie = ModifierNom(nomPrenom);
        int ageDouble = Doubler(age);

        Console.WriteLine($"Bonjour {nomModifie} âgé de {ageDouble}.");

        Console.WriteLine();
        Console.WriteLine("===== Exercice 1 - Partie 2 =====");

        for (int i = ageDouble; i >= 0; i--)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine("===== Exercice 2 - Partie 1 =====");

        List<string> personnes = new List<string>();

        personnes.Add("Mathieu");
        personnes.Add("Antoine");
        personnes.Add("Sophie");
        personnes.Add("Alexandre");
        personnes.Add("Julie");
        personnes.Add("Karine");

        Console.WriteLine(personnes[0]);
        Console.WriteLine(personnes[personnes.Count - 1]);
        Console.WriteLine(personnes[3]);

        personnes.RemoveAt(personnes.Count - 1);

        Console.WriteLine(personnes[personnes.Count - 1]);

        Console.WriteLine();
        Console.WriteLine("===== Exercice 2 - Partie 2 =====");

        Dictionary<string, int> villes = new Dictionary<string, int>();

        villes.Add("Granby", 70000);
        villes.Add("Cowansville", 16000);
        villes.Add("Saint-Alphonse-de-Granby", 3500);
        villes.Add("Sherbrooke", 175000);
        villes.Add("Dunham", 4000);
        villes.Add("Sutton", 4500);

        Console.WriteLine($"{villes.First().Key} : {villes.First().Value}");
        Console.WriteLine($"{villes.Last().Key} : {villes.Last().Value}");

        Console.WriteLine(villes["Sherbrooke"]);

        Console.WriteLine();
        Console.WriteLine("===== Exercice 2 - Partie 3 =====");

        SortedSet<DateTime> dates = new SortedSet<DateTime>();

        DateTime date1 = DateTime.Now.AddDays(1);

        dates.Add(date1);
        dates.Add(DateTime.Now.AddDays(4));
        dates.Add(DateTime.Now.AddDays(-5));
        dates.Add(DateTime.Now.AddDays(18));
        dates.Add(DateTime.Now.AddDays(-11));
        dates.Add(date1);

        foreach (DateTime date in dates)
        {
            Console.WriteLine(date);
        }

        Console.WriteLine();
        Console.WriteLine("===== Exercice 3 - Partie 1 =====");

        int x = 42;
        int y = x;

        x = 100;

        Console.WriteLine($"x = {x}");
        Console.WriteLine($"y = {y}");

        Point p1 = new Point(2, 4);
        Point p2 = p1;

        p1.X = 100;

        p1.Display();
        p2.Display();

        Console.WriteLine();
        Console.WriteLine("===== Exercice 3 - Partie 2 =====");

        int a = 3;
        int b = 4;

        int resultat1 = TraitementValeur(a, b);

        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
        Console.WriteLine($"resultat1 = {resultat1}");

        int resultat2 = TraitementReference(ref a, ref b);

        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
        Console.WriteLine($"resultat2 = {resultat2}");

        Point p = new Point(1, 1);

        TraitementUn(p);
        p.Display();

        TraitementDeux(ref p);
        p.Display();

        Console.WriteLine();
        Console.WriteLine("===== Exercice 4 =====");
        Console.Write("Entrez un nombre : ");
        string nombre = Console.ReadLine()!;

        while (nombre != "42")
        {
            try
            {
                int valeur = Convert.ToInt32(nombre);

                Console.WriteLine("La conversion a réussi.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Erreur : le format du nombre est invalide.");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Erreur : la valeur doit être comprise entre {int.MinValue} et {int.MaxValue}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur : {ex.Message}");
            }
            finally
            {
                Console.Write("Entrez un nombre : ");
                nombre = Console.ReadLine()!;
            }
        }
    }

    static string ModifierNom(string nomPrenom)
    {
        string[] parties = nomPrenom.Split(' ');

        string prenom = parties[0];
        string nom = parties[1].ToUpper();

        return nom + " " + prenom;
    }

    static int Doubler(string age)
    {
        int ageConverti = Convert.ToInt32(age);

        return ageConverti * 2;
    }

    static int TraitementValeur(int a, int b)
    {
        a = a * b;

        return a + b;
    }

    static int TraitementReference(ref int a, ref int b)
    {
        a = a * b;

        return a + b;
    }

    static void TraitementUn(Point p)
    {
        p.X = 100;
        p = new Point(10, 10);
    }

    static void TraitementDeux(ref Point p)
    {
        p.X = 200;
        p = new Point(20, 20);
    }
}