using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms;

namespace InventorySuite
{
    class Export
    {


        public void ExportToExcel  (DataGridView dgv,string WorkSheetText)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            app.Columns.ColumnWidth = 20;
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = WorkSheetText;
            // storing header part in Excel  
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                //if (dgv.CurrentRow.Cells[i].Visible == true)
                if(dgv.Columns[i].Visible)
                {
                    worksheet.Cells[1, i+1] =dgv.Columns[i].HeaderText;
                }
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j <dgv.Columns.Count; j++)
                {
                    if (dgv.CurrentRow.Cells[j].Visible == true)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].FormattedValue.ToString();
                    }
                }

            }

            app.Visible = true;
            app.Quit();

        }

        public void ExportToPdf(DataGridView dgv, String Filename,string headerText)
        {

            //Creating iTextSharp Table from the DataTable data
            BaseFont Bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            int count = 0;
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                if (dgv.Columns[i].Visible)
                {
                    count++;
                }
            }
            PdfPTable pdfTable = new PdfPTable(count);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(Bf, 10, iTextSharp.text.Font.NORMAL);

            //Adding Header row

            foreach (DataGridViewColumn column in dgv.Columns)
            {         if (column.Visible == true)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    pdfTable.AddCell(cell);
                }
            }


            //Adding DataRow
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {      if (cell.Visible == true)
                    {
                        pdfTable.AddCell(new Phrase(cell.FormattedValue.ToString(), text));
                    }
                }
            }

            //  var sfd = new SaveFileDialog();
            //sfd.FileName = Filename;
            //sfd.DefaultExt = ".pdf";
            //if (sfd.ShowDialog() == DialogResult.OK)
            //{
            using (FileStream stream = new FileStream(Filename, FileMode.Create, FileAccess.Write, FileShare.None))
            {

                Document pdfDoc = new Document(PageSize.A3, 10f, 10f, 10f, 0f);
                //  pdfDoc.SetPageSize(iTextSharp.text.PageSize.A4);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();

                //Report Header
                BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font fntHead = new iTextSharp.text.Font(bfntHead, 10, 1, BaseColor.RED);
                Paragraph prgHeading = new Paragraph();
                prgHeading.Alignment = Element.ALIGN_CENTER;
                prgHeading.Add(new Chunk(headerText.ToUpper(), fntHead));
                pdfDoc.Add(prgHeading);

                //   Add a line seperation
                //  Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
                //   pdfDoc.Add(p);

                //Add line break
                pdfDoc.Add(new Chunk("\n", fntHead));

                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
                System.Diagnostics.Process.Start(Filename);


            }
            //}
        }


    }
}
