using static System.Console;
namespace FunWithCircles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write("Enter x, y, and radius: ");
            //string response = ReadLine();
            //string[] parts = response.Split(" ");
            //double x, y, rad;
            //x = double.Parse(parts[0]);
            //y = double.Parse(parts[1]);
            //rad = double.Parse(parts[2]);
            //Circle circle = new Circle(rad, x, y);
            //double area, circumference;
            //area = circle.CalculateArea();
            //circumference = circle.CalculatePerim();
            //WriteLine("Here is the circle: ");
            //WriteLine(circle);
            //WriteLine($"Area = {area,0:F2}, Circumference = {circumference,0:F2}");

            List<Circle> circles = new List<Circle>();
            Random rnd = new Random();
            const int CIRCLE_COUNT = 10;
            const int MAX_SIZE = 500;
            for (int i = 0; i < CIRCLE_COUNT; i++)
            {
                circles.Add(new Circle(rnd.NextDouble()*MAX_SIZE, rnd.NextDouble()*MAX_SIZE, rnd.NextDouble()*MAX_SIZE));
            }

            PrintCircles(circles);

            List<Circle> sortedCircles = circles.OrderBy(x => x.Radius).ToList();
            WriteLine();
            WriteLine("Here they are sorted by radius:");
            PrintCircles(sortedCircles);

            List<Circle> bigOrLeftSideCircles = circles.Where(c => c.Radius >= 400 || c.X < 300).ToList();
            WriteLine();
            WriteLine("Here are the big circles...");
            PrintCircles(bigOrLeftSideCircles);

            double totalArea = circles.Sum(c => c.CalculateArea());
            WriteLine();
            WriteLine($"The total area of the circles is {totalArea}.");

            WriteLine();
            WriteLine("Old people like me might do it this way: ");
            totalArea = 0;
            foreach (Circle circle in circles)
            {
                totalArea = totalArea + circle.CalculateArea();
            }
            WriteLine($"The total area of the circles is {totalArea}.");
        }

        static void PrintCircles(List<Circle> circles)
        {
            foreach (Circle circle in circles)
            {
                WriteLine(circle);
            }
        }
    }
}
