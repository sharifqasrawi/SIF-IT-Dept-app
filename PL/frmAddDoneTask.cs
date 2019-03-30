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
    public partial class frmAddDoneTask : Telerik.WinControls.UI.RadForm
    {
        public string type = "";
        int id = 0;
        public frmAddDoneTask()
        {
            InitializeComponent();
        }
        public frmAddDoneTask(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void frmAddDoneTask_Load(object sender, EventArgs e)
        {
            this.radDateTimePicker1.Value = DateTime.Now;
            if (type == "Edit")
            {
                txtTask.Text = new clsDoneTask(id).GetUserDoneTasksByID().Rows[0][1].ToString();
                txtNotes.Text = new clsDoneTask(id).GetUserDoneTasksByID().Rows[0][3].ToString();
                radDateTimePicker1.Value = Convert.ToDateTime(new clsDoneTask(id).GetUserDoneTasksByID().Rows[0][2]);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtTask.Text) || String.IsNullOrEmpty(txtTask.Text))
            {
                frmDoneTasks.GetFrmDoneTasks.lblMsg.Text = "Please enter Task info";
            }
            else
            {
                int userID = new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text);

                if (type == "New")
                {
                    clsDoneTask t = new clsDoneTask(txtTask.Text, txtNotes.Text, radDateTimePicker1.Value, userID);
                    t.AddTask();
                    frmDoneTasks.GetFrmDoneTasks.TasksGridView.DataSource = t.GetUserDoneTasks(userID);
                    frmDoneTasks.GetFrmDoneTasks.lblMsg.Text = "Task Added successfully";
                    this.Close();
                }
                else if (type == "Edit")
                {
                    clsDoneTask t = new clsDoneTask(id, txtTask.Text, txtNotes.Text);
                    t.EditTask();
                    frmDoneTasks.GetFrmDoneTasks.TasksGridView.DataSource = t.GetUserDoneTasks(userID);
                    frmDoneTasks.GetFrmDoneTasks.lblMsg.Text = "Task Edited successfully";
                    this.Close();
                }
            }
        }
    }
}
