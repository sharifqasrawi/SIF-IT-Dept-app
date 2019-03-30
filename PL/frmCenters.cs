
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
    public partial class frmCenters : Telerik.WinControls.UI.RadForm
    {
        private static frmCenters frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static frmCenters GetFrmCenters
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmCenters();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public frmCenters()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }

        private void frmCenters_Load(object sender, EventArgs e)
        {
            clsCenter centers = new clsCenter();

            
            this.centersGridView.BestFitColumns(Telerik.WinControls.UI.BestFitColumnMode.AllCells);


            clsUser user = new clsUser();

            int userID = new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text);

            if (user.IsInRole(userID, "Admin") || user.IsInRole(userID, "Boss"))
            {
                this.btnDelete.Enabled = true;
                this.BtnNew.Enabled = true;
                this.btnEdit.Enabled = true;
                
            }
            if (user.IsInRole(userID, "AddCenter"))
            {
                this.BtnNew.Enabled = true;
            }
            if (user.IsInRole(userID, "EditCenter"))
            {
                this.btnEdit.Enabled = true;
            }
            if (user.IsInRole(userID, "DeleteCenter"))
            {
                this.btnDelete.Enabled = true;
            }
            if (user.IsInRole(userID, "AllCenters"))
            {
                this.btnDelete.Enabled = true;
                this.centersGridView.DataSource = centers.GetAll();
            }
            else if (user.IsInRole(userID, "Admin") || user.IsInRole(userID, "Boss"))
            {
                this.centersGridView.DataSource = centers.GetAll();
               
            }
            else
            {
                 this.centersGridView.DataSource = centers.GetAll2();
            }
        }


        private void BtnNew_Click(object sender, EventArgs e)
        {
            frmAddCenter frm = new frmAddCenter();
            frm.type = "New";
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.centersGridView.SelectedRows[0].Cells[0].Value.ToString());
                frmAddCenter frm = new frmAddCenter(id);
                frm.type = "Edit";
                frm.Text = "Edit center";
                frm.cntType = centerType;
                frm.ShowDialog();
            }
            catch
            { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.centersGridView.SelectedRows[0].Cells[0].Value.ToString());
                
                var msg = MessageBox.Show("Are you sure you want to delete this record?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    if (centerType == "Internal")
                    {
                        clsCenter c = new clsCenter(id);
                        c.DeleteCenter();
                        this.radButtonElementInternal.PerformClick();
                        this.lblMsg.Text = "Record deleted successfully";
                    }
                    else if(centerType == "Orange")
                    {
                        clsOrangeCardCenter o = new clsOrangeCardCenter(id);
                        o.Delete();
                        this.radButtonElementOrng.PerformClick();
                        this.lblMsg.Text = "Record deleted successfully";
                    }
                    else if(centerType == "Border")
                    {
                        clsBorderCenter b = new clsBorderCenter(id);
                        b.Delete();
                        this.radButtonElementBord.PerformClick();
                        this.lblMsg.Text = "Record deleted successfully";
                    }
                    else if (centerType == "Warehouse")
                    {
                        clsWarehouse w = new clsWarehouse(id);
                        w.Delete();
                        this.radButtonElementWarehouses.PerformClick();
                        this.lblMsg.Text = "Record deleted successfully";
                    }
                    //  MessageBox.Show("Record deleted successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {

            }
        }

        private void BtnNew_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.BtnNew, "Add new center");
        }

        private void btnEdit_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.btnEdit, "Edit center");
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.btnDelete, "Delete center");
        }

        private void frmCenters_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        static string centerType = "Internal";
        private void radButtonElementInternal_Click(object sender, EventArgs e)
        {
            clsCenter c = new clsCenter();
            this.centersGridView.DataSource = c.GetAll();
            this.Text = "Internal Centers";
            this.lblMsg.Text = "";
            centerType = "Internal";
        }

        private void radButtonElementOrng_Click(object sender, EventArgs e)
        {
            clsOrangeCardCenter o = new clsOrangeCardCenter();
            this.centersGridView.DataSource = o.GetAll();
            this.Text = "Orange Card Centers";
            this.lblMsg.Text = "";
            centerType = "Orange";
        }

        private void radButtonElementBord_Click(object sender, EventArgs e)
        {
            clsBorderCenter b = new clsBorderCenter();
            this.centersGridView.DataSource = b.GetAll();
            this.Text = "Border Centers";
            this.lblMsg.Text = "";
            centerType = "Border";
        }

        private void radButtonElementWarehouses_Click(object sender, EventArgs e)
        {
            clsWarehouse w = new clsWarehouse();
            this.centersGridView.DataSource = w.GetAll();
            this.Text = "Warehouses";
            this.lblMsg.Text = "";
            centerType = "Warehouse";
        }



    }
}
