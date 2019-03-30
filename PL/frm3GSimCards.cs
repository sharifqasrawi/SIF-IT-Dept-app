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
    public partial class frm3GSimCards : Telerik.WinControls.UI.RadForm
    {
        private static frm3GSimCards frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static frm3GSimCards GetFrm3GSimCards
        {
            get
            {
                if (frm == null)
                {
                    frm = new frm3GSimCards();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public frm3GSimCards()
        {
            InitializeComponent();
        }

        private void frm3GSimCards_Load(object sender, EventArgs e)
        {
            cls3GSim sim = new cls3GSim();
            this.SimsGridView.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;

            clsUser user = new clsUser();

            int userID = new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text);

            if (user.IsInRole(userID, "Admin") || user.IsInRole(userID, "Boss"))
            {
                this.btnDelete.Enabled = true;
                this.BtnNew.Enabled = true;
                this.btnEdit.Enabled = true;
            }

            if (user.IsInRole(userID, "Add3GSim"))
            {
                this.BtnNew.Enabled = true;
            }
            if (user.IsInRole(userID, "Edit3GSim"))
            {
                this.btnEdit.Enabled = true;
            }
            if (user.IsInRole(userID, "Delete3GSim"))
            {
                this.btnDelete.Enabled = true;
            }
            if (user.IsInRole(userID, "All3G"))
            {
                this.btnDelete.Enabled = true;
                this.SimsGridView.DataSource = sim.GetAll();
            }
            else if (user.IsInRole(userID, "Admin") || user.IsInRole(userID, "Boss"))
            {
                this.SimsGridView.DataSource = sim.GetAll();

            }
            else
            {
                this.SimsGridView.DataSource = sim.GetAll2();
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            frmAdd3GSim frm = new frmAdd3GSim();
            frm.type = "New";
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.SimsGridView.SelectedRows[0].Cells[0].Value.ToString());
                frmAdd3GSim frm = new frmAdd3GSim(id);
                frm.type = "Edit";
                frm.Text = "Edit 3G Sim Card";
                frm.ShowDialog();
            }
            catch
            { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.SimsGridView.SelectedRows[0].Cells[0].Value.ToString());
                var msg = MessageBox.Show("Are you sure you want to delete this record?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(msg == DialogResult.Yes)
                {
                    cls3GSim sim = new cls3GSim(id);
                    sim.DeleteSim();
                    this.SimsGridView.DataSource = sim.GetAll();
                    this.lblMsg.Text = "Record deleted successfully";
                }
            }
            catch
            { }
        }
    }
}
