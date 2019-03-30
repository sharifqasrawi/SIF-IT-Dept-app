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
    public partial class frmAddUser : Telerik.WinControls.UI.RadForm
    {
        public string type = "";
        int id = 0;
        public frmAddUser()
        {
            InitializeComponent();
        }

        public frmAddUser(int id)
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
            if (type == "New")
            {
                try
                {
                    if (String.IsNullOrEmpty(txtFName.Text) || String.IsNullOrWhiteSpace(txtFName.Text)
                     || String.IsNullOrEmpty(txtLName.Text) || String.IsNullOrWhiteSpace(txtLName.Text)
                     || String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrWhiteSpace(txtUsername.Text)
                     || String.IsNullOrEmpty(txtPw.Text) || String.IsNullOrWhiteSpace(txtPw.Text))
                    {
                        frmUsersMng.GetFrmUsersMngTypes.lblMsg.Text = "Please enter all data";
                        //MessageBox.Show("Please enter all data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        clsUser user = new clsUser();
                        if (user.IsUserExists(txtUsername.Text))
                        {
                            MessageBox.Show("Sorry, This user already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            user = new clsUser(txtFName.Text, txtLName.Text, txtUsername.Text, txtPw.Text, cbActive.Checked, DateTime.Now);
                            user.AddUser();
                            frmUsersMng.GetFrmUsersMngTypes.usersGridView.DataSource = user.GetAllUsers();
                            frmUsersMng.GetFrmUsersMngTypes.lblMsg.Text = "User added successfully";
                            //  MessageBox.Show("User added successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (type == "Edit")
            {
                try
                {
                   clsUser user = new clsUser(id, txtFName.Text, txtLName.Text, txtUsername.Text, cbActive.Checked);
                   user.EditUser();
                   frmUsersMng.GetFrmUsersMngTypes.usersGridView.DataSource = user.GetAllUsers();
                   frmUsersMng.GetFrmUsersMngTypes.lblMsg.Text = "User edited successfully";
                   //      MessageBox.Show("User Edited successfully", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   this.Close();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            if (type == "Edit")
            {
                clsUser user = new clsUser(id);
                this.txtFName.Text = user.GetUserByID().Rows[0][1].ToString();
                this.txtLName.Text = user.GetUserByID().Rows[0][2].ToString();
                this.txtUsername.Text = user.GetUserByID().Rows[0][3].ToString();
                this.cbActive.Checked = Convert.ToBoolean(user.GetUserByID().Rows[0][5].ToString());
                this.txtPw.Enabled = false;
            }
            else
            {
                this.txtPw.Enabled = true;
            }
        }
    }
}
