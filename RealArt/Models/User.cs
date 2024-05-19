using System.Configuration;
using System.Text.Json.Serialization;

namespace RealArt.Models
{
    public class User
    {
        public Guid Id { get; private set; }

        public string Username { get; set; }
        
        public string Password { get; set; }
        
        public string? Country { get; set; }
        
        public string? About { get; set; }

        public string? Photo { get; set; } = ConfigurationManager.AppSettings["ImageNotFound"];

        public List<Guid> Pictures { get; set; }
        
        public User(string username, string password)
        {
            Id = Guid.NewGuid();
            Username = username;
            Password = password;
            Pictures = new List<Guid>();
        }

        [JsonConstructor]
        public User(Guid id, string username, string password) : this(username, password)
        {
            Id = id;
        }
    }
}
