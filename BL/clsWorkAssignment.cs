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
    class clsWorkAssignment
    {
        private int id;
        private string emp_name;
        private string job_desc;
        private string assignment;
        private string ass_desc;
        private DateTime fromHour;
        private DateTime toHour;
        private string day;
        private DateTime date;
        private DateTime issueDate;
        private string boss;
        DLClass dl = new DLClass();

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Emp_Name
        {
            get { return this.emp_name; }
            set { this.emp_name = value; }
        }
        public string Job_Desc
        {
            get { return this.job_desc; }
            set { this.job_desc = value; }
        }
        public string Ass_Desc
        {
            get { return this.ass_desc; }
            set { this.ass_desc = value; }
        }

        public string Assignment
        {
            get { return this.assignment; }
            set { this.assignment = value; }
        }

        public string Day
        {
            get { return this.day; }
            set { this.day = value; }
        }

        public DateTime FromHour
        {
            get { return this.fromHour; }
            set { this.fromHour = value; }
        }
        public DateTime ToHour
        {
            get { return this.toHour; }
            set { this.toHour = value; }
        }

        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public DateTime IssueDate
        {
            get { return this.issueDate; }
            set { this.issueDate = value; }
        }

        public string Boss
        {
            get { return this.boss; }
            set { this.boss = value; }
        }

        public clsWorkAssignment()
        {

        }
        public clsWorkAssignment(int id)
        {
            this.ID = id;
        }

        public clsWorkAssignment(string emp,string job, string ass, string assDesc, string day, DateTime from, DateTime to,DateTime dt, DateTime issd,string boss)
        {
            this.Emp_Name = emp;
            this.Job_Desc = job;
            this.Assignment = ass;
            this.Ass_Desc = assDesc;
            this.Day = day;
            this.FromHour = from;
            this.ToHour = to;
            this.Date = dt;
            this.IssueDate = issd;
            this.Boss = boss;
        }
        public clsWorkAssignment(int id, string emp, string job, string ass, string assDesc, string day, DateTime from, DateTime to, DateTime dt, DateTime issd, string boss)
        {
            this.ID = id;
            this.Emp_Name = emp;
            this.Job_Desc = job;
            this.Assignment = ass;
            this.Ass_Desc = assDesc;
            this.Day = day;
            this.FromHour = from;
            this.ToHour = to;
            this.Date = dt;
            this.IssueDate = issd;
            this.Boss = boss;
        }

        public void Add()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[10];
            parm[0] = new SqlParameter("@ParmEmpName", SqlDbType.NVarChar, 100);
            parm[0].Value = this.Emp_Name;

            parm[1] = new SqlParameter("@ParmJobDesc", SqlDbType.NVarChar, 300);
            parm[1].Value = this.Job_Desc;

            parm[2] = new SqlParameter("@ParmAssignment", SqlDbType.NVarChar, 300);
            parm[2].Value = this.Assignment;

            parm[3] = new SqlParameter("@ParmAssDesc", SqlDbType.NVarChar, 4000);
            parm[3].Value = this.Ass_Desc;

            parm[4] = new SqlParameter("@ParmDay", SqlDbType.NVarChar, 50);
            parm[4].Value = this.Day;

            parm[5] = new SqlParameter("@ParmFromHour", SqlDbType.DateTime);
            parm[5].Value = this.FromHour;

            parm[6] = new SqlParameter("@ParmToHour", SqlDbType.DateTime);
            parm[6].Value = this.ToHour;


            parm[7] = new SqlParameter("@ParmDate", SqlDbType.DateTime);
            parm[7].Value = this.Date;


            parm[8] = new SqlParameter("@ParmIssueDate", SqlDbType.DateTime);
            parm[8].Value = this.IssueDate;

            parm[9] = new SqlParameter("@ParmBoss", SqlDbType.NVarChar, 100);
            parm[9].Value = this.Boss;

            dl.ExecuteCommand("sp_AddWorkAssignment", parm);

            dl.Close();
        }

        public void Edit()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[11];

            parm[0] = new SqlParameter("@ParmEmpName", SqlDbType.NVarChar, 100);
            parm[0].Value = this.Emp_Name;

            parm[1] = new SqlParameter("@ParmJobDesc", SqlDbType.NVarChar, 300);
            parm[1].Value = this.Job_Desc;

            parm[2] = new SqlParameter("@ParmAssignment", SqlDbType.NVarChar, 300);
            parm[2].Value = this.Assignment;

            parm[3] = new SqlParameter("@ParmAssDesc", SqlDbType.NVarChar, 4000);
            parm[3].Value = this.Ass_Desc;

            parm[4] = new SqlParameter("@ParmDay", SqlDbType.NVarChar, 50);
            parm[4].Value = this.Day;

            parm[5] = new SqlParameter("@ParmFromHour", SqlDbType.DateTime);
            parm[5].Value = this.FromHour;

            parm[6] = new SqlParameter("@ParmToHour", SqlDbType.DateTime);
            parm[6].Value = this.ToHour;


            parm[7] = new SqlParameter("@ParmDate", SqlDbType.DateTime);
            parm[7].Value = this.Date;


            parm[8] = new SqlParameter("@ParmIssueDate", SqlDbType.DateTime);
            parm[8].Value = this.IssueDate;

            parm[9] = new SqlParameter("@ParmBoss", SqlDbType.NVarChar, 100);
            parm[9].Value = this.Boss;


            parm[10] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[10].Value = this.ID;

           
            dl.ExecuteCommand("sp_EditWorkAssignment", parm);

            dl.Close();
        }

        public void Delete()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;

            dl.ExecuteCommand("sp_DeleteWorkAssignment", parm);

            dl.Close();
        }

        public DataTable GetAll()
        {
            dl.Open();

            DataTable dt = dl.SelectData("sp_GetAllWorkAssignments", null);
            dl.Close();

            return dt;
        }

        public DataTable GetWorkAssignmentByID()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;
            DataTable dt = dl.SelectData("sp_GetWorkAssignmentByID", parm);
            dl.Close();

            return dt;
        }
    }
}
