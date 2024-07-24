using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure002
{
    internal class Rectangle : Figure
    {
        public double length { get; set; }
        public double width { get; set; }

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double Area()
        {
            return length * width;
        }
        public double Perimeter()
        {
            return 2 * (length + width);
        }
    }
}
