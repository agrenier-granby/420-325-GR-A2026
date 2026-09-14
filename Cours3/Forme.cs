using System;
using System.Collections.Generic;
using System.Text;

namespace Cours3
{
    public class Forme
    {
        public Point P1 { get; set; }

        public Forme(Point p1)
        {
            P1 = p1;
        }

        public virtual string Draw()
        {
            return $"Je suis une forme avec le point : {P1.Info()}.";
        }
    }
}
