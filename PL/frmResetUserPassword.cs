using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using IT_Dept.BL;

namespace IT_Dept.PL
{
    public partial class frmResetUserPassword : Telerik.WinControls.UI.RadForm
    {
        int id = 0;
        public frmResetUserPassword(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void frmResetUserPassword_Load(object sender, EventArgs e)
        {
            clsUser user = new clsUser(id);
            this.txtUser.Text = user.GetUserByID().Rows[0][3].ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtPw.Text) || String.IsNullOrWhiteSpace(txtPw.Text))
                {
                    MessageBox.Show("Please enter new password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    clsUser user = new clsUser(id, txtPw.Text);
                    user.ResetPassWord();
                    MessageBox.Show("Password Reseted successfully", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch
            {

            }
        }
    }
}
