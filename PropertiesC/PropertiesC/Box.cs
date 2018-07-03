using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesC
{
    class Box
    {
        //field
        private int length;
        private int height;
        private int width;
        private int volumne;
        private int area;

        //constructor
        public Box() { }
        
        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            this.width = width;
            this.volumne = length * height * width;
        }

        //accessor
        public int Width { get; set; }

        public int Height
        {
            get => height;
            set => height = value;
        }

        public int Length
        {
            get => length;
            set => length = value;
        }

        public int Area
        {
            get => length * height;
            
        }


        //method
        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and width is {2} so the volume is {3}", length, height, width, volumne);
        }

        public void FrontSurface()
        {
            Console.WriteLine("Front surface with a height of {0} and a length of {1} is {2}cm2", height, length, Area);
        }
    }
}
