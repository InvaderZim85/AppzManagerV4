namespace AppzManagerV4.Forms
{
    partial class FormImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImport));
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblFolderPath = new System.Windows.Forms.Label();
            this.btnLoadFiles = new System.Windows.Forms.Button();
            this.checkedListFiles = new System.Windows.Forms.CheckedListBox();
            this.lblFiles = new System.Windows.Forms.Label();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.btnCheckNone = new System.Windows.Forms.Button();
            this.groupFiles = new System.Windows.Forms.GroupBox();
            this.groupOptions = new System.Windows.Forms.GroupBox();
            this.radioAddNew = new System.Windows.Forms.RadioButton();
            this.radioAddAll = new System.Windows.Forms.RadioButton();
            this.btnImport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupFiles.SuspendLayout();
            this.groupOptions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFolder
            // 
            this.txtFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolder.Location = new System.Drawing.Point(63, 21);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(241, 20);
            this.txtFolder.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(310, 19);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(33, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblFolderPath
            // 
            this.lblFolderPath.AutoSize = true;
            this.lblFolderPath.Location = new System.Drawing.Point(15, 24);
            this.lblFolderPath.Name = "lblFolderPath";
            this.lblFolderPath.Size = new System.Drawing.Size(42, 13);
            this.lblFolderPath.TabIndex = 2;
            this.lblFolderPath.Text = "Ordner:";
            // 
            // btnLoadFiles
            // 
            this.btnLoadFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadFiles.Location = new System.Drawing.Point(349, 19);
            this.btnLoadFiles.Name = "btnLoadFiles";
            this.btnLoadFiles.Size = new System.Drawing.Size(89, 23);
            this.btnLoadFiles.TabIndex = 3;
            this.btnLoadFiles.Text = "Laden";
            this.btnLoadFiles.UseVisualStyleBackColor = true;
            this.btnLoadFiles.Click += new System.EventHandler(this.btnLoadFiles_Click);
            // 
            // checkedListFiles
            // 
            this.checkedListFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListFiles.FormattingEnabled = true;
            this.checkedListFiles.Location = new System.Drawing.Point(63, 47);
            this.checkedListFiles.Name = "checkedListFiles";
            this.checkedListFiles.Size = new System.Drawing.Size(241, 94);
            this.checkedListFiles.TabIndex = 4;
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Location = new System.Drawing.Point(10, 51);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(47, 13);
            this.lblFiles.TabIndex = 5;
            this.lblFiles.Text = "Dateien:";
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckAll.Location = new System.Drawing.Point(310, 48);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(128, 23);
            this.btnCheckAll.TabIndex = 6;
            this.btnCheckAll.Text = "Alle markieren";
            this.btnCheckAll.UseVisualStyleBackColor = true;
            this.btnCheckAll.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // btnCheckNone
            // 
            this.btnCheckNone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckNone.Location = new System.Drawing.Point(310, 77);
            this.btnCheckNone.Name = "btnCheckNone";
            this.btnCheckNone.Size = new System.Drawing.Size(128, 23);
            this.btnCheckNone.TabIndex = 7;
            this.btnCheckNone.Text = "Markierung aufheben";
            this.btnCheckNone.UseVisualStyleBackColor = true;
            this.btnCheckNone.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // groupFiles
            // 
            this.groupFiles.Controls.Add(this.btnLoadFiles);
            this.groupFiles.Controls.Add(this.btnCheckNone);
            this.groupFiles.Controls.Add(this.txtFolder);
            this.groupFiles.Controls.Add(this.btnCheckAll);
            this.groupFiles.Controls.Add(this.btnBrowse);
            this.groupFiles.Controls.Add(this.lblFiles);
            this.groupFiles.Controls.Add(this.lblFolderPath);
            this.groupFiles.Controls.Add(this.checkedListFiles);
            this.groupFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupFiles.Location = new System.Drawing.Point(0, 0);
            this.groupFiles.Name = "groupFiles";
            this.groupFiles.Size = new System.Drawing.Size(450, 151);
            this.groupFiles.TabIndex = 8;
            this.groupFiles.TabStop = false;
            this.groupFiles.Text = "Dateien";
            // 
            // groupOptions
            // 
            this.groupOptions.Controls.Add(this.radioAddNew);
            this.groupOptions.Controls.Add(this.radioAddAll);
            this.groupOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupOptions.Location = new System.Drawing.Point(0, 151);
            this.groupOptions.Name = "groupOptions";
            this.groupOptions.Size = new System.Drawing.Size(450, 72);
            this.groupOptions.TabIndex = 9;
            this.groupOptions.TabStop = false;
            this.groupOptions.Text = "Optionen";
            // 
            // radioAddNew
            // 
            this.radioAddNew.AutoSize = true;
            this.radioAddNew.Checked = true;
            this.radioAddNew.Location = new System.Drawing.Point(12, 42);
            this.radioAddNew.Name = "radioAddNew";
            this.radioAddNew.Size = new System.Drawing.Size(150, 17);
            this.radioAddNew.TabIndex = 1;
            this.radioAddNew.TabStop = true;
            this.radioAddNew.Text = "Neue Datensätze anfügen";
            this.radioAddNew.UseVisualStyleBackColor = true;
            // 
            // radioAddAll
            // 
            this.radioAddAll.AutoSize = true;
            this.radioAddAll.Location = new System.Drawing.Point(12, 19);
            this.radioAddAll.Name = "radioAddAll";
            this.radioAddAll.Size = new System.Drawing.Size(210, 17);
            this.radioAddAll.TabIndex = 0;
            this.radioAddAll.Text = "Vorhandene Datensätze überschreiben";
            this.radioAddAll.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.Location = new System.Drawing.Point(176, 10);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(128, 23);
            this.btnImport.TabIndex = 10;
            this.btnImport.Text = "Importieren";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInfo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 151);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // txtInfo
            // 
            this.txtInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInfo.Location = new System.Drawing.Point(3, 16);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(444, 132);
            this.txtInfo.TabIndex = 0;
            this.txtInfo.Text = "Hinweis: \nEs werden nur Anwendungs- und Ordnerdaten importiert.\nGruppendaten werd" +
    "en nicht importiert. Beim Import wird\ndaher eine \"Importgruppe\" angelegt, welche" +
    " später geändert\nwerden kann!";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnCancel);
            this.panelBottom.Controls.Add(this.btnImport);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 374);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(450, 45);
            this.panelBottom.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(310, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 419);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.groupOptions);
            this.Controls.Add(this.groupFiles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import";
            this.groupFiles.ResumeLayout(false);
            this.groupFiles.PerformLayout();
            this.groupOptions.ResumeLayout(false);
            this.groupOptions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblFolderPath;
        private System.Windows.Forms.Button btnLoadFiles;
        private System.Windows.Forms.CheckedListBox checkedListFiles;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.Button btnCheckNone;
        private System.Windows.Forms.GroupBox groupFiles;
        private System.Windows.Forms.GroupBox groupOptions;
        private System.Windows.Forms.RadioButton radioAddNew;
        private System.Windows.Forms.RadioButton radioAddAll;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RichTextBox txtInfo;
    }
}