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
    class clsConSpeed
    {
        private int id;
        private string speed;
        DLClass dl = new DLClass();

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Speed
        {
            get { return this.speed; }
            set { this.speed = value; }
        }

        public clsConSpeed()
        {

        }
        public clsConSpeed(int id)
        {
            this.ID = id;

        }
        public clsConSpeed(string speed)
        {
            this.Speed = speed;
        }
        public clsConSpeed(int id, string speed)
        {
            this.ID = id;
            this.Speed = speed;
        }

        public void Add()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmSpeed", SqlDbType.NVarChar, 50);
            parm[0].Value = this.Speed;

            dl.ExecuteCommand("sp_AddConSpeed", parm);

            dl.Close();
        }

        public void Edit()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@ParmSpeed", SqlDbType.NVarChar, 50);
            parm[0].Value = this.Speed;

            parm[1] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[1].Value = this.ID;

            dl.ExecuteCommand("sp_EditConSpeed", parm);

            dl.Close();
        }

        public void Delete()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;

            dl.ExecuteCommand("sp_DeleteConSpeed", parm);

            dl.Close();
        }

        public DataTable GetAll()
        {
            dl.Open();
            DataTable dt = new DataTable();
            dt = dl.SelectData("sp_GetAllConSpeeds", null);
            dl.Close();
            return dt;
        }

        public DataTable GetConSpeedByID()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;
            DataTable dt = dl.SelectData("sp_GetConSpeedByID", parm);
            dl.Close();
            return dt;
        }
    }
}
