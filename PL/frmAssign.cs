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
    public partial class frmAssign : Telerik.WinControls.UI.RadForm
    {
        int id;
        public frmAssign(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAssign_Load(object sender, EventArgs e)
        {
            this.lstUsers.DataSource = new clsUser().GetAllUsers(frmMain.GetFrmMain.radLabelElementUsername.Text);
            this.lstUsers.DisplayMember = "Username";
            this.lstUsers.ValueMember = "#";
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            clsUser user = new clsUser();

            int userID = new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text);

            clsMaintenanceApp m = new clsMaintenanceApp(id);

            DataTable dt = m.GetUserMaintenanceById();
            m.SetCurrentStatus("Finished");

            int newUserId = int.Parse(lstUsers.SelectedValue.ToString());
            DateTime newR_Date = new DateTime(9999, 12, 31);
            DateTime F_Date = DateTime.Now;
          //  DateTime newF_Date = Convert.ToDateTime(dt.Rows[0][3].ToString());
            string newCurrentStatus = "Waiting";
            string newProblem = dt.Rows[0][5].ToString();
            string newNotes = dt.Rows[0][6].ToString();
            int newMid = int.Parse(dt.Rows[0][7].ToString());

            clsMaintenanceApp nm = new clsMaintenanceApp(id,newUserId, newR_Date,F_Date, newCurrentStatus, newProblem, newNotes, newMid);
            nm.AssignToUser(userID);



            frmMaintenancesApp.GetFrmMaintenancesApp.myMaintGridView.DataSource = m.GetUsertMaintenances(userID);


            frmMaintenancesApp.GetFrmMaintenancesApp.btnMyMaintenances.Text = "My Current Maintenances (" + new clsMaintenanceApp().GetCountUserMaintenances(userID).ToString() + ")";

            frmMaintenancesApp.GetFrmMaintenancesApp.btnCurM.Text = "All Current Maintenances (" + new clsMaintenanceApp().GetCountCurrentMaintenances().ToString() + ")";

            frmMaintenancesApp.GetFrmMaintenancesApp.btnAllm.Text = "All Finished Maintenances (" + new clsMaintenanceApp().GetCountFinishedMaintenances().ToString() + ")";

            this.Close();
        }
    }
}
