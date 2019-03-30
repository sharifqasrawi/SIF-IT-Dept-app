using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Data.Sql;
namespace IT_Dept.DL
{

    class DLClass
    {
        SqlConnection cn;

        public DLClass()
        {
        //   cn = new SqlConnection(@"Data Source = IT-3; Database = IT_Dept; Integrated Security=True");
           cn = new SqlConnection(@"Data Source = Sharif-dell; Database = IT_Dept; Integrated Security=True");
        //     cn = new SqlConnection(@"Data Source = 192.168.2.13; Database = IT_Dept; Integrated Security=false; User Id = kim; Password = kim2009;");

        }

        public SqlConnection CN
        {
            get { return this.cn; }
        }

        public void Open()
        {
            try
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();

                }
            }
            catch (Exception x)
            {
             //   MessageBox.Show(x.Message);
            }

        }

        public void Close()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();

            }
        }

        public void ExecuteCommand(string stored_srocedure, SqlParameter[] parm)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_srocedure;
            sqlcmd.Connection = cn;
           
            if (parm != null)
            {
                sqlcmd.Parameters.AddRange(parm);
            }

            sqlcmd.ExecuteNonQuery();
        }

        public DataTable SelectData(string stored_srocedure, SqlParameter[] parm)
        {

            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_srocedure;
            sqlcmd.Connection = cn;

            if (parm != null)
            {
                for (int i = 0; i < parm.Length; i++)
                {
                    sqlcmd.Parameters.Add(parm[i]);
                }
            }

            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }


    }
}
