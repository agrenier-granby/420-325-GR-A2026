namespace Cours3
{
    public class ProduitDigital : Produit, ILivrable
    {
        public int Taille { get; set; }

        public ProduitDigital(string nom, int prix, int taille)
            : base(nom, prix)
        {
            Taille = taille;
        }

        public string Livrer()
        {
            return $"Envoie d'un courriel avec un lien de téléchargement pour obtenir l'application {Nom} qui a une taille de {Taille} Mo.";
        }
    }
}
