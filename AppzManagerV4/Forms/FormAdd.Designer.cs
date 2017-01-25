namespace AppzManagerV4.Forms
{
    partial class FormAdd
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdd));
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblExecuteIn = new System.Windows.Forms.Label();
            this.lblParameter = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblShortcut = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.comboGroup = new System.Windows.Forms.ComboBox();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelExecuteIn = new System.Windows.Forms.Panel();
            this.txtExecuteIn = new System.Windows.Forms.TextBox();
            this.btnBrowseExecuteIn = new System.Windows.Forms.Button();
            this.lblGroup = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtParameter = new System.Windows.Forms.TextBox();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.panelPath = new System.Windows.Forms.Panel();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowsePath = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.panelShortcut = new System.Windows.Forms.Panel();
            this.lblCtrl = new System.Windows.Forms.Label();
            this.txtShortcut = new System.Windows.Forms.TextBox();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.lblShowInContextMenu = new System.Windows.Forms.Label();
            this.checkShowInContextMenu = new System.Windows.Forms.CheckBox();
            this.btnColerChooser = new System.Windows.Forms.Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblColorData = new System.Windows.Forms.Label();
            this.panelPicButtons = new System.Windows.Forms.Panel();
            this.btnDeleteIcon = new System.Windows.Forms.Button();
            this.btnChangeIcon = new System.Windows.Forms.Button();
            this.lblAutostart = new System.Windows.Forms.Label();
            this.checkAutostart = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSaveClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxData.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.panelExecuteIn.SuspendLayout();
            this.panelPath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.panelShortcut.SuspendLayout();
            this.panelPicButtons.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Location = new System.Drawing.Point(143, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(347, 20);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(134, 26);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblExecuteIn
            // 
            this.lblExecuteIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblExecuteIn.Location = new System.Drawing.Point(3, 52);
            this.lblExecuteIn.Name = "lblExecuteIn";
            this.lblExecuteIn.Size = new System.Drawing.Size(134, 26);
            this.lblExecuteIn.TabIndex = 2;
            this.lblExecuteIn.Text = "Ausführen in:";
            this.lblExecuteIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblParameter
            // 
            this.lblParameter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblParameter.Location = new System.Drawing.Point(3, 78);
            this.lblParameter.Name = "lblParameter";
            this.lblParameter.Size = new System.Drawing.Size(134, 26);
            this.lblParameter.TabIndex = 3;
            this.lblParameter.Text = "Parameter:";
            this.lblParameter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVersion
            // 
            this.lblVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVersion.Location = new System.Drawing.Point(3, 104);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(134, 26);
            this.lblVersion.TabIndex = 4;
            this.lblVersion.Text = "Version:";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblShortcut
            // 
            this.lblShortcut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblShortcut.Location = new System.Drawing.Point(3, 130);
            this.lblShortcut.Name = "lblShortcut";
            this.lblShortcut.Size = new System.Drawing.Size(134, 26);
            this.lblShortcut.TabIndex = 5;
            this.lblShortcut.Text = "Shortcut:";
            this.lblShortcut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblComment
            // 
            this.lblComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblComment.Location = new System.Drawing.Point(3, 156);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(134, 26);
            this.lblComment.TabIndex = 6;
            this.lblComment.Text = "Kommentar:";
            this.lblComment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboGroup
            // 
            this.comboGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGroup.FormattingEnabled = true;
            this.comboGroup.Location = new System.Drawing.Point(143, 185);
            this.comboGroup.Name = "comboGroup";
            this.comboGroup.Size = new System.Drawing.Size(347, 21);
            this.comboGroup.TabIndex = 7;
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.tableLayoutPanel);
            this.groupBoxData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxData.Location = new System.Drawing.Point(0, 0);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(639, 306);
            this.groupBoxData.TabIndex = 3;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Daten";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel.Controls.Add(this.panelExecuteIn, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.lblExecuteIn, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.lblParameter, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.lblVersion, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.lblShortcut, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.lblComment, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.lblGroup, 0, 7);
            this.tableLayoutPanel.Controls.Add(this.comboGroup, 1, 7);
            this.tableLayoutPanel.Controls.Add(this.txtComment, 1, 6);
            this.tableLayoutPanel.Controls.Add(this.txtParameter, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.txtVersion, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.panelPath, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.lblPath, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.pictureBoxIcon, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.panelShortcut, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.btnAddGroup, 2, 7);
            this.tableLayoutPanel.Controls.Add(this.lblShowInContextMenu, 0, 9);
            this.tableLayoutPanel.Controls.Add(this.checkShowInContextMenu, 1, 9);
            this.tableLayoutPanel.Controls.Add(this.btnColerChooser, 2, 8);
            this.tableLayoutPanel.Controls.Add(this.lblColor, 0, 8);
            this.tableLayoutPanel.Controls.Add(this.lblColorData, 1, 8);
            this.tableLayoutPanel.Controls.Add(this.panelPicButtons, 2, 4);
            this.tableLayoutPanel.Controls.Add(this.lblAutostart, 0, 10);
            this.tableLayoutPanel.Controls.Add(this.checkAutostart, 1, 10);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 12;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(633, 287);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // panelExecuteIn
            // 
            this.panelExecuteIn.Controls.Add(this.txtExecuteIn);
            this.panelExecuteIn.Controls.Add(this.btnBrowseExecuteIn);
            this.panelExecuteIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelExecuteIn.Location = new System.Drawing.Point(140, 52);
            this.panelExecuteIn.Margin = new System.Windows.Forms.Padding(0);
            this.panelExecuteIn.Name = "panelExecuteIn";
            this.panelExecuteIn.Size = new System.Drawing.Size(353, 26);
            this.panelExecuteIn.TabIndex = 2;
            // 
            // txtExecuteIn
            // 
            this.txtExecuteIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExecuteIn.Location = new System.Drawing.Point(3, 3);
            this.txtExecuteIn.Name = "txtExecuteIn";
            this.txtExecuteIn.Size = new System.Drawing.Size(307, 20);
            this.txtExecuteIn.TabIndex = 0;
            this.txtExecuteIn.EnabledChanged += new System.EventHandler(this.txtExecuteIn_EnabledChanged);
            // 
            // btnBrowseExecuteIn
            // 
            this.btnBrowseExecuteIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseExecuteIn.Location = new System.Drawing.Point(316, 3);
            this.btnBrowseExecuteIn.Margin = new System.Windows.Forms.Padding(0);
            this.btnBrowseExecuteIn.Name = "btnBrowseExecuteIn";
            this.btnBrowseExecuteIn.Size = new System.Drawing.Size(34, 20);
            this.btnBrowseExecuteIn.TabIndex = 1;
            this.btnBrowseExecuteIn.Text = "...";
            this.btnBrowseExecuteIn.UseVisualStyleBackColor = true;
            this.btnBrowseExecuteIn.Click += new System.EventHandler(this.ButtonBrowseClick);
            // 
            // lblGroup
            // 
            this.lblGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGroup.Location = new System.Drawing.Point(3, 182);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(134, 26);
            this.lblGroup.TabIndex = 7;
            this.lblGroup.Text = "Gruppe:";
            this.lblGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtComment
            // 
            this.txtComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComment.Location = new System.Drawing.Point(143, 159);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(347, 20);
            this.txtComment.TabIndex = 6;
            // 
            // txtParameter
            // 
            this.txtParameter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtParameter.Location = new System.Drawing.Point(143, 81);
            this.txtParameter.Name = "txtParameter";
            this.txtParameter.Size = new System.Drawing.Size(347, 20);
            this.txtParameter.TabIndex = 3;
            // 
            // txtVersion
            // 
            this.txtVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVersion.Location = new System.Drawing.Point(143, 107);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(347, 20);
            this.txtVersion.TabIndex = 4;
            // 
            // panelPath
            // 
            this.panelPath.Controls.Add(this.txtPath);
            this.panelPath.Controls.Add(this.btnBrowsePath);
            this.panelPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPath.Location = new System.Drawing.Point(140, 26);
            this.panelPath.Margin = new System.Windows.Forms.Padding(0);
            this.panelPath.Name = "panelPath";
            this.panelPath.Size = new System.Drawing.Size(353, 26);
            this.panelPath.TabIndex = 1;
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(3, 3);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(307, 20);
            this.txtPath.TabIndex = 0;
            // 
            // btnBrowsePath
            // 
            this.btnBrowsePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowsePath.Location = new System.Drawing.Point(316, 3);
            this.btnBrowsePath.Margin = new System.Windows.Forms.Padding(0);
            this.btnBrowsePath.Name = "btnBrowsePath";
            this.btnBrowsePath.Size = new System.Drawing.Size(34, 20);
            this.btnBrowsePath.TabIndex = 1;
            this.btnBrowsePath.Text = "...";
            this.btnBrowsePath.UseVisualStyleBackColor = true;
            this.btnBrowsePath.Click += new System.EventHandler(this.ButtonBrowseClick);
            // 
            // lblPath
            // 
            this.lblPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPath.Location = new System.Drawing.Point(3, 26);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(134, 26);
            this.lblPath.TabIndex = 1;
            this.lblPath.Text = "Pfad:";
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxIcon.Image = global::AppzManagerV4.Properties.Resources.NoIcon;
            this.pictureBoxIcon.Location = new System.Drawing.Point(496, 3);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.tableLayoutPanel.SetRowSpan(this.pictureBoxIcon, 4);
            this.pictureBoxIcon.Size = new System.Drawing.Size(134, 98);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 17;
            this.pictureBoxIcon.TabStop = false;
            // 
            // panelShortcut
            // 
            this.panelShortcut.Controls.Add(this.lblCtrl);
            this.panelShortcut.Controls.Add(this.txtShortcut);
            this.panelShortcut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShortcut.Location = new System.Drawing.Point(140, 130);
            this.panelShortcut.Margin = new System.Windows.Forms.Padding(0);
            this.panelShortcut.Name = "panelShortcut";
            this.panelShortcut.Size = new System.Drawing.Size(353, 26);
            this.panelShortcut.TabIndex = 5;
            // 
            // lblCtrl
            // 
            this.lblCtrl.AutoSize = true;
            this.lblCtrl.Location = new System.Drawing.Point(3, 6);
            this.lblCtrl.Name = "lblCtrl";
            this.lblCtrl.Size = new System.Drawing.Size(46, 13);
            this.lblCtrl.TabIndex = 5;
            this.lblCtrl.Text = "STRG +";
            // 
            // txtShortcut
            // 
            this.txtShortcut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtShortcut.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtShortcut.Location = new System.Drawing.Point(55, 3);
            this.txtShortcut.MaxLength = 1;
            this.txtShortcut.Name = "txtShortcut";
            this.txtShortcut.Size = new System.Drawing.Size(156, 20);
            this.txtShortcut.TabIndex = 0;
            this.txtShortcut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtShortcut_KeyPress);
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.Image = global::AppzManagerV4.Properties.Resources.Plus;
            this.btnAddGroup.Location = new System.Drawing.Point(493, 184);
            this.btnAddGroup.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(36, 24);
            this.btnAddGroup.TabIndex = 8;
            this.btnAddGroup.UseVisualStyleBackColor = true;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // lblShowInContextMenu
            // 
            this.lblShowInContextMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblShowInContextMenu.Location = new System.Drawing.Point(3, 234);
            this.lblShowInContextMenu.Name = "lblShowInContextMenu";
            this.lblShowInContextMenu.Size = new System.Drawing.Size(134, 26);
            this.lblShowInContextMenu.TabIndex = 18;
            this.lblShowInContextMenu.Text = "Im Kontextmenü anzeigen:";
            this.lblShowInContextMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkShowInContextMenu
            // 
            this.checkShowInContextMenu.AutoSize = true;
            this.checkShowInContextMenu.Checked = true;
            this.checkShowInContextMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkShowInContextMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkShowInContextMenu.Location = new System.Drawing.Point(143, 237);
            this.checkShowInContextMenu.Name = "checkShowInContextMenu";
            this.checkShowInContextMenu.Size = new System.Drawing.Size(347, 20);
            this.checkShowInContextMenu.TabIndex = 19;
            this.checkShowInContextMenu.Text = "(zeigt das Programm im Kontextmenü an)";
            this.checkShowInContextMenu.UseVisualStyleBackColor = true;
            // 
            // btnColerChooser
            // 
            this.btnColerChooser.Location = new System.Drawing.Point(494, 209);
            this.btnColerChooser.Margin = new System.Windows.Forms.Padding(1);
            this.btnColerChooser.Name = "btnColerChooser";
            this.btnColerChooser.Size = new System.Drawing.Size(68, 24);
            this.btnColerChooser.TabIndex = 20;
            this.btnColerChooser.Text = "Ändern";
            this.btnColerChooser.UseVisualStyleBackColor = true;
            this.btnColerChooser.Click += new System.EventHandler(this.ButtonBrowseClick);
            // 
            // lblColor
            // 
            this.lblColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblColor.Location = new System.Drawing.Point(3, 208);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(134, 26);
            this.lblColor.TabIndex = 21;
            this.lblColor.Text = "Farbe:";
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblColorData
            // 
            this.lblColorData.BackColor = System.Drawing.Color.White;
            this.lblColorData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblColorData.Location = new System.Drawing.Point(143, 208);
            this.lblColorData.Name = "lblColorData";
            this.lblColorData.Size = new System.Drawing.Size(347, 26);
            this.lblColorData.TabIndex = 22;
            this.lblColorData.Text = "Testeintrag...";
            this.lblColorData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPicButtons
            // 
            this.panelPicButtons.Controls.Add(this.btnDeleteIcon);
            this.panelPicButtons.Controls.Add(this.btnChangeIcon);
            this.panelPicButtons.Location = new System.Drawing.Point(493, 104);
            this.panelPicButtons.Margin = new System.Windows.Forms.Padding(0);
            this.panelPicButtons.Name = "panelPicButtons";
            this.panelPicButtons.Size = new System.Drawing.Size(140, 26);
            this.panelPicButtons.TabIndex = 23;
            // 
            // btnDeleteIcon
            // 
            this.btnDeleteIcon.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDeleteIcon.Location = new System.Drawing.Point(71, 0);
            this.btnDeleteIcon.Margin = new System.Windows.Forms.Padding(1);
            this.btnDeleteIcon.Name = "btnDeleteIcon";
            this.btnDeleteIcon.Size = new System.Drawing.Size(69, 26);
            this.btnDeleteIcon.TabIndex = 10;
            this.btnDeleteIcon.Text = "Löschen";
            this.btnDeleteIcon.UseVisualStyleBackColor = true;
            this.btnDeleteIcon.Click += new System.EventHandler(this.btnDeleteIcon_Click);
            // 
            // btnChangeIcon
            // 
            this.btnChangeIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnChangeIcon.Location = new System.Drawing.Point(0, 0);
            this.btnChangeIcon.Margin = new System.Windows.Forms.Padding(1);
            this.btnChangeIcon.Name = "btnChangeIcon";
            this.btnChangeIcon.Size = new System.Drawing.Size(69, 26);
            this.btnChangeIcon.TabIndex = 9;
            this.btnChangeIcon.Text = "Ändern";
            this.btnChangeIcon.UseVisualStyleBackColor = true;
            this.btnChangeIcon.Click += new System.EventHandler(this.ButtonBrowseClick);
            // 
            // lblAutostart
            // 
            this.lblAutostart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAutostart.Location = new System.Drawing.Point(3, 260);
            this.lblAutostart.Name = "lblAutostart";
            this.lblAutostart.Size = new System.Drawing.Size(134, 26);
            this.lblAutostart.TabIndex = 24;
            this.lblAutostart.Text = "Autostart:";
            this.lblAutostart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkAutostart
            // 
            this.checkAutostart.AutoSize = true;
            this.checkAutostart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkAutostart.Location = new System.Drawing.Point(143, 263);
            this.checkAutostart.Name = "checkAutostart";
            this.checkAutostart.Size = new System.Drawing.Size(347, 20);
            this.checkAutostart.TabIndex = 25;
            this.checkAutostart.Text = "(startet das Programm beim Start des AppzManagers mit)";
            this.checkAutostart.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(240, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.Location = new System.Drawing.Point(12, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Zurücksetzen";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveClose.Location = new System.Drawing.Point(371, 10);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Size = new System.Drawing.Size(125, 23);
            this.btnSaveClose.TabIndex = 2;
            this.btnSaveClose.Text = "Speichern && Schließen";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSaveClose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(502, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Schließen";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnClear);
            this.panelBottom.Controls.Add(this.btnSaveClose);
            this.panelBottom.Controls.Add(this.btnSave);
            this.panelBottom.Controls.Add(this.btnCancel);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 306);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(639, 45);
            this.panelBottom.TabIndex = 4;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 351);
            this.Controls.Add(this.groupBoxData);
            this.Controls.Add(this.panelBottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neuer Eintrag";
            this.Load += new System.EventHandler(this.FormAdd_Load);
            this.groupBoxData.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.panelExecuteIn.ResumeLayout(false);
            this.panelExecuteIn.PerformLayout();
            this.panelPath.ResumeLayout(false);
            this.panelPath.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.panelShortcut.ResumeLayout(false);
            this.panelShortcut.PerformLayout();
            this.panelPicButtons.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblExecuteIn;
        private System.Windows.Forms.Label lblParameter;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblShortcut;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.ComboBox comboGroup;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panelExecuteIn;
        private System.Windows.Forms.TextBox txtExecuteIn;
        private System.Windows.Forms.Button btnBrowseExecuteIn;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TextBox txtParameter;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Panel panelPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnBrowsePath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Panel panelShortcut;
        private System.Windows.Forms.Label lblCtrl;
        private System.Windows.Forms.TextBox txtShortcut;
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.Label lblShowInContextMenu;
        private System.Windows.Forms.CheckBox checkShowInContextMenu;
        private System.Windows.Forms.Button btnColerChooser;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblColorData;
        private System.Windows.Forms.Panel panelPicButtons;
        private System.Windows.Forms.Button btnDeleteIcon;
        private System.Windows.Forms.Button btnChangeIcon;
        private System.Windows.Forms.Label lblAutostart;
        private System.Windows.Forms.CheckBox checkAutostart;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSaveClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}