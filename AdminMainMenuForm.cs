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

namespace VoteSphere
{
    public partial class AdminMainMenuForm : Form
    {
        public AdminMainMenuForm()
        {
            InitializeComponent();
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

        private void createPoll_bttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreatePollForm createPollForm = new CreatePollForm();
            createPollForm.Show();
        }

        private void registerCandidate_bttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CandidateRegistration candidateRegistration = new CandidateRegistration();
            candidateRegistration.Show();
        }


        private void seePoll_bttn_Click(object sender, EventArgs e)
        {
            this.Hide();
            seePollForm seepoll = new seePollForm();
            seepoll.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
    }
}
