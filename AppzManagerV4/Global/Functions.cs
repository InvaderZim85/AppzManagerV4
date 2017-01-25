using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using AppzManagerV4.Business;
using AppzManagerV4.DataObjects;
using AppzManagerV4.Properties;
using IWshRuntimeLibrary;
using TAFactory.IconPack;
using File = System.IO.File;

namespace AppzManagerV4.Global
{
    public static class Functions
    {
        /// <summary>
        /// Extracts an icon
        /// </summary>
        /// <param name="filepath">The path of the application</param>
        /// <returns>The extracted icon. If no icon is available a default icon is returned</returns>
        public static Image ExtractIcon(string filepath)
        {
            if (!File.Exists(filepath))
                return Resources.NoIcon;

            var iconList = IconHelper.ExtractAllIcons(filepath);

            return iconList == null || !iconList.Any() ? Resources.NoIcon : iconList[0].ToBitmap();
        }
        /// <summary>
        /// Extracts the version of an application
        /// </summary>
        /// <param name="filepath">The path of the application</param>
        /// <returns>The version</returns>
        public static string ExtractVersionInfo(string filepath)
        {
            return FileVersionInfo.GetVersionInfo(filepath).FileVersion;
        }
        /// <summary>
        /// Copies an icon into the icon folder
        /// </summary>
        /// <param name="filepath">The path of the icon</param>
        /// <returns>The new path</returns>
        public static string CopyIconFile(string filepath)
        {
            if (!File.Exists(filepath))
                return string.Empty;

            var fileInfo = new FileInfo(filepath);

            var destfolder = Path.Combine(Settings.Default.BaseFolder, "Icons");
            if (!Directory.Exists(destfolder))
                Directory.CreateDirectory(destfolder);

            var destFile = Path.Combine(destfolder, fileInfo.Name);

            if (!File.Exists(destFile))
                File.Copy(filepath, destFile, true);

            return File.Exists(destFile) ? destFile : string.Empty;
        }
        /// <summary>
        /// Checks if an folder exists
        /// </summary>
        /// <param name="path">The path of the folder</param>
        /// <returns>true if the folder exists, otherwise false</returns>
        public static bool IsFolder(string path)
        {
            try
            {
                return Directory.Exists(path);
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// Checks if the path is an application
        /// </summary>
        /// <param name="path">The path of the entry</param>
        /// <returns>true if the path is an application, otherwise false</returns>
        public static bool IsApplication(string path)
        {
            var extension = GetFileExtension(path);

            return extension.Contains("exe") || extension.Contains("lnk");
        }
        /// <summary>
        /// Opens or executes an application / folder
        /// </summary>
        /// <param name="path">The path</param>
        /// <param name="execute">true if the application should execute</param>
        /// <param name="arguments">The arguments</param>
        /// <param name="executeIn">The path of the execute in value</param>
        /// <returns>true if successful, otherwise false</returns>
        private static bool OpenExecute(string path, bool execute = false, string arguments = "", string executeIn = "")
        {
            try
            {
                if (string.IsNullOrEmpty(path))
                    return false;

                var startInfo = new ProcessStartInfo();

                if (IsFolder(path))
                {
                    startInfo.FileName = "explorer.exe";
                    startInfo.Arguments = path;
                }
                else if (IsApplication(path))
                {
                    if (execute)
                    {
                        startInfo.FileName = path;
                        if (!string.IsNullOrEmpty(arguments))
                            startInfo.Arguments = arguments;

                        if (!string.IsNullOrEmpty(executeIn))
                            startInfo.WorkingDirectory = executeIn;
                    }
                    else
                    {
                        // Selects the given path
                        startInfo.FileName = "explorer.exe";
                        startInfo.Arguments = $"/select,{path}";
                    }
                }
                else
                {
                    startInfo.FileName = path;
                }

                Process.Start(startInfo);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// Gets the contrast color of a color
        /// </summary>
        /// <param name="color">The color</param>
        /// <returns>The contrast value</returns>
        public static Color GetContrastColor(Color color)
        {
            var a = 1 - (0.299 * color.R + 0.587 * color.G + 0.114 * color.B) / 255;

            var d = a < 0.5 ? 0 : 255;

            return Color.FromArgb(d, d, d);
        }
        /// <summary>
        /// Open or executes an app
        /// </summary>
        /// <param name="app">The app</param>
        /// <param name="execute">true for execute, otherwise false (optional, default = true)</param>
        /// <returns>true if successful, otherwise false</returns>
        public static bool OpenExecute(AppModel app, bool execute = true)
        {
            return app != null && OpenExecute(app.Path, execute, app.Parameter, app.ExecuteIn);
        }
        /// <summary>
        /// Opens a folder
        /// </summary>
        /// <param name="folder">The folder</param>
        /// <returns>true if successful, otherwise false</returns>
        public static bool OpenExecute(FolderModel folder)
        {
            return folder != null && OpenExecute(folder.Path);
        }
        /// <summary>
        /// Opens a file
        /// </summary>
        /// <param name="file">The file</param>
        /// <param name="execute">True if the file should be executed, otherwise false (optional, default = false)</param>
        /// <returns>true if successful, otherwise false</returns>
        public static bool OpenExecute(FileModel file, bool execute = false)
        {
            return file != null && OpenExecute(file.Path, execute);
        }
        /// <summary>
        /// Gets the extension of a file
        /// </summary>
        /// <param name="filepath">The path of the file</param>
        /// <returns>The extension</returns>
        public static string GetFileExtension(string filepath)
        {
            if (string.IsNullOrEmpty(filepath) || !File.Exists(filepath))
                return "";

            return new FileInfo(filepath).Extension.Replace(".", "").ToLower();
        }
        /// <summary>
        /// Gets the path of a lnk file
        /// </summary>
        /// <param name="lnkFile">The path of the lnk file</param>
        /// <returns>The original path</returns>
        public static string GetPathOfLnk(string lnkFile)
        {
            if (!File.Exists(lnkFile))
                return "";

            var shell = new WshShell();
            var link = (IWshShortcut)shell.CreateShortcut(lnkFile);

            return File.Exists(link.TargetPath) ? link.TargetPath : "";
        }
        /// <summary>
        /// Calculates the pressed key and returns the according event
        /// </summary>
        /// <param name="e">The key down event</param>
        /// <param name="region">The region</param>
        /// <param name="selectedEntry">The selected entry</param>
        /// <param name="entryList">The entry list</param>
        /// <returns>The key down event</returns>
        public static GlobalEnums.KeyDownEvent MainKeyDown(KeyEventArgs e, GlobalEnums.RegionType region,
            object selectedEntry, object entryList)
        {
            if (!e.Control)
                return GlobalEnums.KeyDownEvent.None;

            if (entryList == null)
                return GlobalEnums.KeyDownEvent.None;

            var result = GlobalEnums.KeyDownEvent.None;

            var app = selectedEntry as AppModel;
            var folder = selectedEntry as FolderModel;

            var appList = entryList as List<AppModel>;
            var folderList = entryList as List<FolderModel>;
            var execute = false;

            switch (e.KeyCode)
            {
                case Keys.Add:
                    FormManager.CreateNewEntry(region, entryList);
                    result = region == GlobalEnums.RegionType.App
                        ? GlobalEnums.KeyDownEvent.NewApp
                        : GlobalEnums.KeyDownEvent.NewFolder;
                    break;
                case Keys.Enter:
                    execute = true;
                    break;
                default:
                    execute = true;
                    if (region == GlobalEnums.RegionType.App && appList != null)
                    {
                        app = appList.FirstOrDefault(f => f.Shortcut == e.KeyCode.ToString());
                    }
                    else if (region == GlobalEnums.RegionType.Folder && folderList != null)
                    {
                        folder = folderList.FirstOrDefault(f => f.Shortcut == e.KeyCode.ToString());
                    }
                    break;
            }

            if (region == GlobalEnums.RegionType.App && execute && app != null)
            {
                OpenExecute(app.Path, true, app.Parameter, app.ExecuteIn);
            }
            else if (region == GlobalEnums.RegionType.Folder && execute && folder != null)
            {
                OpenExecute(folder.Path);
            }

            return result;
        }

        /// <summary>
        /// Creates a new folder
        /// </summary>
        /// <param name="path">The path of the folder</param>
        /// <returns>true if successful, otherwise false</returns>
        public static bool CreateFolder(string path)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException(nameof(path), "Der angegebene Pfad ist leer.");

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            return Directory.Exists(path);
        }
        /// <summary>
        /// Converts a color into its RGB value.
        /// Format: R,G,B
        /// </summary>
        /// <param name="color">The color</param>
        /// <returns>The rgb formated string</returns>
        public static string ToRgbString(this Color color)
        {
            return $"{color.R},{color.G},{color.B}";
        }
        /// <summary>
        /// Converts a string into a color
        /// </summary>
        /// <param name="value">The string value (Format: R,G,B)</param>
        /// <returns>The color</returns>
        public static Color ToColor(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return Color.Black;

            var splitted = value.Split(new[] {","}, StringSplitOptions.None);
            if (splitted.Length == 3)
                return Color.FromArgb(splitted[0].ToInt(), splitted[1].ToInt(), splitted[2].ToInt());

            return Color.Black;
        }
        /// <summary>
        /// Converts a string into a color
        /// </summary>
        /// <param name="value">The string value (Format: "R,G,B")</param>
        /// <returns>The color</returns>
        public static Color StringToColor(string value)
        {
            return value.ToColor();
        }
        /// <summary>
        /// Converts a string into a int value
        /// </summary>
        /// <param name="value">The string value</param>
        /// <returns>The int value</returns>
        public static int ToInt(this string value)
        {
            int tmp;
            return int.TryParse(value, out tmp) ? tmp : 0;
        }
        /// <summary>
        /// Gets the path of the base folder
        /// </summary>
        /// <returns>The path of the base folder</returns>
        public static string GetBaseFolder()
        {
            return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }

        /// <summary>
        /// Loads all files of a folder
        /// </summary>
        /// <param name="folder">The path of the folder</param>
        /// <param name="searchPattern">The search pattern</param>
        /// <param name="includeSubDirs">true if subdirectorys should be included (optional, default = false)</param>
        /// <returns>The list of files</returns>
        public static List<FileInfoModel> LoadFiles(string folder, string searchPattern, bool includeSubDirs = false)
        {
            if (string.IsNullOrEmpty(folder))
                return null;

            var files = new DirectoryInfo(folder).GetFiles(searchPattern);

            return files.Select(s => new FileInfoModel(s)).ToList();
        }
        /// <summary>
        /// Gets the icon according to the file extension
        /// </summary>
        /// <param name="filePath">The path of the file</param>
        /// <returns>The icon</returns>
        public static Bitmap GetFileIcon(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
                return Resources.File_Default;

            var extension = GetFileExtension(filePath);

            var audioList = new[] { "mp3", "ogg", "wav" };
            var videoList = new[] { "avi", "mpeg", "mkv", "mp4" };
            var imageList = new[] { "png", "jpg", "jpeg", "bmp", "tiff", "dds" };
            var archivList = new[] { "zip", "rar", "tar.gz", "7z" };
            var textList = new[] { "txt", "cs", "doc", "docx", "xls", "xlsx", "ods", "odt", "sql", "csv" };

            if (audioList.Contains(extension))
                return Resources.File_Audio;
            if (videoList.Contains(extension))
                return Resources.File_Video;
            if (imageList.Contains(extension))
                return Resources.File_Image;
            if (archivList.Contains(extension))
                return Resources.File_Archive;
            if (textList.Contains(extension))
                return Resources.File_Document;
            if (extension.Equals("dll"))
                return Resources.File_Dll;

            return Resources.File_Default;
        }
    }
}
