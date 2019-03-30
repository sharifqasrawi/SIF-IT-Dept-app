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
    public partial class frmDoneTasks : Telerik.WinControls.UI.RadForm
    {
        private static frmDoneTasks frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static frmDoneTasks GetFrmDoneTasks
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmDoneTasks();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public frmDoneTasks()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            frmAddDoneTask frm = new frmAddDoneTask();
            frm.type = "New";
            frm.ShowDialog();
        }

        private void frmDoneTasks_Load(object sender, EventArgs e)
        {
            clsUser user = new clsUser();

            int userID = new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text);

            if ( user.IsInRole(userID, "Boss"))
            {
                this.btnAllUsersDoneTasks.Visible = true;
            }


            if (user.IsInRole(userID, "Admin") || user.IsInRole(userID, "Boss"))
            {
                this.btnDelete.Enabled = true;
                this.BtnNew.Enabled = true;
                this.btnEdit.Enabled = true;
            }

            if (user.IsInRole(userID, "AddDoneTask"))
            {
                this.BtnNew.Enabled = true;
            }
            if (user.IsInRole(userID, "EditDoneTask"))
            {
                this.btnEdit.Enabled = true;
            }
            if (user.IsInRole(userID, "DeleteDoneTask"))
            {
                this.btnDelete.Enabled = true;
            }

            this.TasksGridView.DataSource = new clsDoneTask().GetUserDoneTasks(userID);
            this.TasksGridView.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddDoneTask frm = new frmAddDoneTask(int.Parse(this.TasksGridView.SelectedRows[0].Cells[0].Value.ToString()));
                frm.Text = "Edit Task";
                frm.type = "Edit";
                frm.ShowDialog();
            }
            catch
            { }
        }

        private void btnAllUsersDoneTasks_Click(object sender, EventArgs e)
        {
            frmAllDailyTasks.GetFrmAllDailyTasks.Show();
            frmAllDailyTasks.GetFrmAllDailyTasks.BringToFront();
            frmAllDailyTasks.GetFrmAllDailyTasks.WindowState = FormWindowState.Normal;
        }
    }
}
