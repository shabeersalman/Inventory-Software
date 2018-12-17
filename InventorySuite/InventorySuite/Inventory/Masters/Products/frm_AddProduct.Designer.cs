namespace InventorySuite.Inventory.Masters.Products
{
    partial class frm_AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddProduct));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMbarcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbProductGroup = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductName1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblhead = new System.Windows.Forms.Label();
            this.btnAutomatic = new System.Windows.Forms.Button();
            this.cbPcode = new System.Windows.Forms.CheckBox();
            this.lblManual = new System.Windows.Forms.Label();
            this.btnAddProductGroup = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btn_Save);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 495);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(823, 76);
            this.panel2.TabIndex = 82;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Image = global::InventorySuite.Properties.Resources.if_Log_Out_27856;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(470, 24);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 38);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Save.Image = global::InventorySuite.Properties.Resources.if_floppy_285657;
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(272, 24);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(90, 38);
            this.btn_Save.TabIndex = 0;
            this.btn_Save.Text = "Save";
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClear.Image = global::InventorySuite.Properties.Resources.if_denied_1055074;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(372, 24);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 38);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(634, 13);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(176, 22);
            this.txtBarcode.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(542, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "Barcode";
            // 
            // txtStock
            // 
            this.txtStock.Enabled = false;
            this.txtStock.Location = new System.Drawing.Point(554, 212);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(230, 22);
            this.txtStock.TabIndex = 6;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ckeckentries_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(484, 216);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 80;
            this.label9.Text = "Stock";
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(554, 168);
            this.txtPurchasePrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(230, 22);
            this.txtPurchasePrice.TabIndex = 5;
            this.txtPurchasePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ckeckentries_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 171);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 78;
            this.label6.Text = "Purchase Price";
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(554, 124);
            this.txtSalePrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(230, 22);
            this.txtSalePrice.TabIndex = 4;
            this.txtSalePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ckeckentries_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(457, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 76;
            this.label7.Text = "Sale Price";
            // 
            // txtMbarcode
            // 
            this.txtMbarcode.Location = new System.Drawing.Point(150, 253);
            this.txtMbarcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtMbarcode.Name = "txtMbarcode";
            this.txtMbarcode.Size = new System.Drawing.Size(230, 22);
            this.txtMbarcode.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 253);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 74;
            this.label4.Text = "M.BarCode";
            // 
            // cbProductGroup
            // 
            this.cbProductGroup.FormattingEnabled = true;
            this.cbProductGroup.Location = new System.Drawing.Point(150, 206);
            this.cbProductGroup.Margin = new System.Windows.Forms.Padding(4);
            this.cbProductGroup.Name = "cbProductGroup";
            this.cbProductGroup.Size = new System.Drawing.Size(195, 24);
            this.cbProductGroup.TabIndex = 2;
            this.cbProductGroup.DropDown += new System.EventHandler(this.cbProductGroup_DropDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 72;
            this.label3.Text = "Products Group";
            // 
            // txtProductName1
            // 
            this.txtProductName1.Location = new System.Drawing.Point(150, 162);
            this.txtProductName1.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName1.Name = "txtProductName1";
            this.txtProductName1.Size = new System.Drawing.Size(230, 22);
            this.txtProductName1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 70;
            this.label2.Text = "Product Name ";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Enabled = false;
            this.txtProductCode.Location = new System.Drawing.Point(150, 118);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(99, 22);
            this.txtProductCode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 68;
            this.label1.Text = "Product Code";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblhead);
            this.panel1.Controls.Add(this.txtBarcode);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 84);
            this.panel1.TabIndex = 89;
            // 
            // lblhead
            // 
            this.lblhead.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhead.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblhead.Location = new System.Drawing.Point(313, 31);
            this.lblhead.Name = "lblhead";
            this.lblhead.Size = new System.Drawing.Size(159, 44);
            this.lblhead.TabIndex = 83;
            this.lblhead.Text = "Products";
            // 
            // btnAutomatic
            // 
            this.btnAutomatic.Location = new System.Drawing.Point(254, 118);
            this.btnAutomatic.Name = "btnAutomatic";
            this.btnAutomatic.Size = new System.Drawing.Size(22, 25);
            this.btnAutomatic.TabIndex = 83;
            this.btnAutomatic.Text = "O";
            this.btnAutomatic.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAutomatic.UseVisualStyleBackColor = true;
            this.btnAutomatic.Click += new System.EventHandler(this.btnAutomatic_Click);
            // 
            // cbPcode
            // 
            this.cbPcode.Location = new System.Drawing.Point(287, 121);
            this.cbPcode.Name = "cbPcode";
            this.cbPcode.Size = new System.Drawing.Size(25, 19);
            this.cbPcode.TabIndex = 84;
            this.cbPcode.UseVisualStyleBackColor = true;
            this.cbPcode.CheckedChanged += new System.EventHandler(this.cbPcode_CheckedChanged);
            // 
            // lblManual
            // 
            this.lblManual.AutoSize = true;
            this.lblManual.Location = new System.Drawing.Point(306, 121);
            this.lblManual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblManual.Name = "lblManual";
            this.lblManual.Size = new System.Drawing.Size(54, 17);
            this.lblManual.TabIndex = 85;
            this.lblManual.Text = "Manual";
            // 
            // btnAddProductGroup
            // 
            this.btnAddProductGroup.Location = new System.Drawing.Point(352, 207);
            this.btnAddProductGroup.Name = "btnAddProductGroup";
            this.btnAddProductGroup.Size = new System.Drawing.Size(22, 25);
            this.btnAddProductGroup.TabIndex = 103;
            this.btnAddProductGroup.Text = "G";
            this.btnAddProductGroup.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddProductGroup.UseVisualStyleBackColor = true;
            this.btnAddProductGroup.Click += new System.EventHandler(this.btnAddProductGroup_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(14, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 17);
            this.label8.TabIndex = 104;
            this.label8.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(7, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 17);
            this.label10.TabIndex = 105;
            this.label10.Text = "*";
            // 
            // frm_AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 571);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAddProductGroup);
            this.Controls.Add(this.lblManual);
            this.Controls.Add(this.cbPcode);
            this.Controls.Add(this.btnAutomatic);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPurchasePrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSalePrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMbarcode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbProductGroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductName1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frm_AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_AddProduct_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMbarcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbProductGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductName1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblhead;
        private System.Windows.Forms.Button btnAutomatic;
        private System.Windows.Forms.CheckBox cbPcode;
        private System.Windows.Forms.Label lblManual;
        private System.Windows.Forms.Button btnAddProductGroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
    }
}