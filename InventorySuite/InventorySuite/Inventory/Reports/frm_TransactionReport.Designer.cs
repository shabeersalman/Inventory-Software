namespace InventorySuite.Inventory.Reports
{
    partial class TransactionReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionReport));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_todate = new System.Windows.Forms.DateTimePicker();
            this.dtp_fromdate = new System.Windows.Forms.DateTimePicker();
            this.btnClose = new System.Windows.Forms.Button();
            this.btn_Show = new System.Windows.Forms.Button();
            this.lblhead = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(114, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "To Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "From Date";
            // 
            // dtp_todate
            // 
            this.dtp_todate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_todate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_todate.Location = new System.Drawing.Point(186, 188);
            this.dtp_todate.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_todate.Name = "dtp_todate";
            this.dtp_todate.Size = new System.Drawing.Size(137, 22);
            this.dtp_todate.TabIndex = 1;
            // 
            // dtp_fromdate
            // 
            this.dtp_fromdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fromdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fromdate.Location = new System.Drawing.Point(187, 148);
            this.dtp_fromdate.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_fromdate.Name = "dtp_fromdate";
            this.dtp_fromdate.Size = new System.Drawing.Size(137, 22);
            this.dtp_fromdate.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Image = global::InventorySuite.Properties.Resources.if_Log_Out_27856;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(234, 263);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 38);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Show
            // 
            this.btn_Show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Show.Image = global::InventorySuite.Properties.Resources.if_files_folders_52_808605;
            this.btn_Show.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Show.Location = new System.Drawing.Point(138, 263);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(90, 38);
            this.btn_Show.TabIndex = 2;
            this.btn_Show.Text = "Show";
            this.btn_Show.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // lblhead
            // 
            this.lblhead.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhead.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblhead.Location = new System.Drawing.Point(86, 29);
            this.lblhead.Name = "lblhead";
            this.lblhead.Size = new System.Drawing.Size(370, 44);
            this.lblhead.TabIndex = 36;
            this.lblhead.Text = "Stock Report";
            // 
            // TransactionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(460, 447);
            this.Controls.Add(this.lblhead);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_todate);
            this.Controls.Add(this.dtp_fromdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "TransactionReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction Report";
            this.Load += new System.EventHandler(this.TransactionReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TransactionReport_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_todate;
        private System.Windows.Forms.DateTimePicker dtp_fromdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Label lblhead;
    }
}