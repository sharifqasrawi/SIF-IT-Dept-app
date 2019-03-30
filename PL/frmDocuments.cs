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
    public partial class frmDocuments : Telerik.WinControls.UI.RadForm
    {
        private static frmDocuments frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static frmDocuments GetFrmDocuments
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmDocuments();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public frmDocuments()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }

        private void btnWS_Click(object sender, EventArgs e)
        {
            frmCreateWorkAssignmentDoc f = new frmCreateWorkAssignmentDoc();
            f.ShowDialog();
        }

        private void frmDocuments_Load(object sender, EventArgs e)
        {

        }

        private void btnTravelAss_Click(object sender, EventArgs e)
        {
            frmCreateTravelAssignment f = new frmCreateTravelAssignment();
            f.ShowDialog();
        }

        private void btnDayOff_Click(object sender, EventArgs e)
        {
            frmDayOffs f = new frmDayOffs();
            f.ShowDialog();
        }
    }
}
