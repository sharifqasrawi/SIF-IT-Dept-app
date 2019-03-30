using IT_Dept.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace IT_Dept.PL
{
    public partial class frmSyriatelNumbers : Telerik.WinControls.UI.RadForm
    {
        private static frmSyriatelNumbers frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static frmSyriatelNumbers GetFrmSyriatelNumbers
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmSyriatelNumbers();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public frmSyriatelNumbers()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }

   

        private void frmSyriatelNumbers_Load(object sender, EventArgs e)
        {
            clsSyriatelNumber n = new clsSyriatelNumber();
            this.syrNGridView.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;

            clsUser user = new clsUser();

            int userID = new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text);

            if (user.IsInRole(userID, "Admin") || user.IsInRole(userID, "Boss"))
            {
                this.btnDelete.Enabled = true;
                this.BtnNew.Enabled = true;
                this.btnEdit.Enabled = true;
            }
            if (user.IsInRole(userID, "AddSyrNum"))
            {
                this.BtnNew.Enabled = true;
            }
            if (user.IsInRole(userID, "EditSyrNum"))
            {
                this.btnEdit.Enabled = true;
            }
            if (user.IsInRole(userID, "DeleteSyrNum"))
            {
                this.btnDelete.Enabled = true;
            }
            if (user.IsInRole(userID, "AllSyrNumbers"))
            {
                this.syrNGridView.DataSource = n.GetAll();
            }
            else if (user.IsInRole(userID, "Admin") || user.IsInRole(userID, "Boss"))
            {
                this.syrNGridView.DataSource = n.GetAll();

            }
            else
            {
                this.syrNGridView.DataSource = n.GetAll2();
            }
        }

       

        private void BtnNew_Click(object sender, EventArgs e)
        {
            frmAddSyriatelNumber frm = new frmAddSyriatelNumber();
            frm.type = "New";
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.syrNGridView.SelectedRows[0].Cells[0].Value.ToString());
                frmAddSyriatelNumber frm = new frmAddSyriatelNumber(id);
                frm.Text = "Edit syriatel number";
                frm.type = "Edit";
                frm.ShowDialog();
            }
            catch { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.syrNGridView.SelectedRows[0].Cells[0].Value.ToString());
                clsSyriatelNumber n = new clsSyriatelNumber(id);
                var msg = MessageBox.Show("Are you sure you want to delete this record?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    n.Delete();
                    this.syrNGridView.DataSource = n.GetAll();
                    this.lblMsg.Text = "Record deleted successfully";
                    //   MessageBox.Show("Record deleted successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {

            }
        }

        private void BtnNew_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.BtnNew, "Add new number");
        }

        private void btnEdit_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.btnEdit, "Edit number");
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.btnDelete, "Delete number");
        }
    }
}
