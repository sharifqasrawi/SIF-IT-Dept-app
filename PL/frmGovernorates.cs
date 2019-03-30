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
    public partial class frmGovernorates : Telerik.WinControls.UI.RadForm
    {
        private static frmGovernorates frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static frmGovernorates GetFrmGovernorates
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmGovernorates();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public frmGovernorates()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAddGov frm = new frmAddGov();
            frm.type = "New";
            frm.ShowDialog();
        }

        private void frmGovernorates_Load(object sender, EventArgs e)
        {
            clsGovernorate g = new clsGovernorate();
            this.govGridView.DataSource = g.GetAll();

            clsUser user = new clsUser();

            int userID = new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text);

            if (user.IsInRole(userID, "Admin") || user.IsInRole(userID, "Boss"))
            {
                this.btnDelete.Enabled = true;
                this.btnNew.Enabled = true;
                this.btnEdit.Enabled = true;
            }
            if (user.IsInRole(userID, "AddGov"))
            {
                this.btnNew.Enabled = true;
            }
            if (user.IsInRole(userID, "EditGov"))
            {
                this.btnEdit.Enabled = true;
            }
            if (user.IsInRole(userID, "DeleteGov"))
            {
                this.btnDelete.Enabled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.govGridView.SelectedRows[0].Cells[0].Value.ToString());
                frmAddGov frm = new frmAddGov(id);
                frm.Text = "Edit Governorate";
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
                int id = int.Parse(this.govGridView.SelectedRows[0].Cells[0].Value.ToString());
                clsGovernorate g = new clsGovernorate(id);
                var msg = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(msg==DialogResult.Yes)
                {
                    g.Delete();
                    frmGovernorates.GetFrmGovernorates.govGridView.DataSource = g.GetAll();
                    this.lblMsg.Text = "Record deleted successfully";
                    //MessageBox.Show("Record deleted successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch
            {

            }
        }
    }
}
