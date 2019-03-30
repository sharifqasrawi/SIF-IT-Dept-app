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
    public partial class frmAllDailyTasks : Telerik.WinControls.UI.RadForm
    {
        private static frmAllDailyTasks frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static frmAllDailyTasks GetFrmAllDailyTasks
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmAllDailyTasks();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public frmAllDailyTasks()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }

        private void frmAllDailyTasks_Load(object sender, EventArgs e)
        {
            clsDoneTask t = new clsDoneTask();
            this.TasksGridView.DataSource = t.GetUserDoneTasks();
            this.TasksGridView.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
        }

        private void TasksGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int id = int.Parse(this.TasksGridView.SelectedRows[0].Cells[0].Value.ToString());
            frmPreviewDailyTask frm = new frmPreviewDailyTask(id);
            frm.ShowDialog();
        }
    }
}
