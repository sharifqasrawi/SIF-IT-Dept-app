using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using IT_Dept.DL;
using IT_Dept.BL;
using System.Data.SqlClient;

namespace IT_Dept.PL
{
    public partial class frmChangePassword : Telerik.WinControls.UI.RadForm
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurPw.Text) || string.IsNullOrEmpty(txtNewPw.Text) || string.IsNullOrEmpty(txtConPw.Text)
                || string.IsNullOrWhiteSpace(txtCurPw.Text) || string.IsNullOrWhiteSpace(txtNewPw.Text) || string.IsNullOrWhiteSpace(txtConPw.Text))
            {
                MessageBox.Show("Fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtNewPw.Text.Length < 8)
                {
                    MessageBox.Show("Password length must be greater than 8 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    string currentPw = new clsUser().HashPassword(txtCurPw.Text);
                    string newPw = txtNewPw.Text;
                    string conPw = txtConPw.Text;
                    DLClass dl = new DLClass();

                    SqlCommand cmd = new SqlCommand("SELECT PassWord FROM tblUsers WHERE UserName = '" + frmMain.GetFrmMain.radLabelElementUsername.Text + "'", dl.CN);
                    dl.Open();
                    string userPw = cmd.ExecuteScalar().ToString();
                    dl.Close();
                    if (currentPw != userPw)
                    {
                        MessageBox.Show("Invalid Current Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (newPw != conPw)
                        {
                            MessageBox.Show("Password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            clsUser user = new clsUser(new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text), newPw);
                            user.ResetPassWord();
                            MessageBox.Show("Password changed !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.Close();
                        }
                    }
                }
            }
        }
    }
}
