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
    public partial class frmMaintenances : Telerik.WinControls.UI.RadForm
    {

        private static frmMaintenances frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static frmMaintenances GetFrmMaintenances
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmMaintenances();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public frmMaintenances()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;

            this.MntsGridView.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.MntsGridView.DataSource = new clsMaintenance().GetAll();
        }

        private void frmMaintenances_Load(object sender, EventArgs e)
        {
            this.MntsGridView.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.MntsGridView.DataSource = new clsMaintenance().GetAll();

            clsUser user = new clsUser();

            int userID = new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text);

            if (user.IsInRole(userID, "Admin") || user.IsInRole(userID, "Boss"))
            {
                this.btnDelete.Enabled = true;
                this.BtnNew.Enabled = true;
                this.btnEdit.Enabled = true;
                this.btnSend.Enabled = true;
            }
            if (user.IsInRole(userID, "AddMaintenance"))
            {
                this.BtnNew.Enabled = true;
            }
            if (user.IsInRole(userID, "SendMaintenance"))
            {
                this.btnSend.Enabled = true;
            }
            if (user.IsInRole(userID, "EditMaintenance"))
            {
                this.btnEdit.Enabled = true;
            }
            if (user.IsInRole(userID, "DeleteMaintenance"))
            {
                this.btnDelete.Enabled = true;
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            frmAddMaintenance frm = new frmAddMaintenance();
            frm.type = "New";
            frm.ShowDialog();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.MntsGridView.SelectedRows[0].Cells[0].Value.ToString());
                new frmMaintenanceOut(id).ShowDialog();
            }
            catch
            {

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.MntsGridView.SelectedRows[0].Cells[0].Value.ToString());
                frmAddMaintenance frm = new frmAddMaintenance(id);
                frm.type = "Edit";

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
                int id = int.Parse(this.MntsGridView.SelectedRows[0].Cells[0].Value.ToString());
                var msg = MessageBox.Show("Are you sure you want to delete this record? ", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    clsMaintenance m = new clsMaintenance(id);
                    m.DeleteMaintenance();
                    this.MntsGridView.DataSource = m.GetAll();
                    lblMsg.Text = "Record Deleted Successfully";
                }
            }
            catch
            {

            }
        }
    }
}
