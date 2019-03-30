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
    public partial class frmSendMessage : Telerik.WinControls.UI.RadForm
    {
        public frmSendMessage()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMessages_Load(object sender, EventArgs e)
        {
            lstUsers.DataSource = new clsUser().GetAllUsers(frmMain.GetFrmMain.radLabelElementUsername.Text);
            lstUsers.DisplayMember = "First name";
            lstUsers.ValueMember = "#";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstUsers.SelectedItems.Count; i++)
            {
                string txtmsg = txtMsg.Text;
                clsMessage msg = new clsMessage(new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text),
                    int.Parse(lstUsers.SelectedItems[i].Value.ToString()), txtmsg, DateTime.Now);
                msg.Send();
                lblMsg.Text = "Message send.";
                txtMsg.Clear();
            }

        }
    }
}
