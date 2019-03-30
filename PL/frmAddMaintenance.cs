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
    public partial class frmAddMaintenance : Telerik.WinControls.UI.RadForm
    {
        public string type = "";
        int id = 0;
        public frmAddMaintenance()
        {
            InitializeComponent();
            this.recdate.Value = DateTime.Now;
        }
        public frmAddMaintenance(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddMaintenance_Load(object sender, EventArgs e)
        {
            if(type == "Edit")
            {
                clsMaintenance m = new clsMaintenance(id);
                txtName.Text = m.GetMaintenanceByID().Rows[0][1].ToString();
                txtSerial.Text = m.GetMaintenanceByID().Rows[0][2].ToString();
                txtModel.Text = m.GetMaintenanceByID().Rows[0][3].ToString();
                txtSource.Text = m.GetMaintenanceByID().Rows[0][4].ToString();
                recdate.Value = Convert.ToDateTime(m.GetMaintenanceByID().Rows[0][5].ToString());
                txtemp.Text = m.GetMaintenanceByID().Rows[0][6].ToString();
                txtProblem.Text = m.GetMaintenanceByID().Rows[0][7].ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (type == "New")
            {
                DateTime dt = new DateTime(1000, 1, 1, 1, 0, 0);
                clsMaintenance m = new clsMaintenance(txtName.Text, txtSerial.Text, txtModel.Text, txtSource.Text, recdate.Value, txtemp.Text, txtProblem.Text, "", dt);
                m.AddMaintenance();
                frmMaintenances.GetFrmMaintenances.MntsGridView.DataSource = m.GetAll();
                frmMaintenances.GetFrmMaintenances.lblMsg.Text = "Maintenance added successfully";
                this.Close();
            }
            else if(type == "Edit")
            {
                clsMaintenance m = new clsMaintenance(id, txtName.Text, txtSerial.Text, txtModel.Text, txtSource.Text, recdate.Value, txtemp.Text, txtProblem.Text);
                m.EditMaintenance();
                frmMaintenances.GetFrmMaintenances.MntsGridView.DataSource = m.GetAll();
                frmMaintenances.GetFrmMaintenances.lblMsg.Text = "Maintenance edited successfully";
                this.Close();
            }
        }
    }
}
