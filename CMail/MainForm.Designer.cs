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
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.ToTextBox1 = new System.Windows.Forms.TextBox();
            this.ToTextBox2 = new System.Windows.Forms.TextBox();
            this.From = new System.Windows.Forms.Label();
            this.FromInbox = new System.Windows.Forms.TextBox();
            this.To = new System.Windows.Forms.Label();
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
            this.NetFolderTab = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.MailTab.SuspendLayout();
            this.OutboxTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OutboxData)).BeginInit();
            this.InboxTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InboxData)).BeginInit();
            this.SettingsTab.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.NetFolderTab.SuspendLayout();
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
            // SettingsTab
            // 
            this.SettingsTab.BackColor = System.Drawing.Color.GhostWhite;
            this.SettingsTab.Controls.Add(this.ToTextBox1);
            this.SettingsTab.Controls.Add(this.ToTextBox2);
            this.SettingsTab.Controls.Add(this.From);
            this.SettingsTab.Controls.Add(this.FromInbox);
            this.SettingsTab.Controls.Add(this.To);
            this.SettingsTab.ImageKey = "computer.png";
            this.SettingsTab.Location = new System.Drawing.Point(4, 54);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Size = new System.Drawing.Size(1301, 571);
            this.SettingsTab.TabIndex = 3;
            this.SettingsTab.Text = "Settings";
            // 
            // ToTextBox1
            // 
            this.ToTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToTextBox1.Location = new System.Drawing.Point(61, 59);
            this.ToTextBox1.Name = "ToTextBox1";
            this.ToTextBox1.Size = new System.Drawing.Size(231, 26);
            this.ToTextBox1.TabIndex = 9;
            this.ToTextBox1.Text = "d:\\!!LUGANSK\\Входящие\\";
            // 
            // ToTextBox2
            // 
            this.ToTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToTextBox2.Location = new System.Drawing.Point(61, 91);
            this.ToTextBox2.Name = "ToTextBox2";
            this.ToTextBox2.Size = new System.Drawing.Size(231, 26);
            this.ToTextBox2.TabIndex = 10;
            this.ToTextBox2.Text = "m:\\POST\\Inbox\\";
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.Location = new System.Drawing.Point(9, 11);
            this.From.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(44, 20);
            this.From.TabIndex = 7;
            this.From.Text = "From:";
            // 
            // FromInbox
            // 
            this.FromInbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FromInbox.Location = new System.Drawing.Point(61, 9);
            this.FromInbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FromInbox.Name = "FromInbox";
            this.FromInbox.Size = new System.Drawing.Size(215, 26);
            this.FromInbox.TabIndex = 6;
            this.FromInbox.Text = "c:\\t-mailip\\files\\";
            // 
            // To
            // 
            this.To.AutoSize = true;
            this.To.Location = new System.Drawing.Point(9, 62);
            this.To.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(28, 20);
            this.To.TabIndex = 8;
            this.To.Text = "To:";
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
            // NetFolderTab
            // 
            this.NetFolderTab.Controls.Add(this.listBox1);
            this.NetFolderTab.Location = new System.Drawing.Point(4, 54);
            this.NetFolderTab.Name = "NetFolderTab";
            this.NetFolderTab.Size = new System.Drawing.Size(1301, 571);
            this.NetFolderTab.TabIndex = 4;
            this.NetFolderTab.Text = "Net Folders";
            this.NetFolderTab.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1290, 564);
            this.listBox1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1309, 714);
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
            this.SettingsTab.ResumeLayout(false);
            this.SettingsTab.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.NetFolderTab.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox ToTextBox1;
        private System.Windows.Forms.TextBox ToTextBox2;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.TextBox FromInbox;
        private System.Windows.Forms.Label To;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabPage NetFolderTab;
        private System.Windows.Forms.ListBox listBox1;
    }
}

