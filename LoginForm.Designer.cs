namespace VoteSphere
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Login = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBoxvoteSphereLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblforgotPassword = new System.Windows.Forms.Label();
            this.txtBoxuserName = new System.Windows.Forms.TextBox();
            this.submitbut = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bttnSubmt = new System.Windows.Forms.Button();
            this.txtBoxpassword = new System.Windows.Forms.TextBox();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bttnExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxvoteSphereLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.ElipseRadius = 20;
            this.Login.TargetControl = this;
            // 
            // pictureBoxvoteSphereLogo
            // 
            this.pictureBoxvoteSphereLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxvoteSphereLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxvoteSphereLogo.BackgroundImage")));
            this.pictureBoxvoteSphereLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxvoteSphereLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxvoteSphereLogo.Image")));
            this.pictureBoxvoteSphereLogo.Location = new System.Drawing.Point(200, 14);
            this.pictureBoxvoteSphereLogo.Name = "pictureBoxvoteSphereLogo";
            this.pictureBoxvoteSphereLogo.Size = new System.Drawing.Size(92, 128);
            this.pictureBoxvoteSphereLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxvoteSphereLogo.TabIndex = 0;
            this.pictureBoxvoteSphereLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "Welcome to VoteSphere";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sans Serif Collection", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(158, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Student Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Sans Serif Collection", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(158, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password";
            // 
            // lblforgotPassword
            // 
            this.lblforgotPassword.AutoSize = true;
            this.lblforgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblforgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblforgotPassword.Font = new System.Drawing.Font("Sans Serif Collection", 5.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblforgotPassword.ForeColor = System.Drawing.Color.White;
            this.lblforgotPassword.Location = new System.Drawing.Point(158, 316);
            this.lblforgotPassword.Name = "lblforgotPassword";
            this.lblforgotPassword.Size = new System.Drawing.Size(92, 17);
            this.lblforgotPassword.TabIndex = 8;
            this.lblforgotPassword.Text = "Register here";
            this.lblforgotPassword.Click += new System.EventHandler(this.lblforgotPassword_Click);
            // 
            // txtBoxuserName
            // 
            this.txtBoxuserName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBoxuserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxuserName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxuserName.Location = new System.Drawing.Point(158, 238);
            this.txtBoxuserName.Name = "txtBoxuserName";
            this.txtBoxuserName.Size = new System.Drawing.Size(185, 20);
            this.txtBoxuserName.TabIndex = 10;
            // 
            // submitbut
            // 
            this.submitbut.ElipseRadius = 10;
            this.submitbut.TargetControl = this.bttnSubmt;
            // 
            // bttnSubmt
            // 
            this.bttnSubmt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(65)))), ((int)(((byte)(94)))));
            this.bttnSubmt.Cursor = System.Windows.Forms.Cursors.Default;
            this.bttnSubmt.FlatAppearance.BorderSize = 0;
            this.bttnSubmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSubmt.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSubmt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bttnSubmt.Location = new System.Drawing.Point(200, 400);
            this.bttnSubmt.Name = "bttnSubmt";
            this.bttnSubmt.Size = new System.Drawing.Size(100, 25);
            this.bttnSubmt.TabIndex = 13;
            this.bttnSubmt.Text = "Submit";
            this.bttnSubmt.UseVisualStyleBackColor = false;
            this.bttnSubmt.Click += new System.EventHandler(this.bttnSubmt_Click);
            // 
            // txtBoxpassword
            // 
            this.txtBoxpassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBoxpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxpassword.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxpassword.Location = new System.Drawing.Point(158, 288);
            this.txtBoxpassword.Name = "txtBoxpassword";
            this.txtBoxpassword.PasswordChar = '*';
            this.txtBoxpassword.Size = new System.Drawing.Size(185, 20);
            this.txtBoxpassword.TabIndex = 11;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 15;
            this.bunifuElipse3.TargetControl = this.txtBoxuserName;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.txtBoxpassword;
            // 
            // bttnExit
            // 
            this.bttnExit.BackColor = System.Drawing.Color.Transparent;
            this.bttnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnExit.BackgroundImage")));
            this.bttnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnExit.Image = ((System.Drawing.Image)(resources.GetObject("bttnExit.Image")));
            this.bttnExit.Location = new System.Drawing.Point(475, 10);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(15, 15);
            this.bttnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bttnExit.TabIndex = 14;
            this.bttnExit.TabStop = false;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.bttnSubmt);
            this.Controls.Add(this.txtBoxpassword);
            this.Controls.Add(this.txtBoxuserName);
            this.Controls.Add(this.lblforgotPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxvoteSphereLogo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxvoteSphereLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Login;
        private System.Windows.Forms.PictureBox pictureBoxvoteSphereLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblforgotPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxuserName;
        private Bunifu.Framework.UI.BunifuElipse submitbut;
        private System.Windows.Forms.TextBox txtBoxpassword;
        private System.Windows.Forms.Button bttnSubmt;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox bttnExit;
    }
}

