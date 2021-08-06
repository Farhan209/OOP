using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    class AreaOfSquare
    {
        public virtual double Square(double a, double b)
        {
            Console.WriteLine("Calculate Area Of Square Power A^B");
            return Math.Pow(a, 2);
        }
    }
}
