using System.Text.Json.Serialization;

namespace RealArt.Models
{
    public class Painting
    {
        public Guid Id { get; private set; }

        public string Name { get; set; }
        
        public string Style { get; set; }
        
        public string Date { get; set; }
        
        public string? ArtistName { get; set; }
        
        public string Type { get; set; }
        
        public float? Price { get; set; }
        
        public string? Photo { get; set; } 

        public Painting(string name, string style, string date, string type, string photo)
        {
            Id = Guid.NewGuid();
            Name = name;
            Style = style;
            Date = date;
            Type = type;
            Photo = photo;
        }

        public Painting(string name, string style, string date, string type, float? price, string photo) : this(name, style, date, type, photo)
        {
            Price = price;
        }


        [JsonConstructor]
        public Painting(Guid id, string name, string style, string date, string type, float? price, string photo) : this(name, style, date, type, price, photo)
        {
            Id = id;
        }
    }
}
