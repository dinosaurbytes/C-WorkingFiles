using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        //variable
        private double Width { get; set; }
        private double Height { get; set; }


        //constructor
        public Rectangle(string id, double w, double h) : base(id)
        {
            this.Width = w;
            this.Height = h;
        }

        //method
        public override double CalculateArea() => Width * Height;

        public override string ToString() => "A " + base.ToString() + " with width " + Width + " and height " + Height + " has a area of: " + CalculateArea();


    }
}
