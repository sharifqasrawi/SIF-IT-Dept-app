using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using IT_Dept.BL;
using MSTSCLib;
using System.Diagnostics;

namespace IT_Dept.PL
{
    public partial class frmConnectRemoteDesktop : Telerik.WinControls.UI.RadForm
    {

        private static frmConnectRemoteDesktop frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static frmConnectRemoteDesktop GetFrmConnectRemoteDesktop
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmConnectRemoteDesktop();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public frmConnectRemoteDesktop()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }

        private void frmConnectRemoteDesktop_Load(object sender, EventArgs e)
        {
            this.lstServers.DataSource = new clsSIFServer().GetAll();
            this.lstServers.DisplayMember = "Server Name";
            this.lstServers.ValueMember = "Server IP";


        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Process rdcProcess = new Process();

            rdcProcess.StartInfo.FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\mstsc.exe");
            rdcProcess.StartInfo.Arguments = "/v " + lstServers.SelectedValue.ToString(); // ip or name of computer to connect
            rdcProcess.Start();
            
        }
    }
}
