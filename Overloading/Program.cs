using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calc = new Calculate();
            int a = 1;
            int b = 2;
            float c = 3.0f;
            float d = 4.0f;
            double e = 5.0d;
            double f = 6.0d;
            String firstName = "Joe";
            String lastName = "Bloggs";
            Console.WriteLine("Add Int: {0}", calc.Add(a, b));
            Console.WriteLine("Add Float: {0}", calc.Add(c, d));
            Console.WriteLine("Add Double: {0}", calc.Add(e, f));
            Console.WriteLine("Add String: {0}", calc.Add(firstName, lastName));
            Console.ReadLine();
        }
    }
}
