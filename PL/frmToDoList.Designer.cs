namespace IT_Dept.PL
{
    partial class frmToDoList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmToDoList));
            this.TasksErGridView = new Telerik.WinControls.UI.MasterGridViewTemplate();
            this.lblMsg = new Telerik.WinControls.UI.RadLabelElement();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.picCheck = new System.Windows.Forms.PictureBox();
            this.BtnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.TasksGridView = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TasksErGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TasksGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TasksGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // TasksErGridView
            // 
            this.TasksErGridView.AllowAddNewRow = false;
            this.TasksErGridView.AllowRowResize = false;
            this.TasksErGridView.AllowSearchRow = true;
            this.TasksErGridView.EnableAlternatingRowColor = true;
            this.TasksErGridView.EnableFiltering = true;
            this.TasksErGridView.EnablePaging = true;
            this.TasksErGridView.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow;
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
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lblMsg});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 448);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(887, 24);
            this.radStatusStrip1.TabIndex = 15;
            this.radStatusStrip1.Text = "radStatusStrip1";
            // 
            // picCheck
            // 
            this.picCheck.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.picCheck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCheck.Enabled = false;
            this.picCheck.Image = global::IT_Dept.Properties.Resources.check1;
            this.picCheck.Location = new System.Drawing.Point(541, 21);
            this.picCheck.Name = "picCheck";
            this.picCheck.Size = new System.Drawing.Size(47, 44);
            this.picCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCheck.TabIndex = 1;
            this.picCheck.TabStop = false;
            this.picCheck.Click += new System.EventHandler(this.picCheck_Click);
            this.picCheck.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCheck_MouseDown);
            this.picCheck.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picCheck_MouseUp);
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
            this.BtnNew.Location = new System.Drawing.Point(272, 21);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(47, 44);
            this.BtnNew.TabIndex = 6;
            this.BtnNew.UseVisualStyleBackColor = false;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            this.BtnNew.MouseHover += new System.EventHandler(this.BtnNew_MouseHover);
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
            this.btnEdit.Location = new System.Drawing.Point(367, 21);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(47, 44);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.MouseHover += new System.EventHandler(this.btnEdit_MouseHover);
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
            this.btnDelete.Location = new System.Drawing.Point(460, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(47, 44);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseHover += new System.EventHandler(this.btnDelete_MouseHover);
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.btnDelete);
            this.radGroupBox2.Controls.Add(this.btnEdit);
            this.radGroupBox2.Controls.Add(this.BtnNew);
            this.radGroupBox2.Controls.Add(this.picCheck);
            this.radGroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radGroupBox2.HeaderText = "Management";
            this.radGroupBox2.Location = new System.Drawing.Point(0, 378);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(887, 70);
            this.radGroupBox2.TabIndex = 14;
            this.radGroupBox2.Text = "Management";
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.AccessibleDescription = "ملف";
            this.radMenuItem1.AccessibleName = "ملف";
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "File";
            this.radMenuItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(887, 20);
            this.radMenu1.TabIndex = 16;
            this.radMenu1.Text = "radMenu1";
            // 
            // TasksGridView
            // 
            this.TasksGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TasksGridView.EnableFastScrolling = true;
            this.TasksGridView.EnableKineticScrolling = true;
            this.TasksGridView.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TasksGridView.Location = new System.Drawing.Point(12, 26);
            // 
            // TasksGridView
            // 
            this.TasksGridView.MasterTemplate.AllowAddNewRow = false;
            this.TasksGridView.MasterTemplate.AllowRowResize = false;
            this.TasksGridView.MasterTemplate.AllowSearchRow = true;
            this.TasksGridView.MasterTemplate.EnableAlternatingRowColor = true;
            this.TasksGridView.MasterTemplate.EnableFiltering = true;
            this.TasksGridView.MasterTemplate.EnablePaging = true;
            this.TasksGridView.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow;
            this.TasksGridView.MasterTemplate.PageSize = 30;
            this.TasksGridView.Name = "TasksGridView";
            this.TasksGridView.ReadOnly = true;
            // 
            // 
            // 
            this.TasksGridView.RootElement.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.TasksGridView.RootElement.FlipText = false;
            this.TasksGridView.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            this.TasksGridView.Size = new System.Drawing.Size(863, 346);
            this.TasksGridView.TabIndex = 18;
            this.TasksGridView.Text = "radGridView1";
            // 
            // frmToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 472);
            this.Controls.Add(this.TasksGridView);
            this.Controls.Add(this.radMenu1);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radStatusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmToDoList";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To Do List";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frmToDoList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TasksErGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TasksGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TasksGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Telerik.WinControls.UI.MasterGridViewTemplate TasksErGridView;
        public Telerik.WinControls.UI.RadLabelElement lblMsg;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        public System.Windows.Forms.PictureBox picCheck;
        public System.Windows.Forms.Button BtnNew;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button btnDelete;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        public Telerik.WinControls.UI.RadGridView TasksGridView;


    }
}
