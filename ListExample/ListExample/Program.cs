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

            numbers.Insert(0, -1.5);
            numbers.Insert(3, 4.4);

            foreach (double num in numbers)
                Console.Write(num + "\t");
            Console.WriteLine();

            numbers.RemoveAt(2);
            foreach (double num in numbers)
                Console.Write(num + "\t");
            //Console.WriteLine();

            Console.WriteLine("\n\nPress any key");
            Console.ReadKey();
        }
    }
}
