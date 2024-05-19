using System.Configuration;
using System.Text.Json;

namespace RealArt.Models
{
    public static class FileWorker
    {
        public static string[] ReadFile(string role)
        {
            string? data = ConfigurationManager.AppSettings["PathTo" + role + "Data"];
            string jsonData = File.ReadAllText(data);
            string[] jsonLines = jsonData.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            return jsonLines;
        }

        public static void UpdateInfoInFiles(string role, List<User> users)
        {
            string? filePath = ConfigurationManager.AppSettings["PathTo" + role + "s" + "Data"];

            if (filePath != null)
            {
                File.WriteAllText(filePath, string.Empty);

                foreach (User user in users)
                {
                    string updatedJson = "";

                    if (role == "Artist" || role == "Collector")
                    {
                        updatedJson = JsonSerializer.Serialize((Person)user);
                    }

                    else if (role == "Museum" || role == "Organisation")
                    {
                        updatedJson = JsonSerializer.Serialize((Organisation)user);
                    }

                    File.AppendAllText(filePath, updatedJson + '\n');
                }
            }
        }

        public static void UpdateInfoInAuctions(List<Auction> auctions)
        {
            string? filePath = ConfigurationManager.AppSettings["PathToAuctionsData"];

            if (filePath != null)
            {
                File.WriteAllText(filePath, string.Empty);

                foreach (Auction auction in auctions)
                {
                    string updatedJson = JsonSerializer.Serialize(auction);
                    File.AppendAllText(filePath, updatedJson + '\n');
                }
            }
        }

        public static void AppendToFile(string filePath, object item)
        {
            string? path = filePath;
            string json = JsonSerializer.Serialize(item);

            if (path != null)
            {
                File.AppendAllText(path, json + '\n');
            }
        }

        public static void AppendToFilePaintings(string filePath, List<Painting> paintings)
        {
            if (filePath != null)
            {
                File.WriteAllText(filePath, string.Empty);

                foreach (Painting painting in paintings)
                {
                    string updatedJson = JsonSerializer.Serialize(painting);
                    File.AppendAllText(filePath, updatedJson + '\n');
                }
            }
        }
    }
}