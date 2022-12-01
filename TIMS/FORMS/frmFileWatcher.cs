using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Timers;
using System.Windows.Forms;
using static TIMS.MODULES.CommonFunctions;
using WIZLICENCE;
using System.Threading.Tasks;

namespace TIMS.FORMS
{

    public partial class frmFileWatcher : Form
    {        
        public bool isWatching;
        private static System.Timers.Timer aTimer;
        FileSystemWatcher watcher;
        private string filePath = string.Empty;
        DateTime lastRead = DateTime.MinValue;
        static readonly object locker = new object();
        public string Path = "";
        delegate void SetTextCallback(string text);
        public string Extension = "";
        public double CheckTime = 0.00;
        string SQL;
        DataTable DT;
        string newLine = Environment.NewLine;
        public bool IncludeSubDirectories = false;
        public bool ArchiveDocs = false;
        public bool PrintDoc = false;
        public bool RestoreDeletedDocs = false;
        public bool SendEmail = false;
        public string InternalEmail = "";
        public string EmailBody = "";
        public string DefaultPrinter = "";
        public string QueryFilter, sqlWhereClause, CopyFolderPath, Delimter, InvColumn, CrnColumn = string.Empty;
        private LicenceInfo licenceInfo = new LicenceInfo();

        public frmFileWatcher()
        {
            InitializeComponent();
        }

        private void btnWatcher_Click(object sender, EventArgs e)
        {
            //We want to check whether the filewatche is on or not and display usefull signal to the user either to start or stop  
            if (isWatching)
            {
                btnWatcher.Text = "Start Watching "+ newLine;
                stopWatching();
            }
            else
            {
                btnWatcher.Text = "Stop Watching "+ newLine;
                startWatching();
            }
        }

        private void startWatching()
        {
            LoadSettings();
            if (!isDirectoryValid(@Path))
            {
                SetText(DateTime.Now + " - Watch Directory Invalid "+ newLine);
                return;
            }
            isWatching = true;
            SetTimer();
            SetText(DateTime.Now + " - Watcher Started "+ newLine);

            watcher = new FileSystemWatcher();
            // Watch both files and subdirectories.  
            watcher.IncludeSubdirectories = IncludeSubDirectories;
            watcher.Path = Path;
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
               | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            watcher.Filter = "*" + Extension;
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnChanged);
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.EnableRaisingEvents = true;
            //await Task.Delay(1);
        }

        private static void SetTimer()
        {
            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer(500);
            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private void stopWatching()
        {
            isWatching = false;
            aTimer.Enabled = false;
            aTimer.Stop();
            SetText(DateTime.Now + " - Watcher Stopped "+ newLine);
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
                              e.SignalTime);
        }

        protected void OnChanged(object source, FileSystemEventArgs e)
        {
            //Specify what to do when a file is changed, created, or deleted    
            switch (e.ChangeType.ToString())
            {
                case "Changed":
                    // code block
                    break;
                case "Created":
                    // code block
                    OnCreateMethod(e);
                    break;
                case "Deleted":

                    break;               
            }
            
        }

        private void OnCreateMethod(FileSystemEventArgs e)
        {
            try
            {
                while (IsFileLocked(e.FullPath))
                {
                    System.Threading.Thread.Sleep(100);
                }

                lock (locker)
                {
                    //Process file  
                    //Do further activities  
                    DateTime lastWriteTime = File.GetLastWriteTime(e.FullPath);
                    if (lastWriteTime != lastRead)
                    {
                        FileInfo file = new FileInfo(e.FullPath);
                        //Process File
                        if (ProcessFiles(file))
                        {
                            SetText("File: \"" + e.FullPath + "\"- " + e.ChangeType + "\" - " + DateTime.Now + " - Processed the changes successfully " + newLine);
                            lastRead = lastWriteTime;
                        }
                        else{
                            SetText("File: \"" + e.FullPath + "\" ERROR processing file contact administratror." + newLine);
                        } 
                        
                        if (ArchiveDocs)
                        {
                            String Todaysdate = DateTime.Now.ToString("MMM yyyy");
                            if (!Directory.Exists(@CopyFolderPath + '\\' + Todaysdate))
                            {
                                Directory.CreateDirectory(@CopyFolderPath + '\\' + Todaysdate);
                            }
                            File.Copy(@e.FullPath, @CopyFolderPath + '\\' + Todaysdate + '\\' + file.Name, true);
                        }

                        //Send email
                        SendEmailMethod(e, lastWriteTime);

                        //Automatically print
                        if (PrintDoc)
                        {
                            try
                            {
                                Default_Printer = DefaultPrinter;
                                //SendToPrinter(e.FullPath);

                                SetText("File: \"" + e.FullPath + "\" sent to printer ("+ Default_Printer + ")" + newLine);
                            }
                            catch (Exception ex)
                            {
                                SetText("File: \"" + e.FullPath + "\" ERROR printing file (" + ex.Message + ")" + newLine);
                            }
                           
                        }

                    }
                }
            }
            catch (FileNotFoundException)
            {
                //Stop processing  
            }
            catch (Exception ex)
            {
                SetText("File: \"" + e.FullPath + "\" ERROR processing file (" + ex.Message + ")" + newLine);
            }
        }

        private void SendEmailMethod(FileSystemEventArgs e, DateTime lastWriteTime)
        {
            try
            {
                if (SendEmail)
                {
                    if (!GET_EMAIL_SETTINGS())
                    {
                        SetText("File: \"" + e.FullPath + "\" Error in Email configurations. Please get in touch with the administrators." + newLine);
                        return;
                    }
                    if (SendEmail("test@gmail.com", "test", "info@test.com", "company", EmailBody, true, e.FullPath, "Test subject"))
                    {
                        SetText("File: \"" + e.FullPath + "\"- " + e.ChangeType + "\" - " + DateTime.Now + " - email sent successfully " + newLine);
                        lastRead = lastWriteTime;
                    }
                    else
                    {
                        SetText("File: \"" + e.FullPath + "\" Error in Email configurations. Please get in touch with the administrators." + newLine);
                    }

                }

            }
            catch (Exception ex)
            {
                SetText("File: \"" + e.FullPath + "\" ERROR sending email (" + ex.Message + ")" + newLine);
            }
        }

        private static bool IsFileLocked(string file)
        {
            FileStream stream = null;

            try
            {
                stream = new FileInfo(file).Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (FileNotFoundException err)
            {
                throw err;
            }
            catch (IOException)
            {
                //the file is unavailable because it is:  
                //still being written to  
                //or being processed by another thread  
                //or does not exist (has already been processed)  
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            //file is not locked  
            return false;
        }

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtEvents.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtEvents.Text += text;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var frmSettings = new frmSettings();
            frmSettings.ShowDialog();
        }

        private void frmFileWatcher_Load(object sender, EventArgs e)
        {
            StatusBarServer.Text = "Server : " + SageServerName;
            StatusBarDB.Text = " |  Database : " + SageDBName;
            StatusActiveUSER.Text = " |  User : " + activeUSER;
            StatusVerion.Text = " |  " + AppVersion;
            LicenceType.Text = " |  Licence Type : " + AppLicenceType;
            DaysRemaining.Text = " |  Remaining Days :  " + AppDaysRemaining.ToString();
            LoadSettings();
            startWatching();
            //txtEvents.Text = licenceInfo.GetMachineInfo();
        }

        private void LoadSettings()
        {
            SQL = "SELECT isnull(PrinterName,'') [PrinterName],ISNULL([SendEmail],'FALSE') SendEmail,ISNULL([SendEmailCopy],'FALSE') SendEmailCopy,ISNULL([CopyEmailAddress],'') CopyEmailAddress,ISNULL([WatchFolderPath],'') WatchFolderPath,ISNULL([FileExtension],'') FileExtension ,isnull([CheckSubDirectories],'FALSE') CheckSubDirectories, isnull(Timer,0) Timer, ISNULL(PrintDocuments,'FALSE') [PrintDocuments], ISNULL(ArchiveDocs,'FALSE') [ArchiveDocs], ISNULL(RestoreDocs,'FALSE')[RestoreDocs], ISNULL(EmailBody,'') [EmailBody], ISNULL(CopyFolderPath,'') CopyFolderPath, isnull(Delimiter,'') Delimiter, isnull(InvColumn,'') InvColumn, isnull(CrnColumn,'') CrnColumn FROM [dbo].[wizESDSettings]";
            DT = new DataTable();
            LoadDatatable(SQL, DT);
            if (DT.Rows.Count > 0)
            {
                DefaultPrinter = DT.Rows[0]["PrinterName"].ToString();
                Path = DT.Rows[0]["WatchFolderPath"].ToString();
                txtFolderPath.Text = Path;
                Extension = DT.Rows[0]["FileExtension"].ToString();
                CheckTime = Convert.ToInt32(DT.Rows[0]["Timer"]);
                IncludeSubDirectories = Convert.ToBoolean(DT.Rows[0]["CheckSubDirectories"]);
                ArchiveDocs = Convert.ToBoolean(DT.Rows[0]["ArchiveDocs"]);
                PrintDoc = Convert.ToBoolean(DT.Rows[0]["PrintDocuments"]);
                CopyFolderPath = DT.Rows[0]["CopyFolderPath"].ToString();
                RestoreDeletedDocs = Convert.ToBoolean(DT.Rows[0]["RestoreDocs"]);
                SendEmail = Convert.ToBoolean(DT.Rows[0]["SendEmail"]);
                InternalEmail = DT.Rows[0]["CopyEmailAddress"].ToString();
                EmailBody = DT.Rows[0]["EmailBody"].ToString();
                Delimter = DT.Rows[0]["Delimiter"].ToString();
                InvColumn = DT.Rows[0]["InvColumn"].ToString();
                CrnColumn = DT.Rows[0]["CrnColumn"].ToString();
            }

            
        }

        private bool ProcessFiles(FileInfo file)
        {
            bool ProcessFiles;
            string filename = file.Name.Substring(0, file.Name.Length - file.Extension.Length);
            string[] fileNameArray = null;

            switch (Delimter.ToString())
            {
                case "Comma":
                    // code block
                    fileNameArray = filename.Split(',');
                    break;
                case "Space":
                    // code block
                    fileNameArray = filename.Split(new char[0]);
                    break;
                case "Dash":
                    fileNameArray = filename.Split('-');
                    break;
            }           

            SQL = "SELECT i.DocType FROM InvNum i WHERE i.InvNumber = '" + fileNameArray[0] + "'";
            int DocType = FetchSingleIntValue(SQL, true, false);

            //Invoices
            if (DocType == 0 || DocType == 4)
            {
                //Check if column is there else create
                //SQL= "IF NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'InvNum' AND COLUMN_NAME = '"+ InvColumn + "') BEGIN ALTER TABLE InvNum ADD "+ InvColumn + " VARCHAR(50) END";
                //ExecuteQuery(SQL);

                //SQL = "UPDATE InvNum SET " + InvColumn + " = '" + fileNameArray[1] + "' WHERE InvNumber = '" + fileNameArray[0] + "'";
            }

            //Credit Notes
            if (DocType == 1)
            {
                //Check if column is there else create
                //SQL = "IF NOT EXISTS(SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'InvNum' AND COLUMN_NAME = '" + CrnColumn + "') BEGIN ALTER TABLE InvNum ADD " + CrnColumn + " VARCHAR(50) END";
                //ExecuteQuery(SQL);

                //SQL = "UPDATE InvNum SET " + CrnColumn + " = '" + fileNameArray[1] + "' WHERE InvNumber = '" + fileNameArray[0] + "'";
            }
            

            //***** Update the invnum table with the MWTxNumber ffrom the document
            //SQL = "UPDATE InvNum SET ucIDSOrdMWNo = '" + fileNameArray[1] + "' WHERE InvNumber = '" + fileNameArray[0] + "'";

            if (ExecuteQuery(SQL))
            {
                SQL = "INSERT INTO wizESDDocumentDetails (FileName, InvoiceNumber, MWTxNumber, DocType) VALUES ('" + file.Name + "', '" + fileNameArray[0] + "', '" + fileNameArray[1] + "', " + DocType + " )";

                if (ExecuteQuery(SQL))
                {
                    ProcessFiles = true;
                }
                else
                {
                    ProcessFiles = false;
                }
            }
            else
            {
                ProcessFiles = false;
            }            

            return ProcessFiles;
        }

        private void LoadProcessedFiles()
        {
            QueryFilter = " convert(varchar(10), d.EntryDate, 112) BETWEEN '" + dtpFrom.Value.ToString("yyyyMMdd", CultureInfo.InvariantCulture) + "' AND '" + dtpTo.Value.ToString("yyyyMMdd", CultureInfo.InvariantCulture) + "' AND";

            if (txtAccountName.Text.Length > 0) QueryFilter += " i.cAccountName like '%" + txtAccountName.Text + "%' AND";

            if (txtInvNum.Text.Length > 0) QueryFilter += " i.InvNumber like '%" + txtInvNum.Text + "%' AND";

            if (txtOrderNum.Text.Length > 0) QueryFilter += " i.ExtOrderNum like '%" + txtOrderNum.Text + "%' AND";

            if (txtMWTxNum.Text.Length > 0) QueryFilter += " i.ucIDSOrdMWNo like '%" + txtMWTxNum.Text + "%' AND";

            if (!string.IsNullOrEmpty(QueryFilter))
            {
                string[] array = QueryFilter.Split(' ');

                string last_word = array[array.Length - 1];

                if (last_word == "AND")
                {
                    sqlWhereClause = "WHERE " + QueryFilter.Remove(QueryFilter.Length - last_word.Length);
                }
                else
                {
                    sqlWhereClause = "WHERE " + QueryFilter;
                }
            }
            else
            {
                sqlWhereClause = " ";
            }

            SQL = "select D.FileName [File Name],d.EntryDate [Processed Date], i.cAccountName [Account], i.InvDate [Inv Date], i.InvNumber [Inv Number], i.ExtOrderNum [Order Number], FORMAT(i.InvTotExcl,'n2') [Inv Total Excl], FORMAT(i.InvTotIncl,'n2') [Inv Total Incl], D.MWTxNumber [MWTxNumber] FROM wizESDDocumentDetails D INNER JOIN InvNum i ON I.InvNumber = D.InvoiceNumber " + sqlWhereClause;
            LoadDataGrid(dgItems, SQL, "", "");
            dgItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:  //Watcher
                    {
                        LoadSettings();
                        break;
                    }
                case 1:  // Data
                    {
                        dtpFrom.Value = DateTime.Now;
                        dtpTo.Value = DateTime.Now;
                        LoadProcessedFiles();
                        break;
                    }

            }
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadProcessedFiles();
        }

        private void dgItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) {
                return;
            }
            if ( dgItems.RowCount ==0)
            {
                return;
            }

            if (dgItems.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgItems.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgItems.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["File Name"].Value);
                var filename = cellValue;

                var frmPdfViewer = new frmPdfViewer();
                // use the LoadFile(ByVal fileName As String) function for open the pdf in control  
                frmPdfViewer.axAcroPDFViewer.LoadFile(@Path + "\\"+ cellValue);
                frmPdfViewer.ShowDialog();
            }
            
        }
    }
}
