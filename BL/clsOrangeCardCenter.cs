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
    class clsOrangeCardCenter
    {
        private int id;
        private int center_id;
        private string center_code;
        private string center_db;
        DLClass dl = new DLClass();

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public int Center_ID
        {
            get { return this.center_id; }
            set { this.center_id = value; }
        }

        public string Center_Code
        {
            get { return this.center_code; }
            set { this.center_code = value; }
        }
        public string Center_DB
        {
            get { return this.center_db; }
            set { this.center_db = value; }
        }

        public clsOrangeCardCenter()
        {

        }
        public clsOrangeCardCenter(int id)
        {
            this.ID = id;
        }
        public clsOrangeCardCenter(int cid, string code, string db)
        {
            this.Center_ID = cid;
            this.Center_Code = code;
            this.Center_DB = db;
        }
        public clsOrangeCardCenter(int id, int cid, string code, string db)
        {
            this.ID = id;
            this.Center_ID = cid;
            this.Center_Code = code;
            this.Center_DB = db;
        }

        public void Add()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[3];
            parm[0] = new SqlParameter("@ParmCenterID", SqlDbType.Int);
            parm[0].Value = this.Center_ID;

            parm[1] = new SqlParameter("@ParmCenterCode", SqlDbType.NVarChar, 50);
            parm[1].Value = this.Center_Code;

            parm[2] = new SqlParameter("@ParmCenterDB", SqlDbType.NVarChar, 50);
            parm[2].Value = this.Center_DB;

            dl.ExecuteCommand("sp_AddOrangeCardCenter", parm);

            dl.Close();
        }
        public void Edit()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[4];
            parm[0] = new SqlParameter("@ParmCenterID", SqlDbType.Int);
            parm[0].Value = this.Center_ID;

            parm[1] = new SqlParameter("@ParmCenterCode", SqlDbType.NVarChar, 50);
            parm[1].Value = this.Center_Code;

            parm[2] = new SqlParameter("@ParmCenterDB", SqlDbType.NVarChar, 50);
            parm[2].Value = this.Center_DB;

            parm[3] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[3].Value = this.ID;

            dl.ExecuteCommand("sp_EditOrangeCardCenter", parm);

            dl.Close();
        }

        public void Delete()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;

            dl.ExecuteCommand("sp_DeleteOrangeCardCenter", parm);

            dl.Close();
        }

        public DataTable GetAll()
        {
            dl.Open();
            DataTable dt =  dl.SelectData("sp_GetAllOrangeCardCenters", null);

            dl.Close();
            return dt;
        }

        public DataTable GetOrangeCenterByID()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;
            DataTable dt = dl.SelectData("sp_GetOrangeCardCenterByID", parm);

            dl.Close();
            return dt;
        }
    }
}
