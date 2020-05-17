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
    public partial class ProductDelete : Form
    {
        /*
         * 
         * This class handles deletion of products
         * 
         */ 

        SqlConnection con;

        public ProductDelete()
        {
            InitializeComponent();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Connect connectObj = new Connect();
                
                using (con = connectObj.connect())
                {


                    using (SqlCommand cmd = new SqlCommand("SELECT PID FROM PRODUCT WHERE PNAME = @pname;"))
                    {
                        cmd.Parameters.AddWithValue("@pname", ProductName.Text);
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            ProductID.Text = sdr["PID"].ToString();
                        }
                        con.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Product not found", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                Connect connectObj = new Connect();
                con = connectObj.connect();
                SqlCommand cmd = new SqlCommand("DELETE FROM PRODUCT WHERE PID = @pid", con);
                cmd.Parameters.AddWithValue("@pid", ProductID.Text);
                int i = cmd.ExecuteNonQuery();
                con.Close();
                //If count is equal to 1, than show frmMain form
                if (i != 0)
                {
                    MessageBox.Show("Product Deletion Successful!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Product Deletion Failed", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ProductName.Clear();
                ProductID.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Product Not found", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(con != null)
                {
                    con.Close();
                }
            }
        }

        private void ProductDelete_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
