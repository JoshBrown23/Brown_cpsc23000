using static System.Console;
namespace CompanySimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company("Lewis Industries", 1932);
            company.AddEmployee("Ray", "Klump", 42.50);
            company.AddEmployee("Joe", "Schmoe", 37.75);

            CompanyWriter.WriteCompanyToScreen(company);
            double maxPayout = company.CalculateTotalFullTimePay();
            WriteLine($"The maximum weekly payout is {maxPayout,0:C}.");
            WriteLine("Now we will compute the pay for an employee you choose...");
            WriteLine("Enter the first and last name separated by a space: ");
            string response = Console.ReadLine();
            string[] parts = response.Split();
            double hoursWorked;
            WriteLine("enter hours worked: ");
            hoursWorked = double.Parse(ReadLine());
            double payAmount;
            try
            {
                payAmount = company.GetPayAmount(parts[0], parts[1], hoursWorked);
                WriteLine($"{parts[0]} {parts[1]} earned {payAmount,0:C}");
            } catch (Exception ex)
            {
                WriteLine("That employee does not exist...");
            }
        }
    }
}
