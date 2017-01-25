using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AppzManagerV4.DataObjects;
using AppzManagerV4.Global;

namespace AppzManagerV4.Forms
{
    public partial class FormImport : Form
    {
        /// <summary>
        /// Creates a new instance of the form
        /// </summary>
        public FormImport()
        {
            InitializeComponent();
            txtInfo.BackColor = Color.White;
            txtInfo.ForeColor = Color.Black;
        }

        /// <summary>
        /// Sets the checkstate for all items in the list
        /// </summary>
        /// <param name="check">true if all items should be checked, otherwise false</param>
        private void SetCheckState(bool check)
        {
            for (var i = 0; i < checkedListFiles.Items.Count; i++)
            {
                checkedListFiles.SetItemChecked(i, check);
            }
        }
        /// <summary>
        /// Loads all files in the given folder
        /// </summary>
        private void LoadFiles()
        {
            var files = Functions.LoadFiles(txtFolder.Text, "*.json");

            checkedListFiles.DataSource = null;
            checkedListFiles.DataSource = files.Where(w => !w.FileInfo.Name.Contains("Group")).ToList();
        }
        /// <summary>
        /// Imports the given files
        /// </summary>
        private void Import()
        {
            var files = new List<FileInfoModel>();
            foreach (var checkedItem in checkedListFiles.CheckedItems)
            {
                files.Add(checkedItem as FileInfoModel);
            }

            var dataImport = new DataImport();
            dataImport.ImportStepEvent += DataImport_ImportStepEvent;
            dataImport.ImportData(files, radioAddNew.Checked);
        }
        /// <summary>
        /// Occurs when the data importer fires a import message
        /// </summary>
        /// <param name="max">The max steps</param>
        /// <param name="step">The current step</param>
        /// <param name="msg">The message</param>
        private void DataImport_ImportStepEvent(int max, int step, string msg)
        {
            WriteMessage(max == 0 ? msg : $"[{step}/{max}] - {msg}");
        }

        /// <summary>
        /// Writes a message into the info box
        /// </summary>
        /// <param name="msg">The message</param>
        private void WriteMessage(string msg)
        {
            txtInfo.AppendText($"{DateTime.Now:G}: {msg}\r\n");
            txtInfo.ScrollToCaret();
        }
        /// <summary>
        /// Occurs when the user hits the browse button
        /// </summary>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog
            {
                Description = "Wähle den Ordner, welcher die Dateien enthält",
                ShowNewFolderButton = false
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtFolder.Text = dialog.SelectedPath;
            }
        }
        /// <summary>
        /// Occurs when the user hits the load button
        /// </summary>
        private void btnLoadFiles_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFolder.Text))
                LoadFiles();
        }
        /// <summary>
        /// Occurs when the user hits one of the check buttons
        /// </summary>
        private void CheckButton_Click(object sender, EventArgs e)
        {
            SetCheckState(sender == btnCheckAll);
        }
        /// <summary>
        /// Occurs when the user hits the import button
        /// </summary>
        private void btnImport_Click(object sender, EventArgs e)
        {
            txtInfo.Clear();
            Import();
        }
    }
}
