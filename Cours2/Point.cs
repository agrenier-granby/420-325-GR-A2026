namespace Cours2
{
    public class Point
    {
        public int X;
        public int Y;
        public Point(int posX, int posY)
        {
            X = posX;
            Y = posY;
        }
        public void Display()
        {
            Console.WriteLine("X: " + X + ", Y: " + Y);
        }
    }
}