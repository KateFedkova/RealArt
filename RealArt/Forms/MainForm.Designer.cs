namespace RealArt
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            ToPage = new AdditionalElements.CirclePicturebox();
            ToLogin = new AdditionalElements.RoundButton();
            ToSignup = new AdditionalElements.RoundButton();
            ToLogout = new AdditionalElements.RoundButton();
            label1 = new Label();
            QuoteLabel = new Label();
            MuseumsButton = new AdditionalElements.RoundButton();
            CollectorsButton = new AdditionalElements.RoundButton();
            ArtistsButton = new AdditionalElements.RoundButton();
            OrganisationsButton = new AdditionalElements.RoundButton();
            panel2 = new Panel();
            MainPanel = new Panel();
            itemsPanel = new TableLayoutPanel();
            QuotePicturebox = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ToPage).BeginInit();
            panel2.SuspendLayout();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QuotePicturebox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(ToPage);
            panel1.Controls.Add(ToLogin);
            panel1.Controls.Add(ToSignup);
            panel1.Controls.Add(ToLogout);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1076, 106);
            panel1.TabIndex = 0;
            // 
            // ToPage
            // 
            ToPage.Anchor = AnchorStyles.Right;
            ToPage.BackColor = Color.DarkGray;
            ToPage.Location = new Point(781, 12);
            ToPage.Name = "ToPage";
            ToPage.Size = new Size(91, 80);
            ToPage.SizeMode = PictureBoxSizeMode.StretchImage;
            ToPage.TabIndex = 5;
            ToPage.TabStop = false;
            ToPage.Click += ToPage_Click;
            // 
            // ToLogin
            // 
            ToLogin.Anchor = AnchorStyles.Right;
            ToLogin.BackColor = Color.Snow;
            ToLogin.BackgroundColor = Color.Snow;
            ToLogin.BorderColor = Color.White;
            ToLogin.BorderRadius = 20;
            ToLogin.BorderSize = 0;
            ToLogin.FlatAppearance.BorderSize = 0;
            ToLogin.FlatStyle = FlatStyle.Flat;
            ToLogin.ForeColor = Color.Black;
            ToLogin.Location = new Point(839, 25);
            ToLogin.Name = "ToLogin";
            ToLogin.Size = new Size(202, 60);
            ToLogin.TabIndex = 2;
            ToLogin.Text = "Увійти";
            ToLogin.TextColor = Color.Black;
            ToLogin.UseVisualStyleBackColor = false;
            ToLogin.Click += ToLogin_Click;
            // 
            // ToSignup
            // 
            ToSignup.Anchor = AnchorStyles.Right;
            ToSignup.BackColor = Color.Snow;
            ToSignup.BackgroundColor = Color.Snow;
            ToSignup.BorderColor = Color.White;
            ToSignup.BorderRadius = 20;
            ToSignup.BorderSize = 0;
            ToSignup.FlatAppearance.BorderSize = 0;
            ToSignup.FlatStyle = FlatStyle.Flat;
            ToSignup.ForeColor = Color.Black;
            ToSignup.Location = new Point(612, 25);
            ToSignup.Name = "ToSignup";
            ToSignup.Size = new Size(202, 60);
            ToSignup.TabIndex = 1;
            ToSignup.Text = "Зареєструватись";
            ToSignup.TextColor = Color.Black;
            ToSignup.UseVisualStyleBackColor = false;
            ToSignup.Click += ToSignup_Click;
            // 
            // ToLogout
            // 
            ToLogout.Anchor = AnchorStyles.Right;
            ToLogout.BackColor = Color.Snow;
            ToLogout.BackgroundColor = Color.Snow;
            ToLogout.BorderColor = Color.White;
            ToLogout.BorderRadius = 20;
            ToLogout.BorderSize = 0;
            ToLogout.FlatAppearance.BorderSize = 0;
            ToLogout.FlatStyle = FlatStyle.Flat;
            ToLogout.ForeColor = Color.Black;
            ToLogout.Location = new Point(905, 25);
            ToLogout.Name = "ToLogout";
            ToLogout.Size = new Size(136, 60);
            ToLogout.TabIndex = 3;
            ToLogout.Text = "Вийти";
            ToLogout.TextColor = Color.Black;
            ToLogout.UseVisualStyleBackColor = false;
            ToLogout.Click += ToLogout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(29, 32);
            label1.Name = "label1";
            label1.Size = new Size(110, 38);
            label1.TabIndex = 0;
            label1.Text = "RealArt";
            // 
            // QuoteLabel
            // 
            QuoteLabel.Anchor = AnchorStyles.Top;
            QuoteLabel.Font = new Font("Comic Sans MS", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            QuoteLabel.ImageKey = "(none)";
            QuoteLabel.Location = new Point(593, 159);
            QuoteLabel.MinimumSize = new Size(472, 89);
            QuoteLabel.Name = "QuoteLabel";
            QuoteLabel.Size = new Size(472, 89);
            QuoteLabel.TabIndex = 9;
            QuoteLabel.Text = "Картини живуть своїм власним життям, народженим душею художника";
            // 
            // MuseumsButton
            // 
            MuseumsButton.Anchor = AnchorStyles.Top;
            MuseumsButton.BackColor = Color.MediumSlateBlue;
            MuseumsButton.BackgroundColor = Color.MediumSlateBlue;
            MuseumsButton.BorderColor = Color.Red;
            MuseumsButton.BorderRadius = 0;
            MuseumsButton.BorderSize = 0;
            MuseumsButton.FlatAppearance.BorderSize = 0;
            MuseumsButton.FlatStyle = FlatStyle.Flat;
            MuseumsButton.ForeColor = Color.White;
            MuseumsButton.Location = new Point(500, 35);
            MuseumsButton.Name = "MuseumsButton";
            MuseumsButton.Size = new Size(160, 50);
            MuseumsButton.TabIndex = 6;
            MuseumsButton.Text = "Музеї";
            MuseumsButton.TextColor = Color.White;
            MuseumsButton.UseVisualStyleBackColor = false;
            MuseumsButton.Click += MuseumsButton_Click;
            // 
            // CollectorsButton
            // 
            CollectorsButton.Anchor = AnchorStyles.Top;
            CollectorsButton.BackColor = Color.MediumSlateBlue;
            CollectorsButton.BackgroundColor = Color.MediumSlateBlue;
            CollectorsButton.BorderColor = Color.Red;
            CollectorsButton.BorderRadius = 0;
            CollectorsButton.BorderSize = 0;
            CollectorsButton.FlatAppearance.BorderSize = 0;
            CollectorsButton.FlatStyle = FlatStyle.Flat;
            CollectorsButton.ForeColor = Color.White;
            CollectorsButton.Location = new Point(267, 35);
            CollectorsButton.Name = "CollectorsButton";
            CollectorsButton.Size = new Size(160, 50);
            CollectorsButton.TabIndex = 5;
            CollectorsButton.Text = "Колекціонери";
            CollectorsButton.TextColor = Color.White;
            CollectorsButton.UseVisualStyleBackColor = false;
            CollectorsButton.Click += CollectorsButton_Click;
            // 
            // ArtistsButton
            // 
            ArtistsButton.Anchor = AnchorStyles.Top;
            ArtistsButton.BackColor = Color.MediumSlateBlue;
            ArtistsButton.BackgroundColor = Color.MediumSlateBlue;
            ArtistsButton.BorderColor = Color.Red;
            ArtistsButton.BorderRadius = 0;
            ArtistsButton.BorderSize = 0;
            ArtistsButton.FlatAppearance.BorderSize = 0;
            ArtistsButton.FlatStyle = FlatStyle.Flat;
            ArtistsButton.ForeColor = Color.White;
            ArtistsButton.Location = new Point(35, 35);
            ArtistsButton.Name = "ArtistsButton";
            ArtistsButton.Size = new Size(160, 50);
            ArtistsButton.TabIndex = 4;
            ArtistsButton.Text = "Художники";
            ArtistsButton.TextColor = Color.White;
            ArtistsButton.UseVisualStyleBackColor = false;
            ArtistsButton.Click += ArtistsButton_Click;
            // 
            // OrganisationsButton
            // 
            OrganisationsButton.Anchor = AnchorStyles.Top;
            OrganisationsButton.BackColor = Color.MediumSlateBlue;
            OrganisationsButton.BackgroundColor = Color.MediumSlateBlue;
            OrganisationsButton.BorderColor = Color.Red;
            OrganisationsButton.BorderRadius = 0;
            OrganisationsButton.BorderSize = 0;
            OrganisationsButton.FlatAppearance.BorderSize = 0;
            OrganisationsButton.FlatStyle = FlatStyle.Flat;
            OrganisationsButton.ForeColor = Color.White;
            OrganisationsButton.Location = new Point(731, 35);
            OrganisationsButton.Name = "OrganisationsButton";
            OrganisationsButton.Size = new Size(305, 50);
            OrganisationsButton.TabIndex = 7;
            OrganisationsButton.Text = "Аукціони та комісійні магазини";
            OrganisationsButton.TextColor = Color.White;
            OrganisationsButton.UseVisualStyleBackColor = false;
            OrganisationsButton.Click += OrganisationsButton_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(OrganisationsButton);
            panel2.Controls.Add(MuseumsButton);
            panel2.Controls.Add(CollectorsButton);
            panel2.Controls.Add(ArtistsButton);
            panel2.Location = new Point(2, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(1076, 110);
            panel2.TabIndex = 3;
            // 
            // MainPanel
            // 
            MainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainPanel.Controls.Add(itemsPanel);
            MainPanel.Controls.Add(QuotePicturebox);
            MainPanel.Controls.Add(QuoteLabel);
            MainPanel.Location = new Point(2, 221);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1076, 424);
            MainPanel.TabIndex = 8;
            MainPanel.Resize += MainPanel_Resize;
            // 
            // itemsPanel
            // 
            itemsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            itemsPanel.AutoSize = true;
            itemsPanel.ColumnCount = 3;
            itemsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            itemsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            itemsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            itemsPanel.Location = new Point(81, 27);
            itemsPanel.Name = "itemsPanel";
            itemsPanel.RowCount = 1;
            itemsPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 320F));
            itemsPanel.Size = new Size(904, 320);
            itemsPanel.TabIndex = 11;
            // 
            // QuotePicturebox
            // 
            QuotePicturebox.Anchor = AnchorStyles.Top;
            QuotePicturebox.Image = (Image)resources.GetObject("QuotePicturebox.Image");
            QuotePicturebox.Location = new Point(29, 37);
            QuotePicturebox.Name = "QuotePicturebox";
            QuotePicturebox.Size = new Size(550, 328);
            QuotePicturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            QuotePicturebox.TabIndex = 10;
            QuotePicturebox.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 644);
            Controls.Add(MainPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Name = "MainForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ToPage).EndInit();
            panel2.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)QuotePicturebox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Label QuoteLabel;
        private AdditionalElements.RoundButton ToSignup;
        private AdditionalElements.RoundButton ToLogout;
        private AdditionalElements.RoundButton ToLogin;
        private AdditionalElements.RoundButton MuseumsButton;
        private AdditionalElements.RoundButton CollectorsButton;
        private AdditionalElements.RoundButton ArtistsButton;
        private AdditionalElements.RoundButton OrganisationsButton;
        private Panel panel2;
        private AdditionalElements.CirclePicturebox ToPage;
        private Panel MainPanel;
        private PictureBox QuotePicturebox;
        private TableLayoutPanel itemsPanel;
    }
}