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
    class clsMaintenance
    {
        private int id;
        private string name;
        private string serial;
        private string model;
        private string source;
        private DateTime receiveDate;
        private string emp;
        private string problem;
        private string returnTo;
        private DateTime returnDate;

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

        public string Serial
        {
            get { return this.serial; }
            set { this.serial = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Source
        {
            get { return this.source; }
            set { this.source = value; }
        }

        public string Emp
        {
            get { return this.emp; }
            set { this.emp = value; }
        }

        public string Problem
        {
            get { return this.problem; }
            set { this.problem = value; }
        }

        public string ReturnTo
        {
            get { return this.returnTo; }
            set { this.returnTo = value; }
        }

        public DateTime ReceiveDate
        {
            get { return this.receiveDate; }
            set { this.receiveDate = value; }
        }

        public DateTime ReturnDate
        {
            get { return this.returnDate; }
            set { this.returnDate = value; }
        }

        public clsMaintenance()
        {

        }

        public clsMaintenance(int id)
        {
            this.ID = id;
        }

        public clsMaintenance(string name, string serial, string model, string source, DateTime receiveDate, string emp, string problem, string returnTo, DateTime returnDate)
        {
            this.Name = name;
            this.Serial = serial;
            this.Model = model;
            this.Source = source;
            this.ReceiveDate = receiveDate;
            this.Emp = emp;
            this.Problem = problem;
            this.ReturnTo = returnTo;
            this.ReturnDate = returnDate;
        }

        public clsMaintenance(int id, string name, string serial, string model, string source, DateTime receiveDate, string emp, string problem, string returnTo, DateTime returnDate)
        {
            this.ID = id;
            this.Name = name;
            this.Serial = serial;
            this.Model = model;
            this.Source = source;
            this.ReceiveDate = receiveDate;
            this.Emp = emp;
            this.Problem = problem;
            this.ReturnTo = returnTo;
            this.ReturnDate = returnDate;
        }

        public clsMaintenance(int id, string name, string serial, string model, string source, DateTime receiveDate, string emp, string problem)
        {
            this.ID = id;
            this.Name = name;
            this.Serial = serial;
            this.Model = model;
            this.Source = source;
            this.ReceiveDate = receiveDate;
            this.Emp = emp;
            this.Problem = problem;

        }

        public clsMaintenance(int id, string returnTo, DateTime returnDate)
        {
            this.ID = id;
            this.ReturnTo = returnTo;
            this.ReturnDate = returnDate;
        }

        public void AddMaintenance()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[9];

            parm[0] = new SqlParameter("@ParmName", SqlDbType.NVarChar, 250);
            parm[0].Value = this.Name;

            parm[1] = new SqlParameter("@ParmSerial", SqlDbType.NVarChar, 250);
            parm[1].Value = this.Serial;

            parm[2] = new SqlParameter("@ParmModel", SqlDbType.NVarChar, 250);
            parm[2].Value = this.Model;

            parm[3] = new SqlParameter("@ParmSource", SqlDbType.NVarChar, 250);
            parm[3].Value = this.Source;

            parm[4] = new SqlParameter("@ParmReceiveDate", SqlDbType.Date);
            parm[4].Value = this.ReceiveDate;

            parm[5] = new SqlParameter("@ParmEmp", SqlDbType.NVarChar, 250);
            parm[5].Value = this.Emp;

            parm[6] = new SqlParameter("@ParmProblem", SqlDbType.NVarChar, 500);
            parm[6].Value = this.Problem;

            parm[7] = new SqlParameter("@ParmReturnTo", SqlDbType.NVarChar, 250);
            parm[7].Value = this.ReturnTo;

            parm[8] = new SqlParameter("@ParmReturnDate", SqlDbType.Date);
            parm[8].Value = this.ReturnDate;

            dl.ExecuteCommand("sp_AddMaintenance", parm);

            dl.Close();
        }

        public void EditMaintenance()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[8];

            parm[0] = new SqlParameter("@ParmName", SqlDbType.NVarChar, 250);
            parm[0].Value = this.Name;

            parm[1] = new SqlParameter("@ParmSerial", SqlDbType.NVarChar, 250);
            parm[1].Value = this.Serial;

            parm[2] = new SqlParameter("@ParmModel", SqlDbType.NVarChar, 250);
            parm[2].Value = this.Model;

            parm[3] = new SqlParameter("@ParmSource", SqlDbType.NVarChar, 250);
            parm[3].Value = this.Source;

            parm[4] = new SqlParameter("@ParmReceiveDate", SqlDbType.Date);
            parm[4].Value = this.ReceiveDate;

            parm[5] = new SqlParameter("@ParmEmp", SqlDbType.NVarChar, 250);
            parm[5].Value = this.Emp;

            parm[6] = new SqlParameter("@ParmProblem", SqlDbType.NVarChar, 500);
            parm[6].Value = this.Problem;


            parm[7] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[7].Value = this.ID;

            dl.ExecuteCommand("sp_EditMaintenance", parm);

            dl.Close();
        }

        public void DeleteMaintenance()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;

            dl.ExecuteCommand("sp_DeleteMaintenance", parm);

            dl.Close();
        }

        public DataTable GetAll()
        {
            dl.Open();

            DataTable dt = dl.SelectData("sp_GetAllMaintenances", null);

            dl.Close();

            return dt;
        }

        public DataTable GetMaintenanceByID()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;

            DataTable dt = dl.SelectData("sp_GetMaintenanceByID", parm);

            dl.Close();

            return dt;
        }

        public void ReturnMaint()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[3];

            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;

            parm[1] = new SqlParameter("@ParmRetrunTo", SqlDbType.NVarChar, 250);
            parm[1].Value = this.ReturnTo;

            parm[2] = new SqlParameter("@ParmRetrunDate", SqlDbType.Date);
            parm[2].Value = this.ReturnDate;

            dl.ExecuteCommand("sp_ReturnMaintenance", parm);

            dl.Close();
        }
    }
}
