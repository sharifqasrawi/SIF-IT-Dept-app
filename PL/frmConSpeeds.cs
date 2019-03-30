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
    public partial class frmConSpeeds : Telerik.WinControls.UI.RadForm
    {
        private static frmConSpeeds frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static frmConSpeeds GetFrmConSpeeds
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmConSpeeds();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public frmConSpeeds()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddConSpeed frm = new frmAddConSpeed(int.Parse(this.speedsGridView.SelectedRows[0].Cells[0].Value.ToString()));
                frm.type = "Edit";
                frm.Text = "Edit connection speed";
                frm.ShowDialog();
            }
            catch
            {

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAddConSpeed frm = new frmAddConSpeed();
            frm.type = "New";
            frm.ShowDialog();
        }


        private void frmConSpeeds_Load(object sender, EventArgs e)
        {
            clsConSpeed speed = new clsConSpeed();
            this.speedsGridView.DataSource = speed.GetAll();

            clsUser user = new clsUser();

            int userID = new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text);

            if (user.IsInRole(userID, "Admin") || user.IsInRole(userID, "Boss"))
            {
                this.btnDelete.Enabled = true;
                this.btnNew.Enabled = true;
                this.btnEdit.Enabled = true;
            }
            if (user.IsInRole(userID, "AddConSpeed"))
            {
                this.btnNew.Enabled = true;
            }
            if (user.IsInRole(userID, "EditConSpeed"))
            {
                this.btnEdit.Enabled = true;
            }
            if (user.IsInRole(userID, "DeleteConSpeed"))
            {
                this.btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                clsConSpeed speed = new clsConSpeed(int.Parse(this.speedsGridView.SelectedRows[0].Cells[0].Value.ToString()));

                var msg = MessageBox.Show("Are you sure you want to delete this record?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {

                    speed.Delete();
                    GetFrmConSpeeds.speedsGridView.DataSource = speed.GetAll();
                    this.lblMsg.Text = "Record deleted successfully";
                    //MessageBox.Show("Record deleted successfully", " Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
        }
    }
}
