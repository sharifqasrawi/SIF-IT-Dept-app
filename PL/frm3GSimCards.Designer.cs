﻿namespace IT_Dept.PL
{
    partial class frm3GSimCards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm3GSimCards));
            this.SimsGridView = new Telerik.WinControls.UI.RadGridView();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.lblMsg = new Telerik.WinControls.UI.RadLabelElement();
            ((System.ComponentModel.ISupportInitialize)(this.SimsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimsGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // SimsGridView
            // 
            this.SimsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SimsGridView.EnableFastScrolling = true;
            this.SimsGridView.EnableKineticScrolling = true;
            this.SimsGridView.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SimsGridView.Location = new System.Drawing.Point(12, 26);
            // 
            // SimsGridView
            // 
            this.SimsGridView.MasterTemplate.AllowAddNewRow = false;
            this.SimsGridView.MasterTemplate.AllowRowResize = false;
            this.SimsGridView.MasterTemplate.AllowSearchRow = true;
            this.SimsGridView.MasterTemplate.EnableAlternatingRowColor = true;
            this.SimsGridView.MasterTemplate.EnableFiltering = true;
            this.SimsGridView.MasterTemplate.EnablePaging = true;
            this.SimsGridView.MasterTemplate.HorizontalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysShow;
            this.SimsGridView.Name = "SimsGridView";
            this.SimsGridView.ReadOnly = true;
            // 
            // 
            // 
            this.SimsGridView.RootElement.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.SimsGridView.RootElement.FlipText = false;
            this.SimsGridView.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            this.SimsGridView.Size = new System.Drawing.Size(863, 346);
            this.SimsGridView.TabIndex = 26;
            this.SimsGridView.Text = "radGridView1";
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(887, 20);
            this.radMenu1.TabIndex = 25;
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
            this.radGroupBox2.TabIndex = 23;
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
            this.btnDelete.Location = new System.Drawing.Point(508, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(47, 44);
            this.btnDelete.TabIndex = 8;
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
            this.btnEdit.Location = new System.Drawing.Point(415, 21);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(47, 44);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.BtnNew.Location = new System.Drawing.Point(320, 21);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(47, 44);
            this.BtnNew.TabIndex = 6;
            this.BtnNew.UseVisualStyleBackColor = false;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lblMsg});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 448);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(887, 24);
            this.radStatusStrip1.TabIndex = 24;
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
            // frm3GSimCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 472);
            this.Controls.Add(this.SimsGridView);
            this.Controls.Add(this.radMenu1);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radStatusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm3GSimCards";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3G Sim Cards";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.frm3GSimCards_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SimsGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SimsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Telerik.WinControls.UI.RadGridView SimsGridView;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.Button BtnNew;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        public Telerik.WinControls.UI.RadLabelElement lblMsg;
    }
}