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
    class cls3GSim
    {
        private int id;
        private string center;
        private string ip;
        private string simPinCode;
        private string simNumber;
        DLClass dl = new DLClass();

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Center
        {
            get { return this.center; }
            set { this.center = value; }
        }

         public string IP
        {
            get { return this.ip; }
            set { this.ip = value; }
        }
        public string SimPinCode
        {
            get { return this.simPinCode; }
            set { this.simPinCode = value; }
        }

        public string SimNumber
        {
            get { return this.simNumber; }
            set { this.simNumber = value; }
        }

        public cls3GSim()
        {

        }
        public cls3GSim(int id)
        {
            this.ID = id;
        }
        public cls3GSim(string c, string ip, string pin ,string num)
        {
            this.Center = c;
            this.IP = ip;
            this.SimPinCode = pin;
            this.SimNumber = num;
        }

        public cls3GSim(int id, string c, string ip, string pin, string num)
        {
            this.ID = id;
            this.Center = c;
            this.IP = ip;
            this.SimPinCode = pin;
            this.SimNumber = num;
        }

        public void AddSim()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[4];
            parm[0] = new SqlParameter("@ParmCenterName", SqlDbType.NVarChar, 100);
            parm[0].Value = this.Center;

            parm[1] = new SqlParameter("@ParmSimPinCode", SqlDbType.NVarChar, 500);
            parm[1].Value = this.SimPinCode;

            parm[2] = new SqlParameter("@ParmSimNumber", SqlDbType.NVarChar, 500);
            parm[2].Value = this.SimNumber;

            parm[3] = new SqlParameter("@ParmIP", SqlDbType.NVarChar, 100);
            parm[3].Value = this.IP;


            dl.ExecuteCommand("sp_Add3GSim", parm);

            dl.Close();
        }

        public void EditSim()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[5];
            parm[0] = new SqlParameter("@ParmCenterName", SqlDbType.NVarChar, 100);
            parm[0].Value = this.Center;

            parm[1] = new SqlParameter("@ParmSimPinCode", SqlDbType.NVarChar, 500);
            parm[1].Value = this.SimPinCode;

            parm[2] = new SqlParameter("@ParmSimNumber", SqlDbType.NVarChar, 500);
            parm[2].Value = this.SimNumber;

            parm[3] = new SqlParameter("@ParmIP", SqlDbType.NVarChar, 100);
            parm[3].Value = this.IP;

            parm[4] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[4].Value = this.ID;

            dl.ExecuteCommand("sp_Edit3GSim", parm);

            dl.Close();
        }

        public void DeleteSim()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;

            dl.ExecuteCommand("sp_Delete3GSim", parm);
            dl.Close(); 
        }

        public DataTable GetAll()
        {
            dl.Open();
            DataTable dt = dl.SelectData("sp_GetAll3GSims", null);
            dl.Close();
            return dt;
        }
        public DataTable GetAll2()
        {
            dl.Open();
            DataTable dt = dl.SelectData("sp_GetAll3GSims2", null);
            dl.Close();
            return dt;
        }

        public DataTable GetSimCard()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;
            DataTable dt = dl.SelectData("sp_GetSimCard", parm);
            dl.Close();
            return dt;
        }
    }
}
