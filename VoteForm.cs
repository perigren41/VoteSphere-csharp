using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VoteSphere
{
    public partial class VoteForm : Form
    {
        public int VoterStudentID { get; set; }
        public string RoleID { get; set; }
        private DatabaseConnection databaseConnection;
        private bool isFormLoaded = false;
        private List<Vote> votes = new List<Vote>();
        public VoteForm()
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
        private string GetSelectedOrganizationID()
        {
            // Assuming OrgName_combobox.SelectedItem contains the DataRowView with SchoolOrgID
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

            int voterStudentID = GetCurrentVoterStudentID();
            string nameofGroup = OrgName_combobox.Text;  // Get the NameofGroup from the selected value
            DateTime voteTimeStamp = DateTime.Now;

            bool anyVoteCast = false;
            List<string> alreadyVotedRoles = new List<string>();

            for (int i = 0; i < roles.Count; i++)
            {
                if (comboBoxes[i].SelectedItem != null)
                {
                    DataRowView selectedRow = comboBoxes[i].SelectedItem as DataRowView;
                    int votedStudentID = (int)selectedRow["StudentID"];
                    string roleID = roles[i];

                    // Check if the voter has already voted for this role
                    if (!databaseConnection.HasVoted(voterStudentID, roleID))
                    {
                        // Insert vote into VotersTable
                        databaseConnection.InsertVotersTable(voterStudentID, nameofGroup, roleID, votedStudentID, voteTimeStamp);
                        anyVoteCast = true;
                    }
                    else
                    {
                        alreadyVotedRoles.Add(roleID);
                    }
                }
            }

            if (anyVoteCast)
            {
                MessageBox.Show("Voted Successfully!", "Vote Success!", MessageBoxButtons.OK);
            }
            else if (alreadyVotedRoles.Count > 0)
            {
                string rolesString = string.Join(", ", alreadyVotedRoles);
                MessageBox.Show($"You have already voted for the following roles: {rolesString}.", "Vote Error", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("No votes were cast.", "Vote Information", MessageBoxButtons.OK);
            }

            // Clear the combobox selections
            ClearRoleComboBoxes();
        }
    
        private int GetCurrentVoterStudentID()
        {
            return CurrentUserContext.StudentID;
        }
        
        private bool HasVoted(int voterStudentID, string roleID)
        {
            // Query the VotersTable to check if the student has already voted for the specified role
            // You would typically query your database here, but for demonstration purposes, 
            // let's assume you have a list of votes stored in a variable called votesList

            foreach (var vote in votes)
            {
                if (vote.VoterStudentID == voterStudentID && vote.RoleID == roleID)
                {
                    return true;
                }
            }

            return false; // The student has not voted for this role
        }

        private void MarkAsVoted(int voterStudentID, string roleID)
        {
            // Add the vote to the list
            votes.Add(new Vote { VoterStudentID = voterStudentID, RoleID = roleID });
        }
        public class Vote
        {
            public int VoterStudentID { get; set; }
            public string RoleID { get; set; }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentMainMenuForm studentMainMenuForm = new StudentMainMenuForm();
            studentMainMenuForm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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
    }
    public static class CurrentUserContext
    {
        public static int StudentID { get; set; }
    }
}
