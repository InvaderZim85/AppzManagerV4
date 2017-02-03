using System;
using System.Drawing;
using System.Windows.Forms;
using AppzManagerV4.Global;

namespace AppzManagerV4.Forms
{
    public partial class FormMd5Hash : Form
    {
        /// <summary>
        /// Creates a new instance of the form
        /// </summary>
        public FormMd5Hash()
        {
            InitializeComponent();

            txtHash.ForeColor = txtFilepath.ForeColor;
            txtHash.BackColor = txtFilepath.BackColor;
        }
        /// <summary>
        /// Occurs when the user hits the browse button
        /// </summary>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog
            {
                Title = "Wähle die gewünschte Datei aus",
                Multiselect = false
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtFilepath.Text = dialog.FileName;
            }
        }
        /// <summary>
        /// Occurs when the user hits the md5 hash button
        /// </summary>
        private void btnGetMd5Hash_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilepath.Text))
                txtHash.Text = Functions.GetMd5Hash(txtFilepath.Text);
        }
        /// <summary>
        /// Occurs when the user hits the copy button
        /// </summary>
        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtHash.Text);
        }
        /// <summary>
        /// Occurs when the user hits the close button
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Occurs when the user hits the compare button
        /// </summary>
        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (txtHash.Text.ToLower().Equals(txtMd5Original.Text.ToLower()))
            {
                lblHashCompareInfo.Text = "Hash-Werte stimmen überein.";
                lblHashCompareInfo.ForeColor = Color.Green;
            }
            else
            {
                lblHashCompareInfo.Text = "Hast-Werte stimmen nicht überein.";
                lblHashCompareInfo.ForeColor = Color.Red;
            }
        }
    }
}
