using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using IT_Dept.BL;

using Microsoft.Office.Interop.Word;
using Microsoft.Office.Core;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Diagnostics;
using System.Drawing.Drawing2D;


namespace IT_Dept.PL
{
    public partial class frmCreateDayOffDoc : Telerik.WinControls.UI.RadForm
    {
        private static string type = "";
        public frmCreateDayOffDoc()
        {
            InitializeComponent();
        }
       
        //Methode Find and Replace:
        private void FindAndReplace(Microsoft.Office.Interop.Word.Application wordApp, object findText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref findText,
                        ref matchCase, ref matchWholeWord,
                        ref matchWildCards, ref matchSoundLike,
                        ref nmatchAllForms, ref forward,
                        ref wrap, ref format, ref replaceWithText,
                        ref replace, ref matchKashida,
                        ref matchDiactitics, ref matchAlefHamza,
                        ref matchControl);
        }

        private void CreateWordDocument(object filename, object savaAs)
        {
            List<int> processesbeforegen = getRunningProcesses();
            object missing = Missing.Value;
            string tempPath = null;

            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();

            Microsoft.Office.Interop.Word.Document aDoc = null;

            if (File.Exists((string)filename))
            {
                DateTime today = DateTime.Now;

                object readOnly = false; //default
                object isVisible = false;

                wordApp.Visible = false;

                aDoc = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing, ref missing);

                aDoc.Activate();

                //Find and replace:
                if(rbAdmin.IsChecked)
                {
                    this.FindAndReplace(wordApp, "<c1>", "*");
                    this.FindAndReplace(wordApp, "<c2>", "");
                    this.FindAndReplace(wordApp, "<c3>", "");
                    this.FindAndReplace(wordApp, "<c4>", "");
                    this.FindAndReplace(wordApp, "<c5>", "");
                    this.FindAndReplace(wordApp, "<c6>", "");
                    type = rbAdmin.Text;
                }
                else if (rbSick.IsChecked)
                {
                    this.FindAndReplace(wordApp, "<c1>", "");
                    this.FindAndReplace(wordApp, "<c2>", "*");
                    this.FindAndReplace(wordApp, "<c3>", "");
                    this.FindAndReplace(wordApp, "<c4>", "");
                    this.FindAndReplace(wordApp, "<c5>", "");
                    this.FindAndReplace(wordApp, "<c6>", "");
                    type = rbSick.Text;
                }
                else if (rbMar.IsChecked)
                {
                    this.FindAndReplace(wordApp, "<c1>", "");
                    this.FindAndReplace(wordApp, "<c2>", "");
                    this.FindAndReplace(wordApp, "<c3>", "*");
                    this.FindAndReplace(wordApp, "<c4>", "");
                    this.FindAndReplace(wordApp, "<c5>", "");
                    this.FindAndReplace(wordApp, "<c6>", "");
                    type = rbMar.Text;
                }
                else if (rbEm.IsChecked)
                {
                    this.FindAndReplace(wordApp, "<c1>", "");
                    this.FindAndReplace(wordApp, "<c2>", "");
                    this.FindAndReplace(wordApp, "<c3>", "");
                    this.FindAndReplace(wordApp, "<c4>", "*");
                    this.FindAndReplace(wordApp, "<c5>", "");
                    this.FindAndReplace(wordApp, "<c6>", "");
                    type = rbEm.Text;
                }
                else if (rbNosal.IsChecked)
                {
                    this.FindAndReplace(wordApp, "<c1>", "");
                    this.FindAndReplace(wordApp, "<c2>", "");
                    this.FindAndReplace(wordApp, "<c3>", "");
                    this.FindAndReplace(wordApp, "<c4>", "");
                    this.FindAndReplace(wordApp, "<c5>", "*");
                    this.FindAndReplace(wordApp, "<c6>", "");
                    type = rbNosal.Text;
                }
                else if (rbMoth.IsChecked)
                {
                    this.FindAndReplace(wordApp, "<c1>", "");
                    this.FindAndReplace(wordApp, "<c2>", "");
                    this.FindAndReplace(wordApp, "<c3>", "");
                    this.FindAndReplace(wordApp, "<c4>", "");
                    this.FindAndReplace(wordApp, "<c5>", "");
                    this.FindAndReplace(wordApp, "<c6>", "*");
                    type = rbMoth.Text;
                }

                if(cbPhoneCall.Checked)
                {
                    this.FindAndReplace(wordApp, "<sing>", "اتصال هاتفي");
                }
                else
                {
                    this.FindAndReplace(wordApp, "<sing>", "_______");
                }

                this.FindAndReplace(wordApp, "<Duration>", txtDuration.Text);
                this.FindAndReplace(wordApp, "<FromDay>", lstFromDay.SelectedItem.ToString());
                this.FindAndReplace(wordApp, "<FromDate>", dateFrom.Value.ToShortDateString());
                this.FindAndReplace(wordApp, "<ToDay>", lstToDay.SelectedItem.ToString());
                this.FindAndReplace(wordApp, "<ToDate>", dateTo.Value.ToShortDateString());
                this.FindAndReplace(wordApp, "<Reason>", txtReason.Text);
                this.FindAndReplace(wordApp, "<Name>", txtEmpName.Text);
                this.FindAndReplace(wordApp, "<Job>", txtJob.Text);
                this.FindAndReplace(wordApp, "<IssueDate>", dateIssue.Value.ToShortDateString());


                /* Object oMissed = aDoc.Paragraphs[1].Range; //the position you want to insert
                 Object oLinkToFile = false;  //default
                 Object oSaveWithDocument = true;//default
                 aDoc.InlineShapes.AddPicture(tempPath, ref  oLinkToFile, ref  oSaveWithDocument, ref oMissed);
                 */

                #region Print Document :
                /*object copies = "1";
                object pages = "1";
                object range = Word.WdPrintOutRange.wdPrintCurrentPage;
                object items = Word.WdPrintOutItem.wdPrintDocumentContent;
                object pageType = Word.WdPrintOutPages.wdPrintAllPages;
                object oTrue = true;
                object oFalse = false;

                Word.Document document = aDoc;
                object nullobj = Missing.Value;
                int dialogResult = wordApp.Dialogs[Microsoft.Office.Interop.Word.WdWordDialog.wdDialogFilePrint].Show(ref nullobj);
                wordApp.Visible = false;
                if (dialogResult == 1)
                {
                    document.PrintOut(
                    ref oTrue, ref oFalse, ref range, ref missing, ref missing, ref missing,
                    ref items, ref copies, ref pages, ref pageType, ref oFalse, ref oTrue,
                    ref missing, ref oFalse, ref missing, ref missing, ref missing, ref missing);
                }
                */
                #endregion

            }
            else
            {
                MessageBox.Show("file dose not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Save as: filename
            aDoc.SaveAs2(ref savaAs, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing);

            //Close Document:
            //aDoc.Close(ref missing, ref missing, ref missing);
            // File.Delete(tempPath);
            MessageBox.Show("File created.", "Create", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            List<int> processesaftergen = getRunningProcesses();
            killProcesses(processesbeforegen, processesaftergen);
            this.Close();
        }


        public List<int> getRunningProcesses()
        {
            List<int> ProcessIDs = new List<int>();
            //here we're going to get a list of all running processes on
            //the computer
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (Process.GetCurrentProcess().Id == clsProcess.Id)
                    continue;
                if (clsProcess.ProcessName.Contains("WINWORD"))
                {
                    ProcessIDs.Add(clsProcess.Id);
                }
            }
            return ProcessIDs;
        }


        private void killProcesses(List<int> processesbeforegen, List<int> processesaftergen)
        {
            foreach (int pidafter in processesaftergen)
            {
                bool processfound = false;
                foreach (int pidbefore in processesbeforegen)
                {
                    if (pidafter == pidbefore)
                    {
                        processfound = true;
                    }
                }

                if (processfound == false)
                {
                    Process clsProcess = Process.GetProcessById(pidafter);
                    clsProcess.Kill();
                }
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (rbAdmin.IsChecked)
            {
                type = rbAdmin.Text;
            }
            else if (rbSick.IsChecked)
            {
                type = rbSick.Text;
            }
            else if (rbMar.IsChecked)
            {
                type = rbMar.Text;
            }
            else if (rbEm.IsChecked)
            {
                type = rbEm.Text;
            }
            else if (rbNosal.IsChecked)
            {
                type = rbNosal.Text;
            }
            else if (rbMoth.IsChecked)
            {
                type = rbMoth.Text;
            }

            clsDayOff d = new clsDayOff(type, txtDuration.Text, lstFromDay.SelectedItem.ToString(), dateFrom.Value, lstToDay.SelectedItem.ToString(), dateTo.Value, txtReason.Text, txtEmpName.Text, txtJob.Text, dateIssue.Value);
            d.AddDayOff();

            frmDayOffs.GetFrmDayOffs.offsGridView.DataSource = d.GetAll();

            SaveFileDialog SaveDoc = new SaveFileDialog();
            SaveDoc.Filter = "Word doc (*.doc) |*.doc";



            CreateWordDocument(System.Windows.Forms.Application.StartupPath + "/Documents/dayOff.doc", System.Windows.Forms.Application.StartupPath + "/Created_Documents/DayOffs/إجازة - " + txtEmpName.Text);
            Process.Start(System.Windows.Forms.Application.StartupPath + "/Created_Documents/DayOffs");
        }

        private void frmCreateDayOffDoc_Load(object sender, EventArgs e)
        {
            this.dateFrom.Value = DateTime.Now;
            this.dateTo.Value = DateTime.Now;
            this.dateIssue.Value = DateTime.Now;
        }
    }
}
