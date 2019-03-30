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
    public partial class frmSIFServers : Telerik.WinControls.UI.RadForm
    {

        private static frmSIFServers frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static frmSIFServers GetFrmSIFServers
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmSIFServers();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public frmSIFServers()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }

        private void frmSIFServers_Load(object sender, EventArgs e)
        {
            clsSIFServer s = new clsSIFServer();
            this.serversGridView.DataSource = s.GetAll();
            this.serversGridView.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;


            clsUser user = new clsUser();

            int userID = new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text);

            if (user.IsInRole(userID, "Admin") || user.IsInRole(userID, "Boss"))
            {
                this.btnDelete.Enabled = true;
                this.BtnNew.Enabled = true;
                this.btnEdit.Enabled = true;
            }
            if (user.IsInRole(userID, "AddSIFServer"))
            {
                this.BtnNew.Enabled = true;
            }
            if (user.IsInRole(userID, "EditSIFServer"))
            {
                this.btnEdit.Enabled = true;
            }
            if (user.IsInRole(userID, "DeleteSIFServer"))
            {
                this.btnDelete.Enabled = true;
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            frmAddSIFServer frm = new frmAddSIFServer();
            frm.type = "New";
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.serversGridView.SelectedRows[0].Cells[0].Value.ToString());
                frmAddSIFServer frm = new frmAddSIFServer(id);
                frm.type = "Edit";
                frm.Text = "Edit SIF Server";
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
                int id = int.Parse(this.serversGridView.SelectedRows[0].Cells[0].Value.ToString());
                var msg = MessageBox.Show("Are you sure you want to delete this server? ", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    clsSIFServer s = new clsSIFServer(id);
                    s.Delete();
                    this.serversGridView.DataSource = s.GetAll();
                    this.lblMsg.Text = "Record deleted successfully";
                }
            }
            catch
            {

            }
        }
    }
}
