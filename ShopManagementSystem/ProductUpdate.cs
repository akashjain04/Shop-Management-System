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
    public partial class ProductUpdate : Form
    {

        /*
         * 
         * This class handles the updation of product data.
         * 
         */

        SqlConnection con;
        public ProductUpdate()
        {
            InitializeComponent();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (ProductName.Text == "" || productID.Text == "" || VendorID.Text == "" || Amount.Text == "")
            {
                MessageBox.Show("Please provide all the details", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Connect conObj = new Connect();
                con = conObj.connect();
                SqlCommand cmd = new SqlCommand("UPDATE PRODUCT SET pname = @pname,amount = @amount,vid = @vid WHERE pid = @id;", con);
                
                cmd.Parameters.AddWithValue("@id", productID.Text);
                cmd.Parameters.AddWithValue("@pname", ProductName.Text);
                cmd.Parameters.AddWithValue("@vid", VendorID.Text);
                cmd.Parameters.AddWithValue("@amount", Amount.Text);
                //cid += 1;
                int i = cmd.ExecuteNonQuery();
                //If count is equal to 1, than show frmMain form
                if (i != 0)
                {
                    MessageBox.Show("Product Updation Successful!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Product Updation Failed", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(con != null)
                {
                    con.Close();
                }
            }
            ProductName.Clear();
            productID.Clear();
            VendorID.Clear();
            Amount.Clear();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ProductName.Clear();
            productID.Clear();
            VendorID.Clear();
            Amount.Clear();
        }

        private void ProductUpdate_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
