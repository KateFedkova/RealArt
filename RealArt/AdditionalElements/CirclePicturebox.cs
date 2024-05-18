using System.Drawing.Drawing2D;

namespace RealArt.AdditionalElements
{
    internal class CirclePicturebox : PictureBox
    {

        public CirclePicturebox()
        {
            this.BackColor = Color.DarkGray;
        }
        
        protected override void OnResize(EventArgs e)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(0, 0, this.Width, this.Height);
            Region region = new Region(graphicsPath);
            this.Region = region;
        }
    }
}
