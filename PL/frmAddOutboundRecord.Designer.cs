namespace IT_Dept.PL
{
    partial class frmAddOutboundRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddOutboundRecord));
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.txtDesc = new Telerik.WinControls.UI.RadTextBox();
            this.txtNotes = new Telerik.WinControls.UI.RadTextBox();
            this.txtDest = new Telerik.WinControls.UI.RadTextBox();
            this.radDateTimePickerAnswerDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radDateTimePickerSendDate = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePickerAnswerDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePickerSendDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
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
            this.radGroupBox1.Controls.Add(this.txtDesc);
            this.radGroupBox1.Controls.Add(this.txtNotes);
            this.radGroupBox1.Controls.Add(this.txtDest);
            this.radGroupBox1.Controls.Add(this.radDateTimePickerAnswerDate);
            this.radGroupBox1.Controls.Add(this.radDateTimePickerSendDate);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.radLabel5);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGroupBox1.HeaderText = "Fill";
            this.radGroupBox1.Location = new System.Drawing.Point(13, 13);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(656, 308);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Fill";
            // 
            // txtDesc
            // 
            this.txtDesc.AcceptsReturn = true;
            this.txtDesc.AutoSize = false;
            this.txtDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDesc.Location = new System.Drawing.Point(88, 171);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(216, 132);
            this.txtDesc.TabIndex = 2;
            this.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNotes
            // 
            this.txtNotes.AcceptsReturn = true;
            this.txtNotes.AutoSize = false;
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNotes.Location = new System.Drawing.Point(437, 83);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(211, 161);
            this.txtNotes.TabIndex = 4;
            this.txtNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDest
            // 
            this.txtDest.AcceptsReturn = true;
            this.txtDest.AutoSize = false;
            this.txtDest.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDest.Location = new System.Drawing.Point(88, 70);
            this.txtDest.Multiline = true;
            this.txtDest.Name = "txtDest";
            this.txtDest.Size = new System.Drawing.Size(216, 95);
            this.txtDest.TabIndex = 1;
            this.txtDest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radDateTimePickerAnswerDate
            // 
            this.radDateTimePickerAnswerDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radDateTimePickerAnswerDate.Location = new System.Drawing.Point(437, 30);
            this.radDateTimePickerAnswerDate.Name = "radDateTimePickerAnswerDate";
            this.radDateTimePickerAnswerDate.Size = new System.Drawing.Size(214, 23);
            this.radDateTimePickerAnswerDate.TabIndex = 3;
            this.radDateTimePickerAnswerDate.TabStop = false;
            this.radDateTimePickerAnswerDate.Text = "Tuesday, March 21, 2017";
            this.radDateTimePickerAnswerDate.Value = new System.DateTime(2017, 3, 21, 21, 30, 13, 543);
            // 
            // radDateTimePickerSendDate
            // 
            this.radDateTimePickerSendDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radDateTimePickerSendDate.Location = new System.Drawing.Point(88, 30);
            this.radDateTimePickerSendDate.Name = "radDateTimePickerSendDate";
            this.radDateTimePickerSendDate.Size = new System.Drawing.Size(216, 23);
            this.radDateTimePickerSendDate.TabIndex = 0;
            this.radDateTimePickerSendDate.TabStop = false;
            this.radDateTimePickerSendDate.Text = "Tuesday, March 21, 2017";
            this.radDateTimePickerSendDate.Value = new System.DateTime(2017, 3, 21, 21, 30, 13, 543);
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel4.Location = new System.Drawing.Point(349, 31);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(82, 21);
            this.radLabel4.TabIndex = 0;
            this.radLabel4.Text = "Answer date";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel3.Location = new System.Drawing.Point(5, 171);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(76, 21);
            this.radLabel3.TabIndex = 0;
            this.radLabel3.Text = "Description";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel5.Location = new System.Drawing.Point(349, 83);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(43, 21);
            this.radLabel5.TabIndex = 0;
            this.radLabel5.Text = "Notes";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel2.Location = new System.Drawing.Point(5, 70);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(76, 21);
            this.radLabel2.TabIndex = 0;
            this.radLabel2.Text = "Destination";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel1.Location = new System.Drawing.Point(5, 31);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(68, 21);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Send date";
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::IT_Dept.Properties.Resources.save_as_icon_94967;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(601, 262);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(47, 41);
            this.btnSave.TabIndex = 5;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::IT_Dept.Properties.Resources.uncheck;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(548, 262);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(47, 41);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddOutboundRecord
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(683, 344);
            this.Controls.Add(this.radGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddOutboundRecord";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Outbound Record";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmAddOutboundRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePickerAnswerDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radDateTimePickerSendDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadTextBox txtDesc;
        private Telerik.WinControls.UI.RadTextBox txtDest;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePickerAnswerDate;
        private Telerik.WinControls.UI.RadDateTimePicker radDateTimePickerSendDate;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtNotes;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}
