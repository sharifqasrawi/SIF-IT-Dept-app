using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT_Dept.DL;
using System.Data;
using System.Data.SqlClient;

namespace IT_Dept.BL
{
    class clsDayOff
    {
        private int id;
        private string type;
        private string duraion;
        private string fromDay;
        private DateTime fromDate;
        private string toDay;
        private DateTime toDate;
        private string reason;
        private string empName;
        private string job;
        private DateTime issueDate;
        DLClass dl = new DLClass();

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
        public string Duration
        {
            get { return this.duraion; }
            set { this.duraion = value; }
        }
        public string FromDay
        {
            get { return this.fromDay; }
            set { this.fromDay = value; }
        }

        public DateTime  FromDate
        {
            get { return this.fromDate; }
            set { this.fromDate = value; }
        }

        public string ToDay
        {
            get { return this.toDay; }
            set { this.toDay = value; }
        }

        public DateTime ToDate
        {
            get { return this.toDate; }
            set { this.toDate = value; }
        }

        public string Reason
        {
            get { return this.reason; }
            set { this.reason = value; }
        }

        public string EmpName
        {
            get { return this.empName; }
            set { this.empName = value; }
        }

        public string Job
        {
            get { return this.job; }
            set { this.job = value; }
        }

        public DateTime IssueDate
        {
            get { return this.issueDate; }
            set { this.issueDate = value; }
        }

        public clsDayOff()
        {

        }

        public clsDayOff(int id)
        {
            this.ID = id;
        }

        public clsDayOff(string type, string duration, string fromDay, DateTime fromDate, string toDay, DateTime td, string reason, string emp, string job, DateTime idt)
        {
            this.Type = type;
            this.Duration = duration;
            this.FromDay = fromDay;
            this.FromDate = fromDate;
            this.ToDay = toDay;
            this.ToDate = td;
            this.Reason = reason;
            this.EmpName = emp;
            this.Job = job;
            this.IssueDate = idt;
        }

        public clsDayOff(int id, string type, string duration, string fromDay, DateTime fromDate, string toDay, DateTime td, string reason, string emp, string job, DateTime idt)
        {
            this.ID = id;
            this.Type = type;
            this.Duration = duration;
            this.FromDay = fromDay;
            this.FromDate = fromDate;
            this.ToDay = toDay;
            this.ToDate = td;
            this.Reason = reason;
            this.EmpName = emp;
            this.Job = job;
            this.IssueDate = idt;
        }

        public void AddDayOff()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[10];

            parm[0] = new SqlParameter("@ParmType", SqlDbType.NVarChar, 100);
            parm[0].Value = this.Type;

            parm[1] = new SqlParameter("@ParmDuration", SqlDbType.NVarChar, 100);
            parm[1].Value = this.Duration;

            parm[2] = new SqlParameter("@ParmFromDay", SqlDbType.NVarChar, 100);
            parm[2].Value = this.FromDay;

            parm[3] = new SqlParameter("@ParmFromDate", SqlDbType.Date);
            parm[3].Value = this.FromDate;

            parm[4] = new SqlParameter("@ParmToDay", SqlDbType.NVarChar, 100);
            parm[4].Value = this.ToDay;

            parm[5] = new SqlParameter("@ParmToDate", SqlDbType.Date);
            parm[5].Value = this.ToDate;

            parm[6] = new SqlParameter("@ParmReason", SqlDbType.NVarChar, 500);
            parm[6].Value = this.Reason;

            parm[7] = new SqlParameter("@ParmEmp", SqlDbType.NVarChar, 100);
            parm[7].Value = this.EmpName;

            parm[8] = new SqlParameter("@ParmJob", SqlDbType.NVarChar, 100);
            parm[8].Value = this.Job;

            parm[9] = new SqlParameter("@ParmIssueDate", SqlDbType.Date);
            parm[9].Value = this.IssueDate;

            dl.ExecuteCommand("sp_AddDayOff", parm);

            dl.Close();
        }

        public void EditDayOff()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[11];

            parm[0] = new SqlParameter("@ParmType", SqlDbType.NVarChar, 100);
            parm[0].Value = this.Type;

            parm[1] = new SqlParameter("@ParmDuration", SqlDbType.NVarChar, 100);
            parm[1].Value = this.Duration;

            parm[2] = new SqlParameter("@ParmFromDay", SqlDbType.NVarChar, 100);
            parm[2].Value = this.FromDay;

            parm[3] = new SqlParameter("@ParmFromDate", SqlDbType.Date);
            parm[3].Value = this.FromDate;

            parm[4] = new SqlParameter("@ParmToDay", SqlDbType.NVarChar, 100);
            parm[4].Value = this.ToDay;

            parm[5] = new SqlParameter("@ParmToDate", SqlDbType.Date);
            parm[5].Value = this.ToDate;

            parm[6] = new SqlParameter("@ParmReason", SqlDbType.NVarChar, 500);
            parm[6].Value = this.Reason;

            parm[7] = new SqlParameter("@ParmEmp", SqlDbType.NVarChar, 100);
            parm[7].Value = this.EmpName;

            parm[8] = new SqlParameter("@ParmJob", SqlDbType.NVarChar, 100);
            parm[8].Value = this.Job;

            parm[9] = new SqlParameter("@ParmIssueDate", SqlDbType.Date);
            parm[9].Value = this.IssueDate;

            parm[10] = new SqlParameter("@ParmId", SqlDbType.Int);
            parm[10].Value = this.ID;

            dl.ExecuteCommand("sp_EditDayOff", parm);

            dl.Close();
        }

        public void DeleteDayOff()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@ParmId", SqlDbType.Int);
            parm[0].Value = this.ID;

            dl.ExecuteCommand("sp_DeleteDayOff", parm);

            dl.Close();
        }

        public DataTable GetAll()
        {
            dl.Open();

            DataTable dt = dl.SelectData("sp_GetAllDayOffs", null);

            dl.Close();

            return dt;
        }
    }
}
