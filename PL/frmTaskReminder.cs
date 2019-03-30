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
    public partial class frmTaskReminder : Telerik.WinControls.UI.RadForm
    {
        public frmTaskReminder(string task)
        {
            InitializeComponent();
            this.textBox1.Text = task;
        }

        private void frmTaskReminder_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            this.WindowState = FormWindowState.Normal;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources._4f_here_I_am);
            player.Play();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
