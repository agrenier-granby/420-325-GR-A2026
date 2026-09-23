namespace Cours3
{
    public class UpperCaseTransformer : ITransformer
    {
        public string Transformer(string texte)
        {
            return texte.ToUpperInvariant();
        }
    }
}
