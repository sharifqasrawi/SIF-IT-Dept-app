using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using IT_Dept.BL;
using System.Text.RegularExpressions;

namespace IT_Dept.PL
{
    public partial class frmAddCenter : Telerik.WinControls.UI.RadForm
    {
        int id = 0;
        public string type = "";
        public string cntType = "";
        public frmAddCenter()
        {
            InitializeComponent();
        }
        public frmAddCenter(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClearfields_Click(object sender, EventArgs e)
        {

            var msg = MessageBox.Show("Are you sure you want to clear all fields?", "Clear fields", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                this.ClearFields();
            }
        }

        private void frmAddCenter_Load(object sender, EventArgs e)
        {
            clsGovernorate g = new clsGovernorate();
            this.lstGov.DataSource = g.GetAll();
            this.lstGov.DisplayMember = "Governorate name";
            this.lstGov.ValueMember = "#";

            clsConType t = new clsConType();
            this.lstConTypes.DataSource = t.GetAll();
            this.lstConTypes.DisplayMember = "Type";
            this.lstConTypes.ValueMember = "#";

            clsConSpeed s = new clsConSpeed();
            this.lstConSpeeds.DataSource = s.GetAll();
            this.lstConSpeeds.DisplayMember = "Speed";
            this.lstConSpeeds.ValueMember = "#";

            clsGateType gt = new clsGateType();
            this.lstGateTypes.DataSource = gt.GetAll();
            this.lstGateTypes.DisplayMember = "Type";
            this.lstGateTypes.ValueMember = "#";

            clsCenter cnt = new clsCenter();
            this.lstCenters.DataSource = cnt.GetAll();
            this.lstCenters.DisplayMember = "Center name";
            this.lstCenters.ValueMember = "#";

            if (type == "Edit")
            {
                if (cntType == "Internal")
                {
                    this.rbInt.IsChecked = true;
                    this.rbOrng.IsChecked = false;
                    this.rbBord.IsChecked = false;
                    this.rbInt.Enabled = true;
                    this.rbOrng.Enabled = false;
                    this.rbBord.Enabled = false;
                    this.panelOrngBord.Hide();
                    this.panelInt.Show();

                    clsCenter c = new clsCenter(this.id);
                    this.txtCntCode.Text = c.GetCenterByID().Rows[0][5].ToString();
                    this.txtCntName.Text = c.GetCenterByID().Rows[0][6].ToString();
                    this.txtGateNum.Text = c.GetCenterByID().Rows[0][11].ToString();
                    this.txtCirCode.Text = c.GetCenterByID().Rows[0][14].ToString();
                    this.txtCntHName.Text = c.GetCenterByID().Rows[0][17].ToString();
                    this.txtConIP.Text = c.GetCenterByID().Rows[0][8].ToString();
                    this.txtLanIP.Text = c.GetCenterByID().Rows[0][7].ToString();
                    this.txtServerIP.Text = c.GetCenterByID().Rows[0][18].ToString();
                    this.txtDB.Text = c.GetCenterByID().Rows[0][9].ToString();
                    this.txtAdminOrd.Text = c.GetCenterByID().Rows[0][10].ToString();
                    this.txtPDNUn.Text = c.GetCenterByID().Rows[0][12].ToString();
                    this.txtPDNPW.Text = c.GetCenterByID().Rows[0][13].ToString();
                    this.txtPHNum.Text = c.GetCenterByID().Rows[0][15].ToString();
                    this.txtMobNum.Text = c.GetCenterByID().Rows[0][16].ToString();
                    this.lstGov.SelectedValue = int.Parse(c.GetCenterByID().Rows[0][1].ToString());
                    this.lstGateTypes.SelectedValue = int.Parse(c.GetCenterByID().Rows[0][4].ToString());
                    this.lstConTypes.SelectedValue = int.Parse(c.GetCenterByID().Rows[0][2].ToString());
                    this.lstConSpeeds.SelectedValue = int.Parse(c.GetCenterByID().Rows[0][3].ToString());

                    try
                    {
                        if (Convert.ToDateTime(c.GetCenterByID().Rows[0][21].ToString()) != null)
                        {
                            this.dateOrd.Value = Convert.ToDateTime(c.GetCenterByID().Rows[0][21].ToString());
                        }
                        else
                        {
                            this.dateOrd.Value = DateTime.Now;
                        }
                    }
                    catch
                    {

                    }
                }
                else if(cntType ==  "Orange")
                {
                    this.rbInt.IsChecked = false;
                    this.rbOrng.IsChecked = true;
                    this.rbBord.IsChecked = false;
                    this.rbWarehouse.IsChecked = false;
                    this.rbWarehouse.Enabled = false;
                    this.rbInt.Enabled = false;
                    this.rbOrng.Enabled = true;
                    this.rbBord.Enabled = false;
                    this.panelInt.Hide();
                    this.panelOrngBord.Show();
                    
                    clsOrangeCardCenter o = new clsOrangeCardCenter(id);

                    this.lstCenters.SelectedValue = int.Parse(o.GetOrangeCenterByID().Rows[0][1].ToString());
                    this.txtOrngBordCode.Text = o.GetOrangeCenterByID().Rows[0][2].ToString();
                    this.txtOrngBordDB.Text = o.GetOrangeCenterByID().Rows[0][3].ToString();

                }
                else if(cntType == "Border")
                {
                    this.rbInt.IsChecked = false;
                    this.rbOrng.IsChecked = false;
                    this.rbBord.IsChecked = true;
                    this.rbWarehouse.IsChecked = false;
                    this.rbWarehouse.Enabled = false;
                    this.rbInt.Enabled = false;
                    this.rbOrng.Enabled = false;
                    this.rbBord.Enabled = true;
                    this.panelInt.Hide();
                    this.panelOrngBord.Show();

                    clsBorderCenter b = new clsBorderCenter(id);

                    this.lstCenters.SelectedValue = int.Parse(b.GetBorderCenterByID().Rows[0][3].ToString());
                    this.txtOrngBordCode.Text = b.GetBorderCenterByID().Rows[0][1].ToString();
                    this.txtOrngBordDB.Text = b.GetBorderCenterByID().Rows[0][2].ToString();

                }
                else if (cntType == "Warehouse")
                {
                    this.rbWarehouse.IsChecked = true;
                    this.rbWarehouse.Enabled = true;
                    this.rbInt.IsChecked = false;
                    this.rbOrng.IsChecked = false;
                    this.rbBord.IsChecked = false;
                    this.rbInt.Enabled = false;
                    this.rbOrng.Enabled = false;
                    this.rbBord.Enabled = false;
                    this.panelInt.Hide();
                    this.panelOrngBord.Show();

                    clsWarehouse w = new clsWarehouse(id);

                    this.lstCenters.SelectedValue = int.Parse(w.GetWarehouseByID().Rows[0][1].ToString());
                    this.txtOrngBordCode.Text = w.GetWarehouseByID().Rows[0][2].ToString();
                    this.txtOrngBordDB.Text = w.GetWarehouseByID().Rows[0][3].ToString();

                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (type == "New")
                {

                    clsCenter center = new clsCenter();
                    if (!center.IsCenterExists(int.Parse(txtCntCode.Text)))
                    {
                        if (!center.IsIPExists(txtConIP.Text, txtLanIP.Text, txtServerIP.Text))
                        {
                            if (!IsValidIP(txtConIP.Text) || !IsValidIP(txtLanIP.Text) || !IsValidIP(txtServerIP.Text))
                            {
                                lblMsg.Text = "Please enter a valid IP Address";
                            }
                            else
                            {
                                center = new clsCenter(int.Parse(txtCntCode.Text), txtCntName.Text, int.Parse(lstGov.SelectedValue.ToString()),
                                                                int.Parse(lstConTypes.SelectedValue.ToString()), int.Parse(lstConSpeeds.SelectedValue.ToString()),
                                                                int.Parse(lstGateTypes.SelectedValue.ToString()), int.Parse(txtGateNum.Text),
                                                                txtCirCode.Text, txtCntHName.Text, txtConIP.Text, txtLanIP.Text, txtDB.Text, txtAdminOrd.Text, txtPDNUn.Text,
                                                                txtPDNPW.Text, txtPHNum.Text, txtMobNum.Text, txtServerIP.Text, dateOrd.Value);

                                center.addCenter();
                                frmCenters.GetFrmCenters.radButtonElementInternal.PerformClick();
                                frmCenters.GetFrmCenters.lblMsg.Text = "Center Added Successfully";
                                //   MessageBox.Show("Center Added Successfully", "Add Center", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                        else
                        {
                            frmCenters.GetFrmCenters.lblMsg.Text = "IP Address already exists";
                            // MessageBox.Show("IP Address already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                    }
                    else
                    {
                        frmCenters.GetFrmCenters.lblMsg.Text = "Center already exists";
                        // MessageBox.Show("Center already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }

                }
                else if (type == "Edit")
                {
                    
                        if (!IsValidIP(txtConIP.Text) || !IsValidIP(txtLanIP.Text))
                        {
                            lblMsg.Text = "Please enter a valid IP Address";
                        }
                        else
                        {

                            clsCenter center = new clsCenter(id, int.Parse(txtCntCode.Text), txtCntName.Text, int.Parse(lstGov.SelectedValue.ToString()),
                                                                int.Parse(lstConTypes.SelectedValue.ToString()), int.Parse(lstConSpeeds.SelectedValue.ToString()),
                                                                int.Parse(lstGateTypes.SelectedValue.ToString()), int.Parse(txtGateNum.Text),
                                                                txtCirCode.Text, txtCntHName.Text, txtConIP.Text, txtLanIP.Text, txtDB.Text, txtAdminOrd.Text, txtPDNUn.Text,
                                                                txtPDNPW.Text, txtPHNum.Text, txtMobNum.Text, txtServerIP.Text, dateOrd.Value);
                            center.EditCenter();
                            frmCenters.GetFrmCenters.radButtonElementInternal.PerformClick();
                            frmCenters.GetFrmCenters.lblMsg.Text = "Center Edited Successfully";
                            // MessageBox.Show("Center Edited Successfully", "Edit Center", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    
                }
            }
            catch(Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
        }


        ///

        public bool IsValidIP(string addr)
        {
            //create our match pattern
            string pattern = @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$";
            //create our Regular Expression object
            Regex check = new Regex(pattern);
            //boolean variable to hold the status
            bool valid = false;
            //check to make sure an ip address was provided
            if (addr == "")
            {
                //no address provided so return false
                valid = false;
            }
            else
            {
                //address provided so use the IsMatch Method
                //of the Regular Expression object
                valid = check.IsMatch(addr, 0);
            }
            //return the results
            return valid;
        }

        ///
        private void ClearFields()
        {
            this.txtCntCode.Clear();
            this.txtCntName.Clear();
            this.txtGateNum.Clear();
            this.txtCirCode.Clear();
            this.txtCntHName.Clear();
            this.txtConIP.Clear();
            this.txtLanIP.Clear();
            this.txtServerIP.Clear();
            this.txtDB.Clear();
            this.txtAdminOrd.Clear();
            this.txtPDNPW.Clear();
            this.txtPDNUn.Clear();
            this.txtPHNum.Clear();
            this.txtMobNum.Clear();
        }

        ///
        private void isNumberKey(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rbOrng_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.panelInt.Hide();
            this.panelOrngBord.Show();
            this.lstCenters.DataSource = new clsCenter().GetAll();
            this.lstCenters.DisplayMember = "Center name";
            this.lstCenters.ValueMember = "#";
        }

        private void rbInt_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.panelOrngBord.Hide();
            this.panelInt.Show();
        }

        private void btnCancelOrngBord_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCleareOrngBord_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Are you sure you want to clear all fields?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                this.txtOrngBordCode.Clear();
                this.txtOrngBordDB.Clear();
            }
        }

        private void btnSaveOrngBord_Click(object sender, EventArgs e)
        {
            try
            {
                if (type == "New")
                {
                    if (rbOrng.IsChecked)
                    {
                        clsOrangeCardCenter o = new clsOrangeCardCenter(int.Parse(lstCenters.SelectedValue.ToString()), txtOrngBordCode.Text, txtOrngBordDB.Text);
                        o.Add();
                        frmCenters.GetFrmCenters.radButtonElementOrng.PerformClick();
                        frmCenters.GetFrmCenters.lblMsg.Text = "Orange Card Center Added Successfully";
                        this.Close();
                    }
                    else if (rbBord.IsChecked)
                    {
                        clsBorderCenter b = new clsBorderCenter(int.Parse(lstCenters.SelectedValue.ToString()), txtOrngBordCode.Text, txtOrngBordDB.Text);
                        b.Add();
                        frmCenters.GetFrmCenters.radButtonElementBord.PerformClick();
                        frmCenters.GetFrmCenters.lblMsg.Text = "Border Center Added Successfully";
                        this.Close();
                    }
                    else if(rbWarehouse.IsChecked)
                    {
                        clsWarehouse w = new clsWarehouse(int.Parse(lstCenters.SelectedValue.ToString()), txtOrngBordCode.Text, txtOrngBordDB.Text);
                        w.Add();
                        frmCenters.GetFrmCenters.radButtonElementWarehouses.PerformClick();
                        frmCenters.GetFrmCenters.lblMsg.Text = "Warehouse Added Successfully";
                        this.Close();
                    }
                }
                else if (type == "Edit")
                {
                    if (cntType == "Orange")
                    {
                        clsOrangeCardCenter o = new clsOrangeCardCenter(id, int.Parse(lstCenters.SelectedValue.ToString()), txtOrngBordCode.Text, txtOrngBordDB.Text);
                        o.Edit();
                        frmCenters.GetFrmCenters.radButtonElementOrng.PerformClick();
                        frmCenters.GetFrmCenters.lblMsg.Text = "Orange Card Center Edited Successfully";
                        this.Close();
                    }
                    else if (cntType == "Border")
                    {
                        clsBorderCenter b = new clsBorderCenter(id,int.Parse(lstCenters.SelectedValue.ToString()), txtOrngBordCode.Text, txtOrngBordDB.Text);
                        b.Edit();
                        frmCenters.GetFrmCenters.radButtonElementBord.PerformClick();
                        frmCenters.GetFrmCenters.lblMsg.Text = "Border Center Edited Successfully";
                        this.Close();
                    }
                    else if (cntType == "Warehouse")
                    {
                        clsWarehouse w = new clsWarehouse(id, int.Parse(lstCenters.SelectedValue.ToString()), txtOrngBordCode.Text, txtOrngBordDB.Text);
                        w.Edit();
                        frmCenters.GetFrmCenters.radButtonElementWarehouses.PerformClick();
                        frmCenters.GetFrmCenters.lblMsg.Text = "Warehouse Edited Successfully";
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
        }

        private void rbBord_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            this.panelInt.Hide();
            this.panelOrngBord.Show();
            this.lstCenters.DataSource = new clsCenter().GetAll();
            this.lstCenters.DisplayMember = "Center name";
            this.lstCenters.ValueMember = "#";
        }

     
    }
}
