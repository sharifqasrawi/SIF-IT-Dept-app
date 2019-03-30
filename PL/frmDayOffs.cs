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
    public partial class frmDayOffs : Telerik.WinControls.UI.RadForm
    {
        private static frmDayOffs frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static frmDayOffs GetFrmDayOffs
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmDayOffs();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public frmDayOffs()
        {
            InitializeComponent();

            if (frm == null)
                frm = this;

            this.offsGridView.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.offsGridView.DataSource = new clsDayOff().GetAll();
        }

        private void frmDayOffs_Load(object sender, EventArgs e)
        {
            clsUser user = new clsUser();

            int userID = new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text);

            if (user.IsInRole(userID, "Admin") || user.IsInRole(userID, "Boss"))
            {
                this.btnDelete.Enabled = true;
                this.BtnNew.Enabled = true;
                this.btnEdit.Enabled = true;
            }
            if (user.IsInRole(userID, "AddDayOff"))
            {
                this.BtnNew.Enabled = true;
            }

            if (user.IsInRole(userID, "EditDayOff"))
            {
                this.btnEdit.Enabled = true;
            }
            if (user.IsInRole(userID, "DeleteDayOff"))
            {
                this.btnDelete.Enabled = true;
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            new frmCreateDayOffDoc().ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.offsGridView.SelectedRows[0].Cells[0].Value.ToString());
                var msg = MessageBox.Show("Are you sure you want to delete this DayOff? ", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    clsDayOff d = new clsDayOff(id);
                    d.DeleteDayOff();
                    this.offsGridView.DataSource = d.GetAll();
                    this.lblMsg.Text = "DayOff deleted successfully";
                }
            }
            catch
            {

            }
        }
    }
}
