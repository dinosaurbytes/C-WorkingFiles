using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();
            
            Task<int> planeTask = Task.Factory.StartNew(BookPlane);
            Task<int> hotelTask = Task.Factory.StartNew(BookHotel);
            Task<int> carTask = Task.Factory.StartNew(BookCar);

            Task.WaitAll(planeTask, hotelTask, carTask);

            int seconds = (int) sw.ElapsedMilliseconds / 1000;
            Console.WriteLine("\nExecution time in seconds: " + seconds + "\n");

            Console.WriteLine("Reservation details: \nPlane#: " + planeTask.Result + "\nHotel#: " + hotelTask.Result + "\nCar#: " + carTask.Result);


            Console.WriteLine("\nPress a key");
            Console.ReadKey();

        }

        static Random rand = new Random();      //random number generator

        private static int BookPlane()
        {
            Console.WriteLine("Booking a plane");
            Thread.Sleep(5000);     //5 seconds
            return rand.Next(100);
        }
        private static int BookHotel()
        {
            Console.WriteLine("Booking hotel");
            Thread.Sleep(8000);     //5 seconds
            return rand.Next(100);
        }
        private static int BookCar()
        {
            Console.WriteLine("Booking a car");
            Thread.Sleep(2000);     //5 seconds
            return rand.Next(100);
        }
    }
}
