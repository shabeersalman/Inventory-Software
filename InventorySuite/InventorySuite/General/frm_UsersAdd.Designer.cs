namespace InventorySuite.General
{
    partial class frm_UsersAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_UsersAdd));
            this.cb_Usertype = new System.Windows.Forms.ComboBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.lbl_UserType = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblhead = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblstar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_Usertype
            // 
            this.cb_Usertype.FormattingEnabled = true;
            this.cb_Usertype.Items.AddRange(new object[] {
            "Admin",
            "Limited"});
            this.cb_Usertype.Location = new System.Drawing.Point(143, 209);
            this.cb_Usertype.Name = "cb_Usertype";
            this.cb_Usertype.Size = new System.Drawing.Size(239, 24);
            this.cb_Usertype.TabIndex = 28;
            this.cb_Usertype.SelectedIndexChanged += new System.EventHandler(this.txt__TextChanged_);
            this.cb_Usertype.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_Usertype_KeyDown);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(143, 170);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(239, 22);
            this.txt_Password.TabIndex = 27;
            this.txt_Password.TextChanged += new System.EventHandler(this.txt__TextChanged_);
            this.txt_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Password_KeyDown);
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(143, 132);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(239, 22);
            this.txt_UserName.TabIndex = 26;
            this.txt_UserName.TextChanged += new System.EventHandler(this.txt__TextChanged_);
            this.txt_UserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_UserName_KeyDown);
            // 
            // lbl_UserType
            // 
            this.lbl_UserType.BackColor = System.Drawing.Color.Transparent;
            this.lbl_UserType.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserType.Location = new System.Drawing.Point(47, 209);
            this.lbl_UserType.Name = "lbl_UserType";
            this.lbl_UserType.Size = new System.Drawing.Size(78, 24);
            this.lbl_UserType.TabIndex = 25;
            this.lbl_UserType.Text = "User Type";
            // 
            // lbl_Password
            // 
            this.lbl_Password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Password.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(47, 172);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(78, 22);
            this.lbl_Password.TabIndex = 24;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_Username
            // 
            this.lbl_Username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Username.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(47, 134);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(83, 23);
            this.lbl_Username.TabIndex = 23;
            this.lbl_Username.Text = "Username";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblhead);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(466, 88);
            this.pnlHeader.TabIndex = 32;
            // 
            // lblhead
            // 
            this.lblhead.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhead.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblhead.Location = new System.Drawing.Point(165, 37);
            this.lblhead.Name = "lblhead";
            this.lblhead.Size = new System.Drawing.Size(139, 44);
            this.lblhead.TabIndex = 0;
            this.lblhead.Text = "Users";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btn_Save);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 88);
            this.panel1.TabIndex = 33;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Image = global::InventorySuite.Properties.Resources.if_Log_Out_27856;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(278, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 38);
            this.btnClose.TabIndex = 31;
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
            this.btn_Save.Location = new System.Drawing.Point(82, 18);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(90, 38);
            this.btn_Save.TabIndex = 29;
            this.btn_Save.Text = "Save";
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClear.Image = global::InventorySuite.Properties.Resources.if_denied_1055074;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(180, 18);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 38);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblstar
            // 
            this.lblstar.AutoSize = true;
            this.lblstar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstar.ForeColor = System.Drawing.Color.Red;
            this.lblstar.Location = new System.Drawing.Point(117, 137);
            this.lblstar.Name = "lblstar";
            this.lblstar.Size = new System.Drawing.Size(14, 17);
            this.lblstar.TabIndex = 34;
            this.lblstar.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(117, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(117, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "*";
            // 
            // frm_UsersAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 411);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblstar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.cb_Usertype);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.lbl_UserType);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_UsersAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.pnlHeader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox cb_Usertype;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label lbl_UserType;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblhead;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblstar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}