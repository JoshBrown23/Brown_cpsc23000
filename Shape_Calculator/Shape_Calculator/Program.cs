using static System.Console;
namespace Shape_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine(new string('*', 51));
            WriteLine($"{"Shape Calculator V1.0", 36}");
            WriteLine(new string('*', 51));
            WriteLine();

            double width, length, height, cubeVol;
            
            //Get cube dimensions
            WriteLine("First, let's deal with a cube.");
            Write("What is the width? ");
            width = double.Parse(Console.ReadLine());
            Write("What is the length? ");
            length = double.Parse(Console.ReadLine());
            Write("What is the height? ");
            height = double.Parse(Console.ReadLine());

            //calculate the volume of the cube using input width, length, and height
            cubeVol = width * length * height; 
            WriteLine($"The cube's volume is {cubeVol, 0:F3}");
            WriteLine();

            double radius, sphereVol;

            //Get sphere dimensions
            WriteLine("Now, let's deal with a sphere.");
            Write("What is the radius? ");
            radius = double.Parse(Console.ReadLine());

            //Calculate the volume of the sphere using input radius
            sphereVol = 4.0 /3.0 * Math.PI * Math.Pow(radius, 3);
            WriteLine($"The sphere's volume is {sphereVol,0:F3}");
            WriteLine();

            //Find total volume of both shapes
            double shapeVol = cubeVol + sphereVol;
            WriteLine($"The total volume of the cube and sphere is {shapeVol, 0:F3}");
            WriteLine();
            WriteLine("Thank you for using this program.");

            




        }
    }
}
