using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA_AS2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            Console.WriteLine("Rectangle 1");
            Console.WriteLine("Lenght: " + rec.GetLength().ToString());
            Console.WriteLine("Width: " + rec.GetWidth().ToString());
            Console.WriteLine("Changing lenght and width");
            rec.SetLength(8);
            rec.SetWidth(6);
            Console.WriteLine("Lenght: " + rec.GetLength().ToString());
            Console.WriteLine("Width: " + rec.GetWidth().ToString());
            Console.WriteLine("Area: " + rec.GetArea().ToString());
            Console.WriteLine("Perimeter: " + rec.GetPerimeter().ToString());
            Console.WriteLine("");

            Console.WriteLine("Rectangle 2");
            Rectangle rec2 = new Rectangle(5, 4);
            Console.WriteLine("Lenght: " + rec2.GetLength().ToString());
            Console.WriteLine("Width: " + rec2.GetWidth().ToString());
            Console.WriteLine("Area: " + rec2.GetArea().ToString());
            Console.WriteLine("Perimeter: " + rec2.GetPerimeter().ToString());
            Console.ReadLine();
        }
    }
}
