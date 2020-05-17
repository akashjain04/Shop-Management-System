using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementSystem
{
    public partial class VendorInsert : Form
    {
        /*
         * 
         * This class handles Vednor details insertion.
         * 
         */ 

        SqlConnection con;

        public VendorInsert()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (VendorName.Text == "" || VendorAddress.Text == "" || PhoneNO.Text == "" || Email.Text == "" || VendorID.Text == "")
            {
                MessageBox.Show("Please provide all the details", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (PhoneNO.Text.Length != 10)
            {
                MessageBox.Show("Enter valid Phone number", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Connect connectObj = new Connect();
                con = connectObj.connect();

                SqlCommand cmd = new SqlCommand("Insert into VENDOR (vid,vname,address,phone_number,email) values(@id,@vname,@address,@phno,@email);", con);
                
                cmd.Parameters.AddWithValue("@id", VendorID.Text);
                cmd.Parameters.AddWithValue("@vname", VendorName.Text);
                cmd.Parameters.AddWithValue("@phno", Convert.ToInt64(PhoneNO.Text));
                cmd.Parameters.AddWithValue("@address", VendorAddress.Text);
                cmd.Parameters.AddWithValue("@email", Email.Text);

                int i = cmd.ExecuteNonQuery();
                //If count is equal to 1, than show frmMain form
                if (i != 0)
                {
                    MessageBox.Show("Vendor Insertion Successful!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Vendor Insertion Failed", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();

                //Clear all the fields.
                VendorName.Clear();
                VendorAddress.Clear();
                PhoneNO.Clear();
                Email.Clear();
                VendorID.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed!! Try with Different ID!!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(con != null)
                {
                    con.Close();
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            VendorName.Clear();
            VendorAddress.Clear();
            PhoneNO.Clear();
            Email.Clear();
            VendorID.Clear();
        }

        private void VendorInsert_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
