/* computes total and average of numbers entered by user.
 * Uses a while loop instead of a do while */
using static System.Console;
namespace AddUpNumbersUntilUserTiredUsingWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            int numNums = 0;
            double number;
            string doAgain = "Y";
            while (doAgain == "Y") {
                Write("Enter a number: ");
                number = double.Parse(ReadLine());
                total = total + number;
                numNums = numNums + 1;
                Write("Do you want another? ");
                doAgain = ReadLine().ToUpper();
            }
            WriteLine($"The sum of the number is {total,0:F2}.");
            double avg = total / numNums;
            WriteLine($"The average of the numbers is {avg,0:F2}.");
        }
    }
}
