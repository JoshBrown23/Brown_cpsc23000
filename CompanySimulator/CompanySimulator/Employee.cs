using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySimulator
{
    internal class Employee
    {
        private double payRate;

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public double PayRate { 
            get
            {
                return payRate;
            }
            set
            {
                if (value < 0)
                {
                    payRate = 0;
                }
                else
                {
                    payRate = value;
                }
            }
        }

        public Employee()
        {
            FirstName = "";
            LastName = "";
            PayRate = 0;

        }

        public Employee(string firstName, string lastName, double payRate)
        {
            FirstName = firstName;
            LastName = lastName;
            PayRate = payRate;
        }

        public double CalculatePay(double hours)
        {
            return PayRate * hours;
        }

        public override string ToString()
        {
            return $"{FirstName}\t{LastName}\t{PayRate,0:C}";
        }
    }
}
