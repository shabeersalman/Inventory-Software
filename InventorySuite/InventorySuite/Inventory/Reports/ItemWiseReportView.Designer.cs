namespace InventorySuite.Inventory.Reports
{
    partial class frmItemWiseReportView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemWiseReportView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Close = new System.Windows.Forms.ToolStripButton();
            this.btnPreviw = new System.Windows.Forms.ToolStripButton();
            this.btnOptions = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnPdf = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExport = new System.Windows.Forms.ToolStripSplitButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.SI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblform = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
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
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvReport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1038, 387);
            this.panel2.TabIndex = 3;
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
            this.SI,
            this.Date,
            this.Product,
            this.TotalQty,
            this.TotalAmount});
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
            this.dgvReport.Size = new System.Drawing.Size(1038, 387);
            this.dgvReport.TabIndex = 0;
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
            this.Date.Width = 124;
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Width = 180;
            // 
            // TotalQty
            // 
            this.TotalQty.HeaderText = "TotalQty";
            this.TotalQty.Name = "TotalQty";
            this.TotalQty.ReadOnly = true;
            // 
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "Total Amount";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            this.TotalAmount.Width = 130;
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
            this.toolStrip1.Size = new System.Drawing.Size(1038, 55);
            this.toolStrip1.TabIndex = 28;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblform
            // 
            this.lblform.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblform.ForeColor = System.Drawing.Color.Red;
            this.lblform.Location = new System.Drawing.Point(17, 67);
            this.lblform.Name = "lblform";
            this.lblform.Size = new System.Drawing.Size(611, 23);
            this.lblform.TabIndex = 0;
            this.lblform.Text = "Item Wise Purchase Return Summary Report";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.lblform);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 111);
            this.panel1.TabIndex = 2;
            // 
            // frmItemWiseReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 498);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1056, 545);
            this.Name = "frmItemWiseReportView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Wise  Sales Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton Close;
        private System.Windows.Forms.ToolStripButton btnPreviw;
        private System.Windows.Forms.ToolStripButton btnOptions;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripMenuItem btnPdf;
        private System.Windows.Forms.ToolStripMenuItem btnExcel;
        private System.Windows.Forms.ToolStripSplitButton btnExport;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label lblform;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
    }
}