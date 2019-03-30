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
    public partial class frmSurvAlarms : Telerik.WinControls.UI.RadForm
    {
        private static frmSurvAlarms frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static frmSurvAlarms GetFrmSurvAlarms
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmSurvAlarms();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public frmSurvAlarms()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }

        private void btnSur_Click(object sender, EventArgs e)
        {
            this.radGroupBox2.Text = btnSur.Text;
            this.pnlSurv.BringToFront();
            this.pnlAlarms.SendToBack();
            this.btnSur.Enabled = false;
            this.btnAlarm.Enabled = true;

            clsSurveillance s = new clsSurveillance();
            this.SurvGridView.DataSource = s.GetAll();
            this.SurvGridView.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            this.radGroupBox2.Text = btnAlarm.Text;
            this.pnlSurv.SendToBack();
            this.pnlAlarms.BringToFront();
            this.btnAlarm.Enabled = false;
            this.btnSur.Enabled = true;

            clsAlarm a = new clsAlarm();
            this.alarmsGridView.DataSource = a.GetAll();
            this.alarmsGridView.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
        }

        private void frmSurvAlarms_Load(object sender, EventArgs e)
        {
       

            clsUser user = new clsUser();

            int userID = new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text);

            if (user.IsInRole(userID, "Admin") || user.IsInRole(userID, "Boss"))
            {
                this.btnAlarm.Enabled = true;
                this.btnSur.Enabled = true;
                this.addToolStripMenuItem.Enabled = true;
                this.editToolStripMenuItem.Enabled = true;
                this.deleteToolStripMenuItem.Enabled = true;
                this.addToolStripMenuItem1.Enabled = true;
                this.editToolStripMenuItem1.Enabled = true;
                this.deleteToolStripMenuItem1.Enabled = true;
                this.alarmEmergencyNumbersToolStripMenuItem.Enabled = true;
            }

            if (user.IsInRole(userID, "Surv") )
            {
                this.btnSur.Enabled = true;
            }
            this.btnSur.PerformClick();

            if (user.IsInRole(userID, "Alarms"))
            {
                this.btnAlarm.Enabled = true;
            }


            if (user.IsInRole(userID, "AddSurv"))
            {
                this.addToolStripMenuItem.Enabled = true;
            }

            if (user.IsInRole(userID, "EditSurv"))
            {
                this.editToolStripMenuItem.Enabled = true;
            }

            if (user.IsInRole(userID, "DeleteSurv"))
            {
                this.deleteToolStripMenuItem.Enabled = true;
            }

            if (user.IsInRole(userID, "AddAlarm"))
            {
                this.addToolStripMenuItem1.Enabled = true;
            }

            if (user.IsInRole(userID, "EditAlarm"))
            {
                this.editToolStripMenuItem1.Enabled = true;
            }

            if (user.IsInRole(userID, "DeleteAlarm"))
            {
                this.deleteToolStripMenuItem1.Enabled = true;
            }
            if (user.IsInRole(userID, "EmergencyNumbers"))
            {
                this.alarmEmergencyNumbersToolStripMenuItem.Enabled = true;
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddSurDevice frm = new frmAddSurDevice();
            frm.type = "New";
            frm.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.SurvGridView.SelectedRows[0].Cells[0].Value.ToString());
                frmAddSurDevice frm = new frmAddSurDevice(id);
                frm.type = "Edit";
                frm.Text = "Edit Surveillance Device";
                frm.ShowDialog();
            }
            catch
            {

            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.SurvGridView.SelectedRows[0].Cells[0].Value.ToString());
                var msg = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(msg == DialogResult.Yes)
                {
                    clsSurveillance s = new clsSurveillance(id);
                    s.DeleteSurDevice();
                    this.SurvGridView.DataSource = s.GetAll();
                    this.lblMsg.Text = "Surveillance Device Deleted Successfully";
                }
            }
            catch
            {

            }
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddAlarmDevice frm = new frmAddAlarmDevice();
            frm.type = "New";
            frm.ShowDialog();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.alarmsGridView.SelectedRows[0].Cells[0].Value.ToString());
                frmAddAlarmDevice frm = new frmAddAlarmDevice(id);
                frm.type = "Edit";
                frm.Text = "Edit Alarm Device";
                frm.ShowDialog();
            }
            catch
            {
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.alarmsGridView.SelectedRows[0].Cells[0].Value.ToString());
                var msg = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    clsAlarm a= new clsAlarm(id);
                    a.DeleteAlarm();
                    this.alarmsGridView.DataSource = a.GetAll();
                    this.lblMsg.Text = "Alarm Device Deleted Successfully";
                }
            }
            catch
            {

            }
        }

        private void alarmEmergencyNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.alarmsGridView.SelectedRows[0].Cells[0].Value.ToString());
                frmAlarmERNumbers frm = new frmAlarmERNumbers(id);
                frm.ShowDialog();
            }
            catch
            {

            }
        }
    }
}
