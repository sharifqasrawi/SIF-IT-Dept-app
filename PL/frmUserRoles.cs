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
    public partial class frmUserRoles : Telerik.WinControls.UI.RadForm
    {
        int id = 0;
       

        
        public frmUserRoles(int id)
        {
            InitializeComponent();
            
            this.id = id;
        }

        private void frmUserRoles_Load(object sender, EventArgs e)
        {
            clsUser user = new clsUser(id);
            this.userRolesGridView.DataSource = user.GetUserRoles();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAddRole frm = new frmAddRole(id);
            frm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clsUser user = new clsUser(id);
            this.userRolesGridView.DataSource = user.GetUserRoles();
            this.lblMsg.Text = "Table refreshed";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.userRolesGridView.SelectedRows[0].Cells[0].Value.ToString());
                var msg = MessageBox.Show("Are you sure you want to delete this record?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(msg == DialogResult.Yes)
                {
                    clsUser user = new clsUser();
                    user.DeleteRole(id);
                    btnRefresh.PerformClick();
                    this.lblMsg.Text = "Record deleted successfully";
                 //   MessageBox.Show("Record deleted successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {

            }
        }

        private void btnRolesDesc_Click(object sender, EventArgs e)
        {
            frmRolesDesc frm = new frmRolesDesc();
            frm.ShowDialog();
        }
    }
}
