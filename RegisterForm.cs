using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace VoteSphere
{
    public partial class RegisterForm : Form
    {
        private DatabaseConnection databaseConnection;
        
        public RegisterForm()
        {
            InitializeComponent();
            string connectionString = "Data Source=DESKTOP-75I29S6\\SQLEXPRESS03;Initial Catalog=VoteSphere;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            databaseConnection = new DatabaseConnection(connectionString);


            string[] yearArray = { "1st year", "2nd year", "3rd year", "4th year" };

            foreach (string year in yearArray)
            {
                comboBox_year.Items.Add(year);
                }

            ArrayList programList = new ArrayList();
            programList.Add("B.S. Information Technology");
            programList.Add("B.S. Computer Science");
            programList.Add("B.S. Computer Engineering");
            programList.Add("B.S. Hospitality Management");
            programList.Add("B.S. Tourism");
            programList.Add("B.S. Business Administrator");
            foreach (string program in programList) 
            {
                comboBox_course.Items.Add(program);
            }
        }
        


            

        
        
        private void bttnExit_Click(object sender, EventArgs e)
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

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
        public string Gender;
        private void bttnRegister_Click(object sender, EventArgs e)
        {


            int StudentID = Convert.ToInt32(txtBoxstudentNumber.Text);
            string Password = txtBoxPassword.Text;
            string firstName = txtBoxfirstName.Text;
            string lastName = txtBoxlastName.Text;
            string courseID = comboBox_course.Text;
            string year = comboBox_year.Text;

            databaseConnection.StudentRegistration(StudentID, courseID, firstName, lastName, Gender, year);

            databaseConnection.InsertLoginTable(StudentID, Password);

            DialogResult Result = MessageBox.Show("Registered successfully! " + "" +
                            "\n          Welcome " + firstName + "!", "Registration Successful!",MessageBoxButtons.OK);

            if (Result == DialogResult.OK) 
            {
                this.Close();
                LoginForm mainForm = new LoginForm();
                mainForm.Show();
            }
        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = Male.Checked;
            if (isChecked) 
            {
                Gender = Male.Text;
            }
            else 
            { 
                Gender = Female.Text; 
            }
        }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = Female.Checked;
            if (isChecked)
            {
                Gender = Female.Text;
            }
            else
            {
                Gender = Male.Text;
            }
        }

        private void pictureBoxvoteSphereLogo_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
