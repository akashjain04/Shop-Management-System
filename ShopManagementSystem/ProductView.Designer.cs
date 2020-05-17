namespace ShopManagementSystem
{
    partial class ProductView
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
            this.Productidlbl = new System.Windows.Forms.Label();
            this.ProductID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.VendorID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.TextBox();
            this.Amtlbl = new System.Windows.Forms.Label();
            this.ProdName = new System.Windows.Forms.TextBox();
            this.ProductNamelbl = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.prodNamelbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Productidlbl
            // 
            this.Productidlbl.AutoSize = true;
            this.Productidlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Productidlbl.Location = new System.Drawing.Point(4, 224);
            this.Productidlbl.Name = "Productidlbl";
            this.Productidlbl.Size = new System.Drawing.Size(89, 20);
            this.Productidlbl.TabIndex = 55;
            this.Productidlbl.Text = "Product ID";
            // 
            // ProductID
            // 
            this.ProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductID.Location = new System.Drawing.Point(129, 224);
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Size = new System.Drawing.Size(243, 26);
            this.ProductID.TabIndex = 56;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2200, 53);
            this.panel1.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(900, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(275, 32);
            this.label6.TabIndex = 1;
            this.label6.Text = "VIEW PRODUCT DETAILS";
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(90, 440);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(230, 38);
            this.Clear.TabIndex = 51;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(294, 36);
            this.label7.TabIndex = 50;
            this.label7.Text = "PRODUCT DETAILS";
            // 
            // VendorID
            // 
            this.VendorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorID.Location = new System.Drawing.Point(129, 372);
            this.VendorID.Name = "VendorID";
            this.VendorID.ReadOnly = true;
            this.VendorID.Size = new System.Drawing.Size(243, 27);
            this.VendorID.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Vendor ID";
            // 
            // Amount
            // 
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Location = new System.Drawing.Point(129, 320);
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Size = new System.Drawing.Size(243, 27);
            this.Amount.TabIndex = 47;
            // 
            // Amtlbl
            // 
            this.Amtlbl.AutoSize = true;
            this.Amtlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amtlbl.Location = new System.Drawing.Point(5, 320);
            this.Amtlbl.Name = "Amtlbl";
            this.Amtlbl.Size = new System.Drawing.Size(66, 20);
            this.Amtlbl.TabIndex = 46;
            this.Amtlbl.Text = "Amount";
            // 
            // ProdName
            // 
            this.ProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdName.Location = new System.Drawing.Point(129, 269);
            this.ProdName.Name = "ProdName";
            this.ProdName.ReadOnly = true;
            this.ProdName.Size = new System.Drawing.Size(243, 27);
            this.ProdName.TabIndex = 45;
            // 
            // ProductNamelbl
            // 
            this.ProductNamelbl.AutoSize = true;
            this.ProductNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNamelbl.Location = new System.Drawing.Point(5, 269);
            this.ProductNamelbl.Name = "ProductNamelbl";
            this.ProductNamelbl.Size = new System.Drawing.Size(116, 20);
            this.ProductNamelbl.TabIndex = 44;
            this.ProductNamelbl.Text = "Product Name";
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(392, 100);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(83, 36);
            this.Search.TabIndex = 43;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // ProductName
            // 
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.Location = new System.Drawing.Point(160, 100);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(190, 27);
            this.ProductName.TabIndex = 42;
            // 
            // prodNamelbl
            // 
            this.prodNamelbl.AutoSize = true;
            this.prodNamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodNamelbl.Location = new System.Drawing.Point(13, 100);
            this.prodNamelbl.Name = "prodNamelbl";
            this.prodNamelbl.Size = new System.Drawing.Size(116, 20);
            this.prodNamelbl.TabIndex = 41;
            this.prodNamelbl.Text = "Product Name";
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 753);
            this.Controls.Add(this.Productidlbl);
            this.Controls.Add(this.ProductID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.VendorID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.Amtlbl);
            this.Controls.Add(this.ProdName);
            this.Controls.Add(this.ProductNamelbl);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.prodNamelbl);
            this.Name = "ProductView";
            this.Text = "ProductView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Deactivate += new System.EventHandler(this.ProductView_Deactivate);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Productidlbl;
        private System.Windows.Forms.TextBox ProductID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox VendorID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.Label Amtlbl;
        private System.Windows.Forms.TextBox ProdName;
        private System.Windows.Forms.Label ProductNamelbl;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.Label prodNamelbl;
        private System.Windows.Forms.Label label6;
    }
}