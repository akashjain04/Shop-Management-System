using DGVPrinterHelper;
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
    public partial class ReportStocks : Form
    {
        /*
         * 
         * This class will generate report on available stocks
         * 
         * 
         */
        SqlConnection con;

        public ReportStocks()
        {
            InitializeComponent();
        }

        private void ReportStocks_Load(object sender, EventArgs e)
        {
            try
            {
                var select = "SELECT * FROM CURRENTLY_AVAILABLE_STOCK;";
                Connect connectObj = new Connect();
                con = connectObj.connect();
                var dataAdapter = new SqlDataAdapter(select, con);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.ReadOnly = true;
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
            catch(Exception ex)
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
        }

        private void print_Click(object sender, EventArgs e)
        {
            DGVPrinterHelper.DGVPrinter printer = new DGVPrinter();
            printer.Title = "Available Stock Report";//Header
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Shop Management System";//Footer
            printer.FooterSpacing = 15;
            //Print landscape mode
            printer.printDocument.DefaultPageSettings.Landscape = false;
            printer.PrintDataGridView(dataGridView1);
        }

        private void ReportStocks_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
