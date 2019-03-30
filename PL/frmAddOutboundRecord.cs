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
    public partial class frmAddOutboundRecord : Telerik.WinControls.UI.RadForm
    {
        public string type = "";
        int id = 0;
        public frmAddOutboundRecord()
        {
            InitializeComponent();
        }
        public frmAddOutboundRecord(int id )
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
                clsOutboundRecord or = new clsOutboundRecord(radDateTimePickerSendDate.Value, txtDest.Text, txtDesc.Text, radDateTimePickerAnswerDate.Value, txtNotes.Text);
                or.AddRecord();
                frmOutboundRecord.GetFrmOutboundRecords.RecordsGridView.DataSource = or.GetAll();
                frmOutboundRecord.GetFrmOutboundRecords.lblMsg.Text = "Record added successfully";
                this.Close();
            }
            else if (type == "Edit")
            {
                clsOutboundRecord or = new clsOutboundRecord(id, radDateTimePickerSendDate.Value, txtDest.Text, txtDesc.Text, radDateTimePickerAnswerDate.Value, txtNotes.Text);
                or.EditRecord();
                frmOutboundRecord.GetFrmOutboundRecords.RecordsGridView.DataSource = or.GetAll();
                frmOutboundRecord.GetFrmOutboundRecords.lblMsg.Text = "Record edited successfully";
                this.Close();
            }
        }

        private void frmAddOutboundRecord_Load(object sender, EventArgs e)
        {
            if (type == "Edit")
            {
                clsOutboundRecord or = new clsOutboundRecord(id);
                this.radDateTimePickerSendDate.Value = Convert.ToDateTime(or.GetOutboundRecordByID().Rows[0][1]);
                this.txtDest.Text = or.GetOutboundRecordByID().Rows[0][2].ToString();
                this.txtDesc.Text = or.GetOutboundRecordByID().Rows[0][3].ToString();
                this.radDateTimePickerAnswerDate.Value = Convert.ToDateTime(or.GetOutboundRecordByID().Rows[0][4]);
                txtNotes.Text = or.GetOutboundRecordByID().Rows[0][5].ToString();
            }
        }
    }
}
