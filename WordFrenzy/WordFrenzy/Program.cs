/*
 * User will enter lines of text.
 * We will then show them the words they entered sorted.
 */

using static System.Console;
namespace WordFrenzy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string response;
            string[] parts;
            List<string> words = new List<string>();
            do
            {
                Write("Enter a line of text or quit to stop.");
                response = ReadLine();
                if (response != "quit")
                {
                    parts = response.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    foreach(string part in parts)
                    {
                        words.Add(part);
                    }
                }
            } while (response != "quit");
            words.Sort();
            foreach (string word in words) 
            { 
                WriteLine(word);
            }
        }
    }
}
