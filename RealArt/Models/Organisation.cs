using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealArt.Models
{
    internal class Organisation : User
    {
        public string? Address { get; set; }
        
        public string? OpeningTime { get; set; }

        public string? ClosingTime { get; set; }

        public Organisation(string username, string password) : base(username, password)
        {

        }
    }
}
