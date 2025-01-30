/* using a do while loop, we'll ask the user to enter a number
 * and then keep adding the numbers they enter to a running total.
 * At the end, we'll show the sum and the average.
 * */
using static System.Console;
namespace AddUpNumbersUntilUserTired
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            int numNums = 0;
            double number;
            string doAgain;
            do
            {
                Write("Enter a number: ");
                number = double.Parse(ReadLine());
                total = total + number;
                numNums = numNums + 1;
                Write("Do you want another number? ");
                doAgain = ReadLine().ToUpper();
            } while (doAgain == "Y"); // continue as long as they indicated they want another number
            WriteLine($"The sum of the number is {total,0:F2}.");
            double avg = total / numNums;
            WriteLine($"The average of the numbers is {avg,0:F2}.");
        }
    }
}
