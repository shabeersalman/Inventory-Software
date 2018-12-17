using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventorySuite.General
{
    public partial class frm_UsersAdd : Form
    {


        public frm_UsersAdd()
        {
            InitializeComponent();
            btn_Save.Enabled = false;



        }
        Users u = new Users();
  
        private void btn_Save_Click(object sender, EventArgs e)
        {

            if (txt_UserName.Text == "" || txt_Password.Text == "" || cb_Usertype.Text == "")
            {

                MessageBox.Show("Please Fill the Fields");
            }

            else
            {
                //  Users u = new Users();
                u.UserName = txt_UserName.Text;
                u.Passwd = txt_Password.Text;
                u.UserType = cb_Usertype.Text;

                int ID = u.Save();

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
            txt_UserName.Text = txt_Password.Text = cb_Usertype.Text = "";
            btn_Save.Enabled = false;
        }

   

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        
 
        private void txt_UserName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txt_Password.Focus();

            }
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                cb_Usertype.Focus();

            }
        }

        private void cb_Usertype_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                if (!txt_UserName.Text.Equals("") || !txt_Password.Text.Equals("") || !cb_Usertype.Text.Equals(""))
                {
                    btn_Save.Focus();
                }
                else
                {
                    btnClear.Focus();
                }

            }
        }

        private void txt__TextChanged_(object sender, EventArgs e)
        {
            if (!txt_UserName.Text.Equals("") || !txt_Password.Text.Equals("") || !cb_Usertype.Text.Equals(""))
            {
                btn_Save.Enabled = true;
            }else
            {
                btn_Save.Enabled = false;
            }
        }
    }
}
