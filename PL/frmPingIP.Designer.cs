namespace IT_Dept.PL
{
    partial class frmPingIP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPingIP));
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.txtPingResults = new Telerik.WinControls.UI.RadTextBox();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.lstIPs = new Telerik.WinControls.UI.RadDropDownList();
            this.rbSifServer = new Telerik.WinControls.UI.RadRadioButton();
            this.rbCenterCon = new Telerik.WinControls.UI.RadRadioButton();
            this.rbCenterServer = new Telerik.WinControls.UI.RadRadioButton();
            this.rbOtherIP = new Telerik.WinControls.UI.RadRadioButton();
            this.txtIP = new Telerik.WinControls.UI.RadTextBox();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.lblMsg = new Telerik.WinControls.UI.RadLabelElement();
            this.commandBarSeparator1 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.btnClear = new Telerik.WinControls.UI.RadButtonElement();
            this.btnPing = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPingResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstIPs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbSifServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbCenterCon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbCenterServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbOtherIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radGroupBox3);
            this.radGroupBox1.Controls.Add(this.radGroupBox2);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGroupBox1.HeaderText = "Ping IP Address";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(669, 433);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Ping IP Address";
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox3.Controls.Add(this.txtPingResults);
            this.radGroupBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGroupBox3.HeaderText = "Ping Results";
            this.radGroupBox3.Location = new System.Drawing.Point(5, 138);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Size = new System.Drawing.Size(659, 290);
            this.radGroupBox3.TabIndex = 2;
            this.radGroupBox3.Text = "Ping Results";
            // 
            // txtPingResults
            // 
            this.txtPingResults.AutoScroll = true;
            this.txtPingResults.AutoSize = false;
            this.txtPingResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPingResults.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPingResults.Location = new System.Drawing.Point(2, 18);
            this.txtPingResults.Multiline = true;
            this.txtPingResults.Name = "txtPingResults";
            this.txtPingResults.ReadOnly = true;
            this.txtPingResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPingResults.Size = new System.Drawing.Size(655, 270);
            this.txtPingResults.TabIndex = 0;
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.btnPing);
            this.radGroupBox2.Controls.Add(this.lstIPs);
            this.radGroupBox2.Controls.Add(this.rbSifServer);
            this.radGroupBox2.Controls.Add(this.rbCenterCon);
            this.radGroupBox2.Controls.Add(this.rbCenterServer);
            this.radGroupBox2.Controls.Add(this.rbOtherIP);
            this.radGroupBox2.Controls.Add(this.txtIP);
            this.radGroupBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGroupBox2.HeaderText = "IP Address";
            this.radGroupBox2.Location = new System.Drawing.Point(5, 35);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(659, 97);
            this.radGroupBox2.TabIndex = 1;
            this.radGroupBox2.Text = "IP Address";
            // 
            // lstIPs
            // 
            this.lstIPs.AllowShowFocusCues = false;
            this.lstIPs.AutoCompleteDisplayMember = null;
            this.lstIPs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.lstIPs.AutoCompleteValueMember = null;
            this.lstIPs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstIPs.DropDownHeight = 150;
            this.lstIPs.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstIPs.Location = new System.Drawing.Point(5, 54);
            this.lstIPs.Name = "lstIPs";
            this.lstIPs.NullText = "Select ";
            this.lstIPs.Size = new System.Drawing.Size(337, 23);
            this.lstIPs.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending;
            this.lstIPs.TabIndex = 5;
            this.lstIPs.Text = "Select";
            // 
            // rbSifServer
            // 
            this.rbSifServer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbSifServer.Location = new System.Drawing.Point(263, 27);
            this.rbSifServer.Name = "rbSifServer";
            this.rbSifServer.Size = new System.Drawing.Size(80, 21);
            this.rbSifServer.TabIndex = 3;
            this.rbSifServer.Text = "SIF Server";
            this.rbSifServer.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rbSifServer_ToggleStateChanged);
            // 
            // rbCenterCon
            // 
            this.rbCenterCon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbCenterCon.Location = new System.Drawing.Point(114, 27);
            this.rbCenterCon.Name = "rbCenterCon";
            this.rbCenterCon.Size = new System.Drawing.Size(134, 21);
            this.rbCenterCon.TabIndex = 4;
            this.rbCenterCon.Text = "Center Connection";
            this.rbCenterCon.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rbCenterCon_ToggleStateChanged);
            // 
            // rbCenterServer
            // 
            this.rbCenterServer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbCenterServer.Location = new System.Drawing.Point(5, 27);
            this.rbCenterServer.Name = "rbCenterServer";
            this.rbCenterServer.Size = new System.Drawing.Size(103, 21);
            this.rbCenterServer.TabIndex = 3;
            this.rbCenterServer.Text = "Center Server";
            this.rbCenterServer.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rbCenterServer_ToggleStateChanged);
            // 
            // rbOtherIP
            // 
            this.rbOtherIP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rbOtherIP.Location = new System.Drawing.Point(405, 27);
            this.rbOtherIP.Name = "rbOtherIP";
            this.rbOtherIP.Size = new System.Drawing.Size(123, 21);
            this.rbOtherIP.TabIndex = 2;
            this.rbOtherIP.Text = "Other IP Address";
            this.rbOtherIP.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rbOtherIP_ToggleStateChanged);
            // 
            // txtIP
            // 
            this.txtIP.Enabled = false;
            this.txtIP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIP.Location = new System.Drawing.Point(405, 54);
            this.txtIP.Name = "txtIP";
            this.txtIP.NullText = "***.***.***.***";
            this.txtIP.Size = new System.Drawing.Size(169, 23);
            this.txtIP.TabIndex = 0;
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lblMsg,
            this.commandBarSeparator1,
            this.btnClear});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 451);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(693, 24);
            this.radStatusStrip1.TabIndex = 1;
            this.radStatusStrip1.Text = "radStatusStrip1";
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
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
            // btnClear
            // 
            this.btnClear.AccessibleDescription = "Clear Results";
            this.btnClear.AccessibleName = "Clear Results";
            this.btnClear.Name = "btnClear";
            this.radStatusStrip1.SetSpring(this.btnClear, false);
            this.btnClear.Text = "Clear Results";
            this.btnClear.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPing
            // 
            this.btnPing.BackgroundImage = global::IT_Dept.Properties.Resources.unnamed;
            this.btnPing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPing.Location = new System.Drawing.Point(593, 27);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(61, 56);
            this.btnPing.TabIndex = 6;
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // frmPingIP
            // 
            this.AcceptButton = this.btnPing;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 475);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.radGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPingIP";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP Address Pinger";
            this.ThemeName = "ControlDefault";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPingIP_FormClosing);
            this.Load += new System.EventHandler(this.frmPingIP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPingResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstIPs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbSifServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbCenterCon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbCenterServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbOtherIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadTextBox txtPingResults;
        private Telerik.WinControls.UI.RadTextBox txtIP;
        private Telerik.WinControls.UI.RadRadioButton rbSifServer;
        private Telerik.WinControls.UI.RadRadioButton rbOtherIP;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement lblMsg;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator1;
        private Telerik.WinControls.UI.RadButtonElement btnClear;
        public Telerik.WinControls.UI.RadRadioButton rbCenterCon;
        public Telerik.WinControls.UI.RadRadioButton rbCenterServer;
        public Telerik.WinControls.UI.RadDropDownList lstIPs;
        public System.Windows.Forms.Button btnPing;
    }
}
