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
    public partial class frm_UserLogin : Form
    {
        public frm_UserLogin()
        {
            InitializeComponent();
        }
        Users u = new Users();
        public void btn_Login_Click(object sender, EventArgs e)
        {
             if (txt_UserName.Text == "" || txt_Password.Text == "")
            {

                MessageBox.Show("Please Fill the Fields");
            }

            else
            {
                Users u = new Users();
                u.UserName = txt_UserName.Text;
                u.Passwd = txt_Password.Text;

                   int ID = u.ValidateUsers();

                if (ID <= 0)
                {
                    MessageBox.Show("Invalid Entry . Please try again");
                }
                else
                {

                    frm_MainDashboard fmain = new InventorySuite.frm_MainDashboard();
                    fmain.Show();
                    this.Hide();

                }

            }
        }

        private void txt_UserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_Password.Focus();

            }
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
               btn_Login.Focus();

            }
        }
    }
}
