using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventorySuite.Inventory.Masters.Products
{
    public partial class frm_EditProduct : Form
    {

        int ProductID;
        ProductView p = new ProductView();
        public frm_EditProduct(string slno, string productcode, string ProductName, string GroupName,string Mbarcode, string purchaseprice, string saleprice, string stock)
        {
            InitializeComponent();
            LoadProductGroup();
            ProductID = Convert.ToInt32(slno);
            txtProductCode.Text = productcode;
            txtProductName.Text = ProductName;
            cbProductGroup.Text = GroupName;
            txtMbarcode.Text = Mbarcode;
            txtPurchasePrice.Text = purchaseprice;
            txtSalePrice2.Text = saleprice;
            txtStock.Text = stock;
           


        }
        public void LoadProductGroup()
        {

            ProductGroup.ProductGroup pg = new ProductGroup.ProductGroup();
            DataSet ds = new DataSet();
            ds = pg.SelectUsers();
            cbProductGroup.DataSource = ds.Tables[0];
            cbProductGroup.DisplayMember = "GroupName";
            cbProductGroup.ValueMember = "ProductGroupID";

        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProductCode.Text == "" )
            {

                MessageBox.Show("Please Fill the Fields");
                txtProductCode.Focus();
            }
            else if(  txtProductName.Text == "")
            {

                MessageBox.Show("Please Fill the Fields");
                txtProductName.Focus();
            }
            else
            {

                p.ProductID = ProductID;
                p.ProductCode = txtProductCode.Text;
                p.ProductName = txtProductName.Text;
                p.ManualBarcode = txtMbarcode.Text;
                p.ProductGroupID = Convert.ToInt32(cbProductGroup.SelectedValue);
                p.PurchasePrice = double.Parse("0"+txtPurchasePrice.Text);
                p.SalePrice = double.Parse ("0"+txtSalePrice2.Text);
                p.Stock = double.Parse("0"+txtStock.Text);

                int ID = p.Edit();

                if (ID <= 0)
                {
                    MessageBox.Show("Invalid Entry . Please try again");
                }
                else
                {

                    this.Close();

                }

            }

        }
        void ClearControls()
        {

            txtProductName.Text = txtProductName.Text = txtBarcode.Text = txtMbarcode.Text = cbProductGroup.Text = txtPurchasePrice.Text =
         txtSalePrice2.Text = txtStock.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void frm_EditProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {

                SendKeys.Send("{TAB}");
            }
        }




        private void Ckeckentries_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsNumeric(sender, e);
        }


        public void IsNumeric(object textBox, KeyPressEventArgs e)

        {
            TextBox txtBox = (TextBox)textBox;
            try
            {
                if (e.KeyChar == '.')
                {
                    for (int i = 0; i < txtBox.Text.Length; i++)
                    {
                        if (txtBox.Text[i] == '.')
                        {
                            e.Handled = true;
                            return;
                        }
                    }
                }
                if (char.IsNumber(e.KeyChar) == true || (Keys)e.KeyChar == Keys.Enter || (Keys)e.KeyChar == Keys.Back || e.KeyChar == '.')
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

        public void loadProductCode()
        {
            DataSet ds = p.LoadProductCode();
            if (ds.Tables[0].Rows.Count > 0)
            {
                txtProductCode.Text = ds.Tables[0].Rows[0][0].ToString();

            }

        }

        private void cbPcode_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPcode.Checked == false)
            {
                txtProductCode.Enabled = false;
                txtProductName.Focus();


            }
            else
            {
                txtProductCode.Enabled = true;
            }
        }

        private void btnAutomatic_Click(object sender, EventArgs e)
        {
            loadProductCode();
        }


        private void btnAddProductGroup_Click(object sender, EventArgs e)
        {
            ProductGroup.frm_AddProductGroup f = new ProductGroup.frm_AddProductGroup();
            f.Show();
   
        }

        private void cbProductGroup_DropDown(object sender, EventArgs e)
        {
            LoadProductGroup();
        }
    }
}

