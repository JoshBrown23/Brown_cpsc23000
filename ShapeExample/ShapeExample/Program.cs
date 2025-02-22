using static System.Console;
namespace ShapeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle defaultCircle = new Circle();
            Circle customCircle = new Circle(7, 3, 5);
            Rectangle defaultRectangle = new Rectangle();
            Rectangle customRectangle = new Rectangle(12, 5, 8, 10);

            List<Shape> shapes = new List<Shape>();
            shapes.Add(defaultCircle);
            shapes.Add(customCircle);
            shapes.Add(defaultRectangle);
            shapes.Add(customRectangle);

            PrintShapesToScreen(shapes);
            PrintAreasAndPerimeters(shapes);

            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                customCircle.RandomMove(rnd);
                customRectangle.RandomMove(rnd);
                WriteLine(customCircle);
                WriteLine(customRectangle);
            }
            
            //WriteLine("Here are your circles");
            //WriteLine(defaultCircle);
            //WriteLine(customCircle);
            //WriteLine($"The area of the circle is {customCircle.CalculateArea(), 0:F2}, and the perimeter is {customCircle.CalculatePerimeter(), 0:F2}");
            //WriteLine("Here are your rectangles.");
            //WriteLine(defaultRectangle);
            //WriteLine(customRectangle);
            //WriteLine($"The area of the rectangle is {customRectangle.CalculateArea(),0:F2}, and the perimeter is {customRectangle.CalculatePerimeter(),0:F2}");


        }

        static void PrintShapesToScreen(List<Shape> shapes)
        {
            foreach (Shape shape in shapes)
            {
                WriteLine(shape); //Thanks to polymorphism, the right ToString will be called
            }
        }

        static void PrintAreasAndPerimeters(List<Shape> shapes)
        {
            double area, perim;
            foreach (Shape shape in shapes)
            {
                area = shape.CalculateArea();
                perim = shape.CalculatePerimeter();
                WriteLine($"Area = {area,0:F2}, Perim = {perim,0:F2}");
            }
        }


    }
}