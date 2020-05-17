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
    public partial class ReportVendors : Form
    {
        /*
         * 
         * This class will generate report of vendors
         * 
         * 
         */

        SqlConnection con;
        public ReportVendors()
        {
            InitializeComponent();
        }

        private void print_Click(object sender, EventArgs e)
        {
            DGVPrinterHelper.DGVPrinter printer = new DGVPrinter();
            printer.Title = "Vendor Report";//Header
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date.ToString("MM/dd/yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Shop Management System";//Footer
            printer.FooterSpacing = 15;
            //Print landscape mode
            printer.printDocument.DefaultPageSettings.Landscape = true;
            printer.PrintDataGridView(dataGridView1);
        }

        private void ReportVendors_Load(object sender, EventArgs e)
        {
            try
            {
                var select = "SELECT * FROM VENDOR";
                Connect connectObj = new Connect();
                con = connectObj.connect();
                var dataAdapter = new SqlDataAdapter(select, con);

                var commandBuilder = new SqlCommandBuilder(dataAdapter);
                var ds = new DataSet();
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
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

        private void ReportVendors_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
