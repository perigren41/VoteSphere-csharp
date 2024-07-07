namespace VoteSphere
{
    partial class updateForm
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
            this.save_bttn = new System.Windows.Forms.Button();
            this.firstName_txtbox = new System.Windows.Forms.TextBox();
            this.lastName_txtbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.role_combobox = new System.Windows.Forms.ComboBox();
            this.Role = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // save_bttn
            // 
            this.save_bttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.save_bttn.FlatAppearance.BorderSize = 0;
            this.save_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_bttn.ForeColor = System.Drawing.Color.White;
            this.save_bttn.Location = new System.Drawing.Point(99, 208);
            this.save_bttn.Name = "save_bttn";
            this.save_bttn.Size = new System.Drawing.Size(75, 23);
            this.save_bttn.TabIndex = 0;
            this.save_bttn.Text = "save";
            this.save_bttn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.save_bttn.UseVisualStyleBackColor = false;
            this.save_bttn.Click += new System.EventHandler(this.save_bttn_Click);
            // 
            // firstName_txtbox
            // 
            this.firstName_txtbox.Location = new System.Drawing.Point(73, 128);
            this.firstName_txtbox.Name = "firstName_txtbox";
            this.firstName_txtbox.Size = new System.Drawing.Size(122, 20);
            this.firstName_txtbox.TabIndex = 1;
            // 
            // lastName_txtbox
            // 
            this.lastName_txtbox.Location = new System.Drawing.Point(73, 169);
            this.lastName_txtbox.Name = "lastName_txtbox";
            this.lastName_txtbox.Size = new System.Drawing.Size(122, 20);
            this.lastName_txtbox.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::VoteSphere.Properties.Resources.Add_a_heading__3__removebg_preview__1_;
            this.pictureBox1.Location = new System.Drawing.Point(109, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // role_combobox
            // 
            this.role_combobox.FormattingEnabled = true;
            this.role_combobox.Items.AddRange(new object[] {
            "President",
            "Internal Vice President",
            "External Vice President",
            "Secretary",
            "Treasurer",
            "1st Year Representative",
            "2nd Year Representative",
            "3rd Year Representative"});
            this.role_combobox.Location = new System.Drawing.Point(73, 85);
            this.role_combobox.Name = "role_combobox";
            this.role_combobox.Size = new System.Drawing.Size(122, 21);
            this.role_combobox.TabIndex = 3;
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.BackColor = System.Drawing.Color.Transparent;
            this.Role.ForeColor = System.Drawing.Color.White;
            this.Role.Location = new System.Drawing.Point(73, 66);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(29, 13);
            this.Role.TabIndex = 4;
            this.Role.Text = "Role";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(70, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this.firstName_txtbox;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 15;
            this.bunifuElipse3.TargetControl = this.lastName_txtbox;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 15;
            this.bunifuElipse4.TargetControl = this.role_combobox;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 15;
            this.bunifuElipse5.TargetControl = this.save_bttn;
            // 
            // updateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VoteSphere.Properties.Resources.Screenshot_2024_05_05_165121;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.role_combobox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lastName_txtbox);
            this.Controls.Add(this.firstName_txtbox);
            this.Controls.Add(this.save_bttn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "updateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "updateForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_bttn;
        private System.Windows.Forms.TextBox firstName_txtbox;
        private System.Windows.Forms.TextBox lastName_txtbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox role_combobox;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
    }
}