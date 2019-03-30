using IT_Dept.BL;
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
    public partial class frmCloseMaintenance : Telerik.WinControls.UI.RadForm
    {
        int id;
        public frmCloseMaintenance(int id)
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
            clsMaintenanceApp m = new clsMaintenanceApp(id);
            m.CloseMaintenance(txtName.Text, Convert.ToDateTime(date.Value));

            // frmMaintenancesApp.GetFrmMaintenancesApp.curMGridView.DataSource = m.GetCurrentMaintenances();
            
            clsUser user = new clsUser();

            int userID = new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text);

            frmMaintenancesApp.GetFrmMaintenancesApp.myMaintGridView.DataSource = m.GetUsertMaintenances(userID);

            this.Close();
        }

        private void frmCloseMaintenance_Load(object sender, EventArgs e)
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
