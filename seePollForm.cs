using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoteSphere
{
    public partial class seePollForm : Form
    {
        private DatabaseConnection databaseConnection;
        public seePollForm()
        {
            InitializeComponent();
            string connectionString = "Data Source=DESKTOP-75I29S6\\SQLEXPRESS03;Initial Catalog=VoteSphere;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            databaseConnection = new DatabaseConnection(connectionString);
            LoadPollTableData();
        }
        private void LoadPollTableData()
        {
            dataGridViewPollTable.AutoGenerateColumns = true; // Ensure columns are automatically generated
            DataTable pollTableData = databaseConnection.GetPollTableData();
            dataGridViewPollTable.DataSource = pollTableData;

            foreach (DataColumn column in pollTableData.Columns)
            {
                Console.WriteLine(column.ColumnName);
            }

            // Set the header text for each column after the data is bound
            if (dataGridViewPollTable.Columns["StudentID"] != null)
            {
                dataGridViewPollTable.Columns["StudentID"].HeaderText = "Student ID";
            }
            if (dataGridViewPollTable.Columns["OrganizationName"] != null)
            {
                dataGridViewPollTable.Columns["OrganizationName"].HeaderText = "Organization Name";
            }
            if (dataGridViewPollTable.Columns["FirstName"] != null)
            {
                dataGridViewPollTable.Columns["FirstName"].HeaderText = "First Name";
            }
            if (dataGridViewPollTable.Columns["LastName"] != null)
            {
                dataGridViewPollTable.Columns["LastName"].HeaderText = "Last Name";
            }
        }
        //exit on exitlogo
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
        //back-to-adminmenu on logo
        private void logo_picturebox_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMainMenuForm mainMenuForm = new AdminMainMenuForm();
            mainMenuForm.Show();
        }

        private void seePollForm_Load(object sender, EventArgs e)
        {
            LoadPollTableData();
        }


        //searchquery
        private void search_txtbox_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = search_txtbox.Text.Trim();
            DataTable pollTableData = (DataTable)dataGridViewPollTable.DataSource;
            DataView dv = pollTableData.DefaultView;
            if (dv != null)
            {
                if (!string.IsNullOrEmpty(searchQuery))
                {
                    dv.RowFilter = $"CONVERT (StudentID, 'System.String') LIKE '%{searchQuery}%' OR [OrganizationName] LIKE '%{searchQuery}%' OR [FirstName] LIKE '%{searchQuery}%' OR [LastName] LIKE '%{searchQuery}%'";

                }

                else
                {
                    dv.RowFilter = string.Empty;
                }
            }
        }
        //update
        private void update_button_Click(object sender, EventArgs e)
        {
            if (dataGridViewPollTable.SelectedRows.Count > 0)
            {


                DataGridViewRow selectedRow = dataGridViewPollTable.SelectedRows[0];
                string studentID = selectedRow.Cells["StudentID"].Value.ToString();
                string firstName = selectedRow.Cells["firstName"].Value.ToString();
                string lastName = selectedRow.Cells["lastName"].Value.ToString();
                string roleID = selectedRow.Cells["RoleID"].Value.ToString();

                updateForm updateform = new updateForm(roleID, firstName, lastName);
                updateform.ShowDialog();

                if (updateform.DialogResult == DialogResult.OK)
                {
                    string updatedFirstName = updateform.GetupdatedfirstName();
                    string updatedLastName = updateform.GetupdatedlastName();
                    string updatedRole = updateform.GetupdatedRole();

                    databaseConnection.UpdatePollTable(studentID, updatedRole, updatedFirstName, updatedLastName);
                    LoadPollTableData();
                }
            }
            else
            {
                MessageBox.Show("Select a row to update.");
            }
        }

        private void delete_bttn_Click(object sender, EventArgs e)
        {
            {
                if (dataGridViewPollTable.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridViewPollTable.SelectedRows[0];
                    string studentID = selectedRow.Cells["StudentID"].Value.ToString();
                    string firstName = selectedRow.Cells["firstName"].Value.ToString();
                    string lastName = selectedRow.Cells["lastName"].Value.ToString();
                    string roleID = selectedRow.Cells["RoleID"].Value.ToString();

                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this candidate?", "Delete Candidate", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        databaseConnection.DeleteCandidate(studentID, roleID, firstName, lastName);
                        LoadPollTableData();
                    }
                }
                else
                {
                    MessageBox.Show("Select a row to delete.");
                }
            }
        }
    }
}
