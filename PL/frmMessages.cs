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
    public partial class frmMessages : Telerik.WinControls.UI.RadForm
    {
        private static frmMessages frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static frmMessages GetFrmMessages
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmMessages();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public frmMessages()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }

        private void frmMessages_Load(object sender, EventArgs e)
        {
            clsMessage msg = new clsMessage();
            this.msgsGridView.DataSource = msg.GetAll(new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text));
            this.msgsGridView.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;

            clsUser user = new clsUser();

            int userID = new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text);

            if (user.IsInRole(userID, "Admin") || user.IsInRole(userID, "Boss"))
            {
                this.btnDelete.Enabled = true;
                this.BtnNew.Enabled = true;
                this.btnView.Enabled = true;
            }

            if (user.IsInRole(userID, "AddMessage"))
            {
                this.BtnNew.Enabled = true;
            }
            if (user.IsInRole(userID, "ReadMessage"))
            {
                this.btnView.Enabled = true;
            }
            if (user.IsInRole(userID, "DeleteMessage"))
            {
                this.btnDelete.Enabled = true;
            }

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            frmSendMessage frm = new frmSendMessage();
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.msgsGridView.SelectedRows[0].Cells[0].Value.ToString());
                var msg = MessageBox.Show("Are you sure you want to delete this message?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(msg == DialogResult.Yes)
                {
                    clsMessage m = new clsMessage(id);
                    m.Delete();
                    frmMessages.GetFrmMessages.msgsGridView.DataSource = m.GetAll(new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text));
                    frmMain.GetFrmMain.lblMsgCount.Text = m.GetMessagesCount(new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text)).ToString();
                    lblMsg.Text = "Message deleted successfully";
                }
            }
            catch
            { }

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.msgsGridView.SelectedRows[0].Cells[0].Value.ToString());
                frmViewMessage frm = new frmViewMessage(id);
                frm.ShowDialog();
            }
            catch
            {

            }
        }

    }
}
