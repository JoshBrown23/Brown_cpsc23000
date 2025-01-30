using static System.Console;
namespace GradeCommentor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Write("Enter your letter grade: ");
            string letterGrade = ReadLine().ToUpper();
            switch (letterGrade) 
            {
                case "A":
                    WriteLine("Congratulations! You're pretty smart.");
                    break;
                case "B":
                    WriteLine("Good job. Keep it up.");
                    break;
                case "C":
                    WriteLine("C is for cookie, and cookies are delicious.");
                    break;
                case "D":
                    WriteLine("D is for diploma.");
                    break;
                case "F":
                    WriteLine("Mom and Dad are going to be mad.");
                    break;
                default:
                    WriteLine("You're so dumb.");
                    break;
            }

        }
    }
}

