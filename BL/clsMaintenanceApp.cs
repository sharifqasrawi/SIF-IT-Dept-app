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
    class clsMaintenanceApp
    {
        int id;
        int devId;
        string problem;
        DateTime date;
        string notes;
        string status;
        /// <summary>
        /// 
        /// </summary>

        int userId;
        DateTime r_date;
        DateTime f_date;
        string actual_problem;
        string user_notes;
        string current_status;
        int mid;



        DLClass dl = new DLClass();

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public int DevId
        {
            get { return this.devId; }
            set { this.devId = value; }
        }
        public string Problem
        {
            get { return this.problem; }
            set { this.problem = value; }
        }
        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        public string Notes
        {
            get { return this.notes; }
            set { this.notes = value; }
        }

        public DateTime R_Date
        {
            get { return this.r_date; }
            set { this.r_date = value; }
        }

        public DateTime F_Date
        {
            get { return this.f_date; }
            set { this.f_date = value; }
        }

        public string Actual_problem
        {
            get { return this.actual_problem; }
            set { this.actual_problem = value; }
        }

        public string User_notes
        {
            get { return this.user_notes; }
            set { this.user_notes = value; }
        }

        public string Current_status
        {
            get { return this.current_status; }
            set { this.current_status = value; }
        }

        public int MId
        {
            get { return this.mid; }
            set { this.mid = value; }
        }

        /// <summary>
        /// //////////////////////
        /// 
        /// 
        /// </summary>
        /// 

        public int UserId
        {
            get { return this.userId; }
            set { this.userId = value; }
        }

        public clsMaintenanceApp(int uid, DateTime rd,string cs)
        {
            this.UserId = uid;
            this.R_Date = rd;
            this.Current_status = cs;
        }

        public clsMaintenanceApp(int id)
        {
            this.Id = id;
        }

        public clsMaintenanceApp(int did, string p, DateTime d, string n, string s)
        {
            this.DevId = did;
            this.Problem = p;
            this.Date = d;
            this.Notes = n;
            this.status = s;
        }

        public clsMaintenanceApp(int id, int did, string p, DateTime d, string n, string s)
        {
            this.Id = id;
            this.DevId = did;
            this.Problem = p;
            this.Date = d;
            this.Notes = n;
            this.status = s;
        }

        public clsMaintenanceApp(int id, int uid, DateTime rd,DateTime fd, string cs, string p, string n, int mid)
        {
            this.Id = id;
            this.UserId = uid;
            this.R_Date = rd;
            this.F_Date = fd;
            this.Current_status = cs;
            this.Problem = p;
            this.Notes = n;
            this.MId = mid;
        }

        public clsMaintenanceApp()
        {

        }

        public void Start()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[5];

            parm[0] = new SqlParameter("@ParmDevId", SqlDbType.Int);
            parm[0].Value = this.DevId;

            parm[1] = new SqlParameter("@ParmProblem", SqlDbType.NVarChar, 500);
            parm[1].Value = this.Problem;

            parm[2] = new SqlParameter("@ParmDate", SqlDbType.DateTime);
            parm[2].Value = this.Date;

            parm[3] = new SqlParameter("@ParmNotes", SqlDbType.NVarChar, 500);
            parm[3].Value = this.Notes;

            parm[4] = new SqlParameter("@ParmStatus", SqlDbType.NVarChar, 50);
            parm[4].Value = this.status;

            dl.ExecuteCommand("sp_StartMaintenance", parm);


            dl.Close();
        }

        public DataTable GetCurrentMaintenances()
        {
            dl.Open();

            DataTable dt = dl.SelectData("sp_GetCurrentMaintenances", null);

            dl.Close();
            return dt;
        }

        public DataTable GetCurrentMaintenancesById(int id)
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@ParmId", SqlDbType.Int);
            parm[0].Value = id;

            DataTable dt = dl.SelectData("sp_GetCurrentMaintenancesById", parm);

            dl.Close();
            return dt;
        }

        public DataTable GetFinishedMaintenances()
        {
            dl.Open();

            DataTable dt = dl.SelectData("sp_GetFinishedMaintenances", null);

            dl.Close();
            return dt;
        }

        public void UserStartMaintenance(int mid)
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@ParmStatus", SqlDbType.NVarChar, 50);
            parm[0].Value = "Started";

            parm[1] = new SqlParameter("@ParmId", SqlDbType.Int);
            parm[1].Value = mid;

            dl.ExecuteCommand("sp_ChangeMaintenanceStatus", parm);

            SqlParameter[] parm2 = new SqlParameter[4];
            parm2[0] = new SqlParameter("@ParmUID", SqlDbType.Int);
            parm2[0].Value = this.UserId;

            parm2[1] = new SqlParameter("@ParmDate", SqlDbType.DateTime);
            parm2[1].Value = this.R_Date;

            parm2[2] = new SqlParameter("@ParmMID", SqlDbType.Int);
            parm2[2].Value = mid;

            parm2[3] = new SqlParameter("@ParmStatus", SqlDbType.NVarChar, 50);
            parm2[3].Value = this.Current_status;

            dl.ExecuteCommand("sp_UserStartMaintenance", parm2);

            dl.Close();
        }

       


        public DataTable GetUsertMaintenances(int uid)
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmId", SqlDbType.Int);
            parm[0].Value = uid;

            DataTable dt = dl.SelectData("sp_GetUserMaintenances", parm);

            dl.Close();
            return dt;
        }

        public void UserSetMaintenanceProblem(int id, string prob)
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@ParmProblem", SqlDbType.NVarChar, 500);
            parm[0].Value = prob;

            parm[1] = new SqlParameter("@ParmId", SqlDbType.Int);
            parm[1].Value = id;


            dl.ExecuteCommand("sp_UserSetMaintenanceProblem", parm);

            dl.Close();
        }

        public void UserSetMaintenanceNotes(int id, string note)
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@ParmNote", SqlDbType.NVarChar, 500);
            parm[0].Value = note;

            parm[1] = new SqlParameter("@ParmId", SqlDbType.Int);
            parm[1].Value = id;


            dl.ExecuteCommand("sp_UserSetMaintenanceNote", parm);

            dl.Close();
        }

        public void AssignToUser(int FromUserId)
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[9];
            parm[0] = new SqlParameter("@ParmUId", SqlDbType.Int);
            parm[0].Value = this.UserId;

            parm[1] = new SqlParameter("@ParmRDate", SqlDbType.DateTime);
            parm[1].Value = this.R_Date;

            parm[2] = new SqlParameter("@ParmCurrentStatus", SqlDbType.NVarChar, 50);
            parm[2].Value = this.Current_status;

            parm[3] = new SqlParameter("@ParmProblem", SqlDbType.NVarChar, 500);
            parm[3].Value = this.Problem;

            parm[4] = new SqlParameter("@ParmNotes", SqlDbType.NVarChar, 500);
            parm[4].Value = this.Notes;

            parm[5] = new SqlParameter("@ParmMId", SqlDbType.Int);
            parm[5].Value = MId;

            parm[6] = new SqlParameter("@ParmId", SqlDbType.Int);
            parm[6].Value = this.Id;

            parm[7] = new SqlParameter("@ParmFromUserId", SqlDbType.Int);
            parm[7].Value = FromUserId;

            parm[8] = new SqlParameter("@ParmFDate", SqlDbType.DateTime);
            parm[8].Value = this.F_Date;


            dl.ExecuteCommand("sp_AssignToUser", parm);

            dl.Close();
        }

        public DataTable GetUserMaintenanceById()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmId", SqlDbType.Int);
            parm[0].Value = this.Id;

            DataTable dt = dl.SelectData("sp_GetUserMaintenanceById", parm);

            dl.Close();
            return dt;
        }

        public DataTable GetMaintenanceTrackByMId()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmMId", SqlDbType.Int);
            parm[0].Value = this.Id;

            DataTable dt = dl.SelectData("sp_GetMaintenanceTrackByMId", parm);

            dl.Close();
            return dt;
        }

        public void SetCurrentStatus(string s)
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@ParmId", SqlDbType.Int);
            parm[0].Value = this.Id;

            parm[1] = new SqlParameter("@ParmNewStatus", SqlDbType.NVarChar, 50);
            parm[1].Value = s;

            dl.ExecuteCommand("sp_SetCurrentStatus", parm);
            dl.Close();
        }

        public void Accept(DateTime dt,string cs)
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[3];
            parm[0] = new SqlParameter("@ParmId", SqlDbType.Int);
            parm[0].Value = this.Id;

            parm[1] = new SqlParameter("@ParmDate", SqlDbType.DateTime);
            parm[1].Value = dt;

            parm[2] = new SqlParameter("@ParmCurrentStatus", SqlDbType.NVarChar,50);
            parm[2].Value = cs;

            dl.ExecuteCommand("sp_AcceptMaintenance", parm);
            dl.Close();
        }

        public int GetDevCurrentMaintenancesCount(int devId)
        {
            int count = 0;

            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmId", SqlDbType.Int);
            parm[0].Value = devId;

            DataTable dt = dl.SelectData("sp_GetDevCurrentMaintenancesCount", parm);
            count = int.Parse(dt.Rows[0][0].ToString());
            dl.Close();


            return count;
        }

        public int GetDevFinishedMaintenancesCount(int devId)
        {
            int count = 0;

            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmId", SqlDbType.Int);
            parm[0].Value = devId;

            DataTable dt = dl.SelectData("sp_GetDevFinishedMaintenancesCount", parm);
            count = int.Parse(dt.Rows[0][0].ToString());
            dl.Close();


            return count;
        }

        public void CloseMaintenance(string name, DateTime dt)
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[3];
            parm[0] = new SqlParameter("@ParmId", SqlDbType.Int);
            parm[0].Value = this.Id;

            parm[1] = new SqlParameter("@ParmHandToName", SqlDbType.NVarChar, 50);
            parm[1].Value = name;

            parm[2] = new SqlParameter("@ParmDate", SqlDbType.DateTime);
            parm[2].Value = dt;

            dl.ExecuteCommand("sp_CloseMaintenance", parm);

            dl.Close();
        }
        public DataTable GetAllDevMaintenances(int devID)
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmId", SqlDbType.Int);
            parm[0].Value = devID;

            DataTable dt = dl.SelectData("sp_GetAllDevMaintenances", parm);

            dl.Close();
            return dt;
        }

        public int GetCountUserMaintenances(int uid)
        {
            int count = 0;

            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmId", SqlDbType.Int);
            parm[0].Value = uid;

            DataTable dt = dl.SelectData("sp_GetUserMaintenances", parm);

            dl.Close();

            count = dt.Rows.Count;

            return count;
        }
        public int GetCountCurrentMaintenances()
        {
            int count = 0;


            DataTable dt = dl.SelectData("sp_GetCurrentMaintenances", null);

            dl.Close();

            count = dt.Rows.Count;

            return count;
        }

        public int GetCountFinishedMaintenances()
        {
            int count = 0;


            DataTable dt = dl.SelectData("sp_GetFinishedMaintenances", null);

            dl.Close();

            count = dt.Rows.Count;

            return count;
        }
    }
}
