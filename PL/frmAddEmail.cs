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
    public partial class frmAddEmail : Telerik.WinControls.UI.RadForm
    {
        public string type = "";
        int id = 0;

        public frmAddEmail()
        {
            InitializeComponent();
        }
        public frmAddEmail(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (type == "New")
            {
                Email email = new Email(txtName.Text, txtEmail.Text, txtPwd.Text, cbActive.Checked);
                email.addEmail();
                frmEmails.GetFrmEmails.emailsGridView.DataSource = email.GetAll();
                frmEmails.GetFrmEmails.lblMsg.Text = "Email added successfuly";
                this.Close();
            }
            else if(type == "Edit")
            {
                Email email = new Email(id,txtName.Text, txtEmail.Text, txtPwd.Text, cbActive.Checked);
                email.EditEmail();
                frmEmails.GetFrmEmails.emailsGridView.DataSource = email.GetAll();
                frmEmails.GetFrmEmails.lblMsg.Text = "Email Edited successfuly";
                this.Close();
            }
            
        }

        private void frmAddEmail_Load(object sender, EventArgs e)
        {
            Email email = new Email(id);
            if (type == "Edit")
            {
                txtName.Text = email.GetEmailByID().Rows[0][1].ToString();
                txtEmail.Text = email.GetEmailByID().Rows[0][2].ToString();
                txtPwd.Text = email.GetEmailByID().Rows[0][3].ToString();
                cbActive.Checked = Convert.ToBoolean(email.GetEmailByID().Rows[0][4].ToString());
            }
        }
    }
}
