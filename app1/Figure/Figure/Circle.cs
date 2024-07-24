using Figure002;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure002
{
    internal class Circle : Figure
    {
        public double r {  get; set; }
        public Circle(double radius)
        {
            this.r = radius;
        }
        public override double Area()
        {
            return Math.PI*r*r;
        }
        public double Perimeter()
        {
            return 2 * Math.PI * r;
        }
    }
}
