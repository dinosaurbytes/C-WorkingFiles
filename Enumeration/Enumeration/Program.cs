using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    /*Define types in the namespace 
     * (types typically start with a captial letter) 
     * (named constants don't need quotes)
     * If you make the first one 1, then the second one auto becomes 2, then 3 etc.
     * If the first one is left blank, then its 0
     */
    enum Season { Spring, Summer, Fall, Winter}

    class Program
    {
        /*
         * Usually Declaring arrays and constants on class level
         */
        const int NR_SEASONS = 4;


        /*
         * Main program
         */
        static void Main(string[] args)
        {
            decimal[] sales = new Decimal[NR_SEASONS];
            decimal totalSales = 0;
            string input; // for reading

            // collect sales for each season
            for (Season season = Season.Spring; season <= Season.Winter; season++) // for each season
            {
                Console.WriteLine("Enter sales amount in " + season.ToString());
                input = Console.ReadLine();
                sales[(int)season] = Convert.ToDecimal(input);
                totalSales += sales[(int)season];
            }

            // display values from array and the total
            Console.WriteLine("\nSeasonal sales:");
            for (Season season = Season.Spring; season <= Season.Winter; season++) // for each season
            {
                Console.WriteLine((season.ToString()).PadRight(8) + ": " + sales[(int)season].ToString("c"));
            }
            Console.WriteLine("\nTotal sales: " + totalSales.ToString("c"));

            Console.WriteLine("\n\nPress a key to finish");
            Console.ReadKey();
        }
    }
}
