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
    public partial class frmAddToDoTask : Telerik.WinControls.UI.RadForm
    {
        int id = 0;
        public string type = "";
        public frmAddToDoTask()
        {
            InitializeComponent();
        }
        public frmAddToDoTask(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void frmAddToDoTask_Load(object sender, EventArgs e)
        {
            this.radTimePicker1.Value = DateTime.Now;
            this.radDateTimePicker1.Value = DateTime.Now;
            if (type == "Edit")
            {
                clsToDoTask t = new clsToDoTask(id);
                this.txtTask.Text = t.GetTaskByID().Rows[0][1].ToString();
                this.radDateTimePicker1.Value = Convert.ToDateTime(t.GetTaskByID().Rows[0][2]);
                this.radTimePicker1.Value = Convert.ToDateTime(t.GetTaskByID().Rows[0][2]);
                this.cbRemind.Checked = Convert.ToBoolean(t.GetTaskByID().Rows[0][5]);
            }
            else if(type=="New")
            {
                this.cbRemind.Checked = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTask.Text) || String.IsNullOrWhiteSpace(txtTask.Text))
            {
                frmToDoList.GetFrmToDoList.lblMsg.Text = "Please enter task text";
                //  MessageBox.Show("Please enter task text.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (type == "New")
                {
                    DateTime dt = new DateTime(this.radDateTimePicker1.Value.Year, this.radDateTimePicker1.Value.Month, this.radDateTimePicker1.Value.Day, this.radTimePicker1.Value.Value.Hour, this.radTimePicker1.Value.Value.Minute,0);
                    clsUser user = new clsUser();
                    clsToDoTask task = new clsToDoTask(txtTask.Text, dt, cbRemind.Checked);
                    task.AddTask(user.GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text));

                    frmToDoList.GetFrmToDoList.TasksGridView.DataSource = new clsToDoTask().GetAll(user.GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text));
                    frmToDoList.GetFrmToDoList.lblMsg.Text = "Task added successfully";
                    // MessageBox.Show("Task added successfully", "Add task", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (type == "Edit")
                {
                    DateTime dt = new DateTime(this.radDateTimePicker1.Value.Year, this.radDateTimePicker1.Value.Month, this.radDateTimePicker1.Value.Day, this.radTimePicker1.Value.Value.Hour, this.radTimePicker1.Value.Value.Minute,0);
                    clsUser user = new clsUser();
                    clsToDoTask task = new clsToDoTask(id, txtTask.Text, dt, cbRemind.Checked);
                    task.EditTask();

                    frmToDoList.GetFrmToDoList.TasksGridView.DataSource = new clsToDoTask().GetAll(user.GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text));
                    frmToDoList.GetFrmToDoList.lblMsg.Text = "Task edited successfully";
                    //MessageBox.Show("Task added successfully", "Add task", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
