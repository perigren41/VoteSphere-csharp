using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VoteSphere
{
    public partial class CandidateRegistration : Form
    {
        private DatabaseConnection databaseConnection;
        public CandidateRegistration()
        {
            InitializeComponent();
            string connectionString = "Data Source=DESKTOP-75I29S6\\SQLEXPRESS03;Initial Catalog=VoteSphere;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            databaseConnection = new DatabaseConnection(connectionString);


            //combo box schoolYear options
            string[] yearArray = { "1st year", "2nd year", "3rd year", "4th year" };

            foreach (string year in yearArray)
            {
                year_combobox.Items.Add(year);
            }
            //combo box course options
            ArrayList programList = new ArrayList();
            programList.Add("B.S. Information Technology");
            programList.Add("B.S. Computer Science");
            programList.Add("B.S. Computer Engineering");
            programList.Add("B.S. Hospitality Management");
            programList.Add("B.S. Tourism");
            programList.Add("B.S. Business Administrator");
            foreach (string program in programList)
            {
                course_combobox.Items.Add(program);
            }


        }

       
        public string Gender;
        private void register_bttn_Click(object sender, EventArgs e)
        {

                int StudentID = Convert.ToInt32(studentNumber_txtbox.Text);
                string roleID = role_combobox.Text;
                string OrgName = organizationName_txtbox.Text;
                string firstName = firstName_txtbox.Text;
                string lastName = lastName_txtbox.Text;
                string year = year_combobox.Text;

                string courseID = course_combobox.Text;

                if (databaseConnection.CandidateValidation(StudentID))
                {
                    MessageBox.Show("Candidate is already registered in an organization.");
                    return;
                }

                databaseConnection.StudentRegistration(StudentID, courseID, firstName, lastName, Gender, year);

                databaseConnection.InsertSchoolOrganization(courseID, OrgName);

                databaseConnection.InsertCandidatesInfo(StudentID, roleID, OrgName, firstName, lastName, year, courseID);

                databaseConnection.InsertPollTable(StudentID, OrgName, roleID, firstName, lastName);

                
                
                DialogResult result = MessageBox.Show("Candidate Successfully Registered!", "Registered Successfully!", MessageBoxButtons.OK);
                if (result == DialogResult.OK) 
                {
                    studentNumber_txtbox.Text = "";
                    role_combobox.Text = "";
                    organizationName_txtbox.Text = "";
                    firstName_txtbox.Text = "";
                    lastName_txtbox.Text = "";
                    year_combobox.Text = "";
                    course_combobox.Text = "";
                }
        }


        private void male_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = male_radiobutton.Checked;
            if (isChecked)
            {
                Gender = male_radiobutton.Text;
            }
            else
            {
                Gender = female_radiobutton.Text;
            }
        }

        private void female_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = female_radiobutton.Checked;
            if (isChecked)
            {
                Gender = female_radiobutton.Text;
            }
            else
            {
                Gender = male_radiobutton.Text;
            }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminMainMenuForm mainMenuForm = new AdminMainMenuForm();
            mainMenuForm.Show();
        }
    }
}
