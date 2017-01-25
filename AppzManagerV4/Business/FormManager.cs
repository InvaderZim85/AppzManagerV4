using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AppzManagerV4.DataObjects;
using AppzManagerV4.Forms;
using AppzManagerV4.Global;
using TAFactory.IconPack;

namespace AppzManagerV4.Business
{
    public static class FormManager
    {
        /// <summary>
        /// Contains the data maanger
        /// </summary>
        private static readonly DataManager DataManager = new DataManager();

        /// <summary>
        /// Creates the listview for the apps
        /// </summary>
        /// <param name="listView">The list view</param>
        /// <param name="appList">The app list</param>
        /// <param name="imgList">The image list</param>
        public static void CreateListView(ref ListView listView, ref List<AppModel> appList, ImageList imgList)
        {
            if (!appList.Any())
                return;

            var deletedList = new List<AppModel>();
            var count = imgList.Images.Count;

            listView.Items.Clear();

            foreach (var app in appList.OrderBy(o => o.Name))
            {
                var addEntry = true;
                var error = false;

                if (!File.Exists(app.Path))
                {
                    if (MessageBox.Show(
                            $"Der Pfad der Anwedung \"{app.Name}\" (Pfad: {app.Path}) konnte nicht gefunden werden. Soll der Eintrag entfernt werden?",
                            "Anwendung - Fehler", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        deletedList.Add(app);
                        addEntry = false;
                    }
                    error = true;
                    app.Error = true;
                }

                if (!addEntry)
                    continue;

                listView.Items.Add(CreateListViewItem(GlobalEnums.RegionType.App, listView, app, error, imgList, count));
                count++;
            }

            foreach (var entry in deletedList)
            {
                appList.Remove(entry);
                DataManager.DeleteApp(entry);
            }
        }
        /// <summary>
        /// Creates the listview for the folders
        /// </summary>
        /// <param name="listView">The list viewq</param>
        /// <param name="folderList">The folder list</param>
        /// <param name="imageList">The image list</param>
        public static void CreateListView(ref ListView listView, ref List<FolderModel> folderList, ImageList imageList)
        {
            if (!folderList.Any())
                return;

            var deleteList = new List<FolderModel>();
            var count = imageList.Images.Count;

            listView.Items.Clear();

            foreach (var folder in folderList)
            {
                var addEntry = true;
                var error = false;

                if (!Directory.Exists(folder.Path))
                {
                    if (MessageBox.Show(
                        $"Der Pfad des Ordners {folder.Name} (Pfad: {folder.Path}) konnte nicht gefunden werden. Soll der Eintrag entfernt werden?",
                        "Ordner", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        deleteList.Add(folder);
                        addEntry = false;
                    }
                    error = true;
                    folder.Error = true;
                }

                if (addEntry)
                {
                    listView.Items.Add(CreateListViewItem(GlobalEnums.RegionType.Folder, listView, folder, error, imageList, count));
                    count++;
                }
            }

            foreach (var entry in deleteList)
            {
                folderList.Remove(entry);
                DataManager.DeleteFolder(entry);
            }
        }
        /// <summary>
        /// Creates the listview for the files
        /// </summary>
        /// <param name="listView">The list view</param>
        /// <param name="fileList">The file list</param>
        /// <param name="imageList">The image list</param>
        public static void CreateListView(ref ListView listView, ref List<FileModel> fileList, ImageList imageList)
        {
            if (!fileList.Any())
                return;

            var deleteList = new List<FileModel>();
            var count = imageList.Images.Count;

            listView.Items.Clear();

            foreach (var file in fileList)
            {
                var addEntry = true;
                var error = false;

                if (!File.Exists(file.Path))
                {
                    if (MessageBox.Show(
                        $"Der Pfad der Datei {file.Name} (Pfad: {file.Path}) konnte nicht gefunden werden. Soll der Eintrag entfernt werden?",
                        "Ordner", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        deleteList.Add(file);
                        addEntry = false;
                    }
                    error = true;
                    file.Error = true;
                }

                if (addEntry)
                {
                    listView.Items.Add(CreateListViewItem(GlobalEnums.RegionType.File, listView, file, error, imageList,
                        count));
                    count++;
                }
            }

            foreach (var entry in deleteList)
            {
                fileList.Remove(entry);
                DataManager.DeleteFile(entry);
            }
        }
        /// <summary>
        /// Creates a new list view entry
        /// </summary>
        /// <param name="region">The region</param>
        /// <param name="listView">The list view</param>
        /// <param name="entry">The current entry</param>
        /// <param name="error">true if the entry has an error, otherwise false</param>
        /// <param name="imgList">The image list</param>
        /// <param name="count">The current count</param>
        /// <returns>The new list view item</returns>
        private static ListViewItem CreateListViewItem(GlobalEnums.RegionType region, ListView listView, dynamic entry,
            bool error, ImageList imgList, int count)
        {
            var name = entry.Name;
            if (region == GlobalEnums.RegionType.App && entry.Autostart)
                name += "*";
                
            var item = new ListViewItem(name) {Tag = entry};
            item.SubItems.Add(string.IsNullOrEmpty(entry.Shortcut) ? "" : $"STRG + {entry.Shortcut}");
            if (region == GlobalEnums.RegionType.App)
                item.SubItems.Add(entry.Version);
            item.SubItems.Add(entry.Comment);
            item.SubItems.Add(entry.Path);
            if (region == GlobalEnums.RegionType.App)
            {
                item.SubItems.Add(entry.ExecuteIn);
                item.SubItems.Add(entry.Parameter);
            }
            item.SubItems.Add(entry.ShowInContextMenu ? "Ja" : "Nein");
            if (region == GlobalEnums.RegionType.App)
                item.SubItems.Add(entry.Autostart ? "Ja" : "Nein");

            if (error)
            {
                imgList.Images.Add(Properties.Resources.error);
                item.ImageIndex = count;
                item.ForeColor = Color.Red;
            }
            else
            {
                if (region == GlobalEnums.RegionType.App)
                {
                    imgList.Images.Add(string.IsNullOrEmpty(entry.IconPath)
                        ? Functions.ExtractIcon(entry.Path)
                        : Image.FromFile(entry.IconPath));
                }
                else if (region == GlobalEnums.RegionType.Folder)
                {
                    imgList.Images.Add(string.IsNullOrEmpty(entry.IconPath)
                        ? Properties.Resources.Folder
                        : Image.FromFile(entry.IconPath));
                }
                else if (region == GlobalEnums.RegionType.File)
                {
                    imgList.Images.Add(Functions.GetFileIcon(entry.Path));
                }
                item.ImageIndex = count;
                entry.ImageIndex = count;
            }

            item.ToolTipText = entry.Name;
            if (!string.IsNullOrEmpty(entry.Comment))
                item.ToolTipText += $"\r\nBeschreibung: {entry.Comment}";
            if (!string.IsNullOrEmpty(entry.Shortcut))
                item.ToolTipText += $"\r\nShortcut: {entry.Shortcut}";

            // Get the group
            foreach (var group in listView.Groups.OfType<ListViewGroup>())
            {
                var groupEntry = group.Tag as GroupModel;
                if (groupEntry != null)
                {
                    if (groupEntry.Id == entry.GroupId)
                        item.Group = group;
                }
            }

            return item;
        }

        /// <summary>
        /// Creates the context menu for the notify icon
        /// </summary>
        /// <param name="contextMenu">The context menu</param>
        /// <param name="appList">The app list</param>
        /// <param name="folderList">The folder list</param>
        /// <param name="groupList">The group list</param>
        /// <param name="imgList">The image list</param>
        /// <param name="fileList">The file list</param>
        /// <param name="icon">The icon</param>
        public static void CreateNotifyIcon(ref ContextMenuStrip contextMenu, List<AppModel> appList,
            List<FolderModel> folderList, List<FileModel> fileList, List<GroupModel> groupList, ImageList imgList, Icon icon)
        {
            contextMenu.Items.Clear();

            var headerItem = new ToolStripMenuItem("AppzManager V4")
            {
                Name = "HeaderItem",
                ToolTipText = "AppzManager",
                Image = icon.ToBitmap()
            };

            contextMenu.Items.Add(headerItem);

            foreach (var group in groupList)
            {
                var tmpAppList = appList.Where(w => w.GroupId == group.Id && w.ShowInContextMenu && !w.Error).ToList();
                if (tmpAppList.Any())
                {
                    if (contextMenu.Items.Count > 0)
                        contextMenu.Items.Add(new ToolStripSeparator());

                    contextMenu.Items.AddRange(CreateItems(GlobalEnums.RegionType.App, tmpAppList, imgList));
                }

                var tmpFolderList =
                    folderList.Where(w => w.GroupId == group.Id && w.ShowInContextMenu && !w.Error).ToList();
                if (tmpFolderList.Any())
                {
                    if (contextMenu.Items.Count > 0)
                        contextMenu.Items.Add(new ToolStripSeparator());

                    contextMenu.Items.AddRange(CreateItems(GlobalEnums.RegionType.Folder, tmpFolderList, imgList));
                }

                var tmpFileList = fileList.Where(w => w.GroupId == group.Id && w.ShowInContextMenu && !w.Error).ToList();
                if (tmpFileList.Any())
                {
                    if (contextMenu.Items.Count > 0)
                        contextMenu.Items.Add(new ToolStripSeparator());

                    contextMenu.Items.AddRange(CreateItems(GlobalEnums.RegionType.File, tmpFileList, imgList));
                }
            }

            contextMenu.Items.AddRange(CreateMainMenuItems());
        }
        /// <summary>
        /// Creates new items for the context menu
        /// </summary>
        /// <param name="region">The region</param>
        /// <param name="entryList">The entry list</param>
        /// <param name="imgList">The image list</param>
        /// <returns>An array with the items</returns>
        private static ToolStripItem[] CreateItems(GlobalEnums.RegionType region, object entryList, ImageList imgList)
        {
            if (region == GlobalEnums.RegionType.App)
            {
                var tmpList = entryList as List<AppModel>;
                if (tmpList == null)
                    return null;

                var result = new ToolStripItem[tmpList.Count];

                var count = 0;

                foreach (var entry in tmpList)
                {
                    var menuItem = new ToolStripMenuItem(entry.Autostart
                        ? $"{entry.Name}*"
                        : entry.Name)
                    {
                        Tag = entry,
                        Image = imgList.Images[entry.ImageIndex],
                        ToolTipText =
                            string.IsNullOrEmpty(entry.Comment) ? entry.Name : $"{entry.Name} - {entry.Comment}",
                        BackColor = entry.ColorCode.ToColor(),
                        ForeColor = Functions.GetContrastColor(entry.ColorCode.ToColor())
                    };


                    result[count++] = menuItem;
                }

                return result;
            }

            if (region == GlobalEnums.RegionType.Folder)
            {
                var tmpList = entryList as List<FolderModel>;
                if (tmpList == null)
                    return null;

                var result = new ToolStripItem[tmpList.Count];

                var count = 0;

                foreach (var entry in tmpList)
                {
                    var menuItem = new ToolStripMenuItem(entry.Name)
                    {
                        Tag = entry,
                        Image = imgList.Images[entry.ImageIndex],
                        ToolTipText =
                            string.IsNullOrEmpty(entry.Comment) ? entry.Name : $"{entry.Name} - {entry.Comment}",
                        BackColor = entry.ColorCode.ToColor(),
                        ForeColor = Functions.GetContrastColor(entry.ColorCode.ToColor())
                    };

                    result[count++] = menuItem;
                }

                return result;
            }

            if (region == GlobalEnums.RegionType.File)
            {
                var tmpList = entryList as List<FileModel>;
                if (tmpList != null)
                    return null;

                var result = new ToolStripItem[tmpList.Count];

                var count = 0;

                foreach (var entry in tmpList)
                {
                    var menuItem = new ToolStripMenuItem(entry.Name)
                    {
                        Tag = entry,
                        Image = imgList.Images[entry.ImageIndex],
                        ToolTipText =
                            string.IsNullOrEmpty(entry.Comment) ? entry.Name : $"{entry.Name} - {entry.Comment}",
                        BackColor = entry.ColorCode.ToColor(),
                        ForeColor = Functions.GetContrastColor(entry.ColorCode.ToColor())
                    };

                    result[count++] = menuItem;
                }

                return result;
            }

            return null;
        }
        /// <summary>
        /// Creates the "main" menu for the context menu
        /// </summary>
        /// <returns>An array with the items</returns>
        private static ToolStripItem[] CreateMainMenuItems()
        {
            var result = new ToolStripItem[3];

            var newItem = new ToolStripMenuItem("Neuer Eintrag")
            {
                Tag = null,
                Image = Properties.Resources.Plus,
                ToolTipText = "Neuer Eintrag",
                Name = "NewItem"
            };

            var newApp = new ToolStripMenuItem("Anwendung")
            {
                Tag = null,
                Image = Properties.Resources.Plus,
                ToolTipText = "Neuer Eintrag - Anwendung",
                Name = "NewAppItem"
            };

            var newFolder = new ToolStripMenuItem("Ordner")
            {
                Tag = null,
                Image = Properties.Resources.Plus,
                ToolTipText = "Neuer Eintrag - Ordner",
                Name = "NewFolderItem"
            };

            var newFile = new ToolStripMenuItem("Datei")
            {
                Tag = null,
                Image = Properties.Resources.Plus,
                ToolTipText = "Neuer Eintrag - Datei",
                Name = "NewFileItem"
            };

            var closeItem = new ToolStripMenuItem("Beenden")
            {
                Tag = null,
                Image = Properties.Resources.Close,
                ToolTipText = "Beendet das Programm",
                Name = "CloseItem"
            };

            newItem.DropDownItems.AddRange(new ToolStripItem[] { newApp, newFolder, newFile });

            result[0] = new ToolStripSeparator();
            result[1] = newItem;
            result[2] = closeItem;

            return result;
        }

        /// <summary>
        /// Creates a new entry
        /// </summary>
        /// <param name="region">The region</param>
        /// <param name="entryList">The entry list</param>
        /// <param name="filepathList">The filepath list</param>
        public static void CreateNewEntry(GlobalEnums.RegionType region, object entryList,
            List<string> filepathList = null)
        {
            var addForm = new FormAdd(region, entryList);
            if (filepathList == null)
                addForm.ShowDialog();
            else
            {
                filepathList.ForEach(entry =>
                {
                    addForm.Path = entry;
                    addForm.ShowDialog();
                });
            }
        }

        /// <summary>
        /// Edits an existing entry
        /// </summary>
        /// <param name="region">The region</param>
        /// <param name="entryList">The entry list</param>
        /// <param name="entry">The entry</param>
        /// <returns>true if successful, otherwise false</returns>
        public static bool EditEntry(GlobalEnums.RegionType region, object entryList, object entry)
        {
            if (entry == null)
                return false;

            var addForm = new FormAdd(region, entryList, entry);
            return addForm.ShowDialog() != DialogResult.Cancel;
        }
    }
}
