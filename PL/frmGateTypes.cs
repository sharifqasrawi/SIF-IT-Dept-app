﻿using System;
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

    public partial class frmGateTypes : Telerik.WinControls.UI.RadForm
    {
        private static frmGateTypes frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static frmGateTypes GetFrmGateTypes
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmGateTypes();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public frmGateTypes()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAddGateType frm = new frmAddGateType();
            frm.type = "New";
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.gateTypesGridView.SelectedRows[0].Cells[0].Value.ToString());
                frmAddGateType frm = new frmAddGateType(id);
                frm.type = "Edit";
                frm.Text = "Edit Gate Type";
                frm.ShowDialog();
            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.gateTypesGridView.SelectedRows[0].Cells[0].Value.ToString());
                clsGateType g = new clsGateType(id);
                var msg = MessageBox.Show("Are you sure you want to delete this record?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    g.Delete();
                    frmGateTypes.GetFrmGateTypes.gateTypesGridView.DataSource = g.GetAll();
                    this.lblMsg.Text = "Record deleted successfully";
                    //  MessageBox.Show("Record deleted successfully", " Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {

            }
        }

        private void frmGateTypes_Load(object sender, EventArgs e)
        {
            this.gateTypesGridView.DataSource = new clsGateType().GetAll();

            clsUser user = new clsUser();

            int userID = new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text);

            if (user.IsInRole(userID, "Admin") || user.IsInRole(userID, "Boss"))
            {
                this.btnDelete.Enabled = true;
                this.btnNew.Enabled = true;
                this.btnEdit.Enabled = true;
            }
            if (user.IsInRole(userID, "AddGateType"))
            {
                this.btnNew.Enabled = true;
            }
            if (user.IsInRole(userID, "EditGateType"))
            {
                this.btnEdit.Enabled = true;
            }
            if (user.IsInRole(userID, "DeleteGateType"))
            {
                this.btnDelete.Enabled = true;
            }
        }
    }
}
