using Figure002;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace Figure002
    {
        internal class Triangle : Figure
        {
            public double side1 { get; set; }
            public double side2 { get; set; }
            public double side3 { get; set; }

            public Triangle(double side1, double side2, double side3)
            {
                this.side1 = side1;
                this.side2 = side2;
                this.side3 = side3;
            }
            public override double Area()
            {
                // Heron's formula for triangle area
                double s = (side1 + side2 + side3) / 2;
                double area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
                return area;
            }
            public double Perimeter()
            {
                return side1 + side2 + side3;
            }
        }
    }
