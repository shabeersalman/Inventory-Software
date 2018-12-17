using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventorySuite.Inventory.Reports
{
    public partial class frmTransRegisterReport : Form
    {
        public frmTransRegisterReport()
        {
            InitializeComponent();
            LoadProductGroup();
            LoadProducts();
        }
        public string TransactionType = frm_MainDashboard.Transactiontype;
        public void LoadProductGroup()
        {
            Masters.ProductGroup.ProductGroup pg = new Masters.ProductGroup.ProductGroup();
            DataSet ds = new DataSet();
            ds = pg.SelectUsers();
            cmbProductGroup.DataSource = ds.Tables[0];
            cmbProductGroup.DisplayMember = "GroupName";
            cmbProductGroup.ValueMember = "ProductGroupID";

        }
        public void LoadProducts()
        {
            Masters.Products.ProductView p = new Masters.Products.ProductView();
            DataSet ds = p.SelectProducts();
            cmbProductName.DataSource = ds.Tables[0];
            cmbProductName.DisplayMember = "ProductName";
            cmbProductName.ValueMember = "ProductID";
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {

            
                DateTime fromdate = dtp_fromdate.Value.Date;
                DateTime todate = dtp_todate.Value.Date;
                int ProductID = Convert.ToInt32(cmbProductName.SelectedValue);
                int ProductGroupID = Convert.ToInt32(cmbProductGroup.SelectedValue);
                bool isCheckedProductName = CbPN.Checked;
                bool isCheckedProductGroup = cbPG.Checked;
                TransRegisterReportView f = new  TransRegisterReportView (fromdate, todate, TransactionType, ProductID, ProductGroupID, isCheckedProductName, isCheckedProductGroup);
                f.ShowDialog(); 
                f.MdiParent = frm_MainDashboard.frmObj;
                this.WindowState = FormWindowState.Maximized;
             
                this.Hide();
            }

        private void frmTransRegisterReport_Load(object sender, EventArgs e)
        {
            switch(TransactionType)
            {

                case "Sales":
                    lblhead.Text ="Sales Register Report";
                    this.Text = "Sales Register Report";
                    break;
                case "SalesReturn":
                    lblhead.Text = "Sales Return Register Report";
                    this.Text = "Sales Return Register Report";
                    break;
                case "Purchase":
                    lblhead.Text = "Purchase Register Report";
                    this.Text = "Purchase Register Report";
                    break;
                case "PurchaseReturn":
                    lblhead.Text = "Purchase Return Register Report";
                    this.Text = "Purchase Return Register Report";
                    break;

            }
  

        }
    }
    }

