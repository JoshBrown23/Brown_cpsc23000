/*
 * Generate a user-specified set of random numbers
 * and then print them out.
 */

using static System.Console;
namespace FunWithRandoms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int howMany, minNum, maxNum, temp;
            Write("How many numbers do you want? ");
            howMany = int.Parse(ReadLine());
            Write("Enter the min: ");
            minNum = int.Parse(ReadLine());
            Write("Enter the max: ");
            maxNum = int.Parse(ReadLine());

            if (minNum > maxNum)
            {
                temp = minNum;
                minNum = maxNum;
                maxNum = temp;
            }

            Random rnd = new Random();
            int[] numbers = new int[howMany];
            for (int i = 0; i < howMany; i++) { 
                numbers[i] = rnd.Next(minNum, maxNum);
            }
            WriteLine("Here are your numbers:");
            Array.Sort(numbers);
            foreach (int number in numbers) {
                WriteLine(number);
            }

            //Now enable the user to search for a value
            int target, pos;

            do
            {
                Write("Enter 0 or positive number, or negative to quit: ");
                target = int.Parse(ReadLine());
                if (target >= 0)
                {
                    pos = Array.IndexOf(numbers, target); // returns -1 if not found
                    if (pos == -1)
                    {
                        WriteLine($"{target} was not found.");
                    }
                    else
                    {
                        WriteLine($"{target} was found at position {pos}");
                    }

                }
            } while (target >= 0);

        }
    }
}
