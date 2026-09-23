namespace Cours3
{
    public class LeetTransformer : ITransformer
    {
        public string Transformer(string texte)
        {
            return texte
                .Replace("e", "3")
                .Replace("E", "3")
                .Replace("t", "7")
                .Replace("T", "7");
        }
    }
}
