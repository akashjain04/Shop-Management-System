using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementSystem
{
    public partial class FormMenu : Form
    {
        private int childFormNumber = 0;
        

        public FormMenu()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void iNSERTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerInsert custInsert = new CustomerInsert();
            custInsert.MdiParent = this;
            custInsert.Show();
            
        }

        private void vIEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerView custView = new CustomerView();
            custView.MdiParent = this;
            custView.Show();
            
        }

        private void uPDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerUpdate custUpdate = new CustomerUpdate();
            custUpdate.MdiParent = this;
            custUpdate.Show();
            
        }

        private void dELETEToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CustomerDelete custDelete = new CustomerDelete();
            custDelete.MdiParent = this;
            custDelete.Show();
       
        }

        private void FormMenu_MdiChildActivate(object sender, EventArgs e)
        {
            
        }

        private void iNSERTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductInsert prodInsert = new ProductInsert();
            prodInsert.MdiParent = this;
            prodInsert.Show();
        }

        private void vIEWToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductView prodView = new ProductView();
            prodView.MdiParent = this;
            prodView.Show();
        }

        private void uPDATEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductUpdate prodUpdate = new ProductUpdate();
            prodUpdate.MdiParent = this;
            prodUpdate.Show();
        }

        private void dELETEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ProductDelete prodDelete = new ProductDelete();
            prodDelete.MdiParent = this;
            prodDelete.Show();
        }

        private void iNSERTToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            VendorInsert vendorInsert = new VendorInsert();
            vendorInsert.MdiParent = this;
            vendorInsert.Show();
        }

        private void vIEWToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            VendorView vendorView = new VendorView();
            vendorView.MdiParent = this;
            vendorView.Show();
        }

        private void uPDATEToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            VendorUpdate vendorUpdate = new VendorUpdate();
            vendorUpdate.MdiParent = this;
            vendorUpdate.Show();
        }

        private void dELETEToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            VendorDelete vendorDelete = new VendorDelete();
            vendorDelete.MdiParent = this;
            vendorDelete.Show();
        }

        private void vIEWToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            StockView stockView = new StockView();
            stockView.MdiParent = this;
            stockView.Show();
        }

        private void uPDATEToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            StockUpdate stockUpdate = new StockUpdate();
            stockUpdate.MdiParent = this;
            stockUpdate.Show();
        }

        private void iNSERTToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            StockInsert stockInsert = new StockInsert();
            stockInsert.MdiParent = this;
            stockInsert.Show();
        }

        private void dELETEToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            StockDelete stockDelete = new StockDelete();
            stockDelete.MdiParent = this;
            stockDelete.Show();
        }

        private void vIEWToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OrderView orderView = new OrderView();
            orderView.MdiParent = this;
            orderView.Show();
        }

        private void cREATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderInsert orderCreate = new OrderInsert();
            orderCreate.MdiParent = this;
            orderCreate.Show();
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderDelete orderDelete = new OrderDelete();
            orderDelete.MdiParent = this;
            orderDelete.Show();
        }

        private void pRODUCTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportProduct reportProduct = new ReportProduct();
            reportProduct.MdiParent = this;
            reportProduct.Show();
        }

        private void oRDERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportOrder reportOrder = new ReportOrder();
            reportOrder.MdiParent = this;
            reportOrder.Show();
        }

        private void cUSTOMERSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReportCustomer reportCustomer = new ReportCustomer();
            reportCustomer.MdiParent = this;
            reportCustomer.Show();
        }

        private void vENDORSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReportVendors reportVendors = new ReportVendors();
            reportVendors.MdiParent = this;
            reportVendors.Show();
        }

        private void aVAILABLESTOCKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportStocks reportStocks = new ReportStocks();
            reportStocks.MdiParent = this;
            reportStocks.Show();
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dEVELOPERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Developers dev = new Developers();
            dev.MdiParent = this;
            dev.Show();
        }

        private void aPPLICATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyApplications applications = new MyApplications();
            applications.MdiParent = this;
            applications.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void dETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Details details = new Details();
            details.MdiParent = this;
            details.Show();
        }
    }
}
