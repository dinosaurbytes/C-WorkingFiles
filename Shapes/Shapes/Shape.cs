using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Shape
    {
        //accessor
        public string ID { get; set; }

        //method
        public virtual double CalculateArea()
        {
            return 0;
        }
        
        //constructor
        public Shape(string id)
        {
            this.ID = id;
        }

        //Method
        public override string ToString()
        {
            return ID;
        }
    }
}
