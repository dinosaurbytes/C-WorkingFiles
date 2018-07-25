using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadTest testObj = new ThreadTest();      //goes on heap memory
            (new Thread(testObj.Go)).Start();

            Console.WriteLine("\nPress any key");
            Console.ReadKey();
        }
    }
}
