namespace TIMS.FORMS
{
    partial class frmSettings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.Panel1 = new System.Windows.Forms.Panel();
            this.TabControlSettings = new System.Windows.Forms.TabControl();
            this.tbPGeneral = new System.Windows.Forms.TabPage();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.chkRestoreDeletedDocs = new System.Windows.Forms.CheckBox();
            this.grpPrinter = new System.Windows.Forms.GroupBox();
            this.chkPrintDoc = new System.Windows.Forms.CheckBox();
            this.lblDefaultPrinter = new System.Windows.Forms.Label();
            this.cboPrinter = new System.Windows.Forms.ComboBox();
            this.grpFileWatcher = new System.Windows.Forms.GroupBox();
            this.cboDelimeter = new System.Windows.Forms.ComboBox();
            this.lblDelimeter = new System.Windows.Forms.Label();
            this.btnSelectCopyFolder = new System.Windows.Forms.Button();
            this.txtCopyFolderPath = new System.Windows.Forms.TextBox();
            this.chkArchiveDocs = new System.Windows.Forms.CheckBox();
            this.txtTimer = new System.Windows.Forms.TextBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.cboFileExtensions = new System.Windows.Forms.ComboBox();
            this.chkSubDirectories = new System.Windows.Forms.CheckBox();
            this.lblFileExtention = new System.Windows.Forms.Label();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.lblWatchFolder = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbPEmail = new System.Windows.Forms.TabPage();
            this.grpEmail = new System.Windows.Forms.GroupBox();
            this.btnSaveEamil = new System.Windows.Forms.Button();
            this.txtMailBody = new System.Windows.Forms.TextBox();
            this.txtInternalEmail = new System.Windows.Forms.TextBox();
            this.lblInternalEmail = new System.Windows.Forms.Label();
            this.chkSendEmail = new System.Windows.Forms.CheckBox();
            this.lblEmailBody = new System.Windows.Forms.Label();
            this.grpSmtp = new System.Windows.Forms.GroupBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.cmdLoad = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.cmdTest = new System.Windows.Forms.Button();
            this.Label16 = new System.Windows.Forms.Label();
            this.cmdSave = new System.Windows.Forms.Button();
            this.chkUseDefaultSettings = new System.Windows.Forms.CheckBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.chkEnableSSL = new System.Windows.Forms.CheckBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.fbdFileWatcherFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.txtInvColumn = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtCrnColumn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Panel1.SuspendLayout();
            this.TabControlSettings.SuspendLayout();
            this.tbPGeneral.SuspendLayout();
            this.grpGeneral.SuspendLayout();
            this.grpPrinter.SuspendLayout();
            this.grpFileWatcher.SuspendLayout();
            this.tbPEmail.SuspendLayout();
            this.grpEmail.SuspendLayout();
            this.grpSmtp.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Panel1.Controls.Add(this.TabControlSettings);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1104, 481);
            this.Panel1.TabIndex = 1;
            // 
            // TabControlSettings
            // 
            this.TabControlSettings.Controls.Add(this.tbPGeneral);
            this.TabControlSettings.Controls.Add(this.tbPEmail);
            this.TabControlSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlSettings.Location = new System.Drawing.Point(0, 0);
            this.TabControlSettings.Name = "TabControlSettings";
            this.TabControlSettings.SelectedIndex = 0;
            this.TabControlSettings.Size = new System.Drawing.Size(1104, 481);
            this.TabControlSettings.TabIndex = 27;
            this.TabControlSettings.SelectedIndexChanged += new System.EventHandler(this.TabControlSettings_SelectedIndexChanged);
            // 
            // tbPGeneral
            // 
            this.tbPGeneral.Controls.Add(this.grpGeneral);
            this.tbPGeneral.Controls.Add(this.grpPrinter);
            this.tbPGeneral.Controls.Add(this.grpFileWatcher);
            this.tbPGeneral.Controls.Add(this.btnSave);
            this.tbPGeneral.Location = new System.Drawing.Point(4, 29);
            this.tbPGeneral.Name = "tbPGeneral";
            this.tbPGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tbPGeneral.Size = new System.Drawing.Size(1096, 448);
            this.tbPGeneral.TabIndex = 0;
            this.tbPGeneral.Text = "General";
            this.tbPGeneral.UseVisualStyleBackColor = true;
            // 
            // grpGeneral
            // 
            this.grpGeneral.Controls.Add(this.chkRestoreDeletedDocs);
            this.grpGeneral.Location = new System.Drawing.Point(25, 272);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Size = new System.Drawing.Size(1055, 77);
            this.grpGeneral.TabIndex = 27;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General";
            // 
            // chkRestoreDeletedDocs
            // 
            this.chkRestoreDeletedDocs.AutoSize = true;
            this.chkRestoreDeletedDocs.Location = new System.Drawing.Point(19, 35);
            this.chkRestoreDeletedDocs.Name = "chkRestoreDeletedDocs";
            this.chkRestoreDeletedDocs.Size = new System.Drawing.Size(199, 24);
            this.chkRestoreDeletedDocs.TabIndex = 7;
            this.chkRestoreDeletedDocs.Text = "Restore Deleted Docs ?";
            this.chkRestoreDeletedDocs.UseVisualStyleBackColor = true;
            // 
            // grpPrinter
            // 
            this.grpPrinter.Controls.Add(this.chkPrintDoc);
            this.grpPrinter.Controls.Add(this.lblDefaultPrinter);
            this.grpPrinter.Controls.Add(this.cboPrinter);
            this.grpPrinter.Location = new System.Drawing.Point(25, 174);
            this.grpPrinter.Name = "grpPrinter";
            this.grpPrinter.Size = new System.Drawing.Size(1055, 79);
            this.grpPrinter.TabIndex = 26;
            this.grpPrinter.TabStop = false;
            this.grpPrinter.Text = "Print";
            // 
            // chkPrintDoc
            // 
            this.chkPrintDoc.AutoSize = true;
            this.chkPrintDoc.Location = new System.Drawing.Point(511, 27);
            this.chkPrintDoc.Name = "chkPrintDoc";
            this.chkPrintDoc.Size = new System.Drawing.Size(159, 24);
            this.chkPrintDoc.TabIndex = 6;
            this.chkPrintDoc.Text = "Print Documents ?";
            this.chkPrintDoc.UseVisualStyleBackColor = true;
            // 
            // lblDefaultPrinter
            // 
            this.lblDefaultPrinter.AutoSize = true;
            this.lblDefaultPrinter.Location = new System.Drawing.Point(15, 28);
            this.lblDefaultPrinter.Name = "lblDefaultPrinter";
            this.lblDefaultPrinter.Size = new System.Drawing.Size(119, 20);
            this.lblDefaultPrinter.TabIndex = 1;
            this.lblDefaultPrinter.Text = "Default Printer:.";
            // 
            // cboPrinter
            // 
            this.cboPrinter.FormattingEnabled = true;
            this.cboPrinter.Location = new System.Drawing.Point(140, 25);
            this.cboPrinter.Name = "cboPrinter";
            this.cboPrinter.Size = new System.Drawing.Size(283, 28);
            this.cboPrinter.TabIndex = 0;
            // 
            // grpFileWatcher
            // 
            this.grpFileWatcher.Controls.Add(this.label2);
            this.grpFileWatcher.Controls.Add(this.label1);
            this.grpFileWatcher.Controls.Add(this.txtCrnColumn);
            this.grpFileWatcher.Controls.Add(this.txtInvColumn);
            this.grpFileWatcher.Controls.Add(this.cboDelimeter);
            this.grpFileWatcher.Controls.Add(this.lblDelimeter);
            this.grpFileWatcher.Controls.Add(this.btnSelectCopyFolder);
            this.grpFileWatcher.Controls.Add(this.txtCopyFolderPath);
            this.grpFileWatcher.Controls.Add(this.chkArchiveDocs);
            this.grpFileWatcher.Controls.Add(this.txtTimer);
            this.grpFileWatcher.Controls.Add(this.lblTimer);
            this.grpFileWatcher.Controls.Add(this.cboFileExtensions);
            this.grpFileWatcher.Controls.Add(this.chkSubDirectories);
            this.grpFileWatcher.Controls.Add(this.lblFileExtention);
            this.grpFileWatcher.Controls.Add(this.txtFolderPath);
            this.grpFileWatcher.Controls.Add(this.btnSelectFolder);
            this.grpFileWatcher.Controls.Add(this.lblWatchFolder);
            this.grpFileWatcher.Location = new System.Drawing.Point(25, 15);
            this.grpFileWatcher.Name = "grpFileWatcher";
            this.grpFileWatcher.Size = new System.Drawing.Size(1055, 153);
            this.grpFileWatcher.TabIndex = 25;
            this.grpFileWatcher.TabStop = false;
            this.grpFileWatcher.Text = "File Watcher";
            // 
            // cboDelimeter
            // 
            this.cboDelimeter.FormattingEnabled = true;
            this.cboDelimeter.Location = new System.Drawing.Point(133, 109);
            this.cboDelimeter.Name = "cboDelimeter";
            this.cboDelimeter.Size = new System.Drawing.Size(121, 28);
            this.cboDelimeter.TabIndex = 13;
            // 
            // lblDelimeter
            // 
            this.lblDelimeter.AutoSize = true;
            this.lblDelimeter.Location = new System.Drawing.Point(25, 116);
            this.lblDelimeter.Name = "lblDelimeter";
            this.lblDelimeter.Size = new System.Drawing.Size(79, 20);
            this.lblDelimeter.TabIndex = 12;
            this.lblDelimeter.Text = "Delimiter:.";
            // 
            // btnSelectCopyFolder
            // 
            this.btnSelectCopyFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectCopyFolder.Image")));
            this.btnSelectCopyFolder.Location = new System.Drawing.Point(991, 64);
            this.btnSelectCopyFolder.Name = "btnSelectCopyFolder";
            this.btnSelectCopyFolder.Size = new System.Drawing.Size(43, 26);
            this.btnSelectCopyFolder.TabIndex = 11;
            this.btnSelectCopyFolder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSelectCopyFolder.UseVisualStyleBackColor = true;
            this.btnSelectCopyFolder.Click += new System.EventHandler(this.btnSelectCopyFolder_Click);
            // 
            // txtCopyFolderPath
            // 
            this.txtCopyFolderPath.Location = new System.Drawing.Point(686, 64);
            this.txtCopyFolderPath.Name = "txtCopyFolderPath";
            this.txtCopyFolderPath.ReadOnly = true;
            this.txtCopyFolderPath.Size = new System.Drawing.Size(290, 26);
            this.txtCopyFolderPath.TabIndex = 10;
            // 
            // chkArchiveDocs
            // 
            this.chkArchiveDocs.AutoSize = true;
            this.chkArchiveDocs.Location = new System.Drawing.Point(511, 66);
            this.chkArchiveDocs.Name = "chkArchiveDocs";
            this.chkArchiveDocs.Size = new System.Drawing.Size(169, 24);
            this.chkArchiveDocs.TabIndex = 9;
            this.chkArchiveDocs.Text = "Keep archive copy ?";
            this.chkArchiveDocs.UseVisualStyleBackColor = true;
            // 
            // txtTimer
            // 
            this.txtTimer.Location = new System.Drawing.Point(177, 67);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(246, 26);
            this.txtTimer.TabIndex = 8;
            this.txtTimer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimer_KeyPress);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(15, 70);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(156, 20);
            this.lblTimer.TabIndex = 7;
            this.lblTimer.Text = "Timer (miliseconds) :.";
            // 
            // cboFileExtensions
            // 
            this.cboFileExtensions.FormattingEnabled = true;
            this.cboFileExtensions.Location = new System.Drawing.Point(853, 23);
            this.cboFileExtensions.Name = "cboFileExtensions";
            this.cboFileExtensions.Size = new System.Drawing.Size(121, 28);
            this.cboFileExtensions.TabIndex = 6;
            // 
            // chkSubDirectories
            // 
            this.chkSubDirectories.AutoSize = true;
            this.chkSubDirectories.Location = new System.Drawing.Point(511, 26);
            this.chkSubDirectories.Name = "chkSubDirectories";
            this.chkSubDirectories.Size = new System.Drawing.Size(200, 24);
            this.chkSubDirectories.TabIndex = 5;
            this.chkSubDirectories.Text = "Include sub directories ?";
            this.chkSubDirectories.UseVisualStyleBackColor = true;
            // 
            // lblFileExtention
            // 
            this.lblFileExtention.AutoSize = true;
            this.lblFileExtention.Location = new System.Drawing.Point(745, 30);
            this.lblFileExtention.Name = "lblFileExtention";
            this.lblFileExtention.Size = new System.Drawing.Size(87, 20);
            this.lblFileExtention.TabIndex = 3;
            this.lblFileExtention.Text = "Extension:.";
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(133, 27);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.ReadOnly = true;
            this.txtFolderPath.Size = new System.Drawing.Size(290, 26);
            this.txtFolderPath.TabIndex = 2;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectFolder.Image")));
            this.btnSelectFolder.Location = new System.Drawing.Point(439, 27);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(43, 26);
            this.btnSelectFolder.TabIndex = 1;
            this.btnSelectFolder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // lblWatchFolder
            // 
            this.lblWatchFolder.AutoSize = true;
            this.lblWatchFolder.Location = new System.Drawing.Point(15, 33);
            this.lblWatchFolder.Name = "lblWatchFolder";
            this.lblWatchFolder.Size = new System.Drawing.Size(112, 20);
            this.lblWatchFolder.TabIndex = 0;
            this.lblWatchFolder.Text = "Watch Folder:.";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGray;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(25, 384);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 33);
            this.btnSave.TabIndex = 14;
            this.btnSave.Tag = "Manager Save Settings";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbPEmail
            // 
            this.tbPEmail.Controls.Add(this.grpEmail);
            this.tbPEmail.Controls.Add(this.grpSmtp);
            this.tbPEmail.Location = new System.Drawing.Point(4, 29);
            this.tbPEmail.Name = "tbPEmail";
            this.tbPEmail.Padding = new System.Windows.Forms.Padding(3);
            this.tbPEmail.Size = new System.Drawing.Size(1096, 448);
            this.tbPEmail.TabIndex = 1;
            this.tbPEmail.Text = "Email";
            this.tbPEmail.UseVisualStyleBackColor = true;
            // 
            // grpEmail
            // 
            this.grpEmail.Controls.Add(this.btnSaveEamil);
            this.grpEmail.Controls.Add(this.txtMailBody);
            this.grpEmail.Controls.Add(this.txtInternalEmail);
            this.grpEmail.Controls.Add(this.lblInternalEmail);
            this.grpEmail.Controls.Add(this.chkSendEmail);
            this.grpEmail.Controls.Add(this.lblEmailBody);
            this.grpEmail.Location = new System.Drawing.Point(363, 17);
            this.grpEmail.Name = "grpEmail";
            this.grpEmail.Size = new System.Drawing.Size(725, 313);
            this.grpEmail.TabIndex = 46;
            this.grpEmail.TabStop = false;
            this.grpEmail.Text = "Email";
            // 
            // btnSaveEamil
            // 
            this.btnSaveEamil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEamil.Location = new System.Drawing.Point(604, 255);
            this.btnSaveEamil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveEamil.Name = "btnSaveEamil";
            this.btnSaveEamil.Size = new System.Drawing.Size(104, 42);
            this.btnSaveEamil.TabIndex = 40;
            this.btnSaveEamil.Text = "SAVE";
            this.btnSaveEamil.UseVisualStyleBackColor = true;
            this.btnSaveEamil.Click += new System.EventHandler(this.btnSaveEamil_Click);
            // 
            // txtMailBody
            // 
            this.txtMailBody.Location = new System.Drawing.Point(357, 90);
            this.txtMailBody.Multiline = true;
            this.txtMailBody.Name = "txtMailBody";
            this.txtMailBody.Size = new System.Drawing.Size(351, 145);
            this.txtMailBody.TabIndex = 5;
            // 
            // txtInternalEmail
            // 
            this.txtInternalEmail.Location = new System.Drawing.Point(10, 90);
            this.txtInternalEmail.Multiline = true;
            this.txtInternalEmail.Name = "txtInternalEmail";
            this.txtInternalEmail.Size = new System.Drawing.Size(325, 145);
            this.txtInternalEmail.TabIndex = 4;
            // 
            // lblInternalEmail
            // 
            this.lblInternalEmail.AutoSize = true;
            this.lblInternalEmail.Location = new System.Drawing.Point(6, 67);
            this.lblInternalEmail.Name = "lblInternalEmail";
            this.lblInternalEmail.Size = new System.Drawing.Size(146, 20);
            this.lblInternalEmail.TabIndex = 3;
            this.lblInternalEmail.Text = "Internal Emails cc :.";
            // 
            // chkSendEmail
            // 
            this.chkSendEmail.AutoSize = true;
            this.chkSendEmail.Location = new System.Drawing.Point(10, 25);
            this.chkSendEmail.Name = "chkSendEmail";
            this.chkSendEmail.Size = new System.Drawing.Size(215, 24);
            this.chkSendEmail.TabIndex = 2;
            this.chkSendEmail.Text = "Automatically send email ?";
            this.chkSendEmail.UseVisualStyleBackColor = true;
            // 
            // lblEmailBody
            // 
            this.lblEmailBody.AutoSize = true;
            this.lblEmailBody.Location = new System.Drawing.Point(353, 67);
            this.lblEmailBody.Name = "lblEmailBody";
            this.lblEmailBody.Size = new System.Drawing.Size(100, 20);
            this.lblEmailBody.TabIndex = 0;
            this.lblEmailBody.Text = "Email Body :.";
            // 
            // grpSmtp
            // 
            this.grpSmtp.Controls.Add(this.txtServer);
            this.grpSmtp.Controls.Add(this.cmdLoad);
            this.grpSmtp.Controls.Add(this.txtPort);
            this.grpSmtp.Controls.Add(this.cmdTest);
            this.grpSmtp.Controls.Add(this.Label16);
            this.grpSmtp.Controls.Add(this.cmdSave);
            this.grpSmtp.Controls.Add(this.chkUseDefaultSettings);
            this.grpSmtp.Controls.Add(this.Label15);
            this.grpSmtp.Controls.Add(this.Label13);
            this.grpSmtp.Controls.Add(this.txtPwd);
            this.grpSmtp.Controls.Add(this.chkEnableSSL);
            this.grpSmtp.Controls.Add(this.Label14);
            this.grpSmtp.Controls.Add(this.txtUserName);
            this.grpSmtp.Location = new System.Drawing.Point(8, 6);
            this.grpSmtp.Name = "grpSmtp";
            this.grpSmtp.Size = new System.Drawing.Size(349, 324);
            this.grpSmtp.TabIndex = 45;
            this.grpSmtp.TabStop = false;
            this.grpSmtp.Text = "SMTP Settings";
            // 
            // txtServer
            // 
            this.txtServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServer.Location = new System.Drawing.Point(129, 24);
            this.txtServer.Margin = new System.Windows.Forms.Padding(2);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(186, 26);
            this.txtServer.TabIndex = 32;
            // 
            // cmdLoad
            // 
            this.cmdLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLoad.Location = new System.Drawing.Point(234, 266);
            this.cmdLoad.Margin = new System.Windows.Forms.Padding(2);
            this.cmdLoad.Name = "cmdLoad";
            this.cmdLoad.Size = new System.Drawing.Size(104, 42);
            this.cmdLoad.TabIndex = 44;
            this.cmdLoad.Text = "LOAD";
            this.cmdLoad.UseVisualStyleBackColor = true;
            this.cmdLoad.Click += new System.EventHandler(this.cmdLoad_Click);
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(129, 121);
            this.txtPort.Margin = new System.Windows.Forms.Padding(2);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(186, 26);
            this.txtPort.TabIndex = 35;
            // 
            // cmdTest
            // 
            this.cmdTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTest.Location = new System.Drawing.Point(125, 266);
            this.cmdTest.Margin = new System.Windows.Forms.Padding(2);
            this.cmdTest.Name = "cmdTest";
            this.cmdTest.Size = new System.Drawing.Size(104, 42);
            this.cmdTest.TabIndex = 43;
            this.cmdTest.Text = "TEST";
            this.cmdTest.UseVisualStyleBackColor = true;
            this.cmdTest.Click += new System.EventHandler(this.cmdTest_Click);
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(32, 58);
            this.Label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(89, 20);
            this.Label16.TabIndex = 40;
            this.Label16.Text = "User Name";
            // 
            // cmdSave
            // 
            this.cmdSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Location = new System.Drawing.Point(17, 266);
            this.cmdSave.Margin = new System.Windows.Forms.Padding(2);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(104, 42);
            this.cmdSave.TabIndex = 39;
            this.cmdSave.Text = "SAVE";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // chkUseDefaultSettings
            // 
            this.chkUseDefaultSettings.AutoSize = true;
            this.chkUseDefaultSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUseDefaultSettings.Location = new System.Drawing.Point(125, 151);
            this.chkUseDefaultSettings.Margin = new System.Windows.Forms.Padding(2);
            this.chkUseDefaultSettings.Name = "chkUseDefaultSettings";
            this.chkUseDefaultSettings.Size = new System.Drawing.Size(170, 24);
            this.chkUseDefaultSettings.TabIndex = 37;
            this.chkUseDefaultSettings.Text = "Use default settings";
            this.chkUseDefaultSettings.UseVisualStyleBackColor = true;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(42, 91);
            this.Label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(78, 20);
            this.Label15.TabIndex = 41;
            this.Label15.Text = "Password";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(20, 24);
            this.Label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(101, 20);
            this.Label13.TabIndex = 36;
            this.Label13.Text = "Server Name";
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwd.Location = new System.Drawing.Point(129, 88);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(2);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(186, 26);
            this.txtPwd.TabIndex = 34;
            // 
            // chkEnableSSL
            // 
            this.chkEnableSSL.AutoSize = true;
            this.chkEnableSSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableSSL.Location = new System.Drawing.Point(125, 178);
            this.chkEnableSSL.Margin = new System.Windows.Forms.Padding(2);
            this.chkEnableSSL.Name = "chkEnableSSL";
            this.chkEnableSSL.Size = new System.Drawing.Size(113, 24);
            this.chkEnableSSL.TabIndex = 38;
            this.chkEnableSSL.Text = "Enable SSL";
            this.chkEnableSSL.UseVisualStyleBackColor = true;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(83, 121);
            this.Label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(38, 20);
            this.Label14.TabIndex = 42;
            this.Label14.Text = "Port";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(129, 54);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(186, 26);
            this.txtUserName.TabIndex = 33;
            // 
            // txtInvColumn
            // 
            this.txtInvColumn.Location = new System.Drawing.Point(439, 113);
            this.txtInvColumn.Name = "txtInvColumn";
            this.txtInvColumn.Size = new System.Drawing.Size(202, 26);
            this.txtInvColumn.TabIndex = 14;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtCrnColumn
            // 
            this.txtCrnColumn.Location = new System.Drawing.Point(832, 113);
            this.txtCrnColumn.Name = "txtCrnColumn";
            this.txtCrnColumn.Size = new System.Drawing.Size(202, 26);
            this.txtCrnColumn.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Inv Column:.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(717, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "CRN Column:.";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 481);
            this.Controls.Add(this.Panel1);
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.Panel1.ResumeLayout(false);
            this.TabControlSettings.ResumeLayout(false);
            this.tbPGeneral.ResumeLayout(false);
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.grpPrinter.ResumeLayout(false);
            this.grpPrinter.PerformLayout();
            this.grpFileWatcher.ResumeLayout(false);
            this.grpFileWatcher.PerformLayout();
            this.tbPEmail.ResumeLayout(false);
            this.grpEmail.ResumeLayout(false);
            this.grpEmail.PerformLayout();
            this.grpSmtp.ResumeLayout(false);
            this.grpSmtp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.TabControl TabControlSettings;
        internal System.Windows.Forms.TabPage tbPGeneral;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.TabPage tbPEmail;
        internal System.Windows.Forms.Button cmdLoad;
        internal System.Windows.Forms.Button cmdTest;
        internal System.Windows.Forms.TextBox txtServer;
        internal System.Windows.Forms.CheckBox chkUseDefaultSettings;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.CheckBox chkEnableSSL;
        internal System.Windows.Forms.TextBox txtUserName;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.TextBox txtPwd;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Button cmdSave;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.TextBox txtPort;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.GroupBox grpFileWatcher;
        private System.Windows.Forms.Label lblWatchFolder;
        private System.Windows.Forms.FolderBrowserDialog fbdFileWatcherFolder;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.ComboBox cboFileExtensions;
        private System.Windows.Forms.CheckBox chkSubDirectories;
        private System.Windows.Forms.Label lblFileExtention;
        private System.Windows.Forms.TextBox txtTimer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.GroupBox grpPrinter;
        private System.Windows.Forms.CheckBox chkPrintDoc;
        private System.Windows.Forms.Label lblDefaultPrinter;
        private System.Windows.Forms.ComboBox cboPrinter;
        private System.Windows.Forms.CheckBox chkArchiveDocs;
        private System.Windows.Forms.GroupBox grpEmail;
        private System.Windows.Forms.TextBox txtMailBody;
        private System.Windows.Forms.TextBox txtInternalEmail;
        private System.Windows.Forms.Label lblInternalEmail;
        private System.Windows.Forms.CheckBox chkSendEmail;
        private System.Windows.Forms.Label lblEmailBody;
        private System.Windows.Forms.GroupBox grpSmtp;
        internal System.Windows.Forms.Button btnSaveEamil;
        private System.Windows.Forms.GroupBox grpGeneral;
        private System.Windows.Forms.CheckBox chkRestoreDeletedDocs;
        private System.Windows.Forms.Button btnSelectCopyFolder;
        private System.Windows.Forms.TextBox txtCopyFolderPath;
        private System.Windows.Forms.ComboBox cboDelimeter;
        private System.Windows.Forms.Label lblDelimeter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCrnColumn;
        private System.Windows.Forms.TextBox txtInvColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}