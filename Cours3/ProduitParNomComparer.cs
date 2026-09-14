namespace Cours3
{
    public class ProduitParNomComparer : IComparer<Produit>
    {
        public int Compare(Produit? x, Produit? y)
        {
            return x!.Nom.CompareTo(y!.Nom);
        }
    }
}
