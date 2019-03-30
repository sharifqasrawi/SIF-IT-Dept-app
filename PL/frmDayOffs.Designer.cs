namespace IT_Dept.PL
{
    partial class frmDayOffs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDayOffs));
            this.offsGridView = new Telerik.WinControls.UI.RadGridView();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.BtnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.lblMsg = new Telerik.WinControls.UI.RadLabelElement();
            ((System.ComponentModel.ISupportInitialize)(this.offsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // offsGridView
            // 
            this.offsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.offsGridView.EnableFastScrolling = true;
            this.offsGridView.EnableKineticScrolling = true;
            this.offsGridView.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.offsGridView.Location = new System.Drawing.Point(12, 26);
            // 
            // offsGridView
            // 
            this.offsGridView.MasterTemplate.AllowAddNewRow = false;
            this.offsGridView.MasterTemplate.AllowRowResize = false;
            this.offsGridView.MasterTemplate.AllowSearchRow = true;
            this.offsGridView.MasterTemplate.EnableAlternatingRowColor = true;
            this.offsGridView.MasterTemplate.EnableFiltering = true;
            this.offsGridView.MasterTemplate.EnablePaging = true;
            this.offsGridView.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow;
            this.offsGridView.MasterTemplate.PageSize = 30;
            this.offsGridView.Name = "offsGridView";
            this.offsGridView.ReadOnly = true;
            // 
            // 
            // 
            this.offsGridView.RootElement.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.offsGridView.RootElement.FlipText = false;
            this.offsGridView.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            this.offsGridView.Size = new System.Drawing.Size(863, 346);
            this.offsGridView.TabIndex = 30;
            this.offsGridView.Text = "radGridView1";
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(887, 20);
            this.radMenu1.TabIndex = 29;
            this.radMenu1.Text = "radMenu1";
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.AccessibleDescription = "ملف";
            this.radMenuItem1.AccessibleName = "ملف";
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "File";
            this.radMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.BtnNew);
            this.radGroupBox2.Controls.Add(this.btnDelete);
            this.radGroupBox2.Controls.Add(this.btnEdit);
            this.radGroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radGroupBox2.HeaderText = "Management";
            this.radGroupBox2.Location = new System.Drawing.Point(0, 378);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(887, 70);
            this.radGroupBox2.TabIndex = 27;
            this.radGroupBox2.Text = "Management";
            // 
            // BtnNew
            // 
            this.BtnNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnNew.BackColor = System.Drawing.Color.Transparent;
            this.BtnNew.BackgroundImage = global::IT_Dept.Properties.Resources._new;
            this.BtnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNew.Enabled = false;
            this.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnNew.Location = new System.Drawing.Point(318, 21);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(47, 44);
            this.BtnNew.TabIndex = 10;
            this.BtnNew.UseVisualStyleBackColor = false;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = global::IT_Dept.Properties.Resources.delete2;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(505, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(47, 44);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackgroundImage = global::IT_Dept.Properties.Resources.edit2;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Location = new System.Drawing.Point(413, 20);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(47, 44);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lblMsg});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 448);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(887, 24);
            this.radStatusStrip1.TabIndex = 28;
            this.radStatusStrip1.Text = "radStatusStrip1";
            // 
            // lblMsg
            // 
            this.lblMsg.AccessibleDescription = "radLabelElement1";
            this.lblMsg.AccessibleName = "radLabelElement1";
            this.lblMsg.Name = "lblMsg";
            this.radStatusStrip1.SetSpring(this.lblMsg, false);
            this.lblMsg.Text = "";
            this.lblMsg.TextWrap = true;
            this.lblMsg.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // frmDayOffs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 472);
            this.Controls.Add(this.offsGridView);
            this.Controls.Add(this.radMenu1);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radStatusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDayOffs";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DayOffs";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmDayOffs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.offsGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Telerik.WinControls.UI.RadGridView offsGridView;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnEdit;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        public Telerik.WinControls.UI.RadLabelElement lblMsg;
        public System.Windows.Forms.Button BtnNew;
    }
}
