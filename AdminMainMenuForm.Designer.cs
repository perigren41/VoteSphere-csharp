namespace VoteSphere
{
    partial class AdminMainMenuForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.admin_lbl = new System.Windows.Forms.Label();
            this.cp_bttn = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.createPoll_bttn = new System.Windows.Forms.Button();
            this.dp_bttn = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sp_bttn = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.seePoll_bttn = new System.Windows.Forms.Button();
            this.registerCandidate_bttn = new System.Windows.Forms.Button();
            this.upd_bttn = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Form
            // 
            this.Form.ElipseRadius = 20;
            this.Form.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::VoteSphere.Properties.Resources.Add_a_heading__3__removebg_preview__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.ErrorImage = global::VoteSphere.Properties.Resources.Add_a_heading__3__removebg_preview__1_;
            this.pictureBox1.Image = global::VoteSphere.Properties.Resources.Add_a_heading__3__removebg_preview__1_;
            this.pictureBox1.InitialImage = global::VoteSphere.Properties.Resources.Add_a_heading__3__removebg_preview__1_;
            this.pictureBox1.Location = new System.Drawing.Point(200, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::VoteSphere.Properties.Resources.OIP_removebg_preview;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::VoteSphere.Properties.Resources.OIP_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(475, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // admin_lbl
            // 
            this.admin_lbl.AutoSize = true;
            this.admin_lbl.BackColor = System.Drawing.Color.Transparent;
            this.admin_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_lbl.ForeColor = System.Drawing.Color.White;
            this.admin_lbl.Location = new System.Drawing.Point(12, 14);
            this.admin_lbl.Name = "admin_lbl";
            this.admin_lbl.Size = new System.Drawing.Size(52, 20);
            this.admin_lbl.TabIndex = 2;
            this.admin_lbl.Text = "admin";
            // 
            // cp_bttn
            // 
            this.cp_bttn.ElipseRadius = 20;
            this.cp_bttn.TargetControl = this.createPoll_bttn;
            // 
            // createPoll_bttn
            // 
            this.createPoll_bttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.createPoll_bttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createPoll_bttn.FlatAppearance.BorderSize = 0;
            this.createPoll_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPoll_bttn.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.createPoll_bttn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.createPoll_bttn.Location = new System.Drawing.Point(167, 269);
            this.createPoll_bttn.Name = "createPoll_bttn";
            this.createPoll_bttn.Size = new System.Drawing.Size(166, 46);
            this.createPoll_bttn.TabIndex = 7;
            this.createPoll_bttn.Text = "Create Poll";
            this.createPoll_bttn.UseVisualStyleBackColor = false;
            this.createPoll_bttn.Click += new System.EventHandler(this.createPoll_bttn_Click);
            // 
            // dp_bttn
            // 
            this.dp_bttn.ElipseRadius = 15;
            this.dp_bttn.TargetControl = this;
            // 
            // sp_bttn
            // 
            this.sp_bttn.ElipseRadius = 20;
            this.sp_bttn.TargetControl = this.seePoll_bttn;
            // 
            // seePoll_bttn
            // 
            this.seePoll_bttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.seePoll_bttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seePoll_bttn.FlatAppearance.BorderSize = 0;
            this.seePoll_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seePoll_bttn.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.seePoll_bttn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.seePoll_bttn.Location = new System.Drawing.Point(167, 333);
            this.seePoll_bttn.Name = "seePoll_bttn";
            this.seePoll_bttn.Size = new System.Drawing.Size(166, 46);
            this.seePoll_bttn.TabIndex = 7;
            this.seePoll_bttn.Text = "See Poll";
            this.seePoll_bttn.UseVisualStyleBackColor = false;
            this.seePoll_bttn.Click += new System.EventHandler(this.seePoll_bttn_Click);
            // 
            // registerCandidate_bttn
            // 
            this.registerCandidate_bttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.registerCandidate_bttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerCandidate_bttn.FlatAppearance.BorderSize = 0;
            this.registerCandidate_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerCandidate_bttn.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.registerCandidate_bttn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.registerCandidate_bttn.Location = new System.Drawing.Point(167, 205);
            this.registerCandidate_bttn.Name = "registerCandidate_bttn";
            this.registerCandidate_bttn.Size = new System.Drawing.Size(166, 46);
            this.registerCandidate_bttn.TabIndex = 7;
            this.registerCandidate_bttn.Text = "Register Candidate";
            this.registerCandidate_bttn.UseVisualStyleBackColor = false;
            this.registerCandidate_bttn.Click += new System.EventHandler(this.registerCandidate_bttn_Click);
            // 
            // upd_bttn
            // 
            this.upd_bttn.ElipseRadius = 20;
            this.upd_bttn.TargetControl = this.registerCandidate_bttn;
            // 
            // AdminMainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VoteSphere.Properties.Resources.Screenshot_2024_05_05_165121;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.registerCandidate_bttn);
            this.Controls.Add(this.seePoll_bttn);
            this.Controls.Add(this.createPoll_bttn);
            this.Controls.Add(this.admin_lbl);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMainMenuForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Form;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label admin_lbl;
        private Bunifu.Framework.UI.BunifuElipse cp_bttn;
        private Bunifu.Framework.UI.BunifuElipse dp_bttn;
        private Bunifu.Framework.UI.BunifuElipse sp_bttn;
        private System.Windows.Forms.Button registerCandidate_bttn;
        private System.Windows.Forms.Button seePoll_bttn;
        private System.Windows.Forms.Button createPoll_bttn;
        private Bunifu.Framework.UI.BunifuElipse upd_bttn;
    }
}