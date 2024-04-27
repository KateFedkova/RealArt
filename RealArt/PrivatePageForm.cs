using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic.ApplicationServices;
using RealArt.Models;

namespace RealArt
{
    public partial class PrivatePageForm : Form
    {
        private MainForm main;

        public PrivatePageForm(MainForm main)
        {
            InitializeComponent();
            this.main = main;
        }
        
        private void ToMain_Click(object sender, EventArgs e)
        {
            this.Close();
            this.main.Show();
        }

        private void PrivatePageForm_Load(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();

            if (CurrentUser.Info is Person person)
            {
                PersonElementsVisibility();
                PersonSetInfo(bindingSource, person);
            }

            else if (CurrentUser.Info is Organisation organisation)
            {
                OrganisationElementsVisibility();
                OrganisationSetInfo(bindingSource, organisation);
            }
        }

        private void PersonElementsVisibility()
        {
            AddressLabel.Visible = false;
            WorkingTimeLabel.Visible = false;
            AddressInfoLabel.Visible = false;
            WorkingTimeInfoLabel.Visible = false;
        }

        private void PersonSetInfo(BindingSource source, Person user)
        {
            source.DataSource = user;
            BindLabel(CountryInfoLabel, source, "Country");
            BindLabel(StyleInfoLabel, source, "Style");
            BindTextbox(AboutInfoTextbox, source, "About");
            BindImage(UserPicturebox, source, "Foto");
        }

        private void OrganisationElementsVisibility()
        {
            StyleLabel.Visible = false;
            StyleInfoLabel.Visible = false;
            AddressLabel.Location = new Point(201, 79);
            AddressInfoLabel.Location = new Point(293, 79);
            WorkingTimeLabel.Location = new Point(201, 125);
            WorkingTimeInfoLabel.Location = new Point(328, 125);
        }

        private void OrganisationSetInfo(BindingSource source, Organisation user)
        {
            source.DataSource = user;

            BindLabel(CountryInfoLabel, source, "Country");
            BindLabel(AddressInfoLabel, source, "Address");
            BindLabel(WorkingTimeInfoLabel, source, "Time");
            BindTextbox(AboutInfoTextbox, source, "About");
            BindImage(UserPicturebox, source, "Foto");
        }

        private void BindLabel(Label label, object source, string property)
        {
            Binding binding = new Binding("Text", source, property);
            binding.Format += (sender, e) =>
            {
                e.Value ??= "невідомо";
            };
            label.DataBindings.Add(binding);
        }

        private void BindTextbox(TextBox textBox, object dataSource, string propertyName)
        {
            Binding binding = new Binding("Text", dataSource, propertyName);
            binding.Format += (sender, e) =>
            {
                e.Value ??= "невідомо";
            };
            textBox.DataBindings.Add(binding);
        }

        private void BindImage(PictureBox pictureBox, object dataSource, string propertyName)
        {
            Binding binding = new Binding("ImageLocation", dataSource, propertyName);
            pictureBox.DataBindings.Add(binding);
        }

        
    }
}
