using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersC
{
    class Members
    {
        //fields
        private string memberName;
        private string jobTitle;

        //public fields
        public int age;
        public int salary = 20000;

        public string JobTitle
        {
            get => jobTitle;
            set => jobTitle = value;
        }


        //methods
        public void Introducing (bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateIntro();
            }
            else
            {
                Console.WriteLine("Hi, my name is {0}, and my job title is {1}. I'm {2} years old", memberName, jobTitle, age);
            }
        }

        //constructor
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            jobTitle = "Developer";
            Console.WriteLine("Object created");
        }

        //destructor/finalizer
        ~Members()
        {
            // cleanup statements
            Console.WriteLine("Deconstruction of Members object");
        }

        private void SharingPrivateIntro()
        {
            Console.WriteLine("My salary is {0}", salary);
        }

    }
}
