using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shape
    {
        //variable
        private double Base { get; set; }
        private double Height { get; set; }


        //constructor
        public Triangle(string id, double b, double h) : base(id)
        {
            this.Base = b;
            this.Height = h;
        }

        //method
        public override double CalculateArea() => Base * Height * 0.5;

        public override string ToString() => "A " + base.ToString() + " with base " + Base + " and height " + Height + " has a area of: " + CalculateArea();



    }
}
