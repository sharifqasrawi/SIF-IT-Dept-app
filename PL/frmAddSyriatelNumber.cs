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
    public partial class frmAddSyriatelNumber : Telerik.WinControls.UI.RadForm
    {
        int id = 0;
        public string type = "";
        public frmAddSyriatelNumber()
        {
            InitializeComponent();
        }

        public frmAddSyriatelNumber(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddSyriatelNumber_Load(object sender, EventArgs e)
        {
            
            if (type == "Edit")
            {
                clsSyriatelNumber n = new clsSyriatelNumber(id);
                this.txtEmpName.Text = n.GetNumberByID().Rows[0][1].ToString();
                this.txtSyrNumber.Text = n.GetNumberByID().Rows[0][2].ToString();
                this.txtLimit.Text = n.GetNumberByID().Rows[0][4].ToString();
                this.radDateTimePicker1.Value = Convert.ToDateTime(n.GetNumberByID().Rows[0][3].ToString());
                this.cbActive.Checked = Convert.ToBoolean(n.GetNumberByID().Rows[0][5].ToString());
                this.txtPin.Text = n.GetNumberByID().Rows[0][6].ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsSyriatelNumber n = new clsSyriatelNumber();
            if (String.IsNullOrEmpty(txtEmpName.Text) || String.IsNullOrWhiteSpace(txtEmpName.Text) ||
                String.IsNullOrWhiteSpace(txtSyrNumber.Text) || String.IsNullOrEmpty(txtSyrNumber.Text) ||
                String.IsNullOrWhiteSpace(txtLimit.Text) || String.IsNullOrEmpty(txtLimit.Text))
            {
                frmSyriatelNumbers.GetFrmSyriatelNumbers.lblMsg.Text = "Please Enter all data";
            }
            else
            {
                if (type == "New")
                {
                    if (n.IsNumberExists(txtSyrNumber.Text))
                    {
                        frmSyriatelNumbers.GetFrmSyriatelNumbers.lblMsg.Text = "Sorry, This number already exists";
                        // MessageBox.Show("Sorry, This number already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        n = new clsSyriatelNumber(txtEmpName.Text, txtSyrNumber.Text, radDateTimePicker1.Value, txtLimit.Text, cbActive.Checked,txtPin.Text);
                        n.Add();
                        frmSyriatelNumbers.GetFrmSyriatelNumbers.syrNGridView.DataSource = n.GetAll();
                        frmSyriatelNumbers.GetFrmSyriatelNumbers.lblMsg.Text = "Number addded successfully";
                        // MessageBox.Show("Number addded successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else if (type == "Edit")
                {
                    n = new clsSyriatelNumber(id, txtEmpName.Text, txtSyrNumber.Text, radDateTimePicker1.Value, txtLimit.Text, cbActive.Checked, txtPin.Text);
                    n.Edit();
                    frmSyriatelNumbers.GetFrmSyriatelNumbers.syrNGridView.DataSource = n.GetAll();
                    frmSyriatelNumbers.GetFrmSyriatelNumbers.lblMsg.Text = "Number edited successfully";
                    //MessageBox.Show("Number edited successfully", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
