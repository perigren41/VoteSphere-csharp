using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics.Eventing.Reader;
namespace VoteSphere
{
    public partial class LoginForm : Form
    {
        private DatabaseConnection databaseConnection;
        public LoginForm()
        {
            InitializeComponent();
            string connectionString = "Data Source=DESKTOP-75I29S6\\SQLEXPRESS03;Initial Catalog=VoteSphere;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            databaseConnection = new DatabaseConnection(connectionString);
        }

        private void lblforgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();

        }


        private void bttnSubmt_Click(object sender, EventArgs e)
        {
            //blank validation
            if (String.IsNullOrEmpty(txtBoxuserName.Text))
            {
                MessageBox.Show("       Username cannot be blank" +
                                "\n                 please try again", "Message Error", MessageBoxButtons.OK);

            }
            else if (String.IsNullOrEmpty(txtBoxpassword.Text))
            {
                MessageBox.Show("       Password cannot be blank " +
                                "\n                 please try again", "Message Error", MessageBoxButtons.OK);
            }

            //db validation
            int userID;
            int? StudentID = null;
            int? ProfID = null;
            bool isProf = false;
            string Password = txtBoxpassword.Text;

            if (!string.IsNullOrEmpty(txtBoxuserName.Text) && int.TryParse(txtBoxuserName.Text, out userID))
            {
                if (databaseConnection.ValidationLogin(userID,out StudentID, out ProfID, Password, out isProf))
                {
                    MessageBox.Show("Login Successful!");
                    if (StudentID.HasValue)
                    {
                        CurrentUserContext.StudentID = userID;
                    }

                    if (isProf)
                    {
                        AdminMainMenuForm adminMainMenuForm = new AdminMainMenuForm();
                        this.Hide();
                        adminMainMenuForm.Show();
                    }
                    else
                    {
                        StudentMainMenuForm studentMainMenuForm = new StudentMainMenuForm();
                        this.Hide();
                        studentMainMenuForm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid ID or Password. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid ID.");
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
    }

}
