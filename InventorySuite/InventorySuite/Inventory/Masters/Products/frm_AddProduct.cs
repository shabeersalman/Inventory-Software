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
    public partial class frm_AddProduct : Form
    {
        public frm_AddProduct()
        {
            InitializeComponent();
            LoadProductGroup();
            loadProductCode();

        }
        ProductView p = new ProductView();


        public void LoadProductGroup()
        {

            ProductGroup.ProductGroup pg = new ProductGroup.ProductGroup();
            DataSet ds = new DataSet();
            ds = pg.SelectUsers();
            cbProductGroup.DataSource = ds.Tables[0];
            cbProductGroup.DisplayMember = "GroupName";
            cbProductGroup.ValueMember = "ProductGroupID";
            cbProductGroup.SelectedIndex = -1;



        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtProductName1.Text == "" || cbProductGroup.Text == "")
            {

                MessageBox.Show("Please Fill the Fields");
            }

            else
            {
                p.ProductCode = txtProductCode.Text;
                p.ProductName = txtProductName1.Text;
                p.ManualBarcode = txtMbarcode.Text;
                p.ProductGroupID = Convert.ToInt32(cbProductGroup.SelectedValue);
                p.PurchasePrice = double.Parse("0" + txtPurchasePrice.Text);
                p.SalePrice = double.Parse("0" + txtSalePrice.Text);
                p.Stock = double.Parse("0" + txtStock.Text);

                int ID = p.Save();

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

            txtProductName1.Text = txtProductName1.Text = txtBarcode.Text = txtMbarcode.Text = cbProductGroup.Text = txtPurchasePrice.Text =
         txtSalePrice.Text = txtStock.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    
        private void frm_AddProduct_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                SendKeys.Send("{TAB}");
            }
        }


        private void  Ckeckentries_KeyPress(object sender, KeyPressEventArgs e)
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
                txtProductName1.Focus();
            

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
            LoadProductGroup();

        }

 
        private void cbProductGroup_DropDown(object sender, EventArgs e)
        {
            LoadProductGroup();
        }


    }

}