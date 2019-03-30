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
    public partial class frmAddSIFServer : Telerik.WinControls.UI.RadForm
    {
        public string type = "";
        int id = 0;
        public frmAddSIFServer()
        {
            InitializeComponent();
        }
        public frmAddSIFServer(int id)
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
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtIP.Text))
            {
                frmSIFServers.GetFrmSIFServers.lblMsg.Text = "Please enter server info";
            }
            else
            {
                if (type == "New")
                {
                    clsSIFServer s = new clsSIFServer(txtName.Text, txtIP.Text, txtBrand.Text, txtModel.Text, txtRam.Text);
                    s.Add();
                    frmSIFServers.GetFrmSIFServers.serversGridView.DataSource = s.GetAll();
                    frmSIFServers.GetFrmSIFServers.lblMsg.Text = "Server added successfully";
                    this.Close();
                }
                else if (type == "Edit")
                {
                    clsSIFServer s = new clsSIFServer(id, txtName.Text, txtIP.Text,txtBrand.Text,txtModel.Text,txtRam.Text);
                    s.Edit();
                    frmSIFServers.GetFrmSIFServers.serversGridView.DataSource = s.GetAll();
                    frmSIFServers.GetFrmSIFServers.lblMsg.Text = "Server edited successfully";
                    this.Close();
                }
            }
        }

        private void frmAddSIFServer_Load(object sender, EventArgs e)
        {
            if (type == "Edit")
            {
                clsSIFServer s = new clsSIFServer(id);
                this.txtName.Text = s.GetSIFServerByID().Rows[0][1].ToString();
                this.txtIP.Text = s.GetSIFServerByID().Rows[0][2].ToString();
                this.txtBrand.Text = s.GetSIFServerByID().Rows[0][3].ToString();
                this.txtModel.Text = s.GetSIFServerByID().Rows[0][4].ToString();
                this.txtRam.Text = s.GetSIFServerByID().Rows[0][5].ToString();
            }
        }
    }
}
