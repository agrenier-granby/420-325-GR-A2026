internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===== Partie 1 =====");
        List<Etudiant> etudiants = new List<Etudiant>
        {
            new() { Id=1, Nom="Alice", Age=19, Note=15.5, Ville="Montréal",  Cours= new(){ "Math", "Physique" } },
            new() { Id=2, Nom="Bob",   Age=21, Note=12.0, Ville="Granby",    Cours= new(){ "Info", "Math" } },
            new() { Id=3, Nom="Chloé", Age=20, Note=9.5,  Ville="Sherbrooke",Cours= new(){ "Chimie" } },
            new() { Id=4, Nom="David", Age=22, Note=18.0, Ville="Granby",    Cours= new(){ "Physique", "Info" } },
            new() { Id=5, Nom="Emma",  Age=20, Note=14.0, Ville="Montréal",  Cours= new(){ "Math", "Chimie", "Info" } },
        };

        Dictionary<string, double> prixProduits = new Dictionary<string, double>
        {
            ["Livre"] = 12.5,
            ["Stylo"] = 1.8,
            ["Clé USB"] = 9.9,
            ["Cahier"] = 3.2,
            ["Calculatrice"] = 19.5
        };

        Dictionary<string, int> quantiteProduits = new Dictionary<string, int>
        {
            ["Livre"] = 8,
            ["Stylo"] = 120,
            ["Clé USB"] = 15,
            ["Cahier"] = 60,
            ["Calculatrice"] = 5
        };

        AfficherAvecCrochets("banane");

        Action<string> afficherAvecCrochetsAction =
        texte => Console.WriteLine($"[{texte}]");

        afficherAvecCrochetsAction("banane");

        Console.WriteLine();

        Console.WriteLine(MultipleDe13(26));

        Predicate<int> multipleDe13Predicate =
            nombre => nombre % 13 == 0;

        Console.WriteLine(multipleDe13Predicate(26));

        Console.WriteLine();

        Func<Etudiant, int> nombreCoursFunc =
            etudiant => etudiant.Cours.Count;

        foreach (Etudiant etudiant in etudiants)
        {
            Console.WriteLine(
                $"{etudiant.Nom} - Fonction : {NombreCours(etudiant)}");

            Console.WriteLine(
                $"{etudiant.Nom} - Func : {nombreCoursFunc(etudiant)}");
        }

        Console.WriteLine();
        Console.WriteLine("===== Partie 2 =====");

        Console.WriteLine("Étudiants avec une note >= 14 triés par nom");

        var etudiantsNote14 = etudiants
            .Where(e => e.Note >= 14)
            .OrderBy(e => e.Nom);

        foreach (var etudiant in etudiantsNote14)
        {
            Console.WriteLine($"{etudiant.Nom} - {etudiant.Note}");
        }

        Console.WriteLine();
        Console.WriteLine("Les 2 meilleures notes");

        var meilleursEtudiants = etudiants
            .OrderByDescending(e => e.Note)
            .Take(2);

        foreach (var etudiant in meilleursEtudiants)
        {
            Console.WriteLine($"{etudiant.Nom} - {etudiant.Note}");
        }

        Console.WriteLine();

        bool auMoinsUnEchec = etudiants.Any(e => e.Note < 8);

        Console.WriteLine($"Au moins un étudiant en échec : {auMoinsUnEchec}");
        Console.WriteLine();

        double moyenne = etudiants.Average(e => e.Note);

        Console.WriteLine($"Moyenne des notes : {moyenne}");
        Console.WriteLine();

        double noteMax = etudiants.Max(e => e.Note);

        Console.WriteLine($"Note maximale : {noteMax}");

        Console.WriteLine();
        Console.WriteLine("Moyenne des notes par ville");

        var moyennesParVille = etudiants
            .GroupBy(e => e.Ville);

        foreach (var groupe in moyennesParVille)
        {
            Console.WriteLine($"{groupe.Key} : {groupe.Average(e => e.Note)}");
        }

        Console.WriteLine();
        Console.WriteLine("Cours distincts");

        var coursDistincts = etudiants
            .SelectMany(e => e.Cours)
            .Distinct()
            .OrderBy(c => c);

        foreach (var cours in coursDistincts)
        {
            Console.WriteLine(cours);
        }

        Console.WriteLine();
        Console.WriteLine("Produits dont le prix est supérieur à 10");

        var produitsPlusDe10 = prixProduits
            .Where(p => p.Value > 10);

        foreach (var produit in produitsPlusDe10)
        {
            Console.WriteLine(produit.Key);
        }

        Console.WriteLine();
        Console.WriteLine("Valeur totale des produits");

        var valeurTotaleProduits =
            prixProduits.Join(
                quantiteProduits,
                prix => prix.Key,
                quantite => quantite.Key,
                (prix, quantite) => new
                {
                    Nom = prix.Key,
                    ValeurTotale = prix.Value * quantite.Value
                });

        foreach (var produit in valeurTotaleProduits)
        {
            Console.WriteLine($"{produit.Nom} : {produit.ValeurTotale}");
        }
    }
    static void AfficherAvecCrochets(string texte)
    {
        Console.WriteLine($"[{texte}]");
    }

    static bool MultipleDe13(int nombre)
    {
        return nombre % 13 == 0;
    }

    static int NombreCours(Etudiant etudiant)
    {
        return etudiant.Cours.Count;
    }
}

public class Etudiant
{
    public int Id { get; set; }
    public string Nom { get; set; } = "";
    public int Age { get; set; }
    public double Note { get; set; } // sur 20
    public string Ville { get; set; } = "";
    public List<string> Cours { get; set; } = new();
}