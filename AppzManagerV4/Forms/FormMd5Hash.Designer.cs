namespace AppzManagerV4.Forms
{
    partial class FormMd5Hash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMd5Hash));
            this.lblFile = new System.Windows.Forms.Label();
            this.txtFilepath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnGetMd5Hash = new System.Windows.Forms.Button();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.lblHash = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.txtMd5Original = new System.Windows.Forms.TextBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.lblMd5Original = new System.Windows.Forms.Label();
            this.lblHashCompareInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(76, 17);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(35, 13);
            this.lblFile.TabIndex = 0;
            this.lblFile.Text = "Datei:";
            // 
            // txtFilepath
            // 
            this.txtFilepath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilepath.Location = new System.Drawing.Point(117, 14);
            this.txtFilepath.Name = "txtFilepath";
            this.txtFilepath.Size = new System.Drawing.Size(213, 20);
            this.txtFilepath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(336, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(35, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnGetMd5Hash
            // 
            this.btnGetMd5Hash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetMd5Hash.Enabled = false;
            this.btnGetMd5Hash.Location = new System.Drawing.Point(377, 12);
            this.btnGetMd5Hash.Name = "btnGetMd5Hash";
            this.btnGetMd5Hash.Size = new System.Drawing.Size(75, 23);
            this.btnGetMd5Hash.TabIndex = 3;
            this.btnGetMd5Hash.Text = "MD5 Hash";
            this.btnGetMd5Hash.UseVisualStyleBackColor = true;
            this.btnGetMd5Hash.Click += new System.EventHandler(this.btnGetMd5Hash_Click);
            // 
            // txtHash
            // 
            this.txtHash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHash.Location = new System.Drawing.Point(117, 40);
            this.txtHash.Name = "txtHash";
            this.txtHash.ReadOnly = true;
            this.txtHash.Size = new System.Drawing.Size(254, 20);
            this.txtHash.TabIndex = 5;
            // 
            // lblHash
            // 
            this.lblHash.AutoSize = true;
            this.lblHash.Location = new System.Drawing.Point(50, 43);
            this.lblHash.Name = "lblHash";
            this.lblHash.Size = new System.Drawing.Size(61, 13);
            this.lblHash.TabIndex = 4;
            this.lblHash.Text = "MD5 Hash:";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(377, 91);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Schließen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Enabled = false;
            this.btnCopy.Location = new System.Drawing.Point(377, 38);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 7;
            this.btnCopy.Text = "Kopieren";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // txtMd5Original
            // 
            this.txtMd5Original.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMd5Original.Location = new System.Drawing.Point(117, 66);
            this.txtMd5Original.Name = "txtMd5Original";
            this.txtMd5Original.Size = new System.Drawing.Size(254, 20);
            this.txtMd5Original.TabIndex = 8;
            this.txtMd5Original.TextChanged += new System.EventHandler(this.txtMd5Original_TextChanged);
            // 
            // btnCompare
            // 
            this.btnCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompare.Enabled = false;
            this.btnCompare.Location = new System.Drawing.Point(377, 64);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 9;
            this.btnCompare.Text = "Vergleichen";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // lblMd5Original
            // 
            this.lblMd5Original.AutoSize = true;
            this.lblMd5Original.Location = new System.Drawing.Point(12, 69);
            this.lblMd5Original.Name = "lblMd5Original";
            this.lblMd5Original.Size = new System.Drawing.Size(99, 13);
            this.lblMd5Original.TabIndex = 10;
            this.lblMd5Original.Text = "MD5 Hash Original:";
            // 
            // lblHashCompareInfo
            // 
            this.lblHashCompareInfo.AutoSize = true;
            this.lblHashCompareInfo.Location = new System.Drawing.Point(114, 89);
            this.lblHashCompareInfo.Name = "lblHashCompareInfo";
            this.lblHashCompareInfo.Size = new System.Drawing.Size(0, 13);
            this.lblHashCompareInfo.TabIndex = 11;
            // 
            // FormMd5Hash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 126);
            this.Controls.Add(this.lblHashCompareInfo);
            this.Controls.Add(this.lblMd5Original);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.txtMd5Original);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtHash);
            this.Controls.Add(this.lblHash);
            this.Controls.Add(this.btnGetMd5Hash);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFilepath);
            this.Controls.Add(this.lblFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMd5Hash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MD5 Hash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.TextBox txtFilepath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnGetMd5Hash;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.Label lblHash;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox txtMd5Original;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Label lblMd5Original;
        private System.Windows.Forms.Label lblHashCompareInfo;
    }
}