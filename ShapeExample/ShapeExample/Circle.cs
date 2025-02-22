using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeExample
{
    internal class Circle: Shape
    {
        private double radius;

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value < 0)
                {
                    radius = 0;
                }
                else
                {
                    radius = value;
                }
            }
        }

        public Circle()
        {
            Radius = 0;
        }

        public Circle(double x, double y, double radius):base(x,y)
        {
            Radius = radius;
        }

        public override string GetType()
        {
            return "circle";
        }

        public override string ToString()
        {
            return $"{base.ToString()} {Radius,0:F2}";
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius,2);
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
