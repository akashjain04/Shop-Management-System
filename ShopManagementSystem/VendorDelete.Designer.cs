namespace ShopManagementSystem
{
    partial class VendorDelete
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.VendorID = new System.Windows.Forms.TextBox();
            this.VendorIDlbl = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.VendorName = new System.Windows.Forms.TextBox();
            this.Vendornamelbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 53);
            this.panel1.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(900, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "DELETE VENDOR";
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Red;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(434, 138);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(133, 38);
            this.Delete.TabIndex = 44;
            this.Delete.Text = "DELETE";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // VendorID
            // 
            this.VendorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorID.Location = new System.Drawing.Point(164, 140);
            this.VendorID.Name = "VendorID";
            this.VendorID.Size = new System.Drawing.Size(200, 27);
            this.VendorID.TabIndex = 43;
            // 
            // VendorIDlbl
            // 
            this.VendorIDlbl.AutoSize = true;
            this.VendorIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorIDlbl.Location = new System.Drawing.Point(12, 140);
            this.VendorIDlbl.Name = "VendorIDlbl";
            this.VendorIDlbl.Size = new System.Drawing.Size(84, 20);
            this.VendorIDlbl.TabIndex = 42;
            this.VendorIDlbl.Text = "Vendor ID";
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(434, 85);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(133, 36);
            this.Search.TabIndex = 47;
            this.Search.Text = "SEARCH";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // VendorName
            // 
            this.VendorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorName.Location = new System.Drawing.Point(164, 90);
            this.VendorName.Name = "VendorName";
            this.VendorName.Size = new System.Drawing.Size(200, 26);
            this.VendorName.TabIndex = 40;
            // 
            // Vendornamelbl
            // 
            this.Vendornamelbl.AutoSize = true;
            this.Vendornamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vendornamelbl.Location = new System.Drawing.Point(17, 90);
            this.Vendornamelbl.Name = "Vendornamelbl";
            this.Vendornamelbl.Size = new System.Drawing.Size(111, 20);
            this.Vendornamelbl.TabIndex = 46;
            this.Vendornamelbl.Text = "Vendor Name";
            // 
            // VendorDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 753);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.VendorID);
            this.Controls.Add(this.VendorIDlbl);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.VendorName);
            this.Controls.Add(this.Vendornamelbl);
            this.Name = "VendorDelete";
            this.Text = "VendorDelete";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Deactivate += new System.EventHandler(this.VendorDelete_Deactivate);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox VendorID;
        private System.Windows.Forms.Label VendorIDlbl;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox VendorName;
        private System.Windows.Forms.Label Vendornamelbl;
    }
}