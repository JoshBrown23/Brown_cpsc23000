using static System.Console;
namespace PolynomialCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintHeading();

            int polyNum = 1;
            int degree;
            string doAgain = "Y";
            double a = 0, b = 0, c = 0, d = 0;
            int minx, maxx, temp;
            double fofx;

            //Print the welcome message
            WriteLine("This tool helps you calculate the values of cubic," +
                "\r\nquadratic,linear, and constant polynomials over a " +
                "\r\nspecified domain. You will enter the coefficients " +
                "\r\nof the polynomial along with the miniumum and " +
                "\r\nmaximum of the domain, and I will do the rest.");
            WriteLine();

            do
            {
                WriteLine($"Enter the deatils for polynomial #{polyNum}");
                try
                {
                    Write("Enter the degree of the polynomial: ");
                    degree = int.Parse(ReadLine());

                }
                catch (FormatException)
                {
                    WriteLine("The degree must be an integer...");
                    WriteLine();
                    continue;
                }

                try
                {
                    WriteLine("Specify the coefficients for f(x) = ax^3 + bx^2 + cx + d:");
                    Write("Enter d: ");
                    d = int.Parse(ReadLine());
                    if (degree > 0)
                    {
                        Write("Enter c: ");
                        c = int.Parse(ReadLine());
                    }
                    if (degree > 1)
                    {
                        Write("Enter b: ");
                        b = int.Parse(ReadLine());
                    }
                    if (degree > 2)
                    {
                        Write("Enter a: ");
                        a = int.Parse(ReadLine());
                    }
                }
                catch (FormatException)
                {
                    WriteLine("The coefficient must be a number...");
                    WriteLine();
                    continue;
                }

                try
                {
                    Write("Enter min x: ");
                    minx = int.Parse(ReadLine());
                    Write("Enter max x: ");
                    maxx = int.Parse(ReadLine());

                    // Check if the limits are in the correct order, swap if necessary
                    if (maxx < minx)
                    {
                        temp = maxx;
                        maxx = minx;
                        minx = temp;
                    }
                }
                catch (FormatException)
                {
                    WriteLine("The min and max limits must be integers...");
                    WriteLine();
                    continue;
                }

                WriteLine($"Here is the polynomial over the domain {minx} through {maxx}:");
                WriteLine($"{"x",3}{"y",12}");

                for (int x = minx; x <= maxx; x++)
                {
                    fofx = (a * Math.Pow(x, 3)) + (b * Math.Pow(x, 2)) + (c * x) + d;
                    WriteLine($"{x,3}{fofx,12:F2}");
                }

                WriteLine();
                Write("Do you want to compute another polynomial (y or n)? ");
                doAgain = ReadLine().ToUpper();
                polyNum++;
                WriteLine();
            } while (doAgain == "Y");

            WriteLine("That was so crazy fun I bet you got dizzy.");
        }
        static void PrintHeading()
        {
            WriteLine(new string('*', 50));
            WriteLine($"{"Polynomial Calculator V1.0", 38}");
            WriteLine(new string('*', 50));
        }
    }
}
