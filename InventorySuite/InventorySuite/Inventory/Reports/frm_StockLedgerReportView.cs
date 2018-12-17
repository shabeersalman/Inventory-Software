using DGVPrinterHelper;
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
    public partial class frm_StockLedgerReportView : Form
    {


        DateTime AsonDate;
        int prodID;
        bool isprodTrue;
        Rports r = new Rports();
        Export Exp = new Export();
        public frm_StockLedgerReportView(DateTime Date, int ProductID,bool isCheckedProductName)
        {
            InitializeComponent();
            AsonDate = Date;
            prodID = ProductID;
            isprodTrue = isCheckedProductName;
            showreports();
            lbldate.Text = Date.ToString();

        }

      
        public void showreports()
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
            DataSet ds = r.StockLedgerReport();
            DataTable dt = ds.Tables[0];
            double TotalInwardQty = 0;
            double TotalOutwardQty = 0;
            double Balance=0;

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    dgvStockLedgerReport.Rows.Add();
                    dgvStockLedgerReport.Rows[i].Cells["SI"].Value = dt.Rows[i]["SI"].ToString();
                    dgvStockLedgerReport.Rows[i].Cells["Date"].Value =Convert.ToDateTime( dt.Rows[i]["TransactionDate"]).ToString("dd/MMM/yyyy");
                    dgvStockLedgerReport.Rows[i].Cells["Particulars"].Value = dt.Rows[i]["PartyName"].ToString();
                    dgvStockLedgerReport.Rows[i].Cells["VoucherType"].Value = dt.Rows[i]["VoucherType"].ToString();
                    dgvStockLedgerReport.Rows[i].Cells["VoucherNo"].Value = dt.Rows[i]["VoucherNumber"].ToString();
                    dgvStockLedgerReport.Rows[i].Cells["InwardQty"].Value = dt.Rows[i]["InwardQty"].ToString();
                    dgvStockLedgerReport.Rows[i].Cells["OutwardQty"].Value = dt.Rows[i]["OutwardQty"].ToString();
                    Balance += Convert.ToDouble(dt.Rows[i]["InwardQty"]) - Convert.ToDouble(dt.Rows[i]["OutwardQty"]);
                    dgvStockLedgerReport.Rows[i].Cells["Balance"].Value = Balance.ToString();

                    TotalInwardQty += Convert.ToDouble(dt.Rows[i]["InwardQty"].ToString());
                    TotalOutwardQty += Convert.ToDouble(dt.Rows[i]["OutwardQty"].ToString());
               


                }
            }
            int count = dgvStockLedgerReport.Rows.Count;
            dgvStockLedgerReport.Rows.Add();
            dgvStockLedgerReport.Rows[count].Cells["Particulars"].Value = "Total";
            dgvStockLedgerReport.Rows[count].Cells["InwardQty"].Value = TotalInwardQty;
            dgvStockLedgerReport.Rows[count].Cells["OutwardQty"].Value = TotalOutwardQty;
            dgvStockLedgerReport.Rows[count].Cells["Balance"].Value = Balance;
            dgvStockLedgerReport.Rows[count].DefaultCellStyle.ForeColor = Color.Red;
            dgvStockLedgerReport.Rows[count].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 10);
            dgvStockLedgerReport.Rows[count].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;


            //dgvStockLedgerReport.DataSource = ds.Tables[0];
            //  calculateTOtal();

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Exp.ExportToExcel(dgvStockLedgerReport, "StockLedger Report");
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
                Exp.ExportToPdf(dgvStockLedgerReport, @"F:\StockLedgerReport.pdf", "StockLedgerReport");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            DGVPrinter Printer = new DGVPrinter();

            Printer.Title = "Stock Ledger Report";
            Printer.SubTitle = String.Format("Date:{0}", DateTime.Now.Date.ToString("dd/mm/yyyy"));
            Printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            Printer.SubTitleSpacing = 3;
            Printer.PageNumbers = true;
            Printer.PageNumberInHeader = false;
            Printer.PorportionalColumns = true;
            Printer.HeaderCellAlignment = StringAlignment.Near;
            Printer.Footer = "Inventory Suite";
            Printer.FooterSpacing = 5;
            Printer.printDocument.DefaultPageSettings.Landscape = false;
            Printer.PrintPreviewDataGridView(dgvStockLedgerReport);
        }
    }
}
