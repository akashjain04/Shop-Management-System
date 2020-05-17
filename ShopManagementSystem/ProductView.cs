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
    public partial class ProductView : Form
    {
        /*
         * 
         * This class handles the view operations of Product details.
         * 
         * 
         */ 
        SqlConnection con;

        public ProductView()
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


                    using (SqlCommand cmd = new SqlCommand("SELECT PID,PNAME,AMOUNT,VID FROM PRODUCT WHERE PNAME = @pname"))
                    {
                        cmd.Parameters.AddWithValue("@pname", ProductName.Text);
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            ProdName.Text = sdr["PNAME"].ToString();

                            VendorID.Text = sdr["VID"].ToString();
                            Amount.Text = sdr["AMOUNT"].ToString();
                            ProductID.Text = sdr["PID"].ToString();
                        }
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Product not found!!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(con != null)
                {
                    con.Close();
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ProdName.Clear();
            Amount.Clear();
            VendorID.Clear();
            ProductName.Clear();
            ProductID.Clear();
        }

        private void ProductView_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
