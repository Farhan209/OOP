using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            Circle cir = new Circle();
            Triangle tri = new Triangle();
            double a = 10;
            double b = 20;
            double c = 1.0;
            double d = 5.0;
            double e = 6.0;
            double area = 0.0;
            double perimeter = 0.0;
            rec.Height = a;
            rec.Width = b;
            area = rec.Area();

            Console.WriteLine("Rectangle Area and Perimeter");
            Console.WriteLine("Area Of Rectangle is: {0:F}", area);
            perimeter = rec.Perimeter();
            Console.WriteLine("Perimeter Of Rectangle is: {0:F}", perimeter);
            Console.WriteLine("----------------------------------");
            
            Console.WriteLine("Circle Area and Perimeter");
            cir.Radius = c;
            area = cir.Area();
            Console.WriteLine("Area Of Circle is: {0:F}", area);
            perimeter = cir.Perimeter();
            Console.WriteLine("Perimeter of Circle is: {0:F}", perimeter);
            Console.WriteLine("----------------------------------");

            Console.WriteLine("Triangle Area");
            tri.Base = d;
            tri.Height = e;
            area = tri.Area();
            Console.WriteLine("Area Of Triangle is: {0:F}", area);
            Console.ReadLine();
        }
    }
}
