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
    public partial class frmUserSetProblem : Telerik.WinControls.UI.RadForm
    {
        int id;
        public string type = "";
        public frmUserSetProblem(int id)
        {
            InitializeComponent();
            this.id = id;

            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (type == "Problem")
            {
                clsMaintenanceApp m = new clsMaintenanceApp();
                m.UserSetMaintenanceProblem(id, txtProblem.Text);

                clsUser user = new clsUser();

                int userID = new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text);
                frmMaintenancesApp.GetFrmMaintenancesApp.myMaintGridView.DataSource = m.GetUsertMaintenances(userID);

            }
            else if(type == "Note")
            {
                clsMaintenanceApp m = new clsMaintenanceApp();
                m.UserSetMaintenanceNotes(id, txtProblem.Text);

                clsUser user = new clsUser();

                int userID = new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text);
                frmMaintenancesApp.GetFrmMaintenancesApp.myMaintGridView.DataSource = m.GetUsertMaintenances(userID);
            }
            this.Close();
        }

        private void frmUserSetProblem_Load(object sender, EventArgs e)
        {
            
            if (type == "Problem")
            {
                this.radGroupBox1.Text = "Set Problem";
                this.Text = "Set Problem";
                txtProblem.Text = frmMaintenancesApp.GetFrmMaintenancesApp.myMaintGridView.SelectedRows[0].Cells[4].Value.ToString();

            }
            else if (type == "Note")
            {
                this.radGroupBox1.Text = "Set Note";
                this.Text = "Set Note";
                txtProblem.Text = frmMaintenancesApp.GetFrmMaintenancesApp.myMaintGridView.SelectedRows[0].Cells[5].Value.ToString();
            }
        }
    }
}
