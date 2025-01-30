/* Payroll example with a set number of employees */
using static System.Console;
namespace CompanyPayrollSetNumberOfEmployees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintHeading();
            int empCount;
            double hoursWorked, payRate, gross, taxes, taxRate, net, totalPay = 0, averagePay;
            Write("Enter number of employees: ");
            empCount = int.Parse(ReadLine());
            for (int i = 1; i <= empCount; i++) {
                WriteLine($"Employee #{i}");
                Write("Enter the hours worked: ");
                hoursWorked = double.Parse(ReadLine());
                Write("Enter the pay rate: ");
                payRate = double.Parse(ReadLine());

                gross = hoursWorked * payRate;

                //determine tax rate based on gross pay
                if (gross >= 2000) {
                    taxRate = 0.25;
                }
                else if (gross >= 1000) {
                    taxRate = 0.15;
                }
                else {
                    taxRate = 0.1;
                }

                // Calculate taxes and net pay
                taxes = taxRate * gross;
                net = gross - taxes;
                totalPay = totalPay + gross;

                // Print the paycheck summary
                WriteLine();
                WriteLine("Here is a summary:");
                WriteLine($"{"Gross Pay",-15}{gross,10:C}");
                WriteLine($"{"Taxes",-15}{taxes,10:C}");
                WriteLine($"{"Net Pay",-15}{net,10:C}");
                WriteLine();
            }
            WriteLine();
            WriteLine($"The total gross pay was {totalPay,0:C}.");
            averagePay = totalPay / empCount;
            WriteLine($"The average gross pay per employee was {averagePay,0:C}.");
        }

        static void PrintHeading()
        {
            WriteLine(new string('*', 50));
            WriteLine($"{"Paycheck Calculator V1.0",37}");
            WriteLine(new string('*', 50));
        }
    }
}
