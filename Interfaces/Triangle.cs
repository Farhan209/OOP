using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Triangle: IShape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public double Area()
        {
            return (Base * Height) / 2;
        }

        public double Perimeter()
        {
            return 0;
        }
    }
}
