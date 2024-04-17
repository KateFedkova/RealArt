using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealArt
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ToSignup_Click(object sender, EventArgs e)
        {
            SignUpForm signup = new SignUpForm(); 
            signup.Show();
            this.Hide();
        }

        private void ToMain_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
           
        }
    }
}
