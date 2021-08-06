using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Arithmetic
    {
        public int Add(int a, int b)
        {
            Console.WriteLine("Add Ints Called");
            return a + b;
        }

        public double Add(double a, double b)
        {
            Console.WriteLine("Add Doubles Called");
            return a + b;
        }
    }
}
