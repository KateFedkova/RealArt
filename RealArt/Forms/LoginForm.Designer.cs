namespace RealArt
{
    partial class LoginForm
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
            ToSignup = new Button();
            ToMain = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            NameArea = new TextBox();
            PasswordArea = new TextBox();
            LoginButton = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 173, 164);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ToSignup);
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
            // ToSignup
            // 
            ToSignup.BackColor = Color.Transparent;
            ToSignup.FlatStyle = FlatStyle.Flat;
            ToSignup.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ToSignup.ForeColor = Color.White;
            ToSignup.Location = new Point(210, 516);
            ToSignup.Name = "ToSignup";
            ToSignup.Size = new Size(209, 53);
            ToSignup.TabIndex = 5;
            ToSignup.Text = "Зареєструватися";
            ToSignup.UseVisualStyleBackColor = false;
            ToSignup.Click += ToSignup_Click;
            // 
            // ToMain
            // 
            ToMain.BackColor = Color.Transparent;
            ToMain.FlatStyle = FlatStyle.Flat;
            ToMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ToMain.ForeColor = Color.White;
            ToMain.Location = new Point(34, 516);
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
            label3.Text = "Ще не маєте акаунту?";
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
            label2.Text = "Увійдіть в акаунт, щоб мати змогу користуватися усіма можливостями сайта";
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
            label5.Location = new Point(191, 146);
            label5.Name = "label5";
            label5.Size = new Size(229, 38);
            label5.TabIndex = 7;
            label5.Text = "Увійти в акаунт";
            // 
            // NameArea
            // 
            NameArea.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameArea.ForeColor = Color.Black;
            NameArea.Location = new Point(78, 257);
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
            PasswordArea.Location = new Point(78, 373);
            PasswordArea.MaxLength = 128;
            PasswordArea.Name = "PasswordArea";
            PasswordArea.PlaceholderText = "Введіть пароль";
            PasswordArea.Size = new Size(484, 37);
            PasswordArea.TabIndex = 9;
            PasswordArea.UseSystemPasswordChar = true;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(54, 173, 164);
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(229, 517);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(135, 53);
            LoginButton.TabIndex = 10;
            LoginButton.Text = "Увійти";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Controls.Add(LoginButton);
            panel2.Controls.Add(NameArea);
            panel2.Controls.Add(PasswordArea);
            panel2.Location = new Point(450, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(618, 737);
            panel2.TabIndex = 6;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1068, 741);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button ToSignup;
        private Button ToMain;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox NameArea;
        private TextBox PasswordArea;
        private Button LoginButton;
        private Panel panel2;
    }
}