namespace RealArt
{
    partial class PaintingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaintingForm));
            PaintingPictureBox = new PictureBox();
            label1 = new Label();
            TitleTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            CopyRadio = new RadioButton();
            OriginalRadio = new RadioButton();
            CreationDate = new DateTimePicker();
            GenreTextBox = new TextBox();
            panel1 = new Panel();
            DeleteButton = new AdditionalElements.RoundButton();
            UpdateButton = new AdditionalElements.RoundButton();
            ArtistComboBox = new ComboBox();
            CancelButton = new AdditionalElements.RoundButton();
            OkButton = new AdditionalElements.RoundButton();
            UploadButton = new AdditionalElements.RoundButton();
            PriceTextBox = new TextBox();
            PriceLabel = new Label();
            TypeLabel = new Label();
            ArtistLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)PaintingPictureBox).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PaintingPictureBox
            // 
            PaintingPictureBox.Image = (Image)resources.GetObject("PaintingPictureBox.Image");
            PaintingPictureBox.ImageLocation = "";
            PaintingPictureBox.InitialImage = null;
            PaintingPictureBox.Location = new Point(42, 71);
            PaintingPictureBox.Name = "PaintingPictureBox";
            PaintingPictureBox.Size = new Size(279, 375);
            PaintingPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PaintingPictureBox.TabIndex = 0;
            PaintingPictureBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(369, 71);
            label1.Name = "label1";
            label1.Size = new Size(73, 30);
            label1.TabIndex = 2;
            label1.Text = "Назва";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(373, 121);
            TitleTextBox.MaxLength = 60;
            TitleTextBox.Multiline = true;
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(313, 75);
            TitleTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(373, 216);
            label2.Name = "label2";
            label2.Size = new Size(69, 30);
            label2.TabIndex = 4;
            label2.Text = "Жанр";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(373, 362);
            label3.Name = "label3";
            label3.Size = new Size(171, 30);
            label3.TabIndex = 6;
            label3.Text = "Дата створення";
            // 
            // CopyRadio
            // 
            CopyRadio.AutoSize = true;
            CopyRadio.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CopyRadio.Location = new Point(921, 121);
            CopyRadio.Name = "CopyRadio";
            CopyRadio.Size = new Size(88, 32);
            CopyRadio.TabIndex = 10;
            CopyRadio.TabStop = true;
            CopyRadio.Text = "Копія";
            CopyRadio.UseVisualStyleBackColor = true;
            // 
            // OriginalRadio
            // 
            OriginalRadio.AutoSize = true;
            OriginalRadio.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OriginalRadio.Location = new Point(752, 121);
            OriginalRadio.Name = "OriginalRadio";
            OriginalRadio.Size = new Size(122, 32);
            OriginalRadio.TabIndex = 9;
            OriginalRadio.TabStop = true;
            OriginalRadio.Text = "Оригінал";
            OriginalRadio.UseVisualStyleBackColor = true;
            // 
            // CreationDate
            // 
            CreationDate.Format = DateTimePickerFormat.Short;
            CreationDate.Location = new Point(373, 415);
            CreationDate.Name = "CreationDate";
            CreationDate.Size = new Size(300, 31);
            CreationDate.TabIndex = 7;
            // 
            // GenreTextBox
            // 
            GenreTextBox.Location = new Point(373, 261);
            GenreTextBox.MaxLength = 60;
            GenreTextBox.Multiline = true;
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.Size = new Size(313, 75);
            GenreTextBox.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(DeleteButton);
            panel1.Controls.Add(UpdateButton);
            panel1.Controls.Add(ArtistComboBox);
            panel1.Controls.Add(CancelButton);
            panel1.Controls.Add(OkButton);
            panel1.Controls.Add(UploadButton);
            panel1.Controls.Add(PriceTextBox);
            panel1.Controls.Add(PriceLabel);
            panel1.Controls.Add(TypeLabel);
            panel1.Controls.Add(ArtistLabel);
            panel1.Controls.Add(PaintingPictureBox);
            panel1.Controls.Add(CopyRadio);
            panel1.Controls.Add(OriginalRadio);
            panel1.Controls.Add(CreationDate);
            panel1.Controls.Add(GenreTextBox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(TitleTextBox);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1102, 600);
            panel1.TabIndex = 0;
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.MediumSlateBlue;
            DeleteButton.BackgroundColor = Color.MediumSlateBlue;
            DeleteButton.BorderColor = Color.Red;
            DeleteButton.BorderRadius = 0;
            DeleteButton.BorderSize = 0;
            DeleteButton.DialogResult = DialogResult.OK;
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DeleteButton.ForeColor = Color.White;
            DeleteButton.Location = new Point(752, 511);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(140, 45);
            DeleteButton.TabIndex = 16;
            DeleteButton.Text = "Видалити";
            DeleteButton.TextColor = Color.White;
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.MediumSlateBlue;
            UpdateButton.BackgroundColor = Color.MediumSlateBlue;
            UpdateButton.BorderColor = Color.Red;
            UpdateButton.BorderRadius = 0;
            UpdateButton.BorderSize = 0;
            UpdateButton.FlatAppearance.BorderSize = 0;
            UpdateButton.FlatStyle = FlatStyle.Flat;
            UpdateButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UpdateButton.ForeColor = Color.White;
            UpdateButton.Location = new Point(594, 511);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(130, 45);
            UpdateButton.TabIndex = 15;
            UpdateButton.Text = "Змінити";
            UpdateButton.TextColor = Color.White;
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // ArtistComboBox
            // 
            ArtistComboBox.FormattingEnabled = true;
            ArtistComboBox.Location = new Point(752, 250);
            ArtistComboBox.Name = "ArtistComboBox";
            ArtistComboBox.Size = new Size(309, 33);
            ArtistComboBox.TabIndex = 12;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.MediumSlateBlue;
            CancelButton.BackgroundColor = Color.MediumSlateBlue;
            CancelButton.BorderColor = Color.Red;
            CancelButton.BorderRadius = 0;
            CancelButton.BorderSize = 0;
            CancelButton.DialogResult = DialogResult.Cancel;
            CancelButton.FlatAppearance.BorderSize = 0;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CancelButton.ForeColor = Color.White;
            CancelButton.Location = new Point(921, 511);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(140, 45);
            CancelButton.TabIndex = 18;
            CancelButton.Text = "Відміна";
            CancelButton.TextColor = Color.White;
            CancelButton.UseVisualStyleBackColor = false;
            // 
            // OkButton
            // 
            OkButton.BackColor = Color.MediumSlateBlue;
            OkButton.BackgroundColor = Color.MediumSlateBlue;
            OkButton.BorderColor = Color.Red;
            OkButton.BorderRadius = 0;
            OkButton.BorderSize = 0;
            OkButton.DialogResult = DialogResult.OK;
            OkButton.FlatAppearance.BorderSize = 0;
            OkButton.FlatStyle = FlatStyle.Flat;
            OkButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OkButton.ForeColor = Color.White;
            OkButton.Location = new Point(752, 511);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(130, 45);
            OkButton.TabIndex = 17;
            OkButton.Text = "Ок";
            OkButton.TextColor = Color.White;
            OkButton.UseVisualStyleBackColor = false;
            OkButton.Click += OkButton_Click;
            // 
            // UploadButton
            // 
            UploadButton.BackColor = Color.MediumSlateBlue;
            UploadButton.BackgroundColor = Color.MediumSlateBlue;
            UploadButton.BorderColor = Color.Red;
            UploadButton.BorderRadius = 0;
            UploadButton.BorderSize = 0;
            UploadButton.FlatAppearance.BorderSize = 0;
            UploadButton.FlatStyle = FlatStyle.Flat;
            UploadButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            UploadButton.ForeColor = Color.White;
            UploadButton.Location = new Point(74, 473);
            UploadButton.Name = "UploadButton";
            UploadButton.Size = new Size(215, 45);
            UploadButton.TabIndex = 1;
            UploadButton.Text = "Завантажити";
            UploadButton.TextColor = Color.White;
            UploadButton.UseVisualStyleBackColor = false;
            UploadButton.Click += UploadButton_Click;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(752, 386);
            PriceTextBox.MaxLength = 1000000000;
            PriceTextBox.Multiline = true;
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(309, 60);
            PriceTextBox.TabIndex = 14;
            PriceTextBox.KeyPress += PriceTextBox_KeyPress;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PriceLabel.Location = new Point(752, 330);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(58, 30);
            PriceLabel.TabIndex = 13;
            PriceLabel.Text = "Ціна";
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TypeLabel.Location = new Point(752, 71);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(51, 30);
            TypeLabel.TabIndex = 8;
            TypeLabel.Text = "Тип";
            // 
            // ArtistLabel
            // 
            ArtistLabel.AutoSize = true;
            ArtistLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ArtistLabel.Location = new Point(752, 192);
            ArtistLabel.Name = "ArtistLabel";
            ArtistLabel.Size = new Size(115, 30);
            ArtistLabel.TabIndex = 11;
            ArtistLabel.Text = "Художник";
            // 
            // PaintingForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 601);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1100, 601);
            MinimumSize = new Size(1100, 601);
            Name = "PaintingForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += PaintingForm_Load;
            ((System.ComponentModel.ISupportInitialize)PaintingPictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PaintingPictureBox;
        private Label label1;
        private TextBox TitleTextBox;
        private Label label2;
        private Label label3;
        private RadioButton CopyRadio;
        private RadioButton OriginalRadio;
        private DateTimePicker CreationDate;
        private TextBox GenreTextBox;
        private Panel panel1;
        private Label ArtistLabel;
        private Label TypeLabel;
        private Label PriceLabel;
        private TextBox PriceTextBox;
        private AdditionalElements.RoundButton UploadButton;
        private AdditionalElements.RoundButton CancelButton;
        private AdditionalElements.RoundButton OkButton;
        private ComboBox ArtistComboBox;
        private AdditionalElements.RoundButton DeleteButton;
        private AdditionalElements.RoundButton UpdateButton;
    }
}