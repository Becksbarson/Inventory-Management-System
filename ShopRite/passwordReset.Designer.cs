namespace ShopRite
{
    partial class passwordReset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(passwordReset));
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userNamestaff = new System.Windows.Forms.TextBox();
            this.staffUsername = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.retype = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.staffBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.LavenderBlush;
            this.Password.Font = new System.Drawing.Font("Lucida Handwriting", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(12, 306);
            this.Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '#';
            this.Password.Size = new System.Drawing.Size(430, 85);
            this.Password.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 53);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password:";
            // 
            // userNamestaff
            // 
            this.userNamestaff.BackColor = System.Drawing.Color.LavenderBlush;
            this.userNamestaff.Font = new System.Drawing.Font("Lucida Handwriting", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNamestaff.Location = new System.Drawing.Point(12, 109);
            this.userNamestaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userNamestaff.Name = "userNamestaff";
            this.userNamestaff.Size = new System.Drawing.Size(430, 85);
            this.userNamestaff.TabIndex = 5;
            // 
            // staffUsername
            // 
            this.staffUsername.AutoSize = true;
            this.staffUsername.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffUsername.Location = new System.Drawing.Point(571, 52);
            this.staffUsername.Name = "staffUsername";
            this.staffUsername.Size = new System.Drawing.Size(198, 53);
            this.staffUsername.TabIndex = 4;
            this.staffUsername.Text = "Username:";
            // 
            // firstname
            // 
            this.firstname.BackColor = System.Drawing.Color.LavenderBlush;
            this.firstname.Font = new System.Drawing.Font("Lucida Handwriting", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.Location = new System.Drawing.Point(472, 109);
            this.firstname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(430, 85);
            this.firstname.TabIndex = 9;
            this.firstname.TextChanged += new System.EventHandler(this.firstname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 53);
            this.label2.TabIndex = 8;
            this.label2.Text = "Firstname:";
            // 
            // retype
            // 
            this.retype.BackColor = System.Drawing.Color.LavenderBlush;
            this.retype.Font = new System.Drawing.Font("Lucida Handwriting", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retype.Location = new System.Drawing.Point(472, 306);
            this.retype.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.retype.Name = "retype";
            this.retype.PasswordChar = '#';
            this.retype.Size = new System.Drawing.Size(430, 85);
            this.retype.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(552, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 53);
            this.label3.TabIndex = 10;
            this.label3.Text = "Re-Type Pass:";
            // 
            // staffBtn
            // 
            this.staffBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.staffBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staffBtn.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffBtn.Location = new System.Drawing.Point(23, 451);
            this.staffBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.staffBtn.Name = "staffBtn";
            this.staffBtn.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.staffBtn.Size = new System.Drawing.Size(178, 153);
            this.staffBtn.TabIndex = 12;
            this.staffBtn.Text = "Admin Reset";
            this.staffBtn.UseVisualStyleBackColor = false;
            this.staffBtn.Click += new System.EventHandler(this.staffBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LavenderBlush;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(653, 439);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.button1.Size = new System.Drawing.Size(202, 165);
            this.button1.TabIndex = 13;
            this.button1.Text = "Staff Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // passwordReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(900, 725);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.staffBtn);
            this.Controls.Add(this.retype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userNamestaff);
            this.Controls.Add(this.staffUsername);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "passwordReset";
            this.Text = "Password Reset ";
            this.Load += new System.EventHandler(this.passwordReset_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userNamestaff;
        private System.Windows.Forms.Label staffUsername;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox retype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button staffBtn;
        private System.Windows.Forms.Button button1;
    }
}