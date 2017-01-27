namespace AppzManagerV4.Forms
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.contextMenuNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.columnPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnExecuteIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnParameter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnShowIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAutostart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuExecute = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuAddEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.tabPageFolders = new System.Windows.Forms.TabPage();
            this.listViewFolders = new System.Windows.Forms.ListView();
            this.columnFolderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFolderShortcut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFolderComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFolderPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFolderShowIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.columnComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.columnVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStripMainForm = new System.Windows.Forms.MenuStrip();
            this.mainMenuProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.programMenuData = new System.Windows.Forms.ToolStripMenuItem();
            this.dataMenuImport = new System.Windows.Forms.ToolStripMenuItem();
            this.programMenuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuView = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenuIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenuList = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuNewEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuGroups = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuReload = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMainForm = new System.Windows.Forms.StatusStrip();
            this.toolStripDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageApps = new System.Windows.Forms.TabPage();
            this.listViewApps = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnShortcut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageFiles = new System.Windows.Forms.TabPage();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.columnFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFileShortcut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFileComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFileShowIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenu.SuspendLayout();
            this.tabPageFolders.SuspendLayout();
            this.menuStripMainForm.SuspendLayout();
            this.statusStripMainForm.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageApps.SuspendLayout();
            this.tabPageFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuNotify
            // 
            this.contextMenuNotify.Name = "contextMenuNotify";
            this.contextMenuNotify.Size = new System.Drawing.Size(61, 4);
            // 
            // columnPath
            // 
            this.columnPath.Text = "Pfad";
            // 
            // columnExecuteIn
            // 
            this.columnExecuteIn.Text = "Ausführen in";
            // 
            // columnParameter
            // 
            this.columnParameter.Text = "Parameter";
            // 
            // columnShowIn
            // 
            this.columnShowIn.Text = "Im Kontextmenü anzeigen";
            // 
            // columnAutostart
            // 
            this.columnAutostart.Text = "Autostart";
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuExecute,
            this.contextMenuOpen,
            this.contextMenuSeparator,
            this.contextMenuAddEntry,
            this.contextMenuEdit,
            this.contextMenuDelete});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(173, 120);
            this.contextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);
            // 
            // contextMenuExecute
            // 
            this.contextMenuExecute.Name = "contextMenuExecute";
            this.contextMenuExecute.Size = new System.Drawing.Size(172, 22);
            this.contextMenuExecute.Text = "Öffnen";
            this.contextMenuExecute.Click += new System.EventHandler(this.ContextMenuClick);
            // 
            // contextMenuOpen
            // 
            this.contextMenuOpen.Name = "contextMenuOpen";
            this.contextMenuOpen.Size = new System.Drawing.Size(172, 22);
            this.contextMenuOpen.Text = "Dateipfad öffnen...";
            this.contextMenuOpen.Click += new System.EventHandler(this.ContextMenuClick);
            // 
            // contextMenuSeparator
            // 
            this.contextMenuSeparator.Name = "contextMenuSeparator";
            this.contextMenuSeparator.Size = new System.Drawing.Size(169, 6);
            this.contextMenuSeparator.Click += new System.EventHandler(this.ContextMenuClick);
            // 
            // contextMenuAddEntry
            // 
            this.contextMenuAddEntry.Name = "contextMenuAddEntry";
            this.contextMenuAddEntry.Size = new System.Drawing.Size(172, 22);
            this.contextMenuAddEntry.Text = "Neuer Eintrag";
            this.contextMenuAddEntry.Click += new System.EventHandler(this.ContextMenuClick);
            // 
            // contextMenuEdit
            // 
            this.contextMenuEdit.Name = "contextMenuEdit";
            this.contextMenuEdit.Size = new System.Drawing.Size(172, 22);
            this.contextMenuEdit.Text = "Eintrag bearbeiten";
            this.contextMenuEdit.Click += new System.EventHandler(this.ContextMenuClick);
            // 
            // contextMenuDelete
            // 
            this.contextMenuDelete.Name = "contextMenuDelete";
            this.contextMenuDelete.Size = new System.Drawing.Size(172, 22);
            this.contextMenuDelete.Text = "Eintrag löschen";
            this.contextMenuDelete.Click += new System.EventHandler(this.ContextMenuClick);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(32, 32);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabPageFolders
            // 
            this.tabPageFolders.Controls.Add(this.listViewFolders);
            this.tabPageFolders.Location = new System.Drawing.Point(4, 22);
            this.tabPageFolders.Name = "tabPageFolders";
            this.tabPageFolders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFolders.Size = new System.Drawing.Size(602, 351);
            this.tabPageFolders.TabIndex = 1;
            this.tabPageFolders.Text = "Ordner";
            this.tabPageFolders.UseVisualStyleBackColor = true;
            // 
            // listViewFolders
            // 
            this.listViewFolders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFolderName,
            this.columnFolderShortcut,
            this.columnFolderComment,
            this.columnFolderPath,
            this.columnFolderShowIn});
            this.listViewFolders.ContextMenuStrip = this.contextMenu;
            this.listViewFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewFolders.FullRowSelect = true;
            this.listViewFolders.GridLines = true;
            this.listViewFolders.LargeImageList = this.imageList;
            this.listViewFolders.Location = new System.Drawing.Point(3, 3);
            this.listViewFolders.Name = "listViewFolders";
            this.listViewFolders.Size = new System.Drawing.Size(596, 345);
            this.listViewFolders.TabIndex = 0;
            this.listViewFolders.UseCompatibleStateImageBehavior = false;
            this.listViewFolders.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            this.listViewFolders.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            this.listViewFolders.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView_KeyDown);
            this.listViewFolders.MouseLeave += new System.EventHandler(this.listView_Leave);
            // 
            // columnFolderName
            // 
            this.columnFolderName.Text = "Ordner";
            // 
            // columnFolderShortcut
            // 
            this.columnFolderShortcut.Text = "Shortcut";
            // 
            // columnFolderComment
            // 
            this.columnFolderComment.DisplayIndex = 3;
            this.columnFolderComment.Text = "Kommentar";
            // 
            // columnFolderPath
            // 
            this.columnFolderPath.DisplayIndex = 2;
            this.columnFolderPath.Text = "Pfad";
            // 
            // columnFolderShowIn
            // 
            this.columnFolderShowIn.Text = "Im Kontextmenü anzeigen";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuNotify;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "AppzManager";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // columnComment
            // 
            this.columnComment.Text = "Kommentar";
            // 
            // clockTimer
            // 
            this.clockTimer.Interval = 1000;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // columnVersion
            // 
            this.columnVersion.Text = "Version";
            // 
            // menuStripMainForm
            // 
            this.menuStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuProgram,
            this.mainMenuView,
            this.mainMenuNewEntry,
            this.mainMenuGroups,
            this.mainMenuReload});
            this.menuStripMainForm.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainForm.Name = "menuStripMainForm";
            this.menuStripMainForm.Size = new System.Drawing.Size(747, 24);
            this.menuStripMainForm.TabIndex = 3;
            this.menuStripMainForm.Text = "menuStripMainForm";
            // 
            // mainMenuProgram
            // 
            this.mainMenuProgram.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programMenuData,
            this.programMenuClose});
            this.mainMenuProgram.Name = "mainMenuProgram";
            this.mainMenuProgram.Size = new System.Drawing.Size(76, 20);
            this.mainMenuProgram.Text = "&Programm";
            // 
            // programMenuData
            // 
            this.programMenuData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataMenuImport});
            this.programMenuData.Name = "programMenuData";
            this.programMenuData.Size = new System.Drawing.Size(120, 22);
            this.programMenuData.Text = "Daten";
            // 
            // dataMenuImport
            // 
            this.dataMenuImport.Name = "dataMenuImport";
            this.dataMenuImport.Size = new System.Drawing.Size(245, 22);
            this.dataMenuImport.Text = "Import (AppzManager V3 Daten)";
            this.dataMenuImport.Click += new System.EventHandler(this.dataMenuImport_Click);
            // 
            // programMenuClose
            // 
            this.programMenuClose.Name = "programMenuClose";
            this.programMenuClose.Size = new System.Drawing.Size(120, 22);
            this.programMenuClose.Text = "&Beenden";
            this.programMenuClose.Click += new System.EventHandler(this.mainMenuClose_Click);
            // 
            // mainMenuView
            // 
            this.mainMenuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewMenuIcons,
            this.viewMenuList});
            this.mainMenuView.Name = "mainMenuView";
            this.mainMenuView.Size = new System.Drawing.Size(59, 20);
            this.mainMenuView.Text = "&Ansicht";
            // 
            // viewMenuIcons
            // 
            this.viewMenuIcons.Name = "viewMenuIcons";
            this.viewMenuIcons.Size = new System.Drawing.Size(102, 22);
            this.viewMenuIcons.Text = "&Icons";
            this.viewMenuIcons.Click += new System.EventHandler(this.viewMenu_Click);
            // 
            // viewMenuList
            // 
            this.viewMenuList.Name = "viewMenuList";
            this.viewMenuList.Size = new System.Drawing.Size(102, 22);
            this.viewMenuList.Text = "&Liste";
            this.viewMenuList.Click += new System.EventHandler(this.viewMenu_Click);
            // 
            // mainMenuNewEntry
            // 
            this.mainMenuNewEntry.Name = "mainMenuNewEntry";
            this.mainMenuNewEntry.Size = new System.Drawing.Size(91, 20);
            this.mainMenuNewEntry.Text = "&Neuer Eintrag";
            this.mainMenuNewEntry.Click += new System.EventHandler(this.mainMenuNewEntry_Click);
            // 
            // mainMenuGroups
            // 
            this.mainMenuGroups.Name = "mainMenuGroups";
            this.mainMenuGroups.Size = new System.Drawing.Size(65, 20);
            this.mainMenuGroups.Text = "&Gruppen";
            this.mainMenuGroups.Click += new System.EventHandler(this.mainMenuGroups_Click);
            // 
            // mainMenuReload
            // 
            this.mainMenuReload.Name = "mainMenuReload";
            this.mainMenuReload.Size = new System.Drawing.Size(73, 20);
            this.mainMenuReload.Text = "Neu &laden";
            this.mainMenuReload.Click += new System.EventHandler(this.mainMenuReload_Click);
            // 
            // statusStripMainForm
            // 
            this.statusStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDate,
            this.toolStripInfo});
            this.statusStripMainForm.Location = new System.Drawing.Point(0, 485);
            this.statusStripMainForm.Name = "statusStripMainForm";
            this.statusStripMainForm.Size = new System.Drawing.Size(747, 24);
            this.statusStripMainForm.TabIndex = 4;
            this.statusStripMainForm.Text = "statusStripMainForm";
            // 
            // toolStripDate
            // 
            this.toolStripDate.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripDate.Name = "toolStripDate";
            this.toolStripDate.Size = new System.Drawing.Size(118, 19);
            this.toolStripDate.Text = "00.00.0000 - 00:00:00";
            // 
            // toolStripInfo
            // 
            this.toolStripInfo.Name = "toolStripInfo";
            this.toolStripInfo.Size = new System.Drawing.Size(0, 19);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageApps);
            this.tabControl.Controls.Add(this.tabPageFolders);
            this.tabControl.Controls.Add(this.tabPageFiles);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(747, 461);
            this.tabControl.TabIndex = 5;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // tabPageApps
            // 
            this.tabPageApps.Controls.Add(this.listViewApps);
            this.tabPageApps.Location = new System.Drawing.Point(4, 22);
            this.tabPageApps.Name = "tabPageApps";
            this.tabPageApps.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageApps.Size = new System.Drawing.Size(739, 435);
            this.tabPageApps.TabIndex = 0;
            this.tabPageApps.Text = "Anwendungen";
            this.tabPageApps.UseVisualStyleBackColor = true;
            // 
            // listViewApps
            // 
            this.listViewApps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnShortcut,
            this.columnVersion,
            this.columnComment,
            this.columnPath,
            this.columnExecuteIn,
            this.columnParameter,
            this.columnShowIn,
            this.columnAutostart});
            this.listViewApps.ContextMenuStrip = this.contextMenu;
            this.listViewApps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewApps.FullRowSelect = true;
            this.listViewApps.GridLines = true;
            this.listViewApps.LargeImageList = this.imageList;
            this.listViewApps.Location = new System.Drawing.Point(3, 3);
            this.listViewApps.Name = "listViewApps";
            this.listViewApps.Size = new System.Drawing.Size(733, 429);
            this.listViewApps.TabIndex = 0;
            this.listViewApps.UseCompatibleStateImageBehavior = false;
            this.listViewApps.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            this.listViewApps.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            this.listViewApps.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView_KeyDown);
            this.listViewApps.Leave += new System.EventHandler(this.listView_Leave);
            // 
            // columnName
            // 
            this.columnName.Text = "Anwendung";
            // 
            // columnShortcut
            // 
            this.columnShortcut.Text = "Shortcut";
            // 
            // tabPageFiles
            // 
            this.tabPageFiles.Controls.Add(this.listViewFiles);
            this.tabPageFiles.Location = new System.Drawing.Point(4, 22);
            this.tabPageFiles.Name = "tabPageFiles";
            this.tabPageFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFiles.Size = new System.Drawing.Size(602, 351);
            this.tabPageFiles.TabIndex = 2;
            this.tabPageFiles.Text = "Dateien";
            this.tabPageFiles.UseVisualStyleBackColor = true;
            // 
            // listViewFiles
            // 
            this.listViewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFileName,
            this.columnFileShortcut,
            this.columnFileComment,
            this.columnFilePath,
            this.columnFileShowIn});
            this.listViewFiles.ContextMenuStrip = this.contextMenu;
            this.listViewFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewFiles.FullRowSelect = true;
            this.listViewFiles.GridLines = true;
            this.listViewFiles.LargeImageList = this.imageList;
            this.listViewFiles.Location = new System.Drawing.Point(3, 3);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(596, 345);
            this.listViewFiles.TabIndex = 0;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            this.listViewFiles.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            this.listViewFiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView_KeyDown);
            this.listViewFiles.Leave += new System.EventHandler(this.listView_Leave);
            // 
            // columnFileName
            // 
            this.columnFileName.Text = "";
            // 
            // columnFileShortcut
            // 
            this.columnFileShortcut.Text = "";
            // 
            // columnFileComment
            // 
            this.columnFileComment.Text = "";
            // 
            // columnFilePath
            // 
            this.columnFilePath.Text = "";
            // 
            // columnFileShowIn
            // 
            this.columnFileShowIn.Text = "Im Kontextmenü anzeigen";
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 509);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStripMainForm);
            this.Controls.Add(this.statusStripMainForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppzManager V.4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.FormMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.FormMain_DragEnter);
            this.contextMenu.ResumeLayout(false);
            this.tabPageFolders.ResumeLayout(false);
            this.menuStripMainForm.ResumeLayout(false);
            this.menuStripMainForm.PerformLayout();
            this.statusStripMainForm.ResumeLayout(false);
            this.statusStripMainForm.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageApps.ResumeLayout(false);
            this.tabPageFiles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuNotify;
        private System.Windows.Forms.ColumnHeader columnPath;
        private System.Windows.Forms.ColumnHeader columnExecuteIn;
        private System.Windows.Forms.ColumnHeader columnParameter;
        private System.Windows.Forms.ColumnHeader columnShowIn;
        private System.Windows.Forms.ColumnHeader columnAutostart;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem contextMenuExecute;
        private System.Windows.Forms.ToolStripMenuItem contextMenuOpen;
        private System.Windows.Forms.ToolStripSeparator contextMenuSeparator;
        private System.Windows.Forms.ToolStripMenuItem contextMenuAddEntry;
        private System.Windows.Forms.ToolStripMenuItem contextMenuEdit;
        private System.Windows.Forms.ToolStripMenuItem contextMenuDelete;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.TabPage tabPageFolders;
        private System.Windows.Forms.ListView listViewFolders;
        private System.Windows.Forms.ColumnHeader columnFolderName;
        private System.Windows.Forms.ColumnHeader columnFolderShortcut;
        private System.Windows.Forms.ColumnHeader columnFolderComment;
        private System.Windows.Forms.ColumnHeader columnFolderPath;
        private System.Windows.Forms.ColumnHeader columnFolderShowIn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ColumnHeader columnComment;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.ColumnHeader columnVersion;
        private System.Windows.Forms.MenuStrip menuStripMainForm;
        private System.Windows.Forms.ToolStripMenuItem mainMenuProgram;
        private System.Windows.Forms.ToolStripMenuItem programMenuClose;
        private System.Windows.Forms.ToolStripMenuItem mainMenuView;
        private System.Windows.Forms.ToolStripMenuItem viewMenuIcons;
        private System.Windows.Forms.ToolStripMenuItem viewMenuList;
        private System.Windows.Forms.ToolStripMenuItem mainMenuNewEntry;
        private System.Windows.Forms.ToolStripMenuItem mainMenuGroups;
        private System.Windows.Forms.ToolStripMenuItem mainMenuReload;
        private System.Windows.Forms.StatusStrip statusStripMainForm;
        private System.Windows.Forms.ToolStripStatusLabel toolStripDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripInfo;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageApps;
        private System.Windows.Forms.ListView listViewApps;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnShortcut;
        private System.Windows.Forms.ToolStripMenuItem programMenuData;
        private System.Windows.Forms.ToolStripMenuItem dataMenuImport;
        private System.Windows.Forms.TabPage tabPageFiles;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.ColumnHeader columnFileName;
        private System.Windows.Forms.ColumnHeader columnFileShortcut;
        private System.Windows.Forms.ColumnHeader columnFileComment;
        private System.Windows.Forms.ColumnHeader columnFilePath;
        private System.Windows.Forms.ColumnHeader columnFileShowIn;
    }
}