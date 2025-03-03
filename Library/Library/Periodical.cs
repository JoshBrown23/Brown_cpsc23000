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
            return $"{base.ToString()}\n{PublicationDate}";
        }
    }
}
