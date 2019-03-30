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
    public partial class frmMaintenancesApp : Telerik.WinControls.UI.RadForm
    {

        private static frmMaintenancesApp frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static frmMaintenancesApp GetFrmMaintenancesApp
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmMaintenancesApp();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public frmMaintenancesApp()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;

            pnlDev.SendToBack();
            pnlCur.SendToBack();
            pnlAll.SendToBack();
            HomePanel.BringToFront();
            pnlMyM.SendToBack();
        }

        private void btnCurM_Click(object sender, EventArgs e)
        {
            pnlCur.BringToFront();
            pnlAll.SendToBack();
            HomePanel.SendToBack();
            pnlDev.SendToBack();
            pnlMyM.SendToBack();
            radGroupBox2.Text = btnCurM.Text;
            btnCurM.Enabled = false;
            btnAllm.Enabled = true;
            btnDev.Enabled = true;
            btnMyMaintenances.Enabled = true;

            this.curMGridView.DataSource = new clsMaintenanceApp().GetCurrentMaintenances();
            this.curMGridView.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;

            clsUser user = new clsUser();

            int userID = new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text);


            this.btnMyMaintenances.Text = "My Current Maintenances (" + new clsMaintenanceApp().GetCountUserMaintenances(userID).ToString() + ")";

            this.btnCurM.Text = "All Current Maintenances (" + new clsMaintenanceApp().GetCountCurrentMaintenances().ToString() + ")";

            this.btnAllm.Text = "All Finished Maintenances (" + new clsMaintenanceApp().GetCountFinishedMaintenances().ToString() + ")";

        }

        private void btnAllm_Click(object sender, EventArgs e)
        {
            pnlAll.BringToFront();
            pnlCur.SendToBack();
            HomePanel.SendToBack();
            pnlDev.SendToBack();
            pnlMyM.SendToBack();
            radGroupBox2.Text = btnAllm.Text;
            btnCurM.Enabled = true;
            btnAllm.Enabled = false;
            btnDev.Enabled = true;
            btnMyMaintenances.Enabled = true;

            this.allMaintGridView.DataSource = new clsMaintenanceApp().GetFinishedMaintenances();
            this.allMaintGridView.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;

            clsUser user = new clsUser();

            int userID = new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text);

            this.btnMyMaintenances.Text = "My Current Maintenances (" + new clsMaintenanceApp().GetCountUserMaintenances(userID).ToString() + ")";

            this.btnCurM.Text = "All Current Maintenances (" + new clsMaintenanceApp().GetCountCurrentMaintenances().ToString() + ")";

            this.btnAllm.Text = "All Finished Maintenances (" + new clsMaintenanceApp().GetCountFinishedMaintenances().ToString() + ")";
        }

        private void btnDev_Click(object sender, EventArgs e)
        {
            pnlDev.BringToFront();
            pnlCur.SendToBack();
            pnlAll.SendToBack();
            HomePanel.SendToBack();
            pnlMyM.SendToBack();
            radGroupBox2.Text = btnDev.Text;
            btnCurM.Enabled = true;
            btnAllm.Enabled = true;
            btnDev.Enabled = false;
            btnMyMaintenances.Enabled = true;

           // this.DevGridView.DataSource = new clsDevice().GetAll();
            DataTable dt = new clsDevice().GetAll();
            this.DevGridView.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            DataColumn c = new DataColumn("Current Maintenances", typeof(int));
            DataColumn c1 = new DataColumn("Finished Maintenances", typeof(int));
            dt.Columns.Add(c);
            dt.Columns.Add(c1);

            foreach(DataRow r in dt.Rows)
            {
                 int count = new clsMaintenanceApp().GetDevCurrentMaintenancesCount(int.Parse(r[0].ToString()));
                 r["Current Maintenances"] = count;
                 int count2 = new clsMaintenanceApp().GetDevFinishedMaintenancesCount(int.Parse(r[0].ToString()));
                 r["Finished Maintenances"] = count2;
            }

            this.DevGridView.DataSource = dt;
        }

        private void radMenuItem3_Click(object sender, EventArgs e)
        {
            frmAddDevice frm = new frmAddDevice();
            frm.type = "New";
            frm.ShowDialog();
        }

        private void radMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.DevGridView.SelectedRows[0].Cells[0].Value.ToString());
                frmAddDevice frm = new frmAddDevice(id);
                frm.type = "Edit";
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
        }

        private void radMenuItem5_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.DevGridView.SelectedRows[0].Cells[0].Value.ToString());

                var msg = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    clsDevice d = new clsDevice(id);
                    d.Delete();

                    DataTable dt = new clsDevice().GetAll();

                    DataColumn c = new DataColumn("Current Maintenances", typeof(int));
                    DataColumn c1 = new DataColumn("Finished Maintenances", typeof(int));
                    dt.Columns.Add(c);
                    dt.Columns.Add(c1);

                    foreach (DataRow r in dt.Rows)
                    {
                        int count = new clsMaintenanceApp().GetDevCurrentMaintenancesCount(int.Parse(r[0].ToString()));
                        r["Current Maintenances"] = count;
                        int count2 = new clsMaintenanceApp().GetDevFinishedMaintenancesCount(int.Parse(r[0].ToString()));
                        r["Finished Maintenances"] = count2;
                    }

                    this.DevGridView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.DevGridView.SelectedRows[0].Cells[0].Value.ToString());
                frmStartMaintenance frm = new frmStartMaintenance(id);
                frm.ShowDialog();

            }
            catch
            {

            }
        }

        private void btnMyMaintenances_Click(object sender, EventArgs e)
        {
            pnlDev.SendToBack();
            pnlCur.SendToBack();
            pnlAll.SendToBack();
            HomePanel.SendToBack();
            pnlMyM.BringToFront();
            radGroupBox2.Text = btnMyMaintenances.Text;
            btnCurM.Enabled = true;
            btnAllm.Enabled = true;
            btnDev.Enabled = true;
            btnMyMaintenances.Enabled = false;

            clsUser user = new clsUser();

            int userID = new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text);

            this.myMaintGridView.DataSource = new clsMaintenanceApp().GetUsertMaintenances(userID);
            this.myMaintGridView.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;


            this.btnMyMaintenances.Text = "My Current Maintenances (" + new clsMaintenanceApp().GetCountUserMaintenances(userID).ToString() + ")";

            this.btnCurM.Text = "All Current Maintenances (" + new clsMaintenanceApp().GetCountCurrentMaintenances().ToString() + ")";

            this.btnAllm.Text = "All Finished Maintenances (" + new clsMaintenanceApp().GetCountFinishedMaintenances().ToString() + ")";
        }

        private void btnStartM_Click(object sender, EventArgs e)
        {
            try
            {
                clsUser user = new clsUser();

                int userID = new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text);

                int mid = int.Parse(this.curMGridView.SelectedRows[0].Cells[0].Value.ToString());
                clsMaintenanceApp m = new clsMaintenanceApp(userID, DateTime.Now, "Ongoing");
                m.UserStartMaintenance(mid);

                this.curMGridView.DataSource = m.GetCurrentMaintenances();


                this.btnMyMaintenances.Text = "My Current Maintenances (" + new clsMaintenanceApp().GetCountUserMaintenances(userID).ToString() + ")";

                this.btnCurM.Text = "All Current Maintenances (" + new clsMaintenanceApp().GetCountCurrentMaintenances().ToString() + ")";

                this.btnAllm.Text = "All Finished Maintenances (" + new clsMaintenanceApp().GetCountFinishedMaintenances().ToString() + ")";

            }
            catch
            {

            }
        }

        private void btnSetProblem_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.myMaintGridView.SelectedRows[0].Cells[0].Value.ToString());
                frmUserSetProblem frm = new frmUserSetProblem(id);
                frm.type = "Problem";
                frm.ShowDialog();
            }
            catch
            {

            }
        }

        private void btnSetNote_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.myMaintGridView.SelectedRows[0].Cells[0].Value.ToString());
                frmUserSetProblem frm = new frmUserSetProblem(id);
                frm.type = "Note";
                frm.ShowDialog();
            }
            catch
            {

            }
        }

        private void curMGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.curMGridView.SelectedRows[0].Cells[9].Value.ToString() == "Started")
                {
                    this.btnStartM.Enabled = false;
                }
                else
                {
                    this.btnStartM.Enabled = true;
                }
            }
            catch
            { }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.myMaintGridView.SelectedRows[0].Cells[0].Value.ToString());
                frmAssign frm = new frmAssign(id);
                frm.ShowDialog();
            }
            catch
            {

            }
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.curMGridView.SelectedRows[0].Cells[0].Value.ToString());
                frmMaintenanceTrack frm = new frmMaintenanceTrack(id);
                frm.ShowDialog();
            }
            catch
            {

            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                clsUser user = new clsUser();

                int userID = new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text);

                int id = int.Parse(this.myMaintGridView.SelectedRows[0].Cells[0].Value.ToString());
                clsMaintenanceApp m = new clsMaintenanceApp(id);
                m.Accept(DateTime.Now, "Ongoing");

                this.myMaintGridView.DataSource = m.GetUsertMaintenances(userID);
            }
            catch
            {

            }
        }

        private void myMaintGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.myMaintGridView.SelectedRows[0].Cells[6].Value == DBNull.Value)
                {
                    this.btnAccept.Enabled = false;
                }
                else
                {
                    this.btnAccept.Enabled = true;
                }

                if (this.myMaintGridView.SelectedRows[0].Cells[3].Value.ToString() == "Waiting")
                {
                    this.btnAccept.Enabled = true;
                    this.btnAssign.Enabled = false;
                }
                else
                {
                    this.btnAccept.Enabled = false;
                    this.btnAssign.Enabled = true;
                }
            }
            catch
            {
               
            }
        }

        private void btnCloseMaintenance_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.myMaintGridView.SelectedRows[0].Cells[1].Value.ToString());
                frmCloseMaintenance frm = new frmCloseMaintenance(id);
                frm.ShowDialog();
            }
            catch
            {

            }

        }

        private void btnTrackFinishedMaint_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.allMaintGridView.SelectedRows[0].Cells[0].Value.ToString());
                frmMaintenanceTrack frm = new frmMaintenanceTrack(id);
                frm.ShowDialog();
            }
            catch
            {

            }
        }

        private void btnAllMaint_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.DevGridView.SelectedRows[0].Cells[0].Value.ToString());
                frmAllDeviceMaintenances frm = new frmAllDeviceMaintenances(id);
                frm.ShowDialog();
            }
            catch
            {

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAddDevice frm = new frmAddDevice();
            frm.type = "New";
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.DevGridView.SelectedRows[0].Cells[0].Value.ToString());
                frmAddDevice frm = new frmAddDevice(id);
                frm.type = "Edit";
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.DevGridView.SelectedRows[0].Cells[0].Value.ToString());

                var msg = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    clsDevice d = new clsDevice(id);
                    d.Delete();

                    DataTable dt = new clsDevice().GetAll();

                    DataColumn c = new DataColumn("Current Maintenances", typeof(int));
                    DataColumn c1 = new DataColumn("Finished Maintenances", typeof(int));
                    dt.Columns.Add(c);
                    dt.Columns.Add(c1);

                    foreach (DataRow r in dt.Rows)
                    {
                        int count = new clsMaintenanceApp().GetDevCurrentMaintenancesCount(int.Parse(r[0].ToString()));
                        r["Current Maintenances"] = count;
                        int count2 = new clsMaintenanceApp().GetDevFinishedMaintenancesCount(int.Parse(r[0].ToString()));
                        r["Finished Maintenances"] = count2;
                    }

                    this.DevGridView.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.curMGridView.SelectedRows[0].Cells[0].Value.ToString());
                frmMaintenanceDetails frm = new frmMaintenanceDetails(id);
                frm.ShowDialog();
            }
            catch
            {

            }
        }

        private void allMaintGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                int id = int.Parse(this.allMaintGridView.SelectedRows[0].Cells[0].Value.ToString());
                frmMaintenanceDetails frm = new frmMaintenanceDetails(id);
                frm.ShowDialog();
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void frmMaintenancesApp_Load(object sender, EventArgs e)
        {
            clsUser user = new clsUser();

            int userID = new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text);

            if (user.IsInRole(userID, "Admin"))
            {
                this.btnDev.Enabled = true;
                this.btnAllm.Enabled = true;
                this.btnCurM.Enabled = true;
                this.btnMyMaintenances.Enabled = true;

                this.btnNew.Enabled = true;
                this.btnEdit.Enabled = true;
                this.btnDelete.Enabled = true;
                this.btnStart.Enabled = true;
                this.btnStartM.Enabled = true;
                this.btnAllMaint.Enabled = true;
                this.btnTrack.Enabled = true;
                this.btnTrackFinishedMaint.Enabled = true;
                this.btnAccept.Enabled = true;
                this.btnSetNote.Enabled = true;
                this.btnSetProblem.Enabled = true;
                this.btnAssign.Enabled = true;
                this.btnCloseMaintenance.Enabled = true;
            }

            if (user.IsInRole(userID, "Devices"))
            {
                this.btnDev.Enabled = true;
            }

            if (user.IsInRole(userID, "FinishedMaintenances"))
            {
                this.btnAllm.Enabled = true;
            }

            if (user.IsInRole(userID, "CurrentMaintenances"))
            {
                this.btnCurM.Enabled = true;
            }

            if (user.IsInRole(userID, "MyMaintenances"))
            {
                this.btnMyMaintenances.Enabled = true;
            }

            if (user.IsInRole(userID, "AddDevice"))
            {
                this.btnNew.Enabled = true;
            }

            if (user.IsInRole(userID, "EditDevice"))
            {
                this.btnEdit.Enabled = true;
            }

            if (user.IsInRole(userID, "DeleteDevice"))
            {
                this.btnDelete.Enabled = true;
            }

            if (user.IsInRole(userID, "DevAllMaintenances"))
            {
                this.btnAllMaint.Enabled = true;
            }

            if (user.IsInRole(userID, "AdminStartMaintenance"))
            {
                this.btnStart.Enabled = true;
            }

            if (user.IsInRole(userID, "TrackMaintenance"))
            {
                this.btnTrack.Enabled = true;
                this.btnTrackFinishedMaint.Enabled = true;
            }

            if (user.IsInRole(userID, "UserStartMaintenance"))
            {
                this.btnStartM.Enabled = true;
            }

            if (user.IsInRole(userID, "SetProblem"))
            {
                this.btnSetProblem.Enabled = true;
            }

            if (user.IsInRole(userID, "SetNote"))
            {
                this.btnSetNote.Enabled = true;
            }

            if (user.IsInRole(userID, "AssignMaintenance"))
            {
                this.btnAssign.Enabled = true;
            }

            if (user.IsInRole(userID, "AcceptMaintenance"))
            {
                this.btnAccept.Enabled = true;
            }

            if (user.IsInRole(userID, "CloseMaintenance"))
            {
                this.btnCloseMaintenance.Enabled = true;
            }

            this.btnMyMaintenances.Text += " (" + new clsMaintenanceApp().GetCountUserMaintenances(userID).ToString() +")";

            this.btnCurM.Text += " (" + new clsMaintenanceApp().GetCountCurrentMaintenances().ToString() + ")";

            this.btnAllm.Text += " (" + new clsMaintenanceApp().GetCountFinishedMaintenances().ToString() + ")";
        }

    }
}
