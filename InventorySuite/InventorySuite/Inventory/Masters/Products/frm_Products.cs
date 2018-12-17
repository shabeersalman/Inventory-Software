
using InventorySuite.Inventory.Masters.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace InventorySuite.Inventory.Masters
{
    public partial class frm_Products : Form
    {
        ProductView p = new ProductView();
        Export Exp = new Export();
        public frm_Products()
        {
            InitializeComponent();

            ShowProducts();
        }



        public void ShowProducts()
        {

            DataSet ds = p.SelectProducts();
            dgv_Product.DataSource = ds.Tables[0];
            this.dgv_Product.Columns["ProductID"].Visible = false;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            frm_AddProduct f = new frm_AddProduct();
            f.ShowDialog();
            ShowProducts();

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            frm_EditProduct f = new frm_EditProduct(
                dgv_Product.CurrentRow.Cells["ProductID"].Value.ToString(),
                dgv_Product.CurrentRow.Cells["ProductCode"].Value.ToString(),
                dgv_Product.CurrentRow.Cells["ProductName"].Value.ToString(),
                dgv_Product.CurrentRow.Cells["GroupName"].Value.ToString(),
                dgv_Product.CurrentRow.Cells["ManualBarcode"].Value.ToString(),
                dgv_Product.CurrentRow.Cells["PurchasePrice"].Value.ToString(),
                dgv_Product.CurrentRow.Cells["SalePrice"].Value.ToString(),
                dgv_Product.CurrentRow.Cells["Stock"].Value.ToString()
                );
            f.ShowDialog();
            ShowProducts();

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            p.ProductID = Convert.ToInt32(dgv_Product.CurrentRow.Cells["ProductID"].Value.ToString());
            int ID = p.Delete();

            if (ID <= 0)
            {
                MessageBox.Show("Product Does not Exist..Try Again.");
            }
            else
            {

                DialogResult dr = MessageBox.Show("Do you want to Delete?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr.Equals(DialogResult.Yes))
                {

                    ShowProducts();
                }

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

     

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

            BindingSource da = new BindingSource();
            da.DataSource = dgv_Product.DataSource;
            da.Filter = "  ProductName like '%" + txt_Search.Text + "%'";
            dgv_Product.DataSource = da;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
         {
            ShowProducts();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {

                Exp.ExportToExcel(dgv_Product, "Product Report");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            try
            {

                Exp.ExportToPdf(dgv_Product, @"F:\Products.pdf","Product Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }

        }
    }
    }

