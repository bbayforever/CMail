namespace CMail
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FilesData = new System.Windows.Forms.DataGridView();
            this.FromTextBox = new System.Windows.Forms.TextBox();
            this.ToTextBox = new System.Windows.Forms.TextBox();
            this.To = new System.Windows.Forms.Label();
            this.From = new System.Windows.Forms.Label();
            this.ToTextBoxSecond = new System.Windows.Forms.TextBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.InboxTab = new System.Windows.Forms.TabPage();
            this.OutboxTab = new System.Windows.Forms.TabPage();
            this.IconsList = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.StartBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmptyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.About = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Terms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportFolder = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.FilesData)).BeginInit();
            this.TabControl.SuspendLayout();
            this.InboxTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilesData
            // 
            this.FilesData.AllowUserToResizeColumns = false;
            this.FilesData.AllowUserToResizeRows = false;
            this.FilesData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilesData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.FilesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilesData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.EmptyColumn,
            this.FileDate,
            this.Index,
            this.About,
            this.Terms,
            this.FileName,
            this.Time,
            this.FileSize});
            this.FilesData.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FilesData.Location = new System.Drawing.Point(6, 122);
            this.FilesData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FilesData.Name = "FilesData";
            this.FilesData.Size = new System.Drawing.Size(1035, 263);
            this.FilesData.TabIndex = 0;
            // 
            // FromTextBox
            // 
            this.FromTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FromTextBox.Enabled = false;
            this.FromTextBox.Location = new System.Drawing.Point(4, 35);
            this.FromTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FromTextBox.Name = "FromTextBox";
            this.FromTextBox.Size = new System.Drawing.Size(195, 26);
            this.FromTextBox.TabIndex = 1;
            this.FromTextBox.Text = "c:\\t-mailip\\files\\";
            // 
            // ToTextBox
            // 
            this.ToTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToTextBox.Enabled = false;
            this.ToTextBox.Location = new System.Drawing.Point(226, 35);
            this.ToTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ToTextBox.Name = "ToTextBox";
            this.ToTextBox.Size = new System.Drawing.Size(195, 26);
            this.ToTextBox.TabIndex = 2;
            this.ToTextBox.Text = "D:\\!!LUGANSK\\Входящие\\";
            // 
            // To
            // 
            this.To.AutoSize = true;
            this.To.Location = new System.Drawing.Point(222, 10);
            this.To.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(28, 20);
            this.To.TabIndex = 3;
            this.To.Text = "To:";
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.Location = new System.Drawing.Point(4, 10);
            this.From.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(44, 20);
            this.From.TabIndex = 3;
            this.From.Text = "From:";
            // 
            // ToTextBoxSecond
            // 
            this.ToTextBoxSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToTextBoxSecond.Enabled = false;
            this.ToTextBoxSecond.Location = new System.Drawing.Point(226, 71);
            this.ToTextBoxSecond.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ToTextBoxSecond.Name = "ToTextBoxSecond";
            this.ToTextBoxSecond.Size = new System.Drawing.Size(195, 26);
            this.ToTextBoxSecond.TabIndex = 2;
            this.ToTextBoxSecond.Text = "m:\\POST\\Inbox\\";
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.InboxTab);
            this.TabControl.Controls.Add(this.OutboxTab);
            this.TabControl.ImageList = this.IconsList;
            this.TabControl.ItemSize = new System.Drawing.Size(100, 50);
            this.TabControl.Location = new System.Drawing.Point(12, 27);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1054, 475);
            this.TabControl.TabIndex = 4;
            // 
            // InboxTab
            // 
            this.InboxTab.Controls.Add(this.StopBtn);
            this.InboxTab.Controls.Add(this.StartBtn);
            this.InboxTab.Controls.Add(this.panel1);
            this.InboxTab.Controls.Add(this.FilesData);
            this.InboxTab.ImageKey = "download.png";
            this.InboxTab.Location = new System.Drawing.Point(4, 54);
            this.InboxTab.Name = "InboxTab";
            this.InboxTab.Padding = new System.Windows.Forms.Padding(3);
            this.InboxTab.Size = new System.Drawing.Size(1046, 417);
            this.InboxTab.TabIndex = 0;
            this.InboxTab.Text = "Inbox";
            this.InboxTab.UseVisualStyleBackColor = true;
            // 
            // OutboxTab
            // 
            this.OutboxTab.ImageIndex = 1;
            this.OutboxTab.Location = new System.Drawing.Point(4, 54);
            this.OutboxTab.Name = "OutboxTab";
            this.OutboxTab.Padding = new System.Windows.Forms.Padding(3);
            this.OutboxTab.Size = new System.Drawing.Size(1046, 404);
            this.OutboxTab.TabIndex = 1;
            this.OutboxTab.Text = "Outbox";
            this.OutboxTab.UseVisualStyleBackColor = true;
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
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.From);
            this.panel1.Controls.Add(this.FromTextBox);
            this.panel1.Controls.Add(this.ToTextBoxSecond);
            this.panel1.Controls.Add(this.ToTextBox);
            this.panel1.Controls.Add(this.To);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 108);
            this.panel1.TabIndex = 4;
            // 
            // StartBtn
            // 
            this.StartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartBtn.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StartBtn.Location = new System.Drawing.Point(537, 6);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(260, 108);
            this.StartBtn.TabIndex = 5;
            this.StartBtn.Text = "START";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Enabled = false;
            this.StopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopBtn.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StopBtn.Location = new System.Drawing.Point(803, 6);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(235, 108);
            this.StopBtn.TabIndex = 5;
            this.StopBtn.Text = "STOP";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // Date
            // 
            this.Date.HeaderText = "Date of receiving";
            this.Date.Name = "Date";
            // 
            // EmptyColumn
            // 
            this.EmptyColumn.HeaderText = "";
            this.EmptyColumn.Name = "EmptyColumn";
            // 
            // FileDate
            // 
            this.FileDate.HeaderText = "Date of creation";
            this.FileDate.Name = "FileDate";
            // 
            // Index
            // 
            this.Index.HeaderText = "Index";
            this.Index.Name = "Index";
            // 
            // About
            // 
            this.About.HeaderText = "About";
            this.About.Name = "About";
            // 
            // Terms
            // 
            this.Terms.HeaderText = "Terms";
            this.Terms.Name = "Terms";
            // 
            // FileName
            // 
            this.FileName.HeaderText = "Filename";
            this.FileName.Name = "FileName";
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            // 
            // FileSize
            // 
            this.FileSize.HeaderText = "Size";
            this.FileSize.Name = "FileSize";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.importToolStripMenuItem.Text = "Import";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 565);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Mail";
            ((System.ComponentModel.ISupportInitialize)(this.FilesData)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.InboxTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FilesData;
        private System.Windows.Forms.TextBox FromTextBox;
        private System.Windows.Forms.TextBox ToTextBox;
        private System.Windows.Forms.Label To;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.TextBox ToTextBoxSecond;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage InboxTab;
        private System.Windows.Forms.TabPage OutboxTab;
        private System.Windows.Forms.ImageList IconsList;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmptyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn About;
        private System.Windows.Forms.DataGridViewTextBoxColumn Terms;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileSize;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog ImportFolder;
    }
}

