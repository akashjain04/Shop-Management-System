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
    public partial class CustomerDelete : Form
    {
        /*
         * 
         * This class handles deletion of the customer details.
         * 
         * 
         */ 


        SqlConnection con;

        public CustomerDelete()
        {
            InitializeComponent();
        }


        private void Search_Click(object sender, EventArgs e)
        {
            try
            {
                Connect connectObj = new Connect();
                using (con = connectObj.connect())
                {


                    using (SqlCommand cmd = new SqlCommand("SELECT C_ID FROM CUSTOMER WHERE CNAME = @cname"))
                    {
                        cmd.Parameters.AddWithValue("@cname", CustomerName.Text);
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        

                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            CustomerID.Text = sdr["C_ID"].ToString();
                        }
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Customer not found", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(con != null)
                {
                    con.Close();
                }
            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                Connect connectObj = new Connect();
                con = connectObj.connect();

                SqlCommand cmd = new SqlCommand("DELETE FROM CUSTOMER WHERE C_ID = @cid", con);
                cmd.Parameters.AddWithValue("@cid", CustomerID.Text);
                int i = cmd.ExecuteNonQuery();
                
                //If count is equal to 1, than show frmMain form
                if (i != 0)
                {
                    MessageBox.Show("Customer Deletion Successful!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Customer Deletion Failed", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                CustomerName.Clear();
                CustomerID.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Customer Not found", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Close the connection to DB
                if(con != null)
                {
                    con.Close();
                }
            }
        }

        private void CustomerDelete_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
