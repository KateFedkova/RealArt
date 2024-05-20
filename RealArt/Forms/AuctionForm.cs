using RealArt.Models;
using System.Configuration;
using System.Text.Json;

namespace RealArt
{
    public partial class AuctionForm : Form
    {
        private Auction? auctionInfo;

        private User? userInfo;

        public AuctionForm(User userInfo, Auction? auctionInfo = null)
        {
            InitializeComponent();
            this.auctionInfo = auctionInfo;
            this.userInfo = userInfo;
        }

        private void AddAuctionForm_Load(object sender, EventArgs e)
        {
            if (userInfo != null && CurrentUser.Info.Id != userInfo.Id)
            {
                UploadButton.Visible = false;
                ShowPaintingsButton.Visible = false;
                AddPaintingButton.Visible = false;
                DeleteButton.Visible = false;
                UpdateButton.Visible = false;
                OkButton.Visible = false;
            }

            if (auctionInfo != null)
            {
                BindingSource bindingSource = new BindingSource();
                UploadButton.Visible = false;
                OkButton.Visible = false;
                SetInfo(bindingSource, auctionInfo);
                MakeReadonly();
            }

            else
            {
                AddPaintingButton.Visible = false;
                UpdateButton.Visible = false;
                DeleteButton.Visible = false;
                ShowPaintingsButton.Visible = false;
            }
        }

        private void MakeReadonly()
        {
            TitleTextBox.ReadOnly = true;
            AuctionDate.Enabled = false;
            AuctionTime.Enabled = false;
        }

        private void SetInfo(BindingSource source, Auction auction)
        {
            source.DataSource = auction;
            BindData(TitleTextBox, source, "Name");
            BindData(AuctionDate, source, "Date");
            BindData(AuctionTime, source, "Time");
            BindImage(PaintingPictureBox, source, "Photo");
        }

        private void BindData(Control control, object dataSource, string propertyName)
        {
            control.DataBindings.Clear();
            Binding binding = new Binding("Text", dataSource, propertyName, false, DataSourceUpdateMode.Never);
            binding.Format += (sender, e) =>
            {
                e.Value ??= "невідомо";
            };
            control.DataBindings.Add(binding);
        }

        private void BindImage(PictureBox pictureBox, object dataSource, string propertyName)
        {
            pictureBox.DataBindings.Clear();
            Binding binding = new Binding("ImageLocation", dataSource, propertyName, false, DataSourceUpdateMode.Never);
            pictureBox.DataBindings.Add(binding);
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

            if (auctionInfo == null && CheckInfoIsGiven(title, date, time, photo))
            {
                if (DateTime.Parse(date).Date >= DateTime.Now.Date)
                {
                    Auction auction = new Auction(title, date, time, CurrentUser.Info.Username, photo);
                    AddAuctionToOwner(auction.Id);
                    string? path = FileWorker.GetPath("Auctions");
                    FileWorker.AppendToFile(path, auction);
                }
                else
                {
                    MessageBox.Show("Дата обрана неправильно");
                    this.DialogResult = DialogResult.None;
                }
            }


            else if (auctionInfo != null && CheckInfoIsGiven(title, date, time, photo))
            {
                if (InfoChanged(auctionInfo))
                {
                    MessageBox.Show("1");
                    UpdateAuction(title, date, time, photo);
                }
            }

            else
            {
                MessageBox.Show("Не всі дані були надані");
                this.DialogResult = DialogResult.None;
            }
        }

        private bool InfoChanged(Auction auction)
        {
            return auction.Name != TitleTextBox.Text ||
                auction.Date != AuctionDate.Text ||
                auction.Time != AuctionTime.Text ||
                auction.Photo != PaintingPictureBox.ImageLocation;
        }

        private bool CheckInfoIsGiven(string title, string date, string time, string photo)
        {
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(date) || string.IsNullOrEmpty(time) || string.IsNullOrEmpty(photo))
            {
                return false;
            }
            return true;
        }

        private void AddAuctionToOwner(Guid AuctionId)
        {
            CurrentUser.Info.Pictures.Add(AuctionId);
            string[] jsonLines = FileWorker.ReadFile("Organisations");
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
            string? filePath = FileWorker.GetPath("Organisations");
            UpdateInfoInFiles(filePath, users);
        }

        private void RemoveAuctionFromOwner(string role, Guid AuctionId)
        {
            CurrentUser.Info.Pictures.Remove(AuctionId);
            string[] jsonLines = FileWorker.ReadFile(role + "s");
            List<Organisation> users = new List<Organisation>();

            foreach (string userString in jsonLines)
            {
                Organisation? user = JsonSerializer.Deserialize<Organisation?>(userString);

                if (user?.Id == CurrentUser.Info.Id)
                {
                    user.Pictures.Remove(AuctionId);
                }

                if (user != null)
                {
                    users.Add(user);
                }
            }
            string? filePath = FileWorker.GetPath(role + "s");
            UpdateInfoInFiles(filePath, users);
        }

        private void UpdateAuction(string title, string date, string time, string photo)
        {
            string[] jsonLines = FileWorker.ReadFile("Auctions");
            List<Auction> auctions = new List<Auction>();

            foreach (string auctionString in jsonLines)
            {
                Auction? auction = JsonSerializer.Deserialize<Auction?>(auctionString);

                if (auction?.Id == auctionInfo.Id)
                {
                    auction.Name = title;
                    auction.Date = date;
                    auction.Time = time;
                    auction.Photo = photo;
                }

                if (auction != null)
                {
                    auctions.Add(auction);
                }
            }

            string? filePath = FileWorker.GetPath("Auctions");
            AppendToFileList(filePath, auctions);
        }

        private void AppendToFileList(string filePath, List<Auction> auctions)
        {
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

        private void UpdateInfoInFiles(string path, List<Organisation> users)
        {
            if (path != null)
            {
                File.WriteAllText(path, string.Empty);

                foreach (Organisation user in users)
                {
                    string updatedJson = JsonSerializer.Serialize(user);
                    File.AppendAllText(path, updatedJson + '\n');
                }
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UploadButton.Visible = true;
            OkButton.Visible = true;
            AddPaintingButton.Visible = false;
            UpdateButton.Visible = false;
            TitleTextBox.ReadOnly = false;
            AuctionDate.Enabled = true;
            AuctionTime.Enabled = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string role = CurrentUser.Role;
            RemoveAuctionFromOwner(role, auctionInfo.Id);

            List<Auction> auctions = ChooseAuctions();
            string? filePath = FileWorker.GetPath("Auctions");
            AppendToFileList(filePath, auctions);

            DeleteAuctionPaintings();
        }


        private List<Auction> ChooseAuctions()
        {
            string[] jsonLines = FileWorker.ReadFile("Auctions");
            List<Auction> auctions = new List<Auction>();
            foreach (string auctionString in jsonLines)
            {
                Auction? auction = JsonSerializer.Deserialize<Auction?>(auctionString);

                if (auction != null && auction?.Id != auctionInfo.Id)
                {
                    auctions.Add(auction);
                }
            }
            return auctions;
        }

        private void DeleteAuctionPaintings()
        {
            string? path = FileWorker.GetPath("Paintings");
            string[] jsonLines = FileWorker.ReadFile("Paintings");
            List<Painting> paintings = new List<Painting>();

            foreach (string paintingString in jsonLines)
            {
                Painting? user = JsonSerializer.Deserialize<Painting?>(paintingString);
                if (!auctionInfo.Pictures.Contains(user.Id))
                {
                    paintings.Add(user);
                }
            }

            FileWorker.AppendToFilePaintings(path, paintings);
        }

        private void AddPaintingButton_Click(object sender, EventArgs e)
        {
            PaintingForm paintingForm = new PaintingForm(null, null, auctionInfo);
            paintingForm.ShowDialog();
        }

        private void ShowPaintingsButton_Click(object sender, EventArgs e)
        {
            User user = userInfo == null ? CurrentUser.Info : userInfo;
            AuctionPaintingsForm auctionPaintings = new AuctionPaintingsForm(user, auctionInfo);
            auctionPaintings.ShowDialog();
        }
    }
}