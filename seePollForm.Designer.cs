namespace VoteSphere
{
    partial class seePollForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.logo_picturebox = new System.Windows.Forms.PictureBox();
            this.exit_picturebox = new System.Windows.Forms.PictureBox();
            this.dataGridViewPollTable = new System.Windows.Forms.DataGridView();
            this.update_button = new System.Windows.Forms.Button();
            this.search_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.search_elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.delete_bttn = new System.Windows.Forms.Button();
            this.del_bttn = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logo_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPollTable)).BeginInit();
            this.SuspendLayout();
            // 
            // logo_picturebox
            // 
            this.logo_picturebox.BackColor = System.Drawing.Color.Transparent;
            this.logo_picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logo_picturebox.Image = global::VoteSphere.Properties.Resources.Add_a_heading__3__removebg_preview__1_;
            this.logo_picturebox.Location = new System.Drawing.Point(200, 14);
            this.logo_picturebox.Name = "logo_picturebox";
            this.logo_picturebox.Size = new System.Drawing.Size(92, 128);
            this.logo_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_picturebox.TabIndex = 0;
            this.logo_picturebox.TabStop = false;
            this.logo_picturebox.Click += new System.EventHandler(this.logo_picturebox_Click);
            // 
            // exit_picturebox
            // 
            this.exit_picturebox.BackColor = System.Drawing.Color.Transparent;
            this.exit_picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_picturebox.Image = global::VoteSphere.Properties.Resources.OIP_removebg_preview;
            this.exit_picturebox.Location = new System.Drawing.Point(475, 10);
            this.exit_picturebox.Name = "exit_picturebox";
            this.exit_picturebox.Size = new System.Drawing.Size(15, 15);
            this.exit_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit_picturebox.TabIndex = 1;
            this.exit_picturebox.TabStop = false;
            this.exit_picturebox.Click += new System.EventHandler(this.exit_picturebox_Click);
            // 
            // dataGridViewPollTable
            // 
            this.dataGridViewPollTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPollTable.Location = new System.Drawing.Point(22, 223);
            this.dataGridViewPollTable.Name = "dataGridViewPollTable";
            this.dataGridViewPollTable.Size = new System.Drawing.Size(449, 208);
            this.dataGridViewPollTable.TabIndex = 2;
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.update_button.FlatAppearance.BorderSize = 0;
            this.update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_button.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.update_button.Location = new System.Drawing.Point(269, 442);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(105, 23);
            this.update_button.TabIndex = 3;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // search_txtbox
            // 
            this.search_txtbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.search_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search_txtbox.Location = new System.Drawing.Point(307, 197);
            this.search_txtbox.Name = "search_txtbox";
            this.search_txtbox.Size = new System.Drawing.Size(164, 20);
            this.search_txtbox.TabIndex = 4;
            this.search_txtbox.TextChanged += new System.EventHandler(this.search_txtbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(260, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search";
            // 
            // Form
            // 
            this.Form.ElipseRadius = 20;
            this.Form.TargetControl = this;
            // 
            // search_elipse
            // 
            this.search_elipse.ElipseRadius = 15;
            this.search_elipse.TargetControl = this.search_txtbox;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.update_button;
            // 
            // delete_bttn
            // 
            this.delete_bttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.delete_bttn.FlatAppearance.BorderSize = 0;
            this.delete_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_bttn.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_bttn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.delete_bttn.Location = new System.Drawing.Point(106, 442);
            this.delete_bttn.Name = "delete_bttn";
            this.delete_bttn.Size = new System.Drawing.Size(105, 23);
            this.delete_bttn.TabIndex = 6;
            this.delete_bttn.Text = "Delete";
            this.delete_bttn.UseVisualStyleBackColor = false;
            this.delete_bttn.Click += new System.EventHandler(this.delete_bttn_Click);
            // 
            // del_bttn
            // 
            this.del_bttn.ElipseRadius = 10;
            this.del_bttn.TargetControl = this.delete_bttn;
            // 
            // seePollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VoteSphere.Properties.Resources.Screenshot_2024_05_05_165121;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.delete_bttn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search_txtbox);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.dataGridViewPollTable);
            this.Controls.Add(this.exit_picturebox);
            this.Controls.Add(this.logo_picturebox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "seePollForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "seePollForm";
            this.Load += new System.EventHandler(this.seePollForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPollTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo_picturebox;
        private System.Windows.Forms.PictureBox exit_picturebox;
        private System.Windows.Forms.DataGridView dataGridViewPollTable;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.TextBox search_txtbox;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse Form;
        private Bunifu.Framework.UI.BunifuElipse search_elipse;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Button delete_bttn;
        private Bunifu.Framework.UI.BunifuElipse del_bttn;
    }
}