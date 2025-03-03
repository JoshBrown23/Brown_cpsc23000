using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySimulator
{
    internal class EmployeeWriter // view class
    {
        public static void WriteEmployeesToScreen(List<Employee> employees)
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
