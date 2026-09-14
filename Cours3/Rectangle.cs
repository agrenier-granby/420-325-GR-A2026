namespace Cours3
{
    public class Rectangle : Forme
    {
        public Point P2 { get; set; }
        public Point P3 { get; set; }
        public Point P4 { get; set; }

        public Rectangle(Point p1, Point p2, Point p3, Point p4) : base(p1)
        {
            P2 = p2;
            P3 = p3;
            P4 = p4;
        }

        public override string Draw()
        {
            return $"Je suis un rectangle avec les 4 points suivants : {P1.Info()}, {P2.Info()}, {P3.Info()}, {P4.Info()}.";
        }
    }
}
