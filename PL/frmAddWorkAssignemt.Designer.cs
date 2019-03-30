namespace IT_Dept.PL
{
    partial class frmAddWorkAssignemt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddWorkAssignemt));
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.timeTo = new Telerik.WinControls.UI.RadTimePicker();
            this.timeFrom = new Telerik.WinControls.UI.RadTimePicker();
            this.dateTo = new Telerik.WinControls.UI.RadDateTimePicker();
            this.dateFrom = new Telerik.WinControls.UI.RadDateTimePicker();
            this.txtDesc = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.lstCenters = new Telerik.WinControls.UI.RadDropDownList();
            this.txtJobDesc = new Telerik.WinControls.UI.RadTextBox();
            this.txtEmp = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstCenters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJobDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.btnCancel);
            this.radGroupBox1.Controls.Add(this.btnSave);
            this.radGroupBox1.Controls.Add(this.timeTo);
            this.radGroupBox1.Controls.Add(this.timeFrom);
            this.radGroupBox1.Controls.Add(this.dateTo);
            this.radGroupBox1.Controls.Add(this.dateFrom);
            this.radGroupBox1.Controls.Add(this.txtDesc);
            this.radGroupBox1.Controls.Add(this.radLabel5);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.lstCenters);
            this.radGroupBox1.Controls.Add(this.txtJobDesc);
            this.radGroupBox1.Controls.Add(this.txtEmp);
            this.radGroupBox1.Controls.Add(this.radLabel6);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGroupBox1.HeaderText = "New work assignment";
            this.radGroupBox1.Location = new System.Drawing.Point(13, 13);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(407, 415);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "New work assignment";
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::IT_Dept.Properties.Resources.uncheck;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(302, 368);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(47, 41);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::IT_Dept.Properties.Resources.save_as_icon_94967;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(355, 368);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(47, 41);
            this.btnSave.TabIndex = 8;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // timeTo
            // 
            this.timeTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.timeTo.Location = new System.Drawing.Point(286, 320);
            this.timeTo.Name = "timeTo";
            this.timeTo.Size = new System.Drawing.Size(99, 23);
            this.timeTo.TabIndex = 7;
            this.timeTo.TabStop = false;
            this.timeTo.Text = "radTimePicker1";
            this.timeTo.Value = new System.DateTime(2017, 3, 12, 21, 19, 8, 632);
            // 
            // timeFrom
            // 
            this.timeFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.timeFrom.Location = new System.Drawing.Point(286, 284);
            this.timeFrom.Name = "timeFrom";
            this.timeFrom.Size = new System.Drawing.Size(99, 23);
            this.timeFrom.TabIndex = 5;
            this.timeFrom.TabStop = false;
            this.timeFrom.Text = "radTimePicker1";
            this.timeFrom.Value = new System.DateTime(2017, 3, 12, 21, 19, 8, 632);
            // 
            // dateTo
            // 
            this.dateTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateTo.Location = new System.Drawing.Point(115, 320);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(165, 23);
            this.dateTo.TabIndex = 6;
            this.dateTo.TabStop = false;
            this.dateTo.Text = "Sunday, March 12, 2017";
            this.dateTo.Value = new System.DateTime(2017, 3, 12, 21, 18, 44, 669);
            // 
            // dateFrom
            // 
            this.dateFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateFrom.Location = new System.Drawing.Point(115, 284);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(165, 23);
            this.dateFrom.TabIndex = 4;
            this.dateFrom.TabStop = false;
            this.dateFrom.Text = "Sunday, March 12, 2017";
            this.dateFrom.Value = new System.DateTime(2017, 3, 12, 21, 18, 44, 669);
            // 
            // txtDesc
            // 
            this.txtDesc.AutoSize = false;
            this.txtDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDesc.Location = new System.Drawing.Point(115, 130);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(270, 148);
            this.txtDesc.TabIndex = 3;
            this.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel5.Location = new System.Drawing.Point(5, 321);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(22, 21);
            this.radLabel5.TabIndex = 2;
            this.radLabel5.Text = "To";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel4.Location = new System.Drawing.Point(5, 285);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(38, 21);
            this.radLabel4.TabIndex = 2;
            this.radLabel4.Text = "From";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel3.Location = new System.Drawing.Point(5, 131);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(76, 21);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "Description";
            // 
            // lstCenters
            // 
            this.lstCenters.AllowShowFocusCues = false;
            this.lstCenters.AutoCompleteDisplayMember = null;
            this.lstCenters.AutoCompleteValueMember = null;
            this.lstCenters.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.lstCenters.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstCenters.Location = new System.Drawing.Point(115, 101);
            this.lstCenters.Name = "lstCenters";
            this.lstCenters.Size = new System.Drawing.Size(270, 23);
            this.lstCenters.TabIndex = 2;
            this.lstCenters.Text = "radDropDownList1";
            // 
            // txtJobDesc
            // 
            this.txtJobDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtJobDesc.Location = new System.Drawing.Point(115, 72);
            this.txtJobDesc.Name = "txtJobDesc";
            this.txtJobDesc.Size = new System.Drawing.Size(270, 23);
            this.txtJobDesc.TabIndex = 1;
            this.txtJobDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmp
            // 
            this.txtEmp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmp.Location = new System.Drawing.Point(115, 43);
            this.txtEmp.Name = "txtEmp";
            this.txtEmp.Size = new System.Drawing.Size(270, 23);
            this.txtEmp.TabIndex = 0;
            this.txtEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel6.Location = new System.Drawing.Point(5, 73);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(101, 21);
            this.radLabel6.TabIndex = 0;
            this.radLabel6.Text = "Job Description";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel2.Location = new System.Drawing.Point(5, 101);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(47, 21);
            this.radLabel2.TabIndex = 0;
            this.radLabel2.Text = "Center";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel1.Location = new System.Drawing.Point(5, 44);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(104, 21);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Employee name";
            // 
            // frmAddWorkAssignemt
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(434, 434);
            this.Controls.Add(this.radGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddWorkAssignemt";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Work Assignment";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmAddWorkAssignemt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstCenters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJobDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadTimePicker timeTo;
        private Telerik.WinControls.UI.RadTimePicker timeFrom;
        private Telerik.WinControls.UI.RadDateTimePicker dateTo;
        private Telerik.WinControls.UI.RadDateTimePicker dateFrom;
        private Telerik.WinControls.UI.RadTextBox txtDesc;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadDropDownList lstCenters;
        private Telerik.WinControls.UI.RadTextBox txtEmp;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private Telerik.WinControls.UI.RadTextBox txtJobDesc;
        private Telerik.WinControls.UI.RadLabel radLabel6;
    }
}
