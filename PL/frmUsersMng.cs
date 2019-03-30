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
    public partial class frmUsersMng : Telerik.WinControls.UI.RadForm
    {
        private static frmUsersMng frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static frmUsersMng GetFrmUsersMngTypes
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmUsersMng();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public frmUsersMng()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }

        private void frmUsersMng_Load(object sender, EventArgs e)
        {
            clsUser users = new clsUser();
            this.usersGridView.DataSource = users.GetAllUsers();
            //frmUnlockUsersMngmnt.GetFrmUnlockUsersMngmnt.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAddUser frm = new frmAddUser();
            frm.type = "New";
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.usersGridView.SelectedRows[0].Cells[0].Value.ToString());
                clsUser user = new clsUser(id);
                var msg = MessageBox.Show("Are you sure you want to delete this record?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(msg == DialogResult.Yes)
                {
                    user.DeleteUser();
                    this.usersGridView.DataSource = user.GetAllUsers();
                    this.lblMsg.Text = "Record deleted successfully";
                    //MessageBox.Show("Record deleted successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.usersGridView.SelectedRows[0].Cells[0].Value.ToString());

                frmAddUser frm = new frmAddUser(id);
                frm.type = "Edit";
                frm.Text = "Edit User";
                frm.ShowDialog();
            }
            catch
            {

            }
        }

        private void btnResetPw_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.usersGridView.SelectedRows[0].Cells[0].Value.ToString());
                frmResetUserPassword frm = new frmResetUserPassword(id);
                frm.ShowDialog();
                
            }
            catch
            {

            }
        }

        private void btnUserRoles_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.usersGridView.SelectedRows[0].Cells[0].Value.ToString());
                frmUserRoles frm = new frmUserRoles(id);
                frm.ShowDialog();
            }
            catch
            {

            }
        }
    }
}
