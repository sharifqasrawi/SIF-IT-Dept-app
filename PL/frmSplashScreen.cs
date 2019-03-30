using IT_Dept.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_Dept.PL
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();

           
        }
        Timer tmr;
        private void frmSplashScreen_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();

            //set time interval 3 sec

            tmr.Interval = 3000;

            //starts the timer

            tmr.Start();

            tmr.Tick += tmr_Tick;

           
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            bool registered = Properties.Settings.Default.rbg11;
            bool reg = false;
            if (File.Exists("License.txt"))
            {
                string key = File.ReadAllText("License.txt").Trim();
                if (key == clsFingerprint.ActivationValue("Sharif"))
                {
                    reg = true;
                }
                else
                {
                    reg = false;
                }
            }
            if (reg)
            {
                this.Hide();
                new frmMain().Show();
            }
            else
            {
                this.Hide();
                new frmActivate().Show();
            }
        }
    }
}
