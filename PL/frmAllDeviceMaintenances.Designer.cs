namespace IT_Dept.PL
{
    partial class frmAllDeviceMaintenances
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAllDeviceMaintenances));
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.allMaintGridView = new Telerik.WinControls.UI.RadGridView();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allMaintGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allMaintGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 495);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(970, 24);
            this.radStatusStrip1.TabIndex = 7;
            this.radStatusStrip1.Text = "radStatusStrip1";
            // 
            // allMaintGridView
            // 
            this.allMaintGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allMaintGridView.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.allMaintGridView.Location = new System.Drawing.Point(0, 26);
            // 
            // allMaintGridView
            // 
            this.allMaintGridView.MasterTemplate.AllowAddNewRow = false;
            this.allMaintGridView.MasterTemplate.AllowRowResize = false;
            this.allMaintGridView.MasterTemplate.AllowSearchRow = true;
            this.allMaintGridView.MasterTemplate.EnableAlternatingRowColor = true;
            this.allMaintGridView.MasterTemplate.EnableFiltering = true;
            this.allMaintGridView.MasterTemplate.EnablePaging = true;
            this.allMaintGridView.Name = "allMaintGridView";
            this.allMaintGridView.ReadOnly = true;
            // 
            // 
            // 
            this.allMaintGridView.RootElement.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.allMaintGridView.RootElement.FlipText = false;
            this.allMaintGridView.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            this.allMaintGridView.Size = new System.Drawing.Size(973, 463);
            this.allMaintGridView.TabIndex = 8;
            this.allMaintGridView.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.allMaintGridView_CellDoubleClick);
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(970, 20);
            this.radMenu1.TabIndex = 6;
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
            // frmAllDeviceMaintenances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 519);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.allMaintGridView);
            this.Controls.Add(this.radMenu1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAllDeviceMaintenances";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Device Maintenances";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allMaintGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allMaintGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        public Telerik.WinControls.UI.RadGridView allMaintGridView;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
    }
}
