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
    public partial class frmAllDeviceMaintenances : Telerik.WinControls.UI.RadForm
    {
        int id;
        public frmAllDeviceMaintenances(int id)
        {
            InitializeComponent();
            this.id = id;

            clsMaintenanceApp m = new clsMaintenanceApp();
            this.allMaintGridView.DataSource = m.GetAllDevMaintenances(id);
            this.allMaintGridView.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
        }

        private void allMaintGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                int mid = int.Parse(this.allMaintGridView.SelectedRows[0].Cells[0].Value.ToString());
                frmMaintenanceDetails frm = new frmMaintenanceDetails(mid);
                frm.ShowDialog();
            }
            catch
            {

            }
        }
    }
}
