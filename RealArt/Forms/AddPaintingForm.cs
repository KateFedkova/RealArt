using RealArt.Models;
using System.Configuration;
using System.Text.Json;

namespace RealArt
{
    public partial class AddPaintingForm : Form
    {
        public AddPaintingForm()
        {
            InitializeComponent();
        }

        private void AddPaintingForm_Load(object sender, EventArgs e)
        {
            if (CurrentUser.Info is Person)
            {
                PersonElementsVisibility();
            }

            else if (CurrentUser.Info is Organisation)
            {
                List<string> artists = GetAllArtists();
                ArtistComboBox.DataSource = artists;
                ArtistComboBox.DisplayMember = "Value";
            }
        }

        private void PersonElementsVisibility()
        {
            ArtistLabel.Visible = false;
            ArtistComboBox.Visible = false;
            PriceLabel.Visible = false;
            PriceTextBox.Visible = false;
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg, *.png)|*.jpg;*.png";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    PaintingPictureBox.ImageLocation = dialog.FileName;
                }
            }

            catch (Exception)
            {
                MessageBox.Show("При завантаженні сталася помилка");
            }
        }

        private void PriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string title = TitleTextBox.Text;
            string style = GenreTextBox.Text;
            string date = CreationDate.Text;
            string photo = PaintingPictureBox.ImageLocation;
            int? price = PriceTextBox.Text == "" ? null : Convert.ToInt32(PriceTextBox.Text);
            string? type = GetPaintingType();

            if (CheckInfoIsGiven(title, style, date, type, photo))
            {
                Painting? painting = null;

                if (CurrentUser.Role == "Artist")
                {
                    painting = new Painting(title, style, date, type, photo);
                    painting.ArtistName = CurrentUser.Info.Username;
                }

                else if (CurrentUser.Role == "Collector" || CurrentUser.Role == "Organisation" || CurrentUser.Role == "Museum")
                {
                    painting = new Painting(title, style, date, type, price, photo);

                    if (!string.IsNullOrEmpty(ArtistComboBox.Text))
                    {
                        painting.ArtistName = ArtistComboBox.Text;
                    }

                    else
                    {
                        MessageBox.Show("Художник не був обран");
                        return;
                    }
                }

                AddPaintingToOwner(CurrentUser.Role, painting.Id);
                CurrentUser.Info.Pictures.Add(painting.Id);
                string json = JsonSerializer.Serialize(painting);
                string? path = ConfigurationManager.AppSettings["PathToPaintingsData"];

                if (path != null)
                {
                    File.AppendAllText(path, json + '\n');
                }
            }

            else
            {
                MessageBox.Show("Не всі дані були надані");
                this.DialogResult = DialogResult.None;
            }
        }

        private string? GetPaintingType()
        {
            string? type = null;
            if (OriginalRadio.Checked) type = "Original";
            else if (CopyRadio.Checked) type = "Copy";
            return type;
        }

        private bool CheckInfoIsGiven(string title, string style, string date, string type, string photo)
        {
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(style) || string.IsNullOrEmpty(date) || string.IsNullOrEmpty(type) || string.IsNullOrEmpty(photo))
            {
                return false;
            }
            return true;
        }

        private List<string> GetAllArtists()
        {
            string[] jsonLines = ReadFile("Artists");

            List<string> data = new List<string>();

            foreach (string userString in jsonLines)
            {
                Person? user = JsonSerializer.Deserialize<Person?>(userString);
                if (user != null)
                {
                    data.Add(user.Username);
                }
            }

            return data;
        }

        private void AddPaintingToOwner(string role, Guid PaintingId)
        {
            string[] jsonLines = ReadFile(role + "s");
            List<User> users = new List<User>();

            foreach (string userString in jsonLines)
            {
                User? user = null;

                if (role == "Artist" || role == "Collector")
                {
                    user = JsonSerializer.Deserialize<Person?>(userString);
                }

                else if (role == "Museum" || role == "Organisation")
                {
                    user = JsonSerializer.Deserialize<Organisation?>(userString);
                }

                if (user?.Id == CurrentUser.Info.Id)
                {
                    user.Pictures.Add(PaintingId);
                }
                users.Add(user);
            }

            UpdateInfoInFiles(role, users);
        }

        private string[] ReadFile(string role)
        {
            string? data = ConfigurationManager.AppSettings["PathTo" + role + "Data"];

            string jsonData = File.ReadAllText(data);

            string[] jsonLines = jsonData.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            return jsonLines;
        }

        private void UpdateInfoInFiles(string role, List<User> users)
        {
            string? filePath = ConfigurationManager.AppSettings["PathTo" + role + "s" + "Data"];
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
}
