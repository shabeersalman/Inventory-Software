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
    public partial class ItemWiseReport : Form
    {


        public string TransactionType = frm_MainDashboard.Transactiontype;
       
        public ItemWiseReport()
        {
            InitializeComponent();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            DateTime fromdate = dtp_fromdate.Value.Date;
            DateTime todate = dtp_todate.Value.Date;
            frmItemWiseReportView f = new frmItemWiseReportView(fromdate, todate, TransactionType);
            f.Show();
            f.MdiParent = frm_MainDashboard.frmObj;
             this.WindowState = FormWindowState.Maximized;
            this.Hide();
        }

        private void ItemWiseReport_Load(object sender, EventArgs e)
        {
            this.Text = "Item Wise " + TransactionType + " Summary Report";
            lblhead.Text= "Item Wise " + TransactionType + " Summary Report";
        }

     
    }
}
