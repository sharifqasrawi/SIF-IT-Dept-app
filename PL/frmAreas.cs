using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IT_Dept.BL;
using Telerik.WinControls;

namespace IT_Dept.PL
{
    public partial class frmAreas : Telerik.WinControls.UI.RadForm
    {

        private static frmAreas frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static frmAreas GetFrmAreas
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmAreas();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public frmAreas()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }

        private void frmAreas_Load(object sender, EventArgs e)
        {
            clsArea areas = new clsArea();
            this.areasGridView.DataSource = areas.GetAll();

            this.areasGridView.AutoSizeColumnsMode =Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
           
            clsUser user = new clsUser();

            int userID = new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text);

            if (user.IsInRole(userID, "Admin") || user.IsInRole(userID, "Boss"))
            {
                this.btnDelete.Enabled = true;
                this.btnNew.Enabled = true;
                this.btnEdit.Enabled = true;
            }
            if (user.IsInRole(userID, "AddArea"))
            {
                this.btnNew.Enabled = true;
            }
            if (user.IsInRole(userID, "EditArea"))
            {
                this.btnEdit.Enabled = true;
            }
            if (user.IsInRole(userID, "DeleteArea"))
            {
                this.btnDelete.Enabled = true;
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAddArea frm = new frmAddArea();
            frm.type = "New";
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.areasGridView.SelectedRows[0].Cells[0].Value.ToString());
                var msg = MessageBox.Show("Are you sure you want to delete this record?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    clsArea area = new clsArea(id);
                    area.Delete();
                    this.areasGridView.DataSource = area.GetAll();
                    this.lblMsg.Text = "Record deleted successfully";
                    //MessageBox.Show("Record deleted successfully", " Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.areasGridView.SelectedRows[0].Cells[0].Value.ToString());
                frmAddArea frm = new frmAddArea(id);
                frm.type = "Edit";
                frm.Text = "Edit area";
                frm.ShowDialog();
            }
            catch
            {

            }
        }
    }
}
