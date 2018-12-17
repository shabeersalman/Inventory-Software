namespace InventorySuite.Inventory.Reports
{
    partial class frm_StockReportView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_StockReportView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnExport = new System.Windows.Forms.ToolStripSplitButton();
            this.btnExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPdf = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnOptions = new System.Windows.Forms.ToolStripButton();
            this.btnPreviw = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.Close = new System.Windows.Forms.ToolStripButton();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblform = new System.Windows.Forms.Label();
            this.pnldgv = new System.Windows.Forms.Panel();
            this.dgvStockReport = new System.Windows.Forms.DataGridView();
            this.GroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutoBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnldgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.lbldate);
            this.panel1.Controls.Add(this.lblform);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 111);
            this.panel1.TabIndex = 3;
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
            this.toolStrip1.TabIndex = 27;
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
            this.btnExport.ButtonClick += new System.EventHandler(this.btnExport_ButtonClick);
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
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
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
            // lbldate
            // 
            this.lbldate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbldate.ForeColor = System.Drawing.Color.Red;
            this.lbldate.Location = new System.Drawing.Point(327, 63);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(92, 23);
            this.lbldate.TabIndex = 4;
            this.lbldate.Text = "dd/mm/yyyy";
            // 
            // lblform
            // 
            this.lblform.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblform.ForeColor = System.Drawing.Color.Red;
            this.lblform.Location = new System.Drawing.Point(29, 63);
            this.lblform.Name = "lblform";
            this.lblform.Size = new System.Drawing.Size(315, 23);
            this.lblform.TabIndex = 0;
            this.lblform.Text = "Stock Report Of All Stock Products As On Date::";
            // 
            // pnldgv
            // 
            this.pnldgv.Controls.Add(this.dgvStockReport);
            this.pnldgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnldgv.Location = new System.Drawing.Point(0, 111);
            this.pnldgv.Name = "pnldgv";
            this.pnldgv.Size = new System.Drawing.Size(1236, 499);
            this.pnldgv.TabIndex = 4;
            // 
            // dgvStockReport
            // 
            this.dgvStockReport.AllowUserToAddRows = false;
            this.dgvStockReport.AllowUserToDeleteRows = false;
            this.dgvStockReport.BackgroundColor = System.Drawing.Color.White;
            this.dgvStockReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupName,
            this.ProductName,
            this.AutoBarcode,
            this.Stock,
            this.PurchasePrice,
            this.SalePrice,
            this.ProductID});
            this.dgvStockReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStockReport.Location = new System.Drawing.Point(0, 0);
            this.dgvStockReport.Name = "dgvStockReport";
            this.dgvStockReport.ReadOnly = true;
            this.dgvStockReport.RowTemplate.Height = 24;
            this.dgvStockReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockReport.Size = new System.Drawing.Size(1236, 499);
            this.dgvStockReport.TabIndex = 0;
            this.dgvStockReport.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvStockReport_MouseDoubleClick);
            // 
            // GroupName
            // 
            this.GroupName.HeaderText = "GroupName";
            this.GroupName.Name = "GroupName";
            this.GroupName.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 180;
            // 
            // AutoBarcode
            // 
            this.AutoBarcode.HeaderText = "AutoBarcode";
            this.AutoBarcode.Name = "AutoBarcode";
            this.AutoBarcode.ReadOnly = true;
            this.AutoBarcode.Width = 120;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 90;
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.HeaderText = "PurchasePrice";
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.ReadOnly = true;
            this.PurchasePrice.Width = 90;
            // 
            // SalePrice
            // 
            this.SalePrice.HeaderText = "SalePrice";
            this.SalePrice.Name = "SalePrice";
            this.SalePrice.ReadOnly = true;
            this.SalePrice.Width = 90;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // frm_StockReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 610);
            this.Controls.Add(this.pnldgv);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_StockReportView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Report ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.frm_StockReportView_Shown);
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnldgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnldgv;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblform;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.ToolStripButton Close;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripButton btnPreviw;
        private System.Windows.Forms.ToolStripButton btnOptions;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvStockReport;
        private System.Windows.Forms.ToolStripMenuItem btnExcel;
        private System.Windows.Forms.ToolStripMenuItem btnPdf;
        private System.Windows.Forms.ToolStripSplitButton btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutoBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupName;
    }
}