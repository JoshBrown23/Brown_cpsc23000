using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Library
    {
        public List<Holding> holdings { get; private set; }

        public Library() 
        { 
            holdings = new List<Holding>();
        }

        public void AddHolding(Holding holding)
        {
            holdings.Add(holding);
        }

        public bool CheckOut(int id)
        {

            Holding result = holdings.Find(h => h.ID == id);
            if (result != null && result.CheckoutStatus == false)
            {
                result.CheckoutStatus = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckIn(int id)
        {
            Holding result = holdings.Find(h => h.ID == id);
            if (result != null && result.CheckoutStatus == true)
            {
                result.CheckoutStatus = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ListAll()
        {
            //Get the holdings that are checked out (not available)
            List<Holding> checkedOutHoldings = holdings.Where(h => h.CheckoutStatus == true).ToList();
            Console.WriteLine("These holdings are checked out:");
            if (checkedOutHoldings.Count > 0)
            {
                HoldingsWriter.WriteHoldingsToScreen(checkedOutHoldings);
            }
            else
            {
                Console.WriteLine("No holdings are checked out.");
                Console.WriteLine();
            }

            //Get the holdings that are checked in (available)
            List<Holding> checkedInHoldings = holdings.Where(h => h.CheckoutStatus == false).ToList();
            Console.WriteLine("These holdings are available:");
            if (checkedInHoldings.Count > 0)
            {
                HoldingsWriter.WriteHoldingsToScreen(checkedInHoldings);
            }
            else
            {
                Console.WriteLine("No holdings are available");
                Console.WriteLine();
            }
        }

        public string GetStats()
        {
            int available = 0;
            int checkedOut = 0;

            foreach (Holding holding in holdings)
            {
                if (holding.CheckoutStatus == false)
                {
                    available++;
                }
                else
                {
                    checkedOut++;
                }
            }

            return $"Available:\t{available}\nChecked Out:\t{checkedOut}";
        }

    }
}
