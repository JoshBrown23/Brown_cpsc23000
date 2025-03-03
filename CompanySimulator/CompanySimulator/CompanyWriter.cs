using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySimulator
{
    internal class CompanyWriter
    {
        public static void WriteCompanyToScreen(Company company)
        {
            Console.WriteLine($"{"Name",-20}{company.Name}");
            Console.WriteLine($"{"Year Founded",-20}{company.YearFounded}");
            Console.WriteLine("List of employees:");
            EmployeeWriter.WriteEmployeesToScreen(company.Employees);
        }
    }
}