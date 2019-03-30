namespace IT_Dept.PL
{
    partial class frmCenters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCenters));
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.lblMsg = new Telerik.WinControls.UI.RadLabelElement();
            this.commandBarSeparator1 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.radButtonElementInternal = new Telerik.WinControls.UI.RadButtonElement();
            this.commandBarSeparator2 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.radButtonElementOrng = new Telerik.WinControls.UI.RadButtonElement();
            this.commandBarSeparator3 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.radButtonElementBord = new Telerik.WinControls.UI.RadButtonElement();
            this.commandBarSeparator4 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.radButtonElementWarehouses = new Telerik.WinControls.UI.RadButtonElement();
            this.centersGridView = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centersGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(887, 20);
            this.radMenu1.TabIndex = 8;
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
            this.radGroupBox2.Controls.Add(this.btnDelete);
            this.radGroupBox2.Controls.Add(this.btnEdit);
            this.radGroupBox2.Controls.Add(this.BtnNew);
            this.radGroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radGroupBox2.HeaderText = "Management";
            this.radGroupBox2.Location = new System.Drawing.Point(0, 378);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(887, 70);
            this.radGroupBox2.TabIndex = 6;
            this.radGroupBox2.Text = "Management";
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
            this.btnDelete.Location = new System.Drawing.Point(512, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(47, 44);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseHover += new System.EventHandler(this.btnDelete_MouseHover);
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
            this.btnEdit.Location = new System.Drawing.Point(419, 21);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(47, 44);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.MouseHover += new System.EventHandler(this.btnEdit_MouseHover);
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
            this.BtnNew.Location = new System.Drawing.Point(324, 21);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(47, 44);
            this.BtnNew.TabIndex = 3;
            this.BtnNew.UseVisualStyleBackColor = false;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            this.BtnNew.MouseHover += new System.EventHandler(this.BtnNew_MouseHover);
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lblMsg,
            this.commandBarSeparator1,
            this.radButtonElementInternal,
            this.commandBarSeparator2,
            this.radButtonElementOrng,
            this.commandBarSeparator3,
            this.radButtonElementBord,
            this.commandBarSeparator4,
            this.radButtonElementWarehouses});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 448);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(887, 24);
            this.radStatusStrip1.TabIndex = 7;
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
            // commandBarSeparator1
            // 
            this.commandBarSeparator1.AccessibleDescription = "commandBarSeparator1";
            this.commandBarSeparator1.AccessibleName = "commandBarSeparator1";
            this.commandBarSeparator1.Name = "commandBarSeparator1";
            this.radStatusStrip1.SetSpring(this.commandBarSeparator1, false);
            this.commandBarSeparator1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarSeparator1.VisibleInOverflowMenu = false;
            // 
            // radButtonElementInternal
            // 
            this.radButtonElementInternal.AccessibleDescription = "Orange Card Centers";
            this.radButtonElementInternal.AccessibleName = "Orange Card Centers";
            this.radButtonElementInternal.Name = "radButtonElementInternal";
            this.radStatusStrip1.SetSpring(this.radButtonElementInternal, false);
            this.radButtonElementInternal.Text = "Internal";
            this.radButtonElementInternal.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radButtonElementInternal.Click += new System.EventHandler(this.radButtonElementInternal_Click);
            // 
            // commandBarSeparator2
            // 
            this.commandBarSeparator2.AccessibleDescription = "commandBarSeparator2";
            this.commandBarSeparator2.AccessibleName = "commandBarSeparator2";
            this.commandBarSeparator2.Name = "commandBarSeparator2";
            this.radStatusStrip1.SetSpring(this.commandBarSeparator2, false);
            this.commandBarSeparator2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarSeparator2.VisibleInOverflowMenu = false;
            // 
            // radButtonElementOrng
            // 
            this.radButtonElementOrng.AccessibleDescription = "Orange Card";
            this.radButtonElementOrng.AccessibleName = "Orange Card";
            this.radButtonElementOrng.Name = "radButtonElementOrng";
            this.radStatusStrip1.SetSpring(this.radButtonElementOrng, false);
            this.radButtonElementOrng.Text = "Orange Card";
            this.radButtonElementOrng.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radButtonElementOrng.Click += new System.EventHandler(this.radButtonElementOrng_Click);
            // 
            // commandBarSeparator3
            // 
            this.commandBarSeparator3.AccessibleDescription = "commandBarSeparator3";
            this.commandBarSeparator3.AccessibleName = "commandBarSeparator3";
            this.commandBarSeparator3.Name = "commandBarSeparator3";
            this.radStatusStrip1.SetSpring(this.commandBarSeparator3, false);
            this.commandBarSeparator3.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarSeparator3.VisibleInOverflowMenu = false;
            // 
            // radButtonElementBord
            // 
            this.radButtonElementBord.AccessibleDescription = "Border";
            this.radButtonElementBord.AccessibleName = "Border";
            this.radButtonElementBord.Name = "radButtonElementBord";
            this.radStatusStrip1.SetSpring(this.radButtonElementBord, false);
            this.radButtonElementBord.Text = "Border";
            this.radButtonElementBord.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radButtonElementBord.Click += new System.EventHandler(this.radButtonElementBord_Click);
            // 
            // commandBarSeparator4
            // 
            this.commandBarSeparator4.AccessibleDescription = "commandBarSeparator4";
            this.commandBarSeparator4.AccessibleName = "commandBarSeparator4";
            this.commandBarSeparator4.Name = "commandBarSeparator4";
            this.radStatusStrip1.SetSpring(this.commandBarSeparator4, false);
            this.commandBarSeparator4.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.commandBarSeparator4.VisibleInOverflowMenu = false;
            // 
            // radButtonElementWarehouses
            // 
            this.radButtonElementWarehouses.AccessibleDescription = "Warehouses";
            this.radButtonElementWarehouses.AccessibleName = "Warehouses";
            this.radButtonElementWarehouses.Name = "radButtonElementWarehouses";
            this.radStatusStrip1.SetSpring(this.radButtonElementWarehouses, false);
            this.radButtonElementWarehouses.Text = "Warehouses";
            this.radButtonElementWarehouses.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.radButtonElementWarehouses.Click += new System.EventHandler(this.radButtonElementWarehouses_Click);
            // 
            // centersGridView
            // 
            this.centersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.centersGridView.EnableFastScrolling = true;
            this.centersGridView.EnableKineticScrolling = true;
            this.centersGridView.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.centersGridView.Location = new System.Drawing.Point(12, 26);
            // 
            // centersGridView
            // 
            this.centersGridView.MasterTemplate.AllowAddNewRow = false;
            this.centersGridView.MasterTemplate.AllowRowResize = false;
            this.centersGridView.MasterTemplate.AllowSearchRow = true;
            this.centersGridView.MasterTemplate.EnableAlternatingRowColor = true;
            this.centersGridView.MasterTemplate.EnableFiltering = true;
            this.centersGridView.MasterTemplate.EnablePaging = true;
            this.centersGridView.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow;
            this.centersGridView.MasterTemplate.PageSize = 30;
            this.centersGridView.Name = "centersGridView";
            this.centersGridView.ReadOnly = true;
            // 
            // 
            // 
            this.centersGridView.RootElement.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.centersGridView.RootElement.FlipText = false;
            this.centersGridView.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            this.centersGridView.Size = new System.Drawing.Size(863, 346);
            this.centersGridView.TabIndex = 5;
            this.centersGridView.Text = "radGridView1";
            // 
            // frmCenters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 472);
            this.Controls.Add(this.radMenu1);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.centersGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCenters";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Centers";
            this.ThemeName = "ControlDefault";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCenters_FormClosing);
            this.Load += new System.EventHandler(this.frmCenters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centersGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        public Telerik.WinControls.UI.RadGridView centersGridView;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button BtnNew;
        public Telerik.WinControls.UI.RadLabelElement lblMsg;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator1;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator2;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator3;
        public Telerik.WinControls.UI.RadButtonElement radButtonElementInternal;
        public Telerik.WinControls.UI.RadButtonElement radButtonElementOrng;
        public Telerik.WinControls.UI.RadButtonElement radButtonElementBord;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator4;
        public Telerik.WinControls.UI.RadButtonElement radButtonElementWarehouses;
    }
}
