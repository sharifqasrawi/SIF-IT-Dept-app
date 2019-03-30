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
    public partial class frmAddWorkAssignemt : Telerik.WinControls.UI.RadForm
    {
        public string type = "";
        int id = 0;
        public frmAddWorkAssignemt()
        {
            InitializeComponent();
        }

        public frmAddWorkAssignemt(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddWorkAssignemt_Load(object sender, EventArgs e)
        {
            this.lstCenters.DataSource = new clsCenter().GetAll();
            this.lstCenters.DisplayMember = "Center name";
            this.lstCenters.ValueMember = "#";

            this.dateFrom.Value = DateTime.Now;
            this.dateTo.Value = DateTime.Now;
            this.timeFrom.Value = DateTime.Now;
            this.timeTo.Value = DateTime.Now;


            if (type == "Edit")
            {
                clsWorkAssignment w = new clsWorkAssignment(id);
                this.txtEmp.Text = w.GetWorkAssignmentByID().Rows[0][1].ToString();
                this.txtDesc.Text = w.GetWorkAssignmentByID().Rows[0][3].ToString();
                this.lstCenters.SelectedValue = int.Parse(w.GetWorkAssignmentByID().Rows[0][2].ToString());
                this.dateFrom.Value = Convert.ToDateTime(w.GetWorkAssignmentByID().Rows[0][4]);
                this.timeFrom.Value = Convert.ToDateTime(w.GetWorkAssignmentByID().Rows[0][4]);
                this.dateTo.Value = Convert.ToDateTime(w.GetWorkAssignmentByID().Rows[0][5]);
                this.timeTo.Value = Convert.ToDateTime(w.GetWorkAssignmentByID().Rows[0][5]);
                this.txtJobDesc.Text = w.GetWorkAssignmentByID().Rows[0][6].ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (type == "New")
            //{
            //    DateTime from = new DateTime(dateFrom.Value.Year, dateFrom.Value.Month, dateFrom.Value.Day, timeFrom.Value.Value.Hour, timeFrom.Value.Value.Minute, 0);
            //    DateTime to = new DateTime(dateTo.Value.Year, dateTo.Value.Month, dateTo.Value.Day, timeTo.Value.Value.Hour, timeTo.Value.Value.Minute, 0);
            //    clsWorkAssignment w = new clsWorkAssignment(txtEmp.Text,txtJobDesc.Text, txtDesc.Text, int.Parse(lstCenters.SelectedValue.ToString()), from, to);
            //    w.Add();
            //    frmWorkAssignments.GetFrmWorkAssignments.WAGridView.DataSource = w.GetAll();
            //    frmWorkAssignments.GetFrmWorkAssignments.lblMsg.Text = "Work assignment added successfully";
            //    this.Close();
            //}
            //else if (type == "Edit")
            //{
            //    DateTime from = new DateTime(dateFrom.Value.Year, dateFrom.Value.Month, dateFrom.Value.Day, timeFrom.Value.Value.Hour, timeFrom.Value.Value.Minute, 0);
            //    DateTime to = new DateTime(dateTo.Value.Year, dateTo.Value.Month, dateTo.Value.Day, timeTo.Value.Value.Hour, timeTo.Value.Value.Minute, 0);
            //    clsWorkAssignment w = new clsWorkAssignment(id, txtEmp.Text, txtJobDesc.Text, txtDesc.Text, int.Parse(lstCenters.SelectedValue.ToString()), from, to);
            //    w.Edit();
            //    frmWorkAssignments.GetFrmWorkAssignments.WAGridView.DataSource = w.GetAll();
            //    frmWorkAssignments.GetFrmWorkAssignments.lblMsg.Text = "Work assignment edited successfully";
            //    this.Close();
            //}
        }
    }
}
