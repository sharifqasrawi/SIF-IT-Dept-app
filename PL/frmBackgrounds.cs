using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace IT_Dept.PL
{
    public partial class frmBackgrounds : Telerik.WinControls.UI.RadForm
    {
        public frmBackgrounds()
        {
            InitializeComponent();
            rbBg2.IsChecked = Properties.Settings.Default.rbg2;
            rbBg3.IsChecked = Properties.Settings.Default.rbg3;
            rbBg4.IsChecked = Properties.Settings.Default.rbg4;
            rbBg5.IsChecked = Properties.Settings.Default.rbbg5;
            rbBg6.IsChecked = Properties.Settings.Default.rbg6;
            rbBg9.IsChecked = Properties.Settings.Default.rbbg9;
            rbBg10.IsChecked = Properties.Settings.Default.rbbg10;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            if(rbBg2.IsChecked)
            {
                frmMain.GetFrmMain.BackgroundImage = Properties.Resources.bg2;
                
                Properties.Resources.bg2.Save(ms, ImageFormat.Jpeg);
                Properties.Settings.Default.bg = Convert.ToBase64String(ms.ToArray());
                Properties.Settings.Default.rbg2 = rbBg2.IsChecked;
            }
            else if(rbBg3.IsChecked)
            {
                frmMain.GetFrmMain.BackgroundImage = Properties.Resources.bg3;
                Properties.Resources.bg3.Save(ms, ImageFormat.Jpeg);
                Properties.Settings.Default.bg = Convert.ToBase64String(ms.ToArray());

                Properties.Settings.Default.rbg3 = rbBg3.IsChecked;
            }
            else if (rbBg4.IsChecked)
            {
                frmMain.GetFrmMain.BackgroundImage = Properties.Resources.bg4;
                Properties.Resources.bg4.Save(ms, ImageFormat.Jpeg);
                Properties.Settings.Default.bg = Convert.ToBase64String(ms.ToArray());

                Properties.Settings.Default.rbg4 = rbBg4.IsChecked;
            }
            else if (rbBg5.IsChecked)
            {
                frmMain.GetFrmMain.BackgroundImage = Properties.Resources.bg5;
                Properties.Resources.bg5.Save(ms, ImageFormat.Jpeg);
                Properties.Settings.Default.bg = Convert.ToBase64String(ms.ToArray());

                Properties.Settings.Default.rbbg5 = rbBg5.IsChecked;
            }
            else if (rbBg6.IsChecked)
            {
                frmMain.GetFrmMain.BackgroundImage = Properties.Resources.bg6;
                Properties.Resources.bg6.Save(ms, ImageFormat.Jpeg);
                Properties.Settings.Default.bg = Convert.ToBase64String(ms.ToArray());

                Properties.Settings.Default.rbg6 = rbBg6.IsChecked;
            }
            else if (rbBg9.IsChecked)
            {
                frmMain.GetFrmMain.BackgroundImage = Properties.Resources.bg9;
                Properties.Resources.bg9.Save(ms, ImageFormat.Jpeg);
                Properties.Settings.Default.bg = Convert.ToBase64String(ms.ToArray());

                Properties.Settings.Default.rbbg9 = rbBg9.IsChecked;
            }
            else if (rbBg10.IsChecked)
            {
                frmMain.GetFrmMain.BackgroundImage = Properties.Resources.b10;
                Properties.Resources.b10.Save(ms, ImageFormat.Jpeg);
                Properties.Settings.Default.bg = Convert.ToBase64String(ms.ToArray());

                Properties.Settings.Default.rbbg10 = rbBg10.IsChecked;
            }
            else if (rbBg11.IsChecked)
            {
                frmMain.GetFrmMain.BackgroundImage = Properties.Resources.bg11;
                Properties.Resources.b10.Save(ms, ImageFormat.Jpeg);
                Properties.Settings.Default.bg = Convert.ToBase64String(ms.ToArray());

                Properties.Settings.Default.rbg11 = rbBg10.IsChecked;
            }
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void frmBackgrounds_Load(object sender, EventArgs e)
        {

        }
    }
}
