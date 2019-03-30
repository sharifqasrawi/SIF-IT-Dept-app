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
    class clsCenter
    {
        private int id;
        private int center_code;
        private string center_name;
        private int gov_id;
        private int conType_id;
        private int conSpeed_id;
        private int gateType_id;
        private string lan_ip;
        private string con_ip;
        private string server_ip;
        private string center_db;
        private string admin_ord;
        private int gate_number;
        private string pdn_username;
        private string pdn_password;
        private string cir_code;
        private string ph_number;
        private string mob_number;
        private string cntHead;
        private DateTime order_date;

        DLClass dl = new DLClass();

        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public int Center_code
        {
            get { return this.center_code; }
            set { this.center_code = value; }
        }

        public int Gov_id
        {
            get { return this.gov_id; }
            set { this.gov_id = value; }
        }

        public int ConType_id
        {
            get { return this.conType_id; }
            set { this.conType_id = value; }
        }

        public int ConSpeed_id
        {
            get { return this.conSpeed_id; }
            set { this.conSpeed_id = value; }
        }

        public int GateType_id
        {
            get { return this.gateType_id; }
            set { this.gateType_id = value; }
        }

        public int Gate_number
        {
            get { return this.gate_number; }
            set { this.gate_number = value; }
        }

        public string Center_Name
        {
            get { return this.center_name; }
            set { this.center_name = value; }
        }

        public string Lan_ip
        {
            get { return this.lan_ip; }
            set { this.lan_ip = value; }
        }

        public string Con_ip
        {
            get { return this.con_ip; }
            set { this.con_ip = value; }
        }
        public string Server_ip
        {
            get { return this.server_ip; }
            set { this.server_ip = value; }
        }
        public string Center_db
        {
            get { return this.center_db; }
            set { this.center_db = value; }
        }

        public string Admin_ord
        {
            get { return this.admin_ord; }
            set { this.admin_ord = value; }
        }

        public string Pdn_username
        {
            get { return this.pdn_username; }
            set { this.pdn_username = value; }
        }

        public string Pdn_Password
        {
            get { return this.pdn_password; }
            set { this.pdn_password = value; }
        }

        public string Cir_code
        {
            get { return this.cir_code; }
            set { this.cir_code = value; }
        }

        public string Ph_number
        {
            get { return this.ph_number; }
            set { this.ph_number = value; }
        }

        public string Mob_number
        {
            get { return this.mob_number; }
            set { this.mob_number = value; }
        }

        public string CntHead
        {
            get { return this.cntHead; }
            set { this.cntHead = value; }
        }

        public DateTime Order_Date
        {
            get { return this.order_date; }
            set { this.order_date = value; }
        }


        public clsCenter() { }
        public clsCenter(int id)
        {
            this.ID = id;
        }

        public clsCenter(int cnt_code, string cnt_name, int gov, int con_type, int con_speed, int gate_type, int gate_num, string cir_code, string cntHname, string con_ip, string lan_ip, string db, string ad_or, string pdnu, string pdnp, string ph, string mob,string sip,DateTime od)
        {
            this.Center_code = cnt_code;
            this.Center_Name = cnt_name;
            this.Gov_id = gov;
            this.ConType_id = con_type;
            this.ConSpeed_id = con_speed;
            this.GateType_id = gate_type;
            this.Gate_number = gate_num;
            this.Cir_code = cir_code;
            this.CntHead = cntHname;
            this.Con_ip = con_ip;
            this.Lan_ip = lan_ip;
            this.Center_db = db;
            this.Admin_ord = ad_or;
            this.Pdn_username = pdnu;
            this.Pdn_Password = pdnp;
            this.Ph_number = ph;
            this.Mob_number = mob;
            this.Server_ip = sip;
            this.Order_Date = od;
        }

        public clsCenter(int id , int cnt_code, string cnt_name, int gov, int con_type, int con_speed, int gate_type, int gate_num, string cir_code, string cntHname, string con_ip, string lan_ip, string db, string ad_or, string pdnu, string pdnp, string ph, string mob,string sip,DateTime od)
        {
            this.ID = id;
            this.Center_code = cnt_code;
            this.Center_Name = cnt_name;
            this.Gov_id = gov;
            this.ConType_id = con_type;
            this.ConSpeed_id = con_speed;
            this.GateType_id = gate_type;
            this.Gate_number = gate_num;
            this.Cir_code = cir_code;
            this.CntHead = cntHname;
            this.Con_ip = con_ip;
            this.Lan_ip = lan_ip;
            this.Center_db = db;
            this.Admin_ord = ad_or;
            this.Pdn_username = pdnu;
            this.Pdn_Password = pdnp;
            this.Ph_number = ph;
            this.Mob_number = mob;
            this.Server_ip = sip;
            this.Order_Date = od;
        }

        public void addCenter()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[19];

            parm[0] = new SqlParameter("@ParmCenterCode", SqlDbType.Int);
            parm[0].Value = this.Center_code;

            parm[1] = new SqlParameter("@ParmCenterName", SqlDbType.NVarChar, 50);
            parm[1].Value = this.Center_Name;

            parm[2] = new SqlParameter("@ParmGovID", SqlDbType.Int);
            parm[2].Value = this.Gov_id;

            parm[3] = new SqlParameter("@ParmConTypeID", SqlDbType.Int);
            parm[3].Value = this.ConType_id;

            parm[4] = new SqlParameter("@ParmConSpeedID", SqlDbType.Int);
            parm[4].Value = this.ConSpeed_id;

            parm[5] = new SqlParameter("@ParmGateTypeID", SqlDbType.Int);
            parm[5].Value = this.GateType_id;

            parm[6] = new SqlParameter("@ParmGateNum", SqlDbType.Int);
            parm[6].Value = this.Gate_number;

            parm[7] = new SqlParameter("@ParmCirCode", SqlDbType.NVarChar, 50); 
            parm[7].Value = this.Cir_code;

            parm[8] = new SqlParameter("@ParmCntHeadName", SqlDbType.NVarChar, 100);
            parm[8].Value = this.CntHead;

            parm[9] = new SqlParameter("@ParmConIP", SqlDbType.NVarChar, 50);
            parm[9].Value = this.Con_ip;

            parm[10] = new SqlParameter("@ParmLanIP", SqlDbType.NVarChar, 50); ;
            parm[10].Value = this.Lan_ip;

            parm[11] = new SqlParameter("@ParmCenterDB", SqlDbType.NVarChar, 50); 
            parm[11].Value = this.Center_db;

            parm[12] = new SqlParameter("@ParmAdminOrd", SqlDbType.NVarChar, 50); 
            parm[12].Value = this.Admin_ord;

            parm[13] = new SqlParameter("@ParmPDNUsername", SqlDbType.NVarChar, 50);
            parm[13].Value = this.Pdn_username;

            parm[14] = new SqlParameter("@ParmPDNPassword", SqlDbType.NVarChar, 50); 
            parm[14].Value = this.Pdn_Password;

            parm[15] = new SqlParameter("@ParmPhNumber", SqlDbType.NVarChar, 100); 
            parm[15].Value = this.Ph_number;

            parm[16] = new SqlParameter("@ParmMobNumber", SqlDbType.NVarChar, 100); 
            parm[16].Value = this.Mob_number;

            parm[17] = new SqlParameter("@ParmServerIP", SqlDbType.NVarChar, 50); 
            parm[17].Value = this.Server_ip;

            parm[18] = new SqlParameter("@ParmOrdDate", SqlDbType.Date);
            parm[18].Value = this.Order_Date;

            dl.ExecuteCommand("sp_AddCenter", parm);

            dl.Close();
        }

        public void EditCenter()
        {
            dl.Open();

            SqlParameter[] parm = new SqlParameter[20];

            parm[0] = new SqlParameter("@ParmCenterCode", SqlDbType.Int);
            parm[0].Value = this.Center_code;

            parm[1] = new SqlParameter("@ParmCenterName", SqlDbType.NVarChar, 50);
            parm[1].Value = this.Center_Name;

            parm[2] = new SqlParameter("@ParmGovID", SqlDbType.Int);
            parm[2].Value = this.Gov_id;

            parm[3] = new SqlParameter("@ParmConTypeID", SqlDbType.Int);
            parm[3].Value = this.ConType_id;

            parm[4] = new SqlParameter("@ParmConSpeedID", SqlDbType.Int);
            parm[4].Value = this.ConSpeed_id;

            parm[5] = new SqlParameter("@ParmGateTypeID", SqlDbType.Int);
            parm[5].Value = this.GateType_id;

            parm[6] = new SqlParameter("@ParmGateNum", SqlDbType.Int);
            parm[6].Value = this.Gate_number;

            parm[7] = new SqlParameter("@ParmCirCode", SqlDbType.NVarChar, 50); 
            parm[7].Value = this.Cir_code;

            parm[8] = new SqlParameter("@ParmCntHname", SqlDbType.NVarChar, 100);
            parm[8].Value = this.CntHead;

            parm[9] = new SqlParameter("@ParmConIP", SqlDbType.NVarChar, 50);
            parm[9].Value = this.Con_ip;

            parm[10] = new SqlParameter("@ParmLanIP", SqlDbType.NVarChar, 50); 
            parm[10].Value = this.Lan_ip;

            parm[11] = new SqlParameter("@ParmCenterDB", SqlDbType.NVarChar, 50); 
            parm[11].Value = this.Center_db;

            parm[12] = new SqlParameter("@ParmAdminOrd", SqlDbType.NVarChar, 50); 
            parm[12].Value = this.Admin_ord;

            parm[13] = new SqlParameter("@ParmPDNUsername", SqlDbType.NVarChar, 50);
            parm[13].Value = this.Pdn_username;

            parm[14] = new SqlParameter("@ParmPDNPassword", SqlDbType.NVarChar, 50); 
            parm[14].Value = this.Pdn_Password;

            parm[15] = new SqlParameter("@ParmPhNumber", SqlDbType.NVarChar, 100); 
            parm[15].Value = this.Ph_number;

            parm[16] = new SqlParameter("@ParmMobNumber", SqlDbType.NVarChar, 100); 
            parm[16].Value = this.Mob_number;


            parm[17] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[17].Value = this.ID;

            parm[18] = new SqlParameter("@ParmServerIP", SqlDbType.NVarChar, 50);
            parm[18].Value = this.Server_ip;

            parm[19] = new SqlParameter("@ParmOrdDate", SqlDbType.Date);
            parm[19].Value = this.Order_Date;


            dl.ExecuteCommand("sp_EditCenter", parm);

            dl.Close();
        }

        public void DeleteCenter()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;

            dl.ExecuteCommand("sp_DeleteCenter", parm);

            dl.Close();
        }

        public DataTable GetAll()
        {
            dl.Open();
            DataTable dt = dl.SelectData("sp_GetAllCenters", null);

            dl.Close();
            return dt;
        }
        public DataTable GetAll2()
        {
            dl.Open();
            DataTable dt = dl.SelectData("sp_GetAllCenters2", null);

            dl.Close();
            return dt;
        }
        public DataTable GetAll3G()
        {
            dl.Open();
            DataTable dt = dl.SelectData("sp_GetAll3GCenters", null);

            dl.Close();
            return dt;
        }
        public DataTable GetAllGSH()
        {
            dl.Open();
            DataTable dt = dl.SelectData("sp_GetAllGSHCenters", null);

            dl.Close();
            return dt;
        }

        public DataTable GetCenterByID()
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = this.ID;

            DataTable dt = dl.SelectData("sp_GetCenterByID", parm);

            dl.Close();
            return dt;
        }

        public bool IsCenterExists(int code)
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@ParmID", SqlDbType.Int);
            parm[0].Value = code;
            DataTable dt = new DataTable();
            dt = dl.SelectData("sp_GetCenterByCode", parm);

            dl.Close();

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;

        }

        public bool IsIPExists(string cip,string lip,string sip)
        {
            dl.Open();
            SqlParameter[] parm = new SqlParameter[3];
            parm[0] = new SqlParameter("@ParmConIP", SqlDbType.NVarChar, 50);
            parm[0].Value = cip;
            parm[1] = new SqlParameter("@ParmLanIP", SqlDbType.NVarChar, 50);
            parm[1].Value = lip;
            parm[2] = new SqlParameter("@ParmServerIP", SqlDbType.NVarChar, 50);
            parm[2].Value = sip;
            DataTable dt = dl.SelectData("sp_GetCenterByIP", parm);
            dl.Close();
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
