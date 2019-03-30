namespace IT_Dept.PL
{
    partial class frmDocuments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDocuments));
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnTravelAss = new Telerik.WinControls.UI.RadButton();
            this.btnWS = new Telerik.WinControls.UI.RadButton();
            this.btnDayOff = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTravelAss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnWS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDayOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.btnDayOff);
            this.radGroupBox1.Controls.Add(this.btnTravelAss);
            this.radGroupBox1.Controls.Add(this.btnWS);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGroupBox1.HeaderText = "Documents";
            this.radGroupBox1.Location = new System.Drawing.Point(13, 13);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(619, 262);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Documents";
            // 
            // btnTravelAss
            // 
            this.btnTravelAss.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTravelAss.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTravelAss.Location = new System.Drawing.Point(144, 42);
            this.btnTravelAss.Name = "btnTravelAss";
            this.btnTravelAss.Size = new System.Drawing.Size(133, 57);
            this.btnTravelAss.TabIndex = 0;
            this.btnTravelAss.Text = "Travel Assignment";
            this.btnTravelAss.Click += new System.EventHandler(this.btnTravelAss_Click);
            // 
            // btnWS
            // 
            this.btnWS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWS.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnWS.Location = new System.Drawing.Point(5, 42);
            this.btnWS.Name = "btnWS";
            this.btnWS.Size = new System.Drawing.Size(133, 57);
            this.btnWS.TabIndex = 0;
            this.btnWS.Text = "Work Assignment";
            this.btnWS.Click += new System.EventHandler(this.btnWS_Click);
            // 
            // btnDayOff
            // 
            this.btnDayOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDayOff.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDayOff.Location = new System.Drawing.Point(283, 42);
            this.btnDayOff.Name = "btnDayOff";
            this.btnDayOff.Size = new System.Drawing.Size(133, 57);
            this.btnDayOff.TabIndex = 0;
            this.btnDayOff.Text = "DayOff";
            this.btnDayOff.Click += new System.EventHandler(this.btnDayOff_Click);
            // 
            // frmDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 281);
            this.Controls.Add(this.radGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDocuments";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documents";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmDocuments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnTravelAss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnWS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDayOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton btnWS;
        private Telerik.WinControls.UI.RadButton btnTravelAss;
        private Telerik.WinControls.UI.RadButton btnDayOff;
    }
}
