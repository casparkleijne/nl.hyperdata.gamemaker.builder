namespace nl.hyperdata.gamemaker.builder
{
    partial class MainForm
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.bt_DllExtensionFile = new System.Windows.Forms.Button();
            this.bt_DllExportFile = new System.Windows.Forms.Button();
            this.bt_GameMakerProject = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "*.dll";
            // 
            // bt_DllExtensionFile
            // 
            this.bt_DllExtensionFile.Location = new System.Drawing.Point(30, 83);
            this.bt_DllExtensionFile.Name = "bt_DllExtensionFile";
            this.bt_DllExtensionFile.Size = new System.Drawing.Size(432, 46);
            this.bt_DllExtensionFile.TabIndex = 2;
            this.bt_DllExtensionFile.Text = "Extension DLL Location";
            this.bt_DllExtensionFile.UseVisualStyleBackColor = true;
            this.bt_DllExtensionFile.Click += new System.EventHandler(this.bt_DllExtensionFile_Click);
            // 
            // bt_DllExportFile
            // 
            this.bt_DllExportFile.Location = new System.Drawing.Point(30, 31);
            this.bt_DllExportFile.Name = "bt_DllExportFile";
            this.bt_DllExportFile.Size = new System.Drawing.Size(432, 46);
            this.bt_DllExportFile.TabIndex = 3;
            this.bt_DllExportFile.Text = "DllExport DLL Location";
            this.bt_DllExportFile.UseVisualStyleBackColor = true;
            this.bt_DllExportFile.Click += new System.EventHandler(this.bt_DllExportFile_Click);
            // 
            // bt_GameMakerProject
            // 
            this.bt_GameMakerProject.Location = new System.Drawing.Point(30, 135);
            this.bt_GameMakerProject.Name = "bt_GameMakerProject";
            this.bt_GameMakerProject.Size = new System.Drawing.Size(432, 46);
            this.bt_GameMakerProject.TabIndex = 4;
            this.bt_GameMakerProject.Text = "Gamemaker ProjectFile Location";
            this.bt_GameMakerProject.UseVisualStyleBackColor = true;
            this.bt_GameMakerProject.Click += new System.EventHandler(this.bt_GameMakerProject_Click);
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.toolTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.toolTip.IsBalloon = true;
            this.toolTip.OwnerDraw = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(30, 188);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(432, 229);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 542);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bt_GameMakerProject);
            this.Controls.Add(this.bt_DllExportFile);
            this.Controls.Add(this.bt_DllExtensionFile);
            this.Name = "MainForm";
            this.Text = "GameMaker Extension Builder";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button bt_DllExtensionFile;
        private System.Windows.Forms.Button bt_DllExportFile;
        private System.Windows.Forms.Button bt_GameMakerProject;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ListBox listBox1;
    }
}

