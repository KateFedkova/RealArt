using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealArt.Models
{
    internal class User
    {
        public readonly Guid Id;

        public string Username { get; set; }
        
        public string Password { get; set; }
        
        public string? Country { get; set; }
        
        public string? About { get; set; }
        
        public string? Foto { get; set; }

        public List<Guid> Pictures { get; set; }
        
        public User(string username, string password)
        {
            Id = Guid.NewGuid();
            Username = username;
            Password = password;
            Pictures = new List<Guid>();
        }
    }

    
}
