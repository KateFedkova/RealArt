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
            AddPaintingButton = new AdditionalElements.RoundButton();
            DeleteButton = new AdditionalElements.RoundButton();
            UpdateButton = new AdditionalElements.RoundButton();
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
            label2.TabIndex = 4;
            label2.Text = "Дата проведення";
            // 
            // AuctionDate
            // 
            AuctionDate.Format = DateTimePickerFormat.Short;
            AuctionDate.Location = new Point(373, 288);
            AuctionDate.Name = "AuctionDate";
            AuctionDate.Size = new Size(300, 31);
            AuctionDate.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(AddPaintingButton);
            panel1.Controls.Add(DeleteButton);
            panel1.Controls.Add(UpdateButton);
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
            panel1.Size = new Size(756, 647);
            panel1.TabIndex = 0;
            // 
            // AddPaintingButton
            // 
            AddPaintingButton.BackColor = Color.MediumSlateBlue;
            AddPaintingButton.BackgroundColor = Color.MediumSlateBlue;
            AddPaintingButton.BorderColor = Color.Red;
            AddPaintingButton.BorderRadius = 0;
            AddPaintingButton.BorderSize = 0;
            AddPaintingButton.DialogResult = DialogResult.OK;
            AddPaintingButton.FlatAppearance.BorderSize = 0;
            AddPaintingButton.FlatStyle = FlatStyle.Flat;
            AddPaintingButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddPaintingButton.ForeColor = Color.White;
            AddPaintingButton.Location = new Point(541, 507);
            AddPaintingButton.Name = "AddPaintingButton";
            AddPaintingButton.Size = new Size(192, 45);
            AddPaintingButton.TabIndex = 8;
            AddPaintingButton.Text = "Додати картину";
            AddPaintingButton.TextColor = Color.White;
            AddPaintingButton.UseVisualStyleBackColor = false;
            AddPaintingButton.Click += AddPaintingButton_Click;
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
            DeleteButton.Location = new Point(318, 577);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(128, 45);
            DeleteButton.TabIndex = 9;
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
            UpdateButton.Location = new Point(460, 577);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(130, 45);
            UpdateButton.TabIndex = 10;
            UpdateButton.Text = "Змінити";
            UpdateButton.TextColor = Color.White;
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(373, 357);
            label3.Name = "label3";
            label3.Size = new Size(135, 30);
            label3.TabIndex = 6;
            label3.Text = "Час початку";
            // 
            // AuctionTime
            // 
            AuctionTime.Format = DateTimePickerFormat.Time;
            AuctionTime.Location = new Point(373, 406);
            AuctionTime.Name = "AuctionTime";
            AuctionTime.ShowUpDown = true;
            AuctionTime.Size = new Size(300, 31);
            AuctionTime.TabIndex = 7;
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
            CancelButton.Location = new Point(603, 577);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(130, 45);
            CancelButton.TabIndex = 12;
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
            OkButton.Location = new Point(480, 577);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(95, 45);
            OkButton.TabIndex = 11;
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
            ClientSize = new Size(757, 648);
            ControlBox = false;
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(757, 648);
            MinimumSize = new Size(757, 648);
            Name = "AddAuctionForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += AddAuctionForm_Load;
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
        private AdditionalElements.RoundButton AddPaintingButton;
        private AdditionalElements.RoundButton DeleteButton;
        private AdditionalElements.RoundButton UpdateButton;
    }
}