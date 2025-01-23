using static System.Console;
namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello, World!");
            Write("enter your name: ");
            string name = ReadLine();
            WriteLine($"It is nice to meet you, {name}.");
            Write("How old are you: ");
            int age = int.Parse(ReadLine());
            int ageInMonths = age * 12;
            WriteLine($"I see that you are {ageInMonths} months old.");
            double sqrtAgeInMonths = Math.Sqrt(ageInMonths);
            WriteLine($"The square root of your age in months is {sqrtAgeInMonths,0:C}.");
        }
    }
}
