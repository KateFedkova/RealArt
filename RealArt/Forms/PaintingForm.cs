using RealArt.Models;
using System.Text.Json;

namespace RealArt
{
    public partial class PaintingForm : Form
    {
        private Painting? paintingInfo;
        private Auction? auctionInfo;
        private User? userInfo;

        public PaintingForm(User userInfo, Painting? paintingInfo = null, Auction? auctionInfo = null)
        {
            InitializeComponent();
            this.paintingInfo = paintingInfo;
            this.auctionInfo = auctionInfo;
            this.userInfo = userInfo;
        }

        private void PaintingForm_Load(object sender, EventArgs e)
        {

            if (userInfo != null && (CurrentUser.Info == null || CurrentUser.Info.Id != userInfo.Id))
            {
                UploadButton.Visible = false;
                UpdateButton.Visible = false;
                DeleteButton.Visible = false;
                OkButton.Visible = false;
            }

            if (paintingInfo != null)
            {
                BindingSource bindingSource = new BindingSource();
                UploadButton.Visible = false;
                OkButton.Visible = false;

                if (CurrentUser.Info == null)
                {
                    OrganisationSetInfo(bindingSource, paintingInfo);
                    MakeOrganisationReadonly();
                }

                else if (CurrentUser.Info is Person)
                {
                    PersonElementsVisibility();
                    PersonSetInfo(bindingSource, paintingInfo);
                    MakePersonReadonly();
                }

                else if (CurrentUser.Info is Organisation)
                {
                    OrganisationSetInfo(bindingSource, paintingInfo);
                    MakeOrganisationReadonly();
                }
            }

            else
            {
                UpdateButton.Visible = false;
                DeleteButton.Visible = false;

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

        private List<string> GetAllArtists()
        {
            string[] jsonLines = FileWorker.ReadFile("Artists");

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

        private void MakePersonReadonly()
        {
            TitleTextBox.ReadOnly = true;
            GenreTextBox.ReadOnly = true;
            CreationDate.Enabled = false;
            OriginalRadio.Enabled = false;
            CopyRadio.Enabled = false;
        }

        private void MakeOrganisationReadonly()
        {
            MakePersonReadonly();
            ArtistComboBox.Enabled = false;
            PriceTextBox.ReadOnly = true;
        }

        private void PersonSetInfo(BindingSource source, Painting painting)
        {
            source.DataSource = painting;
            BindData(TitleTextBox, source, "Name");
            BindData(GenreTextBox, source, "Style");
            BindData(CreationDate, source, "Date");
            BindImage(PaintingPictureBox, source, "Photo");
            CheckRadio(painting);
        }

        private void OrganisationSetInfo(BindingSource source, Painting painting)
        {
            source.DataSource = painting;
            PersonSetInfo(source, painting);
            BindData(ArtistComboBox, source, "ArtistName");
            BindData(PriceTextBox, source, "Price");
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

        private void CheckRadio(Painting painting)
        {
            if (painting.Type == "Original")
            {
                OriginalRadio.Checked = true;
            }
            else if (painting.Type == "Copy")
            {
                CopyRadio.Checked = true;
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

            if (CheckInfoIsGiven(title, style, date, type, photo) && paintingInfo == null)
            {
                CreatePainting(title, style, date, type, price, photo);
            }

            else if (CheckInfoIsGiven(title, style, date, type, photo) && paintingInfo != null)
            {
                UpdatePainting(title, style, date, type, price, photo);
            }

            else
            {
                MessageBox.Show("Не всі дані були надані");
                this.DialogResult = DialogResult.None;
            }
        }

        private void CreatePainting(string title, string style, string date, string type, float? price, string photo)
        {
            Painting? painting = null;

            if (CurrentUser.Role == "Artist" || CurrentUser.Role == "Collector")
            {
                painting = new Painting(title, style, date, type, photo);
                painting.ArtistName = CurrentUser.Info.Username;
            }

            else if (CurrentUser.Role == "Organisation" || CurrentUser.Role == "Museum")
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

            if (auctionInfo == null)
            {
                AddPaintingToOwner(CurrentUser.Role, painting.Id);
            }

            else
            {
                AddPaintingToAuction(painting.Id);
            }

            string? filePath = FileWorker.GetPath("Paintings");
            FileWorker.AppendToFile(filePath, painting);
        }

        private void UpdatePainting(string title, string style, string date, string type, float? price, string photo)
        {
            string[] jsonLines = FileWorker.ReadFile("Paintings");
            List<Painting> paintings = new List<Painting>();

            foreach (string paintingString in jsonLines)
            {
                Painting? painting = JsonSerializer.Deserialize<Painting?>(paintingString);

                if (painting?.Id == paintingInfo.Id)
                {
                    painting.Name = title;
                    painting.Style = style;
                    painting.Date = date;
                    painting.Photo = photo;
                    painting.Price = price;
                    painting.Type = type;
                }

                if (painting != null)
                {
                    paintings.Add(painting);
                }
            }

            string? filePath = FileWorker.GetPath("Paintings");
            FileWorker.AppendToFilePaintings(filePath, paintings);
        }
        
        private void AddPaintingToOwner(string role, Guid PaintingId)
        {
            CurrentUser.Info.Pictures.Add(PaintingId);
            string[] jsonLines = FileWorker.ReadFile(role + "s");
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

                if (user != null)
                {
                    users.Add(user);
                }
            }

            FileWorker.UpdateInfoInFiles(role, users);
        }

        private void AddPaintingToAuction(Guid PaintingId)
        {
            auctionInfo.Pictures.Add(PaintingId);
            string[] jsonLines = FileWorker.ReadFile("Auctions");
            List<Auction> auctions = new List<Auction>();

            foreach (string auctionString in jsonLines)
            {
                Auction? auction = JsonSerializer.Deserialize<Auction?>(auctionString);

                if (auction?.Id == auctionInfo.Id)
                {
                    auction.Pictures.Add(PaintingId);
                }

                if (auction != null)
                {
                    auctions.Add(auction);
                }
            }

            FileWorker.UpdateInfoInAuctions(auctions);
        }

        private void RemovePaintingFromOwner(string role, Guid paintingId)
        {
            CurrentUser.Info.Pictures.Remove(paintingInfo.Id);
            string[] jsonLines = FileWorker.ReadFile(role + "s");
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
                    user.Pictures.Remove(paintingInfo.Id);
                }

                if (user != null)
                {
                    users.Add(user);
                }

                FileWorker.UpdateInfoInFiles(role, users);
            }
        }    

        private void RemovePaintingFromAuction()
        {
            auctionInfo.Pictures.Remove(paintingInfo.Id);
            string[] jsonLines = FileWorker.ReadFile("Auctions");
            List<Auction> auctions = new List<Auction>();

            foreach (string auctionString in jsonLines)
            {
                Auction? auction = JsonSerializer.Deserialize<Auction?>(auctionString);

                if (auction?.Id == auctionInfo.Id)
                {
                    auction.Pictures.Remove(paintingInfo.Id);
                }

                if (auction != null)
                {
                    auctions.Add(auction);
                }
            }

            FileWorker.UpdateInfoInAuctions(auctions);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            TitleTextBox.ReadOnly = false;
            GenreTextBox.ReadOnly = false;
            CreationDate.Enabled = true;
            OriginalRadio.Enabled = true;
            CopyRadio.Enabled = true;
            ArtistComboBox.Enabled = true;
            PriceTextBox.ReadOnly = false;
            UploadButton.Visible = true;
            OkButton.Visible = true;
            CancelButton.Visible = true;
            UpdateButton.Visible = false;
            DeleteButton.Visible = false;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string? filePath = FileWorker.GetPath("Paintings");
            List<Painting> paintings = ChoosePaintings();
            FileWorker.AppendToFilePaintings(filePath, paintings);
            
            if (auctionInfo == null)
            {
                RemovePaintingFromOwner(CurrentUser.Role, paintingInfo.Id);
            }

            else
            {
                RemovePaintingFromAuction();
            }
        }
        private List<Painting> ChoosePaintings()
        {
            string[] jsonLines = FileWorker.ReadFile("Paintings");
            List<Painting> paintings = new List<Painting>();

            foreach (string paintingString in jsonLines)
            {
                Painting? painting = JsonSerializer.Deserialize<Painting?>(paintingString);

                if (painting != null && painting?.Id != paintingInfo.Id)
                {
                    paintings.Add(painting);
                }
            }

            return paintings;
        }
    }
}