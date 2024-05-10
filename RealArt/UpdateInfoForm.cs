using RealArt.Models;

namespace RealArt
{
    public partial class UpdateInfoForm : Form
    {
        public UpdateInfoForm()
        {
            InitializeComponent();
        }

        private void UpdateInfoForm_Load(object sender, EventArgs e)
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
            AddressTextbox.Visible = false;
            OpeningLabel.Visible = false;
            OpeningTimePicker.Visible = false;
            ClosingLabel.Visible = false;
            ClosingTimePicker.Visible = false;
        }

        private void PersonSetInfo(BindingSource source, Person user)
        {
            source.DataSource = user;
            CoutryChooser.DataBindings.Add("Text", source, "Country");
            StyleTextbox.DataBindings.Add("Text", source, "Style");
            AboutTextbox.DataBindings.Add("Text", source, "About");
        }

        private void OrganisationElementsVisibility()
        {
            StyleLabel.Visible = false;
            StyleTextbox.Visible = false;
            AddressLabel.Location = new Point(52, 245);
            AddressTextbox.Location = new Point(52, 301);
            OpeningLabel.Location = new Point(52, 435);
            OpeningTimePicker.Location = new Point(52, 480);
            ClosingLabel.Location = new Point(52, 528);
            ClosingTimePicker.Location = new Point(52, 573);
        }


        private void OrganisationSetInfo(BindingSource source, Organisation user)
        {
            source.DataSource = user;
            CoutryChooser.DataBindings.Add("Text", source, "Country");
            AddressTextbox.DataBindings.Add("Text", source, "Address");
            OpeningTimePicker.DataBindings.Add("Text", source, "OpeningTime");
            ClosingTimePicker.DataBindings.Add("Text", source, "ClosiingTime");
            AboutTextbox.DataBindings.Add("Text", source, "About");
        }

    }
}
