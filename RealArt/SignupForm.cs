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
            this.Hide();
        }

        private void ToMain_Click(object sender, EventArgs e)
        { 
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            string username = NameArea.Text;
            string password = PasswordArea.Text;
            bool checkedRole = ArtistRadio.Checked || —ollectorRadio.Checked || OrganisationRadio.Checked;

            if (CheckInfoIsGiven(username, password, checkedRole))
            {
                string json;
                string path;

                password = HashPassword(password);

                if (OrganisationRadio.Checked)
                {
                    Organisation organisation = new Organisation(username, password);
                    json = JsonSerializer.Serialize(organisation);
                    path = ConfigurationManager.AppSettings["PathToOrganisationsData"];
                }
                else
                {
                    Person person = new Person(username, password);
                    json = JsonSerializer.Serialize(person);
                    path = ConfigurationManager.AppSettings["PathToArtistsData"];
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

        private string HashPassword(string password)
        {
            string passwordHash = BCrypt.Net.BCrypt.EnhancedHashPassword(password, 13);
            return passwordHash;
        }
    }
}
