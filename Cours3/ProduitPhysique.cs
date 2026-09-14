namespace Cours3
{
    public class ProduitPhysique : Produit, ILivrable
    {
        public int Poids { get; set; }

        public ProduitPhysique(string nom, int prix, int poids)
            : base(nom, prix)
        {
            Poids = poids;
        }

        public string Livrer()
        {
            return $"Livraison du produit {Nom}, le produit pèse {Poids} kg.";
        }
    }
}
