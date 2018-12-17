using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using DGVPrinterHelper;

namespace InventorySuite.Inventory.Reports
{

    public partial class frm_StockReportView : Form
    {

        DateTime AsonDate;
        int prodID,prodGroupID;
        bool isprodTrue, isprodGruopTrue;
        Rports r = new Rports();
        Export Exp = new Export();
 
        public frm_StockReportView( DateTime Date, int ProductID, int ProductGroupID,bool isCheckedProductName, bool isCheckedProductGroup)
        {
            InitializeComponent();
            AsonDate = Date;
            prodID   = ProductID;
            prodGroupID = ProductGroupID;
            isprodTrue = isCheckedProductName;
            isprodGruopTrue = isCheckedProductGroup;
            
            showStockreports();
            lbldate.Text = Date.ToString();


        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            frm_StockReportASonDate f = new frm_StockReportASonDate();
            f.Show();
        }

        public void showStockreports()
        {

            r.AsonDate = AsonDate;

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



            DataSet ds = r.StockReport();
            DataTable dt = ds.Tables[0];


            string GroupName = "";
            double substock = 0;
            double grandtotal = 0;
            int k = 0;


            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                // dgvStockReport.Rows.Add();

                if (GroupName != dt.Rows[i]["GroupName"].ToString())
                {

                    if (GroupName!="")
                    {
                        dgvStockReport.Rows.Add();
                        dgvStockReport.Rows[k].Cells["Stock"].Value = substock;
                        dgvStockReport.Rows[k].Cells["ProductName"].Value = "Group  Total";
                        dgvStockReport.Rows[k].DefaultCellStyle.ForeColor = Color.Red;
                        dgvStockReport.Rows[k].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10);
                        dgvStockReport.Rows[k].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        grandtotal += substock;
                        substock = 0;     
                        k++;
                    }
                    dgvStockReport.Rows.Add();
                    dgvStockReport.Rows[k].Cells["GroupName"].Value = dt.Rows[i]["GroupName"].ToString();
                    GroupName = dt.Rows[i]["GroupName"].ToString();
                    k++;
          

                }
                

                dgvStockReport.Rows.Add();


               // dgvStockReport.Rows[k].Cells["TransactionDate"].Value = dt.Rows[i]["TransactionDate"].ToString();
                dgvStockReport.Rows[k].Cells["ProductID"].Value = dt.Rows[i]["ProductID"].ToString();
                dgvStockReport.Rows[k].Cells["ProductName"].Value = dt.Rows[i]["ProductName"].ToString();
                dgvStockReport.Rows[k].Cells["AutoBarcode"].Value = dt.Rows[i]["AutoBarcode"].ToString();
                dgvStockReport.Rows[k].Cells["Stock"].Value = dt.Rows[i]["Stock"].ToString();
                dgvStockReport.Rows[k].Cells["PurchasePrice"].Value = dt.Rows[i]["PurchasePrice"].ToString();
                dgvStockReport.Rows[k].Cells["SalePrice"].Value = dt.Rows[i]["SalePrice"].ToString();
                k++;

                 
                substock += Convert.ToDouble(dt.Rows[i]["Stock"].ToString());
        
                

            }


            int count = dgvStockReport.Rows.Count;
            dgvStockReport.Rows.Add();
            dgvStockReport.Rows[count].Cells["Stock"].Value = substock;
            dgvStockReport.Rows[count].Cells["ProductName"].Value = "Group Total";
            dgvStockReport.Rows[count].DefaultCellStyle.ForeColor = Color.Red;
            dgvStockReport.Rows[count].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10);
            dgvStockReport.Rows[count].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
           dgvStockReport.Rows.Add();
            dgvStockReport.Rows[count+1].DefaultCellStyle.ForeColor = Color.Red;
            dgvStockReport.Rows[count+1].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10);
            dgvStockReport.Rows[count+1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvStockReport.Rows[count+1].Cells["Stock"].Value = grandtotal + substock;
           dgvStockReport.Rows[count+1].Cells["ProductName"].Value = "Grand Total";


        }

  
        

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
              Exp.ExportToExcel (dgvStockReport, "Stock Report");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }

        }


        private void btnPdf_Click(object sender, EventArgs e)
        {

            try
            {

                Exp.ExportToPdf(dgvStockReport, @"F:\Transactions.pdf", "Stock Report");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }

        }

        private void dgvStockReport_MouseDoubleClick(object sender, MouseEventArgs e)
        {

              if(dgvStockReport.CurrentRow.Cells["ProductID"].Value!=null)
            {

            
            int prodId =Convert.ToInt32( dgvStockReport.CurrentRow.Cells["ProductID"].Value);
            
           
                frm_StockLedgerReportView f = new frm_StockLedgerReportView(AsonDate, prodId,true);
                f.MdiParent = frm_MainDashboard.frmObj;
               
                f.Show();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter Printer = new DGVPrinter();

            Printer.Title = "Stock Report";
            Printer.SubTitle = String.Format("Date:{0}", DateTime.Now.Date.ToString("dd/mm/yyyy"));
            Printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            Printer.SubTitleSpacing = 3;
            Printer.PageNumbers = true;
            Printer.PageNumberInHeader = false;
            Printer.PorportionalColumns = true;
            Printer.HeaderCellAlignment = StringAlignment.Near;
            Printer.Footer = "Inventory Suite";
            Printer.FooterSpacing = 5;
            Printer.printDocument.DefaultPageSettings.Landscape = true;
            Printer.PrintPreviewDataGridView(dgvStockReport);

        }

        private void frm_StockReportView_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnExport_ButtonClick(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }










    }
}
