using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investments
{
    internal class CD: Investment
    {
        //These are the data members and properties that are unique to the CD subclass
        private double interestRate;

        public double InterestRate
        {
            get
            {
                return interestRate;
            }

            set
            {
                if (value < 1)
                {
                    interestRate = 1.1;
                }
                else
                {
                    interestRate = value;
                }
            }
        }
        
        //These are the default and specified constructors of the CD subclass
        public CD()
        {
            InterestRate = 1.5;
        }

        public CD(string id, string nameOfHolder, double balance, string openingDate, double interestRate):base(id, nameOfHolder, balance, openingDate)
        {
            InterestRate = interestRate;
        }

        //These are the overrident GetType and ToString functions derived from the Investment superclass
        public override string GetType()
        {
            return "CD";
        }

        public override string ToString()
        {
            return $"{base.ToString()} INTEREST RATE: {InterestRate, 0:F2}";
        }

        //An overriden abstract function derived from the Investment superclass
        //This function calculates the interest that a CD object has accrued
        public override void ApplyAutomaticAdjustments()
        {
            double interest;
            interest = Balance * (InterestRate/100);
            Balance = Balance + interest;
        }
    }
}
