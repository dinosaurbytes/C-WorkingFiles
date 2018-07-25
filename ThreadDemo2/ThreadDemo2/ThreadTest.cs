using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadDemo2
{
    class ThreadTest
    {
        bool done = false;      //will be shared between two threads (it is on heap memory)

        public void Go()
        {
            if (!done)
            {
                Console.WriteLine("Done!");
                done = true;
                
            }
        }

    }
}
