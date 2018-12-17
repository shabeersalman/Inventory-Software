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

    public partial class frmItemWiseReportView : Form
    {


        DateTime fdate, tdate;
        string transaction;
        Rports r = new Rports();
        Export Exp = new Export();



        public frmItemWiseReportView(DateTime fromdate, DateTime todate,string type)
        {
            InitializeComponent();

            fdate = fromdate;
            tdate = todate;
            transaction = type;
            showreports();
            string lbltodate = todate.ToString("dd-MMM-yyyy");
            string lblfromdate = fromdate.ToString("dd-MMM-yyyy");
             lblform.Text =" Item Wise "+ transaction +" summary Report  from "+ lblfromdate +" to"+ lbltodate;
      


        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showreports();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            ItemWiseReport f = new ItemWiseReport();
              f.Show();
        }

        public void showreports()
        {
            r.fromdate = fdate;
            r.todate = tdate;
            r.TransactionType = transaction;
            DataSet ds = r.ItemWiserReport();
            DataTable dt = ds.Tables[0];


            string date = "";
            double Qty = 0;
            double Amount = 0;
            double TotalQty = 0;
            Double TotalAmount = 0;
          
            int k = 0;
            int SI = 1;

            for (int i = 0; i <=dt.Rows.Count - 1; i++)
            {

                if (date != dt.Rows[i]["TransactionDate"].ToString())
                {
                    if (date != "")
                    {
                        dgvReport.Rows.Add();
                        dgvReport.Rows[k].Cells["TotalQTY"].Value = Qty;
                        dgvReport.Rows[k].Cells["TotalAmount"].Value = Amount;
                        dgvReport.Rows[k].Cells["Product"].Value = "Total";
                        dgvReport.Rows[k].DefaultCellStyle.ForeColor = Color.Red;
                        dgvReport.Rows[k].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10);
                        dgvReport.Rows[k].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                         TotalQty += Qty;
                         TotalAmount += Amount;
                          Qty = 0;
                          Amount = 0;
                          SI = 1;
                        k++;

                    }

                    dgvReport.Rows.Add();

                    dgvReport.Rows[k].Cells["Date"].Value = Convert.ToDateTime(dt.Rows[i]["TransactionDate"]).ToString("dd-MMM-yyyy");
                    
                    date =dt.Rows[i]["TransactionDate"].ToString();
                    k++;

                }
                    dgvReport.Rows.Add();
          
                    dgvReport.Rows[k].Cells["Product"].Value = dt.Rows[i]["ProductName"].ToString();
                    dgvReport.Rows[k].Cells["TotalQty"].Value = dt.Rows[i]["TotalQTY"].ToString();
                    dgvReport.Rows[k].Cells["TotalAmount"].Value = dt.Rows[i]["TotalGross"].ToString();
                     dgvReport.Rows[k].Cells["SI"].Value = SI++;
                      k++;
              

                Qty += Convert.ToDouble(dt.Rows[i]["TotalQTY"].ToString());
                Amount += Convert.ToDouble(dt.Rows[i]["TotalGross"].ToString());

            }
                int count = dgvReport.Rows.Count;
         
                dgvReport.Rows.Add();
                dgvReport.Rows[count].DefaultCellStyle.ForeColor = Color.Red;
                dgvReport.Rows[count ].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10);
                dgvReport.Rows[count ].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvReport.Rows[count].Cells["TotalQTY"].Value = Qty;
                dgvReport.Rows[count].Cells["TotalAmount"].Value = Amount;
                dgvReport.Rows[count ].Cells["Product"].Value = "Total";
                dgvReport.Rows.Add();
                dgvReport.Rows[count+1].DefaultCellStyle.ForeColor = Color.Red;
                dgvReport.Rows[count+1].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 12,FontStyle.Bold);
                dgvReport.Rows[count+1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dgvReport.Rows[count+1].Cells["TotalQTY"].Value = Qty + TotalQty;
                dgvReport.Rows[count+1].Cells["TotalAmount"].Value = Amount + TotalAmount;
                dgvReport.Rows[count+1].Cells["Product"].Value = "Total";


        }
        }
}
