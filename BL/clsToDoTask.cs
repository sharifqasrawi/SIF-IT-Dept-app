using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using IT_Dept.DL;

namespace IT_Dept.BL
{
    class clsToDoTask
    {
        private int id;
        private string task;
        private DateTime dateAndTime;
        private bool done;
        private int user_id;
        private bool remind_me;
        DLClass dl = new DLClass();

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Task
        {
            get { return this.task; }
            set { this.task = value; }
        }
        public DateTime DateAndTime
        {
            get { return this.dateAndTime; }
            set { this.dateAndTime = value; }
        }
        public bool Done
        {
            get { return this.done; }
            set { this.done = value; }
        }

        public int User_ID
        {
            get { return this.user_id; }
            set { this.user_id = value; }
        }
        public bool Remind_Me
        {
            get { return this.remind_me; }
            set { this.remind_me = value; }
        }

        public clsToDoTask() { }

        public clsToDoTask(int id)
        {
            this.ID = id;
        }
        public clsToDoTask(string task, DateTime dt,bool r)
        {
            this.Task = task;
            this.DateAndTime = dt;
            this.Remind_Me = r;
        }
        public clsToDoTask(int id, string task, DateTime dt, bool r)
        {
            this.ID = id;
            this.Task = task;
            this.DateAndTime = dt;
            this.Remind_Me = r;
        }

        public DataTable GetAll(int id)
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmUserID", SqlDbType.Int);
            parm[0].Value = id;
            DataTable dt = dl.SelectData("sp_GetAllToDoTasks", parm);
            dl.Close();
            return dt;
        }

        public DataTable GetAllUndoneTasks(int id)
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmUserID", SqlDbType.Int);
            parm[0].Value = id;
            DataTable dt = dl.SelectData("sp_GetAllUndoneTasks", parm);
            dl.Close();
            return dt;
        }

        public void AddTask(int id)
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[4];
            parm[0] = new SqlParameter("@ParmTask", SqlDbType.NVarChar, 4000);
            parm[0].Value = this.Task;
            parm[1] = new SqlParameter("@ParmDateTime", SqlDbType.DateTime);
            parm[1].Value = this.DateAndTime;
            parm[2] = new SqlParameter("@ParmUserID", SqlDbType.Int);
            parm[2].Value = id;
            parm[3] = new SqlParameter("@ParmRemindMe", SqlDbType.Bit);
            parm[3].Value = this.Remind_Me;
            dl.ExecuteCommand("sp_AddToDoTask", parm);
            dl.Close();
        }

        public void EditTask()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[4];
            parm[0] = new SqlParameter("@ParmTask", SqlDbType.NVarChar, 4000);
            parm[0].Value = this.Task;
            parm[1] = new SqlParameter("@ParmDateTime", SqlDbType.DateTime);
            parm[1].Value = this.DateAndTime;
            parm[2] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[2].Value = this.ID;
            parm[3] = new SqlParameter("@ParmRemindMe", SqlDbType.Bit);
            parm[3].Value = this.Remind_Me;
            dl.ExecuteCommand("sp_EditToDoTask", parm);
            dl.Close();
        }

        public void DeleteTask()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;
            dl.ExecuteCommand("sp_DeleteToDoTask", parm);
            dl.Close();
        }

        public void MarkAsDone(bool status)
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;
            parm[1] = new SqlParameter("@ParmDone", SqlDbType.Bit);
            parm[1].Value = status;
            dl.ExecuteCommand("sp_MarkTaskAsDone", parm);
            dl.Close();
        }

        public DataTable GetTaskByID()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;
            DataTable dt = dl.SelectData("sp_GetToDoTaskByID", parm);
            dl.Close();
            return dt;
        }
    }
}
