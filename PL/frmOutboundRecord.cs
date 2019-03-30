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
    public partial class frmOutboundRecord : Telerik.WinControls.UI.RadForm
    {
        private static frmOutboundRecord frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static frmOutboundRecord GetFrmOutboundRecords
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmOutboundRecord();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public frmOutboundRecord()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }

        private void frmOutboundRecord_Load(object sender, EventArgs e)
        {
            this.RecordsGridView.DataSource = new clsOutboundRecord().GetAll();
            this.RecordsGridView.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;

            clsUser user = new clsUser();

            int userID = new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text);

            if (user.IsInRole(userID, "Admin") || user.IsInRole(userID, "Boss"))
            {
                this.btnDelete.Enabled = true;
                this.BtnNew.Enabled = true;
                this.btnEdit.Enabled = true;
            }

            if (user.IsInRole(userID, "AddOutBoundRecord"))
            {
                this.BtnNew.Enabled = true;
            }
            if (user.IsInRole(userID, "EditOutBoundRecord"))
            {
                this.btnEdit.Enabled = true;
            }
            if (user.IsInRole(userID, "DeleteOutBoundRecord"))
            {
                this.btnDelete.Enabled = true;
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            frmAddOutboundRecord frm = new frmAddOutboundRecord();
            frm.type = "New";
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.RecordsGridView.SelectedRows[0].Cells[0].Value.ToString());
                frmAddOutboundRecord frm = new frmAddOutboundRecord(id);
                frm.type = "Edit";
                frm.Text = "Edit Outbound Record";
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
                int id = int.Parse(this.RecordsGridView.SelectedRows[0].Cells[0].Value.ToString());
                var msg = MessageBox.Show("Are you sure you want to delete this record?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(msg == DialogResult.Yes)
                {
                    clsOutboundRecord or = new clsOutboundRecord(id);
                    or.DeleteRecord();
                    this.RecordsGridView.DataSource = or.GetAll();
                    this.lblMsg.Text = "Record deleted successfully";
                }
            }
            catch
            {

            }
        }
    }
}
