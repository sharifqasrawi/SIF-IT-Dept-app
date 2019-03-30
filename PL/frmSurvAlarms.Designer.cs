namespace IT_Dept.PL
{
    partial class frmSurvAlarms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSurvAlarms));
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnAlarm = new Telerik.WinControls.UI.RadButton();
            this.btnSur = new Telerik.WinControls.UI.RadButton();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.lblMsg = new Telerik.WinControls.UI.RadLabelElement();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.pnlAlarms = new System.Windows.Forms.Panel();
            this.alarmsGridView = new Telerik.WinControls.UI.RadGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alarmEmergencyNumbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlSurv = new System.Windows.Forms.Panel();
            this.SurvGridView = new Telerik.WinControls.UI.RadGridView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            this.pnlAlarms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alarmsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmsGridView.MasterTemplate)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnlSurv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SurvGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SurvGridView.MasterTemplate)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox1.Controls.Add(this.btnAlarm);
            this.radGroupBox1.Controls.Add(this.btnSur);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGroupBox1.HeaderText = "Navigation";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 26);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(935, 76);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Navigation";
            // 
            // btnAlarm
            // 
            this.btnAlarm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlarm.Enabled = false;
            this.btnAlarm.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAlarm.Location = new System.Drawing.Point(466, 34);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Size = new System.Drawing.Size(464, 29);
            this.btnAlarm.TabIndex = 0;
            this.btnAlarm.Text = "Alarm";
            this.btnAlarm.Click += new System.EventHandler(this.btnAlarm_Click);
            // 
            // btnSur
            // 
            this.btnSur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSur.Enabled = false;
            this.btnSur.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSur.Location = new System.Drawing.Point(6, 34);
            this.btnSur.Name = "btnSur";
            this.btnSur.Size = new System.Drawing.Size(454, 29);
            this.btnSur.TabIndex = 0;
            this.btnSur.Text = "Surveillance";
            this.btnSur.Click += new System.EventHandler(this.btnSur_Click);
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(959, 20);
            this.radMenu1.TabIndex = 1;
            this.radMenu1.Text = "radMenu1";
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.AccessibleDescription = "File";
            this.radMenuItem1.AccessibleName = "File";
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "File";
            this.radMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lblMsg});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 496);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(959, 24);
            this.radStatusStrip1.TabIndex = 2;
            this.radStatusStrip1.Text = "radStatusStrip1";
            // 
            // lblMsg
            // 
            this.lblMsg.Name = "lblMsg";
            this.radStatusStrip1.SetSpring(this.lblMsg, false);
            this.lblMsg.Text = "";
            this.lblMsg.TextWrap = true;
            this.lblMsg.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGroupBox2.Controls.Add(this.pnlSurv);
            this.radGroupBox2.Controls.Add(this.pnlAlarms);
            this.radGroupBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGroupBox2.HeaderText = "";
            this.radGroupBox2.Location = new System.Drawing.Point(12, 108);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(935, 382);
            this.radGroupBox2.TabIndex = 3;
            // 
            // pnlAlarms
            // 
            this.pnlAlarms.Controls.Add(this.alarmsGridView);
            this.pnlAlarms.Controls.Add(this.menuStrip1);
            this.pnlAlarms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAlarms.Location = new System.Drawing.Point(2, 18);
            this.pnlAlarms.Name = "pnlAlarms";
            this.pnlAlarms.Size = new System.Drawing.Size(931, 362);
            this.pnlAlarms.TabIndex = 1;
            // 
            // alarmsGridView
            // 
            this.alarmsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alarmsGridView.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.alarmsGridView.Location = new System.Drawing.Point(4, 27);
            // 
            // alarmsGridView
            // 
            this.alarmsGridView.MasterTemplate.AllowAddNewRow = false;
            this.alarmsGridView.MasterTemplate.AllowRowResize = false;
            this.alarmsGridView.MasterTemplate.AllowSearchRow = true;
            this.alarmsGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.alarmsGridView.MasterTemplate.EnableAlternatingRowColor = true;
            this.alarmsGridView.MasterTemplate.EnableFiltering = true;
            this.alarmsGridView.MasterTemplate.EnablePaging = true;
            this.alarmsGridView.MasterTemplate.PageSize = 30;
            this.alarmsGridView.Name = "alarmsGridView";
            this.alarmsGridView.ReadOnly = true;
            // 
            // 
            // 
            this.alarmsGridView.RootElement.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.alarmsGridView.RootElement.FlipText = false;
            this.alarmsGridView.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            this.alarmsGridView.Size = new System.Drawing.Size(924, 332);
            this.alarmsGridView.TabIndex = 1;
            this.alarmsGridView.Text = "radGridView1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.alarmEmergencyNumbersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(931, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Enabled = false;
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Enabled = false;
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Enabled = false;
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // alarmEmergencyNumbersToolStripMenuItem
            // 
            this.alarmEmergencyNumbersToolStripMenuItem.Enabled = false;
            this.alarmEmergencyNumbersToolStripMenuItem.Name = "alarmEmergencyNumbersToolStripMenuItem";
            this.alarmEmergencyNumbersToolStripMenuItem.Size = new System.Drawing.Size(165, 20);
            this.alarmEmergencyNumbersToolStripMenuItem.Text = "Alarm Emergency Numbers";
            this.alarmEmergencyNumbersToolStripMenuItem.Click += new System.EventHandler(this.alarmEmergencyNumbersToolStripMenuItem_Click);
            // 
            // pnlSurv
            // 
            this.pnlSurv.Controls.Add(this.SurvGridView);
            this.pnlSurv.Controls.Add(this.menuStrip2);
            this.pnlSurv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSurv.Location = new System.Drawing.Point(2, 18);
            this.pnlSurv.Name = "pnlSurv";
            this.pnlSurv.Size = new System.Drawing.Size(931, 362);
            this.pnlSurv.TabIndex = 0;
            // 
            // SurvGridView
            // 
            this.SurvGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SurvGridView.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SurvGridView.Location = new System.Drawing.Point(4, 27);
            // 
            // SurvGridView
            // 
            this.SurvGridView.MasterTemplate.AllowAddNewRow = false;
            this.SurvGridView.MasterTemplate.AllowRowResize = false;
            this.SurvGridView.MasterTemplate.AllowSearchRow = true;
            this.SurvGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.SurvGridView.MasterTemplate.EnableAlternatingRowColor = true;
            this.SurvGridView.MasterTemplate.EnableFiltering = true;
            this.SurvGridView.MasterTemplate.EnablePaging = true;
            this.SurvGridView.MasterTemplate.PageSize = 30;
            this.SurvGridView.Name = "SurvGridView";
            this.SurvGridView.ReadOnly = true;
            // 
            // 
            // 
            this.SurvGridView.RootElement.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.SurvGridView.RootElement.FlipText = false;
            this.SurvGridView.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            this.SurvGridView.Size = new System.Drawing.Size(924, 334);
            this.SurvGridView.TabIndex = 3;
            this.SurvGridView.Text = "radGridView1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(931, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Options";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Enabled = false;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Enabled = false;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // frmSurvAlarms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 520);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.radMenu1);
            this.Controls.Add(this.radGroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSurvAlarms";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarms & Surveillance";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmSurvAlarms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAlarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.pnlAlarms.ResumeLayout(false);
            this.pnlAlarms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alarmsGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmsGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlSurv.ResumeLayout(false);
            this.pnlSurv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SurvGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SurvGridView)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton btnAlarm;
        private Telerik.WinControls.UI.RadButton btnSur;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private System.Windows.Forms.Panel pnlSurv;
        private System.Windows.Forms.Panel pnlAlarms;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        public Telerik.WinControls.UI.RadGridView SurvGridView;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        public Telerik.WinControls.UI.RadGridView alarmsGridView;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        public Telerik.WinControls.UI.RadLabelElement lblMsg;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alarmEmergencyNumbersToolStripMenuItem;
    }
}
