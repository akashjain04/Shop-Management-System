namespace ShopManagementSystem
{
    partial class CustomerUpdate
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
            this.CustomerIdLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.customerID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.customerAddress = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.CustPhno = new System.Windows.Forms.TextBox();
            this.PhoneNoLabel = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.TextBox();
            this.CustNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerIdLabel
            // 
            this.CustomerIdLabel.AutoSize = true;
            this.CustomerIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIdLabel.Location = new System.Drawing.Point(12, 106);
            this.CustomerIdLabel.Name = "CustomerIdLabel";
            this.CustomerIdLabel.Size = new System.Drawing.Size(104, 20);
            this.CustomerIdLabel.TabIndex = 54;
            this.CustomerIdLabel.Text = "Customer ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(900, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "UPDATE CUSTOMERS";
            // 
            // customerID
            // 
            this.customerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerID.Location = new System.Drawing.Point(196, 106);
            this.customerID.Name = "customerID";
            this.customerID.Size = new System.Drawing.Size(277, 26);
            this.customerID.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2200, 53);
            this.panel1.TabIndex = 52;
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(271, 428);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(193, 38);
            this.updateButton.TabIndex = 51;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(15, 428);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(175, 38);
            this.clearButton.TabIndex = 50;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 49;
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(195, 370);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(277, 26);
            this.Email.TabIndex = 48;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(11, 370);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(51, 20);
            this.EmailLabel.TabIndex = 47;
            this.EmailLabel.Text = "Email";
            // 
            // customerAddress
            // 
            this.customerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAddress.Location = new System.Drawing.Point(195, 262);
            this.customerAddress.Multiline = true;
            this.customerAddress.Name = "customerAddress";
            this.customerAddress.Size = new System.Drawing.Size(277, 86);
            this.customerAddress.TabIndex = 46;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(11, 262);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(71, 20);
            this.addressLabel.TabIndex = 45;
            this.addressLabel.Text = "Address";
            // 
            // CustPhno
            // 
            this.CustPhno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustPhno.Location = new System.Drawing.Point(195, 214);
            this.CustPhno.Name = "CustPhno";
            this.CustPhno.Size = new System.Drawing.Size(277, 26);
            this.CustPhno.TabIndex = 44;
            // 
            // PhoneNoLabel
            // 
            this.PhoneNoLabel.AutoSize = true;
            this.PhoneNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNoLabel.Location = new System.Drawing.Point(11, 214);
            this.PhoneNoLabel.Name = "PhoneNoLabel";
            this.PhoneNoLabel.Size = new System.Drawing.Size(122, 20);
            this.PhoneNoLabel.TabIndex = 43;
            this.PhoneNoLabel.Text = " Phone number";
            // 
            // customerName
            // 
            this.customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerName.Location = new System.Drawing.Point(195, 160);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(277, 26);
            this.customerName.TabIndex = 2;
            // 
            // CustNameLabel
            // 
            this.CustNameLabel.AutoSize = true;
            this.CustNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustNameLabel.Location = new System.Drawing.Point(11, 160);
            this.CustNameLabel.Name = "CustNameLabel";
            this.CustNameLabel.Size = new System.Drawing.Size(131, 20);
            this.CustNameLabel.TabIndex = 41;
            this.CustNameLabel.Text = "Customer Name";
            // 
            // CustomerUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 753);
            this.Controls.Add(this.CustomerIdLabel);
            this.Controls.Add(this.customerID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.customerAddress);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.CustPhno);
            this.Controls.Add(this.PhoneNoLabel);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.CustNameLabel);
            this.Name = "CustomerUpdate";
            this.Text = "CustomerUpdate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerIdLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox customerID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox customerAddress;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox CustPhno;
        private System.Windows.Forms.Label PhoneNoLabel;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.Label CustNameLabel;
    }
}