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
    public partial class frmAddAlarmEmNumber : Telerik.WinControls.UI.RadForm
    {
        int id;
        int aid;
        public string type = "";
        public frmAddAlarmEmNumber()
        {
            InitializeComponent();
        }
        public frmAddAlarmEmNumber(int aid, int id)
        {
            InitializeComponent();
            this.id = id;
            this.aid = aid;
        }

        public frmAddAlarmEmNumber(int aid)
        {
            InitializeComponent();
            this.aid = aid;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(type == "New")
            {
                clsAlarmPhNumber a = new clsAlarmPhNumber(aid, txtNum.Text, txtName.Text);
                a.AddAlarmPhNumber();
                this.Close();
            }
            else if(type == "Edit")
            {
                clsAlarmPhNumber a = new clsAlarmPhNumber(id, aid, txtNum.Text, txtName.Text);
                a.EditAlarmPhNumber();
                this.Close();
            }
        }

        private void frmAddAlarmEmNumber_Load(object sender, EventArgs e)
        {
           if(type == "Edit")
           {
               DataTable dt = new clsAlarmPhNumber(id).GetAlarmPhById();
               this.txtNum.Text = dt.Rows[0][2].ToString();
               this.txtName.Text = dt.Rows[0][3].ToString();
           }
        }
    }
}
