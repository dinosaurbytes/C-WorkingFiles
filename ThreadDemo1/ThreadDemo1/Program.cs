using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo1
{
    class Program
    {
        const int TIMES = 1000;
        static void Main(string[] args)
        {
            
            Thread t = new Thread(WriteY);
            t.Start();

            for (int i = 0; i < TIMES; i++) Console.Write("x");

            Console.WriteLine("\n\nPress any Key");
            Console.ReadKey();
        }
        static void WriteY()
        {
            for (int i = 0; i < TIMES; i++) Console.Write("y");
        }
    }
}
