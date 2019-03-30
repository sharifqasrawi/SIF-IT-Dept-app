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
    public partial class frmMaintenanceTrack : Telerik.WinControls.UI.RadForm
    {
        int id;
        public frmMaintenanceTrack(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void frmMaintenanceTrack_Load(object sender, EventArgs e)
        {
            clsMaintenanceApp m = new clsMaintenanceApp(id);
            this.MaintGridView.DataSource = m.GetMaintenanceTrackByMId();
            this.MaintGridView.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
        }
    }
}
