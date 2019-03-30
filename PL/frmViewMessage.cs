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
    public partial class frmViewMessage : Telerik.WinControls.UI.RadForm
    {
        int id = 0;
        public frmViewMessage(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void frmViewMessage_Load(object sender, EventArgs e)
        {
            clsMessage msg = new clsMessage(id);
            txtFrom.Text = msg.GetMessageByID().Rows[0][1].ToString();
            txtDate.Text = Convert.ToDateTime(msg.GetMessageByID().Rows[0][4]).ToLongDateString();
            txtTime.Text = Convert.ToDateTime(msg.GetMessageByID().Rows[0][4]).ToLongTimeString();
            txtMsg.Text = msg.UnHashMessage(msg.GetMessageByID().Rows[0][3].ToString());
            msg.MarkAsRead();
            int userID = new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text);
            frmMessages.GetFrmMessages.msgsGridView.DataSource = msg.GetAll(userID);
            frmMain.GetFrmMain.lblMsgCount.Text = msg.GetMessagesCount(userID).ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
