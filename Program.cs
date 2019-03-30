using System;
using System.Linq;
using System.Windows.Forms;
using IT_Dept.PL;
using IT_Dept.BL;
using System.IO;

namespace IT_Dept
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
      //      Application.Run(new frmMaintenancesApp());
        //    Application.Run(new frmMain());
            bool registered = Properties.Settings.Default.rbg11;
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
                Application.Run(new frmMain());
            else
                Application.Run(new frmActivate());
        }
    }
}