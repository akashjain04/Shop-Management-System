namespace ShopManagementSystem
{
    partial class CustomerView
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
            this.CustID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.PhoneNo = new System.Windows.Forms.TextBox();
            this.CustName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.Phnolbl = new System.Windows.Forms.Label();
            this.CustnameLbl = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.CustNameLabl1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustID
            // 
            this.CustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustID.Location = new System.Drawing.Point(198, 278);
            this.CustID.Name = "CustID";
            this.CustID.ReadOnly = true;
            this.CustID.Size = new System.Drawing.Size(418, 26);
            this.CustID.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 20);
            this.label11.TabIndex = 58;
            this.label11.Text = "Customer ID";
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(198, 497);
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Size = new System.Drawing.Size(418, 26);
            this.Email.TabIndex = 51;
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(197, 415);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Size = new System.Drawing.Size(418, 63);
            this.Address.TabIndex = 49;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLabel.Location = new System.Drawing.Point(13, 415);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(112, 20);
            this.AddressLabel.TabIndex = 48;
            this.AddressLabel.Text = "AddressLabel";
            // 
            // PhoneNo
            // 
            this.PhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNo.Location = new System.Drawing.Point(197, 367);
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.ReadOnly = true;
            this.PhoneNo.Size = new System.Drawing.Size(418, 26);
            this.PhoneNo.TabIndex = 47;
            // 
            // CustName
            // 
            this.CustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustName.Location = new System.Drawing.Point(198, 314);
            this.CustName.Name = "CustName";
            this.CustName.ReadOnly = true;
            this.CustName.Size = new System.Drawing.Size(418, 26);
            this.CustName.TabIndex = 45;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 53);
            this.panel1.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(900, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(291, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "VIEW CUSTOMER DETAILS";
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(284, 546);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(266, 49);
            this.Clear.TabIndex = 53;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(283, 29);
            this.label7.TabIndex = 52;
            this.label7.Text = "CUSTOMER DETAILS";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(14, 497);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(51, 20);
            this.EmailLabel.TabIndex = 50;
            this.EmailLabel.Text = "Email";
            // 
            // Phnolbl
            // 
            this.Phnolbl.AutoSize = true;
            this.Phnolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phnolbl.Location = new System.Drawing.Point(13, 367);
            this.Phnolbl.Name = "Phnolbl";
            this.Phnolbl.Size = new System.Drawing.Size(122, 20);
            this.Phnolbl.TabIndex = 46;
            this.Phnolbl.Text = " Phone number";
            // 
            // CustnameLbl
            // 
            this.CustnameLbl.AutoSize = true;
            this.CustnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustnameLbl.Location = new System.Drawing.Point(14, 314);
            this.CustnameLbl.Name = "CustnameLbl";
            this.CustnameLbl.Size = new System.Drawing.Size(131, 20);
            this.CustnameLbl.TabIndex = 44;
            this.CustnameLbl.Text = "Customer Name";
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(433, 143);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(133, 36);
            this.Search.TabIndex = 43;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // CustomerName
            // 
            this.CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerName.Location = new System.Drawing.Point(170, 150);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(230, 26);
            this.CustomerName.TabIndex = 42;
            // 
            // CustNameLabl1
            // 
            this.CustNameLabl1.AutoSize = true;
            this.CustNameLabl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustNameLabl1.Location = new System.Drawing.Point(23, 150);
            this.CustNameLabl1.Name = "CustNameLabl1";
            this.CustNameLabl1.Size = new System.Drawing.Size(131, 20);
            this.CustNameLabl1.TabIndex = 41;
            this.CustNameLabl1.Text = "Customer Name";
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 753);
            this.Controls.Add(this.CustID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.PhoneNo);
            this.Controls.Add(this.CustName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.Phnolbl);
            this.Controls.Add(this.CustnameLbl);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.CustNameLabl1);
            this.Name = "CustomerView";
            this.Text = "CustomerView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Deactivate += new System.EventHandler(this.CustomerView_Deactivate);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CustID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox PhoneNo;
        private System.Windows.Forms.TextBox CustName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label Phnolbl;
        private System.Windows.Forms.Label CustnameLbl;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.Label CustNameLabl1;
    }
}