using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppzManagerV4.Business;
using AppzManagerV4.DataObjects;
using AppzManagerV4.Global;

namespace AppzManagerV4.Forms
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// Contains the data manager
        /// </summary>
        private readonly DataManager _dataManager = new DataManager();
        /// <summary>
        /// Contains the current region
        /// </summary>
        private GlobalEnums.RegionType _selectedRegion = GlobalEnums.RegionType.App;
        /// <summary>
        /// Contains the apps
        /// </summary>
        private List<AppModel> _appList;
        /// <summary>
        /// Contains the folders
        /// </summary>
        private List<FolderModel> _folderList;
        /// <summary>
        /// Contains the file list
        /// </summary>
        private List<FileModel> _fileList;
        /// <summary>
        /// Contains the groups
        /// </summary>
        private List<GroupModel> _groupList;

        /// <summary>
        /// Contains the new entry delegate
        /// </summary>
        private CustomDelegates.NewEntry _newEntryDelegate;

        /// <summary>
        /// Creates a new instance of the form
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            InitForm();
        }
        /// <summary>
        /// Inits the form
        /// </summary>
        private void InitForm()
        {
            // Set the delegate
            _newEntryDelegate = CreateNewEntry;

            if (Properties.Settings.Default.ViewStyle == 1)
            {
                listViewApps.View = View.LargeIcon;
                listViewFolders.View = View.LargeIcon;
                listViewFiles.View = View.LargeIcon;
                viewMenuIcons.Checked = true;
                viewMenuList.Checked = false;
            }
            else
            {
                listViewApps.View = View.Details;
                listViewFolders.View = View.Details;
                listViewFiles.View = View.Details;
                viewMenuIcons.Checked = false;
                viewMenuList.Checked = true;
            }
        }
        /// <summary>
        /// Loads the entries
        /// </summary>
        private void LoadEntries()
        {
            _appList = _dataManager.GetApps();
            _folderList = _dataManager.GetFolder();
            _fileList = _dataManager.GetFiles();
            _groupList = _dataManager.GetGroups();


            ShowEntries();
        }
        /// <summary>
        /// Inits the lists
        /// </summary>
        private void InitLists()
        {
            listViewApps.Items.Clear();
            listViewFolders.Items.Clear();
            listViewFiles.Items.Clear();

            imageList.Images.Clear();

            listViewApps.Groups.Clear();
            listViewFolders.Groups.Clear();
            listViewFiles.Groups.Clear();
        }
        /// <summary>
        /// Shows the entries
        /// </summary>
        private void ShowEntries()
        {
            // Inits the lists
            InitLists();

            mainMenuNewEntry.Enabled = _groupList.Any();

            // Add the groups to the list views
            _groupList.OrderBy(o => o.Name).ToList().ForEach(entry =>
            {
                var groupEntry = new ListViewGroup(entry.Name) {Tag = entry};
                listViewApps.Groups.Add(groupEntry);
                listViewFolders.Groups.Add(groupEntry);
                listViewFiles.Groups.Add(groupEntry);
            });

            // Add the apps
            FormManager.CreateListView(ref listViewApps, ref _appList, imageList);
            // Add the folder
            FormManager.CreateListView(ref listViewFolders, ref _folderList, imageList);
            // Add the files
            FormManager.CreateListView(ref listViewFiles, ref _fileList, imageList);

            CreateNotifyMenu();

            listViewApps.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewApps.GridLines = true;

            listViewFolders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewFolders.GridLines = true;
        }
        /// <summary>
        /// Creates the context menu
        /// </summary>
        private void CreateNotifyMenu()
        {
            FormManager.CreateNotifyIcon(ref contextMenuNotify, _appList, _folderList, _fileList, _groupList, imageList, Icon);

            foreach (var item in contextMenuNotify.Items.OfType<ToolStripMenuItem>())
            {
                if (item.DropDownItems.Count > 0)
                {
                    foreach (var subItem in item.DropDownItems.OfType<ToolStripMenuItem>())
                    {
                        subItem.MouseDown += ContextMenuNotifyMouseDown;
                    }
                }
                else
                {
                    item.MouseDown += ContextMenuNotifyMouseDown;
                }
            }
        }
        /// <summary>
        /// Method to admin the drag & drop
        /// </summary>
        /// <param name="fileList"></param>
        private void DragDropEntry(IEnumerable<string> fileList)
        {
            var listFolder = new List<string>();
            var listApp = new List<string>();
            var listFiles = new List<string>();

            foreach (var file in fileList)
            {
                if (Functions.IsFolder(file))
                {
                    listFolder.Add(file);
                }
                else if (Functions.IsApplication(file))
                {
                    var filePath = "";
                    switch (Functions.GetFileExtension(file))
                    {
                        case "exe":
                            filePath = file;
                            break;
                        case "lnk":
                            filePath = Functions.GetPathOfLnk(file);
                            break;
                    }

                    if (string.IsNullOrEmpty(filePath))
                    {
                        MessageBox.Show("Dateipfad konnte nicht ermittelt werden.", "Fehler", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        continue;
                    }
                    listApp.Add(filePath);
                }
                else
                {
                    listFiles.Add(file);
                }

                if (listApp.Any())
                    BeginInvoke(_newEntryDelegate, GlobalEnums.RegionType.App, listApp);

                if (listFolder.Any())
                    BeginInvoke(_newEntryDelegate, GlobalEnums.RegionType.Folder, listFolder);

                if (listFiles.Any())
                    BeginInvoke(_newEntryDelegate, GlobalEnums.RegionType.File, listFiles);
            }

            LoadEntries();
        }
        /// <summary>
        /// Adds a new entry
        /// </summary>
        /// <param name="region">The region</param>
        /// <param name="filepathList">The filepathlist (optional, default = null)</param>
        private void CreateNewEntry(GlobalEnums.RegionType region, List<string> filepathList = null)
        {
            switch (region)
            {
                case GlobalEnums.RegionType.App:
                    FormManager.CreateNewEntry(region, _appList, filepathList);
                    break;
                case GlobalEnums.RegionType.Folder:
                    FormManager.CreateNewEntry(region, _folderList, filepathList);
                    break;
                case GlobalEnums.RegionType.File:
                    FormManager.CreateNewEntry(region, _fileList, filepathList);
                    break;
            }

            LoadEntries();
        }
        /// <summary>
        /// Edits an existing entry
        /// </summary>
        /// <param name="region">The region</param>
        /// <param name="entry">The entry</param>
        private void EditEntry(GlobalEnums.RegionType region, object entry)
        {
            var result = false;
            switch (region)
            {
                case GlobalEnums.RegionType.App:
                    result = FormManager.EditEntry(region, _appList, entry);
                    break;
                case GlobalEnums.RegionType.Folder:
                    result = FormManager.EditEntry(region, _folderList, entry);
                    break;
                case GlobalEnums.RegionType.File:
                    result = FormManager.EditEntry(region, _fileList, entry);
                    break;
            }


            if (result)
                LoadEntries();
        }
        /// <summary>
        /// Deletes an existing entry
        /// </summary>
        /// <param name="region">The region</param>
        /// <param name="id">The id of the entry</param>
        private void DeleteEntry(GlobalEnums.RegionType region, int id)
        {
            if (MessageBox.Show("Soll der Eintrag gelöscht werden?", "Löschen", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                return;

            var result = false;
            switch (region)
            {
                case GlobalEnums.RegionType.App:
                    result = _dataManager.DeleteApp(id);
                    break;
                case GlobalEnums.RegionType.Folder:
                    result = _dataManager.DeleteFolder(id);
                    break;
                case GlobalEnums.RegionType.File:
                    result = _dataManager.DeleteFile(id);
                    break;
            }

            if (result)
                LoadEntries();
        }
        /// <summary>
        /// Occurs when the user hits one of the menu items in the context menu
        /// </summary>
        private void ContextMenuNotifyMouseDown(object sender, MouseEventArgs e)
        {
            var menuItem = (sender as ToolStripMenuItem);
            if (menuItem == null)
                return;

            if (e.Button != MouseButtons.Right)
            {
                var app = menuItem.Tag as AppModel;
                var folder = menuItem.Tag as FolderModel;
                var file = menuItem.Tag as FileModel;

                if (menuItem.Name == "CloseItem")
                {
                    Application.Exit();
                }

                if (app == null && folder == null && file == null)
                {
                    switch (menuItem.Name)
                    {
                        case "CloseItem":
                            Application.Exit();
                            break;
                        case "NewAppItem":
                            CreateNewEntry(GlobalEnums.RegionType.App);
                            break;
                        case "NewFolderItem":
                            CreateNewEntry(GlobalEnums.RegionType.Folder);
                            break;
                        case "NewFileItem":
                            CreateNewEntry(GlobalEnums.RegionType.File);
                            break;
                        case "HeaderItem":
                            WindowState = FormWindowState.Normal;
                            BringToFront();
                            break;
                    }
                }
                else if (app != null)
                {
                    Functions.OpenExecute(app);
                }
                else if (folder != null)
                {
                    Functions.OpenExecute(folder);
                }
                else
                {
                    Functions.OpenExecute(file);
                }
            }
        }
        /// <summary>
        /// Occurs when the form is loading
        /// </summary>
        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadEntries();
            clockTimer.Start();

            // Set the window size
            // 763; 547
            if (Properties.Settings.Default.Width >= 750 && Properties.Settings.Default.Height >= 550)
            {
                Size = new Size(Properties.Settings.Default.Width, Properties.Settings.Default.Height);
            }
            else
            {
                Size = new Size(750, 550);
            }
        }
        /// <summary>
        /// Occurs when the user hits the group menu item
        /// </summary>
        private void mainMenuGroups_Click(object sender, EventArgs e)
        {
            var groupForm = new FormGroups();
            groupForm.ShowDialog();
            LoadEntries();
        }
        /// <summary>
        /// Occurs when the user hits the new entry menu item
        /// </summary>
        private void mainMenuNewEntry_Click(object sender, EventArgs e)
        {
            var region = GlobalEnums.RegionType.None;
            if (tabControl.SelectedTab == tabPageApps)
                region = GlobalEnums.RegionType.App;
            else if (tabControl.SelectedTab == tabPageFolders)
                region = GlobalEnums.RegionType.Folder;
            else if (tabControl.SelectedTab == tabPageFiles)
                region = GlobalEnums.RegionType.File;

            CreateNewEntry(region);
        }
        /// <summary>
        /// Occurs when the user hits a entry in the view menu
        /// </summary>
        private void viewMenu_Click(object sender, EventArgs e)
        {
            var viewStyle = 1;
            if (sender == viewMenuIcons)
            {
                listViewApps.View = View.LargeIcon;
                listViewFolders.View = View.LargeIcon;
                viewMenuIcons.Checked = true;
                viewMenuList.Checked = false;
            }
            else
            {
                viewStyle = 2;
                listViewApps.View = View.Details;
                listViewFolders.View = View.Details;
                viewMenuIcons.Checked = false;
                viewMenuList.Checked = true;
            }


            listViewApps.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewApps.GridLines = true;

            listViewFolders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewFolders.GridLines = true;

            Properties.Settings.Default.ViewStyle = viewStyle;
            Properties.Settings.Default.Save();
        }
        /// <summary>
        /// Occurs when the clock timer ticks
        /// </summary>
        private void clockTimer_Tick(object sender, EventArgs e)
        {
            toolStripDate.Text = DateTime.Now.ToString("T");
        }
        /// <summary>
        /// Occurs when an entry of the context menu is hit
        /// </summary>
        private void ContextMenuClick(object sender, EventArgs e)
        {
            AppModel app = null;
            FolderModel folder = null;
            FileModel file = null;

            if (listViewApps.SelectedItems.Count > 0)
                app = listViewApps.SelectedItems[0].Tag as AppModel;

            if (listViewFolders.SelectedItems.Count > 0)
                folder = listViewFolders.SelectedItems[0].Tag as FolderModel;

            if (listViewFiles.SelectedItems.Count > 0)
                file = listViewFiles.SelectedItems[0].Tag as FileModel;

            if (sender == contextMenuExecute)
            {
                if (_selectedRegion == GlobalEnums.RegionType.App && app != null)
                    Functions.OpenExecute(app);
                else if (_selectedRegion == GlobalEnums.RegionType.Folder && folder != null)
                    Functions.OpenExecute(folder);
                else if (_selectedRegion == GlobalEnums.RegionType.File && file != null)
                    Functions.OpenExecute(file);
            }
            else if (sender == contextMenuOpen)
            {
                if (_selectedRegion == GlobalEnums.RegionType.App && app != null)
                    Functions.OpenExecute(app, false);
                else if (_selectedRegion == GlobalEnums.RegionType.Folder && folder != null)
                    Functions.OpenExecute(folder);
                else if (_selectedRegion == GlobalEnums.RegionType.File && file != null)
                    Functions.OpenExecute(file);
            }
            else if (sender == contextMenuAddEntry)
            {
                CreateNewEntry(_selectedRegion);
            }
            else if (sender == contextMenuEdit)
            {
                if (app != null)
                    EditEntry(_selectedRegion, app);
                else if (folder != null)
                    EditEntry(_selectedRegion, folder);
                else if (file != null)
                    EditEntry(_selectedRegion, file);
            }
            else if (sender == contextMenuDelete)
            {
                if (app != null)
                    DeleteEntry(_selectedRegion, app.Id);
                else if (folder != null)
                    DeleteEntry(_selectedRegion, folder.Id);
                else if (file != null)
                    DeleteEntry(_selectedRegion, file.Id);
            }
        }
        /// <summary>
        /// Occurs when the notify icon is double clicked
        /// </summary>
        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }
        /// <summary>
        /// Occurs when the user drags an item into the form
        /// </summary>
        private void FormMain_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop, false)
                ? DragDropEffects.All
                : DragDropEffects.None;
        }
        /// <summary>
        /// Occurs when the user drops an item into the form
        /// </summary>
        private void FormMain_DragDrop(object sender, DragEventArgs e)
        {
            var fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            DragDropEntry(fileList);
        }
        /// <summary>
        /// Occurs when the user hits the close menu
        /// </summary>
        private void mainMenuClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Occurs when the user hits the reload button
        /// </summary>
        private void mainMenuReload_Click(object sender, EventArgs e)
        {
            LoadEntries();
        }
        /// <summary>
        /// Occurs when the form is showing
        /// </summary>
        private void FormMain_Shown(object sender, EventArgs e)
        {
            if (!_appList.Any(a => a.Autostart))
                return;
            if (MessageBox.Show("Autostart Anwendungen starten?", "Autostart", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var deleteList = _appList.Where(w => w.Autostart).Where(app => !Functions.OpenExecute(app)).ToList();

                if (deleteList.Any())
                {
                    var msg = "Folgende Anwendungen konnten nicht gestartet werden:";

                    deleteList.ForEach(entry =>
                    {
                        msg += $"\r\n\t- \"{entry.Name}\"";
                    });

                    msg += "\r\nSollen diese Anwendungen gelöscht werden?";

                    if (MessageBox.Show(msg, "Fehler Autostart", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        deleteList.Select(s => s.Id)
                            .ToList()
                            .ForEach(entry => DeleteEntry(GlobalEnums.RegionType.App, entry));
                    }
                }
            }
        }
        /// <summary>
        /// Occurs when the user selects another entry
        /// </summary>
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var info = "";
            if (_selectedRegion == GlobalEnums.RegionType.App)
            {
                if (listViewApps.SelectedItems.Count > 0)
                {
                    var app = listViewApps.SelectedItems[0].Tag as AppModel;
                    if (app == null)
                        return;

                    info = app.Name;
                    if (!string.IsNullOrEmpty(app.Comment))
                        info += $" - {app.Comment}";
                    if (!string.IsNullOrEmpty(app.Shortcut))
                        info += $" (Shortcut: {app.Shortcut})";
                    if (app.Autostart)
                        info += " - Autostart aktiviert";
                }
            }
            else if (_selectedRegion == GlobalEnums.RegionType.Folder)
            {
                if (listViewFolders.SelectedItems.Count > 0)
                {
                    var folder = listViewFolders.SelectedItems[0].Tag as FolderModel;
                    if (folder == null)
                        return;

                    info = folder.Name;
                    if (!string.IsNullOrEmpty(folder.Comment))
                        info += $" - {folder.Comment}";
                    if (!string.IsNullOrEmpty(folder.Shortcut))
                        info += $" (Shortcut: {folder.Shortcut})";
                }
            }
            else if (_selectedRegion == GlobalEnums.RegionType.File)
            {
                if (listViewFiles.SelectedItems.Count > 0)
                {
                    var file = listViewFiles.SelectedItems[0].Tag as FileModel;
                    if (file == null)
                        return;

                    info = file.Name;
                    if (!string.IsNullOrEmpty(file.Comment))
                        info += $" - {file.Comment}";
                    if (!string.IsNullOrEmpty(file.Shortcut))
                        info += $" (Shortcut: {file.Shortcut})";
                }
            }
            toolStripInfo.Text = info;
        }
        /// <summary>
        /// Occurs when the user hits the import menu
        /// </summary>
        private void dataMenuImport_Click(object sender, EventArgs e)
        {
            var importForm = new FormImport();
            if (importForm.ShowDialog() != DialogResult.Cancel)
            {
                LoadEntries();
            }
        }
        /// <summary>
        /// Occurs when the user leaves the list view
        /// </summary>
        private void listView_Leave(object sender, EventArgs e)
        {
            toolStripInfo.Text = "";
        }
        /// <summary>
        /// Occurs when the user hits a key while the listview is focused
        /// </summary>
        private void listView_KeyDown(object sender, KeyEventArgs e)
        {
            AppModel app = null;
            FolderModel folder = null;
            FileModel file = null;

            if (listViewApps.SelectedItems.Count > 0)
                app = listViewApps.SelectedItems[0].Tag as AppModel;

            if (listViewFolders.SelectedItems.Count > 0)
                folder = listViewFolders.SelectedItems[0].Tag as FolderModel;

            if (listViewFiles.SelectedItems.Count > 0)
                file = listViewFiles.SelectedItems[0].Tag as FileModel;

            var result = GlobalEnums.KeyDownEvent.None;

            if (app != null)
                result = Functions.MainKeyDown(e, _selectedRegion, app, _appList);
            else if (folder != null)
                result = Functions.MainKeyDown(e, _selectedRegion, folder, _folderList);
            else if (file != null)
                result = Functions.MainKeyDown(e, _selectedRegion, file, _folderList);
            else
            {
                switch (_selectedRegion)
                {
                    case GlobalEnums.RegionType.App:
                        result = Functions.MainKeyDown(e, _selectedRegion, null, _appList);
                        break;
                    case GlobalEnums.RegionType.Folder:
                        result = Functions.MainKeyDown(e, _selectedRegion, null, _folderList);
                        break;
                    case GlobalEnums.RegionType.File:
                        result = Functions.MainKeyDown(e, _selectedRegion, null, _fileList);
                        break;
                }
            }

            if (result != GlobalEnums.KeyDownEvent.None)
                LoadEntries();
        }
        /// <summary>
        /// Occurs when the user performs a double click in the list view
        /// </summary>
        private void listView_DoubleClick(object sender, EventArgs e)
        {
            switch (_selectedRegion)
            {
                case GlobalEnums.RegionType.App:
                    if (listViewApps.SelectedItems.Count > 0)
                        Functions.OpenExecute(listViewApps.SelectedItems[0].Tag as AppModel);
                    break;
                case GlobalEnums.RegionType.Folder:
                    if (listViewFolders.SelectedItems.Count > 0)
                        Functions.OpenExecute(listViewFolders.SelectedItems[0].Tag as FolderModel);
                    break;
                case GlobalEnums.RegionType.File:
                    if (listViewFiles.SelectedItems.Count > 0)
                        Functions.OpenExecute(listViewFiles.SelectedItems[0].Tag as FileModel);
                    break;
            }
        }
        /// <summary>
        /// Occurs when the context menu is opening
        /// </summary>
        private void contextMenu_Opening(object sender, CancelEventArgs e)
        {
            contextMenuExecute.Enabled = false;
            contextMenuOpen.Enabled = false;
            contextMenuDelete.Enabled = false;
            contextMenuEdit.Enabled = false;
            switch (_selectedRegion)
            {
                case GlobalEnums.RegionType.App:
                    if (listViewApps.SelectedItems.Count <= 0)
                        return;

                    var app = listViewApps.SelectedItems[0].Tag as AppModel;
                    if (app == null)
                        return;

                    contextMenuExecute.Enabled = !app.Error;
                    contextMenuOpen.Enabled = !app.Error;
                    contextMenuDelete.Enabled = true;
                    contextMenuEdit.Enabled = true;
                    break;
                case GlobalEnums.RegionType.Folder:
                    if (listViewFolders.SelectedItems.Count <= 0)
                        return;

                    var folder = listViewFolders.SelectedItems[0].Tag as FolderModel;
                    if (folder == null)
                        return;

                    contextMenuOpen.Enabled = !folder.Error;
                    contextMenuDelete.Enabled = true;
                    contextMenuEdit.Enabled = true;
                    break;
                case GlobalEnums.RegionType.File:
                    if (listViewFiles.SelectedItems.Count <= 0)
                        return;

                    var file = listViewFiles.SelectedItems[0].Tag as FileModel;
                    if (file == null)
                        return;

                    contextMenuExecute.Enabled = !file.Error;
                    contextMenuOpen.Enabled = !file.Error;
                    contextMenuDelete.Enabled = true;
                    contextMenuEdit.Enabled = true;
                    break;
            }
        }
        /// <summary>
        /// Occurs when a tab control was selected
        /// </summary>
        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl.SelectedTab == tabPageApps)
                _selectedRegion = GlobalEnums.RegionType.App;
            else if (tabControl.SelectedTab == tabPageFolders)
                _selectedRegion = GlobalEnums.RegionType.Folder;
            else if (tabControl.SelectedTab == tabPageFiles)
                _selectedRegion = GlobalEnums.RegionType.File;
        }
        /// <summary>
        /// Occurs when the form is closing
        /// </summary>
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Width = Size.Width;
            Properties.Settings.Default.Height = Size.Height;
            Properties.Settings.Default.Save();
        }
        /// <summary>
        /// Occurs when the user hits the md5 hash menu item in the tools menu
        /// </summary>
        private void toolsMenuMd5Hash_Click(object sender, EventArgs e)
        {
            var md5Form = new FormMd5Hash();
            md5Form.ShowDialog();
        }
    }
}
