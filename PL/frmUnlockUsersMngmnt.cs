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
    public partial class frmUnlockUsersMngmnt : Telerik.WinControls.UI.RadForm
    {
        private static frmUnlockUsersMngmnt frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static frmUnlockUsersMngmnt GetFrmUnlockUsersMngmnt
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmUnlockUsersMngmnt();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public frmUnlockUsersMngmnt()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            if (txtPw.Text == "ShQ@86754" || txtPw.Text == "S0S@1979")
            {
                frmUsersMng.GetFrmUsersMngTypes.Show();
                frmUsersMng.GetFrmUsersMngTypes.BringToFront();
                frmUsersMng.GetFrmUsersMngTypes.WindowState = FormWindowState.Normal;
                frmUnlockUsersMngmnt.GetFrmUnlockUsersMngmnt.Close();
            }
            else
            {
                MessageBox.Show("Invalid Unlock Code", "Locked", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmUnlockUsersMngmnt_Load(object sender, EventArgs e)
        {
            
        }
    }
}
