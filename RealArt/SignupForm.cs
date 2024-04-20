using System.Configuration;
using System.Text;
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
            bool checkedRole = ArtistRadio.Checked || —ollectorRadio.Checked || MuseumRadio.Checked || OrganisationRadio.Checked;

            if (CheckInfoIsGiven(username, password, checkedRole))
            {
                string json;
                string path;

                password = HashPassword(password);

                if (ArtistRadio.Checked && !CheckUsernameIsUsed(username, "Artists"))
                {
                    Person person = new Person(username, password);
                    json = JsonSerializer.Serialize(person);
                    path = ConfigurationManager.AppSettings["PathToArtistsData"];
                }

                else if (—ollectorRadio.Checked && !CheckUsernameIsUsed(username, "—ollectors"))
                {
                    Person person = new Person(username, password);
                    json = JsonSerializer.Serialize(person);
                    path = ConfigurationManager.AppSettings["PathTo—ollectorsData"];
                }

                else if (MuseumRadio.Checked && !CheckUsernameIsUsed(username, "Museums"))
                {
                    Organisation organisation = new Organisation(username, password);
                    json = JsonSerializer.Serialize(organisation);
                    path = ConfigurationManager.AppSettings["PathToMuseumsData"];
                }

                else if (OrganisationRadio.Checked && !CheckUsernameIsUsed(username, "Organisations"))
                {
                    Organisation organisation = new Organisation(username, password);
                    json = JsonSerializer.Serialize(organisation);
                    path = ConfigurationManager.AppSettings["PathToOrganisationsData"];
                }

                else
                {
                    MessageBox.Show("¡Û‰¸ Î‡ÒÍ‡ Ó·Â≥Ú¸ ≥Ì¯ËÈ username");
                    return;
                }

                File.AppendAllText(path, json + '\n');
            }

            else
            {
                MessageBox.Show("ÕÂ ‚Ò≥ ‰‡Ì≥ ·ÛÎË Ì‡‰‡Ì≥");
            }
        }

        private bool CheckInfoIsGiven(string username, string password, bool checkedRole)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || !checkedRole)
            {
                return false;
            }
            return true;
        }

        private bool CheckUsernameIsUsed(string username, string role)
        {
            string? data = ConfigurationManager.AppSettings["PathTo" + role + "Data"];
         
            string jsonData = File.ReadAllText(data);
            
            string[] jsonLines = jsonData.Split('\n', StringSplitOptions.RemoveEmptyEntries);

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

        private string HashPassword(string password)
        {
            string passwordHash = BCrypt.Net.BCrypt.EnhancedHashPassword(password, 13);
            return passwordHash;
        }
    }
}
