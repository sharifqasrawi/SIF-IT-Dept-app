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
    public partial class frmCreateWorkAssignmentDoc : Telerik.WinControls.UI.RadForm
    {
        public frmCreateWorkAssignmentDoc()
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
                this.FindAndReplace(wordApp, "<Name>", txtEmp.Text);
                this.FindAndReplace(wordApp, "<Job>", txtJobDesc.Text);
                this.FindAndReplace(wordApp, "<Mission>", txtAss.Text);
                this.FindAndReplace(wordApp, "<Desc>", txtDesc.Text);
                this.FindAndReplace(wordApp, "<Day>", lstDays.SelectedItem.ToString());
                this.FindAndReplace(wordApp, "<FromHour>", timeFrom.Value.Value.ToShortTimeString());
                if (cbTo.Checked)
                {
                    this.FindAndReplace(wordApp, "<ToHour>", timeTo.Value.Value.ToShortTimeString());
                }
                else
                {
                    this.FindAndReplace(wordApp, "<ToHour>", "");
                }
                this.FindAndReplace(wordApp, "<MDate>", dateTo.Value.ToShortDateString());
                this.FindAndReplace(wordApp, "<Source>", txtBoss.Text);
                this.FindAndReplace(wordApp, "<Date>", radDateTimePicker1.Value.ToShortDateString());


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
            clsWorkAssignment w = new clsWorkAssignment(txtEmp.Text, txtJobDesc.Text, txtAss.Text, txtDesc.Text, lstDays.SelectedItem.ToString(), timeFrom.Value.Value, timeTo.Value.Value, dateTo.Value, radDateTimePicker1.Value, txtBoss.Text);
            w.Add();

            
            SaveFileDialog SaveDoc = new SaveFileDialog();
            SaveDoc.Filter = "Word doc (*.doc) |*.doc";

            CreateWordDocument(System.Windows.Forms.Application.StartupPath + "/Documents/WASS.doc", System.Windows.Forms.Application.StartupPath + "/Created_Documents/Work_Assignments/مهمة عمل - " + txtEmp.Text);
            Process.Start(System.Windows.Forms.Application.StartupPath + "/Created_Documents/Work_Assignments");
            //printDocument1.DocumentName = SaveDoc.FileName;

            
        }

        private void cbTo_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if(cbTo.Checked)
            {
                this.timeTo.Enabled = true;

            }
            else
            {
                this.timeTo.Enabled = false;
            }
        }

        private void frmCreateWorkAssignmentDoc_Load(object sender, EventArgs e)
        {

        }
    }
}
