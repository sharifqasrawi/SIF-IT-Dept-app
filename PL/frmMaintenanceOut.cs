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
    public partial class frmMaintenanceOut : Telerik.WinControls.UI.RadForm
    {
        int id = 0;
        public frmMaintenanceOut(int id)
        {
            InitializeComponent();
            this.id = id;
            this.date.Value = DateTime.Now;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsMaintenance m = new clsMaintenance(id, txtTo.Text, date.Value);
            
            m.ReturnMaint();

            frmMaintenances.GetFrmMaintenances.MntsGridView.DataSource = m.GetAll();

            this.Close();
        }

        private void frmMaintenanceOut_Load(object sender, EventArgs e)
        {
          //  clsMaintenance m = new clsMaintenance(id);
            
        }
    }
}
