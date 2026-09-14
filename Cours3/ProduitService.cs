namespace Cours3
{
    public class ProduitService : Produit
    {
        public string Responsable { get; set; }

        public ProduitService(string nom, int prix, string responsable)
            : base(nom, prix)
        {
            Responsable = responsable;
        }
    }
}
