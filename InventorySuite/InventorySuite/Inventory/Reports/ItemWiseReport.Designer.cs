namespace InventorySuite.Inventory.Reports
{
    partial class ItemWiseReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemWiseReport));
            this.lblhead = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_todate = new System.Windows.Forms.DateTimePicker();
            this.dtp_fromdate = new System.Windows.Forms.DateTimePicker();
            this.btnClose = new System.Windows.Forms.Button();
            this.btn_Show = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblhead
            // 
            this.lblhead.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhead.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblhead.Location = new System.Drawing.Point(14, 9);
            this.lblhead.Name = "lblhead";
            this.lblhead.Size = new System.Drawing.Size(568, 44);
            this.lblhead.TabIndex = 43;
            this.lblhead.Text = "ItemWise Purchase Return Summary Report ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(179, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 42;
            this.label2.Text = "To Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 41;
            this.label1.Text = "From Date";
            // 
            // dtp_todate
            // 
            this.dtp_todate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_todate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_todate.Location = new System.Drawing.Point(251, 122);
            this.dtp_todate.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_todate.Name = "dtp_todate";
            this.dtp_todate.Size = new System.Drawing.Size(137, 22);
            this.dtp_todate.TabIndex = 38;
            // 
            // dtp_fromdate
            // 
            this.dtp_fromdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fromdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fromdate.Location = new System.Drawing.Point(252, 82);
            this.dtp_fromdate.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_fromdate.Name = "dtp_fromdate";
            this.dtp_fromdate.Size = new System.Drawing.Size(137, 22);
            this.dtp_fromdate.TabIndex = 37;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Image = global::InventorySuite.Properties.Resources.if_Log_Out_27856;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(301, 192);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 38);
            this.btnClose.TabIndex = 40;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btn_Show
            // 
            this.btn_Show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Show.Image = global::InventorySuite.Properties.Resources.if_files_folders_52_808605;
            this.btn_Show.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Show.Location = new System.Drawing.Point(205, 192);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(90, 38);
            this.btn_Show.TabIndex = 39;
            this.btn_Show.Text = "Show";
            this.btn_Show.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // ItemWiseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 251);
            this.Controls.Add(this.lblhead);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_todate);
            this.Controls.Add(this.dtp_fromdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemWiseReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemWiseReport";
            this.Load += new System.EventHandler(this.ItemWiseReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhead;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_todate;
        private System.Windows.Forms.DateTimePicker dtp_fromdate;
    }
}