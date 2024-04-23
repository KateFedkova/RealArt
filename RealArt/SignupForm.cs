using System.Configuration;
using System.Text.Json;
using RealArt.Models;

namespace RealArt
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void ToLogin_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void ToMain_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Close();
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            string username = NameArea.Text;
            string password = PasswordArea.Text;
            string checkedRole = GetSelectedRole();

            if (CheckInfoIsGiven(username, password, checkedRole))
            {
                string json;
                string path;

                password = HashPassword(password);

                if (!CheckUsernameIsUsed(username, checkedRole))
                {
                    var user = CreatePersonOrOrganisation(username, password, checkedRole);

                    if (user != null)
                    {
                        json = JsonSerializer.Serialize(user);
                        path = GetPathForRole(checkedRole);
                        File.AppendAllText(path, json + '\n');
                    }
                }

                else
                {
                    MessageBox.Show("¡Û‰¸ Î‡ÒÍ‡ Ó·Â≥Ú¸ ≥Ì¯ËÈ username");
                    return;
                }
            }

            else
            {
                MessageBox.Show("ÕÂ ‚Ò≥ ‰‡Ì≥ ·ÛÎË Ì‡‰‡Ì≥");
            }
        }

        private bool CheckInfoIsGiven(string username, string password, string checkedRole)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(checkedRole))
            {
                return false;
            }
            return true;
        }

        private string? GetSelectedRole()
        {
            if (ArtistRadio.Checked) return "Artists";
            else if (—ollectorRadio.Checked) return "—ollectors";
            else if (MuseumRadio.Checked) return "Museums";
            else if (OrganisationRadio.Checked) return "Organisations";
            return null;
        }

        private bool CheckUsernameIsUsed(string username, string role)
        {
            string[] jsonLines = ReadFile(role);

            foreach (string jsonLine in jsonLines)
            {
                if (role == "Artists" || role == "—ollectors")
                {
                    Person user = JsonSerializer.Deserialize<Person>(jsonLine);
                    if (user.Username == username) return true;
                }
                
                else if (role == "Museums" || role == "Organisations")
                {
                    Organisation user = JsonSerializer.Deserialize<Organisation>(jsonLine);
                    if (user.Username == username) return true;
                }
            }

            return false;
        }

        private string[] ReadFile(string role)
        {
            string? data = ConfigurationManager.AppSettings["PathTo" + role + "Data"];

            string jsonData = File.ReadAllText(data);

            string[] jsonLines = jsonData.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            
            return jsonLines;
        }

        private object? CreatePersonOrOrganisation(string username, string password, string role)
        {
            switch (role)
            {
                case "Artists":
                case "—ollectors":
                    return new Person(username, password);
                case "Museums":
                case "Organisations":
                    return new Organisation(username, password);
                default:
                    return null;
            }
        }

        private string? GetPathForRole(string role)
        {
            switch (role)
            {
                case "Artists":
                    return ConfigurationManager.AppSettings["PathToArtistsData"];
                case "—ollectors":
                    return ConfigurationManager.AppSettings["PathTo—ollectorsData"];
                case "Museums":
                    return ConfigurationManager.AppSettings["PathToMuseumsData"];
                case "Organisations":
                    return ConfigurationManager.AppSettings["PathToOrganisationsData"];
                default:
                    return null;
            }
        }

        private string HashPassword(string password)
        {
            string passwordHash = BCrypt.Net.BCrypt.EnhancedHashPassword(password, 13);
            return passwordHash;
        }
    }
}
