namespace Cours3
{
    public abstract class Produit : IComparable<Produit>
    {
        public string Nom { get; set; }
        public int Prix { get; set; }

        public Produit(string nom, int prix)
        {
            Nom = nom;
            Prix = prix;
        }

        public int CompareTo(Produit? other)
        {
            return Prix.CompareTo(other!.Prix);
        }
    }
}
