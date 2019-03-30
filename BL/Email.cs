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
    class Email
    {
        private int id;
        private string name;
        private string email;
        private string password;
        private bool active;
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

        public string PropEmail
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public bool Active
        {
            get { return this.active; }
            set { this.active = value; }
        }

        public Email()
        { 
        }

        public Email(int id)
        {
            this.ID = id;
        }

        public Email(string name, string email, string password, bool active)
        {
            this.Name = name;
            this.PropEmail = email;
            this.Password = password;
            this.Active = active;
        }

        public Email(int id, string name, string email, string password, bool active)
        {
            this.ID = id;
            this.Name = name;
            this.PropEmail = email;
            this.Password = password;
            this.Active = active;
        }

        public void addEmail()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[4];
            parm[0] = new SqlParameter("@ParmName", SqlDbType.NVarChar, 100);
            parm[0].Value = this.Name;

            parm[1] = new SqlParameter("@ParmEmail", SqlDbType.NVarChar, 100);
            parm[1].Value = this.PropEmail;

            parm[2] = new SqlParameter("@ParmPassword", SqlDbType.NVarChar, 100);
            parm[2].Value = this.Password;

            parm[3] = new SqlParameter("@ParmActive", SqlDbType.Bit);
            parm[3].Value = this.Active;


            dl.ExecuteCommand("sp_AddEmail", parm);

            dl.Close();
        }

        public void EditEmail()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[5];
            parm[0] = new SqlParameter("@ParmName", SqlDbType.NVarChar, 100);
            parm[0].Value = this.Name;

            parm[1] = new SqlParameter("@ParmEmail", SqlDbType.NVarChar, 100);
            parm[1].Value = this.PropEmail;

            parm[2] = new SqlParameter("@ParmPassword", SqlDbType.NVarChar, 100);
            parm[2].Value = this.Password;

            parm[3] = new SqlParameter("@ParmActive", SqlDbType.Bit);
            parm[3].Value = this.Active;

            parm[4] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[4].Value = this.ID;

            dl.ExecuteCommand("sp_EditEmail", parm);

            dl.Close();
        }

        public void DeleteEmail()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[1];
          
            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;

            dl.ExecuteCommand("sp_DeleteEmail", parm);

            dl.Close();
        }
        public DataTable GetAll()
        {
            dl.Open();
            DataTable dt = dl.SelectData("sp_GetAllEmails", null);
            dl.Close();
            return dt;
        }

        public DataTable GetEmailByID()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;

            DataTable dt = dl.SelectData("sp_GetEmailByID", parm);
            dl.Close();
            return dt;
        }
    }
}
