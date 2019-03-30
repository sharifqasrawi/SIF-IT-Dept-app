using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using IT_Dept.BL;
using IT_Dept.PL;

namespace IT_Dept.PL
{
    public partial class frmAddArea : Telerik.WinControls.UI.RadForm
    {

        int id = 0;
        public string type = "";
        public frmAddArea()
        {
            InitializeComponent();
            
        }

        public frmAddArea(int id)
        {
            InitializeComponent();
            this.id = id;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (type == "New")
            {
                if (String.IsNullOrEmpty(this.txtName.Text) || String.IsNullOrEmpty(this.txtMngr.Text) || String.IsNullOrWhiteSpace(this.txtName.Text) || String.IsNullOrWhiteSpace(this.txtMngr.Text))
                {
                    frmAreas.GetFrmAreas.lblMsg.Text = "Please enter the required data";
                 //   MessageBox.Show("Please enter the required data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    clsArea area = new clsArea(this.txtName.Text, this.txtMngr.Text);
                    area.Add();

                    frmAreas.GetFrmAreas.areasGridView.DataSource = area.GetAll();
                    frmAreas.GetFrmAreas.lblMsg.Text = "Area added successfully";
                 //   MessageBox.Show("Area added successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else if(type=="Edit")
            {
                clsArea area = new clsArea(id, txtName.Text, txtMngr.Text);
                area.Edit();
                frmAreas.GetFrmAreas.areasGridView.DataSource = area.GetAll();
                frmAreas.GetFrmAreas.lblMsg.Text = "Area edited successfully";
                // MessageBox.Show("Area Edited successfully", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddArea_Load(object sender, EventArgs e)
        {
            if (type == "Edit")
            {
                clsArea area = new clsArea(id);
                DataTable dt = area.GetAreaByID();

                this.txtName.Text = dt.Rows[0][1].ToString();
                this.txtMngr.Text = dt.Rows[0][2].ToString();
            }
        }
    }
}
