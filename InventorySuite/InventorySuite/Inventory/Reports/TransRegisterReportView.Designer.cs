namespace InventorySuite.Inventory.Reports
{
    partial class TransRegisterReportView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransRegisterReportView));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.TransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoucherNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalGross = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManualBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblhead = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.Close = new System.Windows.Forms.ToolStripButton();
            this.btnPreviw = new System.Windows.Forms.ToolStripButton();
            this.btnOptions = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnPdf = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExport = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToResizeColumns = false;
            this.dgvReport.AllowUserToResizeRows = false;
            this.dgvReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransactionDate,
            this.VoucherNumber,
            this.PartyName,
            this.Price,
            this.ProductCode,
            this.ProductName,
            this.TotalQTY,
            this.GroupName,
            this.TotalGross,
            this.Barcode,
            this.ManualBarcode});
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.Location = new System.Drawing.Point(0, 0);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReport.RowTemplate.Height = 24;
            this.dgvReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReport.Size = new System.Drawing.Size(1236, 499);
            this.dgvReport.TabIndex = 0;
            // 
            // TransactionDate
            // 
            this.TransactionDate.HeaderText = "Date";
            this.TransactionDate.Name = "TransactionDate";
            this.TransactionDate.ReadOnly = true;
            this.TransactionDate.Width = 130;
            // 
            // VoucherNumber
            // 
            this.VoucherNumber.HeaderText = "VchNo";
            this.VoucherNumber.Name = "VoucherNumber";
            this.VoucherNumber.ReadOnly = true;
            // 
            // PartyName
            // 
            this.PartyName.HeaderText = "Party";
            this.PartyName.Name = "PartyName";
            this.PartyName.ReadOnly = true;
            this.PartyName.Width = 150;
            // 
            // Price
            // 
            this.Price.HeaderText = "Unit Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 120;
            // 
            // ProductCode
            // 
            this.ProductCode.HeaderText = "Product Code";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            this.ProductCode.Width = 120;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 180;
            // 
            // TotalQTY
            // 
            this.TotalQTY.HeaderText = "Quantity";
            this.TotalQTY.Name = "TotalQTY";
            this.TotalQTY.ReadOnly = true;
            this.TotalQTY.Width = 120;
            // 
            // GroupName
            // 
            this.GroupName.HeaderText = "Product Group";
            this.GroupName.Name = "GroupName";
            this.GroupName.ReadOnly = true;
            this.GroupName.Width = 140;
            // 
            // TotalGross
            // 
            this.TotalGross.HeaderText = "Gross";
            this.TotalGross.Name = "TotalGross";
            this.TotalGross.ReadOnly = true;
            this.TotalGross.Width = 120;
            // 
            // Barcode
            // 
            this.Barcode.HeaderText = "AutoBarcode";
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            this.Barcode.Width = 120;
            // 
            // ManualBarcode
            // 
            this.ManualBarcode.HeaderText = "Manual Barcode";
            this.ManualBarcode.Name = "ManualBarcode";
            this.ManualBarcode.ReadOnly = true;
            this.ManualBarcode.Width = 120;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvReport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1236, 499);
            this.panel2.TabIndex = 3;
            // 
            // lblhead
            // 
            this.lblhead.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblhead.ForeColor = System.Drawing.Color.Red;
            this.lblhead.Location = new System.Drawing.Point(17, 67);
            this.lblhead.Name = "lblhead";
            this.lblhead.Size = new System.Drawing.Size(547, 23);
            this.lblhead.TabIndex = 0;
            this.lblhead.Text = "purchase report";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Close
            // 
            this.Close.AutoSize = false;
            this.Close.Image = global::InventorySuite.Properties.Resources.if_Remove_27874;
            this.Close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(60, 50);
            this.Close.Text = "Close";
            this.Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnPreviw
            // 
            this.btnPreviw.AutoSize = false;
            this.btnPreviw.Image = ((System.Drawing.Image)(resources.GetObject("btnPreviw.Image")));
            this.btnPreviw.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPreviw.Name = "btnPreviw";
            this.btnPreviw.Size = new System.Drawing.Size(60, 50);
            this.btnPreviw.Text = "Preview";
            this.btnPreviw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnOptions
            // 
            this.btnOptions.AutoSize = false;
            this.btnOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOptions.Image")));
            this.btnOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(60, 50);
            this.btnOptions.Text = "Options";
            this.btnOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = false;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(60, 50);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnPdf
            // 
            this.btnPdf.Image = global::InventorySuite.Properties.Resources.if_file_extension_pdf_64239;
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(208, 26);
            this.btnPdf.Text = "PDF";
            // 
            // btnExcel
            // 
            this.btnExcel.Image = global::InventorySuite.Properties.Resources.if_logo_brand_brands_logos_excel_2993694;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(208, 26);
            this.btnExcel.Text = "Excel/SpreadSheet";
            // 
            // btnExport
            // 
            this.btnExport.AutoSize = false;
            this.btnExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExcel,
            this.btnPdf});
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(60, 50);
            this.btnExport.Text = "Export";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExport,
            this.btnRefresh,
            this.btnOptions,
            this.btnPreviw,
            this.btnPrint,
            this.Close});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1236, 55);
            this.toolStrip1.TabIndex = 28;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnPrint
            // 
            this.btnPrint.AutoSize = false;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(60, 50);
            this.btnPrint.Text = "&Print";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.lblhead);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 111);
            this.panel1.TabIndex = 2;
            // 
            // TransRegisterReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 610);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TransRegisterReportView";
            this.Text = "TransRegisterReportView";
            this.Load += new System.EventHandler(this.TransRegisterReportView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.panel2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblhead;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripButton Close;
        private System.Windows.Forms.ToolStripButton btnPreviw;
        private System.Windows.Forms.ToolStripButton btnOptions;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripMenuItem btnPdf;
        private System.Windows.Forms.ToolStripMenuItem btnExcel;
        private System.Windows.Forms.ToolStripSplitButton btnExport;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManualBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalGross;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoucherNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionDate;
    }
}