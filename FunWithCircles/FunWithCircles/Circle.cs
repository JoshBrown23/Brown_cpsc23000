using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithCircles
{
    internal class Circle
    {
        private double radius;
        private double x;
        private double y;

        public double Radius
        {
            get { return radius; }
            set 
            { 
                if (value < 0) // value is a reserved word
                {
                    radius = 0;
                }
                else
                {
                    radius = value;
                }
            }
        }

        public double X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public double Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public Circle()
        { //Use property names in constructors
            Radius = 0;
            X = 0;
            Y = 0;
        }

        public Circle(double radius, double x, double y)
        {
            Radius = radius;
            X = x;
            Y = y;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double CalculatePerim()
        {
            return 2 * Math.PI * Radius;
        }

        //Add a ToString function to represent a circle object as a string

        public override string ToString()
        {
            return $"{X,0:F2}\t{Y,0:F2}\t{Radius,0:F2}\t{CalculateArea(), 0:F2}\t{CalculatePerim(), 0:F2}";
        }
    }
}
