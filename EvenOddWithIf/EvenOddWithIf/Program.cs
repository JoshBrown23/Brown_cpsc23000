using static System.Console;
/* This simple program asks the user for an integer and then determines 
 * if it is even or odd */
namespace EvenOddWithIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Write("Enter an integer: ");
            try
            {
                number = int.Parse(ReadLine());
            }
            catch (FormatException)
            {
                WriteLine("You had to enter an integer.");
                return;
            }

            if (number % 2 == 0)
            {
                WriteLine($"THe number {number} is even.");
            } 
            else {
                WriteLine($"The number {number} is odd.");
            }

        }
    }
}
