using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using IT_Dept.DL;
using IT_Dept.BL;
using System.Timers;
using System.IO;
using System.Drawing.Imaging;

namespace IT_Dept.PL
{
    public partial class frmMain : Telerik.WinControls.UI.RadForm
    {
        private static frmMain frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static frmMain GetFrmMain
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmMain();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public System.Timers.Timer aTimer = new System.Timers.Timer();
        public frmMain()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;



            ThemeResolutionService.ApplicationThemeName = Properties.Settings.Default.Theme;

            radMenuItemThDefault.IsChecked = Properties.Settings.Default.th19;
            radMenuItemOffice2010Blu.IsChecked = Properties.Settings.Default.th18;
            radMenuItemWin8.IsChecked = Properties.Settings.Default.th17;
            radMenuItemWin7.IsChecked = Properties.Settings.Default.th16;
            radMenuItemVS2012L.IsChecked = Properties.Settings.Default.th15;
            radMenuItemVS2012D.IsChecked = Properties.Settings.Default.th14;
            radMenuItemMetroTouch.IsChecked = Properties.Settings.Default.th13;
            radMenuItemMetroBlue.IsChecked = Properties.Settings.Default.th12;
            radMenuItemOffice2013L.IsChecked = Properties.Settings.Default.th11;
            radMenuItemOffice2013D.IsChecked = Properties.Settings.Default.th10;
            radMenuItemOffice2010S.IsChecked = Properties.Settings.Default.th9;
            radMenuItemOffice2010Bl.IsChecked = Properties.Settings.Default.th8;
            radMenuItemOffice2007S.IsChecked = Properties.Settings.Default.th7;
            radMenuItemThHQB.IsChecked = Properties.Settings.Default.th6;
            radMenuItemThOffice2007B.IsChecked = Properties.Settings.Default.th5;
            radMenuItemThDesert.IsChecked = Properties.Settings.Default.th4;
            radMenuItemThAqua.IsChecked = Properties.Settings.Default.th3;
            radMenuItemThBreeze.IsChecked = Properties.Settings.Default.th2;
            radMenuItemThMetro.IsChecked = Properties.Settings.Default.th1;



          
            aTimer.Elapsed += new ElapsedEventHandler(timer1_Tick);
            aTimer.Enabled = true;
            // Set the Interval to 1 second.
            aTimer.Interval = 1000;


            //
            try
            {
                string img = Properties.Settings.Default.bg;
                byte[] i = Convert.FromBase64String(img);
                this.BackgroundImage = Image.FromStream(new MemoryStream(i));
            }
            catch { }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DLClass dl = new DLClass();
            this.radLabelElementDateTime.Text = "Today: "+ DateTime.Now.ToLongDateString();
            this.radLabelElementPCName.Text = Environment.MachineName;
            this.radLabelElementServer.Text = dl.CN.DataSource;
            this.radLabelElementDB.Text = dl.CN.Database;
            this.radLabelElementVersion.Text = "Version: 20170805";

            ThemeResolutionService.ApplicationThemeName = "Breeze";
            radMenuItemThDefault.IsChecked = false;
            radMenuItemOffice2010Blu.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemWin8.IsChecked = false;
            radMenuItemWin7.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemVS2012D.IsChecked = false;
            radMenuItemMetroTouch.IsChecked = false;
            radMenuItemMetroBlue.IsChecked = false;
            radMenuItemOffice2013L.IsChecked = false;
            radMenuItemOffice2013D.IsChecked = false;
            radMenuItemOffice2010S.IsChecked = false;
            radMenuItemOffice2010Bl.IsChecked = false;
            radMenuItemOffice2007S.IsChecked = false;
            radMenuItemThHQB.IsChecked = false;
            radMenuItemThOffice2007B.IsChecked = false;
            radMenuItemThDesert.IsChecked = false;
            radMenuItemThAqua.IsChecked = false;
            radMenuItemThBreeze.IsChecked = true;
            radMenuItemThMetro.IsChecked = false;

                    
            frmLogin frm = new frmLogin();
            frm.ShowDialog();


            lblMsgCount.Text = new clsMessage().GetMessagesCount(new clsUser().GetUserID(this.radLabelElementUsername.Text)).ToString();


            clsUser user = new clsUser();

            int userID = new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text);

            if (user.IsInRole(userID, "Admin"))
            {
                this.radMenuItemUsersManage.Visibility = ElementVisibility.Visible;
            }
            if (user.IsInRole(userID, "UsersMng"))
            {
                this.radMenuItemUsersManage.Visibility = ElementVisibility.Visible;
            }
            if (user.IsInRole(userID, "Admin") || user.IsInRole(userID, "Boss"))
            {
                this.btnCenters.Enabled = true;
                this.btnMessages.Enabled = true;
                this.btnNumbers.Enabled = true;
                this.btn3GSims.Enabled = true;
                this.btnDailyTasks.Enabled = true;
                this.btnToDoList.Enabled = true;
                this.btnWorkAss.Enabled = true;
                this.btnOutbound.Enabled = true;
                this.btnPinger.Enabled = true;
                this.btnServersShutdown.Enabled = true;
                this.btnRemoteDesktop.Enabled = true;
                this.btnDocs.Enabled = true;
                this.btnEmails.Enabled = true;
                this.btnMaintenances.Enabled = true;
                this.btnPayDocs.Enabled = true;
                this.btnSurAlarm.Enabled = true;
               

                /////////////////////////////////

                this.radMenuItemContentMng.Visibility = ElementVisibility.Visible;
                this.radMenuItemAreas.Visibility = ElementVisibility.Visible;
                this.radMenuItemGov.Visibility = ElementVisibility.Visible;
                this.radMenuItemConT.Visibility = ElementVisibility.Visible;
                this.radMenuItemConSpeed.Visibility = ElementVisibility.Visible;
                this.radMenuItemGT.Visibility = ElementVisibility.Visible;
                this.radMenuItemSIFServers.Visibility = ElementVisibility.Visible;
                this.radMenuItemBackupRestore.Visibility = ElementVisibility.Visible;
               
            }

            if (user.IsInRole(userID, "Centers"))
            {
                this.btnCenters.Enabled = true;
            }
            if (user.IsInRole(userID, "Messages"))
            {
                this.btnMessages.Enabled = true;
            }
            if (user.IsInRole(userID, "WorkAss"))
            {
                this.btnWorkAss.Enabled = true;
            }
            if (user.IsInRole(userID, "SyriatelNumbers"))
            {
                this.btnNumbers.Enabled = true;
            }
            if (user.IsInRole(userID, "3GSims"))
            {
                this.btn3GSims.Enabled = true;
            }
            if (user.IsInRole(userID, "All"))
            {
                this.btnDailyTasks.Enabled = true;
                this.btnToDoList.Enabled = true;
            }
            if (user.IsInRole(userID, "OutboundRecords"))
            {
                this.btnOutbound.Enabled = true;
            }
            if (user.IsInRole(userID, "Pinger"))
            {
                this.btnPinger.Enabled = true;
            }

            if (user.IsInRole(userID, "AreasMng"))
            {
                this.radMenuItemContentMng.Visibility = ElementVisibility.Visible;
                this.radMenuItemAreas.Visibility = ElementVisibility.Visible;
            }
            if (user.IsInRole(userID, "GovernoratesMng"))
            {
                this.radMenuItemContentMng.Visibility = ElementVisibility.Visible;
                this.radMenuItemGov.Visibility = ElementVisibility.Visible;
            }
            if (user.IsInRole(userID, "ConTypesMng"))
            {
                this.radMenuItemContentMng.Visibility = ElementVisibility.Visible;
                this.radMenuItemConT.Visibility = ElementVisibility.Visible;
            }
            if (user.IsInRole(userID, "ConSpeedsMng"))
            {
                this.radMenuItemContentMng.Visibility = ElementVisibility.Visible;
                this.radMenuItemConSpeed.Visibility = ElementVisibility.Visible;
            }
            if (user.IsInRole(userID, "GatesTypesMng"))
            {
                this.radMenuItemContentMng.Visibility = ElementVisibility.Visible;
                this.radMenuItemGT.Visibility = ElementVisibility.Visible;
            }
            if (user.IsInRole(userID, "SIFServers"))
            {
                this.radMenuItemContentMng.Visibility = ElementVisibility.Visible;
                this.radMenuItemSIFServers.Visibility = ElementVisibility.Visible;
            }
            if (user.IsInRole(userID, "BackupAndRestoreDB"))
            {
                this.radMenuItemBackupRestore.Visibility = ElementVisibility.Visible;
            }

            if (user.IsInRole(userID, "ServersShutdown"))
            {
                this.btnServersShutdown.Enabled = true;
            }
            if (user.IsInRole(userID, "RemoteDesktop"))
            {
                this.btnRemoteDesktop.Enabled = true;
            }
            if (user.IsInRole(userID, "Docs"))
            {
                this.btnDocs.Enabled = true;
            }
            if (user.IsInRole(userID, "Emails"))
            {
                this.btnEmails.Enabled = true;
            }
            if (user.IsInRole(userID, "Maintenances"))
            {
                this.btnMaintenances.Enabled = true;
            }
             
            if (user.IsInRole(userID, "PayDocs"))
            {
                this.btnPayDocs.Enabled = true;
            }

            if (user.IsInRole(userID, "AlarmSurv"))
            {
                this.btnSurAlarm.Enabled = true;
            }
        }

        private void radMenuItem2About_Click(object sender, EventArgs e)
        {

        }

        private void radMenuItemGov_Click(object sender, EventArgs e)
        {
            frmGovernorates.GetFrmGovernorates.Show();
            frmGovernorates.GetFrmGovernorates.BringToFront();
            frmGovernorates.GetFrmGovernorates.WindowState = FormWindowState.Normal;
        }

        private void radMenuItemAreas_Click(object sender, EventArgs e)
        {
            frmAreas.GetFrmAreas.Show();
            frmAreas.GetFrmAreas.BringToFront();
            frmAreas.GetFrmAreas.WindowState = FormWindowState.Normal;
        }

        private void radMenuItemConT_Click(object sender, EventArgs e)
        {
            frmConnectionTypes.GetFrmConnectionTypes.Show();
            frmConnectionTypes.GetFrmConnectionTypes.BringToFront();
            frmConnectionTypes.GetFrmConnectionTypes.WindowState = FormWindowState.Normal;
        }

        private void radMenuItemGT_Click(object sender, EventArgs e)
        {
            frmGateTypes.GetFrmGateTypes.Show();
            frmGateTypes.GetFrmGateTypes.BringToFront();
            frmGateTypes.GetFrmGateTypes.WindowState = FormWindowState.Normal;
        }

        private void radMenuItemConSpeeds_Click(object sender, EventArgs e)
        {
            frmConSpeeds.GetFrmConSpeeds.Show();
            frmConSpeeds.GetFrmConSpeeds.BringToFront();
            frmConSpeeds.GetFrmConSpeeds.WindowState = FormWindowState.Normal;
        }

        private void radMenuItemUsers_Click(object sender, EventArgs e)
        {
            frmUnlockUsersMngmnt.GetFrmUnlockUsersMngmnt.Show();
            frmUnlockUsersMngmnt.GetFrmUnlockUsersMngmnt.BringToFront();
            frmUnlockUsersMngmnt.GetFrmUnlockUsersMngmnt.WindowState = FormWindowState.Normal;
        }

        private void radMenuItemLogout_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            //frmMain.GetFrmMain.radLabelElementUser.Text = "User: ";
            //frmMain.GetFrmMain.radLabelElementLastLogin.Text = "";
            //frmMain.GetFrmMain.radLabelElementUsername.Text = "";
            //this.radMenuItemLogout.Text = "Login";
            //frmMain.GetFrmMain.btnToDoList.Visible = false;
            //frmMain.GetFrmMain.btnCenters.Visible = false;
            //frmMain.GetFrmMain.btnNumbers.Visible = false;
            //frmMain.GetFrmMain.btnMessages.Visible = false;
            //frmMain.GetFrmMain.lblMsgCount.Visible = false;

            //frmMain.GetFrmMain.radMenuItemContentMng.Visibility = ElementVisibility.Collapsed;
            //frmMain.GetFrmMain.radMenuItemUsersManage.Visibility = ElementVisibility.Collapsed;
            //frmMain.GetFrmMain.radMenuItemContentMng.Visibility = ElementVisibility.Collapsed;

            ////Closing forms
            //frmCenters.GetFrmCenters.Close();
            //frmSyriatelNumbers.GetFrmSyriatelNumbers.Close();
            //frmToDoList.GetFrmToDoList.Close();
            //frmMessages.GetFrmMessages.Close();
            //frmAreas.GetFrmAreas.Close();
            //frmConnectionTypes.GetFrmConnectionTypes.Close();
            //frmConSpeeds.GetFrmConSpeeds.Close();
            //frmGateTypes.GetFrmGateTypes.Close();
            //frmGovernorates.GetFrmGovernorates.Close();
            //frmUsersMng.GetFrmUsersMngTypes.Close();

            
            ////
            //frmLogin frm = new frmLogin();
            //frm.ShowDialog();
        }

        private void btnToDoList_Click(object sender, EventArgs e)
        {
            frmToDoList.GetFrmToDoList.Show();
            frmToDoList.GetFrmToDoList.BringToFront();
            frmToDoList.GetFrmToDoList.WindowState = FormWindowState.Normal;
        }

        private void btnNumbers_Click(object sender, EventArgs e)
        {
            frmSyriatelNumbers.GetFrmSyriatelNumbers.Show();
            frmSyriatelNumbers.GetFrmSyriatelNumbers.BringToFront();
            frmSyriatelNumbers.GetFrmSyriatelNumbers.WindowState = FormWindowState.Normal;
        }

        private void btnCenters_Click(object sender, EventArgs e)
        {
            frmCenters.GetFrmCenters.Show();
            frmCenters.GetFrmCenters.BringToFront();
            frmCenters.GetFrmCenters.WindowState = FormWindowState.Normal;
        }

        private void radMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void radMenuItemThMetro_Click(object sender, EventArgs e)
        {
            ThemeResolutionService.ApplicationThemeName = "TelerikMetro";

            radMenuItemThDefault.IsChecked = false;
            radMenuItemOffice2010Blu.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemWin8.IsChecked = false;
            radMenuItemWin7.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemVS2012D.IsChecked = false;
            radMenuItemMetroTouch.IsChecked = false;
            radMenuItemMetroBlue.IsChecked = false;
            radMenuItemOffice2013L.IsChecked = false;
            radMenuItemOffice2013D.IsChecked = false;
            radMenuItemOffice2010S.IsChecked = false;
            radMenuItemOffice2010Bl.IsChecked = false;
            radMenuItemOffice2007S.IsChecked = false;
            radMenuItemThHQB.IsChecked = false;
            radMenuItemThOffice2007B.IsChecked = false;
            radMenuItemThDesert.IsChecked = false;
            radMenuItemThAqua.IsChecked = false;
            radMenuItemThBreeze.IsChecked = false;
            radMenuItemThMetro.IsChecked = true;
        }

        private void radMenuItemThWin8_Click(object sender, EventArgs e)
        {
            ThemeResolutionService.ApplicationThemeName = "Windows8";


            radMenuItemThDefault.IsChecked = false;
            radMenuItemOffice2010Blu.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemWin8.IsChecked = true;
            radMenuItemWin7.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemVS2012D.IsChecked = false;
            radMenuItemMetroTouch.IsChecked = false;
            radMenuItemMetroBlue.IsChecked = false;
            radMenuItemOffice2013L.IsChecked = false;
            radMenuItemOffice2013D.IsChecked = false;
            radMenuItemOffice2010S.IsChecked = false;
            radMenuItemOffice2010Bl.IsChecked = false;
            radMenuItemOffice2007S.IsChecked = false;
            radMenuItemThHQB.IsChecked = false;
            radMenuItemThOffice2007B.IsChecked = false;
            radMenuItemThDesert.IsChecked = false;
            radMenuItemThAqua.IsChecked = false;
            radMenuItemThBreeze.IsChecked = false;
            radMenuItemThMetro.IsChecked = false;
        }

        private void radMenuItemThBreeze_Click(object sender, EventArgs e)
        {
            ThemeResolutionService.ApplicationThemeName = "Breeze";
            radMenuItemThDefault.IsChecked = false;
            radMenuItemOffice2010Blu.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemWin8.IsChecked = false;
            radMenuItemWin7.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemVS2012D.IsChecked = false;
            radMenuItemMetroTouch.IsChecked = false;
            radMenuItemMetroBlue.IsChecked = false;
            radMenuItemOffice2013L.IsChecked = false;
            radMenuItemOffice2013D.IsChecked = false;
            radMenuItemOffice2010S.IsChecked = false;
            radMenuItemOffice2010Bl.IsChecked = false;
            radMenuItemOffice2007S.IsChecked = false;
            radMenuItemThHQB.IsChecked = false;
            radMenuItemThOffice2007B.IsChecked = false;
            radMenuItemThDesert.IsChecked = false;
            radMenuItemThAqua.IsChecked = false;
            radMenuItemThBreeze.IsChecked = true;
            radMenuItemThMetro.IsChecked = false;
        }

        private void radMenuItemThAqua_Click(object sender, EventArgs e)
        {
            ThemeResolutionService.ApplicationThemeName = "Aqua";
            radMenuItemThDefault.IsChecked = false;
            radMenuItemOffice2010Blu.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemWin8.IsChecked = false;
            radMenuItemWin7.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemVS2012D.IsChecked = false;
            radMenuItemMetroTouch.IsChecked = false;
            radMenuItemMetroBlue.IsChecked = false;
            radMenuItemOffice2013L.IsChecked = false;
            radMenuItemOffice2013D.IsChecked = false;
            radMenuItemOffice2010S.IsChecked = false;
            radMenuItemOffice2010Bl.IsChecked = false;
            radMenuItemOffice2007S.IsChecked = false;
            radMenuItemThHQB.IsChecked = false;
            radMenuItemThOffice2007B.IsChecked = false;
            radMenuItemThDesert.IsChecked = false;
            radMenuItemThAqua.IsChecked = true;
            radMenuItemThBreeze.IsChecked = false;
            radMenuItemThMetro.IsChecked = false;
        }

        private void radMenuItemThDesert_Click(object sender, EventArgs e)
        {
            ThemeResolutionService.ApplicationThemeName = "Desert";
            radMenuItemThDefault.IsChecked = false;
            radMenuItemOffice2010Blu.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemWin8.IsChecked = false;
            radMenuItemWin7.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemVS2012D.IsChecked = false;
            radMenuItemMetroTouch.IsChecked = false;
            radMenuItemMetroBlue.IsChecked = false;
            radMenuItemOffice2013L.IsChecked = false;
            radMenuItemOffice2013D.IsChecked = false;
            radMenuItemOffice2010S.IsChecked = false;
            radMenuItemOffice2010Bl.IsChecked = false;
            radMenuItemOffice2007S.IsChecked = false;
            radMenuItemThHQB.IsChecked = false;
            radMenuItemThOffice2007B.IsChecked = false;
            radMenuItemThDesert.IsChecked = true;
            radMenuItemThAqua.IsChecked = false;
            radMenuItemThBreeze.IsChecked = false;
            radMenuItemThMetro.IsChecked = false;
        }

        private void radMenuItemThHQB_Click(object sender, EventArgs e)
        {
            ThemeResolutionService.ApplicationThemeName = "HighContrastBlack";
            radMenuItemThDefault.IsChecked = false;
            radMenuItemOffice2010Blu.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemWin8.IsChecked = false;
            radMenuItemWin7.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemVS2012D.IsChecked = false;
            radMenuItemMetroTouch.IsChecked = false;
            radMenuItemMetroBlue.IsChecked = false;
            radMenuItemOffice2013L.IsChecked = false;
            radMenuItemOffice2013D.IsChecked = false;
            radMenuItemOffice2010S.IsChecked = false;
            radMenuItemOffice2010Bl.IsChecked = false;
            radMenuItemOffice2007S.IsChecked = false;
            radMenuItemThHQB.IsChecked = true;
            radMenuItemThOffice2007B.IsChecked = false;
            radMenuItemThDesert.IsChecked = false;
            radMenuItemThAqua.IsChecked = false;
            radMenuItemThBreeze.IsChecked = false;
            radMenuItemThMetro.IsChecked = false;
        }

        private void radMenuItemThOffice2007B_Click(object sender, EventArgs e)
        {
            ThemeResolutionService.ApplicationThemeName = "Office2007Black";
            radMenuItemThDefault.IsChecked = false;
            radMenuItemOffice2010Blu.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemWin8.IsChecked = false;
            radMenuItemWin7.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemVS2012D.IsChecked = false;
            radMenuItemMetroTouch.IsChecked = false;
            radMenuItemMetroBlue.IsChecked = false;
            radMenuItemOffice2013L.IsChecked = false;
            radMenuItemOffice2013D.IsChecked = false;
            radMenuItemOffice2010S.IsChecked = false;
            radMenuItemOffice2010Bl.IsChecked = false;
            radMenuItemOffice2007S.IsChecked = false;
            radMenuItemThHQB.IsChecked = false;
            radMenuItemThOffice2007B.IsChecked = true;
            radMenuItemThDesert.IsChecked = false;
            radMenuItemThAqua.IsChecked = false;
            radMenuItemThBreeze.IsChecked = false;
            radMenuItemThMetro.IsChecked = false;
        }

        private void radMenuItemOffice2007S_Click(object sender, EventArgs e)
        {
            ThemeResolutionService.ApplicationThemeName = "Office2007Silver";
            radMenuItemThDefault.IsChecked = false;
            radMenuItemOffice2010Blu.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemWin8.IsChecked = false;
            radMenuItemWin7.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemVS2012D.IsChecked = false;
            radMenuItemMetroTouch.IsChecked = false;
            radMenuItemMetroBlue.IsChecked = false;
            radMenuItemOffice2013L.IsChecked = false;
            radMenuItemOffice2013D.IsChecked = false;
            radMenuItemOffice2010S.IsChecked = false;
            radMenuItemOffice2010Bl.IsChecked = false;
            radMenuItemOffice2007S.IsChecked = true;
            radMenuItemThHQB.IsChecked = false;
            radMenuItemThOffice2007B.IsChecked = false;
            radMenuItemThDesert.IsChecked = false;
            radMenuItemThAqua.IsChecked = false;
            radMenuItemThBreeze.IsChecked = false;
            radMenuItemThMetro.IsChecked = false;
        }

        private void radMenuItemOffice2010Bl_Click(object sender, EventArgs e)
        {
            ThemeResolutionService.ApplicationThemeName = "Office2010Black";
            radMenuItemThDefault.IsChecked = false;
            radMenuItemOffice2010Blu.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemWin8.IsChecked = false;
            radMenuItemWin7.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemVS2012D.IsChecked = false;
            radMenuItemMetroTouch.IsChecked = false;
            radMenuItemMetroBlue.IsChecked = false;
            radMenuItemOffice2013L.IsChecked = false;
            radMenuItemOffice2013D.IsChecked = false;
            radMenuItemOffice2010S.IsChecked = false;
            radMenuItemOffice2010Bl.IsChecked = true;
            radMenuItemOffice2007S.IsChecked = false;
            radMenuItemThHQB.IsChecked = false;
            radMenuItemThOffice2007B.IsChecked = false;
            radMenuItemThDesert.IsChecked = false;
            radMenuItemThAqua.IsChecked = false;
            radMenuItemThBreeze.IsChecked = false;
            radMenuItemThMetro.IsChecked = false;
        }

        private void radMenuItemOffice2010S_Click(object sender, EventArgs e)
        {
            ThemeResolutionService.ApplicationThemeName = "Office2010Silver";
            radMenuItemThDefault.IsChecked = false;
            radMenuItemOffice2010Blu.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemWin8.IsChecked = false;
            radMenuItemWin7.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemVS2012D.IsChecked = false;
            radMenuItemMetroTouch.IsChecked = false;
            radMenuItemMetroBlue.IsChecked = false;
            radMenuItemOffice2013L.IsChecked = false;
            radMenuItemOffice2013D.IsChecked = false;
            radMenuItemOffice2010S.IsChecked = true;
            radMenuItemOffice2010Bl.IsChecked = false;
            radMenuItemOffice2007S.IsChecked = false;
            radMenuItemThHQB.IsChecked = false;
            radMenuItemThOffice2007B.IsChecked = false;
            radMenuItemThDesert.IsChecked = false;
            radMenuItemThAqua.IsChecked = false;
            radMenuItemThBreeze.IsChecked = false;
            radMenuItemThMetro.IsChecked = false;
        }

        private void radMenuItemOffice2013D_Click(object sender, EventArgs e)
        {
            ThemeResolutionService.ApplicationThemeName = "Office2013Dark";
            radMenuItemThDefault.IsChecked = false;
            radMenuItemOffice2010Blu.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemWin8.IsChecked = false;
            radMenuItemWin7.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemVS2012D.IsChecked = false;
            radMenuItemMetroTouch.IsChecked = false;
            radMenuItemMetroBlue.IsChecked = false;
            radMenuItemOffice2013L.IsChecked = false;
            radMenuItemOffice2013D.IsChecked = true;
            radMenuItemOffice2010S.IsChecked = false;
            radMenuItemOffice2010Bl.IsChecked = false;
            radMenuItemOffice2007S.IsChecked = false;
            radMenuItemThHQB.IsChecked = false;
            radMenuItemThOffice2007B.IsChecked = false;
            radMenuItemThDesert.IsChecked = false;
            radMenuItemThAqua.IsChecked = false;
            radMenuItemThBreeze.IsChecked = false;
            radMenuItemThMetro.IsChecked = false;
        }

        private void radMenuItemOffice2013L_Click(object sender, EventArgs e)
        {
            ThemeResolutionService.ApplicationThemeName = "Office2013Light";
            radMenuItemThDefault.IsChecked = false;
            radMenuItemOffice2010Blu.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemWin8.IsChecked = false;
            radMenuItemWin7.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemVS2012D.IsChecked = false;
            radMenuItemMetroTouch.IsChecked = false;
            radMenuItemMetroBlue.IsChecked = false;
            radMenuItemOffice2013L.IsChecked = true;
            radMenuItemOffice2013D.IsChecked = false;
            radMenuItemOffice2010S.IsChecked = false;
            radMenuItemOffice2010Bl.IsChecked = false;
            radMenuItemOffice2007S.IsChecked = false;
            radMenuItemThHQB.IsChecked = false;
            radMenuItemThOffice2007B.IsChecked = false;
            radMenuItemThDesert.IsChecked = false;
            radMenuItemThAqua.IsChecked = false;
            radMenuItemThBreeze.IsChecked = false;
            radMenuItemThMetro.IsChecked = false;
        }

        private void radMenuItemMetroBlue_Click(object sender, EventArgs e)
        {
            ThemeResolutionService.ApplicationThemeName = "TelerikMetroBlue";
            radMenuItemThDefault.IsChecked = false;
            radMenuItemOffice2010Blu.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemWin8.IsChecked = false;
            radMenuItemWin7.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemVS2012D.IsChecked = false;
            radMenuItemMetroTouch.IsChecked = true;
            radMenuItemMetroBlue.IsChecked = false;
            radMenuItemOffice2013L.IsChecked = false;
            radMenuItemOffice2013D.IsChecked = false;
            radMenuItemOffice2010S.IsChecked = false;
            radMenuItemOffice2010Bl.IsChecked = false;
            radMenuItemOffice2007S.IsChecked = false;
            radMenuItemThHQB.IsChecked = false;
            radMenuItemThOffice2007B.IsChecked = false;
            radMenuItemThDesert.IsChecked = false;
            radMenuItemThAqua.IsChecked = false;
            radMenuItemThBreeze.IsChecked = false;
            radMenuItemThMetro.IsChecked = false;
        }

        private void radMenuItemMetroTouch_Click(object sender, EventArgs e)
        {
            ThemeResolutionService.ApplicationThemeName = "TelerikMetroTouch";
            radMenuItemThDefault.IsChecked = false;
            radMenuItemOffice2010Blu.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemWin8.IsChecked = false;
            radMenuItemWin7.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemVS2012D.IsChecked = false;
            radMenuItemMetroTouch.IsChecked = true;
            radMenuItemMetroBlue.IsChecked = false;
            radMenuItemOffice2013L.IsChecked = false;
            radMenuItemOffice2013D.IsChecked = false;
            radMenuItemOffice2010S.IsChecked = false;
            radMenuItemOffice2010Bl.IsChecked = false;
            radMenuItemOffice2007S.IsChecked = false;
            radMenuItemThHQB.IsChecked = false;
            radMenuItemThOffice2007B.IsChecked = false;
            radMenuItemThDesert.IsChecked = false;
            radMenuItemThAqua.IsChecked = false;
            radMenuItemThBreeze.IsChecked = false;
            radMenuItemThMetro.IsChecked = false;
        }

        private void radMenuItemVS2012D_Click(object sender, EventArgs e)
        {
            ThemeResolutionService.ApplicationThemeName = "VisualStudio2012Dark";
            radMenuItemThDefault.IsChecked = false;
            radMenuItemOffice2010Blu.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemWin8.IsChecked = false;
            radMenuItemWin7.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemVS2012D.IsChecked = true;
            radMenuItemMetroTouch.IsChecked = false;
            radMenuItemMetroBlue.IsChecked = false;
            radMenuItemOffice2013L.IsChecked = false;
            radMenuItemOffice2013D.IsChecked = false;
            radMenuItemOffice2010S.IsChecked = false;
            radMenuItemOffice2010Bl.IsChecked = false;
            radMenuItemOffice2007S.IsChecked = false;
            radMenuItemThHQB.IsChecked = false;
            radMenuItemThOffice2007B.IsChecked = false;
            radMenuItemThDesert.IsChecked = false;
            radMenuItemThAqua.IsChecked = false;
            radMenuItemThBreeze.IsChecked = false;
            radMenuItemThMetro.IsChecked = false;
        }

        private void radMenuItemVS2012L_Click(object sender, EventArgs e)
        {
            ThemeResolutionService.ApplicationThemeName = "VisualStudio2012Light";
            radMenuItemThDefault.IsChecked = false;
            radMenuItemOffice2010Blu.IsChecked = false;
            radMenuItemVS2012L.IsChecked = true;
            radMenuItemWin8.IsChecked = false;
            radMenuItemWin7.IsChecked = false;
            radMenuItemVS2012D.IsChecked = false;
            radMenuItemMetroTouch.IsChecked = false;
            radMenuItemMetroBlue.IsChecked = false;
            radMenuItemOffice2013L.IsChecked = false;
            radMenuItemOffice2013D.IsChecked = false;
            radMenuItemOffice2010S.IsChecked = false;
            radMenuItemOffice2010Bl.IsChecked = false;
            radMenuItemOffice2007S.IsChecked = false;
            radMenuItemThHQB.IsChecked = false;
            radMenuItemThOffice2007B.IsChecked = false;
            radMenuItemThDesert.IsChecked = false;
            radMenuItemThAqua.IsChecked = false;
            radMenuItemThBreeze.IsChecked = false;
            radMenuItemThMetro.IsChecked = false;
        }

        private void radMenuItemWin7_Click(object sender, EventArgs e)
        {
            ThemeResolutionService.ApplicationThemeName = "Windows7";
            radMenuItemThDefault.IsChecked = false;
            radMenuItemOffice2010Blu.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemWin8.IsChecked = false;
            radMenuItemWin7.IsChecked = true;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemVS2012D.IsChecked = false;
            radMenuItemMetroTouch.IsChecked = false;
            radMenuItemMetroBlue.IsChecked = false;
            radMenuItemOffice2013L.IsChecked = false;
            radMenuItemOffice2013D.IsChecked = false;
            radMenuItemOffice2010S.IsChecked = false;
            radMenuItemOffice2010Bl.IsChecked = false;
            radMenuItemOffice2007S.IsChecked = false;
            radMenuItemThHQB.IsChecked = false;
            radMenuItemThOffice2007B.IsChecked = false;
            radMenuItemThDesert.IsChecked = false;
            radMenuItemThAqua.IsChecked = false;
            radMenuItemThBreeze.IsChecked = false;
            radMenuItemThMetro.IsChecked = false;
        }

        private void radMenuItemWin8_Click(object sender, EventArgs e)
        {
            ThemeResolutionService.ApplicationThemeName = "Windows8";
            radMenuItemThDefault.IsChecked = false;
            radMenuItemOffice2010Blu.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemWin8.IsChecked = true;
            radMenuItemWin7.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemVS2012D.IsChecked = false;
            radMenuItemMetroTouch.IsChecked = false;
            radMenuItemMetroBlue.IsChecked = false;
            radMenuItemOffice2013L.IsChecked = false;
            radMenuItemOffice2013D.IsChecked = false;
            radMenuItemOffice2010S.IsChecked = false;
            radMenuItemOffice2010Bl.IsChecked = false;
            radMenuItemOffice2007S.IsChecked = false;
            radMenuItemThHQB.IsChecked = false;
            radMenuItemThOffice2007B.IsChecked = false;
            radMenuItemThDesert.IsChecked = false;
            radMenuItemThAqua.IsChecked = false;
            radMenuItemThBreeze.IsChecked = false;
            radMenuItemThMetro.IsChecked = false;
        }

        private void radMenuItemOffice2010Blu_Click(object sender, EventArgs e)
        {
            ThemeResolutionService.ApplicationThemeName = "Office2010Blue";
            radMenuItemThDefault.IsChecked = false;
            radMenuItemOffice2010Blu.IsChecked = true;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemWin8.IsChecked = false;
            radMenuItemWin7.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemVS2012D.IsChecked = false;
            radMenuItemMetroTouch.IsChecked = false;
            radMenuItemMetroBlue.IsChecked = false;
            radMenuItemOffice2013L.IsChecked = false;
            radMenuItemOffice2013D.IsChecked = false;
            radMenuItemOffice2010S.IsChecked = false;
            radMenuItemOffice2010Bl.IsChecked = false;
            radMenuItemOffice2007S.IsChecked = false;
            radMenuItemThHQB.IsChecked = false;
            radMenuItemThOffice2007B.IsChecked = false;
            radMenuItemThDesert.IsChecked = false;
            radMenuItemThAqua.IsChecked = false;
            radMenuItemThBreeze.IsChecked = false;
            radMenuItemThMetro.IsChecked = false;
        }

       

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void radMenuItemThDefault_Click(object sender, EventArgs e)
        {
            ThemeResolutionService.ApplicationThemeName = "";
            radMenuItemThDefault.IsChecked = true;
            radMenuItemOffice2010Blu.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemWin8.IsChecked = false;
            radMenuItemWin7.IsChecked = false;
            radMenuItemVS2012L.IsChecked = false;
            radMenuItemVS2012D.IsChecked = false;
            radMenuItemMetroTouch.IsChecked = false;
            radMenuItemMetroBlue.IsChecked = false;
            radMenuItemOffice2013L.IsChecked = false;
            radMenuItemOffice2013D.IsChecked = false;
            radMenuItemOffice2010S.IsChecked = false;
            radMenuItemOffice2010Bl.IsChecked = false;
            radMenuItemOffice2007S.IsChecked = false;
            radMenuItemThHQB.IsChecked = false;
            radMenuItemThOffice2007B.IsChecked = false;
            radMenuItemThDesert.IsChecked = false;
            radMenuItemThAqua.IsChecked = false;
            radMenuItemThBreeze.IsChecked = false;
            radMenuItemThMetro.IsChecked = false;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Theme = ThemeResolutionService.ApplicationThemeName;
            Properties.Settings.Default.th1 = radMenuItemThMetro.IsChecked;
            Properties.Settings.Default.th2 = radMenuItemThBreeze.IsChecked;
            Properties.Settings.Default.th3 = radMenuItemThAqua.IsChecked;
            Properties.Settings.Default.th4 = radMenuItemThDesert.IsChecked;
            Properties.Settings.Default.th5 = radMenuItemThOffice2007B.IsChecked;
            Properties.Settings.Default.th6 = radMenuItemThHQB.IsChecked;
            Properties.Settings.Default.th7 = radMenuItemOffice2007S.IsChecked;
            Properties.Settings.Default.th8 = radMenuItemOffice2010Bl.IsChecked;
            Properties.Settings.Default.th9 = radMenuItemOffice2010S.IsChecked;
            Properties.Settings.Default.th10 = radMenuItemOffice2013D.IsChecked;
            Properties.Settings.Default.th11 = radMenuItemOffice2013L.IsChecked;
            Properties.Settings.Default.th12 = radMenuItemMetroBlue.IsChecked;
            Properties.Settings.Default.th13 = radMenuItemMetroTouch.IsChecked;
            Properties.Settings.Default.th14 = radMenuItemVS2012D.IsChecked;
            Properties.Settings.Default.th15 = radMenuItemVS2012L.IsChecked;
            Properties.Settings.Default.th16 = radMenuItemWin7.IsChecked;
            Properties.Settings.Default.th17 = radMenuItemWin8.IsChecked;
            Properties.Settings.Default.th18 = radMenuItemOffice2010Blu.IsChecked;
            Properties.Settings.Default.th19 = radMenuItemThDefault.IsChecked;


            

            Properties.Settings.Default.Save();

            Application.ExitThread();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                clsToDoTask tasks = new clsToDoTask();
                DataTable dt = tasks.GetAllUndoneTasks(new clsUser().GetUserID(this.radLabelElementUsername.Text));
                DateTime now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DateTime tdt = Convert.ToDateTime(dt.Rows[i][2].ToString());
                    DateTime taskDateTime = new DateTime(tdt.Year, tdt.Month, tdt.Day, tdt.Hour, tdt.Minute, tdt.Second);
                    if (now.CompareTo(taskDateTime) == 0)
                    {
                        frmTaskReminder frm = new frmTaskReminder(dt.Rows[i][1].ToString());
                        frm.ShowDialog();
                    }
                }

                int userId = new clsUser().GetUserID(this.radLabelElementUsername.Text);
                this.lblMsgCount.Text = new clsMessage().GetMessagesCount(userId).ToString();
                // frmMessages.GetFrmMessages.msgsGridView.DataSource = new clsMessage().GetAll(userId);
            }
            catch { }
        }

        public string stateMute = "mute";
        private void btnAllowNot_Click(object sender, EventArgs e)
        {
            if (stateMute == "mute")
            {
                aTimer.Enabled = false;
                stateMute = "unmute";
                this.btnAllowNot.Text = "Notifications OFF";
                this.btnAllowNot.IsChecked = true;
            }
            else
            {
                aTimer.Enabled = true;
                stateMute = "mute";
                this.btnAllowNot.Text = "Notifications ON";
                this.btnAllowNot.IsChecked = false;
            }
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            frmMessages.GetFrmMessages.Show();
            frmMessages.GetFrmMessages.BringToFront();
            frmMessages.GetFrmMessages.WindowState = FormWindowState.Normal;
        }

        private void radMenuItemAbout_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

        private void btnDailyTasks_Click(object sender, EventArgs e)
        {
            frmDoneTasks.GetFrmDoneTasks.Show();
            frmDoneTasks.GetFrmDoneTasks.BringToFront();
            frmDoneTasks.GetFrmDoneTasks.WindowState = FormWindowState.Normal;
        }

        private void radMenuItem3_Click(object sender, EventArgs e)
        {
            frmBackgrounds frm = new frmBackgrounds();
            frm.ShowDialog();
        }

        private void btnWorkAss_Click(object sender, EventArgs e)
        {
            frmWorkAssignments.GetFrmWorkAssignments.Show();
            frmWorkAssignments.GetFrmWorkAssignments.BringToFront();
            frmWorkAssignments.GetFrmWorkAssignments.WindowState = FormWindowState.Normal;
        }

        private void btn3GSims_Click(object sender, EventArgs e)
        {
            frm3GSimCards.GetFrm3GSimCards.Show();
            frm3GSimCards.GetFrm3GSimCards.BringToFront();
            frm3GSimCards.GetFrm3GSimCards.WindowState = FormWindowState.Normal;
        }

        private void btnOutbound_Click(object sender, EventArgs e)
        {
            frmOutboundRecord.GetFrmOutboundRecords.Show();
            frmOutboundRecord.GetFrmOutboundRecords.BringToFront();
            frmOutboundRecord.GetFrmOutboundRecords.WindowState = FormWindowState.Normal;
        }

        private void btnPinger_Click(object sender, EventArgs e)
        {
            frmPingIP.GetFrmPingIP.Show();
            frmPingIP.GetFrmPingIP.BringToFront();
            frmPingIP.GetFrmPingIP.WindowState = FormWindowState.Normal;
        }

        private void radMenuItemSIFServers_Click(object sender, EventArgs e)
        {
            frmSIFServers.GetFrmSIFServers.Show();
            frmSIFServers.GetFrmSIFServers.BringToFront();
            frmSIFServers.GetFrmSIFServers.WindowState = FormWindowState.Normal;
        }

        private void radMenuItemBackupRestore_Click(object sender, EventArgs e)
        {
            frmBackUpDB frm = new frmBackUpDB();
            frm.ShowDialog();
        }

        private void btnServersShutdown_Click(object sender, EventArgs e)
        {
            frmServersShutdown.GetFrmServersShutdown.Show();
            frmServersShutdown.GetFrmServersShutdown.BringToFront();
            frmServersShutdown.GetFrmServersShutdown.WindowState = FormWindowState.Normal;
        }

        private void btnRemoteDesktop_Click(object sender, EventArgs e)
        {
            frmConnectRemoteDesktop.GetFrmConnectRemoteDesktop.Show();
            frmConnectRemoteDesktop.GetFrmConnectRemoteDesktop.BringToFront();
            frmConnectRemoteDesktop.GetFrmConnectRemoteDesktop.WindowState = FormWindowState.Normal;
        }

        private void btnDocs_Click(object sender, EventArgs e)
        {
            frmDocuments.GetFrmDocuments.Show();
            frmDocuments.GetFrmDocuments.BringToFront();
            frmDocuments.GetFrmDocuments.WindowState = FormWindowState.Normal;
        }

        private void radMenuItemChangePw_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.ShowDialog();
        }

        private void btnEmails_Click(object sender, EventArgs e)
        {
            frmEmails.GetFrmEmails.Show();
            frmEmails.GetFrmEmails.BringToFront();
            frmEmails.GetFrmEmails.WindowState = FormWindowState.Normal;
        }

        private void btnMaintenances_Click(object sender, EventArgs e)
        {
            frmMaintenancesApp.GetFrmMaintenancesApp.Show();
            frmMaintenancesApp.GetFrmMaintenancesApp.BringToFront();
            frmMaintenancesApp.GetFrmMaintenancesApp.WindowState = FormWindowState.Normal;
        }

        private void btnMaint_Click(object sender, EventArgs e)
        {
            frmMaintenancesApp.GetFrmMaintenancesApp.Show();
            frmMaintenancesApp.GetFrmMaintenancesApp.BringToFront();
            frmMaintenancesApp.GetFrmMaintenancesApp.WindowState = FormWindowState.Normal;
        }

        private void btnPayDocs_Click(object sender, EventArgs e)
        {
            frmPayDocs.GetFrmPayDocs.Show();
            frmPayDocs.GetFrmPayDocs.BringToFront();
            frmPayDocs.GetFrmPayDocs.WindowState = FormWindowState.Normal;
        }

        private void btnSurAlarm_Click(object sender, EventArgs e)
        {
            frmSurvAlarms.GetFrmSurvAlarms.Show();
            frmSurvAlarms.GetFrmSurvAlarms.BringToFront();
            frmSurvAlarms.GetFrmSurvAlarms.WindowState = FormWindowState.Normal;
        }
    }
}
