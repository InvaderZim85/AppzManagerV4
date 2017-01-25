using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AppzManagerV4.Business;
using AppzManagerV4.DataObjects;
using AppzManagerV4.Global;

namespace AppzManagerV4.Forms
{
    public partial class FormAdd : Form
    {
        /// <summary>
        /// Contains the data manager
        /// </summary>
        private readonly DataManager _manager = new DataManager();
        /// <summary>
        /// Contains the application / folder path
        /// </summary>
        private string _path;
        /// <summary>
        /// Contains the custom icon value
        /// </summary>
        private bool _customIcon;
        /// <summary>
        /// Contains the app list
        /// </summary>
        private List<AppModel> _appList;
        /// <summary>
        /// Contains the folder list
        /// </summary>
        private List<FolderModel> _folderList;
        /// <summary>
        /// Contains the file list
        /// </summary>
        private List<FileModel> _fileList;
        /// <summary>
        /// Contains the group list
        /// </summary>
        private List<GroupModel> _groupList;
        /// <summary>
        /// Contains the current app
        /// </summary>
        private AppModel _app;
        /// <summary>
        /// Contains the current folder
        /// </summary>
        private FolderModel _folder;
        /// <summary>
        /// Contains the current file
        /// </summary>
        private FileModel _file;
        /// <summary>
        /// Contains the current region
        /// </summary>
        private readonly GlobalEnums.RegionType _region;
        /// <summary>
        /// Contains the used shortcuts
        /// </summary>
        private readonly List<string> _usedShortcuts;

        /// <summary>
        /// Sets the path
        /// </summary>
        public string Path { set { _path = value; } }

        /// <summary>
        /// Creates a new instance of the form
        /// </summary>
        /// <param name="region">The region</param>
        /// <param name="entryList">The entry list</param>
        /// <param name="entry">The current entry (optional, default = null)</param>
        public FormAdd(GlobalEnums.RegionType region, object entryList, object entry = null)
        {
            InitializeComponent();

            _region = region;

            if (region == GlobalEnums.RegionType.App)
            {
                _app = entry as AppModel;
                _appList = entryList as List<AppModel>;
                if (_appList != null)
                    _usedShortcuts = _appList.Select(s => s.Shortcut).ToList();
            }
            else if (region == GlobalEnums.RegionType.Folder)
            {
                _folder = entry as FolderModel;
                _folderList = entryList as List<FolderModel>;
                if (_folderList != null)
                    _usedShortcuts = _folderList.Select(s => s.Shortcut).ToList();
            }
            else if (region == GlobalEnums.RegionType.File)
            {
                _file = entry as FileModel;
                _fileList = entryList as List<FileModel>;
                if (_fileList != null)
                    _usedShortcuts = _fileList.Select(s => s.Shortcut).ToList();
            }
        }
        /// <summary>
        /// Inits the form
        /// </summary>
        private void InitForm()
        {
            // Deactivate all textbox controls
            foreach (var ctrl in tableLayoutPanel.Controls.OfType<TextBox>())
            {
                ctrl.Enabled = false;
            }

            foreach (var ctrl in tableLayoutPanel.Controls.OfType<CheckBox>())
            {
                ctrl.Enabled = false;
            }

            foreach (var ctrl in tableLayoutPanel.Controls.OfType<ComboBox>())
            {
                ctrl.Enabled = false;
            }

            foreach (var ctrl in tableLayoutPanel.Controls.OfType<Button>())
            {
                ctrl.Enabled = false;
            }

            foreach (var panel in tableLayoutPanel.Controls.OfType<Panel>())
            {
                foreach (var ctrl in panel.Controls.OfType<TextBox>())
                {
                    ctrl.Enabled = false;
                }
            }

            var infoMsg = "";
            if (_region == GlobalEnums.RegionType.App || _region == GlobalEnums.RegionType.Folder ||
                _region == GlobalEnums.RegionType.File)
            {
                txtName.Enabled = true;
                txtPath.Enabled = true;
                btnBrowsePath.Enabled = true;
                txtShortcut.Enabled = true;
                txtComment.Enabled = true;
                comboGroup.Enabled = true;
                btnAddGroup.Enabled = true;
                btnColerChooser.Enabled = true;
                checkShowInContextMenu.Enabled = true;
            }

            switch (_region)
            {
                case GlobalEnums.RegionType.App:
                    txtExecuteIn.Enabled = true;
                    btnBrowseExecuteIn.Enabled = true;
                    txtParameter.Enabled = true;
                    txtVersion.Enabled = true;
                    checkAutostart.Enabled = true;

                    btnChangeIcon.Enabled = true;
                    btnDeleteIcon.Enabled = true;
                    break;
                case GlobalEnums.RegionType.Folder:
                    btnChangeIcon.Enabled = true;
                    btnDeleteIcon.Enabled = true;

                    infoMsg = "Für Ordner nicht verfügbar.";
                    break;
                case GlobalEnums.RegionType.File:

                    infoMsg = "Für Dateien nicht verfügbar.";
                    break;
            }

            foreach (var ctrl in tableLayoutPanel.Controls.OfType<TextBox>())
            {
                if (!ctrl.Enabled)
                    ctrl.Text = infoMsg;
            }

            if (!txtExecuteIn.Enabled)
                txtExecuteIn.Text = infoMsg;

            LoadGroups();
        }
        /// <summary>
        /// Loads the groups
        /// </summary>
        private void LoadGroups()
        {
            _groupList = _manager.GetGroups();
            comboGroup.DataSource = _groupList;
        }
        /// <summary>
        /// Sets the values of an app
        /// </summary>
        private void SetValuesApp()
        {
            if (_app != null)
            {
                SetGeneralValues(_app);
                txtExecuteIn.Text = _app.ExecuteIn;
                txtParameter.Text = _app.Parameter;
                txtVersion.Text = _app.Version;
                checkAutostart.Checked = _app.Autostart;

                if (string.IsNullOrEmpty(_app.IconPath))
                {
                    pictureBoxIcon.Image = Functions.ExtractIcon(_app.Path);
                }
                else
                {
                    pictureBoxIcon.ImageLocation = _app.IconPath;
                    _customIcon = true;
                }
            }
            else if (!string.IsNullOrEmpty(_path))
            {
                var fileInfo = new FileInfo(_path);
                txtName.Text = fileInfo.Name.Replace(fileInfo.Extension, "");
                txtExecuteIn.Text = fileInfo.DirectoryName;
                txtPath.Text = _path;
                pictureBoxIcon.Image = Functions.ExtractIcon(_path);
                txtVersion.Text = Functions.ExtractVersionInfo(_path);
            }
        }

        /// <summary>
        /// Sets the values of an app
        /// </summary>
        private void SetValuesFolder()
        {
            if (_folder != null)
            {
                SetGeneralValues(_folder);

                if (string.IsNullOrEmpty(_folder.IconPath))
                {
                    pictureBoxIcon.Image = Properties.Resources.Folder;
                }
                else
                {
                    pictureBoxIcon.ImageLocation = _folder.IconPath;
                    _customIcon = true;
                }
            }
            else if (!string.IsNullOrEmpty(_path))
            {
                var dirInfo = new DirectoryInfo(_path);
                txtName.Text = dirInfo.Name;
                txtPath.Text = dirInfo.FullName;
                pictureBoxIcon.Image = Properties.Resources.Folder;
            }
        }
        /// <summary>
        /// Sets the file values
        /// </summary>
        private void SetValuesFile()
        {
            if (_file != null)
            {
                SetGeneralValues(_file);
                pictureBoxIcon.Image = Functions.GetFileIcon(_file.Path);

            }
            else if (!string.IsNullOrEmpty(_path))
            {
                var fileInfo = new FileInfo(_path);
                txtName.Text = fileInfo.Name;
                txtExecuteIn.Text = fileInfo.DirectoryName;
                txtPath.Text = _path;
                pictureBoxIcon.Image = Functions.GetFileIcon(_path);
            }
            else
                pictureBoxIcon.Image = Properties.Resources.File_Default;
        }
        /// <summary>
        /// Sets the general values
        /// </summary>
        /// <param name="entry">The entry</param>
        private void SetGeneralValues(dynamic entry)
        {
            Text = "Eintrag bearbeiten";
            txtName.Text = entry.Name;
            txtPath.Text = entry.Path;
            txtShortcut.Text = entry.Shortcut;
            txtComment.Text = entry.Comment;
            checkShowInContextMenu.Checked = entry.ShowInContextMenu;

            comboGroup.SelectedItem = _groupList.FirstOrDefault(f => f.Id == entry.GroupId);
            lblColorData.BackColor = Functions.StringToColor(entry.ColorCode);
            lblColorData.ForeColor = Functions.GetContrastColor(lblColorData.BackColor);
        }
        /// <summary>
        /// Saves an app
        /// </summary>
        /// <param name="saveAndClose">true if the form should closes (optional, default = false)</param>
        private void SaveEntryApp(bool saveAndClose = false)
        {
            if (ValidInput())
            {
                var groupId = comboGroup.SelectedItem as GroupModel;
                var app = new AppModel
                {
                    Name = txtName.Text,
                    Path = txtPath.Text,
                    ExecuteIn = string.IsNullOrEmpty(txtExecuteIn.Text)
                        ? new FileInfo(txtPath.Text).DirectoryName
                        : txtExecuteIn.Text,
                    Parameter = txtParameter.Text,
                    Version = txtVersion.Text,
                    Shortcut = txtShortcut.Text,
                    Comment = txtComment.Text,
                    GroupId = groupId?.Id ?? 1,
                    IconPath = _customIcon ? Functions.CopyIconFile(pictureBoxIcon.ImageLocation) : string.Empty,
                    ShowInContextMenu = checkShowInContextMenu.Checked,
                    ColorCode = lblColorData.BackColor.ToRgbString(),
                    Autostart = checkAutostart.Checked
                };

                if (_app != null)
                    app.Id = _app.Id;

                _app = app;

                var result = ShowMessage(_manager.SaveApp(app));

                if (saveAndClose && result)
                    DialogResult = DialogResult.OK;
            }
        }
        /// <summary>
        /// Saves a folder
        /// </summary>
        /// <param name="saveAndClose">true if the form should closes (optional, default = false)</param>
        private void SaveEntryFolder(bool saveAndClose = false)
        {
            if (ValidInput())
            {
                var groupId = comboGroup.SelectedItem as GroupModel;
                var folder = new FolderModel
                {
                    Name = txtName.Text,
                    Path = txtPath.Text,
                    Shortcut = txtShortcut.Text,
                    Comment = txtComment.Text,
                    GroupId = groupId?.Id ?? 1,
                    IconPath = _customIcon ? Functions.CopyIconFile(pictureBoxIcon.ImageLocation) : string.Empty,
                    ShowInContextMenu = checkShowInContextMenu.Checked,
                    ColorCode = lblColorData.BackColor.ToRgbString()
                };

                if (_folder != null)
                    folder.Id = _folder.Id;

                _folder = folder;

                var result = ShowMessage(_manager.SaveFolder(folder));

                if (saveAndClose && result)
                    DialogResult = DialogResult.OK;
            }
        }
        /// <summary>
        /// Saves a file
        /// </summary>
        /// <param name="saveAndClose">true if the form should closes (optional, default = false)</param>
        private void SaveEntryFile(bool saveAndClose = false)
        {
            if (ValidInput())
            {
                var groupId = comboGroup.SelectedItem as GroupModel;
                var file = new FileModel
                {
                    Name = txtName.Text,
                    Path = txtPath.Text,
                    Shortcut = txtShortcut.Text,
                    Comment = txtComment.Text,
                    GroupId = groupId?.Id ?? 1,
                    ShowInContextMenu = checkShowInContextMenu.Checked,
                    ColorCode = lblColorData.BackColor.ToRgbString()
                };

                if (_file != null)
                    file.Id = _file.Id;

                _file = file;

                var result = ShowMessage(_manager.SaveFile(_file));

                if (saveAndClose && result)
                    DialogResult = DialogResult.OK;
            }
        }
        /// <summary>
        /// Shows a message
        /// </summary>
        /// <param name="returnType">The return region</param>
        /// <returns>true if successful, otherwise false</returns>
        private bool ShowMessage(bool returnType)
        {
            if (returnType)
            {
                MessageBox.Show("Eintrag erfolgreich gespeichert.", "Speichern",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            else
            {
                MessageBox.Show("Der Eintrag konnte nicht gespeichert werden.", "Fehler",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return returnType;
        }
        /// <summary>
        /// Checks if the input is valid
        /// </summary>
        /// <returns>true if valid, otherwise false</returns>
        private bool ValidInput()
        {
            errorProvider.Clear();
            if (string.IsNullOrEmpty(txtName.Text))
            {
                SetError(txtName, "Name fehlt.");
                return false;
            }

            if (string.IsNullOrEmpty(txtPath.Text))
            {
                SetError(txtPath, "Pfad fehlt.");
                return false;
            }

            var group = comboGroup.SelectedItem as GroupModel;
            if (group == null)
            {
                SetError(comboGroup, "Gruppe fehlt.");
                return false;
            }
            return true;
        }
        /// <summary>
        /// Shows an error
        /// </summary>
        /// <param name="ctrl">The control</param>
        /// <param name="message">The message</param>
        private void SetError(Control ctrl, string message)
        {
            errorProvider.SetError(ctrl, message);
            errorProvider.SetIconPadding(ctrl, -20);
        }
        /// <summary>
        /// Resets the form
        /// </summary>
        private void ClearForm()
        {
            txtName.Clear();
            txtPath.Clear();
            txtExecuteIn.Clear();
            txtParameter.Clear();
            txtVersion.Clear();
            txtShortcut.Clear();
            txtComment.Clear();
            comboGroup.SelectedIndex = -1;
            checkShowInContextMenu.Checked = true;
            pictureBoxIcon.Image = Properties.Resources.NoIcon;
            txtName.Focus();
            lblColorData.BackColor = SystemColors.Control;
            lblColorData.ForeColor = SystemColors.ControlText;
            _customIcon = false;
            checkAutostart.Checked = false;

            InitForm();
        }
        /// <summary>
        /// Occurs when the form is loading
        /// </summary>
        private void FormAdd_Load(object sender, EventArgs e)
        {
            InitForm();
            switch (_region)
            {
                case GlobalEnums.RegionType.App:
                    Text = "Neuer Eintrag - Anwendung";
                    pictureBoxIcon.Image = Properties.Resources.NoIcon;
                    SetValuesApp();
                    break;
                case GlobalEnums.RegionType.Folder:
                    Text = "Neuer Eintrag - Ordner";
                    pictureBoxIcon.Image = Properties.Resources.Folder;
                    SetValuesFolder();
                    break;
                case GlobalEnums.RegionType.File:
                    Text = "Neuer Eintrag - Datei";
                    pictureBoxIcon.Image = Properties.Resources.File_Default;
                    SetValuesFile();
                    break;
            }
        }
        /// <summary>
        /// Occurs when the user hits one of the browse buttons
        /// </summary>
        private void ButtonBrowseClick(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button == null)
                return;

            switch (button.Name)
            {
                case "btnBrowseExecuteIn":
                    var diagBrowse = new FolderBrowserDialog
                    {
                        Description = "Wählen Sie den Ordner, in welchem die Anwendung ausgeführt werden soll.",
                        ShowNewFolderButton = false
                    };

                    if (diagBrowse.ShowDialog() == DialogResult.OK)
                    {
                        txtExecuteIn.Text = diagBrowse.SelectedPath;
                    }
                    break;
                case "btnBrowsePath":
                    switch (_region)
                    {
                        case GlobalEnums.RegionType.App:
                        {
                            var diagFolder = new OpenFileDialog
                            {
                                Title = "Wählen Sie das gewünschte Programm aus.",
                                Filter = "Ausführbare Dateien (*.exe)|*.exe",
                                Multiselect = false
                            };

                            if (diagFolder.ShowDialog() != DialogResult.OK)
                                return;
                            _path = diagFolder.FileName;
                            SetValuesApp();
                        }
                            break;
                        case GlobalEnums.RegionType.Folder:
                        {
                            var diagFolder = new FolderBrowserDialog
                            {
                                Description = "Wählen Sie den gewünschten Ordner aus.",
                                ShowNewFolderButton = false
                            };

                            if (diagFolder.ShowDialog() == DialogResult.OK)
                            {
                                txtPath.Text = diagFolder.SelectedPath;
                                _path = diagFolder.SelectedPath;
                                SetValuesFolder();
                            }
                        }
                            break;
                        case GlobalEnums.RegionType.File:
                        {
                            var diagFolder = new OpenFileDialog
                            {
                                Title = "Wählen Sie die gewünschte Datei aus.",
                                Filter = "Datei (*.*)|*.*",
                                Multiselect = false
                            };

                            if (diagFolder.ShowDialog() != DialogResult.OK)
                                return;
                            _path = diagFolder.FileName;
                            SetValuesFile();
                        }
                            break;
                    }
                    break;
                case "btnChangeIcon":
                    var diagIcon = new OpenFileDialog
                    {
                        Title = "Wählen Sie das gewünschte Bild aus.",
                        Filter = "jpg (*.jpg)|*.jpg|png (*.png)|*.png|bmp (*.bmp)|*.bmp",
                        Multiselect = false
                    };

                    if (diagIcon.ShowDialog() != DialogResult.OK)
                        return;

                    _customIcon = true;
                    pictureBoxIcon.ImageLocation = diagIcon.FileName;
                    break;
                case "btnColerChooser":
                    var diagColor = new ColorDialog();
                    if (diagColor.ShowDialog() == DialogResult.OK)
                    {
                        lblColorData.BackColor = diagColor.Color;
                        lblColorData.ForeColor = Functions.GetContrastColor(lblColorData.BackColor);
                    }
                    break;
            }
        }
        /// <summary>
        /// Occurs when the user hits the save button
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (_region)
            {
                case GlobalEnums.RegionType.App:
                    SaveEntryApp();
                    break;
                case GlobalEnums.RegionType.Folder:
                    SaveEntryFolder();
                    break;
                case GlobalEnums.RegionType.File:
                    SaveEntryFile();
                    break;
            }
        }
        /// <summary>
        /// Occurs when the user hits the add group button
        /// </summary>
        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            var groupForm = new FormGroups();
            groupForm.ShowDialog();

            LoadGroups();
        }
        /// <summary>
        /// Occurs when the user enters a short cut
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtShortcut_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorProvider.Clear();
            if (_usedShortcuts.Contains(e.KeyChar.ToString().ToUpper()))
            {
                SetError(txtShortcut, "Shortcut bereits vergeben.");
                e.Handled = true;
            }
        }
        /// <summary>
        /// Occurs when the user hits the save and close button
        /// </summary>
        private void btnSaveClose_Click(object sender, EventArgs e)
        {
            switch (_region)
            {
                case GlobalEnums.RegionType.App:
                    SaveEntryApp(true);
                    break;
                case GlobalEnums.RegionType.Folder:
                    SaveEntryFolder(true);
                    break;
                case GlobalEnums.RegionType.File:
                    SaveEntryFile(true);
                    break;
            }
        }
        /// <summary>
        /// Occurs when the user hits the clear button
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        /// <summary>
        /// Occurs when the user hits the delete icon button
        /// </summary>
        private void btnDeleteIcon_Click(object sender, EventArgs e)
        {
            _customIcon = false;
            pictureBoxIcon.Image = string.IsNullOrEmpty(txtPath.Text)
                ? Properties.Resources.NoIcon
                : Functions.ExtractIcon(txtPath.Text);
        }
        /// <summary>
        /// Occurs when the enabled state of the text box was changed
        /// </summary>
        private void txtExecuteIn_EnabledChanged(object sender, EventArgs e)
        {
            btnBrowseExecuteIn.Enabled = txtExecuteIn.Enabled;
        }
    }
}
