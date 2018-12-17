using InventorySuite.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventorySuite.Inventory.Transactions
{
    public partial class frm_Transactions : Form 
    {
        transactiondetails td = new transactiondetails();
        transactionmaster tm = new transactionmaster();
        Masters.Products.ProductView p = new Masters.Products.ProductView();
        string TransactionType = frm_MainDashboard.Transactiontype;
       

        public frm_Transactions()
        {
            InitializeComponent();
            btnSave.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            loadvoucher();
            dgvtrans.Rows.Add(60);
          
        }
  

        public void loadvoucher()
        {

            tm.TransactionType = TransactionType;
            DataSet ds = tm.LoadVoucherNo();
            if (ds.Tables[0].Rows.Count > 0)
            {
                txtvoucher.Text = ds.Tables[0].Rows[0][0].ToString();

            }
      
        }
    

        public void LoadProductList()
        {
            
         
            p.ProductName = txtData.Text;
            DataSet ds = p.LoadProductList();
            if (ds.Tables[0].Rows.Count > 0)
            {
                dgvproductlist.DataSource = ds.Tables[0];
                dgvproductlist.Visible = true;
                pnldgv.Visible = true;
                dgvproductlist.Columns["ProductID"].Visible = false;
                // pnldgv.Top = dgvtrans.Top + dgvtrans.GetCellDisplayRectangle(dgvtrans.CurrentCell.ColumnIndex, dgvtrans.CurrentCell.RowIndex, true).Bottom;
                //   pnldgv.Left = dgvtrans.GetCellDisplayRectangle(dgvtrans.CurrentCell.ColumnIndex, dgvproductlist.CurrentCell.RowIndex, true).Left;

                pnldgv.Left = dgvtrans.Left + dgvtrans.GetCellDisplayRectangle(dgvtrans.CurrentCell.ColumnIndex, dgvtrans.CurrentCell.RowIndex, true).Left;
                pnldgv.Top = dgvtrans.Top + dgvtrans.GetCellDisplayRectangle(dgvtrans.CurrentCell.ColumnIndex, dgvtrans.CurrentCell.RowIndex, true).Top + txtData.Height + 3;

            }
            pnldgv.BringToFront();
            txtData.Focus();
        }
        void LoadProductDetails()
        {

            try {
                // td.pcode = Convert.ToInt32("0" + txtData.Text);
                td.pcode = Convert.ToInt32("0" + dgvtrans.CurrentRow.Cells["Code"].FormattedValue.ToString());

                DataSet ds = td.SelecInvdetails();
                pnldgv.Visible = false;
                dgvproductlist.Visible = false;


                if (ds.Tables[0].Rows.Count > 0)

                {


                    dgvtrans.CurrentRow.Cells["Barcode"].Value = ds.Tables[0].Rows[0]["Barcode"].ToString();
                    dgvtrans.CurrentRow.Cells["Code"].Value = ds.Tables[0].Rows[0]["ProductCode"].ToString();
                    dgvtrans.CurrentRow.Cells["Product"].Value = ds.Tables[0].Rows[0]["ProductName"].ToString();
                    dgvtrans.CurrentRow.Cells["MBarcode"].Value = ds.Tables[0].Rows[0]["ManualBarcode"].ToString();
                    dgvtrans.CurrentRow.Cells["Qty"].Value = 0.00;// ds.Tables[0].Rows[0]["TotalQTY"].ToString();
                    if (TransactionType == "Purchase" || TransactionType == "PurchaseReturn"|| TransactionType=="PO"|| TransactionType == "PRO")
                    {
                        dgvtrans.CurrentRow.Cells["UnitPrice"].Value = ds.Tables[0].Rows[0]["PurchasePrice"].ToString();
                        dgvtrans.CurrentRow.Cells["SalePrice"].Value = ds.Tables[0].Rows[0]["SalePrice"].ToString();
                    }
                    else if(TransactionType == "Sales" || TransactionType == "PurchaseReturn" || TransactionType == "SO" || TransactionType == "SRO")
                    {
                        dgvtrans.CurrentRow.Cells["UnitPrice"].Value = ds.Tables[0].Rows[0]["SalePrice"].ToString();
                        dgvtrans.Columns["SalePrice"].Visible = false;
                    }
                  
                    dgvtrans.CurrentRow.Cells["Gross"].Value = 0.00;// ds.Tables[0].Rows[0]["TotalGross"].ToString();
                    dgvtrans.CurrentRow.Cells["Discount"].Value = 0.00;//ds.Tables[0].Rows[0]["TotalDiscount"].ToString();
                    dgvtrans.CurrentRow.Cells["Total"].Value = 0.00;// ds.Tables[0].Rows[0]["NetTotal"].ToString();
                    dgvtrans.CurrentRow.Cells["ProductID"].Value = ds.Tables[0].Rows[0]["ProductID"].ToString();
                    dgvtrans.CurrentRow.Cells["Stock"].Value = ds.Tables[0].Rows[0]["Stock"].ToString();

                    dgvtrans.CurrentCell = dgvtrans["Qty", dgvtrans.CurrentRow.Index];

                    btnSave.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                  


                }
                else
                {
                    txtData.Text = "";
                }
            }
            catch(Exception ex)
            {
                txtData.Text = "";
            }

        }
        private void txtData_KeyDown(object sender, KeyEventArgs e)
        {

                 if(e.KeyCode==Keys.Escape)
                {
                  pnldgv.Visible = false;
                 
                  }
              


                if (e.KeyCode == Keys.Right && dgvtrans.Columns[dgvtrans.CurrentCell.ColumnIndex].Visible == true)
                {
                    if (dgvtrans.Columns[dgvtrans.CurrentCell.ColumnIndex].Name != "SalePrice" && dgvtrans.Columns[dgvtrans.CurrentCell.ColumnIndex].Name != "Stock")
                    {
                        dgvtrans.CurrentCell = dgvtrans[dgvtrans.CurrentCell.ColumnIndex + 1, dgvtrans.CurrentRow.Index];
                    }
                    else
                    {


                    }
                }
                else if (e.KeyCode == Keys.Left)
                {
                    if (dgvtrans.CurrentCell.ColumnIndex > 0)
                        dgvtrans.CurrentCell = dgvtrans[dgvtrans.CurrentCell.ColumnIndex - 1, dgvtrans.CurrentRow.Index];
                }



                if (e.KeyCode == Keys.Down)
                {

                    if (pnldgv.Visible)
                    {
                        dgvproductlist.Focus();
                    }

                    else if (dgvtrans.CurrentRow.Index < 60)
                    {

                        if (dgvtrans.Columns[dgvtrans.CurrentCell.ColumnIndex].Name == "Barcode")
                        {
                            dgvtrans.CurrentCell = dgvtrans["Barcode", dgvtrans.CurrentRow.Index + 1];
                        }
                        else if (dgvtrans.Columns[dgvtrans.CurrentCell.ColumnIndex].Name == "Qty")
                        {
                            dgvtrans.CurrentCell = dgvtrans["Qty", dgvtrans.CurrentRow.Index + 1];
                        }
                        else if (dgvtrans.Columns[dgvtrans.CurrentCell.ColumnIndex].Name == "Code")
                        {
                            dgvtrans.CurrentCell = dgvtrans["Code", dgvtrans.CurrentRow.Index + 1];
                        }
                    }
                }
                if (e.KeyCode == Keys.Up)
                {

                    if (dgvtrans.CurrentRow.Index > 0)
                    {

                        if (dgvtrans.Columns[dgvtrans.CurrentCell.ColumnIndex].Name == "Barcode")
                        {
                            dgvtrans.CurrentCell = dgvtrans["Barcode", dgvtrans.CurrentRow.Index - 1];
                        }
                        else if (dgvtrans.Columns[dgvtrans.CurrentCell.ColumnIndex].Name == "Qty")
                        {
                            dgvtrans.CurrentCell = dgvtrans["Qty", dgvtrans.CurrentRow.Index - 1];
                        }
                        else if (dgvtrans.Columns[dgvtrans.CurrentCell.ColumnIndex].Name == "Code")
                        {
                            dgvtrans.CurrentCell = dgvtrans["Code", dgvtrans.CurrentRow.Index - 1];
                        }

                    }
                }


                if (e.KeyCode == Keys.Enter)
                {


                  if (dgvtrans.Columns[dgvtrans.CurrentCell.ColumnIndex].Name == "Barcode")
                    {
                    
                        dgvtrans.CurrentRow.Cells["Code"].Value = txtData.Text;
                      
                    LoadProductDetails();
                    }
                    else if (dgvtrans.Columns[dgvtrans.CurrentCell.ColumnIndex].Name == "Code")
                    {
                        dgvtrans.CurrentCell.Value = txtData.Text;
                        LoadProductDetails();
                    }
                    else if (dgvtrans.Columns[dgvtrans.CurrentCell.ColumnIndex].Name == "Product")
                    {
                        try {
                            if (pnldgv.Visible)
                            {
                                dgvtrans.CurrentRow.Cells["Code"].Value = dgvproductlist.Rows[0].Cells["ProductCode"].Value.ToString();
                                LoadProductDetails();

                            }
                        } catch (Exception ex)
                        {

                        }

                    }
                    else if (dgvtrans.Columns[dgvtrans.CurrentCell.ColumnIndex].Name == "Qty")
                    {
                        dgvtrans.CurrentCell = dgvtrans["Code", dgvtrans.CurrentRow.Index + 1];
                    }

              
                }
                else
                {

                }
            

            }
        
        public void gross()
        {


            try
            {
                double qty1 = 0.00;
                double unitPrice;

                qty1 = double.Parse("0" + dgvtrans.CurrentRow.Cells["Qty"].Value.ToString());
                unitPrice = double.Parse("0" + dgvtrans.CurrentRow.Cells["UnitPrice"].Value.ToString());
                dgvtrans.CurrentRow.Cells["Gross"].Value = (qty1 * unitPrice).ToString();
                dgvtrans.CurrentRow.Cells["Total"].Value = (qty1 * unitPrice).ToString();



            }
            catch (Exception ex)
            {

            }
        }
        public void discount()
        {

            try {
                double discount;
                double gross;



                discount = double.Parse("0" + dgvtrans.CurrentRow.Cells["Discount"].Value.ToString());
                gross = double.Parse(dgvtrans.CurrentRow.Cells["Gross"].Value.ToString());
                dgvtrans.CurrentRow.Cells["Total"].Value = (gross - discount).ToString();
            }
            catch (Exception ex)
            {
            }
        }
        public void NetAmount()
        {

            try {
                double Netamount = 0;
                int i;
                int noOfRows = dgvtrans.Rows.Count - 1;
                for (i = 0; i <= noOfRows; i++)
                {
                    if (dgvtrans.Rows[i].Cells["Total"].Value != null)
                    {
                        Netamount = Netamount + double.Parse("0" + dgvtrans.Rows[i].Cells["Total"].Value.ToString());
                    }
                }
                txtNetAmount.Text = Netamount.ToString();
                txtGrandTotal.Text = Netamount.ToString();
            }catch(Exception ex)
            {

            }
        }
        private void dgvtrans_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           if (dgvtrans.Columns[dgvtrans.CurrentCell.ColumnIndex].Name != "product")
           {
               dgvproductlist.Visible = false;
                pnldgv.Visible = false;

           }


            switch (dgvtrans.Columns[dgvtrans.CurrentCell.ColumnIndex].Name)
            {
                case "Barcode":
                case "Code":
                case "Product":
                case "Qty":
                case "UnitPrice":
                case "Discount":
                case "SalePrice":

                  DataGridViewCell cell1 = dgvtrans.Rows[dgvtrans.CurrentCell.RowIndex].Cells[dgvtrans.CurrentCell.ColumnIndex];
                  txtData.Left = dgvtrans.Left + dgvtrans.GetCellDisplayRectangle(dgvtrans.CurrentCell.ColumnIndex, dgvtrans.CurrentCell.RowIndex, true).Left;
                  txtData.Top = dgvtrans.Top + dgvtrans.GetCellDisplayRectangle(dgvtrans.CurrentCell.ColumnIndex, dgvtrans.CurrentCell.RowIndex, true).Top;
                  txtData.MinimumSize = new System.Drawing.Size(dgvtrans.GetCellDisplayRectangle(dgvtrans.CurrentCell.ColumnIndex, dgvtrans.CurrentCell.RowIndex, true).Width - 1, dgvtrans.GetCellDisplayRectangle(dgvtrans.CurrentCell.ColumnIndex, dgvtrans.CurrentCell.RowIndex, true).Height - 1);
                  txtData.Width = dgvtrans.GetCellDisplayRectangle(dgvtrans.CurrentCell.ColumnIndex, dgvtrans.CurrentCell.RowIndex, false).Width - 1;
                  txtData.Height = dgvtrans.GetCellDisplayRectangle(dgvtrans.CurrentCell.ColumnIndex, dgvtrans.CurrentCell.RowIndex, false).Height - 1;
                   txtData.Visible = true;

                    if (cell1.Value != null)
                    {
                        txtData.Text = cell1.Value.ToString();
                    }
                    else
                    {

                        txtData.Text = "";
                    }
                    txtData.BringToFront();
                    txtData.SelectAll();
                    txtData.Focus();
                    break;
            }
        }
        
        private void txtData_TextChanged(object sender, EventArgs e)
        {
            
            if (txtData.Text != "")
            {
                switch (dgvtrans.Columns[dgvtrans.CurrentCell.ColumnIndex].Name)
                {

                    case "Qty":
                    case "UnitPrice":
                    case "Discount":              
                        dgvtrans.CurrentCell.Value = txtData.Text;

                        gross();
                        discount();
                        NetAmount();
                        break;
                    case "Product":
                        dgvtrans.CurrentCell.Value = txtData.Text;
                          LoadProductList();
             
                        break;
                }
            }
            else
            {
                pnldgv.Visible = false;

            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {

            double discount = 0;
            double NetAmount;

            if (txtDiscount.Text != "")
            {

                discount = double.Parse("0"+txtDiscount.Text);
                NetAmount = double.Parse("0"+txtNetAmount.Text);
                txtGrandTotal.Text = (NetAmount - discount).ToString();
            }
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtPaidAmount.Text != "")
            {
                double PaidAmount = double.Parse("0"+txtPaidAmount.Text);
                double GrandTotal = double.Parse("0"+txtGrandTotal.Text);

                txtReturn.Text = (PaidAmount - GrandTotal).ToString();
            }
        }

        private void frm_Transactions_Load(object sender, EventArgs e)
        {
            string TransactionType = frm_MainDashboard.Transactiontype;
            this.Text = TransactionType;
           

        }
        //---------------------------save--------------------
        int TransID;
        private void btnSave_Click(object sender, EventArgs e)
        {

        
        int ID = 0;
        
            bool y = false;
            DateTime dt = this.dtptransdate.Value.Date;
            tm.TransactionDate = dt;
            tm.TransactionType = frm_MainDashboard.Transactiontype;
            tm.VoucherNumber = Convert.ToInt32(txtvoucher.Text);
            tm.PartyName = txtcustdeaName.Text;
            tm.Address1 = txtcustdeaAddress.Text;
            tm.Mob = txtcustdeaMobile.Text;
            tm.TotalGross = Convert.ToDecimal(txtNetAmount.Text);
            tm.TotalDiscount = Convert.ToDecimal("0"+txtDiscount.Text);
            tm.GrandTotal = Convert.ToDecimal(txtGrandTotal.Text);
            tm.PaidAmount = Convert.ToDecimal("0"+txtPaidAmount.Text);

            if (isEdit == false)
            {
                ID = tm.Save();
            }
            else
            {
                tm.InvTransactionMasterID = tmid;
                tm.Setisactiveornot();
                //stock in, stock out
                //update stock//



                ID = tm.SAVEFOREDIT();

            }
            if (ID > 0)
            {
               // MessageBox.Show("success");

                for (int i = 0; i <= dgvtrans.Rows.Count; i++)
                {
                    
                    if (dgvtrans.Rows[i].Cells["ProductID"].FormattedValue.ToString() == "") break;
                    td.InvTransactionMasterID = ID;
                    td.ProductID = Convert.ToInt32(dgvtrans.Rows[i].Cells["ProductID"].Value.ToString());
                    td.TotalQTY = Convert.ToDecimal(dgvtrans.Rows[i].Cells["Qty"].Value.ToString());
                    td.Price = Convert.ToDecimal(dgvtrans.Rows[i].Cells["UnitPrice"].Value.ToString());
                    td.TotalGross = Convert.ToDecimal(dgvtrans.Rows[i].Cells["Gross"].Value.ToString());
                    td.TotalDiscount = Convert.ToDecimal(dgvtrans.Rows[i].Cells["Discount"].Value.ToString());
                    td.NetTotal = Convert.ToDecimal(dgvtrans.Rows[i].Cells["Total"].Value.ToString());
                   
                    if (TransactionType == "SalesReturn" || TransactionType == "Purchase")
                    {
                        td.ProductID = Convert.ToInt32(dgvtrans.Rows[i].Cells["ProductID"].Value.ToString());
                        //td.TotalQTY = Convert.ToDecimal(dgvtrans.Rows[i].Cells["Qty"].Value.ToString());
                        td.StockIn = Convert.ToDouble(dgvtrans.Rows[i].Cells["Qty"].Value.ToString());
                        td.StockOut = 0;
                        TransID = td.UpdateStockInProduts();
                       // TransID = td.UpdateStockTrasnDetails();
                    }
                    else if(TransactionType == "Sales" || TransactionType == "PurchaseReturn")
                    {
                        td.ProductID = Convert.ToInt32(dgvtrans.Rows[i].Cells["ProductID"].Value.ToString());
                        //td.TotalQTY = Convert.ToDecimal(dgvtrans.Rows[i].Cells["Qty"].Value.ToString());
                        td.StockOut =  Convert.ToDouble(dgvtrans.Rows[i].Cells["Qty"].Value.ToString());
                        td.StockIn = 0;
                        TransID = td.UpdateStockInProduts();
                        //TransID = td.UpdateStockTrasnDetails();
                    }
                    else
                    {
                        dgvtrans.Columns["Stock"].Visible = false;
                        td.StockOut = 0;
                        td.StockIn = 0;

                    }
                   int  TransID1 = td.Save();// saved invdetails

                    if (TransID > 0 && TransID1 > 0)
                    {
                        y = true;

                    }
                }
                int RefreshStock = td.RefreshStock();
                if (RefreshStock > 0 && y==true  )
                {
                    
                    clearcontrols(true);
                    //btnSave.Enabled = false;
                    //btnEdit.Enabled = true;
                    //btnDelete.Enabled = true;
                }

                clearcontrols(true);
            }
        }


       
        public void clearcontrols(bool UpdateVchNo=true)
        {
            pnldgv.Visible = false;
            dgvproductlist.Visible = false;
            dgvtrans.DataSource = null;
            dgvtrans.Rows.Clear();
            txtcustdeaAddress.Text = txtcustdeaName.Text = txtcustdeaMobile.Text = txtNetAmount.Text = txtDiscount.Text = txtGrandTotal.Text = txtPaidAmount.Text = txtReturn.Text = "";
            txtData.Text = "";
            btnSave.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            dgvtrans.Rows.Add(60);
            if (UpdateVchNo)
            {
                txtvoucher.Text = "";
                loadvoucher();
              
           }


        }


        //-----------   EDIT SECTION-----------------------------------------------------------------------------------------------------------


        int tmid;

        public void LoadetailForEDIT()
        {
            try
            {
              

                tm.TransactionType = frm_MainDashboard.Transactiontype;
                DataSet ds = tm.LoadEditDetails();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtcustdeaAddress.Text = ds.Tables[0].Rows[0]["Address1"].ToString();
                    txtcustdeaMobile.Text = ds.Tables[0].Rows[0]["Mob"].ToString();
                    txtcustdeaName.Text = ds.Tables[0].Rows[0]["PartyName"].ToString();
                    dtptransdate.Value = Convert.ToDateTime(ds.Tables[0].Rows[0]["TransactionDate"].ToString());
                    txtNetAmount.Text = ds.Tables[0].Rows[0]["mTotalGross"].ToString();
                    txtDiscount.Text = ds.Tables[0].Rows[0]["mTotalDiscount"].ToString();
                    txtGrandTotal.Text = ds.Tables[0].Rows[0]["mGrandTotal"].ToString();
                    txtPaidAmount.Text = ds.Tables[0].Rows[0]["PaidAmount"].ToString();
                    tmid = Convert.ToInt32(ds.Tables[0].Rows[0]["InvTransactionMasterID"].ToString());

         
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        for (int i = 0; i < ds.Tables[1].Rows.Count; i++)
                        {
                            dgvtrans.Rows[i].Cells["Barcode"].Value = ds.Tables[1].Rows[i]["Barcode"].ToString();
                            dgvtrans.Rows[i].Cells["Code"].Value = ds.Tables[1].Rows[i]["ProductCode"].ToString();
                            dgvtrans.Rows[i].Cells["Product"].Value = ds.Tables[1].Rows[i]["ProductName"].ToString();
                            dgvtrans.Rows[i].Cells["MBarcode"].Value = ds.Tables[1].Rows[i]["ManualBarcode"].ToString();
                            dgvtrans.Rows[i].Cells["Qty"].Value = ds.Tables[1].Rows[i]["TotalQTY"].ToString();
                            dgvtrans.Rows[i].Cells["UnitPrice"].Value = ds.Tables[1].Rows[i]["PurchasePrice"].ToString();
                            dgvtrans.Rows[i].Cells["Gross"].Value = ds.Tables[1].Rows[i]["TotalGross"].ToString();
                            dgvtrans.Rows[i].Cells["Discount"].Value = ds.Tables[1].Rows[i]["TotalDiscount"].ToString();
                            dgvtrans.Rows[i].Cells["Total"].Value = ds.Tables[1].Rows[i]["NetTotal"].ToString();
                            dgvtrans.Rows[i].Cells["SalePrice"].Value = ds.Tables[1].Rows[i]["SalePrice"].ToString();
                            dgvtrans.Rows[i].Cells["Stock"].Value = ds.Tables[1].Rows[i]["Stock"].ToString();
                            dgvtrans.Rows[i].Cells["ProductID"].Value = ds.Tables[1].Rows[i]["ProductID"].ToString();

                        }
                        txtData.Visible = false;
                        btnSave.Enabled = false;
                        btnEdit.Enabled = btnDelete.Enabled = true;
                        txtcustdeaAddress.Enabled = txtcustdeaMobile.Enabled = txtcustdeaName.Enabled = txtGrandTotal.Enabled = txtNetAmount.Enabled = txtDiscount.Enabled = txtPaidAmount.Enabled = txtReturn.Enabled = false;
                    }
                    else
                    {
                        

                    }
                }
                else
                {

                    clearcontrols(false);


                }
            }
            
            catch (Exception ex)
            {


            }

        }

        bool isEdit = false;
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnEdit.Enabled = btnDelete.Enabled = false;
            txtcustdeaAddress.Enabled = txtcustdeaMobile.Enabled = txtcustdeaName.Enabled = txtGrandTotal.Enabled = txtNetAmount.Enabled = txtDiscount.Enabled = txtPaidAmount.Enabled = txtReturn.Enabled = true;
            isEdit = true;
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            clearcontrols(true);
        }

        private void txtvoucher_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = false;
                e.SuppressKeyPress = true;
                tm.VoucherNumber = Convert.ToInt32(txtvoucher.Text);
                LoadetailForEDIT();

            }

        }

//-------------KEY PRESS EVENTS---------------
        private void txtData_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (dgvtrans.Columns[dgvtrans.CurrentCell.ColumnIndex].Name)
            {

                case "Qty":
                case "UnitPrice":
                case "Discount":
                case "Total":
                case "SalePrice":
                    dgvtrans.CurrentCell.Value = txtData.Text;
                    IsNumeric(sender, e);
                    break;
                case "product": break;
            }
        }
        private void txtvoucher_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
                if (char.IsNumber(e.KeyChar) == true || (Keys)e.KeyChar == Keys.Enter || (Keys)e.KeyChar == Keys.Back )
                {
                    e.Handled = false;
                    
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                e.Handled = true;
            }
        }

        private void Formasterentries_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsNumeric(sender, e);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to Delete?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr.Equals(DialogResult.Yes))
            {
                tm.InvTransactionMasterID = tmid;
                tm.Setisactiveornot();
                int RefreshStock = td.RefreshStock();
                if (RefreshStock > 0)
                {
                  //  loadvoucher();
                    clearcontrols(true);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvproductlist_KeyDown(object sender, KeyEventArgs e)
        {
            try {
                if (e.KeyCode == Keys.Enter)
                {

                    dgvtrans.CurrentRow.Cells["Code"].Value = dgvproductlist.CurrentRow.Cells["ProductCode"].Value.ToString();
                     LoadProductDetails();
                 
      
                }
            }
            catch(Exception ex)
            {

            }
            
        }


        private void btnUp_Click(object sender, EventArgs e)
        {


            tm.VoucherNumber = (Convert.ToInt32(txtvoucher.Text) + 1);
            txtvoucher.Text= (Convert.ToInt32(txtvoucher.Text) + 1).ToString();
                LoadetailForEDIT();
            


        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            try {
                if ((Convert.ToInt32(txtvoucher.Text) - 1) >= 1)
                {
                    tm.VoucherNumber = (Convert.ToInt32(txtvoucher.Text) - 1);
                    txtvoucher.Text = (Convert.ToInt32(txtvoucher.Text) - 1).ToString();
                    LoadetailForEDIT();
                }

            }catch(Exception ex)
            {

            }

        }

        private void cbVoucher_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVoucher.Checked == false)
            {
                txtvoucher.Enabled = false;
                dtptransdate.Enabled = false;

            }
            else
            {

                txtvoucher.Enabled = true;
                dtptransdate.Enabled = true;
            }

        }

     

        private void frm_Transactions_Resize(object sender, EventArgs e)
        {
            int Widthq = this.Width;
            dgvtrans.Height = pnlbottom.Top - pnltop.Bottom;
            dgvtrans.Width = Widthq;
            pnldgv.Height = pnlbottom.Top - txtData.Bottom;

        }

        private void frm_Transactions_Shown(object sender, EventArgs e)
        {
         
            txtData.Focus();
            frm_Transactions_Resize(null, null);
            pnldgv_Resize(null, null);
        }


        private void pnldgv_Resize(object sender, EventArgs e)
        {
          
            dgvproductlist.Height = pnlbottom.Top - txtData.Bottom;


        }

  

        private void txtcustdeaName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtcustdeaAddress.Focus();
            }
        }

        private void txtcustdeaAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtcustdeaMobile.Focus();
            }
        }

        private void txtcustdeaMobile_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txtData.Focus();
            }
        }

        private void txtDiscount_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txtPaidAmount.Focus();
            }
        }

        public void IsNumeric(object textBox,KeyPressEventArgs e)

        {
            TextBox txtBox = (TextBox)textBox;
            try
            {
                if (e.KeyChar=='.')
                {
                    for(int i=0;i<txtBox.Text.Length;i++)
                    {
                        if (txtBox.Text[i] == '.')
                        {
                            e.Handled = true;
                            return;
                        }
                    }
                }
                if(char.IsNumber(e.KeyChar)==true||(Keys)e.KeyChar==Keys.Enter|| (Keys)e.KeyChar == Keys.Back ||e.KeyChar=='.')
                {
                    e.Handled = false;
                }
                else
                {
                   e.Handled = true;
                }
            }      
            catch(Exception ex)
            {
              e.Handled = true;
            }

      }

    }
}

  

