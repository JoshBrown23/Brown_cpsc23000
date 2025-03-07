using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal abstract class Holding
    {        
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool CheckoutStatus { get; set; }

        public Holding()
        {
            ID = 0;
            Title = "";
            Description = "";
            CheckoutStatus = false;
        }

        public Holding(int id, string title, string description)
        {
            ID = id;
            Title = title;
            Description = description;
            CheckoutStatus = false;
        }

        public void ReserverHolding()
        {
            CheckoutStatus = true;
        }

        public void ReturnHolding()
        {
            CheckoutStatus = false;
        }

        public abstract string HoldingType();


        public override string ToString()
        {
            return $"{ID}\n{HoldingType()}\n{Title}\n{Description}\n{GetCheckoutStatusAsString()}";
        }

        private string GetCheckoutStatusAsString()
        {
            if (CheckoutStatus == false)
            {
                return "Available";
            }
            else
            {
                return "Checked Out";
            }
        }

        public abstract Holding CreateHolding(string[] desc);
    }
}
