using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Periodical: Holding
    {
        public string PublicationDate { get; set; }

        public Periodical()
        {
            PublicationDate = "";
        }

        public Periodical(int id, string title, string description, string publicationDate):base(id, title, description)
        {
            PublicationDate = publicationDate;
        }

        public override string HoldingType()
        {
            return "Periodical";
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n{PublicationDate}\n\n";
        }

        public override Holding CreateHolding(string[] desc)
        {
            int id = int.Parse(desc[0]);
            string title = desc[1];
            string description = desc[2];
            string publicationDate = desc[3];
            return new Periodical(id, title, description, publicationDate);
        }
    }
}
