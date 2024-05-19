using System.Text.Json.Serialization;

namespace RealArt.Models
{
    public class Auction
    {
        public Guid Id { get; private set; }

        public string Name { get; set; }

        public string Date { get; set; }

        public string Time { get; set; }

        public string Owner { get; set; }

        public string Photo { get; set; }

        public List<Guid> Pictures { get; set; }

        public Auction(string name, string date, string time, string owner, string photo)
        {
            Id = Guid.NewGuid();
            Name = name;
            Date = date;
            Time = time;
            Owner = owner;
            Photo = photo;
            Pictures = new List<Guid>();
        }

        [JsonConstructor]
        public Auction(Guid id, string name, string date, string time, string owner, string photo) : this(name, date, time, owner, photo)
        {
            Id = id;
        }
    }
}
