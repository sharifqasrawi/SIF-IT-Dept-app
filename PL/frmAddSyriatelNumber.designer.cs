namespace IT_Dept.PL
{
    partial class frmAddSyriatelNumber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddSyriatelNumber));
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.cbActive = new Telerik.WinControls.UI.RadCheckBox();
            this.radDateTimePicker1 = new Telerik.WinControls.UI.RadDateTimePicker();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.txtLimit = new Telerik.WinControls.UI.RadTextBox();
            this.txtSyrNumber = new Telerik.WinControls.UI.RadTextBox();
            this.txtEmpName = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.txtPin = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSyrNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.cbActive);
            this.radGroupBox1.Controls.Add(this.radDateTimePicker1);
            this.radGroupBox1.Controls.Add(this.btnCancel);
            this.radGroupBox1.Controls.Add(this.btnSave);
            this.radGroupBox1.Controls.Add(this.txtPin);
            this.radGroupBox1.Controls.Add(this.txtLimit);
            this.radGroupBox1.Controls.Add(this.txtSyrNumber);
            this.radGroupBox1.Controls.Add(this.txtEmpName);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Controls.Add(this.radLabel5);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGroupBox1.HeaderText = "Fill";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(315, 320);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "Fill";
            // 
            // cbActive
            // 
            this.cbActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbActive.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbActive.Location = new System.Drawing.Point(252, 251);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(58, 21);
            this.cbActive.TabIndex = 5;
            this.cbActive.Text = "Active";
            this.cbActive.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // radDateTimePicker1
            // 
            this.radDateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radDateTimePicker1.Location = new System.Drawing.Point(122, 222);
            this.radDateTimePicker1.Name = "radDateTimePicker1";
            this.radDateTimePicker1.Size = new System.Drawing.Size(188, 23);
            this.radDateTimePicker1.TabIndex = 4;
            this.radDateTimePicker1.TabStop = false;
            this.radDateTimePicker1.Text = "Tuesday, March 7, 2017";
            this.radDateTimePicker1.Value = new System.DateTime(2017, 3, 7, 14, 31, 16, 934);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(122, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 24);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(212, 287);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 24);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtLimit
            // 
            this.txtLimit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLimit.Location = new System.Drawing.Point(122, 138);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(188, 23);
            this.txtLimit.TabIndex = 2;
            this.txtLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSyrNumber
            // 
            this.txtSyrNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSyrNumber.Location = new System.Drawing.Point(122, 93);
            this.txtSyrNumber.Name = "txtSyrNumber";
            this.txtSyrNumber.Size = new System.Drawing.Size(188, 23);
            this.txtSyrNumber.TabIndex = 1;
            this.txtSyrNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmpName.Location = new System.Drawing.Point(122, 46);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(188, 23);
            this.txtEmpName.TabIndex = 0;
            this.txtEmpName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel4.Location = new System.Drawing.Point(5, 223);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(35, 21);
            this.radLabel4.TabIndex = 0;
            this.radLabel4.Text = "Date";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel3.Location = new System.Drawing.Point(5, 138);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(65, 21);
            this.radLabel3.TabIndex = 0;
            this.radLabel3.Text = "Calls limit";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel2.Location = new System.Drawing.Point(5, 94);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(102, 21);
            this.radLabel2.TabIndex = 0;
            this.radLabel2.Text = "Syriatel number";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel1.Location = new System.Drawing.Point(5, 47);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(104, 21);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Employee name";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel5.Location = new System.Drawing.Point(5, 179);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(52, 21);
            this.radLabel5.TabIndex = 0;
            this.radLabel5.Text = "Sim Pin";
            // 
            // txtPin
            // 
            this.txtPin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPin.Location = new System.Drawing.Point(122, 179);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(188, 23);
            this.txtPin.TabIndex = 3;
            this.txtPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmAddSyriatelNumber
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(343, 344);
            this.Controls.Add(this.radGroupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddSyriatelNumber";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Number";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmAddSyriatelNumber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSyrNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadTextBox txtSyrNumber;
        private Telerik.WinControls.UI.RadTextBox txtEmpName;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePicker1;
        private Telerik.WinControls.UI.RadTextBox txtLimit;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadCheckBox cbActive;
        private Telerik.WinControls.UI.RadTextBox txtPin;
        private Telerik.WinControls.UI.RadLabel radLabel5;
    }
}
