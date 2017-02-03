using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppzManagerV4.DataObjects;
using AppzManagerV4.Global;

namespace AppzManagerV4.Forms.Controls
{
    public partial class InfoControl : UserControl
    {
        /// <summary>
        /// Creates a new instance of the control
        /// </summary>
        public InfoControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Shows the information of the given entry
        /// </summary>
        /// <param name="entry">The entry</param>
        /// <param name="region">The region</param>
        public void ShowInfo(object entry, GlobalEnums.RegionType region)
        {
            ClearFields();
            switch (region)
            {
                case GlobalEnums.RegionType.App:
                    var app = entry as AppModel;
                    if (app != null)
                    {
                        lblCommentData.Text = app.Comment;
                        lblShortcutData.Text = string.IsNullOrEmpty(app.Shortcut) ? "" : $"STRG + {app.Shortcut}";

                        ShowFileInfo(app.Path, app.Name);
                    }
                    break;
                case GlobalEnums.RegionType.File:
                    var file = entry as FileModel;
                    if (file != null)
                    {
                        lblCommentData.Text = file.Comment;
                        lblShortcutData.Text = string.IsNullOrEmpty(file.Shortcut) ? "" : $"STRG + {file.Shortcut}";

                        ShowFileInfo(file.Path, file.Name);
                    }
                    break;
                case GlobalEnums.RegionType.Folder:
                    var folder = entry as FolderModel;
                    if (folder != null)
                    {
                        lblCommentData.Text = folder.Comment;
                        lblShortcutData.Text = string.IsNullOrEmpty(folder.Shortcut) ? "" : $"STRG + {folder.Shortcut}";

                        ShowDirInfo(folder.Path, folder.Name);
                    }
                    break;
            }
        }

        /// <summary>
        /// Shows the file infos of a application / file
        /// </summary>
        /// <param name="path">The path of the application / file</param>
        /// <param name="name">The name of the entry</param>
        private void ShowFileInfo(string path, string name)
        {
            var fileInfo = new FileInfo(path);
            lblNameData.Text = string.IsNullOrEmpty(name) ? fileInfo.Name : $"{name} ({fileInfo.Name})";
            lblPathData.Text = fileInfo.FullName;
            lblAttributeData.Text = fileInfo.Attributes.ToString();
            lblCreationDateData.Text = $"{fileInfo.CreationTime:G}";
            lblChangeDateData.Text = $"{fileInfo.LastWriteTime:G}";
            lblSizeData.Text = Functions.GetFileSize(fileInfo);

        }

        /// <summary>
        /// Shows the dir infos of a folder
        /// </summary>
        /// <param name="path">The path of the folder</param>
        /// <param name="name">The name of the entry</param>
        private void ShowDirInfo(string path, string name)
        {
            var dirInfo = new DirectoryInfo(path);
            lblNameData.Text = string.IsNullOrEmpty(name) ? dirInfo.Name : $"{name} ({dirInfo.Name})";
            lblPathData.Text = dirInfo.FullName;
            lblAttributeData.Text = dirInfo.Attributes.ToString();
            lblCreationDateData.Text = $"{dirInfo.CreationTime:G}";
            lblChangeDateData.Text = $"{dirInfo.LastWriteTime:G}";

            lblSizeData.Text = "Berechne...";
            Task.Factory.StartNew(() =>
            {
                var calcTask = Task.Factory.StartNew(() => Functions.GetFolderSize(dirInfo));
                calcTask.Wait();

                return calcTask.Result;
            }).ContinueWith(t =>
            {
                if (t.Exception == null)
                {
                    lblSizeData.Text = t.Result;
                }
                else
                {
                    MessageBox.Show($"Beim Berechnen der Größe ist ein Fehler aufgetreten:\r\n{t.Exception.Message}",
                        "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblSizeData.Text = "Fehler.";
                }
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }
        /// <summary>
        /// Clears the fields
        /// </summary>
        private void ClearFields()
        {
            foreach (var label in tableLayoutPanel.Controls.OfType<Label>())
            {
                if (label.Name.Contains("Data"))
                    label.Text = "";
            }
        }
    }
}
