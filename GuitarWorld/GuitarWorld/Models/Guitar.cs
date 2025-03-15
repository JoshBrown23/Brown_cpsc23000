using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarWorld.Models
{
    public class Guitar
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string  Model { get; set; }
        private int year;

        public int Year
        {
            get
            {
                return year; 
            }

            set
            {
                if (value < 1000 || value >DateTime.Now.Year)
                {
                    year = DateTime.Now.Year;
                }
                else
                {
                    year = value;
                }
            }
        }

        public Guitar()
        {
            Name = string.Empty;
            Manufacturer = string.Empty;
            Model = string.Empty;
            Year = 0;
        }

        public Guitar(string name, string manufacturer, string model, int year)
        {
            Name = name;
            Manufacturer = manufacturer;
            Model = model;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Name}\t{Manufacturer}\t{Model}\t{Year}";
        }

        public Guitar CreateGuitar(string description)
        {
            string[] parts = description.Split("\t");
            Guitar result = new Guitar(parts[0], parts[1], parts[2], int.Parse(parts[3]));
            return result;
        }
    }
}
