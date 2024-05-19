using RealArt.Models;
using System.Text.Json;

namespace RealArt
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ToSignup_Click(object sender, EventArgs e)
        {
            SignUpForm signup = new SignUpForm();
            signup.Show();
            this.Close();
        }

        private void ToMain_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Close();
        }

        private void ToMainAfterLogin()
        {
            MainForm main = new MainForm();
            main.Show();
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = NameArea.Text;
            string password = PasswordArea.Text;
            string[] roles = { "Artist", "Сollector", "Museum", "Organisation" };

            if (CheckInfoIsGiven(username, password))
            {
                foreach (string role in roles)
                {
                    string? userJson = CheckUserRegistered(username, password, role);
                    if (userJson != null)
                    {
                        if (role == "Artist" || role == "Сollector")
                        {
                            CurrentUser.Info = JsonSerializer.Deserialize<Person?>(userJson);
                            CurrentUser.Role = role == "Artist" ? "Artis" : "Collector";
                            ToMainAfterLogin();
                            return;
                        }
                        else if (role == "Museum" || role == "Organisation")
                        {
                            CurrentUser.Info = JsonSerializer.Deserialize<Organisation?>(userJson);
                            CurrentUser.Role = role == "Museum" ? "Museum" : "Organisation";
                            ToMainAfterLogin();
                            return;
                        }
                     }
                }

                MessageBox.Show("Такий користувач не зареєстрований");
                return;
            }

            else
            {
                MessageBox.Show("Не всі дані були надані");
            }
        }

        private bool CheckInfoIsGiven(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return false;
            }
            return true;
        }

        private string? CheckUserRegistered(string username, string password, string role)
        {
            string[] jsonLines = FileWorker.ReadFile(role + "s");

            foreach (string jsonLine in jsonLines)
            {

                if (role == "Artist" || role == "Сollector")
                {
                    Person? user = JsonSerializer.Deserialize<Person?>(jsonLine);
                    ;
                    if (user?.Username == username && VerifyPassword(password, user.Password))
                    {
                        return jsonLine;
                    }
                }

                else if (role == "Museum" || role == "Organisation")
                {
                    Organisation? user = JsonSerializer.Deserialize<Organisation?>(jsonLine);

                    if (user?.Username == username && VerifyPassword(password, user.Password))
                    {
                        return jsonLine;
                    }
                }
            }

            return null;
        }

        private bool VerifyPassword(string password, string passwordHash)
        {
            bool result = BCrypt.Net.BCrypt.EnhancedVerify(password, passwordHash);
            return result;
        }
    }
}
