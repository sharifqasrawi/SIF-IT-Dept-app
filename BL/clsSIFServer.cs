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
    class clsSIFServer
    {
        private int id;
        private string name;
        private string ip;
        private string brand;
        private string model;
        private string ram;

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
        public string IP
        {
            get { return this.ip; }
            set { this.ip = value; }
        }
        public string Brand
        {
            get { return this.brand; }
            set { this.brand = value; }
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public string Ram
        {
            get { return this.ram; }
            set { this.ram = value; }
        }

        public clsSIFServer()
        {

        }

        public clsSIFServer(int id)
        {
            this.ID = id;
        }
        public clsSIFServer(string name, string ip, string brand,string model,string ram)
        {
            this.Name = name;
            this.IP = ip;
            this.Brand = brand;
            this.Model = model;
            this.Ram = ram;
        }
        public clsSIFServer(int id, string name, string ip, string brand, string model, string ram)
        {
            this.ID = id;
            this.Name = name;
            this.IP = ip;
            this.Brand = brand;
            this.Model = model;
            this.Ram = ram;
        }

        public void Add()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[5];
            parm[0] = new SqlParameter("@ParmName", SqlDbType.NVarChar, 100);
            parm[0].Value = this.Name;
            parm[1] = new SqlParameter("@ParmIP", SqlDbType.NVarChar, 100);
            parm[1].Value = this.IP;
            parm[2] = new SqlParameter("@ParmServerBrand", SqlDbType.NVarChar, 50);
            parm[2].Value = this.Brand;
            parm[3] = new SqlParameter("@ParmServerModel", SqlDbType.NVarChar, 250);
            parm[3].Value = this.Model;
            parm[4] = new SqlParameter("@ParmRamCapacity", SqlDbType.NVarChar, 50);
            parm[4].Value = this.Ram;
            dl.ExecuteCommand("sp_AddSIFServer", parm);

            dl.Close();
        }

        public void Edit()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[6];
            parm[0] = new SqlParameter("@ParmName", SqlDbType.NVarChar, 100);
            parm[0].Value = this.Name;
            parm[1] = new SqlParameter("@ParmIP", SqlDbType.NVarChar, 100);
            parm[1].Value = this.IP;
            parm[2] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[2].Value = this.ID;
            parm[3] = new SqlParameter("@ParmServerBrand", SqlDbType.NVarChar, 50);
            parm[3].Value = this.Brand;
            parm[4] = new SqlParameter("@ParmServerModel", SqlDbType.NVarChar, 250);
            parm[4].Value = this.Model;
            parm[5] = new SqlParameter("@ParmRamCapacity", SqlDbType.NVarChar, 50);
            parm[5].Value = this.Ram;
            dl.ExecuteCommand("sp_EditSIFServer", parm);

            dl.Close();
        }

        public void Delete()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;
            dl.ExecuteCommand("sp_DeleteSIFServer", parm);

            dl.Close();
        }

        public DataTable GetSIFServerByID()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;
            DataTable dt = dl.SelectData("sp_GetSIFServerByID", parm);

            dl.Close();
            return dt;
        }

        public DataTable GetAll()
        {
            dl.Open();
            DataTable dt = dl.SelectData("sp_GetAllSIFServers", null);
            dl.Close();
            return dt;
        }
    }
}
