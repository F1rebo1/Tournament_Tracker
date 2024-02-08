using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary.Models;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

        private void CreateSampleData(){
            availableTeamMembers.Add(new PersonModel { FirstName = "Rohan", LastName = "Shanbhag"} );
            availableTeamMembers.Add(new PersonModel { FirstName = "Bob", LastName = "Jones" });

            selectedTeamMembers.Add(new PersonModel { FirstName = "Ra", LastName = "Sudeep" });
            selectedTeamMembers.Add(new PersonModel { FirstName = "Gordon", LastName = "Ramsay" });
        }

        private void WireUpLists(){
            selectTeamMemberDropDown.DataSource = availableTeamMembers;
            selectTeamMemberDropDown.DisplayMember = "FullName";

            teamMembersListBox.DataSource = selectedTeamMembers;
            teamMembersListBox.DisplayMember = "FullName";
        }

        public CreateTeamForm()
        {
            InitializeComponent();

            CreateSampleData();

            WireUpLists();
        }

        private void createMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel person = new PersonModel(
                firstNameValue.Text,
                lastNameValue.Text,
                emailValue.Text,
                cellphoneValue.Text);

                GlobalConfig.Connection.CreatePerson(person);

                firstNameValue.Text = "";
                lastNameValue.Text = "";
                emailValue.Text = "";
                cellphoneValue.Text = "";
            }
            /*
            else {
                MessageBox.Show("This form has invalid information. Please check it and try again!");
            }
            */
        }

        private bool ValidateForm(){
            bool valid = true;
            
            if(firstNameValue.Text.Length <= 0) valid = false;
            if(lastNameValue.Text.Length <= 0) valid = false;
            if(emailValue.Text.Length <= 0 || emailValue.Text.IndexOf('@') == -1 || emailValue.Text.Count(c => c == '.') > 1) valid = false;
            if(cellphoneValue.Text.Length != 10) valid = false;

            return valid;
        }
    }
}
