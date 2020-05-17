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
    public partial class OrderInsert : Form
    {
        /*
         * 
         * This class handles the order creation process.
         * 
         * 
         */ 

        SqlConnection con;
        DataTable transactionDT = new DataTable();
        String cid = "";

        public OrderInsert()
        {
            InitializeComponent();
        }

        private void Cust_search_TextChanged(object sender, EventArgs e)
        {
            String keyword = Cust_search.Text;
            if (keyword == "")
            {
                Cust_search.Clear();
                CustName.Clear();
                PhoneNumber.Clear();
                Cust_address.Clear();
                custEmail.Clear();
                return;
            }

            Connect connectObj = new Connect();
            con = connectObj.connect();
            DataTable dt = new DataTable();
            

            try
            {
                String sql = "SELECT CNAME,ADDRESS,PHONE_NUMBER,EMAIL,C_ID FROM CUSTOMER WHERE C_ID LIKE '%" + keyword + "%' OR CNAME LIKE '%" + keyword + "%';";
                SqlDataAdapter adpt = new SqlDataAdapter(sql, con);

                adpt.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    CustName.Text = dt.Rows[0]["CNAME"].ToString();
                    PhoneNumber.Text = dt.Rows[0]["PHONE_NUMBER"].ToString();
                    Cust_address.Text = dt.Rows[0]["ADDRESS"].ToString();
                    custEmail.Text = dt.Rows[0]["EMAIL"].ToString();
                    cid = dt.Rows[0]["C_ID"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Product_search_TextChanged(object sender, EventArgs e)
        {
            String keyword = Product_search.Text;
            if (keyword == "")
            {

                return;
            }
            Connect connectObj = new Connect();
            con = connectObj.connect();

            DataTable dt = new DataTable();
            

            try
            {
                String sql = "SELECT PID,PNAME,AMOUNT FROM PRODUCT WHERE PID LIKE '%" + keyword + "%' OR PNAME LIKE '%" + keyword + "%';";
                SqlDataAdapter adpt = new SqlDataAdapter(sql, con);

                adpt.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    Product_Name.Text = dt.Rows[0]["PNAME"].ToString();
                    ProductID.Text = dt.Rows[0]["PID"].ToString();
                    Amount.Text = dt.Rows[0]["AMOUNT"].ToString();

                }

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
        }

        private void Add_Click(object sender, EventArgs e)
        {
            String PNAME = Product_Name.Text;
            String PID = ProductID.Text;
            if (Quantity.Text == "" || Product_Name.Text == "" || ProductID.Text == "")
            {
                MessageBox.Show("Enter the Quantity!!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Connect connectObj = new Connect();
                con = connectObj.connect();
                SqlCommand cmd = new SqlCommand("Select * from STOCK where PID =@pid and QUANTITY >= @quantity", con);
                
                cmd.Parameters.AddWithValue("@pid", ProductID.Text);
                cmd.Parameters.AddWithValue("@quantity", Quantity.Text);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count != 1)
                {
                    MessageBox.Show("Check stock!!!!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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
            decimal quantity = decimal.Parse(Quantity.Text);
            decimal amount = decimal.Parse(Amount.Text);
            decimal total = amount * quantity;
            decimal subtotal = decimal.Parse(SubTotal.Text);


            subtotal += total;

            if (PNAME == "")
            {
                MessageBox.Show("select a product and try again", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                transactionDT.Rows.Add(PNAME, PID, quantity, amount, total);
                AddedProducts.DataSource = transactionDT;
                SubTotal.Text = subtotal.ToString();

                if (ProductID.Text == "" || OrderID.Text == "")
                {
                    MessageBox.Show("Please provide all the details", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                Product_Name.Clear();
                ProductID.Clear();
                Quantity.Text = "0";
                Amount.Text = "0";

            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            //Create the orders 
            try
            {
                Connect connectObj = new Connect();
                con = connectObj.connect();
                SqlCommand cmd = new SqlCommand("Insert into MYORDER (ORD_ID,CID,DATE,AMOUNT) values(@oid,@cid,@date,@amount);", con);
                
                cmd.Parameters.AddWithValue("@oid", OrderID.Text);
                //cmd.Parameters.AddWithValue("@pid", textBox8.Text);
                cmd.Parameters.AddWithValue("@cid", cid);
                cmd.Parameters.AddWithValue("@date", date.Text);
                cmd.Parameters.AddWithValue("@amount", Total_Amt.Text);

                int i = cmd.ExecuteNonQuery();
                //If count is equal to 1, than show frmMain form
                if (i != 0)
                {
                    MessageBox.Show("Order Insertion Successful!", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Order Insertion Failed", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            //Insert into orderDetails 
            try
            {
                int j;

                Connect connectObj = new Connect();
                con = connectObj.connect();
                

                for (int i = 0; i < transactionDT.Rows.Count; i++)
                {

                    SqlCommand cmd = new SqlCommand("Insert into ORDER_DETAILS (ord_id,pid,quantity) values(@oid,@pid,@quantity);", con);

                    cmd.Parameters.AddWithValue("@oid", OrderID.Text);
                    cmd.Parameters.AddWithValue("@pid", transactionDT.Rows[i]["Product ID"].ToString());
                    cmd.Parameters.AddWithValue("@quantity", transactionDT.Rows[i]["Quantity"].ToString());


                    j = cmd.ExecuteNonQuery();
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
            //Update stock table after creating order
            try
            {
                int j;
                Connect connectObj = new Connect();
                con = connectObj.connect();
                
                for (int i = 0; i < transactionDT.Rows.Count; i++)
                {

                    SqlCommand cmd = new SqlCommand("UPDATE STOCK SET QUANTITY = QUANTITY - @quantity WHERE PID = @pid", con);

                    cmd.Parameters.AddWithValue("@pid", transactionDT.Rows[i]["Product ID"].ToString());
                    cmd.Parameters.AddWithValue("@quantity", transactionDT.Rows[i]["Quantity"].ToString());


                    j = cmd.ExecuteNonQuery();
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(con != null)
                {
                    con.Close();
                }
            }

            //Clear all the fields.
            Cust_search.Clear();
            CustName.Clear();
            PhoneNumber.Clear();
            Cust_address.Clear();
            custEmail.Clear();
            Product_search.Clear();
            Product_Name.Clear();
            ProductID.Clear();
            Total_Amt.Text = "0";
            SubTotal.Clear();
            Discount.Text = "0";
            GST.Clear();
            PaidAmount.Clear();
            ReturnAmount.Clear();
            Quantity.Text = "0";
            Amount.Text = "0";
            AddedProducts.DataSource = null;
        }

        private void OrderInsert_Load(object sender, EventArgs e)
        {
            transactionDT.Columns.Add("Product Name");
            transactionDT.Columns.Add("Product ID");
            transactionDT.Columns.Add("Quantity");
            transactionDT.Columns.Add("Amount");
            transactionDT.Columns.Add("Total");
        }

        private void Discount_TextChanged(object sender, EventArgs e)
        {
            if (SubTotal.Text == "")
            {
                return;
            }
            if (Discount.Text == "")
            {
                MessageBox.Show("Add value of Discount first", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                decimal discount = decimal.Parse(Discount.Text);
                decimal subtotal = decimal.Parse(SubTotal.Text);
                decimal grandTotal = ((100 - discount) / 100) * subtotal;
                Total_Amt.Text = grandTotal.ToString();
            }
        }

        private void GST_TextChanged(object sender, EventArgs e)
        {
            if (Total_Amt.Text == "")
            {
                MessageBox.Show("Calcuate Grand total after discount", "Captions", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Total_Amt.Text == "" || GST.Text == "")
                {
                    return;
                }
                decimal previousGT = decimal.Parse(Total_Amt.Text);
                decimal gst = decimal.Parse(GST.Text);
                decimal GTwithGst = ((100 + gst) / 100) * previousGT;
                Total_Amt.Text = GTwithGst.ToString();
            }
        }

        private void PaidAmount_TextChanged(object sender, EventArgs e)
        {
            if (PaidAmount.Text == "" || Total_Amt.Text == "")
            {
                return;
            }
            decimal paidamt = decimal.Parse(PaidAmount.Text);
            decimal gtamt = decimal.Parse(Total_Amt.Text);

            if (paidamt < gtamt)
            {
                //MessageBox.Show("Please check the total amount again");
                return;
            }
            decimal retamt = paidamt - gtamt;
            ReturnAmount.Text = retamt.ToString();
        }

        private void OrderInsert_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Cust_search.Clear();
            CustName.Clear();
            PhoneNumber.Clear();
            Cust_address.Clear();
            custEmail.Clear();
            Product_search.Clear();
            Product_Name.Clear();
            ProductID.Clear();
            Total_Amt.Text = "0";
            SubTotal.Clear();
            Discount.Text = "0";
            GST.Clear();
            PaidAmount.Clear();
            ReturnAmount.Clear();
            Quantity.Text = "0";
            Amount.Text = "0";
            AddedProducts.DataSource = null;
        }
    }
}
