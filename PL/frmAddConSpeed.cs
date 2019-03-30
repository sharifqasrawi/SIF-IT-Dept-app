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
    public partial class frmAddConSpeed : Telerik.WinControls.UI.RadForm
    {
        int id = 0;
        public string type = "";
        public frmAddConSpeed()
        {
            InitializeComponent();
        }

        public frmAddConSpeed(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSpeed.Text) || String.IsNullOrWhiteSpace(txtSpeed.Text))
            {
                frmConSpeeds.GetFrmConSpeeds.lblMsg.Text = "Please enter connection speed";
            }
            else
            {
                if (type == "New")
                {
                    clsConSpeed speed = new clsConSpeed(txtSpeed.Text);
                    speed.Add();
                    frmConSpeeds.GetFrmConSpeeds.speedsGridView.DataSource = speed.GetAll();
                    frmConSpeeds.GetFrmConSpeeds.lblMsg.Text = "Connection speed added successfully";
                    //MessageBox.Show("Connection speed added successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (type == "Edit")
                {
                    clsConSpeed speed = new clsConSpeed(id, txtSpeed.Text);
                    speed.Edit();
                    frmConSpeeds.GetFrmConSpeeds.speedsGridView.DataSource = speed.GetAll();
                    frmConSpeeds.GetFrmConSpeeds.lblMsg.Text = "Connection speed edited successfully";
                    //  MessageBox.Show("Connection speed edited successfully", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void frmAddConSpeed_Load(object sender, EventArgs e)
        {
            if(type=="Edit")
            {
                clsConSpeed speed = new clsConSpeed(id);
                this.txtSpeed.Text = speed.GetConSpeedByID().Rows[0][1].ToString();
            }
        }
    }
}
