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
    public partial class frmSrockLedgerReport : Form
    {
       Rports r = new Rports();
        public frmSrockLedgerReport()
        {
            InitializeComponent();
            LoadProducts();
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
            r.AsonDate = dtpAsonDate.Value.Date;
            r.ProductID = Convert.ToInt32(cmbProductName.SelectedValue);
            DateTime AsonDate = dtpAsonDate.Value.Date;
            int ProductID = Convert.ToInt32(cmbProductName.SelectedValue);
            bool isCheckedProductName = cbProductName.Checked;
            frm_StockLedgerReportView f = new frm_StockLedgerReportView(AsonDate, ProductID, isCheckedProductName);
            f.Show();
            this.Hide();

        }
    }
}
