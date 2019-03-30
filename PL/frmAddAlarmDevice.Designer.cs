namespace IT_Dept.PL
{
    partial class frmAddAlarmDevice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddAlarmDevice));
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFire = new Telerik.WinControls.UI.RadTextBox();
            this.txtMotion = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.txtPwd = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.txtType = new Telerik.WinControls.UI.RadTextBox();
            this.lstCenters = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstCenters)).BeginInit();
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
            this.radGroupBox1.Controls.Add(this.txtFire);
            this.radGroupBox1.Controls.Add(this.txtMotion);
            this.radGroupBox1.Controls.Add(this.radLabel7);
            this.radGroupBox1.Controls.Add(this.txtPwd);
            this.radGroupBox1.Controls.Add(this.radLabel6);
            this.radGroupBox1.Controls.Add(this.radLabel5);
            this.radGroupBox1.Controls.Add(this.txtType);
            this.radGroupBox1.Controls.Add(this.lstCenters);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGroupBox1.HeaderText = "New";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(419, 238);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "New";
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::IT_Dept.Properties.Resources.uncheck;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(305, 183);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(47, 41);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::IT_Dept.Properties.Resources.save_as_icon_94967;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(358, 183);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(47, 41);
            this.btnSave.TabIndex = 5;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFire
            // 
            this.txtFire.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFire.Location = new System.Drawing.Point(144, 154);
            this.txtFire.Name = "txtFire";
            this.txtFire.Size = new System.Drawing.Size(261, 23);
            this.txtFire.TabIndex = 4;
            this.txtFire.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMotion
            // 
            this.txtMotion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMotion.Location = new System.Drawing.Point(144, 125);
            this.txtMotion.Name = "txtMotion";
            this.txtMotion.Size = new System.Drawing.Size(261, 23);
            this.txtMotion.TabIndex = 3;
            this.txtMotion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radLabel7
            // 
            this.radLabel7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel7.Location = new System.Drawing.Point(5, 155);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(120, 21);
            this.radLabel7.TabIndex = 0;
            this.radLabel7.Text = "Fire Sensors Count";
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPwd.Location = new System.Drawing.Point(144, 96);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(261, 23);
            this.txtPwd.TabIndex = 2;
            this.txtPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel6.Location = new System.Drawing.Point(5, 126);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(142, 21);
            this.radLabel6.TabIndex = 0;
            this.radLabel6.Text = "Motion Sensors Count";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel5.Location = new System.Drawing.Point(5, 97);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(64, 21);
            this.radLabel5.TabIndex = 0;
            this.radLabel5.Text = "Password";
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtType.Location = new System.Drawing.Point(144, 67);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(261, 23);
            this.txtType.TabIndex = 1;
            this.txtType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lstCenters
            // 
            this.lstCenters.AllowShowFocusCues = false;
            this.lstCenters.AutoCompleteDisplayMember = null;
            this.lstCenters.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.lstCenters.AutoCompleteValueMember = null;
            this.lstCenters.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstCenters.Location = new System.Drawing.Point(144, 38);
            this.lstCenters.Name = "lstCenters";
            this.lstCenters.Size = new System.Drawing.Size(261, 23);
            this.lstCenters.TabIndex = 0;
            this.lstCenters.Text = "radDropDownList1";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel2.Location = new System.Drawing.Point(5, 68);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(36, 21);
            this.radLabel2.TabIndex = 0;
            this.radLabel2.Text = "Type";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel1.Location = new System.Drawing.Point(5, 38);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(47, 21);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Center";
            // 
            // frmAddAlarmDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 262);
            this.Controls.Add(this.radGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAddAlarmDevice";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Alarm Device";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmAddAlarmDevice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstCenters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private Telerik.WinControls.UI.RadTextBox txtFire;
        private Telerik.WinControls.UI.RadTextBox txtMotion;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadTextBox txtPwd;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadTextBox txtType;
        private Telerik.WinControls.UI.RadDropDownList lstCenters;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}
