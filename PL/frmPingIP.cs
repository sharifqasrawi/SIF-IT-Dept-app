using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Net;
using Telerik.WinControls;
using IT_Dept.BL;
using System.Text.RegularExpressions;

namespace IT_Dept.PL
{
    public partial class frmPingIP : Telerik.WinControls.UI.RadForm
    {
        private static frmPingIP frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static frmPingIP GetFrmPingIP
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmPingIP();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }

        Thread thread;
        public frmPingIP()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;

            this.rbCenterServer.IsChecked = true;
            clsCenter c = new clsCenter();

            this.lstIPs.DataSource = c.GetAll();
            this.lstIPs.DisplayMember = "Center name";
            this.lstIPs.ValueMember = "Server IP";
            this.lstIPs.SelectedIndex = 0;
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            thread = new Thread(thread1);
            this.btnPing.Enabled = false;
            this.btnPing.BackgroundImage = Properties.Resources.Free_Ping_Service;
            thread.Start();
        }

        public void thread1()
        {
            try
            {
                string command = "";
                if (rbCenterServer.IsChecked || rbCenterCon.IsChecked || rbSifServer.IsChecked)
                {
                    
                    command = "/c ping " + lstIPs.SelectedValue.ToString();
                }
                else if(rbOtherIP.IsChecked)
                {
                    if (!IsValidIP(txtIP.Text))
                    {
                        lblMsg.Text = "Invalid IP Address";
                        this.btnPing.Enabled = true;
                        this.btnPing.BackgroundImage = Properties.Resources.unnamed;
                    }
                    else
                    {
                        lblMsg.Text = "";
                        command = "/c ping " + txtIP.Text;
                    }
                }
                ProcessStartInfo psi = new ProcessStartInfo("CMD", command);
                Process process = new Process();
                process.StartInfo = psi;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.OutputDataReceived += new DataReceivedEventHandler(podr);
                process.Start();
                process.BeginOutputReadLine();
                process.WaitForExit();
                this.btnPing.Enabled = true;
                this.btnPing.BackgroundImage = Properties.Resources.unnamed;
            }
            catch(Exception)
            {
                MessageBox.Show("Error","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.btnPing.Enabled = true;
                this.btnPing.BackgroundImage = Properties.Resources.unnamed;
            }
        }

        private void podr(object sender, DataReceivedEventArgs e)
        {
            try
            {
                if (e.Data != null)
                {
                    string newLine = e.Data.Trim() + Environment.NewLine;
                    MethodInvoker append = () => txtPingResults.Text += newLine;
                    txtPingResults.BeginInvoke(append);

                    txtPingResults.SelectionStart = txtPingResults.TextLength;
                    txtPingResults.ScrollToCaret();
                }
            }
            catch
            {

            }
        }

        private void frmPingIP_Load(object sender, EventArgs e)
        {
          
        }

        private void rbOtherIP_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (this.rbOtherIP.IsChecked)
            {
                this.txtIP.Enabled = true;
                this.lstIPs.Enabled = false;
            }
        }

        private void rbCenterServer_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.txtIP.Enabled = false;
            this.lstIPs.Enabled = true;
            this.txtIP.Clear();
            this.lblMsg.Text = "";

            clsCenter c = new clsCenter();

            this.lstIPs.DataSource = c.GetAll();
            this.lstIPs.DisplayMember = "Center name";
            this.lstIPs.ValueMember = "Server IP";
            this.lstIPs.SelectedIndex = 0;
            this.lstIPs.Rebind();

        }

        private void rbCenterCon_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.txtIP.Enabled = false;
            this.lstIPs.Enabled = true;
            this.txtIP.Clear();
            this.lblMsg.Text = "";

            clsCenter c = new clsCenter();

            this.lstIPs.DataSource = c.GetAll();
            this.lstIPs.DisplayMember = "Center name";
            this.lstIPs.ValueMember = "Connection IP";
            this.lstIPs.SelectedIndex = 0;
            this.lstIPs.Rebind();
        }

        private void rbSifServer_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.txtIP.Enabled = false;
            this.lstIPs.Enabled = true;
            this.txtIP.Clear();
            this.lblMsg.Text = "";

            clsSIFServer s = new clsSIFServer();

            this.lstIPs.DataSource = s.GetAll();
            this.lstIPs.DisplayMember = "Server Name";
            this.lstIPs.ValueMember = "Server IP";
            this.lstIPs.SelectedIndex = 0;
            this.lstIPs.Rebind();
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPingResults.Clear();
        }

        public bool IsValidIP(string addr)
        {
            //create our match pattern
            string pattern = @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$";
            //create our Regular Expression object
            Regex check = new Regex(pattern);
            //boolean variable to hold the status
            bool valid = false;
            //check to make sure an ip address was provided
            if (addr == "")
            {
                //no address provided so return false
                valid = false;
            }
            else
            {
                //address provided so use the IsMatch Method
                //of the Regular Expression object
                valid = check.IsMatch(addr, 0);
            }
            //return the results
            return valid;
        }

        private void frmPingIP_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void radButtonElement1_Click(object sender, EventArgs e)
        {

        }
    }
}
