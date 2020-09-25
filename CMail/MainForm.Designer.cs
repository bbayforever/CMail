namespace CMail
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MailTab = new System.Windows.Forms.TabControl();
            this.OutboxTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.departmentNum = new System.Windows.Forms.ComboBox();
            this.SendAllBtn = new System.Windows.Forms.Button();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.FilesToSendList = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OutboxData = new System.Windows.Forms.DataGridView();
            this.DateOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeOutbox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IndexOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilenameOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SenderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AboutOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InboxTab = new System.Windows.Forms.TabPage();
            this.InboxData = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmptyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.About = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Terms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetFolderTab = new System.Windows.Forms.TabPage();
            this.UpdateNetworkBtn = new System.Windows.Forms.Button();
            this.PingBtn = new System.Windows.Forms.Button();
            this.NetDirectoryList = new System.Windows.Forms.ListBox();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.SaveSettingsBtn = new System.Windows.Forms.Button();
            this.SetOBAFolderBtn = new System.Windows.Forms.Button();
            this.SetOrgFolderBtn = new System.Windows.Forms.Button();
            this.SetOBNFolderBtn = new System.Windows.Forms.Button();
            this.IBFSetBtn = new System.Windows.Forms.Button();
            this.SetCompJSONBtn = new System.Windows.Forms.Button();
            this.SetOBFolderBtn = new System.Windows.Forms.Button();
            this.SetFTSBtn = new System.Windows.Forms.Button();
            this.IBASetFolderBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OABFolderSettings = new System.Windows.Forms.TextBox();
            this.OrgFolderSettings = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OBNKFolderSettings = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CompInfoSettings = new System.Windows.Forms.TextBox();
            this.IBFolderSettings = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.OBFolderSettings = new System.Windows.Forms.TextBox();
            this.FilesOutFolderSettings = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IBAFolderSettings = new System.Windows.Forms.TextBox();
            this.IconsList = new System.Windows.Forms.ImageList(this.components);
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.ClearMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.ImportInboxFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.OutboxFileUploadDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.StartTool = new System.Windows.Forms.ToolStripButton();
            this.StopTool = new System.Windows.Forms.ToolStripButton();
            this.RefreshBtn = new System.Windows.Forms.ToolStripButton();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.MailTab.SuspendLayout();
            this.OutboxTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutboxData)).BeginInit();
            this.InboxTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InboxData)).BeginInit();
            this.NetFolderTab.SuspendLayout();
            this.SettingsTab.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MailTab
            // 
            this.MailTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MailTab.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.MailTab.Controls.Add(this.OutboxTab);
            this.MailTab.Controls.Add(this.InboxTab);
            this.MailTab.Controls.Add(this.NetFolderTab);
            this.MailTab.Controls.Add(this.SettingsTab);
            this.MailTab.ImageList = this.IconsList;
            this.MailTab.ItemSize = new System.Drawing.Size(100, 50);
            this.MailTab.Location = new System.Drawing.Point(0, 87);
            this.MailTab.Name = "MailTab";
            this.MailTab.SelectedIndex = 0;
            this.MailTab.Size = new System.Drawing.Size(1309, 629);
            this.MailTab.TabIndex = 4;
            // 
            // OutboxTab
            // 
            this.OutboxTab.BackColor = System.Drawing.Color.GhostWhite;
            this.OutboxTab.Controls.Add(this.label4);
            this.OutboxTab.Controls.Add(this.departmentNum);
            this.OutboxTab.Controls.Add(this.SendAllBtn);
            this.OutboxTab.Controls.Add(this.uploadBtn);
            this.OutboxTab.Controls.Add(this.FilesToSendList);
            this.OutboxTab.Controls.Add(this.OutboxData);
            this.OutboxTab.ImageIndex = 1;
            this.OutboxTab.Location = new System.Drawing.Point(4, 54);
            this.OutboxTab.Name = "OutboxTab";
            this.OutboxTab.Padding = new System.Windows.Forms.Padding(3);
            this.OutboxTab.Size = new System.Drawing.Size(1301, 571);
            this.OutboxTab.TabIndex = 1;
            this.OutboxTab.Text = "Outbox";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Department";
            // 
            // departmentNum
            // 
            this.departmentNum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.departmentNum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.departmentNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.departmentNum.FormattingEnabled = true;
            this.departmentNum.Items.AddRange(new object[] {
            "01",
            "02",
            "04",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "15",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "51",
            "31",
            "52",
            "53",
            "54"});
            this.departmentNum.Location = new System.Drawing.Point(3, 30);
            this.departmentNum.Name = "departmentNum";
            this.departmentNum.Size = new System.Drawing.Size(85, 28);
            this.departmentNum.TabIndex = 5;
            // 
            // SendAllBtn
            // 
            this.SendAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendAllBtn.Location = new System.Drawing.Point(98, 47);
            this.SendAllBtn.Name = "SendAllBtn";
            this.SendAllBtn.Size = new System.Drawing.Size(200, 34);
            this.SendAllBtn.TabIndex = 4;
            this.SendAllBtn.Text = "Send all";
            this.SendAllBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SendAllBtn.UseVisualStyleBackColor = true;
            this.SendAllBtn.Click += new System.EventHandler(this.SendAllBtn_Click);
            // 
            // uploadBtn
            // 
            this.uploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadBtn.Location = new System.Drawing.Point(98, 7);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(200, 34);
            this.uploadBtn.TabIndex = 4;
            this.uploadBtn.Text = "Upload";
            this.uploadBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // FilesToSendList
            // 
            this.FilesToSendList.AllowDrop = true;
            this.FilesToSendList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FilesToSendList.ContextMenuStrip = this.contextMenuStrip1;
            this.FilesToSendList.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilesToSendList.ForeColor = System.Drawing.Color.Black;
            this.FilesToSendList.FormattingEnabled = true;
            this.FilesToSendList.ItemHeight = 47;
            this.FilesToSendList.Location = new System.Drawing.Point(0, 94);
            this.FilesToSendList.Name = "FilesToSendList";
            this.FilesToSendList.Size = new System.Drawing.Size(298, 474);
            this.FilesToSendList.TabIndex = 2;
            this.FilesToSendList.DragEnter += new System.Windows.Forms.DragEventHandler(this.FilesToSendList_DragEnter);
            this.FilesToSendList.DoubleClick += new System.EventHandler(this.FilesToSendList_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // OutboxData
            // 
            this.OutboxData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutboxData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OutboxData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.OutboxData.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.OutboxData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OutboxData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateOut,
            this.TimeOutbox,
            this.IndexOut,
            this.FilenameOut,
            this.Department,
            this.SenderName,
            this.AboutOut});
            this.OutboxData.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OutboxData.Location = new System.Drawing.Point(304, 3);
            this.OutboxData.Name = "OutboxData";
            this.OutboxData.RowHeadersWidth = 51;
            this.OutboxData.RowTemplate.Height = 24;
            this.OutboxData.Size = new System.Drawing.Size(991, 558);
            this.OutboxData.TabIndex = 1;
            // 
            // DateOut
            // 
            this.DateOut.HeaderText = "Date";
            this.DateOut.Name = "DateOut";
            // 
            // TimeOutbox
            // 
            this.TimeOutbox.HeaderText = "Time";
            this.TimeOutbox.Name = "TimeOutbox";
            // 
            // IndexOut
            // 
            this.IndexOut.HeaderText = "Index";
            this.IndexOut.Name = "IndexOut";
            // 
            // FilenameOut
            // 
            this.FilenameOut.HeaderText = "File name";
            this.FilenameOut.Name = "FilenameOut";
            // 
            // Department
            // 
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            // 
            // SenderName
            // 
            this.SenderName.HeaderText = "Name";
            this.SenderName.Name = "SenderName";
            // 
            // AboutOut
            // 
            this.AboutOut.HeaderText = "About";
            this.AboutOut.Name = "AboutOut";
            // 
            // InboxTab
            // 
            this.InboxTab.BackColor = System.Drawing.Color.GhostWhite;
            this.InboxTab.Controls.Add(this.InboxData);
            this.InboxTab.ImageKey = "download.png";
            this.InboxTab.Location = new System.Drawing.Point(4, 54);
            this.InboxTab.Name = "InboxTab";
            this.InboxTab.Padding = new System.Windows.Forms.Padding(3);
            this.InboxTab.Size = new System.Drawing.Size(1301, 571);
            this.InboxTab.TabIndex = 0;
            this.InboxTab.Text = "Inbox";
            // 
            // InboxData
            // 
            this.InboxData.AllowUserToResizeColumns = false;
            this.InboxData.AllowUserToResizeRows = false;
            this.InboxData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InboxData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InboxData.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.InboxData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InboxData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.EmptyColumn,
            this.FileDate,
            this.Index,
            this.About,
            this.Terms,
            this.FileName,
            this.Time,
            this.FileSize});
            this.InboxData.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InboxData.Location = new System.Drawing.Point(4, 8);
            this.InboxData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InboxData.Name = "InboxData";
            this.InboxData.RowHeadersWidth = 51;
            this.InboxData.Size = new System.Drawing.Size(1288, 551);
            this.InboxData.TabIndex = 0;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date of receiving";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            // 
            // EmptyColumn
            // 
            this.EmptyColumn.HeaderText = "";
            this.EmptyColumn.MinimumWidth = 6;
            this.EmptyColumn.Name = "EmptyColumn";
            // 
            // FileDate
            // 
            this.FileDate.HeaderText = "Date of creation";
            this.FileDate.MinimumWidth = 6;
            this.FileDate.Name = "FileDate";
            // 
            // Index
            // 
            this.Index.HeaderText = "Index";
            this.Index.MinimumWidth = 6;
            this.Index.Name = "Index";
            // 
            // About
            // 
            this.About.HeaderText = "About";
            this.About.MinimumWidth = 6;
            this.About.Name = "About";
            // 
            // Terms
            // 
            this.Terms.HeaderText = "Terms";
            this.Terms.MinimumWidth = 6;
            this.Terms.Name = "Terms";
            // 
            // FileName
            // 
            this.FileName.HeaderText = "Filename";
            this.FileName.MinimumWidth = 6;
            this.FileName.Name = "FileName";
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            // 
            // FileSize
            // 
            this.FileSize.HeaderText = "Size";
            this.FileSize.MinimumWidth = 6;
            this.FileSize.Name = "FileSize";
            // 
            // NetFolderTab
            // 
            this.NetFolderTab.Controls.Add(this.UpdateNetworkBtn);
            this.NetFolderTab.Controls.Add(this.PingBtn);
            this.NetFolderTab.Controls.Add(this.NetDirectoryList);
            this.NetFolderTab.ImageKey = "diagram.png";
            this.NetFolderTab.Location = new System.Drawing.Point(4, 54);
            this.NetFolderTab.Name = "NetFolderTab";
            this.NetFolderTab.Size = new System.Drawing.Size(1301, 571);
            this.NetFolderTab.TabIndex = 4;
            this.NetFolderTab.Text = "Network";
            this.NetFolderTab.UseVisualStyleBackColor = true;
            // 
            // UpdateNetworkBtn
            // 
            this.UpdateNetworkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateNetworkBtn.Location = new System.Drawing.Point(9, 74);
            this.UpdateNetworkBtn.Name = "UpdateNetworkBtn";
            this.UpdateNetworkBtn.Size = new System.Drawing.Size(107, 68);
            this.UpdateNetworkBtn.TabIndex = 2;
            this.UpdateNetworkBtn.Text = "Update";
            this.UpdateNetworkBtn.UseVisualStyleBackColor = true;
            this.UpdateNetworkBtn.Click += new System.EventHandler(this.UpdateNetworkBtn_Click);
            // 
            // PingBtn
            // 
            this.PingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PingBtn.Location = new System.Drawing.Point(9, 3);
            this.PingBtn.Name = "PingBtn";
            this.PingBtn.Size = new System.Drawing.Size(107, 64);
            this.PingBtn.TabIndex = 1;
            this.PingBtn.Text = "Ping";
            this.PingBtn.UseVisualStyleBackColor = true;
            this.PingBtn.Click += new System.EventHandler(this.PingBtn_Click);
            // 
            // NetDirectoryList
            // 
            this.NetDirectoryList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NetDirectoryList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NetDirectoryList.ColumnWidth = 200;
            this.NetDirectoryList.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NetDirectoryList.FormattingEnabled = true;
            this.NetDirectoryList.ItemHeight = 29;
            this.NetDirectoryList.Location = new System.Drawing.Point(122, 3);
            this.NetDirectoryList.MultiColumn = true;
            this.NetDirectoryList.Name = "NetDirectoryList";
            this.NetDirectoryList.Size = new System.Drawing.Size(1171, 553);
            this.NetDirectoryList.TabIndex = 0;
            this.NetDirectoryList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NetDirectoryList_MouseDoubleClick);
            // 
            // SettingsTab
            // 
            this.SettingsTab.BackColor = System.Drawing.Color.GhostWhite;
            this.SettingsTab.Controls.Add(this.SaveSettingsBtn);
            this.SettingsTab.Controls.Add(this.SetOBAFolderBtn);
            this.SettingsTab.Controls.Add(this.SetOrgFolderBtn);
            this.SettingsTab.Controls.Add(this.SetOBNFolderBtn);
            this.SettingsTab.Controls.Add(this.IBFSetBtn);
            this.SettingsTab.Controls.Add(this.SetCompJSONBtn);
            this.SettingsTab.Controls.Add(this.SetOBFolderBtn);
            this.SettingsTab.Controls.Add(this.SetFTSBtn);
            this.SettingsTab.Controls.Add(this.IBASetFolderBtn);
            this.SettingsTab.Controls.Add(this.label9);
            this.SettingsTab.Controls.Add(this.label5);
            this.SettingsTab.Controls.Add(this.OABFolderSettings);
            this.SettingsTab.Controls.Add(this.OrgFolderSettings);
            this.SettingsTab.Controls.Add(this.label8);
            this.SettingsTab.Controls.Add(this.label7);
            this.SettingsTab.Controls.Add(this.label2);
            this.SettingsTab.Controls.Add(this.OBNKFolderSettings);
            this.SettingsTab.Controls.Add(this.label3);
            this.SettingsTab.Controls.Add(this.CompInfoSettings);
            this.SettingsTab.Controls.Add(this.IBFolderSettings);
            this.SettingsTab.Controls.Add(this.label6);
            this.SettingsTab.Controls.Add(this.OBFolderSettings);
            this.SettingsTab.Controls.Add(this.FilesOutFolderSettings);
            this.SettingsTab.Controls.Add(this.label1);
            this.SettingsTab.Controls.Add(this.IBAFolderSettings);
            this.SettingsTab.ImageKey = "computer.png";
            this.SettingsTab.Location = new System.Drawing.Point(4, 54);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Size = new System.Drawing.Size(1301, 571);
            this.SettingsTab.TabIndex = 3;
            this.SettingsTab.Text = "Settings";
            // 
            // SaveSettingsBtn
            // 
            this.SaveSettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveSettingsBtn.Location = new System.Drawing.Point(9, 433);
            this.SaveSettingsBtn.Name = "SaveSettingsBtn";
            this.SaveSettingsBtn.Size = new System.Drawing.Size(397, 32);
            this.SaveSettingsBtn.TabIndex = 3;
            this.SaveSettingsBtn.Text = "Save settings";
            this.SaveSettingsBtn.UseVisualStyleBackColor = true;
            this.SaveSettingsBtn.Click += new System.EventHandler(this.SaveSettingsBtn_Click);
            // 
            // SetOBAFolderBtn
            // 
            this.SetOBAFolderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetOBAFolderBtn.Location = new System.Drawing.Point(297, 347);
            this.SetOBAFolderBtn.Name = "SetOBAFolderBtn";
            this.SetOBAFolderBtn.Size = new System.Drawing.Size(117, 26);
            this.SetOBAFolderBtn.TabIndex = 2;
            this.SetOBAFolderBtn.Text = "Choose folder...";
            this.SetOBAFolderBtn.UseVisualStyleBackColor = true;
            this.SetOBAFolderBtn.Click += new System.EventHandler(this.SetOBAFolderBtn_Click);
            // 
            // SetOrgFolderBtn
            // 
            this.SetOrgFolderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetOrgFolderBtn.Location = new System.Drawing.Point(297, 137);
            this.SetOrgFolderBtn.Name = "SetOrgFolderBtn";
            this.SetOrgFolderBtn.Size = new System.Drawing.Size(117, 26);
            this.SetOrgFolderBtn.TabIndex = 2;
            this.SetOrgFolderBtn.Text = "Choose folder...";
            this.SetOrgFolderBtn.UseVisualStyleBackColor = true;
            this.SetOrgFolderBtn.Click += new System.EventHandler(this.SetOrgFolderBtn_Click);
            // 
            // SetOBNFolderBtn
            // 
            this.SetOBNFolderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetOBNFolderBtn.Location = new System.Drawing.Point(297, 242);
            this.SetOBNFolderBtn.Name = "SetOBNFolderBtn";
            this.SetOBNFolderBtn.Size = new System.Drawing.Size(117, 26);
            this.SetOBNFolderBtn.TabIndex = 2;
            this.SetOBNFolderBtn.Text = "Choose folder...";
            this.SetOBNFolderBtn.UseVisualStyleBackColor = true;
            this.SetOBNFolderBtn.Click += new System.EventHandler(this.SetOBNFolderBtn_Click);
            // 
            // IBFSetBtn
            // 
            this.IBFSetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBFSetBtn.Location = new System.Drawing.Point(297, 32);
            this.IBFSetBtn.Name = "IBFSetBtn";
            this.IBFSetBtn.Size = new System.Drawing.Size(117, 26);
            this.IBFSetBtn.TabIndex = 2;
            this.IBFSetBtn.Text = "Choose folder...";
            this.IBFSetBtn.UseVisualStyleBackColor = true;
            this.IBFSetBtn.Click += new System.EventHandler(this.IBFSetBtn_Click);
            // 
            // SetCompJSONBtn
            // 
            this.SetCompJSONBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetCompJSONBtn.Location = new System.Drawing.Point(297, 400);
            this.SetCompJSONBtn.Name = "SetCompJSONBtn";
            this.SetCompJSONBtn.Size = new System.Drawing.Size(117, 26);
            this.SetCompJSONBtn.TabIndex = 2;
            this.SetCompJSONBtn.Text = "Choose folder...";
            this.SetCompJSONBtn.UseVisualStyleBackColor = true;
            this.SetCompJSONBtn.Click += new System.EventHandler(this.SetCompJSONBtn_Click);
            // 
            // SetOBFolderBtn
            // 
            this.SetOBFolderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetOBFolderBtn.Location = new System.Drawing.Point(297, 190);
            this.SetOBFolderBtn.Name = "SetOBFolderBtn";
            this.SetOBFolderBtn.Size = new System.Drawing.Size(117, 26);
            this.SetOBFolderBtn.TabIndex = 2;
            this.SetOBFolderBtn.Text = "Choose folder...";
            this.SetOBFolderBtn.UseVisualStyleBackColor = true;
            this.SetOBFolderBtn.Click += new System.EventHandler(this.SetOBFolderBtn_Click);
            // 
            // SetFTSBtn
            // 
            this.SetFTSBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetFTSBtn.Location = new System.Drawing.Point(297, 295);
            this.SetFTSBtn.Name = "SetFTSBtn";
            this.SetFTSBtn.Size = new System.Drawing.Size(117, 26);
            this.SetFTSBtn.TabIndex = 2;
            this.SetFTSBtn.Text = "Choose folder...";
            this.SetFTSBtn.UseVisualStyleBackColor = true;
            this.SetFTSBtn.Click += new System.EventHandler(this.SetFTSBtn_Click);
            // 
            // IBASetFolderBtn
            // 
            this.IBASetFolderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBASetFolderBtn.Location = new System.Drawing.Point(297, 85);
            this.IBASetFolderBtn.Name = "IBASetFolderBtn";
            this.IBASetFolderBtn.Size = new System.Drawing.Size(117, 26);
            this.IBASetFolderBtn.TabIndex = 2;
            this.IBASetFolderBtn.Text = "Choose folder...";
            this.IBASetFolderBtn.UseVisualStyleBackColor = true;
            this.IBASetFolderBtn.Click += new System.EventHandler(this.IBASetFolderBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Outbox archive folder";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Org folder";
            // 
            // OABFolderSettings
            // 
            this.OABFolderSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OABFolderSettings.Location = new System.Drawing.Point(8, 347);
            this.OABFolderSettings.Name = "OABFolderSettings";
            this.OABFolderSettings.Size = new System.Drawing.Size(282, 26);
            this.OABFolderSettings.TabIndex = 0;
            // 
            // OrgFolderSettings
            // 
            this.OrgFolderSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrgFolderSettings.Location = new System.Drawing.Point(8, 137);
            this.OrgFolderSettings.Name = "OrgFolderSettings";
            this.OrgFolderSettings.Size = new System.Drawing.Size(282, 26);
            this.OrgFolderSettings.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Outbox \"notkill\" folder";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Computers information(*json file)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inbox folder";
            // 
            // OBNKFolderSettings
            // 
            this.OBNKFolderSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OBNKFolderSettings.Location = new System.Drawing.Point(8, 242);
            this.OBNKFolderSettings.Name = "OBNKFolderSettings";
            this.OBNKFolderSettings.Size = new System.Drawing.Size(282, 26);
            this.OBNKFolderSettings.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Outbox folder";
            // 
            // CompInfoSettings
            // 
            this.CompInfoSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompInfoSettings.Location = new System.Drawing.Point(8, 400);
            this.CompInfoSettings.Name = "CompInfoSettings";
            this.CompInfoSettings.Size = new System.Drawing.Size(282, 26);
            this.CompInfoSettings.TabIndex = 0;
            // 
            // IBFolderSettings
            // 
            this.IBFolderSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IBFolderSettings.Location = new System.Drawing.Point(8, 32);
            this.IBFolderSettings.Name = "IBFolderSettings";
            this.IBFolderSettings.Size = new System.Drawing.Size(282, 26);
            this.IBFolderSettings.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Files to send folder";
            // 
            // OBFolderSettings
            // 
            this.OBFolderSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OBFolderSettings.Location = new System.Drawing.Point(8, 190);
            this.OBFolderSettings.Name = "OBFolderSettings";
            this.OBFolderSettings.Size = new System.Drawing.Size(282, 26);
            this.OBFolderSettings.TabIndex = 0;
            // 
            // FilesOutFolderSettings
            // 
            this.FilesOutFolderSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FilesOutFolderSettings.Location = new System.Drawing.Point(8, 295);
            this.FilesOutFolderSettings.Name = "FilesOutFolderSettings";
            this.FilesOutFolderSettings.Size = new System.Drawing.Size(282, 26);
            this.FilesOutFolderSettings.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inbox archive folder";
            // 
            // IBAFolderSettings
            // 
            this.IBAFolderSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IBAFolderSettings.Location = new System.Drawing.Point(8, 85);
            this.IBAFolderSettings.Name = "IBAFolderSettings";
            this.IBAFolderSettings.Size = new System.Drawing.Size(282, 26);
            this.IBAFolderSettings.TabIndex = 0;
            // 
            // IconsList
            // 
            this.IconsList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconsList.ImageStream")));
            this.IconsList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconsList.Images.SetKeyName(0, "download.png");
            this.IconsList.Images.SetKeyName(1, "outbox.png");
            this.IconsList.Images.SetKeyName(2, "001-international.png");
            this.IconsList.Images.SetKeyName(3, "002-global services.png");
            this.IconsList.Images.SetKeyName(4, "003-business.png");
            this.IconsList.Images.SetKeyName(5, "004-global communication.png");
            this.IconsList.Images.SetKeyName(6, "005-business.png");
            this.IconsList.Images.SetKeyName(7, "006-corporation.png");
            this.IconsList.Images.SetKeyName(8, "007-teamwork.png");
            this.IconsList.Images.SetKeyName(9, "008-global distribution.png");
            this.IconsList.Images.SetKeyName(10, "009-management.png");
            this.IconsList.Images.SetKeyName(11, "010-global connection.png");
            this.IconsList.Images.SetKeyName(12, "011-idea.png");
            this.IconsList.Images.SetKeyName(13, "012-business.png");
            this.IconsList.Images.SetKeyName(14, "013-forum.png");
            this.IconsList.Images.SetKeyName(15, "014-global communication.png");
            this.IconsList.Images.SetKeyName(16, "015-task.png");
            this.IconsList.Images.SetKeyName(17, "016-international business.png");
            this.IconsList.Images.SetKeyName(18, "017-organization.png");
            this.IconsList.Images.SetKeyName(19, "018-global distribution.png");
            this.IconsList.Images.SetKeyName(20, "019-headquarter.png");
            this.IconsList.Images.SetKeyName(21, "020-money bag.png");
            this.IconsList.Images.SetKeyName(22, "021-global economy.png");
            this.IconsList.Images.SetKeyName(23, "022-investment.png");
            this.IconsList.Images.SetKeyName(24, "023-world map.png");
            this.IconsList.Images.SetKeyName(25, "024-branch.png");
            this.IconsList.Images.SetKeyName(26, "025-risk.png");
            this.IconsList.Images.SetKeyName(27, "026-solution.png");
            this.IconsList.Images.SetKeyName(28, "027-business.png");
            this.IconsList.Images.SetKeyName(29, "028-business plan.png");
            this.IconsList.Images.SetKeyName(30, "029-strategic.png");
            this.IconsList.Images.SetKeyName(31, "030-success.png");
            this.IconsList.Images.SetKeyName(32, "031-global.png");
            this.IconsList.Images.SetKeyName(33, "032-transactions.png");
            this.IconsList.Images.SetKeyName(34, "033-handshake.png");
            this.IconsList.Images.SetKeyName(35, "034-time zones.png");
            this.IconsList.Images.SetKeyName(36, "035-investment.png");
            this.IconsList.Images.SetKeyName(37, "036-agreement.png");
            this.IconsList.Images.SetKeyName(38, "037-partnership.png");
            this.IconsList.Images.SetKeyName(39, "038-global connection.png");
            this.IconsList.Images.SetKeyName(40, "039-goal.png");
            this.IconsList.Images.SetKeyName(41, "040-business.png");
            this.IconsList.Images.SetKeyName(42, "041-search.png");
            this.IconsList.Images.SetKeyName(43, "042-outsourcing.png");
            this.IconsList.Images.SetKeyName(44, "043-transactions.png");
            this.IconsList.Images.SetKeyName(45, "044-forum.png");
            this.IconsList.Images.SetKeyName(46, "045-strategy.png");
            this.IconsList.Images.SetKeyName(47, "046-airplane.png");
            this.IconsList.Images.SetKeyName(48, "047-united.png");
            this.IconsList.Images.SetKeyName(49, "048-airplane.png");
            this.IconsList.Images.SetKeyName(50, "049-directions.png");
            this.IconsList.Images.SetKeyName(51, "050-business.png");
            this.IconsList.Images.SetKeyName(52, "scanner.png");
            this.IconsList.Images.SetKeyName(53, "start.png");
            this.IconsList.Images.SetKeyName(54, "stop-sign.png");
            this.IconsList.Images.SetKeyName(55, "computer.png");
            this.IconsList.Images.SetKeyName(56, "diagram.png");
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearMenuItem,
            this.ExportMenuItem,
            this.ImportMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1309, 38);
            this.MainMenu.TabIndex = 5;
            this.MainMenu.Text = "MainMenu";
            // 
            // ClearMenuItem
            // 
            this.ClearMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearMenuItem.Image = global::CMail.Properties.Resources.close;
            this.ClearMenuItem.Name = "ClearMenuItem";
            this.ClearMenuItem.Size = new System.Drawing.Size(92, 34);
            this.ClearMenuItem.Text = "Clear";
            this.ClearMenuItem.Click += new System.EventHandler(this.ClearMenuItem_Click);
            // 
            // ExportMenuItem
            // 
            this.ExportMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExportMenuItem.Image = global::CMail.Properties.Resources.export;
            this.ExportMenuItem.Name = "ExportMenuItem";
            this.ExportMenuItem.Size = new System.Drawing.Size(104, 34);
            this.ExportMenuItem.Text = "Export";
            this.ExportMenuItem.Click += new System.EventHandler(this.ExportMenuItem_Click);
            // 
            // ImportMenuItem
            // 
            this.ImportMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ImportMenuItem.Image = global::CMail.Properties.Resources.import1;
            this.ImportMenuItem.Name = "ImportMenuItem";
            this.ImportMenuItem.Size = new System.Drawing.Size(107, 34);
            this.ImportMenuItem.Text = "Import";
            this.ImportMenuItem.Click += new System.EventHandler(this.ImportMenuItem_Click);
            // 
            // ImportFolder
            // 
            this.ImportFolder.SelectedPath = "D:\\!!LUGANSK";
            // 
            // ImportInboxFileDialog
            // 
            this.ImportInboxFileDialog.FileName = "openFileDialog1";
            // 
            // OutboxFileUploadDialog
            // 
            this.OutboxFileUploadDialog.InitialDirectory = "m:\\POST\\Inbox\\";
            this.OutboxFileUploadDialog.Multiselect = true;
            this.OutboxFileUploadDialog.SupportMultiDottedExtensions = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartTool,
            this.StopTool,
            this.RefreshBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 38);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1309, 46);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // StartTool
            // 
            this.StartTool.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartTool.Image = ((System.Drawing.Image)(resources.GetObject("StartTool.Image")));
            this.StartTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StartTool.Name = "StartTool";
            this.StartTool.Size = new System.Drawing.Size(103, 43);
            this.StartTool.Text = "Start watching";
            this.StartTool.Click += new System.EventHandler(this.StartTool_Click);
            // 
            // StopTool
            // 
            this.StopTool.AutoSize = false;
            this.StopTool.Image = ((System.Drawing.Image)(resources.GetObject("StopTool.Image")));
            this.StopTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StopTool.Name = "StopTool";
            this.StopTool.Size = new System.Drawing.Size(107, 57);
            this.StopTool.Text = "Stop watching";
            this.StopTool.Click += new System.EventHandler(this.StopTool_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Image = global::CMail.Properties.Resources.reload;
            this.RefreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(66, 43);
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar.Location = new System.Drawing.Point(308, 12);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(989, 23);
            this.ProgressBar.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1309, 714);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.MailTab);
            this.Controls.Add(this.MainMenu);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Mail";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MailTab.ResumeLayout(false);
            this.OutboxTab.ResumeLayout(false);
            this.OutboxTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutboxData)).EndInit();
            this.InboxTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InboxData)).EndInit();
            this.NetFolderTab.ResumeLayout(false);
            this.SettingsTab.ResumeLayout(false);
            this.SettingsTab.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl MailTab;
        private System.Windows.Forms.TabPage OutboxTab;
        private System.Windows.Forms.ImageList IconsList;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem ClearMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportMenuItem;
        private System.Windows.Forms.FolderBrowserDialog ImportFolder;
        private System.Windows.Forms.OpenFileDialog ImportInboxFileDialog;
        private System.Windows.Forms.DataGridView OutboxData;
        private System.Windows.Forms.ListBox FilesToSendList;
        private System.Windows.Forms.OpenFileDialog OutboxFileUploadDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeOutbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndexOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilenameOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn SenderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AboutOut;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton StartTool;
        private System.Windows.Forms.ToolStripButton StopTool;
        private System.Windows.Forms.ToolStripButton RefreshBtn;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.ComboBox departmentNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SendAllBtn;
        private System.Windows.Forms.TabPage SettingsTab;
        private System.Windows.Forms.TabPage InboxTab;
        private System.Windows.Forms.DataGridView InboxData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmptyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn About;
        private System.Windows.Forms.DataGridViewTextBoxColumn Terms;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileSize;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabPage NetFolderTab;
        private System.Windows.Forms.ListBox NetDirectoryList;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Button PingBtn;
        private System.Windows.Forms.Button UpdateNetworkBtn;
        private System.Windows.Forms.TextBox IBAFolderSettings;
        private System.Windows.Forms.Button SaveSettingsBtn;
        private System.Windows.Forms.Button SetOBAFolderBtn;
        private System.Windows.Forms.Button SetOrgFolderBtn;
        private System.Windows.Forms.Button SetOBNFolderBtn;
        private System.Windows.Forms.Button IBFSetBtn;
        private System.Windows.Forms.Button SetCompJSONBtn;
        private System.Windows.Forms.Button SetOBFolderBtn;
        private System.Windows.Forms.Button SetFTSBtn;
        private System.Windows.Forms.Button IBASetFolderBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OABFolderSettings;
        private System.Windows.Forms.TextBox OrgFolderSettings;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OBNKFolderSettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CompInfoSettings;
        private System.Windows.Forms.TextBox IBFolderSettings;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox OBFolderSettings;
        private System.Windows.Forms.TextBox FilesOutFolderSettings;
        private System.Windows.Forms.Label label1;
    }
}

