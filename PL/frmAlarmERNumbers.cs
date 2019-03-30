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
    public partial class frmAlarmERNumbers : Telerik.WinControls.UI.RadForm
    {
       
        int id;
        public frmAlarmERNumbers(int id)
        {
            InitializeComponent();


            this.id = id;
        }

        private void frmAlarmERNumbers_Load(object sender, EventArgs e)
        {
            this.emGridView.DataSource = new clsAlarmPhNumber().GetAlarmPhById(id);
            this.emGridView.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;

            clsUser user = new clsUser();

            int userID = new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text);

            if (user.IsInRole(userID, "Admin") || user.IsInRole(userID, "Boss"))
            {
                this.addToolStripMenuItem.Enabled = true;
                this.editToolStripMenuItem.Enabled = true;
                this.deleteToolStripMenuItem.Enabled = true;
            }

            if (user.IsInRole(userID, "AddEmNum"))
            {
                this.addToolStripMenuItem.Enabled = true;
            }

            if (user.IsInRole(userID, "EditEmNum"))
            {
                this.editToolStripMenuItem.Enabled = true;
            }

            if (user.IsInRole(userID, "DeleteEmNum"))
            {
                this.deleteToolStripMenuItem.Enabled = true;
            }

        }

        private void refreshListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.emGridView.DataSource = new clsAlarmPhNumber().GetAlarmPhById(id);
            this.emGridView.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddAlarmEmNumber frm = new frmAddAlarmEmNumber(id);
            frm.type = "New";
            frm.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int id2 = int.Parse(this.emGridView.SelectedRows[0].Cells[0].Value.ToString());
                frmAddAlarmEmNumber frm = new frmAddAlarmEmNumber(id, id2);
                frm.type = "Edit";
                frm.ShowDialog();
            }
            catch
            {

            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int id2 = int.Parse(this.emGridView.SelectedRows[0].Cells[0].Value.ToString());
                var msg = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(msg == DialogResult.Yes)
                {
                    clsAlarmPhNumber a = new clsAlarmPhNumber(id2);
                    a.DeleteAlarmPhNumber();
                    this.emGridView.DataSource = a.GetAlarmPhById(id);
                    this.lblMsg.Text = "Record Deleted Successfully";

                }
            }
            catch
            {

            }
        }
    }
}
