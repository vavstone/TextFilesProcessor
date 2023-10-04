namespace TextFilesProcessor
{
    partial class Form1
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
            this.tbDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPanelOperations = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbTrimOracleTableNames = new System.Windows.Forms.CheckBox();
            this.cbRemoveOracleAlters = new System.Windows.Forms.CheckBox();
            this.cbRemoveOracleIndexes = new System.Windows.Forms.CheckBox();
            this.cbRemoveOracleCreateInstallFile = new System.Windows.Forms.CheckBox();
            this.cbRemoveOracleGrants = new System.Windows.Forms.CheckBox();
            this.cbRemoveOraclePartition = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btExecute = new System.Windows.Forms.Button();
            this.cbxInputEncoding = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxOutputEncoding = new System.Windows.Forms.ComboBox();
            this.tbFilesToDirMasks = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFilesToDirDirs = new System.Windows.Forms.TextBox();
            this.tabPanelOperations.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDir
            // 
            this.tbDir.Location = new System.Drawing.Point(123, 15);
            this.tbDir.Name = "tbDir";
            this.tbDir.Size = new System.Drawing.Size(865, 20);
            this.tbDir.TabIndex = 0;
            this.tbDir.Text = "e:\\TextFilesProcessor\\FilesToFolders\\";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Папка с файлами txt:";
            // 
            // tabPanelOperations
            // 
            this.tabPanelOperations.Controls.Add(this.tabPage1);
            this.tabPanelOperations.Controls.Add(this.tabPage2);
            this.tabPanelOperations.Controls.Add(this.tabPage3);
            this.tabPanelOperations.Location = new System.Drawing.Point(13, 82);
            this.tabPanelOperations.Name = "tabPanelOperations";
            this.tabPanelOperations.SelectedIndex = 0;
            this.tabPanelOperations.Size = new System.Drawing.Size(979, 445);
            this.tabPanelOperations.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbTrimOracleTableNames);
            this.tabPage1.Controls.Add(this.cbRemoveOracleAlters);
            this.tabPage1.Controls.Add(this.cbRemoveOracleIndexes);
            this.tabPage1.Controls.Add(this.cbRemoveOracleCreateInstallFile);
            this.tabPage1.Controls.Add(this.cbRemoveOracleGrants);
            this.tabPage1.Controls.Add(this.cbRemoveOraclePartition);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(971, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Oracle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbTrimOracleTableNames
            // 
            this.cbTrimOracleTableNames.AutoSize = true;
            this.cbTrimOracleTableNames.Checked = true;
            this.cbTrimOracleTableNames.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTrimOracleTableNames.Location = new System.Drawing.Point(7, 99);
            this.cbTrimOracleTableNames.Name = "cbTrimOracleTableNames";
            this.cbTrimOracleTableNames.Size = new System.Drawing.Size(247, 17);
            this.cbTrimOracleTableNames.TabIndex = 6;
            this.cbTrimOracleTableNames.Text = "Обрезать названия таблиц до 27 символов";
            this.cbTrimOracleTableNames.UseVisualStyleBackColor = true;
            // 
            // cbRemoveOracleAlters
            // 
            this.cbRemoveOracleAlters.AutoSize = true;
            this.cbRemoveOracleAlters.Checked = true;
            this.cbRemoveOracleAlters.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRemoveOracleAlters.Location = new System.Drawing.Point(7, 76);
            this.cbRemoveOracleAlters.Name = "cbRemoveOracleAlters";
            this.cbRemoveOracleAlters.Size = new System.Drawing.Size(115, 17);
            this.cbRemoveOracleAlters.TabIndex = 5;
            this.cbRemoveOracleAlters.Text = "Удалить альтеры";
            this.cbRemoveOracleAlters.UseVisualStyleBackColor = true;
            // 
            // cbRemoveOracleIndexes
            // 
            this.cbRemoveOracleIndexes.AutoSize = true;
            this.cbRemoveOracleIndexes.Checked = true;
            this.cbRemoveOracleIndexes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRemoveOracleIndexes.Location = new System.Drawing.Point(7, 53);
            this.cbRemoveOracleIndexes.Name = "cbRemoveOracleIndexes";
            this.cbRemoveOracleIndexes.Size = new System.Drawing.Size(116, 17);
            this.cbRemoveOracleIndexes.TabIndex = 4;
            this.cbRemoveOracleIndexes.Text = "Удалить индексы";
            this.cbRemoveOracleIndexes.UseVisualStyleBackColor = true;
            // 
            // cbRemoveOracleCreateInstallFile
            // 
            this.cbRemoveOracleCreateInstallFile.AutoSize = true;
            this.cbRemoveOracleCreateInstallFile.Checked = true;
            this.cbRemoveOracleCreateInstallFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRemoveOracleCreateInstallFile.Location = new System.Drawing.Point(7, 122);
            this.cbRemoveOracleCreateInstallFile.Name = "cbRemoveOracleCreateInstallFile";
            this.cbRemoveOracleCreateInstallFile.Size = new System.Drawing.Size(152, 17);
            this.cbRemoveOracleCreateInstallFile.TabIndex = 3;
            this.cbRemoveOracleCreateInstallFile.Text = "Создать файл \"install.sql\"";
            this.cbRemoveOracleCreateInstallFile.UseVisualStyleBackColor = true;
            // 
            // cbRemoveOracleGrants
            // 
            this.cbRemoveOracleGrants.AutoSize = true;
            this.cbRemoveOracleGrants.Checked = true;
            this.cbRemoveOracleGrants.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRemoveOracleGrants.Location = new System.Drawing.Point(7, 30);
            this.cbRemoveOracleGrants.Name = "cbRemoveOracleGrants";
            this.cbRemoveOracleGrants.Size = new System.Drawing.Size(108, 17);
            this.cbRemoveOracleGrants.TabIndex = 1;
            this.cbRemoveOracleGrants.Text = "Удалить гранты";
            this.cbRemoveOracleGrants.UseVisualStyleBackColor = true;
            // 
            // cbRemoveOraclePartition
            // 
            this.cbRemoveOraclePartition.AutoSize = true;
            this.cbRemoveOraclePartition.Checked = true;
            this.cbRemoveOraclePartition.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRemoveOraclePartition.Location = new System.Drawing.Point(7, 7);
            this.cbRemoveOraclePartition.Name = "cbRemoveOraclePartition";
            this.cbRemoveOraclePartition.Size = new System.Drawing.Size(119, 17);
            this.cbRemoveOraclePartition.TabIndex = 0;
            this.cbRemoveOraclePartition.Text = "Удалить партиции";
            this.cbRemoveOraclePartition.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tbFilesToDirDirs);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tbFilesToDirMasks);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(971, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Файлы по папкам";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(971, 419);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Разное";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btExecute
            // 
            this.btExecute.Location = new System.Drawing.Point(17, 533);
            this.btExecute.Name = "btExecute";
            this.btExecute.Size = new System.Drawing.Size(75, 23);
            this.btExecute.TabIndex = 3;
            this.btExecute.Text = "Выполнить";
            this.btExecute.UseVisualStyleBackColor = true;
            this.btExecute.Click += new System.EventHandler(this.btExecute_Click);
            // 
            // cbxInputEncoding
            // 
            this.cbxInputEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxInputEncoding.FormattingEnabled = true;
            this.cbxInputEncoding.Items.AddRange(new object[] {
            "Windows 1251"});
            this.cbxInputEncoding.Location = new System.Drawing.Point(292, 45);
            this.cbxInputEncoding.Name = "cbxInputEncoding";
            this.cbxInputEncoding.Size = new System.Drawing.Size(121, 21);
            this.cbxInputEncoding.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Кодировка исходных файлов (по умолчанию Unicode):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(570, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Кодировка выходных файлов (по умолчанию Unicode):";
            // 
            // cbxOutputEncoding
            // 
            this.cbxOutputEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOutputEncoding.FormattingEnabled = true;
            this.cbxOutputEncoding.Items.AddRange(new object[] {
            "Windows 1251"});
            this.cbxOutputEncoding.Location = new System.Drawing.Point(858, 45);
            this.cbxOutputEncoding.Name = "cbxOutputEncoding";
            this.cbxOutputEncoding.Size = new System.Drawing.Size(121, 21);
            this.cbxOutputEncoding.TabIndex = 7;
            // 
            // tbFilesToDirMasks
            // 
            this.tbFilesToDirMasks.Location = new System.Drawing.Point(6, 23);
            this.tbFilesToDirMasks.Multiline = true;
            this.tbFilesToDirMasks.Name = "tbFilesToDirMasks";
            this.tbFilesToDirMasks.Size = new System.Drawing.Size(444, 390);
            this.tbFilesToDirMasks.TabIndex = 0;
            this.tbFilesToDirMasks.Text = "*.fnc\r\n*.pck;*.spc\r\n*.prc\r\n*.seq\r\n*.syn\r\n*.tab\r\n*.tps\r\n*.trg\r\n*.vw;*.mvw";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Маски файлов для отбора";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(519, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Целевые папки";
            // 
            // tbFilesToDirDirs
            // 
            this.tbFilesToDirDirs.Location = new System.Drawing.Point(518, 23);
            this.tbFilesToDirDirs.Multiline = true;
            this.tbFilesToDirDirs.Name = "tbFilesToDirDirs";
            this.tbFilesToDirDirs.Size = new System.Drawing.Size(444, 390);
            this.tbFilesToDirDirs.TabIndex = 2;
            this.tbFilesToDirDirs.Text = "functions\r\npackages\r\nprocedures\r\nsequences\r\nsynonyms\r\ntables\r\ntypes\r\ntriggers\r\nvi" +
    "ews";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 563);
            this.Controls.Add(this.cbxOutputEncoding);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxInputEncoding);
            this.Controls.Add(this.btExecute);
            this.Controls.Add(this.tabPanelOperations);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDir);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabPanelOperations.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabPanelOperations;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox cbRemoveOraclePartition;
        private System.Windows.Forms.Button btExecute;
        private System.Windows.Forms.CheckBox cbRemoveOracleGrants;
        private System.Windows.Forms.ComboBox cbxInputEncoding;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxOutputEncoding;
        private System.Windows.Forms.CheckBox cbRemoveOracleCreateInstallFile;
        private System.Windows.Forms.CheckBox cbRemoveOracleIndexes;
        private System.Windows.Forms.CheckBox cbRemoveOracleAlters;
        private System.Windows.Forms.CheckBox cbTrimOracleTableNames;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFilesToDirDirs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFilesToDirMasks;
    }
}

