namespace InventorySuite.Inventory.Reports
{
    partial class frm_StockLedgerReportView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_StockLedgerReportView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblform = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnExport = new System.Windows.Forms.ToolStripSplitButton();
            this.btnExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPdf = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnOptions = new System.Windows.Forms.ToolStripButton();
            this.btnPreviw = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.Close = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvStockLedgerReport = new System.Windows.Forms.DataGridView();
            this.SI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Particulars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoucherType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoucherNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InwardQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutwardQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockLedgerReport)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbldate);
            this.panel1.Controls.Add(this.lblform);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 121);
            this.panel1.TabIndex = 0;
            // 
            // lbldate
            // 
            this.lbldate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbldate.ForeColor = System.Drawing.Color.Red;
            this.lbldate.Location = new System.Drawing.Point(320, 77);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(92, 23);
            this.lbldate.TabIndex = 31;
            this.lbldate.Text = "dd/mm/yyyy";
            // 
            // lblform
            // 
            this.lblform.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblform.ForeColor = System.Drawing.Color.Red;
            this.lblform.Location = new System.Drawing.Point(3, 77);
            this.lblform.Name = "lblform";
            this.lblform.Size = new System.Drawing.Size(315, 23);
            this.lblform.TabIndex = 30;
            this.lblform.Text = "Stock Ledger Report Of All Stock Products As On Date::";
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
            this.toolStrip1.Size = new System.Drawing.Size(1236, 78);
            this.toolStrip1.TabIndex = 29;
            this.toolStrip1.Text = "toolStrip1";
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
            // btnExcel
            // 
            this.btnExcel.Image = global::InventorySuite.Properties.Resources.if_logo_brand_brands_logos_excel_2993694;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(208, 26);
            this.btnExcel.Text = "Excel/SpreadSheet";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnPdf
            // 
            this.btnPdf.Image = global::InventorySuite.Properties.Resources.if_file_extension_pdf_64239;
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(208, 26);
            this.btnPdf.Text = "PDF";
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
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
            // btnPrint
            // 
            this.btnPrint.AutoSize = false;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(60, 50);
            this.btnPrint.Text = "&Print";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvStockLedgerReport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1236, 489);
            this.panel2.TabIndex = 1;
            // 
            // dgvStockLedgerReport
            // 
            this.dgvStockLedgerReport.AllowUserToAddRows = false;
            this.dgvStockLedgerReport.AllowUserToDeleteRows = false;
            this.dgvStockLedgerReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvStockLedgerReport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvStockLedgerReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockLedgerReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SI,
            this.Date,
            this.Particulars,
            this.VoucherType,
            this.VoucherNo,
            this.InwardQty,
            this.OutwardQty,
            this.Balance});
            this.dgvStockLedgerReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockLedgerReport.Location = new System.Drawing.Point(0, 0);
            this.dgvStockLedgerReport.Name = "dgvStockLedgerReport";
            this.dgvStockLedgerReport.ReadOnly = true;
            this.dgvStockLedgerReport.Size = new System.Drawing.Size(1236, 489);
            this.dgvStockLedgerReport.TabIndex = 0;
            // 
            // SI
            // 
            this.SI.HeaderText = "SI";
            this.SI.Name = "SI";
            this.SI.ReadOnly = true;
            this.SI.Width = 60;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 130;
            // 
            // Particulars
            // 
            this.Particulars.HeaderText = "Particulars";
            this.Particulars.Name = "Particulars";
            this.Particulars.ReadOnly = true;
            // 
            // VoucherType
            // 
            this.VoucherType.HeaderText = "Voucher Type";
            this.VoucherType.Name = "VoucherType";
            this.VoucherType.ReadOnly = true;
            this.VoucherType.Width = 130;
            // 
            // VoucherNo
            // 
            this.VoucherNo.HeaderText = "Voucher No";
            this.VoucherNo.Name = "VoucherNo";
            this.VoucherNo.ReadOnly = true;
            // 
            // InwardQty
            // 
            this.InwardQty.HeaderText = "Inward Qty";
            this.InwardQty.Name = "InwardQty";
            this.InwardQty.ReadOnly = true;
            // 
            // OutwardQty
            // 
            this.OutwardQty.HeaderText = "Outward Qty";
            this.OutwardQty.Name = "OutwardQty";
            this.OutwardQty.ReadOnly = true;
            // 
            // Balance
            // 
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            this.Balance.Width = 130;
            // 
            // frm_StockLedgerReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 610);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_StockLedgerReportView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Ledger Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockLedgerReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton Close;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripButton btnPreviw;
        private System.Windows.Forms.ToolStripButton btnOptions;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvStockLedgerReport;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblform;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutwardQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn InwardQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoucherNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn VoucherType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Particulars;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn SI;
        private System.Windows.Forms.ToolStripMenuItem btnPdf;
        private System.Windows.Forms.ToolStripMenuItem btnExcel;
        private System.Windows.Forms.ToolStripSplitButton btnExport;
    }
}