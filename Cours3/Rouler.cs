using System;
using System.Collections.Generic;
using System.Text;

namespace Cours3
{
    public class Rouler : ITest
    {
        public void Etape1()
        {
            Console.WriteLine("Etape1 rouler");
        }

        public int Etape2()
        {
            Console.WriteLine("Etape2 rouler");
            return 2;
        }

        public int Etape3()
        {
            Console.WriteLine("Etape3 rouler");
            return 3;
        }
    }
}
