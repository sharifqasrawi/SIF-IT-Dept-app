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
    public partial class frmAddDevice : Telerik.WinControls.UI.RadForm
    {
        int id;
        public string type = "";
        public frmAddDevice()
        {
            InitializeComponent();
            lstCenters.DataSource = new clsCenter().GetAll();
            lstCenters.DisplayMember = "Center Name";
            lstCenters.ValueMember = "#";
        }

        public frmAddDevice(int id)
        {
            InitializeComponent();
            lstCenters.DataSource = new clsCenter().GetAll();
            lstCenters.DisplayMember = "Center Name";
            lstCenters.ValueMember = "#";

            this.id = id;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (type == "New")
            {
                clsDevice d = new clsDevice(txtBrand.Text, txtModel.Text, txtSerial.Text, int.Parse(lstCenters.SelectedValue.ToString()), txtNotes.Text);
                d.Add();
                
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

                frmMaintenancesApp.GetFrmMaintenancesApp.DevGridView.DataSource = dt;
                this.Close();
            }
            else if(type == "Edit")
            {
                clsDevice d = new clsDevice(id, txtBrand.Text, txtModel.Text, txtSerial.Text, int.Parse(lstCenters.SelectedValue.ToString()), txtNotes.Text);
                d.Edit();
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

                frmMaintenancesApp.GetFrmMaintenancesApp.DevGridView.DataSource = dt;
                this.Close();
            }
        }

        private void frmAddDevice_Load(object sender, EventArgs e)
        {
            if(type == "Edit")
            {
                txtBrand.Text = new clsDevice(id).GetById().Rows[0][1].ToString();
                txtModel.Text = new clsDevice(id).GetById().Rows[0][2].ToString();
                txtSerial.Text = new clsDevice(id).GetById().Rows[0][3].ToString();
                txtNotes.Text = new clsDevice(id).GetById().Rows[0][4].ToString();
            //    lstCenters.SelectedText = new clsDevice(id).GetById().Rows[0][5].ToString();
            }
        }

        private void txtSerial_TextChanged(object sender, EventArgs e)
        {
            clsDevice d = new clsDevice();
            if (type != "Edit")
            {
                if (d.IsDeviceExitst(txtSerial.Text))
                {
                    MessageBox.Show("This Device Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.btnSave.Enabled = false;
                }
                else
                {
                    this.btnSave.Enabled = true;
                }
            }
        }
    }
}
