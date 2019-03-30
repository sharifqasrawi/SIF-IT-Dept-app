using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using IT_Dept.BL;
using System.IO;

namespace IT_Dept.PL
{
    public partial class frmActivate : Telerik.WinControls.UI.RadForm
    {
        public frmActivate()
        {
            InitializeComponent();
            if (!File.Exists(Application.StartupPath + "\\License.txt"))
            {
                File.Create(Application.StartupPath + "\\License.txt");
            }
        }

        private void frmActivate_Load(object sender, EventArgs e)
        {
            this.txtUID.Text = clsFingerprint.Value();

            ThemeResolutionService.ApplicationThemeName = "Breeze";
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(clsFingerprint.ActivationValue( "Sharif"));
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtUID.Text);
            MessageBox.Show("UID copied to Clipboard", "Clipboard", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmActivate_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            string ActivationKey = File.ReadAllText(txtSource.Text).Trim();

           
            File.WriteAllText(Application.StartupPath + "\\License.txt", ActivationKey);
         
            bool reg = false;
            if (File.Exists("License.txt"))
            {
                string key = File.ReadAllText("License.txt").Trim();
                if (key == clsFingerprint.ActivationValue("SharifQasrawi"))
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
                MessageBox.Show("Product Activated!!\nPlease restart application.", "Activation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.ExitThread();
            }
            else
            {
                MessageBox.Show("Invalid License File", "Activation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
              

            
           // File.WriteAllText(Path.GetFileName(txtDestination.Text),ActivationKey);
        }

        private void btnOpenFile1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files (*.txt) |*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.txtSource.Text = ofd.FileName;
            }
        }
    }
}
