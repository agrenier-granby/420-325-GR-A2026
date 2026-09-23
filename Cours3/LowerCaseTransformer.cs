namespace Cours3
{
    public class LowerCaseTransformer : ITransformer
    {
        public string Transformer(string texte)
        {
            return texte.ToLowerInvariant();
        }
    }
}
