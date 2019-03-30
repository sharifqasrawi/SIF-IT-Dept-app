using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Data.SqlClient;
using System.Threading;

namespace IT_Dept
{
    public partial class frmPayDocs : Telerik.WinControls.UI.RadForm
    {

        private static frmPayDocs frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public static frmPayDocs GetFrmPayDocs
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmPayDocs();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }

      //  SqlConnection cn1 = new SqlConnection(@"Data Source = 192.168.2.13; Database = IT_Dept; Integrated Security=false; User Id = kim; Password = kim2009;");

        SqlConnection cn1 = new IT_Dept.DL.DLClass().CN;


        SqlConnection cn = new SqlConnection(@"Data Source = 192.168.2.12; Database = sif_internal; Integrated Security=false; User Id = kim; Password = kim2009;");
        public frmPayDocs()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;

            radLabelElementMachine.Text = Environment.MachineName;
            radLabelElementDate.Text = DateTime.Now.ToLongDateString();
            radLabelElementCon.Text = cn.DataSource;

            ThemeResolutionService.ApplicationThemeName = "Breeze";
            radDateTimePicker1.Value = DateTime.Now;
            radDateTimePicker2.Value = DateTime.Now;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblCenters where IsCenter = 1 Order by Center_Name ", cn1);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);


            radDropDownList1.DataSource = dt;
            radDropDownList1.DisplayMember = "Center_Name";
            radDropDownList1.ValueMember = "ConDB";
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(f);
            t.Start();
            txtRes.Text = "Please wait...";
            radButton1.Enabled = false;

            
        }

        private void f()
        {
            string centerName = "";
            try
            {
                string center = "";
                
                centerName = radDropDownList1.SelectedItem.ToString();
                center = radDropDownList1.SelectedValue.ToString();
                
                string fromDate = radDateTimePicker1.Value.Year.ToString() + "-0" + radDateTimePicker1.Value.Month.ToString() + "-" + radDateTimePicker1.Value.Day.ToString();
                string toDate = radDateTimePicker2.Value.Year.ToString() + "-0" + radDateTimePicker2.Value.Month.ToString() + "-" + radDateTimePicker2.Value.Day.ToString();
                //     MessageBox.Show(fromDate + "   " + toDate);

                string cmdText = "UPDATE tbl_Contracts_All " +
                                 "SET Cont_Paydoc = tbl_Contracts_All_1.Cont_Paydoc " +
                                 "FROM tbl_Contracts_All INNER JOIN " +
                                 center + ".dbo.tbl_Contracts_All " +
                                 "AS tbl_Contracts_All_1 " +
                                 "ON tbl_Contracts_All.AllID = tbl_Contracts_All_1.AllID " +
                                 "AND tbl_Contracts_All.AllType = tbl_Contracts_All_1.AllType " +
                                 "AND tbl_Contracts_All.All_CenterID = tbl_Contracts_All_1.All_CenterID " +
                                 "WHERE (tbl_Contracts_All.Cont_PayDoc IS NULL) AND (tbl_Contracts_All_1.Cont_PayDoc IS NOT NULL) " +
                                 "AND (dateadd(d,0,dateDiff(Day,0,tbl_Contracts_All.Cont_Date)) >= '" + fromDate + "') " +
                                 "AND (dateadd(d,0,dateDiff(Day,0,tbl_Contracts_All.Cont_Date)) <= '" + toDate + "') ";



                cn.Open();

                SqlCommand cmd = new SqlCommand(cmdText, cn);
                cmd.CommandTimeout = 9999999;
                int? r = cmd.ExecuteNonQuery();
                if (r != null)
                {
                    if (txtRes.InvokeRequired)
                    {
                        txtRes.Invoke(new MethodInvoker(delegate { txtRes.Text = r.ToString() + " Rows affected"; }));
                    }

                    if (txtSuc.InvokeRequired)
                    {
                        txtSuc.Invoke(new MethodInvoker(delegate { txtSuc.Text += "Success: " + centerName + Environment.NewLine; }));
                    }
                 //   txtSuc.Text += "Sucess: " + centerName + Environment.NewLine;
                }
                else
                {
                    txtRes.Text = "Error";
                }
                cn.Close();
                
            }
            catch (Exception ex)
            {
                if (txtRes.InvokeRequired)
                {
                    txtRes.Invoke(new MethodInvoker(delegate { txtRes.Text = "Error"; }));
                }
                if (txtSuc.InvokeRequired)
                {
                    txtSuc.Invoke(new MethodInvoker(delegate { txtSuc.Text += "Fail: " + centerName + Environment.NewLine; }));
                }
              //  txtSuc.Text += "Fail: " + centerName + Environment.NewLine;
            }
            finally
            {
                if (radButton1.InvokeRequired)
                {
                    radButton1.Invoke(new MethodInvoker(delegate { radButton1.Enabled = true; }));
                }
                cn.Close();
               // radButton1.Enabled = true;
            }
        }
    }
}
