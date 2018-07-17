using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = new List<double>(); //empty list
            Console.WriteLine("List count: " + numbers.Count + "; list capacity: " + numbers.Capacity);
            numbers.Add(7.5);
            numbers.Add(2.3);
            numbers.Add(-1.2);
            numbers.Add(-1.2);
            numbers.Add(-1.2);
            Console.WriteLine("List count: " + numbers.Count + "; list capacity: " + numbers.Capacity);



            Console.WriteLine("\n\nPress any key");
            Console.ReadKey();
        }
    }
}
