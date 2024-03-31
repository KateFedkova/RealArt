using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealArt.Models
{
    internal class Person : User
    {
        public string? Style { get; set; }

        public Person(string username, string password) : base(username, password)
        { 
        
        }
    }
}
