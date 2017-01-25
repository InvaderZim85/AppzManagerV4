using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using AppzManagerV4.Business;
using AppzManagerV4.DataObjects;
using Newtonsoft.Json;

namespace AppzManagerV4.Global
{
    public class DataImport
    {
        /// <summary>
        /// Contains the data manager
        /// </summary>
        private DataManager _dataManager = new DataManager();

        /// <summary>
        /// Occurs when the importer steps
        /// </summary>
        [Browsable(true), Description("Occurs when the importer moves a step forward...")]
        public event CustomDelegates.ImportStep ImportStepEvent;
        /// <summary>
        /// Raises the import step event
        /// </summary>
        /// <param name="max">The max steps</param>
        /// <param name="step">The current step</param>
        /// <param name="msg">The message</param>
        private void ImportStepNotifier(int max, int step, string msg)
        {
            ImportStepEvent?.Invoke(max, step, msg);
        }

        /// <summary>
        /// Imports the given files
        /// </summary>
        /// <param name="fileList">The file list</param>
        /// <param name="onlyAddNew">true if only new entries should be add, false = duplicated entries will be overwritten (optional, default = true)</param>
        public void ImportData(List<FileInfoModel> fileList, bool onlyAddNew = true)
        {
            if (fileList == null)
                return;

            foreach (var file in fileList)
            {
                if (file.FileInfo.Name.Contains("App"))
                    ImportAppData(file.FileInfo, onlyAddNew);
                else if (file.FileInfo.Name.Contains("Folder"))
                    ImportFolderData(file.FileInfo, onlyAddNew);
            }
        }
        /// <summary>
        /// Imports the app data
        /// </summary>
        /// <param name="file">The file</param>
        /// <param name="onlyAddNew">true if only new entries should be add, false = duplicated entries will be overwritten</param>
        private void ImportAppData(FileInfo file, bool onlyAddNew)
        {
            ImportStepNotifier(0, 0, "Importiere Anwendungsdaten");
            var data = GetFileData<List<ImportAppModel>>(file.FullName);

            var importGroupId = GetImportGroupId();

            data.ForEach(entry => entry.GroupId = importGroupId);

            ImportStepNotifier(0, 0, $"{data.Count} Einträge extrahiert.");

            var apps = _dataManager.GetApps();
            var count = 1;
            foreach (var app in data)
            {
                var entry = apps.FirstOrDefault(f => f.Path == app.Path);
                if (entry == null)
                {
                    // Entry doesn' exist, so add it
                    ImportStepNotifier(data.Count, count++,
                        _dataManager.SaveApp(MapAppData(app))
                            ? $"Eintrag \"{app.Name}\" neu angelegt."
                            : $"Eintrag \"{app.Name}\" konnte nicht angelegt werden.");
                }
                else
                {
                    if (!onlyAddNew)
                    {
                        ImportStepNotifier(data.Count, count++, 
                            _dataManager.SaveApp(UpdateExistingEntry(entry, app))
                            ? $"Eintrag \"{app.Name}\" aktualisiert."
                            : $"Eintrag \"{app.Name}\" konnte nicht aktualisiert werden.");
                    }
                }
            }
        }
        /// <summary>
        /// Imports the folder data
        /// </summary>
        /// <param name="file">The file</param>
        /// <param name="onlyAddNew">true if only new entries should be add, false = duplicated entries will be overwritten</param>
        private void ImportFolderData(FileInfo file, bool onlyAddNew)
        {
            ImportStepNotifier(0, 0, "Importiere Ordnerdaten");
            var data = GetFileData<List<ImportFolderModel>>(file.FullName);

            var importGroupId = GetImportGroupId();

            data.ForEach(entry => entry.GroupId = importGroupId);

            ImportStepNotifier(0, 0, $"{data.Count} Einträge extrahiert.");

            var folders = _dataManager.GetFolder();
            var count = 1;
            foreach (var folder in data)
            {
                var entry = folders.FirstOrDefault(f => f.Path == folder.Path);
                if (entry == null)
                {
                    // Entry doesn' exist, so add it
                    ImportStepNotifier(data.Count, count++,
                        _dataManager.SaveFolder(MapFolderData(folder))
                            ? $"Eintrag \"{folder.Name}\" neu angelegt."
                            : $"Eintrag \"{folder.Name}\" konnte nicht angelegt werden.");
                }
                else
                {
                    if (!onlyAddNew)
                    {
                        ImportStepNotifier(data.Count, count++,
                            _dataManager.SaveFolder(UpdateExistingEntry(entry, folder))
                            ? $"Eintrag \"{folder.Name}\" aktualisiert."
                            : $"Eintrag \"{folder.Name}\" konnte nicht aktualisiert werden.");
                    }
                }
            }
        }
        /// <summary>
        /// Extracts the data of a json file
        /// </summary>
        /// <typeparam name="T">The type of the json data</typeparam>
        /// <param name="filepath">The filepath</param>
        /// <returns>The deserialized data</returns>
        private T GetFileData<T>(string filepath)
        {
            if (string.IsNullOrEmpty(filepath))
                return default(T);

            var jsonString = File.ReadAllText(filepath);

            return JsonConvert.DeserializeObject<T>(jsonString);
        }
        /// <summary>
        /// Gets the id of the import group
        /// </summary>
        /// <returns>The id of the import group</returns>
        private int GetImportGroupId()
        {
            var groups = _dataManager.GetGroups();

            if (!groups.Any(a => a.Name.Equals("Import")))
                _dataManager.SaveGroup(new GroupModel {Name = "Import"});

            groups = _dataManager.GetGroups();

            return groups.FirstOrDefault(f => f.Name.Equals("Import"))?.Id ?? 0;
        }
        /// <summary>
        /// Maps the import model to the app model
        /// </summary>
        /// <param name="importApp">The import model</param>
        /// <returns>The app model</returns>
        private AppModel MapAppData(ImportAppModel importApp)
        {
            return new AppModel
            {
                Name = importApp.Name,
                Path = importApp.Path,
                IconPath = "",
                Comment = importApp.Comment,
                Shortcut = importApp.Shortcut,
                GroupId = importApp.GroupId,
                Error = importApp.Error,
                ShowInContextMenu = importApp.ShowInContextMenu,
                ImageIndex = importApp.ImageIndex,
                ColorCode = importApp.ContextColor.ToRgbString(),
                ExecuteIn = importApp.ExecuteIn,
                Version = importApp.Version,
                Parameter = importApp.Parameter,
                Autostart = importApp.Autostart
            };
        }
        /// <summary>
        /// Updates an existing entry
        /// </summary>
        /// <param name="entry">The existing entry</param>
        /// <param name="importModel">The imported entry</param>
        /// <returns>The updated entry</returns>
        private AppModel UpdateExistingEntry(AppModel entry, ImportAppModel importModel)
        {
            entry.Name = importModel.Name;
            entry.Path = importModel.Path;
            entry.Comment = importModel.Comment;
            entry.Shortcut = importModel.Shortcut;
            entry.Error = importModel.Error;
            entry.ShowInContextMenu = importModel.ShowInContextMenu;
            entry.ColorCode = importModel.ContextColor.ToRgbString();
            entry.ExecuteIn = importModel.ExecuteIn;
            entry.Version = importModel.Version;
            entry.Parameter = importModel.Parameter;
            entry.Autostart = importModel.Autostart;

            return entry;
        }
        /// <summary>
        /// Maps the import model for the folder model
        /// </summary>
        /// <param name="importFolder">The import model</param>
        /// <returns>The folder model</returns>
        private FolderModel MapFolderData(ImportFolderModel importFolder)
        {
            return new FolderModel
            {
                Name = importFolder.Name,
                Path = importFolder.Path,
                IconPath = "",
                Comment = importFolder.Comment,
                Shortcut = importFolder.Shortcut,
                GroupId = importFolder.GroupId,
                Error = importFolder.Error,
                ShowInContextMenu = importFolder.ShowInContextMenu,
                ImageIndex = importFolder.ImageIndex,
                ColorCode = importFolder.ContextColor.ToRgbString(),
            };
        }
        /// <summary>
        /// Updates an existing entry
        /// </summary>
        /// <param name="entry">The existing entry</param>
        /// <param name="importModel">The imported entry</param>
        /// <returns>The updated entry</returns>
        private FolderModel UpdateExistingEntry(FolderModel entry, ImportFolderModel importModel)
        {
            entry.Name = importModel.Name;
            entry.Path = importModel.Path;
            entry.Comment = importModel.Comment;
            entry.Shortcut = importModel.Shortcut;
            entry.Error = importModel.Error;
            entry.ShowInContextMenu = importModel.ShowInContextMenu;
            entry.ColorCode = importModel.ContextColor.ToRgbString();

            return entry;
        }
    }
}
