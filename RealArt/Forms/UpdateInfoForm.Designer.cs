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
            label1 = new Label();
            label2 = new Label();
            StyleLabel = new Label();
            AddressLabel = new Label();
            OpeningLabel = new Label();
            ClosingLabel = new Label();
            CountryChooser = new ComboBox();
            OpeningTimePicker = new DateTimePicker();
            label7 = new Label();
            AboutTextbox = new TextBox();
            StyleTextbox = new TextBox();
            AddressTextbox = new TextBox();
            ClosingTimePicker = new DateTimePicker();
            OkButton = new AdditionalElements.RoundButton();
            CancelButton = new AdditionalElements.RoundButton();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(52, 116);
            label1.Name = "label1";
            label1.Size = new Size(79, 30);
            label1.TabIndex = 2;
            label1.Text = "Країна";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(455, 116);
            label2.Name = "label2";
            label2.Size = new Size(108, 30);
            label2.TabIndex = 12;
            label2.Text = "Про себе";
            // 
            // StyleLabel
            // 
            StyleLabel.AutoSize = true;
            StyleLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            StyleLabel.Location = new Point(52, 245);
            StyleLabel.Name = "StyleLabel";
            StyleLabel.Size = new Size(72, 30);
            StyleLabel.TabIndex = 4;
            StyleLabel.Text = "Стиль";
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddressLabel.Location = new Point(52, 397);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(85, 30);
            AddressLabel.TabIndex = 6;
            AddressLabel.Text = "Адреса";
            // 
            // OpeningLabel
            // 
            OpeningLabel.AutoSize = true;
            OpeningLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OpeningLabel.Location = new Point(455, 325);
            OpeningLabel.Name = "OpeningLabel";
            OpeningLabel.Size = new Size(150, 30);
            OpeningLabel.TabIndex = 8;
            OpeningLabel.Text = "Час відкриття";
            // 
            // ClosingLabel
            // 
            ClosingLabel.AutoSize = true;
            ClosingLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ClosingLabel.Location = new Point(455, 428);
            ClosingLabel.Name = "ClosingLabel";
            ClosingLabel.Size = new Size(142, 30);
            ClosingLabel.TabIndex = 10;
            ClosingLabel.Text = "Час закриття";
            // 
            // CountryChooser
            // 
            CountryChooser.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CountryChooser.FormattingEnabled = true;
            CountryChooser.Items.AddRange(new object[] { "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "The Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina Faso", "Burundi", "Cabo Verde", "Cambodia", "Cameroon", "Canada", "Central African Republic", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo, ", "Democratic Republic of the Congo, ", "Republic of the Costa Rica", "Côte d’Ivoire", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "East Timor", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Eswatini", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "The Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "South Korea", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Federated States of Micronesia, ", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar (Burma)", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "North Macedonia", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "Spain", "Sri Lanka", "Sudan", "Sudan, South", "Suriname", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City", "Venezuela", "Vietnam", "Yemen", "Zambia", "Zimbabwe" });
            CountryChooser.Location = new Point(52, 170);
            CountryChooser.Name = "CountryChooser";
            CountryChooser.Size = new Size(322, 36);
            CountryChooser.TabIndex = 3;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(230, 45);
            label7.Name = "label7";
            label7.Size = new Size(375, 30);
            label7.TabIndex = 1;
            label7.Text = "Оновити персональну інформацію";
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
            // StyleTextbox
            // 
            StyleTextbox.Location = new Point(52, 301);
            StyleTextbox.MaxLength = 120;
            StyleTextbox.Multiline = true;
            StyleTextbox.Name = "StyleTextbox";
            StyleTextbox.Size = new Size(322, 58);
            StyleTextbox.TabIndex = 5;
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
            // ClosingTimePicker
            // 
            ClosingTimePicker.Format = DateTimePickerFormat.Time;
            ClosingTimePicker.Location = new Point(455, 478);
            ClosingTimePicker.Name = "ClosingTimePicker";
            ClosingTimePicker.ShowUpDown = true;
            ClosingTimePicker.Size = new Size(300, 31);
            ClosingTimePicker.TabIndex = 11;
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
            OkButton.Click += OkButton_Click;
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
            panel1.Controls.Add(CountryChooser);
            panel1.Controls.Add(ClosingLabel);
            panel1.Controls.Add(OpeningLabel);
            panel1.Controls.Add(AddressLabel);
            panel1.Controls.Add(StyleLabel);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-10, -12);
            panel1.Name = "panel1";
            panel1.Size = new Size(849, 705);
            panel1.TabIndex = 0;
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

        private Label label1;
        private Label label2;
        private Label StyleLabel;
        private Label AddressLabel;
        private Label OpeningLabel;
        private Label ClosingLabel;
        private ComboBox CountryChooser;
        private DateTimePicker OpeningTimePicker;
        private Label label7;
        private TextBox AboutTextbox;
        private TextBox StyleTextbox;
        private TextBox AddressTextbox;
        private DateTimePicker ClosingTimePicker;
        private AdditionalElements.RoundButton OkButton;
        private AdditionalElements.RoundButton CancelButton;
        private Panel panel1;
    }
}