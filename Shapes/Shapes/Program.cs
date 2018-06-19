using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Shapes
            Circle c = new Circle("circle", 3);
            Triangle t = new Triangle("Triangle", 5, 7);
            Rectangle r = new Rectangle("Square", 8, 8);

            Console.WriteLine(c);
            Console.WriteLine(t);
            Console.WriteLine(r);

            Console.Write("\n\nPress any key");
            Console.ReadKey();

        }
    }
}
