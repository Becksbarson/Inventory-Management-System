namespace ShopRite
{
    partial class staffLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staffLogin));
            this.staffUsername = new System.Windows.Forms.Label();
            this.userNamestaff = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logInbtn = new System.Windows.Forms.Button();
            this.resetPassword = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // staffUsername
            // 
            this.staffUsername.AutoSize = true;
            this.staffUsername.BackColor = System.Drawing.Color.LavenderBlush;
            this.staffUsername.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffUsername.Location = new System.Drawing.Point(16, 425);
            this.staffUsername.Name = "staffUsername";
            this.staffUsername.Size = new System.Drawing.Size(198, 53);
            this.staffUsername.TabIndex = 0;
            this.staffUsername.Text = "Username:";
            this.staffUsername.Click += new System.EventHandler(this.staffUsername_Click);
            // 
            // userNamestaff
            // 
            this.userNamestaff.BackColor = System.Drawing.Color.White;
            this.userNamestaff.Font = new System.Drawing.Font("Lucida Handwriting", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNamestaff.Location = new System.Drawing.Point(616, 425);
            this.userNamestaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userNamestaff.Multiline = true;
            this.userNamestaff.Name = "userNamestaff";
            this.userNamestaff.Size = new System.Drawing.Size(260, 50);
            this.userNamestaff.TabIndex = 1;
            this.userNamestaff.TextChanged += new System.EventHandler(this.userNamestaff_TextChanged);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.White;
            this.Password.Font = new System.Drawing.Font("Lucida Handwriting", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.SystemColors.Menu;
            this.Password.Location = new System.Drawing.Point(616, 504);
            this.Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '#';
            this.Password.Size = new System.Drawing.Size(273, 42);
            this.Password.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LavenderBlush;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // logInbtn
            // 
            this.logInbtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.logInbtn.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInbtn.Location = new System.Drawing.Point(319, 551);
            this.logInbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logInbtn.Name = "logInbtn";
            this.logInbtn.Size = new System.Drawing.Size(199, 54);
            this.logInbtn.TabIndex = 4;
            this.logInbtn.Text = "Log In";
            this.logInbtn.UseVisualStyleBackColor = false;
            this.logInbtn.Click += new System.EventHandler(this.logInbtn_Click);
            // 
            // resetPassword
            // 
            this.resetPassword.AutoSize = true;
            this.resetPassword.BackColor = System.Drawing.Color.MistyRose;
            this.resetPassword.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPassword.LinkColor = System.Drawing.Color.Black;
            this.resetPassword.Location = new System.Drawing.Point(20, 572);
            this.resetPassword.Name = "resetPassword";
            this.resetPassword.Size = new System.Drawing.Size(185, 28);
            this.resetPassword.TabIndex = 5;
            this.resetPassword.TabStop = true;
            this.resetPassword.Text = "Forgot Password?";
            this.resetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.resetPassword_LinkClicked);
            // 
            // staffLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 618);
            this.Controls.Add(this.resetPassword);
            this.Controls.Add(this.logInbtn);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userNamestaff);
            this.Controls.Add(this.staffUsername);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "staffLogin";
            this.Text = "staffLogin";
            this.Load += new System.EventHandler(this.staffLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label staffUsername;
        private System.Windows.Forms.TextBox userNamestaff;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logInbtn;
        private System.Windows.Forms.LinkLabel resetPassword;
    }
}