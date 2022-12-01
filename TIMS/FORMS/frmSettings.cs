using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TIMS.MODULES;
using static TIMS.MODULES.CommonFunctions;

namespace TIMS.FORMS
{
    public partial class frmSettings : Form
    {
        string SQL;
        DataTable DT;
        string PwdKey = "65f02fab40f56c8e409b121965fa1d657a80d237fabacab95f9c59f8f967becb";
        string FPath = "";
        string SERVER = "";
        string User = "";
        string PWD = "";
        string PORT = "";
        string SSL = "";
        string DEFSETTING = "";

        public frmSettings()
        {
            InitializeComponent();
        }

        private void SAVE_SETTINGS()
        {
            var wrapper = new Simple3Des(PwdKey);

           
            int J = 0;

            if (string.IsNullOrEmpty(Strings.Trim(txtServer.Text)))
            {
                Interaction.MsgBox("Please a valid Server name");
                return;
            }
            else if (string.IsNullOrEmpty(Strings.Trim(txtUserName.Text)))
            {
                Interaction.MsgBox("Please enter valid User Name");
                return;
            }
            else if (string.IsNullOrEmpty(Strings.Trim(txtPwd.Text)))
            {
                Interaction.MsgBox("Please enter valid password");
                return;
            }
            else if (string.IsNullOrEmpty(Strings.Trim(txtPort.Text)))
            {
                Interaction.MsgBox("Please enter valid email port number");
                return;
            }

            FPath = Application.ExecutablePath; // & "\AppInfo.Log"
            J = Strings.InStrRev(FPath, @"\");
            FPath = Strings.Mid(FPath, 1, J);
            FPath = FPath + "Server.Log";

            // If File.Exists(FPath) = False Then
            // 'Debug.Print(FPath)
            // MsgBox("Please enter Email Server details")
            // Exit Sub
            // End If

            try
            {
                TextWriter writeFile = new StreamWriter(FPath);
                // LINE 1: EMAIL SERVER NAME
                writeFile.WriteLine(wrapper.EncryptData(txtServer.Text));
                // LINE 2: EMAIL USER NAME
                writeFile.WriteLine(wrapper.EncryptData(txtUserName.Text));
                // LINE 3: EMAIL PASSWORD
                writeFile.WriteLine(wrapper.EncryptData(txtPwd.Text));
                // LINE 4: EMAIL PORT#
                writeFile.WriteLine(wrapper.EncryptData(txtPort.Text));
                // LINE 5: ENABLE SSL (Y/N)
                if (chkEnableSSL.CheckState == CheckState.Checked)
                {
                    writeFile.WriteLine(wrapper.EncryptData("1"));
                }
                else if (chkEnableSSL.CheckState == CheckState.Unchecked)
                {
                    writeFile.WriteLine(wrapper.EncryptData("0"));
                }
                // LINE 6: USE DEFAULT SETTINGS (Y/N)
                if (chkUseDefaultSettings.CheckState == CheckState.Checked)
                {
                    writeFile.WriteLine(wrapper.EncryptData("1"));
                }
                else if (chkUseDefaultSettings.CheckState == CheckState.Unchecked)
                {
                    writeFile.WriteLine(wrapper.EncryptData("0"));
                }


                writeFile.Flush();
                writeFile.Close();
                writeFile = null;
            }
            catch (IOException ex)
            {
                Interaction.MsgBox(ex.ToString());
            }
            MessageBox.Show("Server details saved successfully", " Email Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //this.Close();
        }

        private bool GET_SETTINGS()
        {
            bool GET_SETTINGSRet = false;
            int J = 0;
            // Checking if the Email Setting file is present
            string EmailSettingFileLocation;
            //EmailSettingFileLocation = global::Application.Info.DirectoryPath + @"\Server.Log";
            FPath = Application.ExecutablePath; // & "\AppInfo.Log"
            J = Strings.InStrRev(FPath, @"\");
            FPath = Strings.Mid(FPath, 1, J);
            FPath = FPath + "Server.Log";
            EmailSettingFileLocation = FPath;
            if (File.Exists(EmailSettingFileLocation) == false)
            {
                // the file doesn't exist. Tell user to open Email Settings form
                // frmEmailSettings
                Interaction.MsgBox("Email settings not found. Please provide Email Settings");
                return false;
            }

            var wrapper = new Simple3Des(PwdKey);
            int I = 1;

            FPath = Application.ExecutablePath; // & "\AppInfo.Log"
            I = Strings.InStrRev(FPath, @"\");
            FPath = Strings.Mid(FPath, 1, I);
            FPath = FPath + "Server.Log";

            I = 1;

            if (File.Exists(FPath) == false)
            {
                // Debug.Print(FPath)
                Interaction.MsgBox("Setting file not found. Please enter the settings and save");
                GET_SETTINGSRet = false;
                return GET_SETTINGSRet;
            }

            try
            {
                string line;
                TextReader readFile = new StreamReader(FPath);
                while (true)
                {
                    line = readFile.ReadLine();
                    if (line is null)
                    {
                        break;
                    }
                    else
                    {
                        switch (I)
                        {
                            case 1:
                                {
                                    SERVER = wrapper.DecryptData(line);
                                    break;
                                }
                            case 2:
                                {
                                    User = wrapper.DecryptData(line);
                                    break;
                                }
                            case 3:
                                {
                                    PWD = wrapper.DecryptData(line);
                                    break;
                                }
                            case 4:
                                {
                                    PORT = wrapper.DecryptData(line);
                                    break;
                                }
                            case 5:
                                {
                                    SSL = wrapper.DecryptData(line);
                                    break;
                                }
                            case 6:
                                {
                                    DEFSETTING = wrapper.DecryptData(line);
                                    break;
                                }
                        }
                        I += 1;
                    }
                }
                readFile.Close();
                readFile = null;

                txtServer.Text = SERVER;
                txtPwd.Text = PWD;
                txtPort.Text = PORT;
                txtUserName.Text = User;
                if (SSL == "0")
                {
                    chkEnableSSL.Checked = false;
                }
                else
                {
                    chkEnableSSL.Checked = true;
                }
                if (DEFSETTING == "0")
                {
                    chkUseDefaultSettings.Checked = false;
                }
                else
                {
                    chkUseDefaultSettings.Checked = true;
                }

                CommonFunctions.EmailServerName = SERVER;
                CommonFunctions.EmailUserName = User;
                CommonFunctions.EmailPassword = PWD;
                CommonFunctions.MailServerPort = Convert.ToInt32(PORT);
                CommonFunctions.UseSSL = Convert.ToBoolean(chkEnableSSL.CheckState);
                CommonFunctions.UseDefaultSettings = Convert.ToBoolean(chkUseDefaultSettings.CheckState);

                GET_SETTINGSRet = true;
            }

            catch (IOException ex)
            {
                Interaction.MsgBox(ex.ToString());
                GET_SETTINGSRet = false;
            }

            return GET_SETTINGSRet;

        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            SAVE_SETTINGS();
        }

        private void cmdTest_Click(object sender, EventArgs e)
        {
            if (GET_SETTINGS() == false)
            {
                return;
            }
            //var test = new SendEmail("PJ@TIKONE.BIZ", "PJ TIKONE", "PJ@WIZAG.BIZ", "PJ WIZAG", "This is a test message", false, "", "This is your email");
            if (SendEmail("PJ@TIKONE.BIZ", "PJ TIKONE", "PJ@WIZAG.BIZ", "PJ WIZAG", "This is a test message", false, "", "This is your email") == true)
            {
                Interaction.MsgBox("Email settings tested successfully!");
            }
            else
            {
                Interaction.MsgBox("Email settings have issue. Please re-enter the settings and try again.");
            }
        }

        private void cmdLoad_Click(object sender, EventArgs e)
        {
            GET_SETTINGS();
        }

        private void TabControlSettings_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TabControlSettings.SelectedIndex)
            {
                case 0:  // General Settings
                    {
                        LoadDelimeter();
                        LoadExtensions();
                        LoadGeneralSettings();                        
                        break;
                    }
                case 1:  // Email Settings
                    {
                        GET_SETTINGS();
                        break;                        
                    }               

            }
        }

        private void LoadGeneralSettings()
        {
            SQL = "SELECT isnull(PrinterName,'') [PrinterName],ISNULL([SendEmail],'FALSE') SendEmail,ISNULL([SendEmailCopy],'FALSE') SendEmailCopy,ISNULL([CopyEmailAddress],'') CopyEmailAddress,ISNULL([WatchFolderPath],'') WatchFolderPath,ISNULL([FileExtension],'') FileExtension ,isnull([CheckSubDirectories],'FALSE') CheckSubDirectories, isnull(Timer,0) Timer, ISNULL(PrintDocuments,'FALSE') [PrintDocuments], ISNULL(ArchiveDocs,'FALSE') [ArchiveDocs], ISNULL(RestoreDocs,'FALSE')[RestoreDocs], ISNULL(EmailBody,'') [EmailBody], isnull(CopyFolderPath,'') CopyFolderPath, isnull(Delimiter,'') Delimiter, isnull(InvColumn,'') InvColumn, isnull(CrnColumn,'') CrnColumn FROM [dbo].[wizESDSettings]";

            DT = new DataTable();
            LoadDatatable(SQL, DT);
            if (DT.Rows.Count > 0)
            {
                //MessageBox.Show("Kindly contact administrator.", "Error in Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //DT = null;
                //return;
                txtFolderPath.Text = DT.Rows[0]["WatchFolderPath"].ToString();
                cboFileExtensions.Text = DT.Rows[0]["FileExtension"].ToString();
                cboDelimeter.Text = DT.Rows[0]["Delimiter"].ToString();
                chkSubDirectories.Checked = Convert.ToBoolean(DT.Rows[0]["CheckSubDirectories"]);
                txtTimer.Text = DT.Rows[0]["Timer"].ToString();
                chkArchiveDocs.Checked = Convert.ToBoolean(DT.Rows[0]["ArchiveDocs"]);
                txtCopyFolderPath.Text = DT.Rows[0]["CopyFolderPath"].ToString();
                cboPrinter.Text = DT.Rows[0]["PrinterName"].ToString();
                chkPrintDoc.Checked = Convert.ToBoolean(DT.Rows[0]["PrintDocuments"]);
                chkRestoreDeletedDocs.Checked = Convert.ToBoolean(DT.Rows[0]["RestoreDocs"]);
                chkSendEmail.Checked = Convert.ToBoolean(DT.Rows[0]["SendEmail"]);
                txtInternalEmail.Text = DT.Rows[0]["CopyEmailAddress"].ToString();
                txtMailBody.Text = DT.Rows[0]["EmailBody"].ToString();
                txtInvColumn.Text = DT.Rows[0]["InvColumn"].ToString();
                txtCrnColumn.Text = DT.Rows[0]["CrnColumn"].ToString();
            }

            
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {         
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                // shows the path to the selected folder in the folder dialog
                txtFolderPath.Text = fbd.SelectedPath;            
            //MessageBox.Show(fbd.SelectedPath);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isDirectoryValid(@txtFolderPath.Text))
            {
                try
                {
                    //Check if settings table has values
                    SQL = "SELECT COUNT( *) FROM wizESDSettings";

                    if (FetchSingleIntValue(SQL, true, false) == 0)
                    {
                        SQL = " INSERT INTO wizESDSettings (WatchFolderPath, FileExtension, PrinterName, CheckSubDirectories, Timer, PrintDocuments, ArchiveDocs, RestoreDocs,CopyFolderPath , Delimiter, InvColumn, CrnColumn) VALUES ('" + @txtFolderPath.Text + "', '" + cboFileExtensions.Text + "', '" + cboPrinter.Text + "','" + chkSubDirectories.Checked + "', "+Convert.ToInt32(txtTimer.Text)+", '"+chkPrintDoc.Checked+"', '"+ chkArchiveDocs.Checked + "', '"+ chkRestoreDeletedDocs.Checked + "', '" + txtCopyFolderPath.Text + "', '" + cboDelimeter.Text + "','" + txtInvColumn.Text +"','"+ txtCrnColumn.Text +"') ";
                    }
                    else
                    {
                        SQL = " UPDATE wizESDSettings SET WatchFolderPath='" + @txtFolderPath.Text + "', FileExtension='" + cboFileExtensions.Text + "', PrinterName='" + cboPrinter.Text + "', CheckSubDirectories='" + chkSubDirectories.Checked + "', Timer ="+Convert.ToInt32(txtTimer.Text) + ", PrintDocuments='" + chkPrintDoc.Checked + "', ArchiveDocs='" + chkArchiveDocs.Checked + "', RestoreDocs='" + chkRestoreDeletedDocs.Checked + "', CopyFolderPath='" + txtCopyFolderPath.Text + "', Delimiter='" + cboDelimeter.Text + "', InvColumn='"+ txtInvColumn.Text + "', CrnColumn='"+ txtCrnColumn.Text + "'";
                    }                    

                    if (ExecuteQuery(SQL)) MessageBox.Show("Saved successfully", "Save settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message , " Save settings failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               
                
            }
            else
            {
                MessageBox.Show(@txtFolderPath.Text + " -  Watch Directory Invalid", "File Watch Folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {            
            TabControlSettings.SelectedIndex = 0;
            TabControlSettings_SelectedIndexChanged(sender, e);
        }

        public void LoadExtensions()
        {
            // SQL = "select idUnits, cUnitCode from _etblUnits where iUnitCategoryID = 3"
            // Call LoadCombo(SQL, cboAltUnits, "idUnits", "cUnitCode", False, False)
            cboFileExtensions.Items.Clear();
            cboFileExtensions.Items.Add(".pdf");
            cboFileExtensions.Items.Add(".txt");
            cboFileExtensions.SelectedIndex = 0;
        }

        public void LoadDelimeter()
        {
            // SQL = "select idUnits, cUnitCode from _etblUnits where iUnitCategoryID = 3"
            // Call LoadCombo(SQL, cboAltUnits, "idUnits", "cUnitCode", False, False)
            cboDelimeter.Items.Clear();
            cboDelimeter.Items.Add("Space");
            cboDelimeter.Items.Add("Comma");
            cboDelimeter.Items.Add("Dash");
            cboDelimeter.SelectedIndex = 0;
        }

        private void txtTimer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Strings.Asc(e.KeyChar) != 8)
            {
                if (Strings.Asc(e.KeyChar) < 48 | Strings.Asc(e.KeyChar) > 57)
                {
                    e.Handled = true;
                }
            }
        }

        private void LoadPrinters()
        {
            // Loading all printers
            CommonFunctions.LoadPrinters(cboPrinter);
        }

        private void btnSaveEamil_Click(object sender, EventArgs e)
        {
            try
            {
                //Check if settings table has values
                SQL = "SELECT COUNT( *) FROM wizESDSettings";

                if (FetchSingleIntValue(SQL, true, false) == 0)
                {
                    SQL = " INSERT INTO wizESDSettings (SendEmail, SendEmailCopy, CopyEmailAddress, EmailBody) VALUES ('" + chkSendEmail.Checked + "', '" + chkSendEmail.Checked + "', '" + txtInternalEmail.Text + "','" + txtMailBody.Text + "') ";
                }
                else
                {
                    SQL = " UPDATE wizESDSettings SET SendEmail='" + chkSendEmail.Checked + "', SendEmailCopy='" + chkSendEmail.Checked + "', CopyEmailAddress='" + txtInternalEmail.Text + "', EmailBody='" + txtMailBody.Text + "'";
                }

                if (ExecuteQuery(SQL)) MessageBox.Show("Saved successfully", "Save settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " Save settings failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectCopyFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                // shows the path to the selected folder in the folder dialog
                txtCopyFolderPath.Text = fbd.SelectedPath;
            //MessageBox.Show(fbd.SelectedPath);
        }
    }
}
