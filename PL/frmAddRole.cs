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
    public partial class frmAddRole : Telerik.WinControls.UI.RadForm
    {
        int id = 0;
        public frmAddRole(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddRole_Load(object sender, EventArgs e)
        {
            clsRole roles = new clsRole();
            

            this.lstRoles2.DataSource = roles.GetAllRoles();
            this.lstRoles2.DisplayMember = "Role";
            this.lstRoles2.ValueMember = "ID";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsUser user = new clsUser();

           // user.AddRole(this.id, int.Parse(this.lstRoles.SelectedValue.ToString()));
            for (int i = 0; i < lstRoles2.SelectedItems.Count; i++ )
            {
                user.AddRole(this.id, int.Parse(this.lstRoles2.SelectedItems[i].Value.ToString()));
            }
         
            MessageBox.Show("Roles Added", "Add Role", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            this.Close();
        }
    }
}
