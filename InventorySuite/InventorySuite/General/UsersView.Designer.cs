namespace InventorySuite.General
{
    partial class UsersView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.pnldgv = new System.Windows.Forms.Panel();
            this.dgv_Userview = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.ToolStripSplitButton();
            this.btnExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPdf = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_header.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnldgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Userview)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.Controls.Add(this.toolStrip1);
            this.pnl_header.Controls.Add(this.txt_Search);
            this.pnl_header.Controls.Add(this.lbl_Search);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1092, 102);
            this.pnl_header.TabIndex = 26;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnDelete,
            this.btnExport,
            this.btnRefresh,
            this.btnClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1092, 53);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = false;
            this.btnAdd.Image = global::InventorySuite.Properties.Resources.if_Add_27831;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 50);
            this.btnAdd.Text = "Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = false;
            this.btnEdit.Image = global::InventorySuite.Properties.Resources.pencil;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(60, 50);
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = false;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 50);
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = false;
            this.btnRefresh.Image = global::InventorySuite.Properties.Resources.if_gtk_refresh_48111;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(60, 50);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = false;
            this.btnClose.Image = global::InventorySuite.Properties.Resources.if_Remove_27874;
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 50);
            this.btnClose.Text = "Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(79, 59);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(201, 25);
            this.txt_Search.TabIndex = 5;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            // 
            // lbl_Search
            // 
            this.lbl_Search.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search.Location = new System.Drawing.Point(5, 59);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(67, 17);
            this.lbl_Search.TabIndex = 4;
            this.lbl_Search.Text = "Search";
            // 
            // pnldgv
            // 
            this.pnldgv.Controls.Add(this.dgv_Userview);
            this.pnldgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnldgv.Location = new System.Drawing.Point(0, 102);
            this.pnldgv.Name = "pnldgv";
            this.pnldgv.Size = new System.Drawing.Size(1092, 322);
            this.pnldgv.TabIndex = 27;
            // 
            // dgv_Userview
            // 
            this.dgv_Userview.AllowUserToAddRows = false;
            this.dgv_Userview.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Aquamarine;
            this.dgv_Userview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Userview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Userview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Userview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Userview.Location = new System.Drawing.Point(0, 0);
            this.dgv_Userview.MultiSelect = false;
            this.dgv_Userview.Name = "dgv_Userview";
            this.dgv_Userview.ReadOnly = true;
            this.dgv_Userview.RowTemplate.Height = 24;
            this.dgv_Userview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Userview.Size = new System.Drawing.Size(1092, 322);
            this.dgv_Userview.TabIndex = 0;
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
            // UsersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 424);
            this.Controls.Add(this.pnldgv);
            this.Controls.Add(this.pnl_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsersView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsersView";
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnldgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Userview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnldgv;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.DataGridView dgv_Userview;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripSplitButton btnExport;
        private System.Windows.Forms.ToolStripMenuItem btnExcel;
        private System.Windows.Forms.ToolStripMenuItem btnPdf;
    }
}