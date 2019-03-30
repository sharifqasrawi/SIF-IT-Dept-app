using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using IT_Dept.DL;
using System.Data.SqlClient;
using IT_Dept.BL;

namespace IT_Dept.PL
{
    public partial class frmBackUpDB : Telerik.WinControls.UI.RadForm
    {
        SqlCommand cmd;
        DLClass dl = new DLClass();
        public frmBackUpDB()
        {
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Backup files (*.bak) |*.bak";
            if(sf.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    cmd = new SqlCommand("Backup Database IT_Dept To Disk='" + sf.FileName + "'", dl.CN);
                    dl.Open();
                    cmd.ExecuteNonQuery();
                    dl.Close();
                    MessageBox.Show("Database Backup Success", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            this.txtFileName.Text = openFileDialog1.FileName;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                dl.Close();
                frmMain.GetFrmMain.aTimer.Enabled = false;
                string query = "use master " +
                                "alter database IT_Dept " +
                                "set single_user with rollback immediate; " +
                                "alter database IT_Dept " +
                                "set multi_user; ";
                SqlConnection cn = new SqlConnection(@"Data Source = Sharif-dell\SQLExpress; Database = Master; Integrated Security=false; User Id = kim; Password = kim2009");
                cmd = new SqlCommand(query+ " Restore Database IT_Dept From Disk='" + txtFileName.Text + "'", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
                dl.Open();
                frmMain.GetFrmMain.aTimer.Enabled = true;
                MessageBox.Show("Database Restore Success", "Restore", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Restore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBackUpDB_Load(object sender, EventArgs e)
        {
            clsUser user = new clsUser();

            int userID = new clsUser().GetUserID(frmMain.GetFrmMain.radLabelElementUsername.Text);

            if (user.IsInRole(userID, "Admin") || user.IsInRole(userID, "Boss"))
            {
                this.btnBackup.Enabled = true;
                this.btnOpenFile.Enabled = true;
                this.btnRestore.Enabled = true;
            }

            if (user.IsInRole(userID, "BackupDB"))
            {
                this.btnBackup.Enabled = true;
            }
            if (user.IsInRole(userID, "RestoreDB"))
            {
                this.btnOpenFile.Enabled = true;
                this.btnRestore.Enabled = true;
            }
        }
    }
}
