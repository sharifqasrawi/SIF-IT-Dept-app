namespace IT_Dept.PL
{
    partial class frmRolesDesc
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
            this.RolesGridView = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.RolesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RolesGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // RolesGridView
            // 
            this.RolesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RolesGridView.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RolesGridView.Location = new System.Drawing.Point(0, 0);
            // 
            // RolesGridView
            // 
            this.RolesGridView.MasterTemplate.AllowAddNewRow = false;
            this.RolesGridView.MasterTemplate.AllowRowResize = false;
            this.RolesGridView.MasterTemplate.AllowSearchRow = true;
            this.RolesGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.RolesGridView.MasterTemplate.EnableAlternatingRowColor = true;
            this.RolesGridView.MasterTemplate.EnableFiltering = true;
            this.RolesGridView.MasterTemplate.EnablePaging = true;
            this.RolesGridView.MasterTemplate.PageSize = 40;
            this.RolesGridView.Name = "RolesGridView";
            this.RolesGridView.ReadOnly = true;
            // 
            // 
            // 
            this.RolesGridView.RootElement.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.RolesGridView.RootElement.FlipText = false;
            this.RolesGridView.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            this.RolesGridView.Size = new System.Drawing.Size(906, 421);
            this.RolesGridView.TabIndex = 6;
            this.RolesGridView.Text = "radGridView1";
            // 
            // frmRolesDesc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 421);
            this.Controls.Add(this.RolesGridView);
            this.Name = "frmRolesDesc";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roles Description";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmRolesDesc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RolesGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RolesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Telerik.WinControls.UI.RadGridView RolesGridView;
    }
}
