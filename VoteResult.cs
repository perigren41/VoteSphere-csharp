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
    public partial class VoteResult : Form
    {
        private DatabaseConnection databaseConnection;
        public VoteResult()
        {
            InitializeComponent();

            this.Load += new EventHandler(VoteResult_Load);
            string connectionString = "Data Source = DESKTOP-75I29S6\\SQLEXPRESS03; Initial Catalog = VoteSphere;Integrated Security=True; TrustServerCertificate = True;";
            databaseConnection = new DatabaseConnection(connectionString);
        }

        private void VoteResult_Load(object sender, EventArgs e)
        {
            DisplayVoteCounts();
        }
        private void DisplayVoteCounts()
        {
            DataTable voteCountsTable = databaseConnection.GetVoteCounts();

            voteCountsDataGridView.DataSource = voteCountsTable;

            // Set column headers
            if (voteCountsDataGridView.Columns["RoleID"] != null)
                voteCountsDataGridView.Columns["RoleID"].HeaderText = "Role";
            if (voteCountsDataGridView.Columns["firstName"] != null)
                voteCountsDataGridView.Columns["firstName"].HeaderText = "First Name";
            if (voteCountsDataGridView.Columns["lastName"] != null)
                voteCountsDataGridView.Columns["lastName"].HeaderText = "Last Name";
            if (voteCountsDataGridView.Columns["TotalVotes"] != null)
                voteCountsDataGridView.Columns["TotalVotes"].HeaderText = "Total Votes";
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
}
