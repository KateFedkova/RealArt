using RealArt.Models;
using System.Configuration;
using System.Text.Json;

namespace RealArt
{
    public partial class AddAuctionForm : Form
    {
        public AddAuctionForm()
        {
            InitializeComponent();
            AuctionDate.MinDate = DateTime.Now;
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

        private void OkButton_Click(object sender, EventArgs e)
        {
            string title = TitleTextBox.Text;
            string date = AuctionDate.Text;
            string time = AuctionTime.Text;
            string photo = PaintingPictureBox.ImageLocation;

            if (CheckInfoIsGiven(title, date, time, photo))
            {
                Auction auction = new Auction(title, date, time, CurrentUser.Info.Username);
                             
                AddAuctionToOwner(CurrentUser.Role, auction.Id);
                
                string json = JsonSerializer.Serialize(auction);
                string? path = ConfigurationManager.AppSettings["PathToAuctionsData"];

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

        private bool CheckInfoIsGiven(string title, string date, string time, string photo)
        {
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(date) || string.IsNullOrEmpty(time) || string.IsNullOrEmpty(photo))
            {
                return false;
            }
            return true;
        }

        private void AddAuctionToOwner(string role, Guid AuctionId)
        {
            string[] jsonLines = ReadFile(role + "s");
            CurrentUser.Info.Pictures.Add(AuctionId);
            List<Organisation> users = new List<Organisation>();

            foreach (string userString in jsonLines)
            {
                Organisation? user = JsonSerializer.Deserialize<Organisation?>(userString);
                
                if (user?.Id == CurrentUser.Info.Id)
                {
                    user.Pictures.Add(AuctionId);
                }

                if (user != null)
                {
                    users.Add(user);
                }
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

        private void UpdateInfoInFiles(string role, List<Organisation> users)
        {
            string? filePath = ConfigurationManager.AppSettings["PathTo" + role + "s" + "Data"];
            File.WriteAllText(filePath, string.Empty);

            foreach (User user in users)
            {
                string updatedJson = JsonSerializer.Serialize((Organisation)user);
                File.AppendAllText(filePath, updatedJson + '\n');
            }
        }
    }
}
