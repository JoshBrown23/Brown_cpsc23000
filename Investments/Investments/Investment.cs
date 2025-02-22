using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investments
{
    internal abstract class Investment
    {
        //These are the data members and properties that are inherent to all Investments
        private DateTime openingDate;

        public string ID { get; set; }

        public string NameOfHolder { get; set; }

        public double Balance { get; set; }
        public string OpeningDate
        {
            get
            {
                return openingDate.ToString("MM/dd/yyyy");
            }

            set
            {
                if (DateTime.TryParseExact(value, "M/d/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
                {
                    openingDate = parsedDate;
                }
                else
                {
                    throw new ArgumentException("Invalid date format");
                }
            }
        }

        //These are the default and specified constructors for the Investment superclass
        public Investment() 
        {
            ID = "INV01";
            NameOfHolder = "John Doe";
            Balance = 100;
            OpeningDate = "01/01/2000";
        }

        public Investment(string id, string nameOfHolder, double balance, string openingDate)
        {
            ID = id;
            NameOfHolder = nameOfHolder;
            Balance = balance;
            OpeningDate = openingDate;
        }

        //These are the default GetType and ToString functions for the Investment superclass
        public virtual string GetType()
        {
            return "Investment";
        }
        public override string ToString()
        {
            return $"TYPE: {GetType()} ID: {ID} NAME: {NameOfHolder} BALANCE: {Balance, 0:C} DATE: {OpeningDate}";
        }
        
        //This is an abstract function that is overriden by the child classes of Investment
        public abstract void ApplyAutomaticAdjustments();
    }
}
