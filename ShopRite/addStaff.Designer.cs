namespace ShopRite
{
    partial class addStaff
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
            this.removeStaff = new System.Windows.Forms.Button();
            this.Adminpass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Adminuser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.TextBox();
            this.staffUsername = new System.Windows.Forms.Label();
            this.defaultpassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.usernamee = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // removeStaff
            // 
            this.removeStaff.BackColor = System.Drawing.Color.Transparent;
            this.removeStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeStaff.Location = new System.Drawing.Point(408, 674);
            this.removeStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeStaff.Name = "removeStaff";
            this.removeStaff.Size = new System.Drawing.Size(237, 90);
            this.removeStaff.TabIndex = 23;
            this.removeStaff.Text = "Add Staff";
            this.removeStaff.UseVisualStyleBackColor = false;
            this.removeStaff.Click += new System.EventHandler(this.removeStaff_Click);
            // 
            // Adminpass
            // 
            this.Adminpass.BackColor = System.Drawing.Color.MistyRose;
            this.Adminpass.Font = new System.Drawing.Font("Lucida Handwriting", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adminpass.Location = new System.Drawing.Point(12, 529);
            this.Adminpass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Adminpass.Name = "Adminpass";
            this.Adminpass.PasswordChar = '#';
            this.Adminpass.Size = new System.Drawing.Size(430, 85);
            this.Adminpass.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 53);
            this.label4.TabIndex = 21;
            this.label4.Text = "Admin Password:";
            // 
            // Adminuser
            // 
            this.Adminuser.BackColor = System.Drawing.Color.MistyRose;
            this.Adminuser.Font = new System.Drawing.Font("Lucida Handwriting", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adminuser.Location = new System.Drawing.Point(536, 313);
            this.Adminuser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Adminuser.Name = "Adminuser";
            this.Adminuser.Size = new System.Drawing.Size(430, 85);
            this.Adminuser.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(600, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 53);
            this.label3.TabIndex = 19;
            this.label3.Text = "Admin username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 53);
            this.label2.TabIndex = 17;
            this.label2.Text = "Username:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // firstname
            // 
            this.firstname.BackColor = System.Drawing.Color.MistyRose;
            this.firstname.Font = new System.Drawing.Font("Lucida Handwriting", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.Location = new System.Drawing.Point(536, 90);
            this.firstname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(430, 74);
            this.firstname.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 53);
            this.label1.TabIndex = 15;
            this.label1.Text = "Firstname:";
            // 
            // surname
            // 
            this.surname.BackColor = System.Drawing.Color.MistyRose;
            this.surname.Font = new System.Drawing.Font("Lucida Handwriting", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname.Location = new System.Drawing.Point(12, 90);
            this.surname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(430, 74);
            this.surname.TabIndex = 14;
            this.surname.TextChanged += new System.EventHandler(this.surname_TextChanged);
            // 
            // staffUsername
            // 
            this.staffUsername.AutoSize = true;
            this.staffUsername.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffUsername.Location = new System.Drawing.Point(641, 33);
            this.staffUsername.Name = "staffUsername";
            this.staffUsername.Size = new System.Drawing.Size(175, 53);
            this.staffUsername.TabIndex = 13;
            this.staffUsername.Text = "Surname:";
            // 
            // defaultpassword
            // 
            this.defaultpassword.BackColor = System.Drawing.Color.MistyRose;
            this.defaultpassword.Font = new System.Drawing.Font("Lucida Handwriting", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defaultpassword.Location = new System.Drawing.Point(536, 529);
            this.defaultpassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.defaultpassword.Name = "defaultpassword";
            this.defaultpassword.PasswordChar = '#';
            this.defaultpassword.Size = new System.Drawing.Size(430, 85);
            this.defaultpassword.TabIndex = 25;
            this.defaultpassword.TextChanged += new System.EventHandler(this.defaultpassword_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(571, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(334, 53);
            this.label5.TabIndex = 24;
            this.label5.Text = "Default Password:";
            // 
            // usernamee
            // 
            this.usernamee.BackColor = System.Drawing.Color.MistyRose;
            this.usernamee.Font = new System.Drawing.Font("Lucida Handwriting", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamee.Location = new System.Drawing.Point(12, 320);
            this.usernamee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usernamee.Name = "usernamee";
            this.usernamee.Size = new System.Drawing.Size(430, 74);
            this.usernamee.TabIndex = 26;
            // 
            // addStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1083, 850);
            this.Controls.Add(this.usernamee);
            this.Controls.Add(this.defaultpassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.removeStaff);
            this.Controls.Add(this.Adminpass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Adminuser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.staffUsername);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "addStaff";
            this.Text = "addStaff";
            this.Load += new System.EventHandler(this.addStaff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button removeStaff;
        private System.Windows.Forms.TextBox Adminpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Adminuser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Label staffUsername;
        private System.Windows.Forms.TextBox defaultpassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox usernamee;
    }
}