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
            panel1 = new Panel();
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
            AddButton = new AdditionalElements.RoundButton();
            UpdateButton = new AdditionalElements.RoundButton();
            AddPhotoButton = new AdditionalElements.RoundButton();
            UserPicturebox = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserPicturebox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.SeaGreen;
            panel1.BorderStyle = BorderStyle.FixedSingle;
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
            panel1.Controls.Add(AddButton);
            panel1.Controls.Add(UpdateButton);
            panel1.Controls.Add(AddPhotoButton);
            panel1.Controls.Add(UserPicturebox);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1079, 237);
            panel1.TabIndex = 0;
            // 
            // AboutInfoTextbox
            // 
            AboutInfoTextbox.BorderStyle = BorderStyle.None;
            AboutInfoTextbox.Enabled = false;
            AboutInfoTextbox.ImeMode = ImeMode.NoControl;
            AboutInfoTextbox.Location = new Point(463, 74);
            AboutInfoTextbox.MaxLength = 120;
            AboutInfoTextbox.Multiline = true;
            AboutInfoTextbox.Name = "AboutInfoTextbox";
            AboutInfoTextbox.ReadOnly = true;
            AboutInfoTextbox.Size = new Size(313, 110);
            AboutInfoTextbox.TabIndex = 10;
            AboutInfoTextbox.Text = "не відомо";
            // 
            // WorkingTimeInfoLabel
            // 
            WorkingTimeInfoLabel.AutoSize = true;
            WorkingTimeInfoLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WorkingTimeInfoLabel.Location = new Point(326, 165);
            WorkingTimeInfoLabel.Name = "WorkingTimeInfoLabel";
            WorkingTimeInfoLabel.Size = new Size(104, 28);
            WorkingTimeInfoLabel.TabIndex = 8;
            WorkingTimeInfoLabel.Text = "не відомо";
            // 
            // AddressInfoLabel
            // 
            AddressInfoLabel.AutoSize = true;
            AddressInfoLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddressInfoLabel.Location = new Point(277, 120);
            AddressInfoLabel.Name = "AddressInfoLabel";
            AddressInfoLabel.Size = new Size(104, 28);
            AddressInfoLabel.TabIndex = 6;
            AddressInfoLabel.Text = "не відомо";
            // 
            // StyleInfoLabel
            // 
            StyleInfoLabel.AutoSize = true;
            StyleInfoLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            StyleInfoLabel.Location = new Point(278, 79);
            StyleInfoLabel.Name = "StyleInfoLabel";
            StyleInfoLabel.Size = new Size(104, 28);
            StyleInfoLabel.TabIndex = 4;
            StyleInfoLabel.Text = "не відомо";
            // 
            // CountryInfoLabel
            // 
            CountryInfoLabel.AutoSize = true;
            CountryInfoLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CountryInfoLabel.Location = new Point(277, 32);
            CountryInfoLabel.Name = "CountryInfoLabel";
            CountryInfoLabel.Size = new Size(104, 28);
            CountryInfoLabel.TabIndex = 2;
            CountryInfoLabel.Text = "не відомо";
            // 
            // WorkingTimeLabel
            // 
            WorkingTimeLabel.AutoSize = true;
            WorkingTimeLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            WorkingTimeLabel.Location = new Point(190, 165);
            WorkingTimeLabel.Name = "WorkingTimeLabel";
            WorkingTimeLabel.Size = new Size(130, 28);
            WorkingTimeLabel.TabIndex = 7;
            WorkingTimeLabel.Text = "Час роботи:";
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            AddressLabel.Location = new Point(190, 120);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(82, 28);
            AddressLabel.TabIndex = 5;
            AddressLabel.Text = "Адреса:";
            // 
            // StyleLabel
            // 
            StyleLabel.AutoSize = true;
            StyleLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            StyleLabel.Location = new Point(190, 79);
            StyleLabel.Name = "StyleLabel";
            StyleLabel.Size = new Size(82, 28);
            StyleLabel.TabIndex = 3;
            StyleLabel.Text = "Стиль:";
            // 
            // AboutLabel
            // 
            AboutLabel.AutoSize = true;
            AboutLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            AboutLabel.Location = new Point(463, 31);
            AboutLabel.Name = "AboutLabel";
            AboutLabel.Size = new Size(99, 28);
            AboutLabel.TabIndex = 9;
            AboutLabel.Text = "Про себе:";
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            CountryLabel.Location = new Point(190, 32);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(86, 28);
            CountryLabel.TabIndex = 1;
            CountryLabel.Text = "Країна: ";
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Right;
            AddButton.BackColor = Color.FloralWhite;
            AddButton.BackgroundColor = Color.FloralWhite;
            AddButton.BorderColor = Color.Red;
            AddButton.BorderRadius = 20;
            AddButton.BorderSize = 0;
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddButton.ForeColor = Color.Black;
            AddButton.Location = new Point(853, 165);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(190, 55);
            AddButton.TabIndex = 13;
            AddButton.Text = "Додати картину";
            AddButton.TextColor = Color.Black;
            AddButton.UseVisualStyleBackColor = false;
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
            UpdateButton.Location = new Point(853, 93);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(190, 55);
            UpdateButton.TabIndex = 12;
            UpdateButton.Text = "Редагувати";
            UpdateButton.TextColor = Color.Black;
            UpdateButton.UseVisualStyleBackColor = false;
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
            AddPhotoButton.Location = new Point(853, 18);
            AddPhotoButton.Name = "AddPhotoButton";
            AddPhotoButton.Size = new Size(190, 55);
            AddPhotoButton.TabIndex = 11;
            AddPhotoButton.Text = "Додати фото";
            AddPhotoButton.TextColor = Color.Black;
            AddPhotoButton.UseVisualStyleBackColor = false;
            AddPhotoButton.Click += AddPhotoButton_Click;
            // 
            // UserPicturebox
            // 
            UserPicturebox.Anchor = AnchorStyles.Left;
            UserPicturebox.BorderStyle = BorderStyle.FixedSingle;
            UserPicturebox.Location = new Point(21, 18);
            UserPicturebox.Name = "UserPicturebox";
            UserPicturebox.Size = new Size(148, 202);
            UserPicturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            UserPicturebox.TabIndex = 0;
            UserPicturebox.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Location = new Point(0, 237);
            panel2.Name = "panel2";
            panel2.Size = new Size(1079, 409);
            panel2.TabIndex = 3;
            // 
            // PrivatePageForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 644);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(1101, 700);
            Name = "PrivatePageForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += PrivatePageForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserPicturebox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox UserPicturebox;
        private AdditionalElements.RoundButton AddPhotoButton;
        private AdditionalElements.RoundButton UpdateButton;
        private AdditionalElements.RoundButton AddButton;
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
    }
}