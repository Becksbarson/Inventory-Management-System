namespace ShopRite
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.adminBtn = new System.Windows.Forms.Button();
            this.staffBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adminBtn
            // 
            this.adminBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.adminBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminBtn.Font = new System.Drawing.Font("Monotype Corsiva", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBtn.Location = new System.Drawing.Point(2, 356);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Padding = new System.Windows.Forms.Padding(10);
            this.adminBtn.Size = new System.Drawing.Size(241, 69);
            this.adminBtn.TabIndex = 1;
            this.adminBtn.Text = "Admin";
            this.adminBtn.UseVisualStyleBackColor = false;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // staffBtn
            // 
            this.staffBtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.staffBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.staffBtn.Font = new System.Drawing.Font("Monotype Corsiva", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffBtn.Location = new System.Drawing.Point(455, 350);
            this.staffBtn.Name = "staffBtn";
            this.staffBtn.Padding = new System.Windows.Forms.Padding(10);
            this.staffBtn.Size = new System.Drawing.Size(241, 75);
            this.staffBtn.TabIndex = 2;
            this.staffBtn.Text = "Staff";
            this.staffBtn.UseVisualStyleBackColor = false;
            this.staffBtn.Click += new System.EventHandler(this.staffBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCoral;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 53);
            this.label2.TabIndex = 4;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(42F, 82F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(709, 428);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.staffBtn);
            this.Controls.Add(this.adminBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(200, 100);
            this.Margin = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.MinimumSize = new System.Drawing.Size(400, 250);
            this.Name = "Home";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

 
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.Button staffBtn;
        private System.Windows.Forms.Label label2;
    }
}

