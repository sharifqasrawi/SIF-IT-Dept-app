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
    class clsRole
    {
        DLClass dl = new DLClass();

        public DataTable GetAllRoles()
        {
            dl.Open();
            DataTable dt = dl.SelectData("sp_GetAllRoles", null);
            dl.Close();
            return dt;
        }

        public string GetRoleByID(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT Role FROM tblRoles WHERE ID = @ParmID", dl.CN);
            cmd.Parameters.Add("@ParmID", SqlDbType.Int).Value = id;
            dl.Open();
            string role = cmd.ExecuteScalar().ToString();
            dl.Close();
            return role;
        }
    }
}
