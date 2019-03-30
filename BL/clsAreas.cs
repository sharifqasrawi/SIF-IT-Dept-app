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
    class clsArea
    {
        private int id;
        private string name;
        private string area_manager;
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

        public string Area_Manager
        {
            get { return this.area_manager; }
            set { this.area_manager = value; }
        }

        public clsArea() { }

        public clsArea(int id) 
        {
            this.ID = id;
        }
        public clsArea(int id,string name, string area_manager)
        {
            this.ID = id;
            this.Name = name;
            this.Area_Manager = area_manager;
        }

        public clsArea(string name, string area_manager)
        {
            this.Name = name;
            this.Area_Manager = area_manager;
        }

        public void Add()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@ParmName", SqlDbType.NVarChar, 50);
            parm[0].Value = this.Name;
            parm[1] = new SqlParameter("@ParmAreaManager", SqlDbType.NVarChar, 50);
            parm[1].Value = this.Area_Manager;

            dl.ExecuteCommand("sp_AddArea", parm);

            dl.Close();
        }

        public void Edit()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[3];
            parm[0] = new SqlParameter("@ParmName", SqlDbType.NVarChar, 50);
            parm[0].Value = this.Name;
            parm[1] = new SqlParameter("@ParmAreaManager", SqlDbType.NVarChar, 50);
            parm[1].Value = this.Area_Manager;
            parm[2] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[2].Value = this.ID;

            dl.ExecuteCommand("sp_EditArea", parm);

            dl.Close();
        }

        public void Delete()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];
          
            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;

            dl.ExecuteCommand("sp_DeleteArea", parm);

            dl.Close();
        }

        public DataTable GetAll()
        {
            dl.Open();
            DataTable dt = new DataTable();
            dt = dl.SelectData("sp_GetAllAreas", null);
            dl.Close();

            return dt;
        }

        public DataTable GetAreaByID()
        {
            dl.Open();
            DataTable dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;
            dt = dl.SelectData("sp_GetAreaByID", parm);
            dl.Close();

            return dt;
        }

        public DataTable GetAreaIDByName(string name)
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmName", SqlDbType.NVarChar, 50);
            parm[0].Value = name;
            DataTable dt = dl.SelectData("sp_GetAreaIDByName", parm);

            dl.Close();
            return dt;
        }
    }
}
