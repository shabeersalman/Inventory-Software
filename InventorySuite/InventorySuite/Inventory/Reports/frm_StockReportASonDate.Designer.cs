namespace InventorySuite.Inventory.Reports
{
    partial class frm_StockReportASonDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_StockReportASonDate));
            this.lblAsondate = new System.Windows.Forms.Label();
            this.dtpAsonDate = new System.Windows.Forms.DateTimePicker();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblhead = new System.Windows.Forms.Label();
            this.cmbProductName = new System.Windows.Forms.ComboBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.CbPN = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btn_Show = new System.Windows.Forms.Button();
            this.cbPG = new System.Windows.Forms.CheckBox();
            this.lblProductGroup = new System.Windows.Forms.Label();
            this.cmbProductGroup = new System.Windows.Forms.ComboBox();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAsondate
            // 
            this.lblAsondate.AutoSize = true;
            this.lblAsondate.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblAsondate.Location = new System.Drawing.Point(61, 234);
            this.lblAsondate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsondate.Name = "lblAsondate";
            this.lblAsondate.Size = new System.Drawing.Size(80, 19);
            this.lblAsondate.TabIndex = 51;
            this.lblAsondate.Text = "As On Date";
            // 
            // dtpAsonDate
            // 
            this.dtpAsonDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAsonDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAsonDate.Location = new System.Drawing.Point(149, 230);
            this.dtpAsonDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpAsonDate.Name = "dtpAsonDate";
            this.dtpAsonDate.Size = new System.Drawing.Size(137, 22);
            this.dtpAsonDate.TabIndex = 2;
            this.dtpAsonDate.Value = new System.DateTime(2018, 7, 6, 0, 0, 0, 0);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblhead);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(448, 88);
            this.pnlHeader.TabIndex = 53;
            // 
            // lblhead
            // 
            this.lblhead.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhead.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblhead.Location = new System.Drawing.Point(103, 30);
            this.lblhead.Name = "lblhead";
            this.lblhead.Size = new System.Drawing.Size(266, 44);
            this.lblhead.TabIndex = 0;
            this.lblhead.Text = "Stock Report";
            // 
            // cmbProductName
            // 
            this.cmbProductName.FormattingEnabled = true;
            this.cmbProductName.Location = new System.Drawing.Point(149, 178);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.Size = new System.Drawing.Size(253, 24);
            this.cmbProductName.TabIndex = 1;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(43, 182);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(99, 19);
            this.lblProductName.TabIndex = 54;
            this.lblProductName.Text = "Product Name";
            // 
            // CbPN
            // 
            this.CbPN.AutoSize = true;
            this.CbPN.Location = new System.Drawing.Point(16, 185);
            this.CbPN.Name = "CbPN";
            this.CbPN.Size = new System.Drawing.Size(18, 17);
            this.CbPN.TabIndex = 57;
            this.CbPN.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Image = global::InventorySuite.Properties.Resources.if_Log_Out_27856;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(312, 331);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 38);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btn_Show
            // 
            this.btn_Show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Show.Image = global::InventorySuite.Properties.Resources.if_files_folders_52_808605;
            this.btn_Show.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Show.Location = new System.Drawing.Point(216, 331);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(90, 38);
            this.btn_Show.TabIndex = 3;
            this.btn_Show.Text = "Show";
            this.btn_Show.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // cbPG
            // 
            this.cbPG.AutoSize = true;
            this.cbPG.Location = new System.Drawing.Point(16, 131);
            this.cbPG.Name = "cbPG";
            this.cbPG.Size = new System.Drawing.Size(18, 17);
            this.cbPG.TabIndex = 56;
            this.cbPG.UseVisualStyleBackColor = true;
            // 
            // lblProductGroup
            // 
            this.lblProductGroup.AutoSize = true;
            this.lblProductGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductGroup.Location = new System.Drawing.Point(43, 131);
            this.lblProductGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductGroup.Name = "lblProductGroup";
            this.lblProductGroup.Size = new System.Drawing.Size(101, 19);
            this.lblProductGroup.TabIndex = 50;
            this.lblProductGroup.Text = "Product Group";
            // 
            // cmbProductGroup
            // 
            this.cmbProductGroup.FormattingEnabled = true;
            this.cmbProductGroup.Location = new System.Drawing.Point(149, 126);
            this.cmbProductGroup.Name = "cmbProductGroup";
            this.cmbProductGroup.Size = new System.Drawing.Size(253, 24);
            this.cmbProductGroup.TabIndex = 0;
            // 
            // frm_StockReportASonDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 442);
            this.Controls.Add(this.CbPN);
            this.Controls.Add(this.cbPG);
            this.Controls.Add(this.cmbProductName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.cmbProductGroup);
            this.Controls.Add(this.lblAsondate);
            this.Controls.Add(this.lblProductGroup);
            this.Controls.Add(this.dtpAsonDate);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frm_StockReportASonDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Report";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_StockReportASonDate_KeyDown);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Label lblAsondate;
        private System.Windows.Forms.DateTimePicker dtpAsonDate;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblhead;
        private System.Windows.Forms.ComboBox cmbProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.CheckBox CbPN;
        private System.Windows.Forms.ComboBox cmbProductGroup;
        private System.Windows.Forms.Label lblProductGroup;
        private System.Windows.Forms.CheckBox cbPG;
    }
}