using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoteSphere
{
    public partial class StudentMainMenuForm : Form
    {
        private DatabaseConnection databaseConnection;
        public StudentMainMenuForm()
        {
            InitializeComponent();
            string connectionString = "Data Source = DESKTOP-75I29S6\\SQLEXPRESS03; Initial Catalog = VoteSphere; Trust_Certificate = True";
            databaseConnection = new DatabaseConnection(connectionString);
        }


        

        private void vote_bttn_Click(object sender, EventArgs e)
        {
            this.Close();
            VoteForm voteform = new VoteForm();
            voteform.Show();
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

        private void logo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void result_bttn_Click(object sender, EventArgs e)
        {
            this.Close();
            VoteResult voteResult = new VoteResult();
            voteResult.Show();
        }
    }
}
