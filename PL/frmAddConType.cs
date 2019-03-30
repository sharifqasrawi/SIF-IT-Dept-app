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
    public partial class frmAddConType : Telerik.WinControls.UI.RadForm
    {
        int id = 0;
        public string type = "";
        public frmAddConType()
        {
            InitializeComponent();
        }
        public frmAddConType(int id)
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
            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrWhiteSpace(txtName.Text))
            {
                frmConnectionTypes.GetFrmConnectionTypes.lblMsg.Text = "Please enter connection type";
            }
            else
            {
                if (type == "New")
                {
                    clsConType ct = new clsConType(txtName.Text);
                    ct.Add();
                    frmConnectionTypes.GetFrmConnectionTypes.conTypesGridView.DataSource = ct.GetAll();
                    frmConnectionTypes.GetFrmConnectionTypes.lblMsg.Text = "Connection type added successfully";
                    //  MessageBox.Show("Connection type added successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (type == "Edit")
                {
                    clsConType ct = new clsConType(id, txtName.Text);
                    ct.Edit();
                    frmConnectionTypes.GetFrmConnectionTypes.conTypesGridView.DataSource = ct.GetAll();
                    frmConnectionTypes.GetFrmConnectionTypes.lblMsg.Text = "Connection type edited successfully";
                    //MessageBox.Show("Connection type edited successfully", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void frmAddConType_Load(object sender, EventArgs e)
        {
            if(type=="Edit")
            {
                clsConType ct = new clsConType(id);
                this.txtName.Text = ct.GetConTypeByID().Rows[0][1].ToString();
            }
        }
    }
}
