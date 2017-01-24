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

namespace AppzManagerV4.Forms
{
    public partial class FormGroups : Form
    {
        /// <summary>
        /// Contains the data manager
        /// </summary>
        private readonly DataManager _manager = new DataManager();
        /// <summary>
        /// Contains the has changes value
        /// </summary>
        private bool _hasChanges;
        /// <summary>
        /// Contains the old value of the group
        /// </summary>
        private string _oldValue = "";
        /// <summary>
        /// Contains the group list
        /// </summary>
        private List<GroupModel> _groupList;

        /// <summary>
        /// Creates a new instance of the form
        /// </summary>
        public FormGroups()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the groups
        /// </summary>
        private void LoadGroups()
        {
            sourceGroups.DataSource = null;
            _groupList = _manager.GetGroups().OrderBy(o => o.Name).ToList();
            sourceGroups.DataSource = _groupList;
        }
        /// <summary>
        /// Fügt eine neue Gruppe hinzu
        /// </summary>
        private void AddGroup()
        {
            errorProvider.Clear();
            if (string.IsNullOrEmpty(txtGroup.Text))
            {
                SetError(txtGroup, "Name der Gruppe fehlt.");
                return;
            }

            if (!ValidGroup())
            {
                SetError(txtGroup, "Gruppe bereits vorhanden.");
                return;
            }

            var result = _manager.SaveGroup(new GroupModel {Name = txtGroup.Text});
            if (!result)
            {
                MessageBox.Show("Der Eintrag konnte nicht gespeichert werden.", "Fehler",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtGroup.Clear();
                LoadGroups();
            }
        }
        /// <summary>
        /// Checks if the given group is valid
        /// </summary>
        /// <returns>true if valie, otherwise false</returns>
        private bool ValidGroup()
        {
            return _groupList.Count(c => c.Name.Equals(txtGroup.Text)) == 0;
        }
        /// <summary>
        /// Löscht die gewählte Gruppe
        /// </summary>
        private void DeleteGroup()
        {
            var entry = sourceGroups.Current as GroupModel;
            if (entry != null && entry.Id > 0)
            {
                if (_manager.GroupInUse(entry.Id))
                {
                    MessageBox.Show("Der Eintrag kann nicht gelöscht werden, da dieser bereits verwendet wird.",
                        "Löschen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _manager.DeleteGroup(entry);
                LoadGroups();
            }
        }
        /// <summary>
        /// Speichert die komplette Liste
        /// </summary>
        private void SaveAll()
        {
            var groupList = sourceGroups.DataSource as List<GroupModel>;
            if (groupList != null)
            {
                if (_manager.SaveGroupList(groupList))
                    MessageBox.Show("Einträge gespeichert.", "Speichern",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Beim Speichern der Einträge ist ein Fehler aufgetreten.", "Speichern",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                _hasChanges = false;
                _oldValue = "";
            }
        }
        /// <summary>
        /// Setzt einen Fehler
        /// </summary>
        /// <param name="ctrl">Das Control, an welchem der Fehler angezeigt werden soll</param>
        /// <param name="message">Die anzuzeigende Nachricht</param>
        private void SetError(Control ctrl, string message)
        {
            errorProvider.SetError(ctrl, message);
            errorProvider.SetIconPadding(ctrl, -20);
        }
        /// <summary>
        /// Wird ausgelöst, wenn der Benutzer Enter drückt
        /// </summary>
        private void txtGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddGroup();
        }
        /// <summary>
        /// Wird ausgelöst, wenn der Benutzer auf "Hinzufügen" klickt
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddGroup();
        }
        /// <summary>
        /// Wird ausgelöst, wenn der Benutzer auf das Löschen-Symbol klickt
        /// </summary>
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            DeleteGroup();
        }
        /// <summary>
        /// Wird ausgelöst, wenn der Benutzer auf "Schließen" klickt
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {

            Close();
        }
        /// <summary>
        /// Wird ausgelöst, wenn der Benutzer auf "Speichern" klickt
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveAll();
        }
        /// <summary>
        /// Wird ausgelöst, wenn die Form geladen wird
        /// </summary>
        private void GroupForm_Load(object sender, EventArgs e)
        {
            LoadGroups();
        }
        /// <summary>
        /// Wird ausgelöst, wenn sich der Wert einer Zelle geändert hat
        /// </summary>
        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var value = dataGridView.Rows[e.RowIndex].DataBoundItem as GroupModel;

            if (value != null)
            {
                if (!string.IsNullOrEmpty(_oldValue) && _oldValue != value.Name)
                {
                    _hasChanges = true;
                }
            }
            else
            {
                _hasChanges = true;
            }
        }
        /// <summary>
        /// Wird ausgelöst, wenn der Wert einer Zelle geändert wurde
        /// </summary>
        private void dataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var value = dataGridView.Rows[e.RowIndex].DataBoundItem as GroupModel;
            if (value != null)
            {
                _oldValue = value.Name;
            }
        }
        /// <summary>
        /// Wird ausgelöst, wenn die Form geschlossen werden soll
        /// </summary>
        private void GroupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_hasChanges)
            {
                if (MessageBox.Show("Es sind ungespeichert Änderungen vorhanden. Trotzdem verlassen?", "Schließen",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
