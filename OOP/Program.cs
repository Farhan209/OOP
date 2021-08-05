using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            int x = 6;
            int y = 3;
            int sum = 0;
            sum = calc.Mult(x, y);
            Console.WriteLine("Result: {0}", sum);
            Console.ReadLine();
        }
    }
}
