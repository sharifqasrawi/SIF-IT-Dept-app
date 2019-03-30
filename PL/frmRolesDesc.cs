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
    public partial class frmRolesDesc : Telerik.WinControls.UI.RadForm
    {
        public frmRolesDesc()
        {
            InitializeComponent();
        }

        private void frmRolesDesc_Load(object sender, EventArgs e)
        {
            this.RolesGridView.DataSource = new clsRole().GetAllRoles();
            this.RolesGridView.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
        }
    }
}
