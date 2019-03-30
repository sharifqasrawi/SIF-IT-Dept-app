using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

using Microsoft.Office.Interop.Word;
using Microsoft.Office.Core;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace IT_Dept.PL
{
    public partial class frmCreateTravelAssignment : Telerik.WinControls.UI.RadForm
    {
        public frmCreateTravelAssignment()
        {
            InitializeComponent();
        }

        private void cbToDay_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if(cbToDay.Checked)
            {
                this.lstDaysTo.Enabled = true;
            }
            else
            {
                this.lstDaysTo.Enabled = false;
            }
        }

        private void cbToDate_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (cbToDate.Checked)
            {
                this.dateTo.Enabled = true;
            }
            else
            {
                this.dateTo.Enabled = false;
            }
        }

        private void cbToHour_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (cbToHour.Checked)
            {
                this.HourTo.Enabled = true;
            }
            else
            {
                this.HourTo.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

            Word.Application wordApp = new Word.Application();

            Word.Document aDoc = null;

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
                this.FindAndReplace(wordApp, "<Parm1>", txtEmp.Text);
                this.FindAndReplace(wordApp, "<Parm2>", txtJobDesc.Text);
                this.FindAndReplace(wordApp, "<Parm3>", txtAss.Text);
                this.FindAndReplace(wordApp, "<Parm4>", txtDesc.Text);
                this.FindAndReplace(wordApp, "<Parm5>", lstDaysFrom.SelectedItem.ToString());
                this.FindAndReplace(wordApp, "<Parm6>", dateFrom.Value.ToShortDateString());
                this.FindAndReplace(wordApp, "<Parm7>", timeFrom.Value.Value.ToShortTimeString());
                if (cbToDay.Checked)
                {
                    this.FindAndReplace(wordApp, "<Parm8>", lstDaysTo.SelectedItem.ToString());
                }
                else
                {
                    this.FindAndReplace(wordApp, "<Parm8>", "");
                }
                if (cbToDate.Checked)
                {
                    this.FindAndReplace(wordApp, "<Parm9>", dateTo.Value.ToShortDateString());
                }
                else
                {
                    this.FindAndReplace(wordApp, "<Parm9>", "");
                }
                if (cbToHour.Checked)
                {
                    this.FindAndReplace(wordApp, "<Parm10>", HourTo.Value.Value.ToShortTimeString());
                }
                else
                {
                    this.FindAndReplace(wordApp, "<Parm10>", "");
                }
                this.FindAndReplace(wordApp, "<Parm11>", txtBoss.Text);
                this.FindAndReplace(wordApp, "<Parm12>", IssueDate.Value.ToShortDateString());


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




        private void btnSave_Click(object sender, EventArgs e)
        {
            CreateWordDocument(System.Windows.Forms.Application.StartupPath + "/Documents/Travel.doc", System.Windows.Forms.Application.StartupPath + "/Created_Documents/Travel_Assignments/مهمة سفر - " + txtEmp.Text);
            Process.Start(System.Windows.Forms.Application.StartupPath + "/Created_Documents/Travel_Assignments");
        }

        private void frmCreateTravelAssignment_Load(object sender, EventArgs e)
        {

        }
    }
}
