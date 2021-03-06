﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text.RegularExpressions;
using System.DirectoryServices;
using System.Diagnostics;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Net;
using System.Net.NetworkInformation;
using System.Configuration;
using CMail.Properties;

namespace CMail
{
    public partial class MainForm : Form
    {
        private bool IsStarted = false;
        private static string numberPattern = "{0}";
        public List<Computers> DeserializedComputers { get; set; }

        Dictionary<string, string> specialist = new Dictionary<string, string>
        {
            ["work11"] = "Климова%05",
            ["work29"] = "Денисенко%05",
            ["work47"] = "Королева%06",
            ["work48"] = "Миронкина%06",
            ["del1"] = "Кузнецова%01",
            ["del2"] = "Денисенко%01",
            ["buh4"] = "Березникова%02",
            ["buh5"] = "Агеева%02",
            ["buh1"] = "Опольская%02",
            ["kro1"] = "Климачева%04",
            ["kro2"] = "Калюжная%04",
            ["del3"] = "Ломакина%01",
            ["pers1"] = "Дмитриенко%03",
            ["jur3"] = "Андрош%08",
            ["Alt"] = " % ",
            ["Dim"] = "Шалько%07",


        };

        
        public List<Computers> DisplayedComputers { get; set; }
        public MainForm()
        {
            InitializeComponent();
            this.AllowDrop = true;
            FilesToSendList.DragEnter += new DragEventHandler(FilesToSendList_DragEnter);
            FilesToSendList.DragDrop += new DragEventHandler(FilesToSendList_DragDrop);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitNetDirectory();
            departmentNum.SelectedIndex = 0;
            ProgressBar.Visible = false;
            ProgressBar.Minimum = 1;
            ProgressBar.Maximum = NetDirectoryList.Items.Count;
            ProgressBar.Value = 1;
            ProgressBar.Step = 1;

            IBFolderSettings.Text = Settings.Default.InboxFolder.ToString();
            IBAFolderSettings.Text = Settings.Default.InboxArchiveFolder.ToString();
            OrgFolderSettings.Text = Settings.Default.DelovodFolder.ToString();
            OBFolderSettings.Text = Settings.Default.OutboxFolder.ToString();
            OBNKFolderSettings.Text = Settings.Default.OutboxNotkillFolder.ToString();
            FilesOutFolderSettings.Text = Settings.Default.OutboxSendingFolder.ToString();
            OABFolderSettings.Text = Settings.Default.OutboxArchiveFolder.ToString();
            CompInfoSettings.Text = Settings.Default.ComputersInfoJSON.ToString();

        }

        private void OutboxFilesScan()
        {
            FilesToSendList.Items.Clear();
            string[] outboxFiles = Directory.GetFiles(Settings.Default.OutboxSendingFolder.ToString());
            foreach (string file in outboxFiles)
            {
                FileInfo fileInfo = new FileInfo(file);
                FilesToSendList.Items.Add(fileInfo.Name);
            }
        }

        public void Watch(string path, bool isInbox)
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = path;
            switch (isInbox)
            {
                case true:
                    watcher.Created += FileSystemWatcherInbox_Created;
                    watcher.Changed += FileSystemWatcherInbox_Created;
                    break;
                case false:
                    watcher.Created += FileSystemWatcherOutbox_Created;
                    watcher.Changed += FileSystemWatcherOutbox_Created;
                    watcher.Renamed += FileSystemWatcherOutbox_Renamed;
                    watcher.Deleted += FileSystemWatcherOutbox_OnChanged;
                    break;
                default:
                    break;
            }

            if (IsStarted)
            {
                watcher.EnableRaisingEvents = true;
            }
            else
            {
                watcher.EnableRaisingEvents = false;
            }
        }

        public void FileSystemWatcherInbox_Created(object source, FileSystemEventArgs e)
        {
            string currDateDirectory1 = Settings.Default.InboxArchiveFolder.ToString() + DateTime.Now.ToString("dd-MM") + @"\";
            FileInfo CreatedFile = new FileInfo(e.FullPath);
            if (!IsFileLocked(CreatedFile) && CreatedFile.Extension.ToLower() != ".tmp" &&
                CreatedFile.Length != 0 &&
                !File.GetAttributes(e.FullPath).HasFlag(FileAttributes.Hidden) &&
                !File.GetAttributes(e.FullPath).HasFlag(FileAttributes.System))
            {
                FillDataGrid(CreatedFile, true);
                System.IO.File.Copy(e.FullPath, currDateDirectory1 + e.Name, true);
                System.IO.File.Copy(e.FullPath, Settings.Default.DelovodFolder.ToString() + e.Name, true);
                System.IO.File.Delete(e.FullPath);
            }
        }

        public void FileSystemWatcherOutbox_Created(object source, FileSystemEventArgs e)
        {

            if (e.ChangeType.ToString() == "Created")
            {
                FilesToSendList.Invoke(new Action(() =>
                {
                    FilesToSendList.Items.Add(e.Name);
                }));
            }
        }

        public void FileSystemWatcherOutbox_OnChanged(object source, FileSystemEventArgs e)
        {
            if (e.ChangeType.ToString() == "Deleted")
            {
                FilesToSendList.Invoke(new Action(() =>
                {
                    FilesToSendList.Items.Remove(e.Name);
                }));
            }
        }

        public void FileSystemWatcherOutbox_Renamed(object source, RenamedEventArgs e)
        {
            FilesToSendList.Invoke(new Action(() =>
            {
                FilesToSendList.Items.Remove(e.OldName);
                FilesToSendList.Items.Add(e.Name);
            }));
        }

        private bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;
            try
            {
                stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (Exception)
            {
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
            return false;
        }

        public void CopyFolderInbox(string sourceFolder, string destFolders1, string destFolders2)
        {
            string[] files = Directory.GetFiles(sourceFolder);

            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                if (!Directory.Exists(destFolders1))
                    Directory.CreateDirectory(destFolders1);
                string dest1 = Path.Combine(destFolders1 + DateTime.Now.ToString("dd-MM") + @"\", name);
                string dest2 = Path.Combine(destFolders2, name);
                FileInfo fileInfo = new FileInfo(file);
                if (!IsFileLocked(fileInfo))
                {
                    System.IO.File.Copy(file, dest1, true);
                    System.IO.File.Copy(file, dest2, true);
                    FillDataGrid(fileInfo, true);
                    System.IO.File.Delete(file);
                }
            }
            string[] folders = Directory.GetDirectories(sourceFolder);
            foreach (string folder in folders)
            {
                CopyFolderInbox(folder, destFolders1, destFolders2);
                Directory.Delete(folder);
            }
        }

        private void ClearMenuItem_Click(object sender, EventArgs e)
        {
            switch (MailTab.SelectedTab.Name)
            {
                case "InboxTab":
                    InboxData.Rows.Clear();
                    break;
                case "OutboxTab":
                    OutboxData.Rows.Clear();
                    break;
                default:
                    break;
            }

        }

        private string GetFileSize(string filename)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            double len = new FileInfo(filename).Length;
            int order = 0;
            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len /= 1024;
            }
            string result = String.Format("{0:0.##} {1}", len, sizes[order]);
            return result;
        }

        private void FillDataGrid(FileInfo file, bool isInbox)
        {
            string username = System.IO.File.GetAccessControl(file.FullName).
                            GetOwner(typeof(System.Security.Principal.NTAccount)).ToString().Split('\\')[1];
            switch (isInbox)
            {
                case true:
                    InboxData.Invoke(new Action(() =>
                    {
                        InboxData.Rows.Add(
                            DateTime.Now.ToString("dd.MM.yyyy"),
                            "",
                            file.LastWriteTime.ToString("dd.MM.yyyy"),
                            "",
                            "", "",
                            file.Name,
                            file.CreationTime.ToString("HH-mm"),
                            GetFileSize(file.FullName));
                        InboxData.Sort(Time, ListSortDirection.Ascending);
                    }));
                    break;
                case false:
                    OutboxData.Invoke(new Action(() =>
                    {
                        OutboxData.Rows.Add(
                            file.CreationTime.ToString("dd.MM.yyyy"),
                            file.CreationTime.ToString("HH-mm"),
                            "",
                            file.Name,
                            specialist[username].Split('%')[1],
                            specialist[username].Split('%')[0]
                            ,
                            "");
                        OutboxData.Sort(TimeOutbox, ListSortDirection.Ascending);
                    }));
                    break;
                default:
                    break;
            }
        }

        private void ExportDataGridToExcel(DataGridView datagridview)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            app.Visible = true;

            worksheet = workbook.Sheets["Лист1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Exported from gridview";

            for (int i = 1; i < datagridview.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = datagridview.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < datagridview.Rows.Count - 1; i++)
            {
                for (int j = 0; j < datagridview.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = datagridview.Rows[i].Cells[j].Value.ToString();
                }
            }

            workbook.SaveAs(@"d:\Почта\Журнал почты\" + datagridview.Name + DateTime.Now.ToString("dd-MM"),
                Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing,
                Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing);
        }

        private void ImportMenuItem_Click(object sender, EventArgs e)
        {
            if (ImportFolder.ShowDialog() == DialogResult.OK)
            {
                switch (MailTab.SelectedTab.Name)
                {
                    case "InboxTab":
                        ScanFolder(ImportFolder.SelectedPath, true);
                        break;
                    case "OutboxTab":
                        ScanFolder(ImportFolder.SelectedPath, false);
                        break;
                    default:
                        break;
                }
            }
        }

        private void ScanFolder(string path, bool isInbox)
        {
            string[] files = Directory.GetFiles(path);

            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                switch (isInbox)
                {
                    case true:
                        FillDataGrid(fileInfo, true);
                        break;
                    case false:
                        FillDataGrid(fileInfo, false);
                        break;
                    default:
                        break;
                }
            }

            string[] folders = Directory.GetDirectories(path);

            foreach (string folder in folders)
            {
                ScanFolder(folder, isInbox);
            }
        }

        private void FilesToSendList_DoubleClick(object sender, EventArgs e)
        {
            if (FilesToSendList.SelectedItem != null)
            {
                string file = FilesToSendList.SelectedItem.ToString();
                SendOutbox(file);
                FilesToSendList.Items.Remove(FilesToSendList.SelectedItem);
            }
        }


        public static string NextAvailableFilename(string path)
        {
            if (!System.IO.File.Exists(path))
                return path;

            if (Path.HasExtension(path))
                return GetNextFilename(path.Insert(
                                       path.LastIndexOf(Path.GetExtension(path)),
                                       numberPattern));

            return GetNextFilename(path + numberPattern);
        }

        private static string GetNextFilename(string pattern)
        {
            string tmp = string.Format(pattern, 1);
            if (tmp == pattern)
                throw new ArgumentException("The pattern must include an index place-holder", "pattern");

            if (!System.IO.File.Exists(tmp))
                return tmp;

            int min = 1, max = 2;

            while (System.IO.File.Exists(string.Format(pattern, max)))
            {
                min = max;
                max *= 2;
            }

            while (max != min + 1)
            {
                int pivot = (max + min) / 2;
                if (System.IO.File.Exists(string.Format(pattern, pivot)))
                    min = pivot;
                else
                    max = pivot;
            }
            return string.Format(pattern, max);
        }

        private void ExportMenuItem_Click(object sender, EventArgs e)
        {
            ExportDataGridToExcel(InboxData);
            ExportDataGridToExcel(OutboxData);
        }

        private void StartTool_Click(object sender, EventArgs e)
        {
            IsStarted = true;
            StartTool.Enabled = false;
            StopTool.Enabled = true;
            Directory.CreateDirectory(Settings.Default.InboxArchiveFolder.ToString() + DateTime.Now.ToString("dd-MM"));
            CopyFolderInbox(Settings.Default.InboxFolder, Settings.Default.InboxArchiveFolder.ToString(), Settings.Default.DelovodFolder.ToString());
            OutboxFilesScan();
            Watch(Settings.Default.InboxFolder.ToString(), true);
            Watch(Settings.Default.OutboxSendingFolder.ToString(), false);
        }

        private void StopTool_Click(object sender, EventArgs e)
        {
            IsStarted = false;
            StartTool.Enabled = true;
            StopTool.Enabled = false;
            Watch(Settings.Default.InboxFolder.ToString(), true);
            Watch(Settings.Default.OutboxSendingFolder.ToString(), false);
        }

        private void RefreshOutboxBtn_Click(object sender, EventArgs e)
        {
            OutboxFilesScan();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            switch (MailTab.SelectedTab.Name)
            {
                case "OutboxTab":
                    OutboxFilesScan();
                    OutboxData.Rows.Clear();
                    ScanFolder(Settings.Default.OutboxNotkillFolder.ToString(), false);
                    break;

                case "InboxTab":
                    InboxData.Rows.Clear();
                    ScanFolder(Settings.Default.InboxArchiveFolder.ToString() + DateTime.Now.ToString("dd-MM"), true);
                    break;

                default:
                    break;
            }
        }

        private string RenameExistedFile(string fullPath)
        {
            int count = 1;
            string fileNameOnly = Path.GetFileNameWithoutExtension(fullPath);
            string extension = Path.GetExtension(fullPath);
            string path = Path.GetDirectoryName(fullPath);
            string newFullPath = fullPath;
            while (System.IO.File.Exists(newFullPath))
            {
                string tempFileName = fileNameOnly.Remove(7, 1).Insert(7, count++.ToString());
                newFullPath = Path.Combine(path, tempFileName + extension);
            }

            return newFullPath;
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            if (OutboxFileUploadDialog.ShowDialog() == DialogResult.OK)
            {
                string[] filenames = OutboxFileUploadDialog.FileNames;
                foreach (string file in filenames)
                {
                    UploadOutbox(file);
                }
            }
        }

        private void UploadOutbox(string path)
        {
            string fileCode = " ";
            string filename = path;
            string newpath = string.Empty;
            int counter = 1;
            string extension = Path.GetExtension(filename).ToLower();
            if (extension == ".jpg" || extension == ".pdf")
            {
                fileCode = "g" + departmentNum.SelectedItem +
                            DateTime.Now.ToString("ddMM") +
                            counter.ToString() +
                            ".05" + extension;
            }
            else if (extension == ".doc" || extension == ".docx")
            {
                fileCode = "d" + departmentNum.SelectedItem +
                            DateTime.Now.ToString("ddMM") +
                            counter.ToString() +
                            ".05" + extension;
            }
            else if (extension == ".xls" || extension == ".xlsx")
            {
                fileCode = "t" + departmentNum.SelectedItem +
                            DateTime.Now.ToString("ddMM") +
                            counter.ToString() +
                            ".05" + extension;
            }
            else if (extension == ".rar" || extension == ".zip")
            {
                fileCode = "a" + departmentNum.SelectedItem +
                            DateTime.Now.ToString("ddMM") +
                            counter.ToString() +
                            ".05" + extension;
            }
            newpath = RenameExistedFile(Settings.Default.OutboxSendingFolder.ToString() + fileCode);
            File.Copy(filename, newpath);
            //!!!!!!!!!!!!!!!!!!!!!!!!
            //File.GetAccessControl(newpath).SetOwner()
        }

        private void SendOutbox(string fileName)
        {
            if (fileName != null)
            {
                string path = Settings.Default.OutboxSendingFolder.ToString() + fileName;
                string copyPath = Settings.Default.OutboxNotkillFolder.ToString() + fileName;

                if (System.IO.File.Exists(copyPath))
                {
                    DialogResult dialogResult = MessageBox.Show("A file " + fileName + " with the same name already exists. Replace? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.No)
                    {
                        copyPath = RenameExistedFile(Settings.Default.OutboxNotkillFolder.ToString() + fileName);
                    }
                }

                System.IO.File.Copy(path, copyPath, true);
                FileInfo fileInfo = new FileInfo(path);
                FillDataGrid(fileInfo, false);
                System.IO.File.Copy(path, Settings.Default.OutboxFolder.ToString()
                    + Path.GetFileName(copyPath), true);
                System.IO.File.Delete(path);
            }
        }

        private void SendAllBtn_Click(object sender, EventArgs e)
        {
            string[] filesToSend = new string[FilesToSendList.Items.Count];
            for (int i = 0; i < filesToSend.Length; i++)
            {
                filesToSend[i] = FilesToSendList.Items[i].ToString();
            }

            foreach (string fl in filesToSend)
            {
                SendOutbox(fl);
            }
        }

        private void FilesToSendList_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files) UploadOutbox(file);
        }

        private void FilesToSendList_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Move;
        }

        private void InitNetDirectory()
        {
            using (StreamReader sr = new StreamReader(Settings.Default.ComputersInfoJSON.ToString()))
            {
                string json = sr.ReadToEnd();
                DeserializedComputers = JsonConvert.DeserializeObject<List<Computers>>(json);
            }
            foreach (var cmp in DeserializedComputers)
            {
                NetDirectoryList.Items.Add(cmp.Name);
            }

        }

        private void NetDirectoryList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                OpenFolder(NetDirectoryList.SelectedItem.ToString());
            }
            catch (System.ComponentModel.Win32Exception)
            {

                MessageBox.Show("Network path not found.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            
        }

        private void OpenFolder(string computerName)
        {
            Process.Start(@"\\" + Dns.GetHostEntry(computerName).AddressList.Where(ip =>
                            ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).ToList()[0].ToString());

        }

        public bool IsIPOnline(string ip)
        {
            try
            {
                Ping MyPing = new Ping();
                PingReply reply = MyPing.Send(ip);
                if (reply != null)
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
            return false;
        }

        private void PingBtn_Click(object sender, EventArgs e)
        {
            NetDirectoryList.Items.Clear();
            ProgressBar.Visible = true;
            foreach (var computer in DeserializedComputers)
            {
                ProgressBar.PerformStep();
                if (IsIPOnline(computer.IPAdress))
                {
                    NetDirectoryList.Items.Add(computer.Name);
                }
            }

            ProgressBar.Value = 1;
            ProgressBar.Visible = false;
        }

        public void SetComputerList()
        {
            DirectoryEntry root = new DirectoryEntry("WinNT:", "Administrator", "derwas");
            List<Computers> ComputerList = new List<Computers>();

            foreach (DirectoryEntry computers in root.Children)
            {
                foreach (DirectoryEntry computer in computers.Children)
                {
                    if (computer.Name != "Schema" && computer.SchemaClassName == "Computer")
                    {
                        try
                        {
                            ComputerList.Add(new Computers()
                            {
                                IPAdress = Dns.GetHostEntry(computer.Name).AddressList.Where(ip =>
                                ip.AddressFamily == System.Net.Sockets.
                                AddressFamily.InterNetwork).ToList()[0].ToString(),

                                Name = computer.Name,
                                ID = computer.GetHashCode().ToString(),
                            }); 
                        }
                        catch (System.Net.Sockets.SocketException)
                        {
                            ComputerList.Add(new Computers()
                            {
                                Name = computer.Name,
                                IPAdress = null,
                                ID = computer.GetHashCode().ToString(),
                            });
                        }
                    }
                }
            }
            DisplayedComputers = ComputerList;
        }

        public void UpdateNetwork()
        {
            SetComputerList();
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter(Settings.Default.ComputersInfoJSON.ToString()))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, DisplayedComputers);
            }
        }

        private void UpdateNetworkBtn_Click(object sender, EventArgs e)
        {
            NetDirectoryList.Items.Clear();
            UpdateNetwork();
            InitNetDirectory();
        }

        private void SaveSettingsBtn_Click(object sender, EventArgs e)
        {
            Settings.Default.ComputersInfoJSON = CompInfoSettings.Text;
            Settings.Default.OutboxArchiveFolder = OABFolderSettings.Text;
            Settings.Default.OutboxSendingFolder = FilesOutFolderSettings.Text;
            Settings.Default.OutboxNotkillFolder = OBNKFolderSettings.Text;
            Settings.Default.OutboxFolder = OBFolderSettings.Text;
            Settings.Default.DelovodFolder = OrgFolderSettings.Text;
            Settings.Default.InboxArchiveFolder = IBAFolderSettings.Text;
            Settings.Default.InboxFolder = IBFolderSettings.Text;
        }

        private void SetFolderSettings(TextBox tb)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                tb.Text = fbd.SelectedPath;
            }
        }

        private void IBFSetBtn_Click(object sender, EventArgs e)
        {
            SetFolderSettings(IBFolderSettings);
        }

        private void IBASetFolderBtn_Click(object sender, EventArgs e)
        {
            SetFolderSettings(IBAFolderSettings);
        }

        private void SetOrgFolderBtn_Click(object sender, EventArgs e)
        {
            SetFolderSettings(OrgFolderSettings);
        }

        private void SetOBFolderBtn_Click(object sender, EventArgs e)
        {
            SetFolderSettings(OBFolderSettings);
        }

        private void SetOBNFolderBtn_Click(object sender, EventArgs e)
        {
            SetFolderSettings(OBNKFolderSettings);
        }

        private void SetFTSBtn_Click(object sender, EventArgs e)
        {
            SetFolderSettings(FilesOutFolderSettings);
        }

        private void SetOBAFolderBtn_Click(object sender, EventArgs e)
        {
            SetFolderSettings(OABFolderSettings);
        }

        private void SetCompJSONBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                CompInfoSettings.Text = ofd.FileName;
            }
        }
    }
}

