namespace VoteSphere
{
    partial class CreatePollForm
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
            this.Form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.logo_picturebox = new System.Windows.Forms.PictureBox();
            this.exit_picturebox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.president_combobox = new System.Windows.Forms.ComboBox();
            this.internalVP_combobox = new System.Windows.Forms.ComboBox();
            this.external_combobox = new System.Windows.Forms.ComboBox();
            this.secretary_combobox = new System.Windows.Forms.ComboBox();
            this.treasurer_combobox = new System.Windows.Forms.ComboBox();
            this.firstYearRep_combobox = new System.Windows.Forms.ComboBox();
            this.secondYearRep_combobox = new System.Windows.Forms.ComboBox();
            this.thirdYearRep_combobox = new System.Windows.Forms.ComboBox();
            this.pres_elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ivp_elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.xvp_elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.secretary_elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.treasurer_elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.frstyrRep_elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.scndyrRep_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.thrdyrRep_elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.createpoll_bttn = new System.Windows.Forms.Button();
            this.poll_bttn = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.OrgName_combobox = new System.Windows.Forms.ComboBox();
            this.OrgName_elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.orgName_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // Form
            // 
            this.Form.ElipseRadius = 20;
            this.Form.TargetControl = this;
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
            this.exit_picturebox.BackgroundImage = global::VoteSphere.Properties.Resources.OIP_removebg_preview;
            this.exit_picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_picturebox.Image = global::VoteSphere.Properties.Resources.OIP_removebg_preview;
            this.exit_picturebox.Location = new System.Drawing.Point(475, 10);
            this.exit_picturebox.Name = "exit_picturebox";
            this.exit_picturebox.Size = new System.Drawing.Size(15, 15);
            this.exit_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit_picturebox.TabIndex = 0;
            this.exit_picturebox.TabStop = false;
            this.exit_picturebox.Click += new System.EventHandler(this.exit_picturebox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(157, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create Poll";
            // 
            // president_combobox
            // 
            this.president_combobox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.president_combobox.DropDownWidth = 145;
            this.president_combobox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.president_combobox.FormattingEnabled = true;
            this.president_combobox.Location = new System.Drawing.Point(49, 226);
            this.president_combobox.Name = "president_combobox";
            this.president_combobox.Size = new System.Drawing.Size(164, 21);
            this.president_combobox.TabIndex = 2;
            // 
            // internalVP_combobox
            // 
            this.internalVP_combobox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.internalVP_combobox.DropDownWidth = 145;
            this.internalVP_combobox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.internalVP_combobox.FormattingEnabled = true;
            this.internalVP_combobox.Location = new System.Drawing.Point(49, 275);
            this.internalVP_combobox.Name = "internalVP_combobox";
            this.internalVP_combobox.Size = new System.Drawing.Size(164, 21);
            this.internalVP_combobox.TabIndex = 2;
            // 
            // external_combobox
            // 
            this.external_combobox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.external_combobox.DropDownWidth = 145;
            this.external_combobox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.external_combobox.FormattingEnabled = true;
            this.external_combobox.Location = new System.Drawing.Point(49, 324);
            this.external_combobox.Name = "external_combobox";
            this.external_combobox.Size = new System.Drawing.Size(164, 21);
            this.external_combobox.TabIndex = 2;
            // 
            // secretary_combobox
            // 
            this.secretary_combobox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.secretary_combobox.DropDownWidth = 145;
            this.secretary_combobox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.secretary_combobox.FormattingEnabled = true;
            this.secretary_combobox.Location = new System.Drawing.Point(49, 373);
            this.secretary_combobox.Name = "secretary_combobox";
            this.secretary_combobox.Size = new System.Drawing.Size(164, 21);
            this.secretary_combobox.TabIndex = 2;
            // 
            // treasurer_combobox
            // 
            this.treasurer_combobox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.treasurer_combobox.DropDownWidth = 145;
            this.treasurer_combobox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.treasurer_combobox.FormattingEnabled = true;
            this.treasurer_combobox.Location = new System.Drawing.Point(261, 226);
            this.treasurer_combobox.Name = "treasurer_combobox";
            this.treasurer_combobox.Size = new System.Drawing.Size(164, 21);
            this.treasurer_combobox.TabIndex = 2;
            // 
            // firstYearRep_combobox
            // 
            this.firstYearRep_combobox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.firstYearRep_combobox.DropDownWidth = 145;
            this.firstYearRep_combobox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.firstYearRep_combobox.FormattingEnabled = true;
            this.firstYearRep_combobox.Location = new System.Drawing.Point(261, 275);
            this.firstYearRep_combobox.Name = "firstYearRep_combobox";
            this.firstYearRep_combobox.Size = new System.Drawing.Size(164, 21);
            this.firstYearRep_combobox.TabIndex = 2;
            // 
            // secondYearRep_combobox
            // 
            this.secondYearRep_combobox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.secondYearRep_combobox.DropDownWidth = 145;
            this.secondYearRep_combobox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.secondYearRep_combobox.FormattingEnabled = true;
            this.secondYearRep_combobox.Location = new System.Drawing.Point(261, 324);
            this.secondYearRep_combobox.Name = "secondYearRep_combobox";
            this.secondYearRep_combobox.Size = new System.Drawing.Size(164, 21);
            this.secondYearRep_combobox.TabIndex = 2;
            // 
            // thirdYearRep_combobox
            // 
            this.thirdYearRep_combobox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.thirdYearRep_combobox.DropDownWidth = 145;
            this.thirdYearRep_combobox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.thirdYearRep_combobox.FormattingEnabled = true;
            this.thirdYearRep_combobox.Location = new System.Drawing.Point(261, 373);
            this.thirdYearRep_combobox.Name = "thirdYearRep_combobox";
            this.thirdYearRep_combobox.Size = new System.Drawing.Size(164, 21);
            this.thirdYearRep_combobox.TabIndex = 2;
            // 
            // pres_elipse
            // 
            this.pres_elipse.ElipseRadius = 15;
            this.pres_elipse.TargetControl = this.president_combobox;
            // 
            // ivp_elipse
            // 
            this.ivp_elipse.ElipseRadius = 15;
            this.ivp_elipse.TargetControl = this.internalVP_combobox;
            // 
            // xvp_elipse
            // 
            this.xvp_elipse.ElipseRadius = 15;
            this.xvp_elipse.TargetControl = this.external_combobox;
            // 
            // secretary_elipse
            // 
            this.secretary_elipse.ElipseRadius = 15;
            this.secretary_elipse.TargetControl = this.secretary_combobox;
            // 
            // treasurer_elipse
            // 
            this.treasurer_elipse.ElipseRadius = 15;
            this.treasurer_elipse.TargetControl = this.treasurer_combobox;
            // 
            // frstyrRep_elipse
            // 
            this.frstyrRep_elipse.ElipseRadius = 15;
            this.frstyrRep_elipse.TargetControl = this.firstYearRep_combobox;
            // 
            // scndyrRep_Elipse
            // 
            this.scndyrRep_Elipse.ElipseRadius = 15;
            this.scndyrRep_Elipse.TargetControl = this.secondYearRep_combobox;
            // 
            // thrdyrRep_elipse
            // 
            this.thrdyrRep_elipse.ElipseRadius = 15;
            this.thrdyrRep_elipse.TargetControl = this.thirdYearRep_combobox;
            // 
            // createpoll_bttn
            // 
            this.createpoll_bttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.createpoll_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.createpoll_bttn.FlatAppearance.BorderSize = 0;
            this.createpoll_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createpoll_bttn.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createpoll_bttn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.createpoll_bttn.Location = new System.Drawing.Point(190, 419);
            this.createpoll_bttn.Name = "createpoll_bttn";
            this.createpoll_bttn.Size = new System.Drawing.Size(100, 25);
            this.createpoll_bttn.TabIndex = 3;
            this.createpoll_bttn.Text = "Create poll";
            this.createpoll_bttn.UseVisualStyleBackColor = false;
            this.createpoll_bttn.Click += new System.EventHandler(this.createpoll_bttn_Click);
            // 
            // poll_bttn
            // 
            this.poll_bttn.ElipseRadius = 10;
            this.poll_bttn.TargetControl = this.createpoll_bttn;
            // 
            // OrgName_combobox
            // 
            this.OrgName_combobox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.OrgName_combobox.DropDownWidth = 145;
            this.OrgName_combobox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OrgName_combobox.FormattingEnabled = true;
            this.OrgName_combobox.Location = new System.Drawing.Point(164, 184);
            this.OrgName_combobox.Name = "OrgName_combobox";
            this.OrgName_combobox.Size = new System.Drawing.Size(164, 21);
            this.OrgName_combobox.TabIndex = 4;
            // 
            // OrgName_elipse
            // 
            this.OrgName_elipse.ElipseRadius = 15;
            this.OrgName_elipse.TargetControl = this.OrgName_combobox;
            // 
            // orgName_lbl
            // 
            this.orgName_lbl.AutoSize = true;
            this.orgName_lbl.BackColor = System.Drawing.Color.Transparent;
            this.orgName_lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.orgName_lbl.Location = new System.Drawing.Point(192, 167);
            this.orgName_lbl.Name = "orgName_lbl";
            this.orgName_lbl.Size = new System.Drawing.Size(97, 13);
            this.orgName_lbl.TabIndex = 5;
            this.orgName_lbl.Text = "Organization Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(46, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Choose your President";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(46, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Choose your Internal Vice President";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(46, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Choose your External Vice President";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(46, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Choose your Secretary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(258, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Choose your Treasurer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(258, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Choose your 1st year Rep.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(258, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Choose your 2nd year Rep.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(258, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Choose your 3rd year Rep.";
            // 
            // CreatePollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VoteSphere.Properties.Resources.Screenshot_2024_05_05_165121;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.orgName_lbl);
            this.Controls.Add(this.OrgName_combobox);
            this.Controls.Add(this.createpoll_bttn);
            this.Controls.Add(this.thirdYearRep_combobox);
            this.Controls.Add(this.secondYearRep_combobox);
            this.Controls.Add(this.secretary_combobox);
            this.Controls.Add(this.firstYearRep_combobox);
            this.Controls.Add(this.external_combobox);
            this.Controls.Add(this.treasurer_combobox);
            this.Controls.Add(this.internalVP_combobox);
            this.Controls.Add(this.president_combobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit_picturebox);
            this.Controls.Add(this.logo_picturebox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreatePollForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreatePollForm";
            this.Load += new System.EventHandler(this.CreatePollForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Form;
        private System.Windows.Forms.PictureBox exit_picturebox;
        private System.Windows.Forms.PictureBox logo_picturebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox thirdYearRep_combobox;
        private System.Windows.Forms.ComboBox secondYearRep_combobox;
        private System.Windows.Forms.ComboBox secretary_combobox;
        private System.Windows.Forms.ComboBox firstYearRep_combobox;
        private System.Windows.Forms.ComboBox external_combobox;
        private System.Windows.Forms.ComboBox treasurer_combobox;
        private System.Windows.Forms.ComboBox internalVP_combobox;
        private System.Windows.Forms.ComboBox president_combobox;
        private System.Windows.Forms.Button createpoll_bttn;
        private Bunifu.Framework.UI.BunifuElipse pres_elipse;
        private Bunifu.Framework.UI.BunifuElipse ivp_elipse;
        private Bunifu.Framework.UI.BunifuElipse xvp_elipse;
        private Bunifu.Framework.UI.BunifuElipse secretary_elipse;
        private Bunifu.Framework.UI.BunifuElipse treasurer_elipse;
        private Bunifu.Framework.UI.BunifuElipse frstyrRep_elipse;
        private Bunifu.Framework.UI.BunifuElipse scndyrRep_Elipse;
        private Bunifu.Framework.UI.BunifuElipse thrdyrRep_elipse;
        private Bunifu.Framework.UI.BunifuElipse poll_bttn;
        private System.Windows.Forms.ComboBox OrgName_combobox;
        private Bunifu.Framework.UI.BunifuElipse OrgName_elipse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label orgName_lbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}