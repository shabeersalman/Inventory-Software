using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using DGVPrinterHelper;

namespace InventorySuite.Inventory.Reports
{
    public partial class frm_TransReportView : Form
    {


        DateTime fdate, tdate;
        string transactiontype;
        Rports r = new Rports();
        Export Exp = new Export();
        public frm_TransReportView(DateTime fromdate, DateTime todate, string type)
        {
            InitializeComponent();
            fdate = fromdate;
            tdate = todate;
            transactiontype = type;
            showreports();
            lbltodate.Text = todate.ToString();
            lblfromdate.Text = fromdate.ToString();
            lblform.Text = transactiontype + " Report";

           
        }

              
        private void frm_TransReportView_Load(object sender, EventArgs e)
        {
            this.Text = transactiontype +" Report";
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            TransactionReport f = new TransactionReport();
            f.Show();
        }

        public void showreports()
        {
            r.fromdate = fdate;
            r.todate = tdate;
            r.TransactionType = transactiontype;
            DataSet ds = r.TransReports();
            DataTable dt = ds.Tables[0];

           dt.Rows.Add( dt.NewRow());

            dgvReport.DataSource = ds.Tables[0];
            calculateTOtal();

        }

        private void frm_TransReportView_Shown(object sender, EventArgs e)
        {
            calculateTOtal();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {

                Exp.ExportToExcel(dgvReport, transactiontype);
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

                Exp.ExportToPdf(dgvReport, @"F:\Transactions.pdf",transactiontype);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter Printer = new DGVPrinter();

            Printer.Title = String.Format("{0} Report", transactiontype);
            Printer.SubTitle = String.Format("Date:{0}", DateTime.Now.Date.ToString("dd/mm/yyyy"));
            Printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            Printer.SubTitleSpacing = 5;
             Printer.PageNumbers = true;
            Printer.PageNumberInHeader = false;
            Printer.PorportionalColumns = true;
            Printer.HeaderCellAlignment = StringAlignment.Near;
            Printer.Footer = "Inventory Suite";
            Printer.FooterSpacing = 5;
            Printer.printDocument.DefaultPageSettings.Landscape = true;
            Printer.PrintPreviewDataGridView(dgvReport);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        void calculateTOtal()
        {
            double tot = 0;
            double gross = 0;
            for(int i=0;i<dgvReport.Rows.Count-1;i++)
            {
                tot += Convert.ToDouble("0"+dgvReport.Rows[i].Cells["GrandTotal"].FormattedValue);
                gross += Convert.ToDouble("0"+dgvReport.Rows[i].Cells["Gross"].FormattedValue);

            }

            dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["GrandTotal"].Value = tot;
            dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["Gross"].Value = gross;
            dgvReport.Rows[dgvReport.Rows.Count - 1].Cells["PartyName"].Value = "Total";

            dgvReport.Rows[dgvReport.Rows.Count - 1].DefaultCellStyle.ForeColor = Color.Red;
            dgvReport.Rows[dgvReport.Rows.Count - 1].DefaultCellStyle.Font = new Font("Arial", 10);
            dgvReport.Rows[dgvReport.Rows.Count - 1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

        }
    }
}
