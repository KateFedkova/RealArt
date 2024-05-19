using System.Text.Json.Serialization;

namespace RealArt.Models
{
    public class Organisation : User
    {
        public string? Address { get; set; }
        
        public string? OpeningTime { get; set; }

        public string? ClosingTime { get; set; }

        public string? Time
        {
            get
            {
                if (OpeningTime == null || ClosingTime == null)
                {
                    return null;
                }
                
                return $"{OpeningTime} - {ClosingTime}";  
            }
        }

        public Organisation(string username, string password) : base(username, password)
        {

        }


        [JsonConstructor]
        public Organisation(Guid id, string username, string password) : base(id, username, password)
        {

        }
    }
}
