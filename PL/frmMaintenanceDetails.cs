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
    public partial class frmMaintenanceDetails : Telerik.WinControls.UI.RadForm
    {
        int id;
        public frmMaintenanceDetails(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void frmMaintenanceDetails_Load(object sender, EventArgs e)
        {
            try
            {
                clsMaintenanceApp m = new clsMaintenanceApp();
                DataTable dt = m.GetCurrentMaintenancesById(id);

                txtBrand.Text = dt.Rows[0][2].ToString();
                txtModel.Text = dt.Rows[0][3].ToString();
                txtSerial.Text = dt.Rows[0][1].ToString();
                txtFrom.Text = dt.Rows[0][4].ToString();
                txtDNotes.Text = dt.Rows[0][5].ToString();
                txtProb.Text = dt.Rows[0][6].ToString();
                txtStartDate.Text = dt.Rows[0][7].ToString();
                txtMNotes.Text = dt.Rows[0][8].ToString();
                txtStatus.Text = dt.Rows[0][9].ToString();
                txtFDate.Text = dt.Rows[0][11].ToString();
                txtHandedTo.Text = dt.Rows[0][10].ToString();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
