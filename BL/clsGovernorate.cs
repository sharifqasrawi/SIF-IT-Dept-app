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
    class clsGovernorate
    {
        private int id;
        private string name;
        private int area_id;
        DLClass dl = new DLClass();

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Area_ID
        {
            get { return this.area_id; }
            set { this.area_id = value; }
        }

        public clsGovernorate() { }

        public clsGovernorate(int id)
        {
            this.ID = id;
        }

        public clsGovernorate(string name , int area_id)
        {
            this.Name = name;
            this.Area_ID = area_id;
        }

        public clsGovernorate(int id, string name, int area_id)
        {
            this.ID = id;
            this.Name = name;
            this.Area_ID = area_id;
        }

        public void Add()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@ParmName", SqlDbType.NVarChar, 50);
            parm[0].Value = this.Name;

            parm[1] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[1].Value = this.Area_ID;

            dl.ExecuteCommand("sp_AddGovernorate", parm);

            dl.Close();
        }

        public void Edit()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[3];
            parm[0] = new SqlParameter("@ParmName", SqlDbType.NVarChar, 50);
            parm[0].Value = this.Name;

            parm[1] = new SqlParameter("@ParmAreaID", SqlDbType.Int);
            parm[1].Value = this.Area_ID;

            parm[2] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[2].Value = this.ID;

            dl.ExecuteCommand("sp_EditGovernorate", parm);

            dl.Close();
        }

        public void Delete()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;

            dl.ExecuteCommand("sp_DeleteGovernorate", parm);

            dl.Close();
        }

        public DataTable GetAll()
        {
            dl.Open();
            DataTable dt = dl.SelectData("sp_GetAllGovernorates", null);
            dl.Close();
            return dt;
        }

        public DataTable GetGovByID()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;
            DataTable dt = dl.SelectData("sp_GetGovByID", parm);

            dl.Close();
            return dt;
        }

        

    }
}
