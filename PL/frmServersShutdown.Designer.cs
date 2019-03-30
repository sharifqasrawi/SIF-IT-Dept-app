namespace IT_Dept.PL
{
    partial class frmServersShutdown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServersShutdown));
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.lstServers = new Telerik.WinControls.UI.RadListView();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstServers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.btnShutdown);
            this.radGroupBox1.Controls.Add(this.lstServers);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGroupBox1.HeaderText = "Servers Shutdown";
            this.radGroupBox1.Location = new System.Drawing.Point(13, 13);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(594, 330);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Servers Shutdown";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabel1.Location = new System.Drawing.Point(6, 34);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(169, 21);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Select servers to shutdown";
            // 
            // lstServers
            // 
            this.lstServers.AllowColumnReorder = false;
            this.lstServers.AllowColumnResize = false;
            this.lstServers.AllowEdit = false;
            this.lstServers.AllowRemove = false;
            this.lstServers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstServers.Location = new System.Drawing.Point(6, 61);
            this.lstServers.MultiSelect = true;
            this.lstServers.Name = "lstServers";
            this.lstServers.ShowCheckBoxes = true;
            this.lstServers.Size = new System.Drawing.Size(583, 164);
            this.lstServers.TabIndex = 4;
            this.lstServers.Text = "radListView1";
            this.lstServers.SelectedItemChanged += new System.EventHandler(this.lstServers_SelectedItemChanged);
            this.lstServers.ItemCheckedChanged += new Telerik.WinControls.UI.ListViewItemEventHandler(this.lstServers_ItemCheckedChanged);
            // 
            // btnShutdown
            // 
            this.btnShutdown.BackgroundImage = global::IT_Dept.Properties.Resources.Shut_Down_Setting_in_Windows_8;
            this.btnShutdown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShutdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShutdown.Location = new System.Drawing.Point(486, 231);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(100, 93);
            this.btnShutdown.TabIndex = 5;
            this.btnShutdown.UseVisualStyleBackColor = true;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Ravie", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(6, 252);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(317, 79);
            this.radLabel2.TabIndex = 6;
            this.radLabel2.Text = "Servers";
            // 
            // frmServersShutdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 355);
            this.Controls.Add(this.radGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmServersShutdown";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote SIF Servers Shutdown";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmServersShutdown_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstServers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadListView lstServers;
        private System.Windows.Forms.Button btnShutdown;
        private Telerik.WinControls.UI.RadLabel radLabel2;
    }
}
