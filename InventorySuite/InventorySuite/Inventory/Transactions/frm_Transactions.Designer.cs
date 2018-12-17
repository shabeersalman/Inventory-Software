namespace InventorySuite.Inventory.Transactions
{
    partial class frm_Transactions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Transactions));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvtrans = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gross = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblnetAmount = new System.Windows.Forms.Label();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtNetAmount = new System.Windows.Forms.TextBox();
            this.pnlbottom = new System.Windows.Forms.Panel();
            this.lblReturnAmount = new System.Windows.Forms.Label();
            this.lblCashpaid = new System.Windows.Forms.Label();
            this.txtReturn = new System.Windows.Forms.TextBox();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.pnltop = new System.Windows.Forms.Panel();
            this.cbVoucher = new System.Windows.Forms.CheckBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.lblMob = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtcustdeaMobile = new System.Windows.Forms.TextBox();
            this.txtcustdeaAddress = new System.Windows.Forms.TextBox();
            this.txtcustdeaName = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.dtptransdate = new System.Windows.Forms.DateTimePicker();
            this.txtvoucher = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblvoucherNo = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.dgvproductlist = new System.Windows.Forms.DataGridView();
            this.pnldgv = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtrans)).BeginInit();
            this.pnlbottom.SuspendLayout();
            this.pnltop.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductlist)).BeginInit();
            this.pnldgv.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvtrans
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            this.dgvtrans.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvtrans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Barcode,
            this.Product,
            this.MBarcode,
            this.Qty,
            this.UnitPrice,
            this.Gross,
            this.Discount,
            this.Total,
            this.SalePrice,
            this.ProductID,
            this.Stock});
            this.dgvtrans.Location = new System.Drawing.Point(0, 152);
            this.dgvtrans.Margin = new System.Windows.Forms.Padding(4);
            this.dgvtrans.Name = "dgvtrans";
            this.dgvtrans.Size = new System.Drawing.Size(1346, 537);
            this.dgvtrans.TabIndex = 3;
            this.dgvtrans.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtrans_CellEnter);
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.Width = 80;
            // 
            // Barcode
            // 
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.Name = "Barcode";
            this.Barcode.Width = 80;
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.Width = 250;
            // 
            // MBarcode
            // 
            this.MBarcode.HeaderText = "MBarcode";
            this.MBarcode.Name = "MBarcode";
            this.MBarcode.Width = 80;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.Width = 80;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Width = 80;
            // 
            // Gross
            // 
            this.Gross.HeaderText = "Gross";
            this.Gross.Name = "Gross";
            this.Gross.Width = 80;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.Width = 80;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.Width = 80;
            // 
            // SalePrice
            // 
            this.SalePrice.HeaderText = "SalePrice";
            this.SalePrice.Name = "SalePrice";
            this.SalePrice.Width = 80;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.Visible = false;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 80;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.ForeColor = System.Drawing.Color.Red;
            this.lblGrandTotal.Location = new System.Drawing.Point(908, 105);
            this.lblGrandTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(159, 30);
            this.lblGrandTotal.TabIndex = 14;
            this.lblGrandTotal.Text = "Grand Total";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(971, 63);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(77, 23);
            this.lblDiscount.TabIndex = 13;
            this.lblDiscount.Text = "Discount";
            // 
            // lblnetAmount
            // 
            this.lblnetAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnetAmount.Location = new System.Drawing.Point(945, 22);
            this.lblnetAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnetAmount.Name = "lblnetAmount";
            this.lblnetAmount.Size = new System.Drawing.Size(122, 26);
            this.lblnetAmount.TabIndex = 5;
            this.lblnetAmount.Text = "Net Amount";
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Enabled = false;
            this.txtGrandTotal.Location = new System.Drawing.Point(1083, 105);
            this.txtGrandTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtGrandTotal.Multiline = true;
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.ReadOnly = true;
            this.txtGrandTotal.Size = new System.Drawing.Size(228, 34);
            this.txtGrandTotal.TabIndex = 2;
            this.txtGrandTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Formasterentries_KeyPress);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(1083, 65);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(228, 22);
            this.txtDiscount.TabIndex = 1;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            this.txtDiscount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDiscount_KeyDown);
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Formasterentries_KeyPress);
            // 
            // txtNetAmount
            // 
            this.txtNetAmount.Enabled = false;
            this.txtNetAmount.Location = new System.Drawing.Point(1083, 22);
            this.txtNetAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtNetAmount.Name = "txtNetAmount";
            this.txtNetAmount.ReadOnly = true;
            this.txtNetAmount.Size = new System.Drawing.Size(228, 22);
            this.txtNetAmount.TabIndex = 0;
            this.txtNetAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Formasterentries_KeyPress);
            // 
            // pnlbottom
            // 
            this.pnlbottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlbottom.Controls.Add(this.lblReturnAmount);
            this.pnlbottom.Controls.Add(this.lblCashpaid);
            this.pnlbottom.Controls.Add(this.txtReturn);
            this.pnlbottom.Controls.Add(this.txtPaidAmount);
            this.pnlbottom.Controls.Add(this.lblGrandTotal);
            this.pnlbottom.Controls.Add(this.lblDiscount);
            this.pnlbottom.Controls.Add(this.lblnetAmount);
            this.pnlbottom.Controls.Add(this.txtGrandTotal);
            this.pnlbottom.Controls.Add(this.txtDiscount);
            this.pnlbottom.Controls.Add(this.txtNetAmount);
            this.pnlbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlbottom.Location = new System.Drawing.Point(0, 539);
            this.pnlbottom.Margin = new System.Windows.Forms.Padding(4);
            this.pnlbottom.Name = "pnlbottom";
            this.pnlbottom.Size = new System.Drawing.Size(1346, 150);
            this.pnlbottom.TabIndex = 1;
            this.pnlbottom.TabStop = true;
            // 
            // lblReturnAmount
            // 
            this.lblReturnAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnAmount.Location = new System.Drawing.Point(449, 86);
            this.lblReturnAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReturnAmount.Name = "lblReturnAmount";
            this.lblReturnAmount.Size = new System.Drawing.Size(142, 32);
            this.lblReturnAmount.TabIndex = 18;
            this.lblReturnAmount.Text = "Return Amount";
            // 
            // lblCashpaid
            // 
            this.lblCashpaid.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashpaid.ForeColor = System.Drawing.Color.Red;
            this.lblCashpaid.Location = new System.Drawing.Point(490, 43);
            this.lblCashpaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCashpaid.Name = "lblCashpaid";
            this.lblCashpaid.Size = new System.Drawing.Size(97, 22);
            this.lblCashpaid.TabIndex = 17;
            this.lblCashpaid.Text = "Cash Paid";
            // 
            // txtReturn
            // 
            this.txtReturn.Enabled = false;
            this.txtReturn.Location = new System.Drawing.Point(600, 86);
            this.txtReturn.Margin = new System.Windows.Forms.Padding(4);
            this.txtReturn.Name = "txtReturn";
            this.txtReturn.Size = new System.Drawing.Size(228, 22);
            this.txtReturn.TabIndex = 4;
            this.txtReturn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Formasterentries_KeyPress);
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Location = new System.Drawing.Point(600, 45);
            this.txtPaidAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(228, 22);
            this.txtPaidAmount.TabIndex = 3;
            this.txtPaidAmount.TextChanged += new System.EventHandler(this.txtPaidAmount_TextChanged);
            this.txtPaidAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Formasterentries_KeyPress);
            // 
            // pnltop
            // 
            this.pnltop.Controls.Add(this.cbVoucher);
            this.pnltop.Controls.Add(this.btnDown);
            this.pnltop.Controls.Add(this.btnUp);
            this.pnltop.Controls.Add(this.lblMob);
            this.pnltop.Controls.Add(this.lblAddress);
            this.pnltop.Controls.Add(this.lblName);
            this.pnltop.Controls.Add(this.txtcustdeaMobile);
            this.pnltop.Controls.Add(this.txtcustdeaAddress);
            this.pnltop.Controls.Add(this.txtcustdeaName);
            this.pnltop.Controls.Add(this.toolStrip1);
            this.pnltop.Controls.Add(this.dtptransdate);
            this.pnltop.Controls.Add(this.txtvoucher);
            this.pnltop.Controls.Add(this.lblDate);
            this.pnltop.Controls.Add(this.lblvoucherNo);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Margin = new System.Windows.Forms.Padding(4);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(1346, 152);
            this.pnltop.TabIndex = 0;
            this.pnltop.TabStop = true;
            // 
            // cbVoucher
            // 
            this.cbVoucher.Location = new System.Drawing.Point(16, 60);
            this.cbVoucher.Name = "cbVoucher";
            this.cbVoucher.Size = new System.Drawing.Size(25, 19);
            this.cbVoucher.TabIndex = 1;
            this.cbVoucher.UseVisualStyleBackColor = true;
            this.cbVoucher.CheckedChanged += new System.EventHandler(this.cbVoucher_CheckedChanged);
            // 
            // btnDown
            // 
            this.btnDown.Image = global::InventorySuite.Properties.Resources.if_arrow_down_01_186411;
            this.btnDown.Location = new System.Drawing.Point(136, 98);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(27, 18);
            this.btnDown.TabIndex = 3;
            this.btnDown.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Image = global::InventorySuite.Properties.Resources.if_arrow_up_01_186407;
            this.btnUp.Location = new System.Drawing.Point(136, 83);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(27, 18);
            this.btnUp.TabIndex = 2;
            this.btnUp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // lblMob
            // 
            this.lblMob.AutoSize = true;
            this.lblMob.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMob.Location = new System.Drawing.Point(1012, 120);
            this.lblMob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMob.Name = "lblMob";
            this.lblMob.Size = new System.Drawing.Size(74, 23);
            this.lblMob.TabIndex = 32;
            this.lblMob.Text = "Mob No";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(1012, 90);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(70, 23);
            this.lblAddress.TabIndex = 31;
            this.lblAddress.Text = "Address";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(1023, 58);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 23);
            this.lblName.TabIndex = 30;
            this.lblName.Text = "Name";
            // 
            // txtcustdeaMobile
            // 
            this.txtcustdeaMobile.Location = new System.Drawing.Point(1096, 123);
            this.txtcustdeaMobile.Margin = new System.Windows.Forms.Padding(4);
            this.txtcustdeaMobile.Name = "txtcustdeaMobile";
            this.txtcustdeaMobile.Size = new System.Drawing.Size(228, 22);
            this.txtcustdeaMobile.TabIndex = 7;
            this.txtcustdeaMobile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcustdeaMobile_KeyDown);
            // 
            // txtcustdeaAddress
            // 
            this.txtcustdeaAddress.Location = new System.Drawing.Point(1096, 91);
            this.txtcustdeaAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtcustdeaAddress.Name = "txtcustdeaAddress";
            this.txtcustdeaAddress.Size = new System.Drawing.Size(228, 22);
            this.txtcustdeaAddress.TabIndex = 6;
            this.txtcustdeaAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcustdeaAddress_KeyDown);
            // 
            // txtcustdeaName
            // 
            this.txtcustdeaName.Location = new System.Drawing.Point(1096, 59);
            this.txtcustdeaName.Margin = new System.Windows.Forms.Padding(4);
            this.txtcustdeaName.Name = "txtcustdeaName";
            this.txtcustdeaName.Size = new System.Drawing.Size(228, 22);
            this.txtcustdeaName.TabIndex = 5;
            this.txtcustdeaName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcustdeaName_KeyDown);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnEdit,
            this.btnDelete,
            this.btnClear,
            this.btnClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1346, 55);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = false;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 50);
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = false;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(60, 50);
            this.btnEdit.Text = "&Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = false;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 50);
            this.btnDelete.Text = "&Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = false;
            this.btnClear.Image = global::InventorySuite.Properties.Resources.symbol_delete;
            this.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 50);
            this.btnClear.Text = "&Clear";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = false;
            this.btnClose.Image = global::InventorySuite.Properties.Resources.if_Remove_27874;
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 50);
            this.btnClose.Text = "&Close";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dtptransdate
            // 
            this.dtptransdate.Enabled = false;
            this.dtptransdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtptransdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtptransdate.Location = new System.Drawing.Point(175, 85);
            this.dtptransdate.Margin = new System.Windows.Forms.Padding(4);
            this.dtptransdate.Name = "dtptransdate";
            this.dtptransdate.Size = new System.Drawing.Size(125, 22);
            this.dtptransdate.TabIndex = 4;
            // 
            // txtvoucher
            // 
            this.txtvoucher.Enabled = false;
            this.txtvoucher.Location = new System.Drawing.Point(18, 85);
            this.txtvoucher.Margin = new System.Windows.Forms.Padding(4);
            this.txtvoucher.Multiline = true;
            this.txtvoucher.Name = "txtvoucher";
            this.txtvoucher.Size = new System.Drawing.Size(113, 31);
            this.txtvoucher.TabIndex = 1;
            this.txtvoucher.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            this.txtvoucher.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtvoucher_KeyDown);
            this.txtvoucher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvoucher_KeyPress);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(171, 57);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(46, 23);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // lblvoucherNo
            // 
            this.lblvoucherNo.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvoucherNo.Location = new System.Drawing.Point(38, 58);
            this.lblvoucherNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvoucherNo.Name = "lblvoucherNo";
            this.lblvoucherNo.Size = new System.Drawing.Size(115, 19);
            this.lblvoucherNo.TabIndex = 2;
            this.lblvoucherNo.Text = "Voucher No";
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.Color.LightGray;
            this.txtData.Location = new System.Drawing.Point(155, 306);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(131, 22);
            this.txtData.TabIndex = 0;
            this.txtData.TextChanged += new System.EventHandler(this.txtData_TextChanged);
            this.txtData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtData_KeyDown);
            this.txtData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtData_KeyPress);
            // 
            // dgvproductlist
            // 
            this.dgvproductlist.AllowUserToAddRows = false;
            this.dgvproductlist.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue;
            this.dgvproductlist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvproductlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvproductlist.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvproductlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvproductlist.Location = new System.Drawing.Point(0, 0);
            this.dgvproductlist.Name = "dgvproductlist";
            this.dgvproductlist.ReadOnly = true;
            this.dgvproductlist.RowTemplate.Height = 24;
            this.dgvproductlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvproductlist.Size = new System.Drawing.Size(981, 280);
            this.dgvproductlist.TabIndex = 0;
            this.dgvproductlist.Visible = false;
            this.dgvproductlist.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvproductlist_KeyDown);
            // 
            // pnldgv
            // 
            this.pnldgv.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pnldgv.Controls.Add(this.dgvproductlist);
            this.pnldgv.Location = new System.Drawing.Point(165, 208);
            this.pnldgv.Name = "pnldgv";
            this.pnldgv.Size = new System.Drawing.Size(981, 280);
            this.pnldgv.TabIndex = 26;
            this.pnldgv.Visible = false;
            this.pnldgv.Resize += new System.EventHandler(this.pnldgv_Resize);
            // 
            // frm_Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 689);
            this.Controls.Add(this.pnlbottom);
            this.Controls.Add(this.pnldgv);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.dgvtrans);
            this.Controls.Add(this.pnltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Transactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.frm_Transactions_Load);
            this.Shown += new System.EventHandler(this.frm_Transactions_Shown);
            this.Resize += new System.EventHandler(this.frm_Transactions_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtrans)).EndInit();
            this.pnlbottom.ResumeLayout(false);
            this.pnlbottom.PerformLayout();
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproductlist)).EndInit();
            this.pnldgv.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtrans;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblnetAmount;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtNetAmount;
        private System.Windows.Forms.Panel pnlbottom;
        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.DateTimePicker dtptransdate;
        private System.Windows.Forms.TextBox txtvoucher;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblvoucherNo;
        private System.Windows.Forms.Label lblReturnAmount;
        private System.Windows.Forms.Label lblCashpaid;
        private System.Windows.Forms.TextBox txtReturn;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gross;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn MBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridView dgvproductlist;
        private System.Windows.Forms.Panel pnldgv;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.TextBox txtcustdeaName;
        private System.Windows.Forms.TextBox txtcustdeaAddress;
        private System.Windows.Forms.TextBox txtcustdeaMobile;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblMob;
        private System.Windows.Forms.ToolStripButton btnClear;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.CheckBox cbVoucher;
    }
}