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
    class clsDoneTask
    {
        private int id;
        private string text;
        private string notes;
        private DateTime datetime;
        private int user_id;
        DLClass dl = new DLClass();

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Text
        {
            get { return this.text; }
            set { this.text = value; }
        }

        public string Notes
        {
            get { return this.notes; }
            set { this.notes = value; }
        }

        public DateTime DateTime
        {
            get { return this.datetime; }
            set { this.datetime = value; }
        }

        public int User_ID
        {
            get { return this.user_id; }
            set { this.user_id = value; }
        }


        public clsDoneTask() { }
        public clsDoneTask(int id) { this.ID = id; }

        public clsDoneTask(string text, string notes, DateTime date, int user_id) 
        {
            this.Text = text;
            this.Notes = notes;
            this.DateTime = date;
            this.User_ID = user_id;
        }

        public clsDoneTask(int id, string text, string notes)
        {
            this.ID = id;
            this.Text = text;
            this.Notes = notes;

        }

        public void AddTask()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[4];
            parm[0] = new SqlParameter("@ParmText", SqlDbType.NVarChar, 4000);
            parm[0].Value = this.Text;

            parm[1] = new SqlParameter("@ParmNotes", SqlDbType.NVarChar, 1000);
            parm[1].Value = this.Notes;

            parm[2] = new SqlParameter("@ParmDateTime", SqlDbType.DateTime);
            parm[2].Value = this.DateTime;

            parm[3] = new SqlParameter("@ParmUserID", SqlDbType.Int);
            parm[3].Value = this.User_ID;

            dl.ExecuteCommand("sp_AddDoneTask", parm);

            dl.Close();
        }

        public void EditTask()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[3];
            parm[0] = new SqlParameter("@ParmText", SqlDbType.NVarChar, 4000);
            parm[0].Value = this.Text;

            parm[1] = new SqlParameter("@ParmNotes", SqlDbType.NVarChar, 1000);
            parm[1].Value = this.Notes;

            parm[2] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[2].Value = this.ID;

            dl.ExecuteCommand("sp_EditDoneTask", parm);

            dl.Close();
        }

        public void DeleteTask()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;

            dl.ExecuteCommand("sp_DeleteDoneTask", parm);

            dl.Close();
        }

        public DataTable GetUserDoneTasks(int userID)
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@ParmUserID", SqlDbType.Int);
            parm[0].Value = userID;

            DataTable dt = dl.SelectData("sp_GetUserDoneTasks", parm);
            dl.Close();

            return dt;
        }

        public DataTable GetUserDoneTasks()
        {
            dl.Open();

            DataTable dt = dl.SelectData("sp_GetAllDoneTasks",null);
            dl.Close();

            return dt;
        }

        public DataTable GetUserDoneTasksByID()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;

            DataTable dt = dl.SelectData("sp_GetDoneTaskByID", parm);
            dl.Close();

            return dt;
        }

    }
}
