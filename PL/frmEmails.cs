using IT_Dept.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace IT_Dept.PL
{
    public partial class frmEmails : Telerik.WinControls.UI.RadForm
    {

        private static frmEmails frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static frmEmails GetFrmEmails
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmEmails();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public frmEmails()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;

            Email areas = new Email();
            this.emailsGridView.DataSource = areas.GetAll();

            this.emailsGridView.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            frmAddEmail frm = new frmAddEmail();
            frm.type = "New";
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.emailsGridView.SelectedRows[0].Cells[0].Value.ToString());
                frmAddEmail frm = new frmAddEmail(id);
                frm.type = "Edit";
                frm.Text = "Edit email";
                frm.ShowDialog();
            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.emailsGridView.SelectedRows[0].Cells[0].Value.ToString());
                var msg = MessageBox.Show("Are you sure you want to delete this email? ", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(msg == DialogResult.Yes)
                {
                    Email email = new Email(id);
                    email.DeleteEmail();
                    this.emailsGridView.DataSource = email.GetAll();
                    this.lblMsg.Text = "Email deleted successfully";
                }
            }
            catch
            {

            }
        }

        private void frmEmails_Load(object sender, EventArgs e)
        {
            Email areas = new Email();
            this.emailsGridView.DataSource = areas.GetAll();

            this.emailsGridView.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;

            clsUser user = new clsUser();

            int userID = new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text);

            if (user.IsInRole(userID, "Admin") || user.IsInRole(userID, "Boss"))
            {
                this.btnDelete.Enabled = true;
                this.BtnNew.Enabled = true;
                this.btnEdit.Enabled = true;
            }
            if (user.IsInRole(userID, "AddEmail"))
            {
                this.BtnNew.Enabled = true;
            }
            if (user.IsInRole(userID, "EditEmail"))
            {
                this.btnEdit.Enabled = true;
            }
            if (user.IsInRole(userID, "DeleteEmail"))
            {
                this.btnDelete.Enabled = true;
            }
        }
    }
}
