using static System.Console;
/* write a program that screens a person by their age to determine if they are
 * eligible to attend a 21-and-over concert unaccompanied. No one under 18 will
 * be admitted. If you are between 18 and 21, you must be accompanied by an adult.
 * Otherwise, you're allowed in.
 */
namespace ClubEntrance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Welcome to Bouncer, the club entrance tool.");
            WriteLine();
            int age;
            Write("Please enter your age: ");

            try
            {
                age = int.Parse(ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("You had to enter an integer. Quitting now.");
                return;
            }

            if (age < 0 || age > 115)
            {
                WriteLine("That is not a valid age.");
            }
            else if (age < 18)
            {
                WriteLine("You are not allowed in.");
                WriteLine("Next time, get a fake ID.");
            }
            else if (age < 21)
            {
                WriteLine("You must be accompanied by someone older than 21.");
            }
            else
            {
                WriteLine("Enjoy the show!");
            }
        }
    }
}
