namespace InventorySuite.Inventory.Reports
{
    partial class frmTransRegisterReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransRegisterReport));
            this.cmbProductName = new System.Windows.Forms.ComboBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.cmbProductGroup = new System.Windows.Forms.ComboBox();
            this.lblProductGroup = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblhead = new System.Windows.Forms.Label();
            this.CbPN = new System.Windows.Forms.CheckBox();
            this.cbPG = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btn_Show = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_todate = new System.Windows.Forms.DateTimePicker();
            this.dtp_fromdate = new System.Windows.Forms.DateTimePicker();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbProductName
            // 
            this.cmbProductName.FormattingEnabled = true;
            this.cmbProductName.Location = new System.Drawing.Point(149, 180);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.Size = new System.Drawing.Size(253, 24);
            this.cmbProductName.TabIndex = 59;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(43, 184);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(99, 19);
            this.lblProductName.TabIndex = 66;
            this.lblProductName.Text = "Product Name";
            // 
            // cmbProductGroup
            // 
            this.cmbProductGroup.FormattingEnabled = true;
            this.cmbProductGroup.Location = new System.Drawing.Point(149, 130);
            this.cmbProductGroup.Name = "cmbProductGroup";
            this.cmbProductGroup.Size = new System.Drawing.Size(253, 24);
            this.cmbProductGroup.TabIndex = 58;
            // 
            // lblProductGroup
            // 
            this.lblProductGroup.AutoSize = true;
            this.lblProductGroup.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductGroup.Location = new System.Drawing.Point(43, 135);
            this.lblProductGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductGroup.Name = "lblProductGroup";
            this.lblProductGroup.Size = new System.Drawing.Size(101, 19);
            this.lblProductGroup.TabIndex = 63;
            this.lblProductGroup.Text = "Product Group";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblhead);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(448, 88);
            this.pnlHeader.TabIndex = 65;
            // 
            // lblhead
            // 
            this.lblhead.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhead.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblhead.Location = new System.Drawing.Point(28, 30);
            this.lblhead.Name = "lblhead";
            this.lblhead.Size = new System.Drawing.Size(417, 44);
            this.lblhead.TabIndex = 0;
            this.lblhead.Text = "Sales Register Report";
            // 
            // CbPN
            // 
            this.CbPN.AutoSize = true;
            this.CbPN.Location = new System.Drawing.Point(16, 187);
            this.CbPN.Name = "CbPN";
            this.CbPN.Size = new System.Drawing.Size(18, 17);
            this.CbPN.TabIndex = 68;
            this.CbPN.UseVisualStyleBackColor = true;
            // 
            // cbPG
            // 
            this.cbPG.AutoSize = true;
            this.cbPG.Location = new System.Drawing.Point(16, 135);
            this.cbPG.Name = "cbPG";
            this.cbPG.Size = new System.Drawing.Size(18, 17);
            this.cbPG.TabIndex = 67;
            this.cbPG.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Image = global::InventorySuite.Properties.Resources.if_Log_Out_27856;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(312, 368);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 38);
            this.btnClose.TabIndex = 62;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btn_Show
            // 
            this.btn_Show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Show.Image = global::InventorySuite.Properties.Resources.if_files_folders_52_808605;
            this.btn_Show.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Show.Location = new System.Drawing.Point(216, 368);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(90, 38);
            this.btn_Show.TabIndex = 61;
            this.btn_Show.Text = "Show";
            this.btn_Show.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(76, 268);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 72;
            this.label2.Text = "To Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 227);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 71;
            this.label1.Text = "From Date";
            // 
            // dtp_todate
            // 
            this.dtp_todate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_todate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_todate.Location = new System.Drawing.Point(148, 269);
            this.dtp_todate.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_todate.Name = "dtp_todate";
            this.dtp_todate.Size = new System.Drawing.Size(137, 22);
            this.dtp_todate.TabIndex = 70;
            // 
            // dtp_fromdate
            // 
            this.dtp_fromdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fromdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fromdate.Location = new System.Drawing.Point(149, 229);
            this.dtp_fromdate.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_fromdate.Name = "dtp_fromdate";
            this.dtp_fromdate.Size = new System.Drawing.Size(137, 22);
            this.dtp_fromdate.TabIndex = 69;
            // 
            // frmTransRegisterReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 442);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_todate);
            this.Controls.Add(this.dtp_fromdate);
            this.Controls.Add(this.cmbProductName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.cmbProductGroup);
            this.Controls.Add(this.lblProductGroup);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.CbPN);
            this.Controls.Add(this.cbPG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTransRegisterReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTransRegisterReport";
            this.Load += new System.EventHandler(this.frmTransRegisterReport_Load);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.ComboBox cmbProductGroup;
        private System.Windows.Forms.Label lblProductGroup;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblhead;
        private System.Windows.Forms.CheckBox CbPN;
        private System.Windows.Forms.CheckBox cbPG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_todate;
        private System.Windows.Forms.DateTimePicker dtp_fromdate;
    }
}