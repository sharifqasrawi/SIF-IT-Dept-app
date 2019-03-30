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
    public partial class frmAdd3GSim : Telerik.WinControls.UI.RadForm
    {
        public string type = "";
        int id = 0;
        public frmAdd3GSim()
        {
            InitializeComponent();
        }
        public frmAdd3GSim(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void frmAdd3GSim_Load(object sender, EventArgs e)
        {

            if (type == "Edit")
            {
                cls3GSim sim = new cls3GSim(id);
               this.txtCenter.Text = sim.GetSimCard().Rows[0][1].ToString();
               this.txtIP.Text = sim.GetSimCard().Rows[0][4].ToString();
                this.txtPin.Text = sim.GetSimCard().Rows[0][2].ToString();
                this.txtSimNum.Text = sim.GetSimCard().Rows[0][3].ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(type == "New")
            {
                cls3GSim sim = new cls3GSim(txtCenter.Text,txtIP.Text, txtPin.Text, txtSimNum.Text);
                sim.AddSim();
                frm3GSimCards.GetFrm3GSimCards.SimsGridView.DataSource = sim.GetAll();
                frm3GSimCards.GetFrm3GSimCards.lblMsg.Text = "3G Sim added successfully";
                this.Close();
            }
            else if(type == "Edit")
            {
                cls3GSim sim = new cls3GSim(id, txtCenter.Text,txtIP.Text, txtPin.Text, txtSimNum.Text);
                sim.EditSim();
                frm3GSimCards.GetFrm3GSimCards.SimsGridView.DataSource = sim.GetAll();
                frm3GSimCards.GetFrm3GSimCards.lblMsg.Text = "3G Sim edited successfully";
                this.Close();
            }
        }
    }
}
