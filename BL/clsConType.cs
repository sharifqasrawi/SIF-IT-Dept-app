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
    class clsConType
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

        public clsConType()
        {

        }
        public clsConType(int id)
        {
            this.ID = id;

        }
        public clsConType(string type)
        {
            this.Type = type;
        }
        public clsConType(int id, string type)
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

            dl.ExecuteCommand("sp_AddConType", parm);

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

            dl.ExecuteCommand("sp_EditConType", parm);

            dl.Close();
        }

        public void Delete()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;

            dl.ExecuteCommand("sp_DeleteConType", parm);

            dl.Close();
        }

        public DataTable GetAll()
        {
            dl.Open();
            DataTable dt = new DataTable();
            dt = dl.SelectData("sp_GetAllConTypes", null);
            dl.Close();
            return dt;
        }

        public DataTable GetConTypeByID()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;
            DataTable dt = dl.SelectData("sp_GetConTypeByID", parm);
            dl.Close();
            return dt;
        }
    }
}
