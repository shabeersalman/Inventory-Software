namespace InventorySuite.Inventory.Reports
{
    partial class frm_TransReportView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TransReportView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.lbltodate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblfromdate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblform = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.lbltodate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblfromdate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblform);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 111);
            this.panel1.TabIndex = 0;
       
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
            // lbltodate
            // 
            this.lbltodate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbltodate.ForeColor = System.Drawing.Color.Red;
            this.lbltodate.Location = new System.Drawing.Point(325, 67);
            this.lbltodate.Name = "lbltodate";
            this.lbltodate.Size = new System.Drawing.Size(92, 23);
            this.lbltodate.TabIndex = 4;
            this.lbltodate.Text = "dd/mm/yyyy";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(292, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "to";
            // 
            // lblfromdate
            // 
            this.lblfromdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblfromdate.ForeColor = System.Drawing.Color.Red;
            this.lblfromdate.Location = new System.Drawing.Point(193, 67);
            this.lblfromdate.Name = "lblfromdate";
            this.lblfromdate.Size = new System.Drawing.Size(92, 23);
            this.lblfromdate.TabIndex = 2;
            this.lblfromdate.Text = "dd/mm/yyyy";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(142, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "from";
            // 
            // lblform
            // 
            this.lblform.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblform.ForeColor = System.Drawing.Color.Red;
            this.lblform.Location = new System.Drawing.Point(17, 67);
            this.lblform.Name = "lblform";
            this.lblform.Size = new System.Drawing.Size(136, 23);
            this.lblform.TabIndex = 0;
            this.lblform.Text = "purchase report";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvReport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1236, 499);
            this.panel2.TabIndex = 1;
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
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // frm_TransReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 610);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_TransReportView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransReportView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_TransReportView_Load);
            this.Shown += new System.EventHandler(this.frm_TransReportView_Shown);
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Label lblform;
        private System.Windows.Forms.Label lbltodate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblfromdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton Close;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripButton btnPreviw;
        private System.Windows.Forms.ToolStripButton btnOptions;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnPdf;
        private System.Windows.Forms.ToolStripMenuItem btnExcel;
        private System.Windows.Forms.ToolStripSplitButton btnExport;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}