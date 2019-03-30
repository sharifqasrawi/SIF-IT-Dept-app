using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT_Dept.DL;
using System.Data.SqlClient;
using System.Data;

namespace IT_Dept.BL
{
    class clsOutboundRecord
    {
        private int id;
        private DateTime send_date;
        private string description;
        private string destination;
        private DateTime answer_date;
        private string notes;

        DLClass dl = new DLClass();

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public DateTime Send_Date
        {
            get { return this.send_date; }
            set { this.send_date = value; }
        }
        private string Destination
        {
            get { return this.destination; }
            set { this.destination = value; }
        }
        private string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        public DateTime Answer_Date
        {
            get { return this.answer_date; }
            set { this.answer_date = value; }
        }
        private string Notes
        {
            get { return this.notes; }
            set { this.notes = value; }
        }

        public clsOutboundRecord()
        {

        }
        public clsOutboundRecord(int id)
        {
            this.ID = id;
        }
        public clsOutboundRecord(DateTime sd, string dest, string desc, DateTime ad, string n)
        {
            this.Send_Date = sd;
            this.Destination = dest;
            this.Description = desc;
            this.Answer_Date = ad;
            this.Notes = n;
        }
        public clsOutboundRecord(int id, DateTime sd, string dest, string desc, DateTime ad, string n)
        {
            this.ID = id;
            this.Send_Date = sd;
            this.Destination = dest;
            this.Description = desc;
            this.Answer_Date = ad;
            this.Notes = n;
        }

        public void AddRecord()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[5];
            parm[0] = new SqlParameter("@ParmSendDate", SqlDbType.Date);
            parm[0].Value = this.Send_Date;

            parm[1] = new SqlParameter("@ParmDestination", SqlDbType.NVarChar, 1000);
            parm[1].Value = this.Destination;

            parm[2] = new SqlParameter("@ParmDescription", SqlDbType.NVarChar, 2000);
            parm[2].Value = this.Description;

            parm[3] = new SqlParameter("@ParmAnswerDate", SqlDbType.Date);
            parm[3].Value = this.Answer_Date;

            parm[4] = new SqlParameter("@ParmNotes", SqlDbType.NVarChar, 2000);
            parm[4].Value = this.Notes;

            dl.ExecuteCommand("sp_AddOutboundRecord", parm);

            dl.Close();
        }

        public void EditRecord()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[6];
            parm[0] = new SqlParameter("@ParmSendDate", SqlDbType.Date);
            parm[0].Value = this.Send_Date;

            parm[1] = new SqlParameter("@ParmDestination", SqlDbType.NVarChar, 1000);
            parm[1].Value = this.Destination;

            parm[2] = new SqlParameter("@ParmDescription", SqlDbType.NVarChar, 2000);
            parm[2].Value = this.Description;

            parm[3] = new SqlParameter("@ParmAnswerDate", SqlDbType.Date);
            parm[3].Value = this.Answer_Date;

            parm[4] = new SqlParameter("@ParmNotes", SqlDbType.NVarChar, 2000);
            parm[4].Value = this.Notes;

            parm[5] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[5].Value = this.ID;

            dl.ExecuteCommand("sp_EditOutboundRecord", parm);

            dl.Close();
        }

        public void DeleteRecord()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;

            dl.ExecuteCommand("sp_DeleteOutboundRecord", parm);

            dl.Close();
        }

        public DataTable GetAll()
        {
            dl.Open();

            DataTable dt = dl.SelectData("sp_GetALLOutboundRecords", null);

            dl.Close();

            return dt;
        }

        public DataTable GetOutboundRecordByID()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;
            DataTable dt = dl.SelectData("sp_GetOutboundRecordByID", parm);

            dl.Close();

            return dt;
        }
    }
}
