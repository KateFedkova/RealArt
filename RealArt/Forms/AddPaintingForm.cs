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
            string? imageNotFound = ConfigurationManager.AppSettings["ImageNotFound"];

            if (imageNotFound != null)
            {
                PaintingPictureBox.Image = Image.FromFile(imageNotFound);
            }

            if (CurrentUser.Info is Person)
            {
                PersonElementsVisibility();
            }
        }

        private void PersonElementsVisibility()
        {
            ArtistLabel.Visible = false;
            ArtistTextBox.Visible = false;
            TypeLabel.Visible = false;
            OriginalRadio.Visible = false;
            CopyRadio.Visible = false;
            PriceLabel.Visible = false;
            PriceTextBox.Visible = false;
            OkButton.Location = new Point(825, 216);
            CancelButton.Location = new Point(820, 300);
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg, *.png)|*.jpg;*.png";
                string fileName = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = dialog.FileName;
                    PaintingPictureBox.ImageLocation = fileName;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("При завантаженні сталася помилка");
            }
        }
    }
}
