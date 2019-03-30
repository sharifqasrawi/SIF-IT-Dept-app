using IT_Dept.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Dept.BL
{
    class clsGateType
    {
             private int id;
        private string type;
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

        public clsGateType()
        {

        }
        public clsGateType(int id)
        {
            this.ID = id;

        }
        public clsGateType(string type)
        {
            this.Type = type;
        }
        public clsGateType(int id, string type)
        {
            this.ID = id;
            this.Type = type;
        }

        public void Add()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmType", SqlDbType.NVarChar, 50);
            parm[0].Value = this.Type;

            dl.ExecuteCommand("sp_AddGateType", parm);

            dl.Close();
        }

        public void Edit()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@ParmType", SqlDbType.NVarChar, 50);
            parm[0].Value = this.Type;

            parm[1] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[1].Value = this.ID;

            dl.ExecuteCommand("sp_EditGateType", parm);

            dl.Close();
        }

        public void Delete()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;

            dl.ExecuteCommand("sp_DeleteGateType", parm);

            dl.Close();
        }

        public DataTable GetAll()
        {
            dl.Open();
            DataTable dt = new DataTable();
            dt = dl.SelectData("sp_GetAllGateTypes", null);
            dl.Close();
            return dt;
        }

        public DataTable GetGateTypeByID()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;
            DataTable dt = dl.SelectData("sp_GetGateTypeByID", parm);
            dl.Close();
            return dt;
        }
    }
}
