using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealArt.Models
{
    internal class Painting
    {
        public readonly Guid ID;

        public string Name { get; set; }

        public string Style { get; set; }

        public string Date { get; set; }

        public Guid Artist { get; set; } 

        public float Price { get; set; }

        public Painting(string name, string style, string date, Guid artist, float price)
        {
            ID = Guid.NewGuid();
            Name = name;
            Style = style;
            Date = date;
            Artist = artist;
            Price = price;
        } 

    }
}
