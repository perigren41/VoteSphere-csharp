using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VoteSphere
{
    public partial class CreatePollForm : Form
    {
        private DatabaseConnection databaseConnection;
        private bool isFormLoaded = false;
        public CreatePollForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(CreatePollForm_Load);
            string connectionString = "Data Source=DESKTOP-75I29S6\\SQLEXPRESS03;Initial Catalog=VoteSphere;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            databaseConnection = new DatabaseConnection(connectionString);

        }
        private void CreatePollForm_Load(object sender, EventArgs e)
        {
            // Populate the organization combo box first
            PopulateOrganizationComboBox();

            // Set an event handler for when the selected organization changes
            OrgName_combobox.SelectedIndexChanged += new EventHandler(OrganizationComboBox_SelectedIndexChanged);

            //mark form as fully loaded
            isFormLoaded = true;


            
    }
        private void PopulateOrganizationComboBox()
        {
            // Assuming you have a method to get the list of organizations
            var organizations = databaseConnection.GetOrganizations();
            OrgName_combobox.DataSource = organizations;
            OrgName_combobox.DisplayMember = "NameofGroup";
            OrgName_combobox.ValueMember = "NameofGroup";
            OrgName_combobox.SelectedIndex = -1;
        }
        private void OrganizationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isFormLoaded)
            {

                ClearRoleComboBoxes();
                LoadCandidatesForSelectedOrganization();
            }
        }
        private void ClearRoleComboBoxes()
        {
            var comboBoxes = new List<System.Windows.Forms.ComboBox>
        {
            president_combobox, internalVP_combobox, external_combobox, secretary_combobox, treasurer_combobox,
            firstYearRep_combobox, secondYearRep_combobox, thirdYearRep_combobox
        };

            foreach (var comboBox in comboBoxes)
            {
                comboBox.SelectedIndex = -1;
            }
        }


        public void LoadCandidatesIntoComboBoxes(string SchoolOrgName)
        {
            // Assuming roles are defined and mapped to each ComboBox
            var roles = new List<string>
        {
        "President", "Internal Vice President", "External Vice President", "Secretary", "Treasurer",
        "1st year Representative", "2nd Year Representative", "3rd Year Representative"
            };
            var comboBoxes = new List<System.Windows.Forms.ComboBox>
            {
                president_combobox, internalVP_combobox, external_combobox, secretary_combobox, treasurer_combobox,
                 firstYearRep_combobox, secondYearRep_combobox, thirdYearRep_combobox
            };

            for (int i = 0; i < roles.Count; i++)
            {
                var candidatesTable = databaseConnection.GetCandidatesByRoleAndOrganization(roles[i], SchoolOrgName);
                comboBoxes[i].DataSource = candidatesTable;
                comboBoxes[i].DisplayMember = "FullName";
                comboBoxes[i].ValueMember = "StudentID";
            }
        }
        private void LoadCandidatesForSelectedOrganization()
        {
            string selectedOrganizationName = GetSelectedOrganizationName();
                if (!string.IsNullOrEmpty(selectedOrganizationName))
                {
                    LoadCandidatesIntoComboBoxes(selectedOrganizationName);
                }
        }
        private string GetSelectedOrganizationName() 
        {
            if (OrgName_combobox.SelectedItem != null)
            {
                return OrgName_combobox.SelectedValue.ToString();
            }
            else
            {
                return string.Empty;
            }
            
        }

        private void createpoll_bttn_Click(object sender, EventArgs e)
        {
            var roles = new List<string>
            {
            "President", "Internal Vice President", "External Vice President", "Secretary", "Treasurer",
            "1st Year Representative", "2nd Year Representative", "3rd Year Representative"
            };

            var comboBoxes = new List<System.Windows.Forms.ComboBox>
            {
            president_combobox, internalVP_combobox, external_combobox, secretary_combobox, treasurer_combobox,
                 firstYearRep_combobox, secondYearRep_combobox, thirdYearRep_combobox
            };

            for (int i = 0; i < roles.Count; i++)
            {
                if (comboBoxes[i].SelectedItem != null)
                {
                    DataRowView selectedRow = comboBoxes[i].SelectedItem as DataRowView;
                    int studentID = (int)selectedRow["StudentID"];
                    string fullName = selectedRow["FullName"].ToString();
                    string firstName = fullName.Split(' ')[0];
                    string lastName = fullName.Split(' ')[1];
                    string roleID = roles[i];
                    string organizationName = OrgName_combobox.SelectedValue.ToString();

                    databaseConnection.InsertVotePoll(studentID, organizationName, roleID, firstName, lastName);
                }

            }
            DialogResult result = MessageBox.Show("Poll created successfully!","Poll created success!", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                president_combobox.Text = "";
                internalVP_combobox.Text = "";
                external_combobox.Text = "";
                secretary_combobox.Text = "";
                treasurer_combobox.Text = "";
                firstYearRep_combobox.Text = "";
                secondYearRep_combobox.Text = "";
                thirdYearRep_combobox.Text = "";
            }

            if (OrgName_combobox.SelectedItem == null)
            {
                MessageBox.Show("Please select an organization");
            }

        }

        private void exit_picturebox_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit VoteSphere?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void logo_picturebox_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminMainMenuForm adminMainMenuForm = new AdminMainMenuForm();
            adminMainMenuForm.ShowDialog();
        }
    }
}
