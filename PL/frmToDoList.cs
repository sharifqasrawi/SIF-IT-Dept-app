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
    public partial class frmToDoList : Telerik.WinControls.UI.RadForm
    {
        private static frmToDoList frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static frmToDoList GetFrmToDoList
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmToDoList();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public frmToDoList()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }

        private void frmToDoList_Load(object sender, EventArgs e)
        {
            clsToDoTask t = new clsToDoTask();

            clsUser user = new clsUser();
            this.TasksGridView.DataSource = t.GetAll(user.GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text));
            this.TasksGridView.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;

            int userID = new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text);

            if (user.IsInRole(userID, "Admin") || user.IsInRole(userID, "Boss"))
            {
                this.btnDelete.Enabled = true;
                this.BtnNew.Enabled = true;
                this.btnEdit.Enabled = true;
                this.picCheck.Enabled = true;
            }

            if (user.IsInRole(userID, "AddToDoTask"))
            {
                this.BtnNew.Enabled = true;
            }
            if (user.IsInRole(userID, "EditToDoTask"))
            {
                this.btnEdit.Enabled = true;
            }
            if (user.IsInRole(userID, "DeleteToDoTask"))
            {
                this.btnDelete.Enabled = true;
            }
            if (user.IsInRole(userID, "CheckToDoTask"))
            {
                this.picCheck.Enabled = true;
            }
        }


        private void picCheck_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.TasksGridView.SelectedRows[0].Cells[0].Value.ToString());
                clsToDoTask task = new clsToDoTask(id);
                if (Convert.ToBoolean(this.TasksGridView.SelectedRows[0].Cells[3].Value) == false)
                {
                    task.MarkAsDone(true);
                    this.picCheck.Image = Properties.Resources.uncheck;
                }
                else
                {
                    task.MarkAsDone(false);
                    this.picCheck.Image = Properties.Resources.check1;
                }
                clsUser user = new clsUser();
                frmToDoList.GetFrmToDoList.TasksGridView.DataSource = new clsToDoTask().GetAll(user.GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void picCheck_MouseDown(object sender, MouseEventArgs e)
        {
            this.picCheck.BorderStyle = BorderStyle.Fixed3D;
        }

        private void picCheck_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            if (Convert.ToBoolean(this.TasksGridView.SelectedRows[0].Cells[3].Value) == true)
                tt.SetToolTip(this.picCheck, "Mark task as not done");
            else
                tt.SetToolTip(this.picCheck, "Mark task as done");
        }

        private void picCheck_MouseUp(object sender, MouseEventArgs e)
        {
            this.picCheck.BorderStyle = BorderStyle.FixedSingle;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            frmAddToDoTask frm = new frmAddToDoTask();
            frm.type = "New";
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.TasksGridView.SelectedRows[0].Cells[0].Value.ToString());
                frmAddToDoTask frm = new frmAddToDoTask(id);
                frm.Text = "Edit Task";
                frm.type = "Edit";
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
                int id = int.Parse(this.TasksGridView.SelectedRows[0].Cells[0].Value.ToString());
                var msg = MessageBox.Show("Are you sure you want to delete this record?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    clsToDoTask task = new clsToDoTask(id);
                    task.DeleteTask();
                    clsUser user = new clsUser();
                    frmToDoList.GetFrmToDoList.TasksGridView.DataSource = task.GetAll(user.GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text));
                    this.lblMsg.Text = "Record deleted successfully";
                    //  MessageBox.Show("Record deleted successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.btnDelete, "Delete task");
        }

        private void btnEdit_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.btnEdit, "Edit task");
        }

        private void BtnNew_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.BtnNew, "Add new task");
        }

      
    }
}
