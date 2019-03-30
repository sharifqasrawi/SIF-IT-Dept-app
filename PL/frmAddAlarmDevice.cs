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
    public partial class frmAddAlarmDevice : Telerik.WinControls.UI.RadForm
    {
        int id;
        public string type = "";
        public frmAddAlarmDevice()
        {
            InitializeComponent();
        }
        public frmAddAlarmDevice(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void frmAddAlarmDevice_Load(object sender, EventArgs e)
        {
            this.lstCenters.DataSource = new clsCenter().GetAll();
            this.lstCenters.DisplayMember = "Center Name";
            this.lstCenters.ValueMember = "#";

            if(type == "Edit")
            {
                DataTable dt = new clsAlarm(id).GetById();
                this.lstCenters.SelectedValue = int.Parse(dt.Rows[0][1].ToString());
                this.txtType.Text = dt.Rows[0][2].ToString();
                this.txtPwd.Text = dt.Rows[0][3].ToString();
                this.txtMotion.Text = dt.Rows[0][4].ToString();
                this.txtFire.Text = dt.Rows[0][5].ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(type == "New")
                {
                    clsAlarm a = new clsAlarm(int.Parse(this.lstCenters.SelectedValue.ToString()), txtType.Text, txtPwd.Text, int.Parse(txtMotion.Text), int.Parse(txtFire.Text));
                    a.AddAlarm();
                    frmSurvAlarms.GetFrmSurvAlarms.alarmsGridView.DataSource = a.GetAll();
                    frmSurvAlarms.GetFrmSurvAlarms.lblMsg.Text = "Alarm Device Added Successfully";
                    this.Close();
                }
                else if(type == "Edit")
                {
                    clsAlarm a = new clsAlarm(id, int.Parse(this.lstCenters.SelectedValue.ToString()), txtType.Text, txtPwd.Text, int.Parse(txtMotion.Text), int.Parse(txtFire.Text));
                    a.EditAlarm();
                    frmSurvAlarms.GetFrmSurvAlarms.alarmsGridView.DataSource = a.GetAll();
                    frmSurvAlarms.GetFrmSurvAlarms.lblMsg.Text = "Alarm Device Edited Successfully";
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                frmSurvAlarms.GetFrmSurvAlarms.lblMsg.Text = ex.Message;
            }
        }
    }
}
