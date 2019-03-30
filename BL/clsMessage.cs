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
    class clsMessage
    {
        private int id;
        private int sender_id;
        private int rec_id;
        private string text;
        private DateTime datetime;
        private bool isRead;
        DLClass dl = new DLClass();

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public int Sender_ID
        {
            get { return this.sender_id; }
            set { this.sender_id = value; }
        }
        public int Rec_ID
        {
            get { return this.rec_id; }
            set { this.rec_id = value; }
        }

        public string Text
        {
            get { return this.text; }
            set { this.text = HashMessage(value); }
        }
        public DateTime DateTime
        {
            get { return this.datetime; }
            set { this.datetime = value; }
        }
        public bool IsRead
        {
            get { return this.isRead; }
            set { this.isRead = value; }
        }
        public clsMessage()
        {

        }
        public clsMessage(int id)
        {
            this.ID = id;
        }
        public clsMessage(int sender_id, int rec_id, string text, DateTime datetime)
        {
            this.Sender_ID = sender_id;
            this.Rec_ID = rec_id;
            this.Text = text;
            this.DateTime = datetime;
        }

        public void Send()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[4];
            parm[0] = new SqlParameter("@ParmSenderID", SqlDbType.Int);
            parm[0].Value = this.Sender_ID;
            parm[1] = new SqlParameter("@ParmRecID", SqlDbType.Int);
            parm[1].Value = this.Rec_ID;
            parm[2] = new SqlParameter("@ParmText", SqlDbType.NVarChar, 4000);
            parm[2].Value = this.Text;
            parm[3] = new SqlParameter("@ParmDateAndTime", SqlDbType.DateTime);
            parm[3].Value = this.DateTime;

            dl.ExecuteCommand("sp_SendMessage", parm);
            dl.Close();
        }

        public DataTable GetAll(int id)
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = id;
            DataTable dt = dl.SelectData("sp_GetMessages", parm);
            dl.Close();
            return dt;
        }

        public DataTable GetMessageByID()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;
            DataTable dt = dl.SelectData("sp_GetMessageByID", parm);
            dl.Close();
            return dt;
        }

        public void Delete()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;
            dl.ExecuteCommand("sp_DeleteMessage", parm);
            dl.Close();
        }

        public void MarkAsRead()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;
            dl.ExecuteCommand("sp_MarkMsgAsRead", parm);
            dl.Close();
        }
        public int GetMessagesCount(int id)
        {
            dl.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tblMessages WHERE Rec_Id = @ParmID AND IsRead = 0", dl.CN);
            cmd.Parameters.Add("@ParmID", SqlDbType.Int).Value = id;
            int count = 0;
            if (cmd.ExecuteScalar() != null)
                count = int.Parse(cmd.ExecuteScalar().ToString());
            else
                count = 0;

            dl.Close();
            return count;
        }


        public string HashMessage(string msg)
        {
            string hashedMessage = "";
            int i = 0;
            int d = 0;
            char[] c;
            c = msg.ToCharArray();
            for (i = 0; i < c.Length; i++)
            {
                d = (int)c[i];
                d += 37;
                c[i] = (char)d;
            }
            hashedMessage = new string(c);
            return hashedMessage;
        }
        public string UnHashMessage(string msg)
        {
            string hashedMessage = "";
            int i = 0;
            int d = 0;
            char[] c;
            c = msg.ToCharArray();
            for (i = 0; i < c.Length; i++)
            {
                d = (int)c[i];
                d -= 37;
                c[i] = (char)d;
            }
            hashedMessage = new string(c);
            return hashedMessage;
        }
    }
}
