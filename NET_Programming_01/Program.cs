using System;
namespace NET_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            float x;
            x = Console.Read();
            Console.WriteLine(x == 0 ? "number not set" : x);
        }
    }
}
