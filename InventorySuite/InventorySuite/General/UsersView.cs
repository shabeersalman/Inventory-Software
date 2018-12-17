using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

using System.Windows.Forms;

namespace InventorySuite.General
{
    public partial class UsersView : Form
    {
        public UsersView()
        {
            InitializeComponent();
            
            ShowUsers();
        }
        Users u = new Users();
        Export Export = new Export();


        public void ShowUsers()
        {

            DataSet ds = u.SelectUsers();
           dgv_Userview.DataSource = ds.Tables[0];
           this.dgv_Userview.Columns["UserID"].Visible = false;
           // dgv_Userview.CurrentRow.HeaderCell.Value = (dgv_Userview.CurrentRow.Index + 1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frm_UsersAdd ud = new frm_UsersAdd();
            ud.ShowDialog();
            ShowUsers();
        }

   
        private void btnEdit_Click(object sender, EventArgs e)
        {
            frm_UserEdit f1 = new frm_UserEdit(dgv_Userview.CurrentRow.Cells["UserID"].Value.ToString(),
                                                   dgv_Userview.CurrentRow.Cells["UserName"].Value.ToString(),
                                                   dgv_Userview.CurrentRow.Cells["Password"].Value.ToString(),
                                                   dgv_Userview.CurrentRow.Cells["UserType"].Value.ToString() );


            f1.ShowDialog();
            ShowUsers();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           this.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            u.UserID = int.Parse(dgv_Userview.CurrentRow.Cells["UserID"].Value.ToString());
            int ID = u.Delete();

            if (ID <= 0)
            {
                MessageBox.Show("User Does not Exist..Try Again.");
            }
            else
            {

                DialogResult dr = MessageBox.Show("Do you want to Delete?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr.Equals(DialogResult.Yes))
                {
                    ShowUsers();
                }

            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

            BindingSource da = new BindingSource();
            da.DataSource = dgv_Userview.DataSource;
            da.Filter = "UserName like '%" + txt_Search.Text + "%'";
            dgv_Userview.DataSource = da;

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowUsers();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Export.ExportToExcel(dgv_Userview, "User Report");
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
                Export.ExportToPdf(dgv_Userview, @"F:\Users.pdf","User Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }

            
           
            
        }
    }
} 
