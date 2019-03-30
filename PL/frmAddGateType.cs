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
    public partial class frmAddGateType : Telerik.WinControls.UI.RadForm
    {
        int id = 0;
        public string type = "";
        public frmAddGateType()
        {
            InitializeComponent();
        }

        public frmAddGateType(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void frmAddGateType_Load(object sender, EventArgs e)
        {
            if(type =="Edit")
            {
                clsGateType g = new clsGateType(id);
                this.txtName.Text = g.GetGateTypeByID().Rows[0][1].ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrWhiteSpace(txtName.Text))
            {
                frmGateTypes.GetFrmGateTypes.lblMsg.Text = "Please enter gate type";
            }
            else
            {
                if (type == "New")
                {
                    clsGateType g = new clsGateType(txtName.Text);
                    g.Add();
                    frmGateTypes.GetFrmGateTypes.gateTypesGridView.DataSource = g.GetAll();
                    frmGateTypes.GetFrmGateTypes.lblMsg.Text = "Gate added successfully";
                    // MessageBox.Show("Gate added successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (type == "Edit")
                {
                    clsGateType g = new clsGateType(id, txtName.Text);
                    g.Edit();
                    frmGateTypes.GetFrmGateTypes.gateTypesGridView.DataSource = g.GetAll();
                    frmGateTypes.GetFrmGateTypes.lblMsg.Text = "Gate edited successfully";
                    //MessageBox.Show("Gate edited successfully", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
