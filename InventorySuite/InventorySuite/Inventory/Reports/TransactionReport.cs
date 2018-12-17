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
    public partial class TransactionReport : Form
    {
        public TransactionReport()
        {
            InitializeComponent();
         
        }
     public string TransactionType = frm_MainDashboard.Transactiontype;
       

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            DateTime fromdate = dtp_fromdate.Value.Date;
            DateTime todate = dtp_todate.Value.Date;
            frm_TransReportView f = new frm_TransReportView (fromdate, todate, TransactionType);
            f.ShowDialog();
            this.Hide();

        }

        private void TransactionReport_Load(object sender, EventArgs e)
        {

           this.Text = TransactionType+"Report";
        }
    }
}
