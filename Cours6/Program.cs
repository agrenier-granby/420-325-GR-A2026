using Cours6;

internal class Program
{
    private static void Main(string[] args)
    {
        using(Exercice9dbContext dbContext = new Exercice9dbContext())
        {
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
    }
}