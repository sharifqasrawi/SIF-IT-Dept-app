using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using IT_Dept.BL;
using System.Diagnostics;

namespace IT_Dept.PL
{
    public partial class frmServersShutdown : Telerik.WinControls.UI.RadForm
    {
        private static frmServersShutdown frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static frmServersShutdown GetFrmServersShutdown
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmServersShutdown();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public frmServersShutdown()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;

            clsSIFServer s = new clsSIFServer();
            this.lstServers.DataSource = s.GetAll();
            this.lstServers.DisplayMember = "Server Name";
            this.lstServers.ValueMember = "Server IP";

            for (int i = 0; i < lstServers.Items.Count; i++)
            {
                lstServers.Items[i].CheckState = Telerik.WinControls.Enumerations.ToggleState.Off;
            }
        }

        private void frmServersShutdown_Load(object sender, EventArgs e)
        {
            
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            string ServersToDelete = "";
            for (int i = 0; i < lstServers.CheckedItems.Count; i++)
            {
                ServersToDelete += lstServers.CheckedItems[i].Text.ToString() + " - " + lstServers.CheckedItems[i].Value.ToString() + "\n";
            }
            var msg = MessageBox.Show("Are you sure you want to SHUTDOWN these servers:\n" + ServersToDelete, "Confirm Shutdown", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                for (int i = 0; i < lstServers.CheckedItems.Count; i++)
                {
                    var shutdown = new ProcessStartInfo("shutdown", @"-m \\" + lstServers.CheckedItems[i].Value.ToString() + " -s -f -t 30");
                    shutdown.CreateNoWindow = true;
                    shutdown.UseShellExecute = false;
                    Process.Start(shutdown);
                }

                MessageBox.Show("Shutdown orders was sent to the selected servers", "Shutdown", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            
           
        }

        private void lstServers_ItemCheckedChanged(object sender, Telerik.WinControls.UI.ListViewItemEventArgs e)
        {
            if (this.lstServers.SelectedItem.CheckState == Telerik.WinControls.Enumerations.ToggleState.On)
            {
                if (this.lstServers.SelectedItem.Value.ToString() == "192.168.2.7")
                {
                    var msg = MessageBox.Show("Are you sure you want to check [ " + this.lstServers.SelectedItem.Text + " ] ??", "Confirm Check", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(msg == DialogResult.Yes)
                    {
                        this.lstServers.SelectedItem.CheckState = Telerik.WinControls.Enumerations.ToggleState.On;
                    }
                    else
                    {
                        this.lstServers.SelectedItem.CheckState = Telerik.WinControls.Enumerations.ToggleState.Off;
                    }
                }
                if (this.lstServers.SelectedItem.Value.ToString() == "192.168.2.12")
                {
                    var msg = MessageBox.Show("Are you sure you want to check [ " + this.lstServers.SelectedItem.Text + " ] ??", "Confirm Check", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        this.lstServers.SelectedItem.CheckState = Telerik.WinControls.Enumerations.ToggleState.On;
                    }
                    else
                    {
                        this.lstServers.SelectedItem.CheckState = Telerik.WinControls.Enumerations.ToggleState.Off;
                    }
                }
            }
        }

        private void lstServers_SelectedItemChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (this.lstServers.SelectedItem.CheckState == Telerik.WinControls.Enumerations.ToggleState.On)
            //        this.lstServers.SelectedItem.CheckState = Telerik.WinControls.Enumerations.ToggleState.Off;
            //    else
            //        this.lstServers.SelectedItem.CheckState = Telerik.WinControls.Enumerations.ToggleState.On;
            //}
            //catch { }
        }
    }
}
