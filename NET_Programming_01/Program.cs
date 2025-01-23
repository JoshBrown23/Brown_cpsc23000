using static System.Console;
namespace NET_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Get employee's name
            WriteLine("Hello, welcome to the payroll system!");
            Write("Please enter the employee's name: ");
            string employeeName = ReadLine();

            //Get employee's payrate
            Write("Please enter the employee's payrate: ");
            try
            { 
                double payrate = Double.Parse(ReadLine());
                double hoursWorked = Double.Parse(ReadLine());
            }
            catch(FormatException)
            {
                WriteLine("Please submit a valid entry (i.e. integer/double)...");
            }



        }
    }
}
