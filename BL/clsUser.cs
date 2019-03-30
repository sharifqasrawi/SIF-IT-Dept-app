using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT_Dept.DL;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;

namespace IT_Dept.BL
{
    class clsUser
    {
        private int id;
        private string firstname;
        private string lastname;
        private string username;
        private string password;
        private bool isActive;
        private DateTime crDate;
        private DateTime lastLoginDate;
        DLClass dl = new DLClass();

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string FirstName
        {
            get { return this.firstname; }
            set { this.firstname = value; }
        }

        public string LastName
        {
            get { return this.lastname; }
            set { this.lastname = value; }
        }

        public string UserName
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public string PassWord
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public bool IsActive
        {
            get { return this.isActive; }
            set { this.isActive = value; }
        }

        public DateTime CrDate
        {
            get { return this.crDate; }
            set { this.crDate = value; }
        }

        public DateTime LastLoginDate
        {
            get { return this.lastLoginDate; }
            set { this.lastLoginDate = value; }
        }

        public clsUser() { }
        public clsUser(int id)
        {
            this.ID = id;
        }

        public clsUser(int id,string password)
        {
            this.ID = id;
            this.PassWord = password;
        }

        public clsUser(string username, string password)
        {
            this.UserName = username;
            this.PassWord = password;
        }

        public clsUser(string fname, string lname, string uname, string pw, bool active, DateTime crDate)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.UserName = uname;
            this.PassWord = pw;
            this.IsActive = active;
            this.CrDate = crDate;
        }

        public clsUser(int id, string fname, string lname, string uname, bool active)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.UserName = uname;
            this.IsActive = active;
            this.ID = id;
        }

        public void AddUser()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[6];
            
            parm[0] = new SqlParameter("@ParmFirstName", SqlDbType.NVarChar, 50);
            parm[0].Value = this.FirstName;

            parm[1] = new SqlParameter("@ParmLastName", SqlDbType.NVarChar, 50);
            parm[1].Value = this.LastName;

            parm[2] = new SqlParameter("@ParmUserName", SqlDbType.NVarChar, 50);
            parm[2].Value = this.UserName;

            parm[3] = new SqlParameter("@ParmPassWord", SqlDbType.NVarChar, 250);
            parm[3].Value = this.HashPassword(this.PassWord);

            parm[4] = new SqlParameter("@ParmIsActive", SqlDbType.Bit);
            parm[4].Value = this.IsActive;

            parm[5] = new SqlParameter("@ParmCrDate", SqlDbType.DateTime);
            parm[5].Value = this.CrDate;


            dl.ExecuteCommand("sp_AddNewUser", parm);


            dl.Close();
        }
        
        public void EditUser()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[5];

            parm[0] = new SqlParameter("@ParmFirstName", SqlDbType.NVarChar, 50);
            parm[0].Value = this.FirstName;

            parm[1] = new SqlParameter("@ParmLastName", SqlDbType.NVarChar, 50);
            parm[1].Value = this.LastName;

            parm[2] = new SqlParameter("@ParmUserName", SqlDbType.NVarChar, 50);
            parm[2].Value = this.UserName;

            parm[3] = new SqlParameter("@ParmIsActive", SqlDbType.Bit);
            parm[3].Value = this.IsActive;

            parm[4] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[4].Value = this.ID;

            dl.ExecuteCommand("sp_EditUser", parm);

            dl.Close();
        }

        public void DeleteUser()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;

            dl.ExecuteCommand("sp_DeleteUser", parm);

            dl.Close();
        }

        public DataTable GetAllUsers()
        {
            dl.Open();
            DataTable dt = dl.SelectData("sp_GetAllUsers", null);
            dl.Close();
            return dt;
        }

        public DataTable GetAllUsers(string me)
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmMe", SqlDbType.NVarChar, 50);
            parm[0].Value = me;
            DataTable dt = dl.SelectData("sp_GetAllUsersButMe", parm);
            dl.Close();
            return dt;
        }
        

        public bool IsUserExists(string username)
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmUname", SqlDbType.NVarChar, 50);
            parm[0].Value = username;
            DataTable dt = dl.SelectData("sp_GetUserByUsername", parm);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }


        public DataTable GetUserByID()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;
            DataTable dt = dl.SelectData("sp_GetUserByID", parm);
            dl.Close();
            return dt;
        }

        public void ResetPassWord()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@ParmNewPassWord", SqlDbType.NVarChar, 250);
            parm[0].Value = this.HashPassword(this.PassWord);

            parm[1] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[1].Value = this.ID;

            dl.ExecuteCommand("sp_ChangePassWord", parm);
            dl.Close();
        }

        public DataTable GetUserRoles()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;

            DataTable dt = dl.SelectData("sp_GetUserRoles", parm);
            dl.Close();
            return dt;
        }

        public void AddRole(int userId, int roleId)
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@ParmUserID", SqlDbType.Int);
            parm[0].Value = userId;
            parm[1] = new SqlParameter("@ParmRoleID", SqlDbType.Int);
            parm[1].Value = roleId;

            dl.ExecuteCommand("sp_AddUserToRole", parm);
            dl.Close();

        }

        public void DeleteRole(int id)
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = id;
            dl.ExecuteCommand("sp_RemoveUserFromRole", parm);
            dl.Close();
        }

        public bool Login()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@ParmUsername", SqlDbType.NVarChar, 50);
            parm[0].Value = this.UserName;

            parm[1] = new SqlParameter("@ParmPassword", SqlDbType.NVarChar, 250);
            parm[1].Value = this.HashPassword(this.PassWord);

            DataTable dt = dl.SelectData("sp_Login", parm);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public void SetLastLogin(DateTime date, int userID)
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@ParmUserID", SqlDbType.Int);
            parm[0].Value = userID;

            parm[1] = new SqlParameter("@ParmLoginDateTime", SqlDbType.DateTime);
            parm[1].Value = date;

            dl.ExecuteCommand("sp_SetLastLogin", parm);

            dl.Close();
        }

        public DateTime GetLastLogin(int userID)
        {
            dl.Open();

            SqlCommand cmd = new SqlCommand("SELECT LastLoginDate FROM tblUsers WHERE ID = @ParmID;", dl.CN);
            cmd.Parameters.Add("@ParmID", SqlDbType.Int).Value = userID;
            DateTime dt = new DateTime();
            if(cmd.ExecuteScalar() != DBNull.Value)
            {
                dt = Convert.ToDateTime(cmd.ExecuteScalar());
            }
            else
            {
                dt = new DateTime(1111, 1, 1, 1, 1, 1);

            }
            return dt;
        }

        public int test(string role)
        {
            dl.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID FROM tblRoles WHERE Role = @ParmRole", dl.CN);
            cmd.Parameters.Add("@ParmRole", SqlDbType.NVarChar, 50).Value = role;
            int roleId = int.Parse(cmd.ExecuteScalar().ToString());
            dl.Close();
            return roleId;
        }
        public bool IsInRole(int id, string role)
        {
            dl.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID FROM tblRoles WHERE Role = @ParmRole", dl.CN);
            cmd.Parameters.Add("@ParmRole", SqlDbType.NVarChar, 50).Value = role;
            int roleId = int.Parse(cmd.ExecuteScalar().ToString());
            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@ParmUserID", SqlDbType.Int);
            parm[0].Value = id;
            parm[1] = new SqlParameter("@ParmRoleID", SqlDbType.Int);
            parm[1].Value = roleId;

            DataTable dt = dl.SelectData("sp_IsInRole", parm);

            dl.Close();

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public int GetUserID()
        {
            dl.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID FROM tblUsers WHERE UserName = @ParmUserName AND PassWord = @ParmPassWord", dl.CN);
            cmd.Parameters.Add("@ParmUserName", SqlDbType.NVarChar, 50).Value = this.UserName;
            cmd.Parameters.Add("@ParmPassWord", SqlDbType.NVarChar, 250).Value = this.HashPassword(this.PassWord);
            int userID = int.Parse(cmd.ExecuteScalar().ToString());
            dl.Close();

            return userID;
        }

        public int GetUserID(string username)
        {
            dl.Open();
            SqlCommand cmd = new SqlCommand("SELECT ID FROM tblUsers WHERE UserName = @ParmUserName", dl.CN);
            cmd.Parameters.Add("@ParmUserName", SqlDbType.NVarChar, 50).Value = username;
            int userID = 0;
            if (cmd.ExecuteScalar() != null)
            {
                 userID = int.Parse(cmd.ExecuteScalar().ToString());
            }
            dl.Close();

            return userID;
        }

        public string GetUserFullNameByID(int id)
        {
            dl.Open();
            SqlCommand cmd = new SqlCommand("SELECT FirstName + ' ' + LastName FROM tblUsers WHERE ID  = @ParmID", dl.CN);
            cmd.Parameters.Add("@ParmID", SqlDbType.Int).Value = id;
            string name = "";
            if (cmd.ExecuteScalar() != null)
            {
                name = cmd.ExecuteScalar().ToString();
            }
            dl.Close();

            return name;
        }

        ////////////////////////////////////////////
        //Hashing password
        public string HashPassword(string pw)
        {
            UTF8Encoding encoder = new UTF8Encoding();
            SHA256Managed sha256hasher = new SHA256Managed();
            byte[] hashedDataBytes = sha256hasher.ComputeHash(encoder.GetBytes(pw));
            return Convert.ToBase64String(hashedDataBytes);
        }
    }
}
