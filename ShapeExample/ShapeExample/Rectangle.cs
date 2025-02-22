using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeExample
{
    internal class Rectangle: Shape
    {
        private double length;
        private double width;

        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value < 0)
                {
                    length = 0;
                }
                else
                {
                    length = value;
                }
            }
        }

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value < 0)
                {
                    width = 0;
                }
                else
                {
                    width = value;
                }
            }
        }

        public Rectangle()
        {
            Length = 0;
            Width = 0;
        }

        public Rectangle(double x, double y, double length, double width):base(x,y)
        {
            Length= length;
            Width = width;
        }

        public override string GetType()
        {
            return "rectangle";
        }

        public override string ToString()
        {
            return $"{base.ToString()} {Length, 0:F2} {Width, 0:F2}";
        }

        public override double CalculateArea()
        {
            return Length * Width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }
    }
}
