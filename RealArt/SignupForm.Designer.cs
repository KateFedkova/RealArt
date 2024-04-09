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
            label4 = new Label();
            label5 = new Label();
            NameArea = new TextBox();
            PasswordArea = new TextBox();
            ArtistRadio = new RadioButton();
            label6 = new Label();
            СollectorRadio = new RadioButton();
            OrganisationRadio = new RadioButton();
            SignupButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
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
            panel1.Size = new Size(452, 741);
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
            ToMain.Click += button1_Click_1;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(497, 358);
            label4.Name = "label4";
            label4.Size = new Size(74, 25);
            label4.TabIndex = 2;
            label4.Text = "Вітаємо";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.FromArgb(54, 173, 164);
            label5.Location = new Point(632, 69);
            label5.Name = "label5";
            label5.Size = new Size(245, 38);
            label5.TabIndex = 3;
            label5.Text = "Створити акаунт";
            // 
            // NameArea
            // 
            NameArea.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameArea.ForeColor = Color.Black;
            NameArea.Location = new Point(523, 172);
            NameArea.MaxLength = 128;
            NameArea.Name = "NameArea";
            NameArea.PlaceholderText = "Введіть ім'я";
            NameArea.Size = new Size(484, 37);
            NameArea.TabIndex = 5;
            NameArea.TextChanged += textBox2_TextChanged;
            // 
            // PasswordArea
            // 
            PasswordArea.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PasswordArea.ForeColor = Color.Black;
            PasswordArea.Location = new Point(523, 269);
            PasswordArea.MaxLength = 128;
            PasswordArea.Name = "PasswordArea";
            PasswordArea.PlaceholderText = "Введіть пароль";
            PasswordArea.Size = new Size(484, 37);
            PasswordArea.TabIndex = 6;
            PasswordArea.UseSystemPasswordChar = true;
            // 
            // ArtistRadio
            // 
            ArtistRadio.AutoSize = true;
            ArtistRadio.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ArtistRadio.Location = new Point(632, 351);
            ArtistRadio.Name = "ArtistRadio";
            ArtistRadio.Size = new Size(128, 32);
            ArtistRadio.TabIndex = 7;
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
            label6.Location = new Point(523, 404);
            label6.Name = "label6";
            label6.Size = new Size(73, 32);
            label6.TabIndex = 8;
            label6.Text = "Роль ";
            // 
            // СollectorRadio
            // 
            СollectorRadio.AutoSize = true;
            СollectorRadio.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            СollectorRadio.Location = new Point(632, 405);
            СollectorRadio.Name = "СollectorRadio";
            СollectorRadio.Size = new Size(153, 32);
            СollectorRadio.TabIndex = 9;
            СollectorRadio.TabStop = true;
            СollectorRadio.Text = "колекціонер";
            СollectorRadio.UseVisualStyleBackColor = true;
            СollectorRadio.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // OrganisationRadio
            // 
            OrganisationRadio.AutoSize = true;
            OrganisationRadio.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OrganisationRadio.Location = new Point(632, 462);
            OrganisationRadio.Name = "OrganisationRadio";
            OrganisationRadio.Size = new Size(142, 32);
            OrganisationRadio.TabIndex = 10;
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
            SignupButton.Location = new Point(632, 549);
            SignupButton.Name = "SignupButton";
            SignupButton.Size = new Size(244, 53);
            SignupButton.TabIndex = 12;
            SignupButton.Text = "Зареєструватися";
            SignupButton.UseVisualStyleBackColor = false;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1068, 741);
            Controls.Add(SignupButton);
            Controls.Add(OrganisationRadio);
            Controls.Add(СollectorRadio);
            Controls.Add(label6);
            Controls.Add(ArtistRadio);
            Controls.Add(PasswordArea);
            Controls.Add(NameArea);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button ToMain;
        private Button ToLogin;
        private Label label4;
        private Label label5;
        private TextBox NameArea;
        private TextBox PasswordArea;
        private RadioButton ArtistRadio;
        private Label label6;
        private RadioButton СollectorRadio;
        private RadioButton OrganisationRadio;
        private Button SignupButton;
    }
}
