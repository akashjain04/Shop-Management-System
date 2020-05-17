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
    public partial class MyLogin : Form
    {

        SqlConnection con;
        public MyLogin()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            /*
             * 
             * This method is called on click on login button
             * 
             */
            if (userName.Text == "" || this.password.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string username = userName.Text;
            string password = this.password.Text;

            try
            {
                Connect connectObj = new Connect();
                con = connectObj.connect();

                SqlCommand cmd = new SqlCommand("Select * from LOGIN where UserName=@username and Password=@password", con);

                cmd.Parameters.AddWithValue("@username", userName.Text);
                cmd.Parameters.AddWithValue("@password", this.password.Text);

                SqlDataAdapter adapt = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                adapt.Fill(ds);

                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form

                if (count == 1)
                {
                    MessageBox.Show("Login Successful!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormMenu menu = new FormMenu();
                    this.Hide();
                    menu.Show();
                    

                }
                else
                {
                    MessageBox.Show("Invalid UserName or Password", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            userName.Clear();
            password.Clear();
        }
    }
}
