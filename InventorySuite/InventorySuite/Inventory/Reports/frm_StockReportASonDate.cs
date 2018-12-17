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
    public partial class frm_StockReportASonDate : Form
    {
        public frm_StockReportASonDate()
        {
            InitializeComponent();
            LoadProducts();
            LoadProductGroup();
        }



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

        private void btn_Save_Click(object sender, EventArgs e)
        {

            try {
                DateTime AsonDate = dtpAsonDate.Value.Date;
                int ProductID = Convert.ToInt32(cmbProductName.SelectedValue);
                int ProductGroupID = Convert.ToInt32(cmbProductGroup.SelectedValue);
                bool isCheckedProductName = CbPN.Checked;
                bool isCheckedProductGroup = cbPG.Checked;
                frm_StockReportView f = new frm_StockReportView(AsonDate, ProductID, ProductGroupID, isCheckedProductName, isCheckedProductGroup);
                f.MdiParent = frm_MainDashboard.frmObj;
                 this.WindowState = FormWindowState.Maximized;
                f.Show();
                this.Hide();
            }catch(Exception ex)
            {

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_StockReportASonDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                SendKeys.Send("{TAB}");
            }
        }

       
    }
}
