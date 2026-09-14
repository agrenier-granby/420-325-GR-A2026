using System;
using System.Collections.Generic;
using System.Text;

namespace Cours3
{
    internal class Marcher : ITest
    {
        public void Etape1()
        {
            Console.WriteLine("Etape1 marcher");
        }

        public int Etape2()
        {
            Console.WriteLine("Etape2 marcher");
            return 0;
        }

        public int Etape3()
        {
            Console.WriteLine("Etape3 marcher");
            return 1;
        }
    }
}
