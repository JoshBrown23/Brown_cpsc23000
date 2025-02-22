using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investments
{
    internal class CheckingAccount: Investment
    {
        //These are the data members and properties that are unique to the CheckingAccount subclass
        private double overdraftFee;

        public double OverdraftFee
        {
            get 
            {
               return overdraftFee;
            }

            set
            {
                overdraftFee = value;
            }
        }

        //These are the default and specified constructors for the CheckingAccount subclass
        public CheckingAccount()
        {
            OverdraftFee = 10;
        }

        public CheckingAccount(string id, string nameOfHolder, double balance, string openingDate, double overdraftFee):base(id, nameOfHolder, balance, openingDate)
        {
            OverdraftFee= overdraftFee;
        }

        //These are the overriden GetType and ToString functions derived from the Investment superclass
        public override string GetType()
        {
            return "Checking";
        }

        public override string ToString()
        {
            return $"{base.ToString()} OVERDRAFT FEE: {overdraftFee, 0:C}";
        }

        //An overriden abstract function derived from the Investment superclass
        //This function determines whether a CheckingAccount object should appliy an overdraft fee
        //If so, this function will also subtract a predetermined amount from the CheckingAccount's balance
        public override void ApplyAutomaticAdjustments()
        {
            if (Balance < 0)
            {
                Balance = Balance - OverdraftFee;
            }
        }

        //This function allows the user to subtract a given amount of money from the balance of a CheckingAccount object
        public void Withdraw(double amount)
        {
            Balance = Balance - amount;
        }

        //This function allows the user to add a given amount of money to the balance of a CheckingAccount object
        public void Deposit (double amount)
        {
            Balance = Balance + amount;
        }
    }
}
