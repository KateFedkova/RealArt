using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealArt.Models
{
    internal class Auction
    {
        public readonly Guid ID;

        public string Name { get; set; }

        public string Date { get; set; }

        public string Time { get; set; }

        public List<Painting> Pictures { get; set; }

        public Auction(string name, string date, string time)
        {
            ID = Guid.NewGuid();
            Name = name;
            Date = date;
            Time = time;
            Pictures = new List<Painting>();
        }
    }
}
