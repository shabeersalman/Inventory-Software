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
    public partial class TransRegisterReportView : Form
    {



        DateTime fdate, tdate;
        string type;
        int prodID, prodGroupID;
        bool isprodTrue, isprodGruopTrue;
        Rports r = new Rports();

        private void TransRegisterReportView_Load(object sender, EventArgs e)
        {
            string lbltodate = fdate.ToString("dd-MMM-yyyy");
            string lblfromdate = tdate.ToString("dd-MMM-yyyy");
            switch (type)
            {

                case "Sales":
                    lblhead.Text = "Sales Register Report from " + lblfromdate + " to" + lbltodate;
                    this.Text = "Sales Register Report";
                    break;
                case "SalesReturn":
                    lblhead.Text = "Sales Return Register Report " + lblfromdate + " to" + lbltodate;
                    this.Text = "Sales Return Register Report";
                    break;
                case "Purchase":
                    lblhead.Text = "Purchase Register Report " + lblfromdate + " to" + lbltodate;
                    this.Text = "Purchase Register Report";
                    break;
                case "PurchaseReturn":
                    lblhead.Text = "Purchase Return Register Report " + lblfromdate + " to" + lbltodate;
                    this.Text = "Purchase Return Register Report";
                    break;

            }
        
        }

        Export Exp = new Export();

        public TransRegisterReportView(DateTime fromdate, DateTime todate,  string TransactionType, int ProductID, int ProductGroupID, bool isCheckedProductName, bool isCheckedProductGroup)
        {
            InitializeComponent();
            fdate = fromdate;
            tdate = todate;
            prodID = ProductID;
            prodGroupID = ProductGroupID;
            isprodTrue = isCheckedProductName;
            isprodGruopTrue = isCheckedProductGroup;
            type = TransactionType;
            showreports();
         

        }



        public void showreports()
        {
            r.fromdate = fdate;
            r.todate = tdate;
            r.TransactionType = type;

            if (isprodTrue == true)
            {
                r.ProductID = prodID;

            }
            else
            {
                r.ProductID = -1;
            }

            if (isprodGruopTrue == true)
            {
                r.ProductGroupID = prodGroupID;

            }
            else
            {
                r.ProductGroupID = -1;
            }


            DataSet ds = r.SelectTransRegisterReport();
            DataTable dt = ds.Tables[0];
            double TotalQty = 0;
            double TotalGross    = 0;
           

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    dgvReport.Rows.Add();
                    dgvReport.Rows[i].Cells["TransactionDate"].Value = Convert.ToDateTime(dt.Rows[i]["TransactionDate"]).ToString("dd/MMM/yyyy");
                    dgvReport.Rows[i].Cells["VoucherNumber"].Value = dt.Rows[i]["VoucherNumber"].ToString();
                    dgvReport.Rows[i].Cells["PartyName"].Value = dt.Rows[i]["PartyName"].ToString();
                    dgvReport.Rows[i].Cells["Price"].Value = dt.Rows[i]["Price"].ToString();
                    dgvReport.Rows[i].Cells["ProductCode"].Value = dt.Rows[i]["ProductCode"].ToString();
                    dgvReport.Rows[i].Cells["ProductName"].Value = dt.Rows[i]["ProductName"].ToString();
                    dgvReport.Rows[i].Cells["GroupName"].Value = dt.Rows[i]["GroupName"].ToString();
                    dgvReport.Rows[i].Cells["TotalQTY"].Value = dt.Rows[i]["TotalQTY"].ToString();
                    dgvReport.Rows[i].Cells["TotalGross"].Value = dt.Rows[i]["TotalGross"].ToString();
                    dgvReport.Rows[i].Cells["Barcode"].Value = dt.Rows[i]["Barcode"].ToString();
                    dgvReport.Rows[i].Cells["ManualBarcode"].Value = dt.Rows[i]["ManualBarcode"].ToString();
             


                    TotalQty += Convert.ToDouble(dt.Rows[i]["TotalQTY"].ToString());
                    TotalGross += Convert.ToDouble(dt.Rows[i]["TotalGross"].ToString());



                }
            }
            int count = dgvReport.Rows.Count;
            dgvReport.Rows.Add();
            dgvReport.Rows[count].Cells["PartyName"].Value = "Total";
            dgvReport.Rows[count].Cells["TotalQTY"].Value = TotalQty;
            dgvReport.Rows[count].Cells["TotalGross"].Value = TotalGross;

            dgvReport.Rows[count].DefaultCellStyle.ForeColor = Color.Red;
            dgvReport.Rows[count].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10,FontStyle.Bold);
            dgvReport.Rows[count].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


           

        }







    }
}
