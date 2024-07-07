namespace VoteSphere
{
    partial class StudentMainMenuForm
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
            this.logo = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.vote_bttn = new System.Windows.Forms.Button();
            this.result_bttn = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.vote = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = global::VoteSphere.Properties.Resources.Add_a_heading__3__removebg_preview__1_;
            this.logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logo.Image = global::VoteSphere.Properties.Resources.Add_a_heading__3__removebg_preview__1_;
            this.logo.Location = new System.Drawing.Point(200, 14);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(92, 128);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::VoteSphere.Properties.Resources.OIP_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(475, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // vote_bttn
            // 
            this.vote_bttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.vote_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.vote_bttn.FlatAppearance.BorderSize = 0;
            this.vote_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vote_bttn.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.vote_bttn.ForeColor = System.Drawing.Color.White;
            this.vote_bttn.Location = new System.Drawing.Point(167, 205);
            this.vote_bttn.Name = "vote_bttn";
            this.vote_bttn.Size = new System.Drawing.Size(166, 46);
            this.vote_bttn.TabIndex = 2;
            this.vote_bttn.Text = "Vote";
            this.vote_bttn.UseVisualStyleBackColor = false;
            this.vote_bttn.Click += new System.EventHandler(this.vote_bttn_Click);
            // 
            // result_bttn
            // 
            this.result_bttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.result_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.result_bttn.FlatAppearance.BorderSize = 0;
            this.result_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.result_bttn.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F);
            this.result_bttn.ForeColor = System.Drawing.Color.White;
            this.result_bttn.Location = new System.Drawing.Point(167, 269);
            this.result_bttn.Name = "result_bttn";
            this.result_bttn.Size = new System.Drawing.Size(166, 46);
            this.result_bttn.TabIndex = 2;
            this.result_bttn.Text = "Result";
            this.result_bttn.UseVisualStyleBackColor = false;
            this.result_bttn.Click += new System.EventHandler(this.result_bttn_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // vote
            // 
            this.vote.ElipseRadius = 20;
            this.vote.TargetControl = this.vote_bttn;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 20;
            this.bunifuElipse3.TargetControl = this.result_bttn;
            // 
            // StudentMainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VoteSphere.Properties.Resources.Screenshot_2024_05_05_165121;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.result_bttn);
            this.Controls.Add(this.vote_bttn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentMainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentMainMenuForm";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button vote_bttn;
        private System.Windows.Forms.Button result_bttn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse vote;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
    }
}