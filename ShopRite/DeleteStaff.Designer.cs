namespace ShopRite
{
    partial class DeleteStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteStaff));
            this.surname = new System.Windows.Forms.TextBox();
            this.staffUsername = new System.Windows.Forms.Label();
            this.firstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Adminuser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Adminpass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.removeStaff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // surname
            // 
            this.surname.BackColor = System.Drawing.Color.LavenderBlush;
            this.surname.Font = new System.Drawing.Font("Lucida Handwriting", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surname.Location = new System.Drawing.Point(26, 106);
            this.surname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(430, 74);
            this.surname.TabIndex = 3;
            // 
            // staffUsername
            // 
            this.staffUsername.AutoSize = true;
            this.staffUsername.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffUsername.Location = new System.Drawing.Point(820, 30);
            this.staffUsername.Name = "staffUsername";
            this.staffUsername.Size = new System.Drawing.Size(191, 57);
            this.staffUsername.TabIndex = 2;
            this.staffUsername.Text = "Surname:";
            this.staffUsername.Click += new System.EventHandler(this.staffUsername_Click);
            // 
            // firstname
            // 
            this.firstname.BackColor = System.Drawing.Color.LavenderBlush;
            this.firstname.Font = new System.Drawing.Font("Lucida Handwriting", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.Location = new System.Drawing.Point(688, 91);
            this.firstname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(430, 74);
            this.firstname.TabIndex = 5;
            this.firstname.TextChanged += new System.EventHandler(this.firstname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 57);
            this.label1.TabIndex = 4;
            this.label1.Text = "Firstname:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.LavenderBlush;
            this.username.Font = new System.Drawing.Font("Lucida Handwriting", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(12, 330);
            this.username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(430, 69);
            this.username.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 57);
            this.label2.TabIndex = 6;
            this.label2.Text = "Username:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Adminuser
            // 
            this.Adminuser.BackColor = System.Drawing.Color.LavenderBlush;
            this.Adminuser.Font = new System.Drawing.Font("Lucida Handwriting", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adminuser.Location = new System.Drawing.Point(653, 362);
            this.Adminuser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Adminuser.Name = "Adminuser";
            this.Adminuser.Size = new System.Drawing.Size(430, 85);
            this.Adminuser.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(736, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 57);
            this.label3.TabIndex = 8;
            this.label3.Text = "Admin username:";
            // 
            // Adminpass
            // 
            this.Adminpass.BackColor = System.Drawing.Color.LavenderBlush;
            this.Adminpass.Font = new System.Drawing.Font("Lucida Handwriting", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adminpass.Location = new System.Drawing.Point(12, 548);
            this.Adminpass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Adminpass.Name = "Adminpass";
            this.Adminpass.PasswordChar = '#';
            this.Adminpass.Size = new System.Drawing.Size(430, 85);
            this.Adminpass.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(341, 57);
            this.label4.TabIndex = 10;
            this.label4.Text = "Admin Password:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // removeStaff
            // 
            this.removeStaff.BackColor = System.Drawing.Color.HotPink;
            this.removeStaff.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeStaff.Location = new System.Drawing.Point(843, 548);
            this.removeStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeStaff.Name = "removeStaff";
            this.removeStaff.Size = new System.Drawing.Size(275, 90);
            this.removeStaff.TabIndex = 12;
            this.removeStaff.Text = "RemoveStaff";
            this.removeStaff.UseVisualStyleBackColor = false;
            this.removeStaff.Click += new System.EventHandler(this.removeStaff_Click);
            // 
            // DeleteStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1130, 751);
            this.Controls.Add(this.removeStaff);
            this.Controls.Add(this.Adminpass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Adminuser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.staffUsername);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DeleteStaff";
            this.Text = "DeleteStaff";
            this.Load += new System.EventHandler(this.DeleteStaff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Label staffUsername;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Adminuser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Adminpass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button removeStaff;
    }
}