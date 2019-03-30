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
    public partial class frmConnectionTypes : Telerik.WinControls.UI.RadForm
    {
        private static frmConnectionTypes frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static frmConnectionTypes GetFrmConnectionTypes
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmConnectionTypes();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public frmConnectionTypes()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAddConType frm = new frmAddConType();
            frm.type = "New";
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.conTypesGridView.SelectedRows[0].Cells[0].Value.ToString());
                frmAddConType frm = new frmAddConType(id);
                frm.type = "Edit";
                frm.Text = "Edit Connection Type";
                frm.ShowDialog();
            }
            catch
            {

            }
        }

        private void frmConnectionTypes_Load(object sender, EventArgs e)
        {
            clsConType ct = new clsConType();
            this.conTypesGridView.DataSource = ct.GetAll();

            clsUser user = new clsUser();

            int userID = new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text);

            if (user.IsInRole(userID, "Admin") || user.IsInRole(userID, "Boss"))
            {
                this.btnDelete.Enabled = true;
                this.btnNew.Enabled = true;
                this.btnEdit.Enabled = true;
            }
            if (user.IsInRole(userID, "AddConType"))
            {
                this.btnNew.Enabled = true;
            }
            if (user.IsInRole(userID, "EditConType"))
            {
                this.btnEdit.Enabled = true;
            }
            if (user.IsInRole(userID, "DeleteConType"))
            {
                this.btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.conTypesGridView.SelectedRows[0].Cells[0].Value.ToString());
                clsConType ct = new clsConType(id);
                var msg = MessageBox.Show("Are you sure you want to delete this record?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {

                    ct.Delete();
                    frmConnectionTypes.GetFrmConnectionTypes.conTypesGridView.DataSource = ct.GetAll();
                    this.lblMsg.Text = "Record deleted successfully";
                    //   MessageBox.Show("Record deleted successfully", " Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch
            {

            }
        }
    }
}
