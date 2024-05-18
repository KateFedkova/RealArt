namespace RealArt
{
    partial class AddAuctionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAuctionForm));
            PaintingPictureBox = new PictureBox();
            label1 = new Label();
            TitleTextBox = new TextBox();
            label2 = new Label();
            AuctionDate = new DateTimePicker();
            panel1 = new Panel();
            label3 = new Label();
            AuctionTime = new DateTimePicker();
            CancelButton = new AdditionalElements.RoundButton();
            OkButton = new AdditionalElements.RoundButton();
            UploadButton = new AdditionalElements.RoundButton();
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
            label1.Location = new Point(373, 71);
            label1.Name = "label1";
            label1.Size = new Size(73, 30);
            label1.TabIndex = 2;
            label1.Text = "Назва";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(373, 124);
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
            label2.Location = new Point(373, 235);
            label2.Name = "label2";
            label2.Size = new Size(189, 30);
            label2.TabIndex = 6;
            label2.Text = "Дата проведення";
            // 
            // AuctionDate
            // 
            AuctionDate.Format = DateTimePickerFormat.Short;
            AuctionDate.Location = new Point(373, 288);
            AuctionDate.Name = "AuctionDate";
            AuctionDate.Size = new Size(300, 31);
            AuctionDate.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(AuctionTime);
            panel1.Controls.Add(CancelButton);
            panel1.Controls.Add(OkButton);
            panel1.Controls.Add(UploadButton);
            panel1.Controls.Add(PaintingPictureBox);
            panel1.Controls.Add(AuctionDate);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TitleTextBox);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(756, 600);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(373, 357);
            label3.Name = "label3";
            label3.Size = new Size(135, 30);
            label3.TabIndex = 19;
            label3.Text = "Час початку";
            // 
            // AuctionTime
            // 
            AuctionTime.Format = DateTimePickerFormat.Time;
            AuctionTime.Location = new Point(373, 406);
            AuctionTime.Name = "AuctionTime";
            AuctionTime.ShowUpDown = true;
            AuctionTime.Size = new Size(300, 31);
            AuctionTime.TabIndex = 18;
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
            CancelButton.Location = new Point(556, 511);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(130, 45);
            CancelButton.TabIndex = 16;
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
            OkButton.Location = new Point(432, 511);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(95, 45);
            OkButton.TabIndex = 15;
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
            // AddAuctionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 601);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1100, 601);
            Name = "AddAuctionForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
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
        private DateTimePicker AuctionDate;
        private Panel panel1;
        private AdditionalElements.RoundButton UploadButton;
        private AdditionalElements.RoundButton CancelButton;
        private AdditionalElements.RoundButton OkButton;
        private DateTimePicker AuctionTime;
        private Label label3;
    }
}