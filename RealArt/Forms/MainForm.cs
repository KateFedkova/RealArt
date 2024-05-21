using RealArt.Models;
using System.Text.Json;

namespace RealArt
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void MainPanel_Resize(object sender, EventArgs e)
        {
            int formWidth = this.ClientSize.Width;
            int minWidth = this.MinimumSize.Width;
            int newWidth = Math.Max(minWidth, formWidth);
            int rowHeight = formWidth >= 1500 ? 600 : 320;
            float widthRatio = (float)newWidth / itemsPanel.Size.Width;

            itemsPanel.Size = new Size((int)(itemsPanel.Size.Width * widthRatio), itemsPanel.RowCount * rowHeight);
            itemsPanel.Location = new Point((formWidth - itemsPanel.Width) / 2, 43);

            for (int i = 0; i < itemsPanel.RowCount; i++)
            {
                RowStyle rowStyle = itemsPanel.RowStyles[i];
                rowStyle.SizeType = SizeType.Absolute;
                rowStyle.Height = rowHeight;
            }
        }

        private void ToSignup_Click(object sender, EventArgs e)
        {
            SignUpForm signup = new SignUpForm();
            signup.Show();
            this.Hide();
        }

        private void ToLogin_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void ToPage_Click(object sender, EventArgs e)
        {
            PrivatePageForm page = new PrivatePageForm(this, null);
            page.Show();
            this.Hide();
        }

        private void ToLogout_Click(object sender, EventArgs e)
        {
            CurrentUser.Info = null;
            CurrentUser.Role = null;
            MainForm_Load(null, null);
        }

        private void UpdateUI()
        {
            itemsPanel.Visible = false;
            QuoteLabel.Visible = true;
            QuotePicturebox.Visible = true;

            if (CurrentUser.Info != null)
            {
                ToSignup.Visible = false;
                ToLogin.Visible = false;
                ToLogout.Visible = true;
                ToPage.Visible = true;
                ToPage.ImageLocation = CurrentUser.Info.Photo;
            }
            else
            {
                ToLogout.Visible = false;
                ToSignup.Visible = true;
                ToLogin.Visible = true;
                ToPage.Visible = false;
            }
        }

        private void ArtistsButton_Click(object sender, EventArgs e)
        {
            List<User> people = GetUsers("Artist");
            QuoteLabel.Visible = false;
            QuotePicturebox.Visible = false;
            itemsPanel.Visible = true;
            BindPictures(itemsPanel, people);
        }

        private void CollectorsButton_Click(object sender, EventArgs e)
        {
            List<User> people = GetUsers("Collector");
            QuoteLabel.Visible = false;
            QuotePicturebox.Visible = false;
            itemsPanel.Visible = true;
            BindPictures(itemsPanel, people);
        }

        private void MuseumsButton_Click(object sender, EventArgs e)
        {
            List<User> people = GetUsers("Museum");
            QuoteLabel.Visible = false;
            QuotePicturebox.Visible = false;
            itemsPanel.Visible = true;
            BindPictures(itemsPanel, people);
        }

        private void OrganisationsButton_Click(object sender, EventArgs e)
        {
            List<User> people = GetUsers("Organisation");
            QuoteLabel.Visible = false;
            QuotePicturebox.Visible = false;
            itemsPanel.Visible = true;
            BindPictures(itemsPanel, people);
        }


        private void BindPictures(TableLayoutPanel tableLayoutPanel, List<User> users)
        {
            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.RowCount = 0;
            int columnCount = 3;

            for (int i = 0; i < users.Count; i++)
            {
                User user = users[i];
                PictureBox pictureBox = CreatePictureBox(user);
                pictureBox.Click += (sender, e) => OnPictureBoxClick(user);

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

        private List<User> GetUsers(string role)
        {
            List<User> users = new List<User>();
            string[] jsonLines = FileWorker.ReadFile(role + "s");

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

                if (user != null)
                {
                    users.Add(user);
                }
            }

            return users;
        }

        private PictureBox CreatePictureBox(User item)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile(item.Photo);
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Margin = new Padding(20);
            return pictureBox;
        }

        private void OnPictureBoxClick(object item)
        {
            if (item is Person person)
            {
                PrivatePageForm privatePage = new PrivatePageForm(this, person);
                privatePage.Show();
                this.Hide();
            }
            else if (item is Organisation organisation)
            {
                PrivatePageForm privatePage = new PrivatePageForm(this, organisation);
                privatePage.Show();
                this.Hide();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}