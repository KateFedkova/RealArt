using RealArt.Models;
using System.Text.Json;

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
            CountryChooser.DataBindings.Add("Text", source, "Country", false, DataSourceUpdateMode.Never);
            StyleTextbox.DataBindings.Add("Text", source, "Style", false, DataSourceUpdateMode.Never);
            AboutTextbox.DataBindings.Add("Text", source, "About", false, DataSourceUpdateMode.Never);
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
            CountryChooser.DataBindings.Add("Text", source, "Country", false, DataSourceUpdateMode.Never);
            AddressTextbox.DataBindings.Add("Text", source, "Address", false, DataSourceUpdateMode.Never);
            OpeningTimePicker.DataBindings.Add("Text", source, "OpeningTime", false, DataSourceUpdateMode.Never);
            ClosingTimePicker.DataBindings.Add("Text", source, "ClosingTime", false, DataSourceUpdateMode.Never);
            AboutTextbox.DataBindings.Add("Text", source, "About", false, DataSourceUpdateMode.Never);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (InfoChanged())
            {
                string role = CurrentUser.Role;
                string[] jsonLines = FileWorker.ReadFile(role + "s");
                List<User> users = new List<User>();

                foreach (string userString in jsonLines)
                {

                    if (role == "Artist" || role == "Collector")
                    {
                        Person? user = JsonSerializer.Deserialize<Person?>(userString);

                        if (user?.Id == CurrentUser.Info.Id)
                        {
                            user.Country = CountryChooser.Text;
                            user.About = AboutTextbox.Text;
                            user.Style = StyleTextbox.Text;
                            UpdateCurrentPerson((Person) CurrentUser.Info);
                        }

                        if (user != null)
                        {
                            users.Add(user);
                        }
                    }

                    else if (role == "Museum" || role == "Organisation")
                    {
                        Organisation? user = JsonSerializer.Deserialize<Organisation?>(userString);

                        if (user?.Id == CurrentUser.Info.Id)
                        {
                            user.Country = CountryChooser.Text;
                            user.About = AboutTextbox.Text;
                            user.Address = AddressTextbox.Text;
                            user.OpeningTime = OpeningTimePicker.Text;
                            user.ClosingTime = ClosingTimePicker.Text;

                            UpdateCurrentOrganisation((Organisation) CurrentUser.Info);
                        }

                        if (user != null)
                        {
                            users.Add(user);
                        }
                    }
                }

                FileWorker.UpdateInfoInFiles(role, users);
            }
        }

        private bool InfoChanged()
        {
            if (CurrentUser.Info is Person person)
            {
                return person.Country != CountryChooser.Text ||
                    person.Style != StyleTextbox.Text ||
                    person.About != AboutTextbox.Text;
            }

            else if (CurrentUser.Info is Organisation organisation)
            {
                return organisation.Country != CountryChooser.Text ||
                    organisation.Address != AddressTextbox.Text ||
                    organisation.About != AboutTextbox.Text ||
                    organisation.OpeningTime != OpeningTimePicker.Text ||
                    organisation.ClosingTime != ClosingTimePicker.Text;
            }

            return false;
        }

        private void UpdateCurrentPerson(Person person)
        {
            person.Country = CountryChooser.Text;
            person.About = AboutTextbox.Text;
            person.Style = StyleTextbox.Text;
        }

        private void UpdateCurrentOrganisation(Organisation organisation)
        {
            organisation.Country = CountryChooser.Text;
            organisation.About = AboutTextbox.Text;
            organisation.OpeningTime = OpeningTimePicker.Text;
            organisation.ClosingTime = ClosingTimePicker.Text;
            organisation.Address = AddressTextbox.Text;
        }
    }
}
