using System.Text.Json.Serialization;

namespace RealArt.Models
{
    public class Person : User
    {
        public string? Style { get; set; }

        public Person(string username, string password) : base(username, password)
        { 
        
        }

        [JsonConstructor]
        public Person(Guid id, string username, string password) : base(id, username, password)
        {
           
        }
    }
}
