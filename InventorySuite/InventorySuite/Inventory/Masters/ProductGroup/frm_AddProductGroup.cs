using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventorySuite.Inventory.Masters.ProductGroup
{
    public partial class frm_AddProductGroup : Form
    {
        public frm_AddProductGroup()
        {
            InitializeComponent();
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_GroupName.Text == "")
            {
                MessageBox.Show("Please Fill the Fields");
            }
            else
            {
                ProductGroup pg = new ProductGroup();
                pg.GroupName = txt_GroupName.Text;
                int ID = pg.Save();
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
            txt_GroupName.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void txt_GroupName_TextChanged(object sender, EventArgs e)
        {
            if (!txt_GroupName.Text.Equals(""))
            {
                btn_Save.Enabled = true;
            }
            else
            {
                btn_Save.Enabled = false;
            }

        }

        private void txt_GroupName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!txt_GroupName.Text.Equals(""))
                {
                    btn_Save.Focus();
                }
                else
                {
                    btnClear.Focus();
                }

            }
        }
    }
}

