namespace TIMS.FORMS
{
    partial class frmFileWatcher
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
            this.btnWatcher = new System.Windows.Forms.Button();
            this.txtEvents = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbFileWatcher = new System.Windows.Forms.TabPage();
            this.splitContWatcher = new System.Windows.Forms.SplitContainer();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.tbData = new System.Windows.Forms.TabPage();
            this.splitContDataMain = new System.Windows.Forms.SplitContainer();
            this.lblMwtxNum = new System.Windows.Forms.Label();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.lblInvNum = new System.Windows.Forms.Label();
            this.lblAccName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtMWTxNum = new System.Windows.Forms.TextBox();
            this.txtOrderNum = new System.Windows.Forms.TextBox();
            this.txtInvNum = new System.Windows.Forms.TextBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dgItems = new System.Windows.Forms.DataGridView();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusBarServer = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusBarDB = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusActiveUSER = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusVerion = new System.Windows.Forms.ToolStripStatusLabel();
            this.LicenceType = new System.Windows.Forms.ToolStripStatusLabel();
            this.DaysRemaining = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tbFileWatcher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContWatcher)).BeginInit();
            this.splitContWatcher.Panel1.SuspendLayout();
            this.splitContWatcher.Panel2.SuspendLayout();
            this.splitContWatcher.SuspendLayout();
            this.tbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContDataMain)).BeginInit();
            this.splitContDataMain.Panel1.SuspendLayout();
            this.splitContDataMain.Panel2.SuspendLayout();
            this.splitContDataMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).BeginInit();
            this.StatusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWatcher
            // 
            this.btnWatcher.Location = new System.Drawing.Point(19, 14);
            this.btnWatcher.Name = "btnWatcher";
            this.btnWatcher.Size = new System.Drawing.Size(148, 35);
            this.btnWatcher.TabIndex = 0;
            this.btnWatcher.Text = "Start Watching";
            this.btnWatcher.UseVisualStyleBackColor = true;
            this.btnWatcher.Click += new System.EventHandler(this.btnWatcher_Click);
            // 
            // txtEvents
            // 
            this.txtEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEvents.Location = new System.Drawing.Point(0, 0);
            this.txtEvents.Multiline = true;
            this.txtEvents.Name = "txtEvents";
            this.txtEvents.Size = new System.Drawing.Size(1293, 452);
            this.txtEvents.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbFileWatcher);
            this.tabControl1.Controls.Add(this.tbData);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1307, 572);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tbFileWatcher
            // 
            this.tbFileWatcher.Controls.Add(this.splitContWatcher);
            this.tbFileWatcher.Location = new System.Drawing.Point(4, 29);
            this.tbFileWatcher.Name = "tbFileWatcher";
            this.tbFileWatcher.Padding = new System.Windows.Forms.Padding(3);
            this.tbFileWatcher.Size = new System.Drawing.Size(1299, 539);
            this.tbFileWatcher.TabIndex = 0;
            this.tbFileWatcher.Text = "KRA MW Capture";
            this.tbFileWatcher.UseVisualStyleBackColor = true;
            // 
            // splitContWatcher
            // 
            this.splitContWatcher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContWatcher.Location = new System.Drawing.Point(3, 3);
            this.splitContWatcher.Name = "splitContWatcher";
            this.splitContWatcher.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContWatcher.Panel1
            // 
            this.splitContWatcher.Panel1.Controls.Add(this.txtFolderPath);
            this.splitContWatcher.Panel1.Controls.Add(this.btnWatcher);
            this.splitContWatcher.Panel1.Controls.Add(this.btnSettings);
            // 
            // splitContWatcher.Panel2
            // 
            this.splitContWatcher.Panel2.Controls.Add(this.txtEvents);
            this.splitContWatcher.Size = new System.Drawing.Size(1293, 533);
            this.splitContWatcher.SplitterDistance = 77;
            this.splitContWatcher.TabIndex = 4;
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolderPath.Location = new System.Drawing.Point(206, 18);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.ReadOnly = true;
            this.txtFolderPath.Size = new System.Drawing.Size(317, 26);
            this.txtFolderPath.TabIndex = 3;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.Image = global::TIMS.Properties.Resources.kempas;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSettings.Location = new System.Drawing.Point(1174, 7);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(99, 61);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // tbData
            // 
            this.tbData.Controls.Add(this.splitContDataMain);
            this.tbData.Location = new System.Drawing.Point(4, 29);
            this.tbData.Name = "tbData";
            this.tbData.Padding = new System.Windows.Forms.Padding(3);
            this.tbData.Size = new System.Drawing.Size(1299, 539);
            this.tbData.TabIndex = 1;
            this.tbData.Text = "KRA MW Data";
            this.tbData.UseVisualStyleBackColor = true;
            // 
            // splitContDataMain
            // 
            this.splitContDataMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContDataMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContDataMain.Location = new System.Drawing.Point(3, 3);
            this.splitContDataMain.Name = "splitContDataMain";
            this.splitContDataMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContDataMain.Panel1
            // 
            this.splitContDataMain.Panel1.Controls.Add(this.lblMwtxNum);
            this.splitContDataMain.Panel1.Controls.Add(this.lblOrderNum);
            this.splitContDataMain.Panel1.Controls.Add(this.lblInvNum);
            this.splitContDataMain.Panel1.Controls.Add(this.lblAccName);
            this.splitContDataMain.Panel1.Controls.Add(this.btnSearch);
            this.splitContDataMain.Panel1.Controls.Add(this.txtMWTxNum);
            this.splitContDataMain.Panel1.Controls.Add(this.txtOrderNum);
            this.splitContDataMain.Panel1.Controls.Add(this.txtInvNum);
            this.splitContDataMain.Panel1.Controls.Add(this.txtAccountName);
            this.splitContDataMain.Panel1.Controls.Add(this.dtpTo);
            this.splitContDataMain.Panel1.Controls.Add(this.dtpFrom);
            this.splitContDataMain.Panel1.Controls.Add(this.lblTo);
            this.splitContDataMain.Panel1.Controls.Add(this.lblFrom);
            // 
            // splitContDataMain.Panel2
            // 
            this.splitContDataMain.Panel2.Controls.Add(this.dgItems);
            this.splitContDataMain.Size = new System.Drawing.Size(1293, 533);
            this.splitContDataMain.SplitterDistance = 64;
            this.splitContDataMain.TabIndex = 1;
            // 
            // lblMwtxNum
            // 
            this.lblMwtxNum.AutoSize = true;
            this.lblMwtxNum.Location = new System.Drawing.Point(1021, 9);
            this.lblMwtxNum.Name = "lblMwtxNum";
            this.lblMwtxNum.Size = new System.Drawing.Size(94, 20);
            this.lblMwtxNum.TabIndex = 12;
            this.lblMwtxNum.Text = "MW Tx Num";
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Location = new System.Drawing.Point(832, 9);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(86, 20);
            this.lblOrderNum.TabIndex = 11;
            this.lblOrderNum.Text = "Order Num";
            // 
            // lblInvNum
            // 
            this.lblInvNum.AutoSize = true;
            this.lblInvNum.Location = new System.Drawing.Point(643, 9);
            this.lblInvNum.Name = "lblInvNum";
            this.lblInvNum.Size = new System.Drawing.Size(67, 20);
            this.lblInvNum.TabIndex = 10;
            this.lblInvNum.Text = "Inv Num";
            // 
            // lblAccName
            // 
            this.lblAccName.AutoSize = true;
            this.lblAccName.Location = new System.Drawing.Point(353, 9);
            this.lblAccName.Name = "lblAccName";
            this.lblAccName.Size = new System.Drawing.Size(124, 20);
            this.lblAccName.TabIndex = 9;
            this.lblAccName.Text = "Customer Name";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Image = global::TIMS.Properties.Resources.Search;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(1202, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 32);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtMWTxNum
            // 
            this.txtMWTxNum.Location = new System.Drawing.Point(1025, 32);
            this.txtMWTxNum.Name = "txtMWTxNum";
            this.txtMWTxNum.Size = new System.Drawing.Size(173, 26);
            this.txtMWTxNum.TabIndex = 7;
            // 
            // txtOrderNum
            // 
            this.txtOrderNum.Location = new System.Drawing.Point(836, 32);
            this.txtOrderNum.Name = "txtOrderNum";
            this.txtOrderNum.Size = new System.Drawing.Size(173, 26);
            this.txtOrderNum.TabIndex = 6;
            // 
            // txtInvNum
            // 
            this.txtInvNum.Location = new System.Drawing.Point(647, 32);
            this.txtInvNum.Name = "txtInvNum";
            this.txtInvNum.Size = new System.Drawing.Size(173, 26);
            this.txtInvNum.TabIndex = 5;
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(357, 32);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(275, 26);
            this.txtAccountName.TabIndex = 4;
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd-MMM-yy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(177, 32);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(166, 26);
            this.dtpTo.TabIndex = 3;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd-MMM-yy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(9, 32);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(151, 26);
            this.dtpFrom.TabIndex = 2;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(173, 9);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(27, 20);
            this.lblTo.TabIndex = 1;
            this.lblTo.Text = "To";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(5, 9);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(46, 20);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "From";
            // 
            // dgItems
            // 
            this.dgItems.AllowUserToAddRows = false;
            this.dgItems.AllowUserToDeleteRows = false;
            this.dgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgItems.Location = new System.Drawing.Point(0, 0);
            this.dgItems.Name = "dgItems";
            this.dgItems.ReadOnly = true;
            this.dgItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgItems.Size = new System.Drawing.Size(1291, 463);
            this.dgItems.TabIndex = 0;
            this.dgItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItems_CellDoubleClick);
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBarServer,
            this.StatusBarDB,
            this.StatusActiveUSER,
            this.StatusVerion,
            this.LicenceType,
            this.DaysRemaining});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 550);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.StatusStrip1.Size = new System.Drawing.Size(1307, 22);
            this.StatusStrip1.TabIndex = 188;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // StatusBarServer
            // 
            this.StatusBarServer.Name = "StatusBarServer";
            this.StatusBarServer.Size = new System.Drawing.Size(39, 17);
            this.StatusBarServer.Text = "Server";
            // 
            // StatusBarDB
            // 
            this.StatusBarDB.Name = "StatusBarDB";
            this.StatusBarDB.Size = new System.Drawing.Size(22, 17);
            this.StatusBarDB.Text = "DB";
            // 
            // StatusActiveUSER
            // 
            this.StatusActiveUSER.Name = "StatusActiveUSER";
            this.StatusActiveUSER.Size = new System.Drawing.Size(30, 17);
            this.StatusActiveUSER.Text = "User";
            // 
            // StatusVerion
            // 
            this.StatusVerion.Name = "StatusVerion";
            this.StatusVerion.Size = new System.Drawing.Size(40, 17);
            this.StatusVerion.Text = "Verion";
            // 
            // LicenceType
            // 
            this.LicenceType.Name = "LicenceType";
            this.LicenceType.Size = new System.Drawing.Size(47, 17);
            this.LicenceType.Text = "Licence";
            // 
            // DaysRemaining
            // 
            this.DaysRemaining.Name = "DaysRemaining";
            this.DaysRemaining.Size = new System.Drawing.Size(32, 17);
            this.DaysRemaining.Text = "Days";
            // 
            // frmFileWatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1307, 572);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmFileWatcher";
            this.Text = "KRA MW Capture";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFileWatcher_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbFileWatcher.ResumeLayout(false);
            this.splitContWatcher.Panel1.ResumeLayout(false);
            this.splitContWatcher.Panel1.PerformLayout();
            this.splitContWatcher.Panel2.ResumeLayout(false);
            this.splitContWatcher.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContWatcher)).EndInit();
            this.splitContWatcher.ResumeLayout(false);
            this.tbData.ResumeLayout(false);
            this.splitContDataMain.Panel1.ResumeLayout(false);
            this.splitContDataMain.Panel1.PerformLayout();
            this.splitContDataMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContDataMain)).EndInit();
            this.splitContDataMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgItems)).EndInit();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWatcher;
        private System.Windows.Forms.TextBox txtEvents;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbFileWatcher;
        private System.Windows.Forms.TabPage tbData;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.DataGridView dgItems;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.SplitContainer splitContDataMain;
        private System.Windows.Forms.SplitContainer splitContWatcher;
        private System.Windows.Forms.Label lblMwtxNum;
        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.Label lblInvNum;
        private System.Windows.Forms.Label lblAccName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtMWTxNum;
        private System.Windows.Forms.TextBox txtOrderNum;
        private System.Windows.Forms.TextBox txtInvNum;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel StatusBarServer;
        internal System.Windows.Forms.ToolStripStatusLabel StatusBarDB;
        internal System.Windows.Forms.ToolStripStatusLabel StatusActiveUSER;
        internal System.Windows.Forms.ToolStripStatusLabel StatusVerion;
        private System.Windows.Forms.ToolStripStatusLabel LicenceType;
        private System.Windows.Forms.ToolStripStatusLabel DaysRemaining;
    }
}