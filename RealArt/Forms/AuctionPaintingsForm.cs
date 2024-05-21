using RealArt.Models;
using System.Text.Json;

namespace RealArt
{
    public partial class AuctionPaintingsForm : Form
    {

        private Auction? auctionInfo;

        private User? userInfo;

        public AuctionPaintingsForm(User userInfo, Auction auctionInfo)
        {
            InitializeComponent();
            this.userInfo = userInfo;
            this.auctionInfo = auctionInfo;
        }

        private void AuctionPaintingsForm_Load(object sender, EventArgs e)
        {
            BindPictures(paintingsPanel, auctionInfo);
        }

        private void BindPictures(TableLayoutPanel tableLayoutPanel, Auction auction)
        {
            tableLayoutPanel.Controls.Clear();
            tableLayoutPanel.RowCount = 0;
            int columnCount = 3;

            List<Painting> paintings = GetPictures(auction);

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

        private List<Painting> GetPictures(Auction auction)
        {
            List<Painting> paintings = new List<Painting>();
            string[] jsonLines = FileWorker.ReadFile("Paintings");

            foreach (Guid id in auction.Pictures)
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

        private PictureBox CreatePictureBox(Painting painting)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile(painting.Photo);
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Margin = new Padding(20);
            return pictureBox;
        }

        private void OnPictureBoxClick(Painting painting)
        {
            User user = userInfo == null ? CurrentUser.Info : userInfo;
            PaintingForm paintingForm = new PaintingForm(user, painting);
            paintingForm.ShowDialog();
        }
    }
}
