/*This program determines if a number entered by the user
 * is even or odd. It uses an inline conditional to do so.
 */
using static System.Console;
namespace EvenOddUsingInLineConditional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Write("Enter a number: ");
            number = int.Parse(ReadLine());
            //string judgment = number % 2 == 0 ? "even" : "odd";
            //WriteLine($"The number {number} is {judgment}");
            WriteLine($"The number {number} is {(number % 2 == 0 ? "even" : "odd")}");
        }
    }
}
