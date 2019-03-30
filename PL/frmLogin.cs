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
    public partial class frmLogin : Telerik.WinControls.UI.RadForm
    {
        private static frmLogin frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static frmLogin GetFrmLogin
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmLogin();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public static string username = "";
        public frmLogin()
        {
            InitializeComponent();
            clsUser u = new clsUser();
            this.lstUsers.DataSource = u.GetAllUsers();
            this.lstUsers.DisplayMember = "Username";
            this.lstUsers.ValueMember = "Username";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                clsUser user = new clsUser(this.lstUsers.SelectedValue.ToString(), txtPw.Text);
                int userID = new clsUser().GetUserID(this.lstUsers.SelectedValue.ToString());
                if (user.Login())
                {
                    frmMain.GetFrmMain.radLabelElementLastLogin.Text = "Last Login: " + user.GetLastLogin(userID).ToLongDateString() + " " + user.GetLastLogin(userID).ToLongTimeString();
                    user.SetLastLogin(DateTime.Now, userID);

                    frmMain.GetFrmMain.Opacity = 1;
                    frmMain.GetFrmMain.radLabelElementUsername.Text = user.UserName;
                    username = user.UserName;

              
                    frmMain.GetFrmMain.btnToDoList.Visible = true;
                    frmMain.GetFrmMain.btnCenters.Visible = true;
                    frmMain.GetFrmMain.btnNumbers.Visible = true;
                    frmMain.GetFrmMain.btnMessages.Visible = true;
                    frmMain.GetFrmMain.lblMsgCount.Visible = true;
                    frmMain.GetFrmMain.btnDailyTasks.Visible = true;
                    frmMain.GetFrmMain.btnWorkAss.Visible = true;
                    frmMain.GetFrmMain.btn3GSims.Visible = true;
                    frmMain.GetFrmMain.btnOutbound.Visible = true;
                    frmMain.GetFrmMain.btnPinger.Visible = true;
                    frmMain.GetFrmMain.btnRemoteDesktop.Visible = true;
                    frmMain.GetFrmMain.btnServersShutdown.Visible = true;
                    frmMain.GetFrmMain.btnDocs.Visible = true;
                    frmMain.GetFrmMain.btnEmails.Visible = true;
                    frmMain.GetFrmMain.btnMaintenances.Visible = true;
                    frmMain.GetFrmMain.btnPayDocs.Visible = true;
                    frmMain.GetFrmMain.btnSurAlarm.Visible = true;

                    frmMain.GetFrmMain.lblMsgCount.Text = new clsMessage().GetMessagesCount(userID).ToString();


                    lblLoginFail.Visible = false;
                    frmMain.GetFrmMain.radMenuItemLogout.Text = "Log out";
                    this.Close();
                }
                else
                {
                    lblLoginFail.Visible = true;

                }
            }
            catch (Exception ex)
            {
                lblLoginFail.Visible = true;
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Properties.Settings.Default.LoginUserName = this.lstUsers.SelectedValue.ToString();
            }
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            clsUser u = new clsUser();
            this.lstUsers.DataSource = u.GetAllUsers();
            this.lstUsers.DisplayMember = "Username";
            this.lstUsers.ValueMember = "Username";

            this.lstUsers.SelectedValue = Properties.Settings.Default.LoginUserName;
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
