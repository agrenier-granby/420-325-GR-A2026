namespace Cours3
{
    public class Point
    {
        private int x;
        private int y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public string Info()
        {
            return $"[{X},{Y}]";
        }
    }
}
