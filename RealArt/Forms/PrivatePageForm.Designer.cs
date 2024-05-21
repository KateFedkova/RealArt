namespace RealArt
{
    partial class PrivatePageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrivatePageForm));
            panel1 = new Panel();
            AddAuctionButton = new AdditionalElements.RoundButton();
            AddPaintingButton = new AdditionalElements.RoundButton();
            ToMain = new PictureBox();
            AboutInfoTextbox = new TextBox();
            WorkingTimeInfoLabel = new Label();
            AddressInfoLabel = new Label();
            StyleInfoLabel = new Label();
            CountryInfoLabel = new Label();
            WorkingTimeLabel = new Label();
            AddressLabel = new Label();
            StyleLabel = new Label();
            AboutLabel = new Label();
            CountryLabel = new Label();
            UpdateButton = new AdditionalElements.RoundButton();
            AddPhotoButton = new AdditionalElements.RoundButton();
            UserPicturebox = new PictureBox();
            panel2 = new Panel();
            MessageLabel = new Label();
            paintingsPanel = new TableLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ToMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UserPicturebox).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.SeaGreen;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(AddAuctionButton);
            panel1.Controls.Add(AddPaintingButton);
            panel1.Controls.Add(ToMain);
            panel1.Controls.Add(AboutInfoTextbox);
            panel1.Controls.Add(WorkingTimeInfoLabel);
            panel1.Controls.Add(AddressInfoLabel);
            panel1.Controls.Add(StyleInfoLabel);
            panel1.Controls.Add(CountryInfoLabel);
            panel1.Controls.Add(WorkingTimeLabel);
            panel1.Controls.Add(AddressLabel);
            panel1.Controls.Add(StyleLabel);
            panel1.Controls.Add(AboutLabel);
            panel1.Controls.Add(CountryLabel);
            panel1.Controls.Add(UpdateButton);
            panel1.Controls.Add(AddPhotoButton);
            panel1.Controls.Add(UserPicturebox);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1079, 269);
            panel1.TabIndex = 0;
            // 
            // AddAuctionButton
            // 
            AddAuctionButton.Anchor = AnchorStyles.Right;
            AddAuctionButton.BackColor = Color.FloralWhite;
            AddAuctionButton.BackgroundColor = Color.FloralWhite;
            AddAuctionButton.BorderColor = Color.Red;
            AddAuctionButton.BorderRadius = 20;
            AddAuctionButton.BorderSize = 0;
            AddAuctionButton.FlatAppearance.BorderSize = 0;
            AddAuctionButton.FlatStyle = FlatStyle.Flat;
            AddAuctionButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddAuctionButton.ForeColor = Color.Black;
            AddAuctionButton.Location = new Point(863, 205);
            AddAuctionButton.Name = "AddAuctionButton";
            AddAuctionButton.Size = new Size(190, 50);
            AddAuctionButton.TabIndex = 15;
            AddAuctionButton.Text = "Додати аукціон";
            AddAuctionButton.TextColor = Color.Black;
            AddAuctionButton.UseVisualStyleBackColor = false;
            AddAuctionButton.Click += AddAuctionButton_Click;
            // 
            // AddPaintingButton
            // 
            AddPaintingButton.Anchor = AnchorStyles.Right;
            AddPaintingButton.BackColor = Color.FloralWhite;
            AddPaintingButton.BackgroundColor = Color.FloralWhite;
            AddPaintingButton.BorderColor = Color.Red;
            AddPaintingButton.BorderRadius = 20;
            AddPaintingButton.BorderSize = 0;
            AddPaintingButton.FlatAppearance.BorderSize = 0;
            AddPaintingButton.FlatStyle = FlatStyle.Flat;
            AddPaintingButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddPaintingButton.ForeColor = Color.Black;
            AddPaintingButton.Location = new Point(863, 140);
            AddPaintingButton.Name = "AddPaintingButton";
            AddPaintingButton.Size = new Size(190, 50);
            AddPaintingButton.TabIndex = 13;
            AddPaintingButton.Text = "Додати картину";
            AddPaintingButton.TextColor = Color.Black;
            AddPaintingButton.UseVisualStyleBackColor = false;
            AddPaintingButton.Click += AddButton_Click;
            // 
            // ToMain
            // 
            ToMain.Image = (Image)resources.GetObject("ToMain.Image");
            ToMain.Location = new Point(4, -1);
            ToMain.Name = "ToMain";
            ToMain.Size = new Size(30, 30);
            ToMain.SizeMode = PictureBoxSizeMode.StretchImage;
            ToMain.TabIndex = 14;
            ToMain.TabStop = false;
            ToMain.Click += ToMain_Click;
            // 
            // AboutInfoTextbox
            // 
            AboutInfoTextbox.BorderStyle = BorderStyle.None;
            AboutInfoTextbox.Enabled = false;
            AboutInfoTextbox.ImeMode = ImeMode.NoControl;
            AboutInfoTextbox.Location = new Point(504, 79);
            AboutInfoTextbox.MaxLength = 120;
            AboutInfoTextbox.Multiline = true;
            AboutInfoTextbox.Name = "AboutInfoTextbox";
            AboutInfoTextbox.ReadOnly = true;
            AboutInfoTextbox.Size = new Size(313, 110);
            AboutInfoTextbox.TabIndex = 10;
            AboutInfoTextbox.Text = "невідомо";
            // 
            // WorkingTimeInfoLabel
            // 
            WorkingTimeInfoLabel.AutoSize = true;
            WorkingTimeInfoLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WorkingTimeInfoLabel.Location = new Point(337, 165);
            WorkingTimeInfoLabel.Name = "WorkingTimeInfoLabel";
            WorkingTimeInfoLabel.Size = new Size(99, 28);
            WorkingTimeInfoLabel.TabIndex = 8;
            WorkingTimeInfoLabel.Text = "невідомо";
            // 
            // AddressInfoLabel
            // 
            AddressInfoLabel.AutoSize = true;
            AddressInfoLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddressInfoLabel.Location = new Point(293, 120);
            AddressInfoLabel.Name = "AddressInfoLabel";
            AddressInfoLabel.Size = new Size(99, 28);
            AddressInfoLabel.TabIndex = 6;
            AddressInfoLabel.Text = "невідомо";
            // 
            // StyleInfoLabel
            // 
            StyleInfoLabel.AutoSize = true;
            StyleInfoLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            StyleInfoLabel.Location = new Point(293, 79);
            StyleInfoLabel.Name = "StyleInfoLabel";
            StyleInfoLabel.Size = new Size(99, 28);
            StyleInfoLabel.TabIndex = 4;
            StyleInfoLabel.Text = "невідомо";
            // 
            // CountryInfoLabel
            // 
            CountryInfoLabel.AutoSize = true;
            CountryInfoLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CountryInfoLabel.Location = new Point(293, 32);
            CountryInfoLabel.Name = "CountryInfoLabel";
            CountryInfoLabel.Size = new Size(99, 28);
            CountryInfoLabel.TabIndex = 2;
            CountryInfoLabel.Text = "невідомо";
            // 
            // WorkingTimeLabel
            // 
            WorkingTimeLabel.AutoSize = true;
            WorkingTimeLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            WorkingTimeLabel.Location = new Point(201, 165);
            WorkingTimeLabel.Name = "WorkingTimeLabel";
            WorkingTimeLabel.Size = new Size(130, 28);
            WorkingTimeLabel.TabIndex = 7;
            WorkingTimeLabel.Text = "Час роботи:";
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            AddressLabel.Location = new Point(201, 120);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(82, 28);
            AddressLabel.TabIndex = 5;
            AddressLabel.Text = "Адреса:";
            // 
            // StyleLabel
            // 
            StyleLabel.AutoSize = true;
            StyleLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            StyleLabel.Location = new Point(201, 79);
            StyleLabel.Name = "StyleLabel";
            StyleLabel.Size = new Size(82, 28);
            StyleLabel.TabIndex = 3;
            StyleLabel.Text = "Стиль:";
            // 
            // AboutLabel
            // 
            AboutLabel.AutoSize = true;
            AboutLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            AboutLabel.Location = new Point(504, 31);
            AboutLabel.Name = "AboutLabel";
            AboutLabel.Size = new Size(99, 28);
            AboutLabel.TabIndex = 9;
            AboutLabel.Text = "Про себе:";
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            CountryLabel.Location = new Point(201, 32);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(86, 28);
            CountryLabel.TabIndex = 1;
            CountryLabel.Text = "Країна: ";
            // 
            // UpdateButton
            // 
            UpdateButton.Anchor = AnchorStyles.Right;
            UpdateButton.BackColor = Color.FloralWhite;
            UpdateButton.BackgroundColor = Color.FloralWhite;
            UpdateButton.BorderColor = Color.Red;
            UpdateButton.BorderRadius = 20;
            UpdateButton.BorderSize = 0;
            UpdateButton.FlatAppearance.BorderSize = 0;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UpdateButton.ForeColor = Color.Black;
            UpdateButton.Location = new Point(863, 75);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(190, 50);
            UpdateButton.TabIndex = 12;
            UpdateButton.Text = "Редагувати";
            UpdateButton.TextColor = Color.Black;
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // AddPhotoButton
            // 
            AddPhotoButton.Anchor = AnchorStyles.Right;
            AddPhotoButton.BackColor = Color.FloralWhite;
            AddPhotoButton.BackgroundColor = Color.FloralWhite;
            AddPhotoButton.BorderColor = Color.Red;
            AddPhotoButton.BorderRadius = 20;
            AddPhotoButton.BorderSize = 0;
            AddPhotoButton.FlatAppearance.BorderSize = 0;
            AddPhotoButton.FlatStyle = FlatStyle.Flat;
            AddPhotoButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddPhotoButton.ForeColor = Color.Black;
            AddPhotoButton.Location = new Point(863, 11);
            AddPhotoButton.Name = "AddPhotoButton";
            AddPhotoButton.Size = new Size(190, 50);
            AddPhotoButton.TabIndex = 11;
            AddPhotoButton.Text = "Додати фото";
            AddPhotoButton.TextColor = Color.Black;
            AddPhotoButton.UseVisualStyleBackColor = false;
            AddPhotoButton.Click += AddPhotoButton_Click;
            // 
            // UserPicturebox
            // 
            UserPicturebox.Anchor = AnchorStyles.Left;
            UserPicturebox.Image = (Image)resources.GetObject("UserPicturebox.Image");
            UserPicturebox.Location = new Point(40, 28);
            UserPicturebox.Name = "UserPicturebox";
            UserPicturebox.Size = new Size(148, 205);
            UserPicturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            UserPicturebox.TabIndex = 0;
            UserPicturebox.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoScroll = true;
            panel2.Controls.Add(MessageLabel);
            panel2.Controls.Add(paintingsPanel);
            panel2.Location = new Point(0, 270);
            panel2.Name = "panel2";
            panel2.Size = new Size(1079, 370);
            panel2.TabIndex = 3;
            // 
            // MessageLabel
            // 
            MessageLabel.AutoSize = true;
            MessageLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MessageLabel.Location = new Point(230, 150);
            MessageLabel.Name = "MessageLabel";
            MessageLabel.Size = new Size(648, 48);
            MessageLabel.TabIndex = 4;
            MessageLabel.Text = "Жодної  інформації не було знайдено";
            // 
            // paintingsPanel
            // 
            paintingsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            paintingsPanel.AutoSize = true;
            paintingsPanel.ColumnCount = 3;
            paintingsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            paintingsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            paintingsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            paintingsPanel.Location = new Point(82, 43);
            paintingsPanel.Name = "paintingsPanel";
            paintingsPanel.RowCount = 1;
            paintingsPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 320F));
            paintingsPanel.Size = new Size(904, 320);
            paintingsPanel.TabIndex = 1;
            // 
            // PrivatePageForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 644);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1101, 700);
            Name = "PrivatePageForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += PrivatePageForm_FormClosing;
            Load += PrivatePageForm_Load;
            Resize += PrivatePageForm_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ToMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)UserPicturebox).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox UserPicturebox;
        private AdditionalElements.RoundButton AddPhotoButton;
        private AdditionalElements.RoundButton UpdateButton;
        private AdditionalElements.RoundButton AddPaintingButton;
        private Label CountryLabel;
        private Label AboutLabel;
        private Label StyleLabel;
        private Label WorkingTimeLabel;
        private Label AddressLabel;
        private Label CountryInfoLabel;
        private Label WorkingTimeInfoLabel;
        private Label AddressInfoLabel;
        private Label StyleInfoLabel;
        private TextBox AboutInfoTextbox;
        private Panel panel2;
        private PictureBox ToMain;
        private TableLayoutPanel paintingsPanel;
        private AdditionalElements.RoundButton AddAuctionButton;
        private Label MessageLabel;
    }
}