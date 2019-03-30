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
    public partial class frmRegisterApp : Telerik.WinControls.UI.RadForm
    {
        public frmRegisterApp()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtKey.Text == "AdnanYamenYasminTalaZaidAdam86754")
            {
                Properties.Settings.Default.rbg11 = true;
                Properties.Settings.Default.Save();
                MessageBox.Show("Welcome !!", "Registered", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Hide();
                new frmMain().Show();
                
            }
            else
            {
                MessageBox.Show("Invalid Key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
