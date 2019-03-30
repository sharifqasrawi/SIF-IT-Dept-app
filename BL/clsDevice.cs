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
    class clsDevice
    {
        int id;
        string brand;
        string model;
        string serial;
        int centerId;
        string notes;

        DLClass dl = new DLClass();

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
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

        public string Serial
        {
            get { return this.serial; }
            set { this.serial = value; }
        }
        public int CenterId
        {
            get { return this.centerId; }
            set { this.centerId = value; }
        }

        public string Notes
        {
            get { return this.notes; }
            set { this.notes = value; }
        }

        public clsDevice()
        {

        }
        public clsDevice(int id)
        {
            this.Id = id;
        }

        public clsDevice(string b, string m, string s, int cid, string n)
        {
            this.Brand = b;
            this.Model = m;
            this.Serial = s;
            this.CenterId = cid;
            this.Notes = n;
        }

        public clsDevice(int id, string b, string m, string s, int cid, string n)
        {
            this.Id = id;
            this.Brand = b;
            this.Model = m;
            this.Serial = s;
            this.CenterId = cid;
            this.Notes = n;
        }

        public void Add()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[5];

            parm[0] = new SqlParameter("@ParmBrand", SqlDbType.NVarChar, 250);
            parm[0].Value = this.Brand;

            parm[1] = new SqlParameter("@ParmModel", SqlDbType.NVarChar, 250);
            parm[1].Value = this.Model;

            parm[2] = new SqlParameter("@ParmSerial", SqlDbType.NVarChar, 250);
            parm[2].Value = this.Serial;

            parm[3] = new SqlParameter("@ParmCenterId", SqlDbType.Int);
            parm[3].Value = this.CenterId;

            parm[4] = new SqlParameter("@ParmNotes", SqlDbType.NVarChar, 100);
            parm[4].Value = this.Notes;

            dl.ExecuteCommand("sp_AddDevice", parm);

            dl.Close();
        }

        public void Edit()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[6];

            parm[0] = new SqlParameter("@ParmBrand", SqlDbType.NVarChar, 250);
            parm[0].Value = this.Brand;

            parm[1] = new SqlParameter("@ParmModel", SqlDbType.NVarChar, 250);
            parm[1].Value = this.Model;

            parm[2] = new SqlParameter("@ParmSerial", SqlDbType.NVarChar, 250);
            parm[2].Value = this.Serial;

            parm[3] = new SqlParameter("@ParmCenterId", SqlDbType.Int);
            parm[3].Value = this.CenterId;

            parm[4] = new SqlParameter("@ParmNotes", SqlDbType.NVarChar, 100);
            parm[4].Value = this.Notes;

            parm[5] = new SqlParameter("@ParmId", SqlDbType.Int);
            parm[5].Value = this.Id;

            dl.ExecuteCommand("sp_EditDevice", parm);

            dl.Close();
        }

        public void Delete()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@ParmId", SqlDbType.Int);
            parm[0].Value = this.Id;

            dl.ExecuteCommand("sp_DeleteDevice", parm);

            dl.Close();
        }

        public DataTable GetAll()
        {
            dl.Open();

            DataTable dt = dl.SelectData("sp_GetAllDevices", null);

            dl.Close();
            return dt;
        }

        public DataTable GetById()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@ParmId", SqlDbType.Int);
            parm[0].Value = this.Id;

            DataTable dt = dl.SelectData("sp_DeviceById", parm);

            dl.Close();
            return dt;
        }

        public bool IsDeviceExitst(string s)
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmSerial",SqlDbType.NVarChar,250);
            parm[0].Value = s;

            DataTable dt = dl.SelectData("sp_GetDeviceBySerial", parm);

            dl.Close();
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
