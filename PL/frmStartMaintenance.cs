using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using IT_Dept.BL;

namespace IT_Dept.PL
{
    public partial class frmStartMaintenance : Telerik.WinControls.UI.RadForm
    {
        int id;
        public frmStartMaintenance(int id)
        {
            InitializeComponent();
            this.id = id;

            this.date.Value = DateTime.Now;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsMaintenanceApp m = new clsMaintenanceApp(id, txtProb.Text, date.Value, txtNotes.Text, "Awaiting");
            m.Start();

            clsUser user = new clsUser();

            int userID = new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text);

            frmMaintenancesApp.GetFrmMaintenancesApp.btnMyMaintenances.Text = "My Current Maintenances (" + new clsMaintenanceApp().GetCountUserMaintenances(userID).ToString() + ")";

            frmMaintenancesApp.GetFrmMaintenancesApp.btnCurM.Text = "All Current Maintenances (" + new clsMaintenanceApp().GetCountCurrentMaintenances().ToString() + ")";

            frmMaintenancesApp.GetFrmMaintenancesApp.btnAllm.Text = "All Finished Maintenances (" + new clsMaintenanceApp().GetCountFinishedMaintenances().ToString() + ")";

            this.Close();
        }

        private void frmStartMaintenance_Load(object sender, EventArgs e)
        {
            clsUser user = new clsUser();

            int userID = new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text);

            if (user.IsInRole(userID, "Admin"))
            {
                this.date.Enabled = true;
            }

            if (user.IsInRole(userID, "EditDate"))
            {
                this.date.Enabled = true;
            }
        }
    }
}
