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
    public partial class frmAddGov : Telerik.WinControls.UI.RadForm
    {
        int id = 0;
        public string type = "";
        public frmAddGov()
        {
            InitializeComponent();
        }
        public frmAddGov(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddGov_Load(object sender, EventArgs e)
        {
            clsArea areas = new clsArea();
            this.lstAreas.DataSource = areas.GetAll();
            this.lstAreas.DisplayMember = "Area name";
            this.lstAreas.ValueMember = "#";

            if(type=="Edit")
            {
                clsGovernorate g = new clsGovernorate(id);
                this.txtName.Text = g.GetGovByID().Rows[0][1].ToString();

                clsArea a = new clsArea();
                this.lstAreas.SelectedValue = int.Parse(a.GetAreaIDByName(frmGovernorates.GetFrmGovernorates.govGridView.SelectedRows[0].Cells[2].Value.ToString()).Rows[0][0].ToString());
              //  MessageBox.Show(a.GetAreaIDByName(txtName.Text).Rows[0][0].ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtName.Text) || String.IsNullOrEmpty(txtName.Text) || lstAreas.SelectedValue == null)
            {
                frmGovernorates.GetFrmGovernorates.lblMsg.Text = "Please enter all data";
            }
            else
            {
                if (type == "New")
                {
                    clsGovernorate g = new clsGovernorate(txtName.Text, int.Parse(this.lstAreas.SelectedValue.ToString()));
                    g.Add();
                    frmGovernorates.GetFrmGovernorates.govGridView.DataSource = g.GetAll();
                    frmGovernorates.GetFrmGovernorates.lblMsg.Text = "Governorate added successfully";
                    //   MessageBox.Show("Governorate added successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else if (type == "Edit")
                {
                    clsGovernorate g = new clsGovernorate(id, txtName.Text, int.Parse(this.lstAreas.SelectedValue.ToString()));
                    g.Edit();
                    frmGovernorates.GetFrmGovernorates.govGridView.DataSource = g.GetAll();
                    frmGovernorates.GetFrmGovernorates.lblMsg.Text = "Governorate edited successfully";
                    //       MessageBox.Show("Governorate edited successfully", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
