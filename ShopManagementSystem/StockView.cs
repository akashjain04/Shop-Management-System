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
    public partial class StockView : Form
    {
        /*
         * 
         * This class handles view operation on Stock data.
         * 
         * 
         */ 
        SqlConnection con;

        public StockView()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                Connect connectObj = new Connect();

                using (con = connectObj.connect())
                {

                    using (SqlCommand cmd = new SqlCommand("SELECT PNAME FROM PRODUCT WHERE PID = @pid"))
                    {
                        cmd.Parameters.AddWithValue("@pid", ProductID.Text);
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            Productname.Text = sdr["PNAME"].ToString();
                        }
                        
                    }
                    using (SqlCommand cmd = new SqlCommand("SELECT QUANTITY FROM STOCK WHERE PID = @pid"))
                    {
                        cmd.Parameters.AddWithValue("@pid", ProductID.Text);
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            Quantity.Text = sdr["QUANTITY"].ToString();
                        }
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stock not found", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            ProductID.Clear();
            Productname.Clear();
            Quantity.Clear();
        }

        private void StockView_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
