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
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_todate = new System.Windows.Forms.DateTimePicker();
            this.dtp_fromdate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_Close.Location = new System.Drawing.Point(334, 253);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(89, 36);
            this.btn_Close.TabIndex = 35;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_show
            // 
            this.btn_show.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.btn_show.Location = new System.Drawing.Point(212, 253);
            this.btn_show.Margin = new System.Windows.Forms.Padding(4);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(89, 36);
            this.btn_show.TabIndex = 34;
            this.btn_show.Text = "Show";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(201, 192);
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
            this.label1.Location = new System.Drawing.Point(186, 151);
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
            this.dtp_todate.Location = new System.Drawing.Point(273, 193);
            this.dtp_todate.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_todate.Name = "dtp_todate";
            this.dtp_todate.Size = new System.Drawing.Size(137, 22);
            this.dtp_todate.TabIndex = 31;
            // 
            // dtp_fromdate
            // 
            this.dtp_fromdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fromdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fromdate.Location = new System.Drawing.Point(274, 153);
            this.dtp_fromdate.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_fromdate.Name = "dtp_fromdate";
            this.dtp_fromdate.Size = new System.Drawing.Size(137, 22);
            this.dtp_fromdate.TabIndex = 30;
            // 
            // TransactionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(614, 435);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_todate);
            this.Controls.Add(this.dtp_fromdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TransactionReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransactionReport";
            this.Load += new System.EventHandler(this.TransactionReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_todate;
        private System.Windows.Forms.DateTimePicker dtp_fromdate;
    }
}