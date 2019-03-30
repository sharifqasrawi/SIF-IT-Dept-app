namespace IT_Dept.PL
{
    partial class frmMaintenanceTrack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaintenanceTrack));
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.MaintGridView = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaintGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaintGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(947, 20);
            this.radMenu1.TabIndex = 0;
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
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 479);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(947, 24);
            this.radStatusStrip1.TabIndex = 1;
            this.radStatusStrip1.Text = "radStatusStrip1";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.MaintGridView);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.HeaderText = "Maintenance Tracking";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 20);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(947, 459);
            this.radGroupBox1.TabIndex = 2;
            this.radGroupBox1.Text = "Maintenance Tracking";
            // 
            // MaintGridView
            // 
            this.MaintGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaintGridView.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MaintGridView.Location = new System.Drawing.Point(2, 18);
            // 
            // MaintGridView
            // 
            this.MaintGridView.MasterTemplate.AllowAddNewRow = false;
            this.MaintGridView.MasterTemplate.AllowRowResize = false;
            this.MaintGridView.MasterTemplate.AllowSearchRow = true;
            this.MaintGridView.MasterTemplate.EnableAlternatingRowColor = true;
            this.MaintGridView.MasterTemplate.EnableFiltering = true;
            this.MaintGridView.MasterTemplate.EnablePaging = true;
            this.MaintGridView.MasterTemplate.PageSize = 40;
            this.MaintGridView.MasterTemplate.ShowGroupedColumns = true;
            this.MaintGridView.Name = "MaintGridView";
            this.MaintGridView.ReadOnly = true;
            // 
            // 
            // 
            this.MaintGridView.RootElement.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.MaintGridView.RootElement.FlipText = false;
            this.MaintGridView.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            this.MaintGridView.Size = new System.Drawing.Size(943, 439);
            this.MaintGridView.TabIndex = 6;
            // 
            // frmMaintenanceTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 503);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.radMenu1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMaintenanceTrack";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Track Maintenance";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmMaintenanceTrack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MaintGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaintGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        public Telerik.WinControls.UI.RadGridView MaintGridView;
    }
}
