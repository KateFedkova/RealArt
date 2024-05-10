namespace RealArt
{
    partial class UpdateInfoForm
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
            CancelButton = new AdditionalElements.RoundButton();
            OkButton = new AdditionalElements.RoundButton();
            ClosingTimePicker = new DateTimePicker();
            AddressTextbox = new TextBox();
            StyleTextbox = new TextBox();
            AboutTextbox = new TextBox();
            label7 = new Label();
            OpeningTimePicker = new DateTimePicker();
            CoutryChooser = new ComboBox();
            ClosingLabel = new Label();
            OpeningLabel = new Label();
            AddressLabel = new Label();
            StyleLabel = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(CancelButton);
            panel1.Controls.Add(OkButton);
            panel1.Controls.Add(ClosingTimePicker);
            panel1.Controls.Add(AddressTextbox);
            panel1.Controls.Add(StyleTextbox);
            panel1.Controls.Add(AboutTextbox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(OpeningTimePicker);
            panel1.Controls.Add(CoutryChooser);
            panel1.Controls.Add(ClosingLabel);
            panel1.Controls.Add(OpeningLabel);
            panel1.Controls.Add(AddressLabel);
            panel1.Controls.Add(StyleLabel);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-10, -11);
            panel1.Name = "panel1";
            panel1.Size = new Size(849, 704);
            panel1.TabIndex = 0;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.MediumSlateBlue;
            CancelButton.BackgroundColor = Color.MediumSlateBlue;
            CancelButton.BorderColor = Color.Red;
            CancelButton.BorderRadius = 20;
            CancelButton.BorderSize = 0;
            CancelButton.DialogResult = DialogResult.Cancel;
            CancelButton.FlatAppearance.BorderSize = 0;
            CancelButton.FlatStyle = FlatStyle.Flat;
            CancelButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CancelButton.ForeColor = Color.White;
            CancelButton.Location = new Point(597, 599);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(180, 55);
            CancelButton.TabIndex = 15;
            CancelButton.Text = "Не змінювати";
            CancelButton.TextColor = Color.White;
            CancelButton.UseVisualStyleBackColor = false;
            // 
            // OkButton
            // 
            OkButton.BackColor = Color.MediumSlateBlue;
            OkButton.BackgroundColor = Color.MediumSlateBlue;
            OkButton.BorderColor = Color.Red;
            OkButton.BorderRadius = 20;
            OkButton.BorderSize = 0;
            OkButton.DialogResult = DialogResult.OK;
            OkButton.FlatAppearance.BorderSize = 0;
            OkButton.FlatStyle = FlatStyle.Flat;
            OkButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OkButton.ForeColor = Color.White;
            OkButton.Location = new Point(455, 599);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(105, 55);
            OkButton.TabIndex = 14;
            OkButton.Text = "OK";
            OkButton.TextColor = Color.White;
            OkButton.UseVisualStyleBackColor = false;
            // 
            // ClosingTimePicker
            // 
            ClosingTimePicker.Format = DateTimePickerFormat.Time;
            ClosingTimePicker.Location = new Point(455, 478);
            ClosingTimePicker.Name = "ClosingTimePicker";
            ClosingTimePicker.ShowUpDown = true;
            ClosingTimePicker.Size = new Size(300, 31);
            ClosingTimePicker.TabIndex = 11;
            // 
            // AddressTextbox
            // 
            AddressTextbox.Location = new Point(52, 456);
            AddressTextbox.MaxLength = 120;
            AddressTextbox.Multiline = true;
            AddressTextbox.Name = "AddressTextbox";
            AddressTextbox.Size = new Size(322, 117);
            AddressTextbox.TabIndex = 7;
            // 
            // StyleTextbox
            // 
            StyleTextbox.Location = new Point(52, 301);
            StyleTextbox.MaxLength = 120;
            StyleTextbox.Multiline = true;
            StyleTextbox.Name = "StyleTextbox";
            StyleTextbox.Size = new Size(322, 58);
            StyleTextbox.TabIndex = 5;
            // 
            // AboutTextbox
            // 
            AboutTextbox.Location = new Point(455, 170);
            AboutTextbox.MaxLength = 120;
            AboutTextbox.Multiline = true;
            AboutTextbox.Name = "AboutTextbox";
            AboutTextbox.Size = new Size(322, 117);
            AboutTextbox.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(287, 45);
            label7.Name = "label7";
            label7.Size = new Size(273, 30);
            label7.TabIndex = 1;
            label7.Text = "Update your personal info";
            // 
            // OpeningTimePicker
            // 
            OpeningTimePicker.Format = DateTimePickerFormat.Time;
            OpeningTimePicker.Location = new Point(455, 369);
            OpeningTimePicker.Name = "OpeningTimePicker";
            OpeningTimePicker.ShowUpDown = true;
            OpeningTimePicker.Size = new Size(300, 31);
            OpeningTimePicker.TabIndex = 9;
            // 
            // CoutryChooser
            // 
            CoutryChooser.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CoutryChooser.FormattingEnabled = true;
            CoutryChooser.Location = new Point(52, 170);
            CoutryChooser.Name = "CoutryChooser";
            CoutryChooser.Size = new Size(322, 36);
            CoutryChooser.TabIndex = 3;
            // 
            // ClosingLabel
            // 
            ClosingLabel.AutoSize = true;
            ClosingLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ClosingLabel.Location = new Point(455, 428);
            ClosingLabel.Name = "ClosingLabel";
            ClosingLabel.Size = new Size(133, 30);
            ClosingLabel.TabIndex = 10;
            ClosingLabel.Text = "Closing time";
            // 
            // OpeningLabel
            // 
            OpeningLabel.AutoSize = true;
            OpeningLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OpeningLabel.Location = new Point(455, 325);
            OpeningLabel.Name = "OpeningLabel";
            OpeningLabel.Size = new Size(146, 30);
            OpeningLabel.TabIndex = 8;
            OpeningLabel.Text = "Opening time";
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddressLabel.Location = new Point(52, 397);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(91, 30);
            AddressLabel.TabIndex = 6;
            AddressLabel.Text = "Address";
            // 
            // StyleLabel
            // 
            StyleLabel.AutoSize = true;
            StyleLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            StyleLabel.Location = new Point(52, 245);
            StyleLabel.Name = "StyleLabel";
            StyleLabel.Size = new Size(59, 30);
            StyleLabel.TabIndex = 4;
            StyleLabel.Text = "Style";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(455, 116);
            label2.Name = "label2";
            label2.Size = new Size(72, 30);
            label2.TabIndex = 12;
            label2.Text = "About";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(52, 116);
            label1.Name = "label1";
            label1.Size = new Size(90, 30);
            label1.TabIndex = 2;
            label1.Text = "Country";
            // 
            // UpdateInfoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 683);
            ControlBox = false;
            Controls.Add(panel1);
            MaximumSize = new Size(850, 802);
            MinimumSize = new Size(850, 705);
            Name = "UpdateInfoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += UpdateInfoForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label StyleLabel;
        private Label label2;
        private Label AddressLabel;
        private Label OpeningLabel;
        private Label ClosingLabel;
        private ComboBox CoutryChooser;
        private DateTimePicker OpeningTimePicker;
        private TextBox AboutTextbox;
        private Label label7;
        private TextBox AddressTextbox;
        private TextBox StyleTextbox;
        private DateTimePicker ClosingTimePicker;
        private AdditionalElements.RoundButton OkButton;
        private AdditionalElements.RoundButton CancelButton;
    }
}