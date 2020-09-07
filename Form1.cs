using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Security.Permissions;
using System.Runtime.InteropServices;

namespace CMail
{
    public partial class Form1 : Form
    {
        private bool IsStarted = false;
        public Form1()
        {
            InitializeComponent();
            string currDateDirectory = ToTextBox.Text + DateTime.Now.Day + "-" + DateTime.Now.Month + @"\";
            Directory.CreateDirectory(currDateDirectory);
        }
        public void Watch(string path)
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = path;
            watcher.Created += FileSystemWatcher_Created;
            watcher.Changed += FileSystemWatcher_Created;
            if (IsStarted)
            {
                watcher.EnableRaisingEvents = true;
            }
            else
            {
                watcher.EnableRaisingEvents = true;
            }
        }

        public void FileSystemWatcher_Created(object source, FileSystemEventArgs e)
        {
            string currDateDirectory1 = ToTextBox.Text + DateTime.Now.Day + "-" + DateTime.Now.Month + @"\";
            string currDateDirectory2 = ToTextBoxSecond.Text;
            FileInfo CreatedFile = new FileInfo(e.FullPath);
            if (!IsFileLocked(CreatedFile))
            {
                FillDate(CreatedFile);
                File.Copy(e.FullPath, currDateDirectory1 + e.Name, true);
                File.Copy(e.FullPath, currDateDirectory2 + e.Name, true);
                File.Delete(e.FullPath);
            }
        }

        private bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException)
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

        private void StartBtn_Click(object sender, EventArgs e)
        {
            IsStarted = true;
            StartBtn.Enabled = false;
            StopBtn.Enabled = true;
            CopyFolder(FromTextBox.Text, ToTextBoxSecond.Text, ToTextBox.Text + DateTime.Now.Day + "-" + DateTime.Now.Month + @"\");

            Watch(FromTextBox.Text);
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            IsStarted = false;
            StartBtn.Enabled = true;
            StopBtn.Enabled = false;
            Watch(FromTextBox.Text);
        }

        public void CopyFolder(string sourceFolder, string destFolder1, string destFolder)
        {
            if (!Directory.Exists(destFolder))
                Directory.CreateDirectory(destFolder);
            string[] files = Directory.GetFiles(sourceFolder);
            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                string dest = Path.Combine(destFolder, name);
                string dest1 = Path.Combine(destFolder1, name);
                File.Copy(file, dest, true);
                File.Copy(file, dest1, true);
                FileInfo fileInfo = new FileInfo(file);
                FillDate(fileInfo);
                File.Delete(file);
            }
            string[] folders = Directory.GetDirectories(sourceFolder);
            foreach (string folder in folders)
            {
                string name = Path.GetFileName(folder);
                string dest = Path.Combine(destFolder, name);
                string dest1 = Path.Combine(destFolder1, name);
                CopyFolder(folder, dest, dest1);
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilesData.Rows.Clear();
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

            // Adjust the format string to your preferences. For example "{0:0.#}{1}" would
            // show a single decimal place, and no space.
            string result = String.Format("{0:0.##} {1}", len, sizes[order]);
            return result;
        }

        private void FillDate(FileInfo file)
        {
            FilesData.Invoke(new Action(() =>
            {
                FilesData.Rows.Add(
                    DateTime.Now.ToString("dd.MM.yyyy"),
                    " ",
                    file.LastWriteTime.ToString("dd.MM.yyyy"),
                    " ", " ", " ",
                    file.Name,
                    file.LastAccessTime.ToString("HH-mm"),
                    GetFileSize(file.FullName));
            }));
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing); 
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Лист1"];
            worksheet = workbook.ActiveSheet;  
            worksheet.Name = "Exported from gridview"; 
            for (int i = 1; i < FilesData.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = FilesData.Columns[i - 1].HeaderText;
            } 
            for (int i = 0; i < FilesData.Rows.Count - 1; i++)
            {
                for (int j = 0; j < FilesData.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = FilesData.Rows[i].Cells[j].Value.ToString();
                }
            }
            workbook.SaveAs("D:\\Почта\\output.xls"+ DateTime.Now.ToString("dd-MM"), Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ImportFolder.ShowDialog() == DialogResult.OK)
            {
                string path = ImportFolder.SelectedPath;
                string[] files = Directory.GetFiles(path);
                foreach (string file in files)
                {
                    string name = Path.GetFileName(file);
                    FileInfo fileInfo = new FileInfo(file);
                    FillDate(fileInfo);
                }
                string[] folders = Directory.GetDirectories(path);
                foreach (string folder in folders)
                {
                    string name = Path.GetFileName(folder);

                    CopyFolder(folder, dest, dest1);
                }
            }
        }
    }
}
