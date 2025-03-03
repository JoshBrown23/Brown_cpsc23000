using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Book: Holding
    {
        private int copyrightYear;
        public int CopyrightYear
        {
            get
            {
                return copyrightYear;
            }

            set
            {
                if (value < 1800 || value > 2025)
                {
                    throw new ArgumentException();
                }
                else
                {
                    copyrightYear = value;
                }
            }
        }
        public string Author { get; set; }
        
        public Book()
        {
            CopyrightYear = 2000;
            Author = "";
        }

        public Book(int id, string title, string description, int copyrightYear, string author):base(id, title, description)
        {
            CopyrightYear = copyrightYear;
            Author = author;
        }

        public override string HoldingType()
        {
            return "Book";
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n{CopyrightYear}\n{Author}";
        }
    }
}
