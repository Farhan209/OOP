using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Calculate: Arithmetic
    {
        public float Add(float a, float b)
        {
            Console.WriteLine("Add Floats Called");
            return a + b;
        }

        public String Add(String a, String b)
        {
            Console.WriteLine("Add Strings Called");
            return "Hello " + a + " " + b;
        }
    }
}
