namespace Cours3
{
    public class Cercle : Forme
    {
        public int Rayon { get; set; }

        public Cercle(Point centre, int rayon) : base(centre)
        {
            Rayon = rayon;
        }

        public override string Draw()
        {
            return $"Je suis un cercle de rayon {Rayon} avec comme centre le point: {P1.Info()}.";
        }
    }
}
