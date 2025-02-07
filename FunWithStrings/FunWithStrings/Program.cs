/*
 * This demonstrates various built-in methods of the string data type.
 */

using static System.Console;
namespace FunWithStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("Enter a greeting: ");
            string greeting = ReadLine();
            int numChars = greeting.Length;
            WriteLine($"You enter this phrase: \n\t{greeting}");
            string shouted = greeting.ToUpper();
            WriteLine($"That has {numChars}");
            WriteLine($"Uppercase, that's {shouted}");
            string part = greeting.Substring(2, 5); //Starting at pos 2, return 5 chars
            WriteLine($"Substring is {part}");
            Write("enter a substring to find: ");
            string findThis = ReadLine();
            int pos = greeting.IndexOf(findThis);
            if (pos == -1)
            {
                WriteLine("The string you specified was not found");
            }
            else
            {
                WriteLine($"The substring {findThis} was located at position {pos}.");
            }
            Write("What do you want to replace? ");
            string replaceThis = ReadLine();
            Write("Replace with what? ");
            string replaceWith = ReadLine();
            if (greeting.IndexOf(replaceThis) < 0)
            {
                WriteLine("not found");
            }
            else { 
                greeting = greeting.Replace(replaceThis, replaceWith);
                WriteLine($"The greeting is now {greeting}.");
            }
        }

    }
}
