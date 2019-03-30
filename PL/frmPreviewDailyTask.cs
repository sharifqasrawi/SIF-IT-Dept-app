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
    public partial class frmPreviewDailyTask : Telerik.WinControls.UI.RadForm
    {
        clsDoneTask t;
        private int id;
        public frmPreviewDailyTask(int id)
        {
            InitializeComponent();
            this.id = id;
            t = new clsDoneTask(this.id);

        }

        private void frmPreviewDailyTask_Load(object sender, EventArgs e)
        {
            txtUser.Text = new clsUser().GetUserFullNameByID(int.Parse(t.GetUserDoneTasksByID().Rows[0][4].ToString()));
            txtTask.Text = t.GetUserDoneTasksByID().Rows[0][1].ToString();
            txtDate.Text = Convert.ToDateTime(t.GetUserDoneTasksByID().Rows[0][2].ToString()).ToShortDateString();
            txtNotes.Text = t.GetUserDoneTasksByID().Rows[0][3].ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
