using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesC
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(5, 4, 5);
          

            box.DisplayInfo();
            box.FrontSurface();
            Console.ReadKey();
        }
    }
}
