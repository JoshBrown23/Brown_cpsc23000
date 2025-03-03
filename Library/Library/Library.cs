using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Library
    {
        public List<Holding> Holdings { get; private set; }

        public void AddBook(int id, string title, string description, int copyrightYear, string author)
        {
            Book book = new Book(id, title, description, copyrightYear, author);
            Holdings.Add(book);
        }

        public void AddPeriodical(int id, string title, string description, string publicationDate)
        {
            Periodical periodical = new Periodical(id, title, description, publicationDate);
            Holdings.Add(periodical);
        }

        public void CheckOut (int id) 
        { 
            try
        }
    }
}
