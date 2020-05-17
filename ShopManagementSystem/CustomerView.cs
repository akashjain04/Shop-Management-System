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
    public partial class CustomerView : Form
    {

        SqlConnection con;

        public CustomerView()
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


                    using (SqlCommand cmd = new SqlCommand("SELECT C_ID,CNAME,PHONE_NUMBER,ADDRESS,EMAIL FROM CUSTOMER WHERE CNAME = @cname"))
                    {
                        cmd.Parameters.AddWithValue("@cname", CustomerName.Text);
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;

                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            CustName.Text = sdr["CNAME"].ToString();
                            PhoneNo.Text = sdr["PHONE_NUMBER"].ToString();
                            Address.Text = sdr["ADDRESS"].ToString();
                            Email.Text = sdr["EMAIL"].ToString();
                            CustID.Text = sdr["C_ID"].ToString();
                        }

                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Customer Not found!!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Close the connection
                if(con != null)
                {
                    con.Close();
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            //Clear all the textboxes
            PhoneNo.Clear();
            Address.Clear();
            Email.Clear();
            CustName.Clear();
            CustomerName.Clear();
            CustID.Clear();
        }

        private void CustomerView_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
