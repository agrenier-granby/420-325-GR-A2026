using Cours3;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("===== Exercice 5 - Partie 1 =====");

        Point point1 = new Point(1, 2);

        Forme forme = new Forme(point1);

        Console.WriteLine(forme.Draw());

        Console.WriteLine();
        Console.WriteLine("===== Exercice 5 - Partie 2 =====");

        Point p1 = new Point(1, 2);
        Point p2 = new Point(3, 2);
        Point p3 = new Point(3, 4);
        Point p4 = new Point(1, 4);

        Rectangle rectangle = new Rectangle(p1, p2, p3, p4);

        Console.WriteLine(rectangle.Draw());

        Console.WriteLine();
        Console.WriteLine("===== Exercice 5 - Partie 3 =====");

        Cercle cercle1 = new Cercle(new Point(0, 0), 4);
        Cercle cercle2 = new Cercle(new Point(5, 5), 2);
        Cercle cercle3 = new Cercle(new Point(10, 10), 6);

        Rectangle rectangle1 = new Rectangle(
            new Point(1, 1),
            new Point(4, 1),
            new Point(4, 3),
            new Point(1, 3));

        Rectangle rectangle2 = new Rectangle(
            new Point(2, 2),
            new Point(6, 2),
            new Point(6, 5),
            new Point(2, 5));

        Rectangle rectangle3 = new Rectangle(
            new Point(0, 0),
            new Point(2, 0),
            new Point(2, 2),
            new Point(0, 2));

        List<Forme> formes = new List<Forme>();

        formes.Add(cercle1);
        formes.Add(cercle2);
        formes.Add(cercle3);
        formes.Add(rectangle1);
        formes.Add(rectangle2);
        formes.Add(rectangle3);

        foreach (Forme f in formes)
        {
            Console.WriteLine(f.Draw());
        }

        Console.WriteLine();
        Console.WriteLine("===== Exercice 6 - Partie 1 =====");

        List<Produit> produits = new List<Produit>();

        produits.Add(new ProduitDigital("Windows", 200, 5000));
        produits.Add(new ProduitDigital("Office", 150, 3000));
        produits.Add(new ProduitDigital("Visual Studio", 100, 2500));
        produits.Add(new ProduitDigital("Photoshop", 120, 4000));

        produits.Add(new ProduitPhysique("Clavier", 80, 1));
        produits.Add(new ProduitPhysique("Souris", 40, 1));
        produits.Add(new ProduitPhysique("Moniteur", 300, 5));
        produits.Add(new ProduitPhysique("Portable", 1200, 2));

        produits.Add(new ProduitService("Réparation", 75, "Antoine"));
        produits.Add(new ProduitService("Installation", 50, "Julie"));
        produits.Add(new ProduitService("Formation", 150, "Marc"));
        produits.Add(new ProduitService("Consultation", 100, "Sophie"));

        foreach (Produit produit in produits)
        {
            Console.WriteLine($"{produit.Nom} - {produit.Prix}$");
        }

        ITest marcher = new Marcher();
        ITest rouler = new Rouler();
        List<ITest> tests = new List<ITest>();
        tests.Add(marcher);
        tests.Add(rouler);
        foreach (var test in tests)
        {
            MethodeAvecInterface(test);
        }

        #region Exercice 6 - Partie 2
        Console.WriteLine();
        Console.WriteLine("===== Exercice 6 - Partie 2 =====");

        //ILivrable produittest = new ProduitPhysique("Nom", 0, 0);
        foreach (Produit produit in produits)
        {
            if (produit is ILivrable livrable)
            {
                Console.WriteLine(livrable.Livrer());
            }
        }
        #endregion

        Console.WriteLine();
        Console.WriteLine("===== Exercice 6 - Partie 3 =====");

        produits.Sort();

        foreach (Produit produit in produits)
        {
            Console.WriteLine($"{produit.Nom} - {produit.Prix}$");
        }

        Console.WriteLine();
        Console.WriteLine("===== Exercice 6 - Partie 4 =====");

        produits.Sort(new ProduitParNomComparer());

        foreach (Produit produit in produits)
        {
            Console.WriteLine($"{produit.Nom} - {produit.Prix}$");
        }
    }
    static void MethodeAvecInterface(ITest test)
    {
        test.Etape1();
        int valeur2 = test.Etape2();
        int valeur3 = test.Etape3();
    }
}