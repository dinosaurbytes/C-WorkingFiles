using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        //variable
        private double Radius { get; set; }

               

        //constructor
        public Circle (string id, double r) : base(id)
        {
            this.Radius = r;
        }

        //method
        public override double CalculateArea() => Radius * Math.PI * Radius;

        public override string ToString() => "A " + base.ToString() + " with radius " + Radius + " has a area of: " + CalculateArea();
    }
}
