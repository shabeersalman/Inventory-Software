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


namespace InventorySuite.Inventory.Masters.ProductGroup
{

    public partial class frm_ProductGroupView : Form
    {
        ProductGroup pd = new ProductGroup();
        Export Exp = new Export();
        public frm_ProductGroupView()
        {
            InitializeComponent();
           ShowProductGroup();
        }


        public void ShowProductGroup()
        {

            DataSet ds = pd.SelectUsers();
            dgv_ProductGroupview.DataSource = ds.Tables[0];
            this.dgv_ProductGroupview.Columns["ProductGroupID"].Visible = false;

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

            frm_AddProductGroup apg = new frm_AddProductGroup();
            apg.ShowDialog();
           ShowProductGroup();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
             frm_EditProductGroup f1=new frm_EditProductGroup (dgv_ProductGroupview.CurrentRow.Cells["ProductGroupID"].Value.ToString(),
                                                 dgv_ProductGroupview.CurrentRow.Cells["GroupName"].Value.ToString());

            f1.ShowDialog();
           ShowProductGroup();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pd.ProductGroupID = Convert.ToInt32 (dgv_ProductGroupview.CurrentRow.Cells["ProductGroupID"].Value.ToString());
            int ID = pd.Delete();

            if (ID <= 0)
            {
                MessageBox.Show("ProductGroup Does not Exist..Try Again.");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Do you want to Delete?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr.Equals(DialogResult.Yes))
                {

                    ShowProductGroup();
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
            da.DataSource = dgv_ProductGroupview.DataSource;
            da.Filter = "  GroupName like '%" + txt_Search.Text + "%'";
            dgv_ProductGroupview.DataSource = da;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowProductGroup();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

            try
            {

                Exp.ExportToExcel(dgv_ProductGroupview, "ProductGroup Report");
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
           
              Exp.ExportToPdf(dgv_ProductGroupview, @"F:\ProductGroup.pdf", "ProductGroup Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
          }
    }
}
