using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("hello","brian",true);
            Console.WriteLine(post1.ToString());

            ImagePost ipost1 = new ImagePost("Check out my new inheritance", "Jay", "www.inheritance.com", true) ;
            Console.WriteLine(ipost1.ToString());

            Console.ReadKey();
        }
    }
}
