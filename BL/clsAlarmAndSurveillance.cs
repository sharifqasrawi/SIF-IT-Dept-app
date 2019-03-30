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
    class clsAlarm
    {
        int id;
        int center_id;
        string type;
        string password;
        int motionSensors;
        int fireSensors;
        DLClass dl = new DLClass();

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public int Center_Id
        {
            get { return this.center_id; }
            set { this.center_id = value; }
        }

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public int MotionSensors
        {
            get { return this.motionSensors; }
            set { this.motionSensors= value; }
        }

        public int FireSensors
        {
            get { return this.fireSensors; }
            set { this.fireSensors = value; }
        }

        public clsAlarm()
        {

        }

        public clsAlarm(int id)
        {
            this.Id = id;
        }

        public clsAlarm(int cid, string type, string pass, int ms, int fs)
        {
            this.Center_Id = cid;
            this.Type = type;
            this.Password = pass;
            this.MotionSensors = ms;
            this.FireSensors = fs;
        }

        public clsAlarm(int id, int cid, string type, string pass, int ms, int fs)
        {
            this.Id = id;
            this.Center_Id = cid;
            this.Type = type;
            this.Password = pass;
            this.MotionSensors = ms;
            this.FireSensors = fs;
        }

        public void AddAlarm()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[5];
            parm[0] = new SqlParameter("@ParmCenterId", SqlDbType.Int);
            parm[0].Value = this.Center_Id;

            parm[1] = new SqlParameter("@ParmType", SqlDbType.NVarChar, 50);
            parm[1].Value = this.Type;

            parm[2] = new SqlParameter("@ParmPassword", SqlDbType.NVarChar, 50);
            parm[2].Value = this.Password;

            parm[3] = new SqlParameter("@ParmMotionSensors", SqlDbType.Int);
            parm[3].Value = this.MotionSensors;

            parm[4] = new SqlParameter("@ParmFireSensors", SqlDbType.Int);
            parm[4].Value = this.FireSensors;

            dl.ExecuteCommand("sp_AddAlarmDevice", parm);

            dl.Close();
        }

        public void EditAlarm()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[6];
            parm[0] = new SqlParameter("@ParmCenterId", SqlDbType.Int);
            parm[0].Value = this.Center_Id;

            parm[1] = new SqlParameter("@ParmType", SqlDbType.NVarChar, 50);
            parm[1].Value = this.Type;

            parm[2] = new SqlParameter("@ParmPassword", SqlDbType.NVarChar, 50);
            parm[2].Value = this.Password;

            parm[3] = new SqlParameter("@ParmMotionSensors", SqlDbType.Int);
            parm[3].Value = this.MotionSensors;

            parm[4] = new SqlParameter("@ParmFireSensors", SqlDbType.Int);
            parm[4].Value = this.FireSensors;

            parm[5] = new SqlParameter("@ParmId", SqlDbType.Int);
            parm[5].Value = this.Id;

            dl.ExecuteCommand("sp_EditAlarmDevice", parm);

            dl.Close();
        }

        public void DeleteAlarm()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@ParmId", SqlDbType.Int);
            parm[0].Value = this.Id;

            dl.ExecuteCommand("sp_DeleteAlarmDevice", parm);

            dl.Close();
        }

        public DataTable GetAll()
        {
            dl.Open();

            DataTable dt = dl.SelectData("sp_GetAllAlarmDevices", null);

            dl.Close();
            return dt;
        }

        public DataTable GetById()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[1];

            parm[0] = new SqlParameter("@ParmId", SqlDbType.Int);
            parm[0].Value = this.Id;

            DataTable dt = dl.SelectData("sp_GetAlarmDeviceById", parm);

            dl.Close();
            return dt;
        }
    }

    public class clsAlarmPhNumber
    {
        int id;
        int alarm_id;
        string phNumber;
        string name;

        DLClass dl = new DLClass();

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public int Alarm_Id
        {
            get { return this.alarm_id; }
            set { this.alarm_id = value; }
        }

        public string PhNumber
        {
            get { return this.phNumber; }
            set { this.phNumber = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public clsAlarmPhNumber()
        {

        }

        public clsAlarmPhNumber(int id)
        {
            this.Id = id;
        }

        public clsAlarmPhNumber(int aid, string ph, string n)
        {
            this.Alarm_Id = aid;
            this.PhNumber = ph;
            this.Name = n;
        }
        public clsAlarmPhNumber(int id, int aid, string ph, string n)
        {
            this.Id = id;
            this.Alarm_Id = aid;
            this.PhNumber = ph;
            this.Name = n;
        }

        public void AddAlarmPhNumber()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[3];
            parm[0] = new SqlParameter("@ParmAlarmId", SqlDbType.Int);
            parm[0].Value = this.Alarm_Id;

            parm[1] = new SqlParameter("@ParmNumber", SqlDbType.NVarChar, 50);
            parm[1].Value = this.PhNumber;

            parm[2] = new SqlParameter("@ParmName", SqlDbType.NVarChar, 50);
            parm[2].Value = this.Name;

            dl.ExecuteCommand("sp_AddAlarmPhNumber", parm);

            dl.Close();
        }

        public void EditAlarmPhNumber()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[4];
            parm[0] = new SqlParameter("@ParmAlarmId", SqlDbType.Int);
            parm[0].Value = this.Alarm_Id;

            parm[1] = new SqlParameter("@ParmNumber", SqlDbType.NVarChar, 50);
            parm[1].Value = this.PhNumber;

            parm[2] = new SqlParameter("@ParmName", SqlDbType.NVarChar, 50);
            parm[2].Value = this.Name;

            parm[3] = new SqlParameter("@ParmId", SqlDbType.Int);
            parm[3].Value = this.Id;

            dl.ExecuteCommand("sp_EditAlarmPhNumber", parm);

            dl.Close();
        }

        public void DeleteAlarmPhNumber()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[1];


            parm[0] = new SqlParameter("@ParmId", SqlDbType.Int);
            parm[0].Value = this.Id;

            dl.ExecuteCommand("sp_DeleteAlarmPhNumber", parm);

            dl.Close();
        }

        public DataTable GetAlarmPhById()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[1];


            parm[0] = new SqlParameter("@ParmId", SqlDbType.Int);
            parm[0].Value = this.Id;

            DataTable dt = dl.SelectData("sp_GetAlarmPhNumberById", parm);

            dl.Close();
            return dt;
        }

        public DataTable GetAlarmPhById(int devId)
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[1];


            parm[0] = new SqlParameter("@ParmId", SqlDbType.Int);
            parm[0].Value = devId;

            DataTable dt = dl.SelectData("sp_GetAlarmPhNumbersByDevId", parm);

            dl.Close();
            return dt;
        }
    }

    public class clsSurveillance
    {
        int id;
        int center_id;
        string type;
        string ip;
        string username;
        string password;
        int innerCameras;
        int outercameras;
        DLClass dl = new DLClass();
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public int Center_id
        {
            get { return this.center_id; }
            set { this.center_id = value; }
        } 

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public string Ip
        {
            get { return this.ip; }
            set { this.ip = value; }
        }

        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        public string Password
        {
            get { return this.password; }
            set { this.password = value; }
        }

        public int InnerCameras
        {
            get { return this.innerCameras; }
            set { this.innerCameras = value; }
        }

        public int OuterCameras
        {
            get { return this.outercameras; }
            set { this.outercameras = value; }
        }

        public clsSurveillance()
        {

        }
        public clsSurveillance(int id)
        {
            this.Id = id;
        }
        public clsSurveillance(int cid, string t, string ip,string u, string p, int ic, int oc)
        {
            this.Center_id = cid;
            this.Type = t;
            this.Ip = ip;
            this.Username = u;
            this.Password = p;
            this.InnerCameras = ic;
            this.OuterCameras = oc;
        }

        public clsSurveillance(int id, int cid, string t, string ip, string u, string p, int ic, int oc)
        {
            this.Id = id;
            this.Center_id = cid;
            this.Type = t;
            this.Ip = ip;
            this.Username = u;
            this.Password = p;
            this.InnerCameras = ic;
            this.OuterCameras = oc;
        }

        public void AddSurDevice()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[7];
            parm[0] = new SqlParameter("@ParmCenterId", SqlDbType.Int);
            parm[0].Value = this.Center_id;

            parm[1] = new SqlParameter("@ParmType", SqlDbType.NVarChar, 50);
            parm[1].Value = this.Type;

            parm[2] = new SqlParameter("@ParmIp", SqlDbType.NVarChar, 50);
            parm[2].Value = this.Ip;

            parm[3] = new SqlParameter("@ParmUserName", SqlDbType.NVarChar, 50);
            parm[3].Value = this.Username;

            parm[4] = new SqlParameter("@ParmPassword", SqlDbType.NVarChar, 50);
            parm[4].Value = this.Password;

            parm[5] = new SqlParameter("@ParmInnerCameras", SqlDbType.Int);
            parm[5].Value = this.InnerCameras;

            parm[6] = new SqlParameter("@ParmOuterCameras", SqlDbType.Int);
            parm[6].Value = this.OuterCameras;

            dl.ExecuteCommand("sp_AddSurvDevice", parm);

            dl.Close();
        }

        public void EditSurDevice()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[8];
            parm[0] = new SqlParameter("@ParmCenterId", SqlDbType.Int);
            parm[0].Value = this.Center_id;

            parm[1] = new SqlParameter("@ParmType", SqlDbType.NVarChar, 50);
            parm[1].Value = this.Type;

            parm[2] = new SqlParameter("@ParmIp", SqlDbType.NVarChar, 50);
            parm[2].Value = this.Ip;

            parm[3] = new SqlParameter("@ParmUserName", SqlDbType.NVarChar, 50);
            parm[3].Value = this.Username;

            parm[4] = new SqlParameter("@ParmPassword", SqlDbType.NVarChar, 50);
            parm[4].Value = this.Password;

            parm[5] = new SqlParameter("@ParmInnerCameras", SqlDbType.Int);
            parm[5].Value = this.InnerCameras;

            parm[6] = new SqlParameter("@ParmOuterCameras", SqlDbType.Int);
            parm[6].Value = this.OuterCameras;

            parm[7] = new SqlParameter("@ParmId", SqlDbType.Int);
            parm[7].Value = this.Id;


            dl.ExecuteCommand("sp_EditSurvDevice", parm);

            dl.Close();
        }

        public void DeleteSurDevice()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[1];
           

            parm[0] = new SqlParameter("@ParmId", SqlDbType.Int);
            parm[0].Value = this.Id;


            dl.ExecuteCommand("sp_DeleteSurvDevice", parm);

            dl.Close();
        }
        
        public DataTable GetAll()
        {
            dl.Open();

            DataTable dt = dl.SelectData("sp_GetAllSurvs", null);

            dl.Close();
            return dt;
        }

         public DataTable GetSurvById()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[1];


            parm[0] = new SqlParameter("@ParmId", SqlDbType.Int);
            parm[0].Value = this.Id;

            DataTable dt = dl.SelectData("sp_GetSurvById", parm);

            dl.Close();
            return dt;
        }
    }
}
