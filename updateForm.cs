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

namespace VoteSphere
{
    public partial class updateForm : Form
    {
        public string updatedfirstName;
        public string updatedlastName;
        public string updatedRole;
        public updateForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(updateForm_Load);
        }
        private void updateForm_Load(object sender, EventArgs e)
        {
            PopulateRoleComboBox();
        }

        private void PopulateRoleComboBox()
        {
            // List of roles
            string[] roles = new string[]
            {
                "President",
                "Internal Vice President",
                "External Vice President",
                "Secretary",
                "Treasurer",
                "1st Year Representative",
                "2nd Year Representative",
                "3rd Year Representative"
            };// Add roles to ComboBox
            foreach (string role in roles)
            {
                role_combobox.Items.Add(role);
            }
        }

        public updateForm(string roleID, string firstName, string lastName)
        {
            InitializeComponent();

            role_combobox.Text = roleID;
            firstName_txtbox.Text = firstName;
            lastName_txtbox.Text = lastName;

        }
        public string GetupdatedfirstName()
        {
            return updatedfirstName;
        }

        public string GetupdatedlastName()
        {
            return updatedlastName;
        }
        public string GetupdatedRole()
        {
            return updatedRole;
        }

        private void save_bttn_Click(object sender, EventArgs e)
        {
            updatedfirstName = firstName_txtbox.Text;
            updatedlastName = lastName_txtbox.Text;
            updatedRole = role_combobox.Text;



            DialogResult result = MessageBox.Show("Saved successfully!", "Saved!", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            seePollForm seePollForm = new seePollForm();
            seePollForm.Show();
        }
    }
}
