namespace ShopRite
{
    partial class StaffPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.barcodeText = new System.Windows.Forms.TextBox();
            this.quantityText = new System.Windows.Forms.TextBox();
            this.addtocart = new System.Windows.Forms.Button();
            this.preView = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.DataGridView();
            this.namee = new System.Windows.Forms.TextBox();
            this.Product = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.search)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome, ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LavenderBlush;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1040, 230);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LavenderBlush;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Barcode:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LavenderBlush;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Quantity:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // barcodeText
            // 
            this.barcodeText.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeText.Location = new System.Drawing.Point(75, 304);
            this.barcodeText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barcodeText.Name = "barcodeText";
            this.barcodeText.Size = new System.Drawing.Size(151, 38);
            this.barcodeText.TabIndex = 4;
            this.barcodeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.barcodeText.TextChanged += new System.EventHandler(this.barcodeText_TextChanged);
            // 
            // quantityText
            // 
            this.quantityText.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityText.Location = new System.Drawing.Point(75, 194);
            this.quantityText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.quantityText.Name = "quantityText";
            this.quantityText.Size = new System.Drawing.Size(151, 38);
            this.quantityText.TabIndex = 5;
            this.quantityText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantityText.TextChanged += new System.EventHandler(this.quantityText_TextChanged);
            // 
            // addtocart
            // 
            this.addtocart.BackColor = System.Drawing.Color.LavenderBlush;
            this.addtocart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addtocart.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtocart.Location = new System.Drawing.Point(56, 526);
            this.addtocart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addtocart.Name = "addtocart";
            this.addtocart.Size = new System.Drawing.Size(209, 70);
            this.addtocart.TabIndex = 6;
            this.addtocart.Text = "AddToCart";
            this.addtocart.UseVisualStyleBackColor = false;
            // 
            // preView
            // 
            this.preView.BackColor = System.Drawing.Color.LavenderBlush;
            this.preView.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preView.Location = new System.Drawing.Point(1019, 479);
            this.preView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.preView.Name = "preView";
            this.preView.Size = new System.Drawing.Size(209, 70);
            this.preView.TabIndex = 7;
            this.preView.Text = "PreView";
            this.preView.UseVisualStyleBackColor = false;
            this.preView.Click += new System.EventHandler(this.preView_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(737, 39);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(0, 65);
            this.name.TabIndex = 10;
            // 
            // search
            // 
            this.search.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.search.Location = new System.Drawing.Point(390, 183);
            this.search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.search.Name = "search";
            this.search.RowHeadersWidth = 51;
            this.search.RowTemplate.Height = 24;
            this.search.Size = new System.Drawing.Size(544, 425);
            this.search.TabIndex = 11;
            this.search.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.search_CellContentClick);
            // 
            // namee
            // 
            this.namee.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namee.Location = new System.Drawing.Point(75, 440);
            this.namee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.namee.Name = "namee";
            this.namee.Size = new System.Drawing.Size(151, 38);
            this.namee.TabIndex = 13;
            this.namee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Product
            // 
            this.Product.AutoSize = true;
            this.Product.BackColor = System.Drawing.Color.LavenderBlush;
            this.Product.Font = new System.Drawing.Font("Monotype Corsiva", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product.Location = new System.Drawing.Point(87, 376);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(89, 26);
            this.Product.TabIndex = 12;
            this.Product.Text = "Product:";
            this.Product.Click += new System.EventHandler(this.Product_Click);
            // 
            // StaffPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1772, 745);
            this.Controls.Add(this.namee);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.search);
            this.Controls.Add(this.name);
            this.Controls.Add(this.preView);
            this.Controls.Add(this.addtocart);
            this.Controls.Add(this.quantityText);
            this.Controls.Add(this.barcodeText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StaffPage";
            this.Text = "Home page ";
            this.Load += new System.EventHandler(this.StaffPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox barcodeText;
        private System.Windows.Forms.TextBox quantityText;
        private System.Windows.Forms.Button addtocart;
        private System.Windows.Forms.Button preView;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.DataGridView search;
        private System.Windows.Forms.TextBox namee;
        private System.Windows.Forms.Label Product;
    }
}