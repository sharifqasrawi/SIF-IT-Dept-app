using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using IT_Dept.BL;
using System.Text.RegularExpressions;

namespace IT_Dept.PL
{
    public partial class frmAddSurDevice : Telerik.WinControls.UI.RadForm
    {
        int id;
        public string type = "";
        public frmAddSurDevice()
        {
            InitializeComponent();
        }

        public frmAddSurDevice(int id)
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
            try
            {
                if (type == "New")
                {
                    if (!IsValidIP(txtIP.Text))
                    {
                        frmSurvAlarms.GetFrmSurvAlarms.lblMsg.Text = "Invalid IP Address";
                    }
                    else
                    {
                        clsSurveillance s = new clsSurveillance(int.Parse(this.lstCenters.SelectedValue.ToString()), txtType.Text, txtIP.Text, txtUsername.Text, txtPwd.Text, int.Parse(txtInner.Text), int.Parse(txtOuter.Text));
                        s.AddSurDevice();
                        frmSurvAlarms.GetFrmSurvAlarms.SurvGridView.DataSource = s.GetAll();
                        frmSurvAlarms.GetFrmSurvAlarms.lblMsg.Text = "Surveillance Device Added Successfully";
                        this.Close();
                    }
                }
                else if (type == "Edit")
                {
                    clsSurveillance s = new clsSurveillance(id, int.Parse(this.lstCenters.SelectedValue.ToString()), txtType.Text, txtIP.Text, txtUsername.Text, txtPwd.Text, int.Parse(txtInner.Text), int.Parse(txtOuter.Text));
                    s.EditSurDevice();
                    frmSurvAlarms.GetFrmSurvAlarms.SurvGridView.DataSource = s.GetAll();
                    frmSurvAlarms.GetFrmSurvAlarms.lblMsg.Text = "Surveillance Device Edited Successfully";
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                frmSurvAlarms.GetFrmSurvAlarms.lblMsg.Text = ex.Message;
            }
        }

        private void frmAddSurDevice_Load(object sender, EventArgs e)
        {
            this.lstCenters.DataSource = new clsCenter().GetAll();
            this.lstCenters.DisplayMember = "Center Name";
            this.lstCenters.ValueMember = "#";
            if (type == "Edit")
            {
                DataTable dt = new clsSurveillance(id).GetSurvById();
                this.lstCenters.SelectedValue = int.Parse(dt.Rows[0][1].ToString());
                this.txtType.Text = dt.Rows[0][2].ToString();
                this.txtIP.Text = dt.Rows[0][3].ToString();
                this.txtUsername.Text = dt.Rows[0][4].ToString();
                this.txtPwd.Text = dt.Rows[0][5].ToString();
                this.txtInner.Text = dt.Rows[0][6].ToString();
                this.txtOuter.Text = dt.Rows[0][7].ToString();
            }
        }

        public bool IsValidIP(string addr)
        {
            //create our match pattern
            string pattern = @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$";
            //create our Regular Expression object
            Regex check = new Regex(pattern);
            //boolean variable to hold the status
            bool valid = false;
            //check to make sure an ip address was provided
            if (addr == "")
            {
                //no address provided so return false
                valid = false;
            }
            else
            {
                //address provided so use the IsMatch Method
                //of the Regular Expression object
                valid = check.IsMatch(addr, 0);
            }
            //return the results
            return valid;
        }
    }
}
