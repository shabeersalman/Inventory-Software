using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventorySuite
{
    public partial class frm_MainDashboard : Form
    {

        public static frm_MainDashboard frmObj;

        public frm_MainDashboard()
        {
            InitializeComponent();
            frmObj = this;
        }

        public static  string Transactiontype = "";
        private void mnu_users_Click(object sender, EventArgs e)
        {
            General.UsersView uv = new General.UsersView();
            uv.MdiParent = this;
            uv.Show();

        }

        private void mnu_products_Click(object sender, EventArgs e)
        {
            Inventory.Masters.frm_Products pds = new Inventory.Masters.frm_Products();
            pds.MdiParent = this;
            pds.Show();
        }

        private void mnu_ProductsGroup_Click(object sender, EventArgs e)
        {
            Inventory.Masters.ProductGroup.frm_ProductGroupView f = new Inventory.Masters.ProductGroup.frm_ProductGroupView();
            f.MdiParent = this;
            f.Show();

        }

        private void mnuSales_Click(object sender, EventArgs e)
        {
            Transactiontype = "Sales";
            Inventory.Transactions.frm_Transactions f = new Inventory.Transactions.frm_Transactions();
            f.MdiParent = this;
            f.Show();


        }

        private void mnuSaLeReturn_Click(object sender, EventArgs e)
        {

            Transactiontype = "SalesReturn";
            Inventory.Transactions.frm_Transactions f = new Inventory.Transactions.frm_Transactions();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuPurchase_Click(object sender, EventArgs e)
        {
            Transactiontype = "Purchase";
            Inventory.Transactions.frm_Transactions f = new Inventory.Transactions.frm_Transactions();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuPurchaseReturn_Click(object sender, EventArgs e)
        {
            Transactiontype = "PurchaseReturn";
            Inventory.Transactions.frm_Transactions f = new Inventory.Transactions.frm_Transactions();
            f.MdiParent = this;
            f.Show();
        }

        private void mnusalesreport_Click(object sender, EventArgs e)
        {
            Transactiontype = "Sales";
           Inventory.Reports.TransactionReport f = new Inventory.Reports.TransactionReport();
            f.MdiParent = this;
            f.Show();
        }

        private void mnusalesReturnreport_Click(object sender, EventArgs e)
        {
            Transactiontype = "SalesReturn";
            Inventory.Reports.TransactionReport f = new Inventory.Reports.TransactionReport();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuPurchaseReport_Click(object sender, EventArgs e)
        {
            Transactiontype = "Purchase";
            Inventory.Reports.TransactionReport f = new Inventory.Reports.TransactionReport();
            f.MdiParent = this;
            f.Show();
        }

        private void mnusPurchaseReturnreport_Click(object sender, EventArgs e)
        {
            Transactiontype = "PurchaseReturn";
            Inventory.Reports.TransactionReport f = new Inventory.Reports.TransactionReport();
            f.MdiParent = this;
            f.Show();
        }

        private void BtnStock_Click(object sender, EventArgs e)
        {
            Inventory.Reports.frm_StockReportASonDate f = new Inventory.Reports.frm_StockReportASonDate();
            f.MdiParent = this;
            f.Show();
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            Inventory.Masters.Products.frm_AddProduct f = new Inventory.Masters.Products.frm_AddProduct();
            f.MdiParent = frm_MainDashboard.frmObj;
            f.Show();
        }

        private void mnuCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
         
                
        }

        private void mnuTileVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuTileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuArrrangeIcons_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void mnuItemWiseSales_Click(object sender, EventArgs e)
        {
            Transactiontype = "Sales";
            Inventory.Reports.ItemWiseReport f = new Inventory.Reports.ItemWiseReport();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuItemWiseSalesReturn_Click(object sender, EventArgs e)
        {
            Transactiontype = "SalesReturn";
            Inventory.Reports.ItemWiseReport f = new Inventory.Reports.ItemWiseReport();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuItemWisePurchase_Click(object sender, EventArgs e)
        {
            Transactiontype = "Purchase";
            Inventory.Reports.ItemWiseReport f = new Inventory.Reports.ItemWiseReport();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuItemWisePurchaseReturn_Click(object sender, EventArgs e)
        {
            Transactiontype = "PurchaseReturn";
            Inventory.Reports.ItemWiseReport f = new Inventory.Reports.ItemWiseReport();
            f.MdiParent = this;
            f.Show();
        }

        private void stockLedgerReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory.Reports.frmSrockLedgerReport f = new Inventory.Reports.frmSrockLedgerReport();
            f.Show();
            f.MdiParent = this;
        }

        private void mnuSalesOrder_Click(object sender, EventArgs e)
        {
            Transactiontype = "SO";
            Inventory.Transactions.frm_Transactions f = new Inventory.Transactions.frm_Transactions();
            f.MdiParent = this;
            f.Show();

        }

        private void mnuSalesReturnOrder_Click(object sender, EventArgs e)
        {
            Transactiontype = "SRO";
            Inventory.Transactions.frm_Transactions f = new Inventory.Transactions.frm_Transactions();
            f.MdiParent = this;
            f.Show();

        }

        private void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transactiontype = "PO";
            Inventory.Transactions.frm_Transactions f = new Inventory.Transactions.frm_Transactions();
            f.MdiParent = this;
            f.Show();

        }

        private void purchaseReturnOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transactiontype = "PRO";
            Inventory.Transactions.frm_Transactions f = new Inventory.Transactions.frm_Transactions();
            f.MdiParent = this;
            f.Show();

        }

        private void mnuSalesOrderReport_Click(object sender, EventArgs e)
        {
            Transactiontype = "SO";
            Inventory.Reports.TransactionReport f = new Inventory.Reports.TransactionReport();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuSalesReturnOrderReport_Click(object sender, EventArgs e)
        {
            Transactiontype = "SRO";
            Inventory.Reports.TransactionReport f = new Inventory.Reports.TransactionReport();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuPurchaseOrderReport_Click(object sender, EventArgs e)
        {
            Transactiontype = "PO";
            Inventory.Reports.TransactionReport f = new Inventory.Reports.TransactionReport();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuPurchaseReturnOrderReport_Click(object sender, EventArgs e)
        {
            Transactiontype = "PRO";
            Inventory.Reports.TransactionReport f = new Inventory.Reports.TransactionReport();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuSOReport_Click(object sender, EventArgs e)
        {
            Transactiontype = "SO";
            Inventory.Reports.ItemWiseReport f = new Inventory.Reports.ItemWiseReport();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuSROReport_Click(object sender, EventArgs e)
        {
            Transactiontype = "SRO";
            Inventory.Reports.ItemWiseReport f = new Inventory.Reports.ItemWiseReport();
            f.MdiParent = this;
            f.Show();
        }

        private void purchaseOrderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Transactiontype = "PO";
            Inventory.Reports.ItemWiseReport f = new Inventory.Reports.ItemWiseReport();
            f.MdiParent = this;
            f.Show();
        }

        private void purchaseReturnOrderToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Transactiontype = "PRO";
            Inventory.Reports.ItemWiseReport f = new Inventory.Reports.ItemWiseReport();
            f.MdiParent = this;
            f.Show();
        }

     

        private void mnusalesRegister_Click(object sender, EventArgs e)
        {
            Transactiontype = "Sales";
            Inventory.Reports.frmTransRegisterReport f = new Inventory.Reports.frmTransRegisterReport();
            f.MdiParent = this;
            f.Show();
        }

        private void mnusalesReturnRegister_Click(object sender, EventArgs e)
        {
            Transactiontype = "SalesReturn";
            Inventory.Reports.frmTransRegisterReport f = new Inventory.Reports.frmTransRegisterReport();
            f.MdiParent = this;
            f.Show();
        }

     
        private void mnupurchaseRegister_Click(object sender, EventArgs e)
        {
            Transactiontype = "Purchase";
            Inventory.Reports.frmTransRegisterReport f = new Inventory.Reports.frmTransRegisterReport();
            f.MdiParent = this;
            f.Show();
        }

        private void mnupurchaseReturnRegister_Click(object sender, EventArgs e)
        {
            Transactiontype = "PurchaseReturn";
            Inventory.Reports.frmTransRegisterReport f = new Inventory.Reports.frmTransRegisterReport();
            f.MdiParent = this;
            f.Show();
        }
    }
}
