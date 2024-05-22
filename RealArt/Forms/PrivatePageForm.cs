using System.Text.Json;
using RealArt.Models;

namespace RealArt
{
    public partial class PrivatePageForm : Form
    {
        private MainForm main;

        private User userInfo;

        private bool exitApplication = true;

        public PrivatePageForm(MainForm main, User userInfo)
        {
            InitializeComponent();
            this.main = main;
            this.userInfo = userInfo;
        }

        private void ToMain_Click(object sender, EventArgs e)
        {
            exitApplication = false;
            this.Close();
            this.main.Show();
        }

        private void PrivatePageForm_Resize(object sender, EventArgs e)
        {
            int formWidth = this.ClientSize.Width;
            int minWidth = this.MinimumSize.Width;
            int newWidth = Math.Max(minWidth, formWidth);
            int rowHeight = formWidth >= 1500 ? 600 : 320;
            float widthRatio = (float)newWidth / paintingsPanel.Size.Width;

            paintingsPanel.Size = new Size((int)(paintingsPanel.Size.Width * widthRatio), paintingsPanel.RowCount * rowHeight);
            paintingsPanel.Location = new Point((formWidth - paintingsPanel.Width) / 2, 43);

            for (int i = 0; i < paintingsPanel.RowCount; i++)
            {
                RowStyle rowStyle = paintingsPanel.RowStyles[i];
                rowStyle.SizeType = SizeType.Absolute;
                rowStyle.Height = rowHeight;
            }
        }

        private void PrivatePageForm_Load(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            User user = userInfo == null ? CurrentUser.Info : userInfo;

            if (userInfo != null)
            {
                GuestElementsVisibility();
            }

            if (user is Person person)
            {
                PersonElementsVisibility();
                PersonSetInfo(bindingSource, person);
            }

            else if (user is Organisation organisation)
            {
                OrganisationElementsVisibility();
                OrganisationSetInfo(bindingSource, organisation);
            }
        }

        private void PersonElementsVisibility()
        {
            AddressLabel.Visible = false;
            WorkingTimeLabel.Visible = false;
            AddressInfoLabel.Visible = false;
            WorkingTimeInfoLabel.Visible = false;
            AddAuctionButton.Visible = false;
        }

        private void PersonSetInfo(BindingSource source, Person user)
        {
            source.DataSource = user;
            BindLabel(CountryInfoLabel, source, "Country");
            BindLabel(StyleInfoLabel, source, "Style");
            BindTextbox(AboutInfoTextbox, source, "About");
            BindImage(UserPicturebox, source, "Photo");
            BindPictures(paintingsPanel, user);
        }

        private void OrganisationElementsVisibility()
        {
            StyleLabel.Visible = false;
            StyleInfoLabel.Visible = false;
            AddressLabel.Location = new Point(201, 79);
            AddressInfoLabel.Location = new Point(293, 79);
            WorkingTimeLabel.Location = new Point(201, 125);
            WorkingTimeInfoLabel.Location = new Point(328, 125);

            if (CurrentUser.Role == "Museum") AddAuctionButton.Visible = false;
        }

        private void OrganisationSetInfo(BindingSource source, Organisation user)
        {
            source.DataSource = user;
            BindLabel(CountryInfoLabel, source, "Country");
            BindLabel(AddressInfoLabel, source, "Address");
            BindLabel(WorkingTimeInfoLabel, source, "Time");
            BindTextbox(AboutInfoTextbox, source, "About");
            BindImage(UserPicturebox, source, "Photo");
            BindPictures(paintingsPanel, user);
        }

        private void GuestElementsVisibility()
        {
            AddPhotoButton.Visible = false;
            UpdateButton.Visible = false;
            AddPaintingButton.Visible = false;
            AddAuctionButton.Visible = false;
        }

        private void BindLabel(Label label, object source, string property)
        {
            label.DataBindings.Clear();
            Binding binding = new Binding("Text", source, property);
            binding.Format += (sender, e) =>
            {
                e.Value ??= "невідомо";
            };
            label.DataBindings.Add(binding);
        }

        private void BindTextbox(TextBox textBox, object dataSource, string propertyName)
        {
            textBox.DataBindings.Clear();
            Binding binding = new Binding("Text", dataSource, propertyName);
            binding.Format += (sender, e) =>
            {
                e.Value ??= "невідомо";
            };
            textBox.DataBindings.Add(binding);
        }

        private void BindImage(PictureBox pictureBox, object dataSource, string propertyName)
        {
            pictureBox.DataBindings.Clear();
            Binding binding = new Binding("ImageLocation", dataSource, propertyName);
            pictureBox.DataBindings.Add(binding);
        }

        private void BindPictures(TableLayoutPanel tableLayoutPanel, User user)
        {
            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.RowCount = 0;
            int columnCount = 3;

            List<Auction> auctions = GetAuctions(user);

            if (auctions.Count != 0)
            {
                MessageLabel.Visible = false;

                for (int i = 0; i < auctions.Count; i++)
                {
                    Auction auction = auctions[i];
                    PictureBox pictureBox = CreatePictureBox(auction);
                    pictureBox.Click += (sender, e) => OnPictureBoxClick(auction);

                    int row = i / columnCount;
                    int col = i % columnCount;
                    tableLayoutPanel.Controls.Add(pictureBox, col, row);

                    if (col == columnCount - 1)
                    {
                        tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 320));
                        tableLayoutPanel.RowCount++;
                    }
                }
            }
        
            List<Painting> paintings = GetPictures(user);

            if (paintings.Count != 0)
            {
                MessageLabel.Visible = false;

                for (int i = 0; i < paintings.Count; i++)
                {
                    Painting painting = paintings[i];
                    PictureBox pictureBox = CreatePictureBox(painting);
                    pictureBox.Click += (sender, e) => OnPictureBoxClick(painting);

                    int row = i / columnCount;
                    int col = i % columnCount;
                    tableLayoutPanel.Controls.Add(pictureBox, col, row);

                    if (col == columnCount - 1)
                    {
                        tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 320));
                        tableLayoutPanel.RowCount++;
                    }
                }
            }
        }

        private List<Painting> GetPictures(User user)
        {
            List<Painting> paintings = new List<Painting>();
            string[] jsonLines = FileWorker.ReadFile("Paintings");

            foreach (Guid id in user.Pictures)
            {
                foreach (string paintingString in jsonLines)
                {
                    Painting? painting = JsonSerializer.Deserialize<Painting?>(paintingString);

                    if (painting?.Id == id)
                    {
                        paintings.Add(painting);
                        break;
                    }
                }
            }
            return paintings;
        }

        private List<Auction> GetAuctions(User user)
        {
            List<Auction> paintings = new List<Auction>();
            string[] jsonLines = FileWorker.ReadFile("Auctions");

            foreach (Guid id in user.Pictures)
            {
                foreach (string auctionString in jsonLines)
                {
                    Auction? auction = JsonSerializer.Deserialize<Auction?>(auctionString);

                    if (auction?.Id == id)
                    {
                        paintings.Add(auction);
                        break;
                    }
                }
            }
            return paintings;
        }

        private PictureBox CreatePictureBox(object item)
        {
            PictureBox pictureBox = new PictureBox();

            if (item is Painting painting)
            {
                pictureBox.Image = Image.FromFile(painting.Photo);
            }

            else if (item is Auction auction)
            {
                pictureBox.Image = Image.FromFile(auction.Photo);
            }

            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Margin = new Padding(20);
            return pictureBox;
        }

        private void AddPhotoButton_Click(object sender, EventArgs e)
        {
            string fileName = SetImage();

            if (fileName != "")
            {
                string role = CurrentUser.Role;
                CurrentUser.Info.Photo = fileName;
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
                        user.Photo = fileName;
                    }

                    if (user != null)
                    {
                        users.Add(user);
                    }
                }

                FileWorker.UpdateInfoInFiles(role, users);
            }
        }

        private string SetImage()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files (*.jpg, *.png)|*.jpg;*.png";
            string fileName = "";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fileName = dialog.FileName;
                UserPicturebox.ImageLocation = fileName;
            }

            return fileName;
        }

        private void OnPictureBoxClick(object item)
        {
            User user = userInfo == null ? CurrentUser.Info : userInfo;
            if (item is Painting painting)
            {
                PaintingForm paintingForm = new PaintingForm(user, painting);
                paintingForm.ShowDialog();
                PrivatePageForm_Load(null, null);
            }
            else if (item is Auction auction)
            {
                AuctionForm auctionForm = new AuctionForm(user, auction);
                auctionForm.ShowDialog();
                PrivatePageForm_Load(null, null);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateInfoForm updateInfoForm = new UpdateInfoForm();
            updateInfoForm.ShowDialog();
            PrivatePageForm_Load(null, null);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            PaintingForm addPaintingForm = new PaintingForm(null);
            addPaintingForm.ShowDialog();
            PrivatePageForm_Load(null, null);
        }

        private void AddAuctionButton_Click(object sender, EventArgs e)
        {
            AuctionForm addAuctionForm = new AuctionForm(null);
            addAuctionForm.ShowDialog();
            PrivatePageForm_Load(null, null);
        }

        private void PrivatePageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exitApplication)
            {
                Application.Exit();
            }
        }
    }
}