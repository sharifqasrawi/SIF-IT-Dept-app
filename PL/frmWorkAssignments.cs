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
    public partial class frmWorkAssignments : Telerik.WinControls.UI.RadForm
    {
        private static frmWorkAssignments frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static frmWorkAssignments GetFrmWorkAssignments
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmWorkAssignments();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public frmWorkAssignments()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }

        private void frmWorkAssignments_Load(object sender, EventArgs e)
        {
            clsWorkAssignment w = new clsWorkAssignment();
            this.WAGridView.DataSource = w.GetAll();
            this.WAGridView.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;


            clsUser user = new clsUser();

            int userID = new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text);

            if (user.IsInRole(userID, "Admin") || user.IsInRole(userID, "Boss"))
            {
                this.btnDelete.Enabled = true;
                this.BtnNew.Enabled = true;
                this.btnEdit.Enabled = true;
            }

            if (user.IsInRole(userID, "AddWASS"))
            {
                this.BtnNew.Enabled = true;
            }
            if (user.IsInRole(userID, "EditWASS"))
            {
                this.btnEdit.Enabled = true;
            }
            if (user.IsInRole(userID, "DeleteWASS"))
            {
                this.btnDelete.Enabled = true;
            }

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            frmAddWorkAssignemt frm = new frmAddWorkAssignemt();
            frm.type = "New";
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.WAGridView.SelectedRows[0].Cells[0].Value.ToString());
                frmAddWorkAssignemt frm = new frmAddWorkAssignemt(id);
                frm.type = "Edit";
                frm.Text = "Edit work assignment";
                frm.ShowDialog();
            }
            catch
            { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.WAGridView.SelectedRows[0].Cells[0].Value.ToString());
                var msg = MessageBox.Show("Are you sure you want to delete this record?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(msg == DialogResult.Yes)
                {
                    clsWorkAssignment w = new clsWorkAssignment(id);
                    w.Delete();
                    this.WAGridView.DataSource = w.GetAll();
                    this.lblMsg.Text = "Record deleted successfully";

                }
            }
            catch(Exception ex) {MessageBox.Show(ex.Message); }
        }
    }
}
