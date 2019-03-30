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
    class clsSyriatelNumber
    {
        private int id;
        private string emp_name;
        private string syr_num;
        private DateTime date;
        private string limit;
        private bool active;
        private string pinCode;
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

        public string Syr_Num
        {
            get { return this.syr_num; }
            set { this.syr_num = value; }
        }

        public string Limit
        {
            get { return this.limit; }
            set { this.limit = value; }
        }
        public DateTime Date
        {
            get { return this.date; }
            set { this.date = value; }
        }
        public bool Active
        {
            get { return this.active; }
            set { this.active = value; }
        }
        public string PinCode
        {
            get { return this.pinCode; }
            set { this.pinCode = value; }
        }

        public clsSyriatelNumber()
        {

        }

        public clsSyriatelNumber(int id)
        {
            this.ID = id;
        }

        public clsSyriatelNumber(string n, string num, DateTime date, string limit, bool active, string pin)
        {
            this.Emp_Name = n;
            this.Syr_Num = num;
            this.Date = date;
            this.Limit = limit;
            this.Active = active;
            this.PinCode = pin;
        }

        public clsSyriatelNumber(int id, string n, string num, DateTime date, string limit, bool active,string pin)
        {
            this.Emp_Name = n;
            this.Syr_Num = num;
            this.Date = date;
            this.Limit = limit;
            this.Active = active;
            this.PinCode = pin;
            this.ID = id;
        }

        public DataTable GetAll()
        {
            dl.Open();

            DataTable dt = dl.SelectData("sp_GetAllSyrNums", null);

            dl.Close();
            return dt;
        }
        public DataTable GetAll2()
        {
            dl.Open();

            DataTable dt = dl.SelectData("sp_GetAllSyrNums2", null);

            dl.Close();
            return dt;
        }

        public void Add()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[6];
            parm[0] = new SqlParameter("@ParmName", SqlDbType.NVarChar, 500);
            parm[0].Value = this.Emp_Name;

            parm[1] = new SqlParameter("@ParmNumber", SqlDbType.NVarChar, 100);
            parm[1].Value = this.Syr_Num;

            parm[2] = new SqlParameter("@ParmLimit", SqlDbType.NVarChar, 50);
            parm[2].Value = this.Limit;

            parm[3] = new SqlParameter("@ParmDateTime", SqlDbType.DateTime);
            parm[3].Value = this.Date;

            parm[4] = new SqlParameter("@ParmActive", SqlDbType.Bit);
            parm[4].Value = this.Active;

            parm[5] = new SqlParameter("@ParmPinCode", SqlDbType.NVarChar,500);
            parm[5].Value = this.PinCode;

            dl.ExecuteCommand("sp_AddSyrNumber", parm);

            dl.Close();
        }

        public void Edit()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[7];
            parm[0] = new SqlParameter("@ParmName", SqlDbType.NVarChar, 500);
            parm[0].Value = this.Emp_Name;

            parm[1] = new SqlParameter("@ParmNumber", SqlDbType.NVarChar, 100);
            parm[1].Value = this.Syr_Num;

            parm[2] = new SqlParameter("@ParmLimit", SqlDbType.NVarChar, 50);
            parm[2].Value = this.Limit;

            parm[3] = new SqlParameter("@ParmDateTime", SqlDbType.DateTime);
            parm[3].Value = this.Date;

            parm[4] = new SqlParameter("@ParmActive", SqlDbType.Bit);
            parm[4].Value = this.Active;

            parm[5] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[5].Value = this.ID;

            parm[6] = new SqlParameter("@ParmPinCode", SqlDbType.NVarChar, 500);
            parm[6].Value = this.PinCode;

            dl.ExecuteCommand("sp_EditSyrNumber", parm);

            dl.Close();
        }

        public DataTable GetNumberByID()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;
            DataTable dt = dl.SelectData("sp_GetNumberByID", parm);
            dl.Close();
            return dt;
        }

        public void Delete()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;
            dl.ExecuteCommand("sp_DeleteSyrNumber", parm);
            dl.Close();
        }

        public bool IsNumberExists(string num)
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmNum", SqlDbType.NVarChar, 100);
            parm[0].Value = num;
            DataTable dt = dl.SelectData("sp_GetSyrNumByNum", parm);

            dl.Close();

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
