namespace RealArt
{
    partial class SignUpForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            ToLogin = new Button();
            ToMain = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            NameArea = new TextBox();
            PasswordArea = new TextBox();
            ArtistRadio = new RadioButton();
            label6 = new Label();
            СollectorRadio = new RadioButton();
            OrganisationRadio = new RadioButton();
            SignupButton = new Button();
            MuseumRadio = new RadioButton();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 173, 164);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ToLogin);
            panel1.Controls.Add(ToMain);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 741);
            panel1.TabIndex = 0;
            // 
            // ToLogin
            // 
            ToLogin.BackColor = Color.Transparent;
            ToLogin.FlatStyle = FlatStyle.Flat;
            ToLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ToLogin.ForeColor = Color.White;
            ToLogin.Location = new Point(253, 514);
            ToLogin.Name = "ToLogin";
            ToLogin.Size = new Size(145, 53);
            ToLogin.TabIndex = 5;
            ToLogin.Text = "Увійти";
            ToLogin.UseVisualStyleBackColor = false;
            ToLogin.Click += ToLogin_Click;
            // 
            // ToMain
            // 
            ToMain.BackColor = Color.Transparent;
            ToMain.FlatStyle = FlatStyle.Flat;
            ToMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ToMain.ForeColor = Color.White;
            ToMain.Location = new Point(54, 514);
            ToMain.Name = "ToMain";
            ToMain.Size = new Size(145, 53);
            ToMain.TabIndex = 4;
            ToMain.Text = "Головна";
            ToMain.UseVisualStyleBackColor = false;
            ToMain.Click += ToMain_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(44, 410);
            label3.Name = "label3";
            label3.Size = new Size(375, 53);
            label3.TabIndex = 3;
            label3.Text = "Вже маєте акаунт?";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(44, 257);
            label2.Name = "label2";
            label2.Size = new Size(375, 153);
            label2.TabIndex = 2;
            label2.Text = "Зареєструйтеся, щоб мати змогу користуватися усіма можливостями сайта";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(158, 182);
            label1.Name = "label1";
            label1.Size = new Size(142, 45);
            label1.TabIndex = 1;
            label1.Text = "Вітаємо";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.FromArgb(54, 173, 164);
            label5.Location = new Point(183, 60);
            label5.Name = "label5";
            label5.Size = new Size(245, 38);
            label5.TabIndex = 7;
            label5.Text = "Створити акаунт";
            // 
            // NameArea
            // 
            NameArea.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameArea.ForeColor = Color.Black;
            NameArea.Location = new Point(73, 169);
            NameArea.MaxLength = 80;
            NameArea.Name = "NameArea";
            NameArea.PlaceholderText = "Введіть ім'я";
            NameArea.Size = new Size(484, 37);
            NameArea.TabIndex = 8;
            // 
            // PasswordArea
            // 
            PasswordArea.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PasswordArea.ForeColor = Color.Black;
            PasswordArea.Location = new Point(73, 266);
            PasswordArea.MaxLength = 128;
            PasswordArea.Name = "PasswordArea";
            PasswordArea.PlaceholderText = "Введіть пароль";
            PasswordArea.Size = new Size(484, 37);
            PasswordArea.TabIndex = 9;
            PasswordArea.UseSystemPasswordChar = true;
            // 
            // ArtistRadio
            // 
            ArtistRadio.AutoSize = true;
            ArtistRadio.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ArtistRadio.Location = new Point(181, 378);
            ArtistRadio.Name = "ArtistRadio";
            ArtistRadio.Size = new Size(128, 32);
            ArtistRadio.TabIndex = 11;
            ArtistRadio.TabStop = true;
            ArtistRadio.Text = "художник";
            ArtistRadio.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.FromArgb(54, 173, 164);
            label6.Location = new Point(73, 457);
            label6.Name = "label6";
            label6.Size = new Size(66, 32);
            label6.TabIndex = 10;
            label6.Text = "Роль";
            // 
            // СollectorRadio
            // 
            СollectorRadio.AutoSize = true;
            СollectorRadio.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            СollectorRadio.Location = new Point(181, 431);
            СollectorRadio.Name = "СollectorRadio";
            СollectorRadio.Size = new Size(153, 32);
            СollectorRadio.TabIndex = 12;
            СollectorRadio.TabStop = true;
            СollectorRadio.Text = "колекціонер";
            СollectorRadio.UseVisualStyleBackColor = true;
            // 
            // OrganisationRadio
            // 
            OrganisationRadio.AutoSize = true;
            OrganisationRadio.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OrganisationRadio.Location = new Point(181, 535);
            OrganisationRadio.Name = "OrganisationRadio";
            OrganisationRadio.Size = new Size(142, 32);
            OrganisationRadio.TabIndex = 14;
            OrganisationRadio.TabStop = true;
            OrganisationRadio.Text = "організація";
            OrganisationRadio.UseVisualStyleBackColor = true;
            // 
            // SignupButton
            // 
            SignupButton.BackColor = Color.FromArgb(54, 173, 164);
            SignupButton.FlatStyle = FlatStyle.Flat;
            SignupButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SignupButton.ForeColor = Color.White;
            SignupButton.Location = new Point(182, 617);
            SignupButton.Name = "SignupButton";
            SignupButton.Size = new Size(244, 53);
            SignupButton.TabIndex = 15;
            SignupButton.Text = "Зареєструватися";
            SignupButton.UseVisualStyleBackColor = false;
            SignupButton.Click += SignupButton_Click;
            // 
            // MuseumRadio
            // 
            MuseumRadio.AutoSize = true;
            MuseumRadio.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MuseumRadio.Location = new Point(181, 484);
            MuseumRadio.Name = "MuseumRadio";
            MuseumRadio.Size = new Size(97, 32);
            MuseumRadio.TabIndex = 13;
            MuseumRadio.TabStop = true;
            MuseumRadio.Text = "музей ";
            MuseumRadio.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(OrganisationRadio);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(MuseumRadio);
            panel2.Controls.Add(СollectorRadio);
            panel2.Controls.Add(ArtistRadio);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(NameArea);
            panel2.Controls.Add(PasswordArea);
            panel2.Controls.Add(SignupButton);
            panel2.Location = new Point(449, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(619, 741);
            panel2.TabIndex = 6;
            panel2.TabStop = true;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1068, 741);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button ToMain;
        private Button ToLogin;
        private Label label5;
        private TextBox NameArea;
        private TextBox PasswordArea;
        private RadioButton ArtistRadio;
        private Label label6;
        private RadioButton СollectorRadio;
        private RadioButton OrganisationRadio;
        private Button SignupButton;
        private RadioButton MuseumRadio;
        private Panel panel2;
    }
}
