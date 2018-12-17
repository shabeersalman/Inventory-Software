namespace InventorySuite.Inventory.Reports
{
    partial class frmSrockLedgerReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSrockLedgerReport));
            this.cmbProductName = new System.Windows.Forms.ComboBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblAsondate = new System.Windows.Forms.Label();
            this.dtpAsonDate = new System.Windows.Forms.DateTimePicker();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblhead = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btn_Show = new System.Windows.Forms.Button();
            this.cbProductName = new System.Windows.Forms.CheckBox();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbProductName
            // 
            this.cmbProductName.FormattingEnabled = true;
            this.cmbProductName.Location = new System.Drawing.Point(172, 130);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.Size = new System.Drawing.Size(253, 24);
            this.cmbProductName.TabIndex = 56;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(66, 134);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(99, 19);
            this.lblProductName.TabIndex = 63;
            this.lblProductName.Text = "Product Name";
            // 
            // lblAsondate
            // 
            this.lblAsondate.AutoSize = true;
            this.lblAsondate.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblAsondate.Location = new System.Drawing.Point(84, 186);
            this.lblAsondate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAsondate.Name = "lblAsondate";
            this.lblAsondate.Size = new System.Drawing.Size(80, 19);
            this.lblAsondate.TabIndex = 61;
            this.lblAsondate.Text = "As On Date";
            // 
            // dtpAsonDate
            // 
            this.dtpAsonDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAsonDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAsonDate.Location = new System.Drawing.Point(172, 182);
            this.dtpAsonDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpAsonDate.Name = "dtpAsonDate";
            this.dtpAsonDate.Size = new System.Drawing.Size(137, 22);
            this.dtpAsonDate.TabIndex = 57;
            this.dtpAsonDate.Value = new System.DateTime(2018, 7, 6, 0, 0, 0, 0);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblhead);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(588, 88);
            this.pnlHeader.TabIndex = 62;
            // 
            // lblhead
            // 
            this.lblhead.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhead.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblhead.Location = new System.Drawing.Point(88, 34);
            this.lblhead.Name = "lblhead";
            this.lblhead.Size = new System.Drawing.Size(457, 44);
            this.lblhead.TabIndex = 0;
            this.lblhead.Text = "Stock Ledger Report";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Image = global::InventorySuite.Properties.Resources.if_Log_Out_27856;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(308, 234);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 38);
            this.btnClose.TabIndex = 59;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btn_Show
            // 
            this.btn_Show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Show.Image = global::InventorySuite.Properties.Resources.if_files_folders_52_808605;
            this.btn_Show.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Show.Location = new System.Drawing.Point(212, 234);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(90, 38);
            this.btn_Show.TabIndex = 58;
            this.btn_Show.Text = "Show";
            this.btn_Show.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // cbProductName
            // 
            this.cbProductName.AutoSize = true;
            this.cbProductName.Location = new System.Drawing.Point(43, 136);
            this.cbProductName.Name = "cbProductName";
            this.cbProductName.Size = new System.Drawing.Size(18, 17);
            this.cbProductName.TabIndex = 64;
            this.cbProductName.UseVisualStyleBackColor = true;
            // 
            // frmSrockLedgerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 314);
            this.Controls.Add(this.cbProductName);
            this.Controls.Add(this.cmbProductName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.lblAsondate);
            this.Controls.Add(this.dtpAsonDate);
            this.Controls.Add(this.pnlHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSrockLedgerReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Srock Ledger Report";
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Label lblAsondate;
        private System.Windows.Forms.DateTimePicker dtpAsonDate;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblhead;
        private System.Windows.Forms.CheckBox cbProductName;
    }
}