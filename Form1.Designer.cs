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
            this.cbUpperFirstLetterInComments = new System.Windows.Forms.CheckBox();
            this.cbUpperColNamesInComments = new System.Windows.Forms.CheckBox();
            this.cbTrimOracleTableColNames = new System.Windows.Forms.CheckBox();
            this.cbTrimOracleTableNames = new System.Windows.Forms.CheckBox();
            this.cbRemoveOracleAlters = new System.Windows.Forms.CheckBox();
            this.cbRemoveOracleIndexes = new System.Windows.Forms.CheckBox();
            this.cbOracleCreateInstallFile = new System.Windows.Forms.CheckBox();
            this.cbRemoveOracleGrants = new System.Windows.Forms.CheckBox();
            this.cbRemoveOraclePartition = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFilesToDirDirs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFilesToDirMasks = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbUnzip = new System.Windows.Forms.RadioButton();
            this.rbZip = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.cbRemoveIntermediateDoubles = new System.Windows.Forms.CheckBox();
            this.cbMergeTextFiles = new System.Windows.Forms.CheckBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.cbxGetDBGitGrantes = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbOutOracleGitDir = new System.Windows.Forms.TextBox();
            this.btExecute = new System.Windows.Forms.Button();
            this.cbxInputEncoding = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxOutputEncoding = new System.Windows.Forms.ComboBox();
            this.tbxRemoveDoublesMask = new System.Windows.Forms.TextBox();
            this.tabPanelOperations.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDir
            // 
            this.tbDir.Location = new System.Drawing.Point(123, 15);
            this.tbDir.Name = "tbDir";
            this.tbDir.Size = new System.Drawing.Size(865, 20);
            this.tbDir.TabIndex = 0;
            this.tbDir.Text = "e:\\tmp\\4\\res\\";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Папка с файлами:";
            // 
            // tabPanelOperations
            // 
            this.tabPanelOperations.Controls.Add(this.tabPage1);
            this.tabPanelOperations.Controls.Add(this.tabPage2);
            this.tabPanelOperations.Controls.Add(this.tabPage4);
            this.tabPanelOperations.Controls.Add(this.tabPage3);
            this.tabPanelOperations.Controls.Add(this.tabPage5);
            this.tabPanelOperations.Location = new System.Drawing.Point(13, 82);
            this.tabPanelOperations.Name = "tabPanelOperations";
            this.tabPanelOperations.SelectedIndex = 0;
            this.tabPanelOperations.Size = new System.Drawing.Size(979, 445);
            this.tabPanelOperations.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbUpperFirstLetterInComments);
            this.tabPage1.Controls.Add(this.cbUpperColNamesInComments);
            this.tabPage1.Controls.Add(this.cbTrimOracleTableColNames);
            this.tabPage1.Controls.Add(this.cbTrimOracleTableNames);
            this.tabPage1.Controls.Add(this.cbRemoveOracleAlters);
            this.tabPage1.Controls.Add(this.cbRemoveOracleIndexes);
            this.tabPage1.Controls.Add(this.cbOracleCreateInstallFile);
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
            // cbUpperFirstLetterInComments
            // 
            this.cbUpperFirstLetterInComments.AutoSize = true;
            this.cbUpperFirstLetterInComments.Checked = true;
            this.cbUpperFirstLetterInComments.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUpperFirstLetterInComments.Location = new System.Drawing.Point(7, 166);
            this.cbUpperFirstLetterInComments.Name = "cbUpperFirstLetterInComments";
            this.cbUpperFirstLetterInComments.Size = new System.Drawing.Size(605, 17);
            this.cbUpperFirstLetterInComments.TabIndex = 9;
            this.cbUpperFirstLetterInComments.Text = "Привести к верхнему регистру первую букву комментария в скрипте создания коммента" +
    "риев на таблицы и поля";
            this.cbUpperFirstLetterInComments.UseVisualStyleBackColor = true;
            // 
            // cbUpperColNamesInComments
            // 
            this.cbUpperColNamesInComments.AutoSize = true;
            this.cbUpperColNamesInComments.Checked = true;
            this.cbUpperColNamesInComments.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUpperColNamesInComments.Location = new System.Drawing.Point(7, 142);
            this.cbUpperColNamesInComments.Name = "cbUpperColNamesInComments";
            this.cbUpperColNamesInComments.Size = new System.Drawing.Size(491, 17);
            this.cbUpperColNamesInComments.TabIndex = 8;
            this.cbUpperColNamesInComments.Text = "Привести к верхнему регистру названия полей в скрипте создания комментариев на по" +
    "ля";
            this.cbUpperColNamesInComments.UseVisualStyleBackColor = true;
            // 
            // cbTrimOracleTableColNames
            // 
            this.cbTrimOracleTableColNames.AutoSize = true;
            this.cbTrimOracleTableColNames.Checked = true;
            this.cbTrimOracleTableColNames.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTrimOracleTableColNames.Location = new System.Drawing.Point(7, 122);
            this.cbTrimOracleTableColNames.Name = "cbTrimOracleTableColNames";
            this.cbTrimOracleTableColNames.Size = new System.Drawing.Size(364, 17);
            this.cbTrimOracleTableColNames.TabIndex = 7;
            this.cbTrimOracleTableColNames.Text = "Обрезать названия столбцов таблиц до 27 символов  (файлы .tab)";
            this.cbTrimOracleTableColNames.UseVisualStyleBackColor = true;
            // 
            // cbTrimOracleTableNames
            // 
            this.cbTrimOracleTableNames.AutoSize = true;
            this.cbTrimOracleTableNames.Checked = true;
            this.cbTrimOracleTableNames.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTrimOracleTableNames.Location = new System.Drawing.Point(7, 99);
            this.cbTrimOracleTableNames.Name = "cbTrimOracleTableNames";
            this.cbTrimOracleTableNames.Size = new System.Drawing.Size(314, 17);
            this.cbTrimOracleTableNames.TabIndex = 6;
            this.cbTrimOracleTableNames.Text = "Обрезать названия таблиц до 27 символов  (файлы .tab)";
            this.cbTrimOracleTableNames.UseVisualStyleBackColor = true;
            // 
            // cbRemoveOracleAlters
            // 
            this.cbRemoveOracleAlters.AutoSize = true;
            this.cbRemoveOracleAlters.Checked = true;
            this.cbRemoveOracleAlters.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRemoveOracleAlters.Location = new System.Drawing.Point(7, 76);
            this.cbRemoveOracleAlters.Name = "cbRemoveOracleAlters";
            this.cbRemoveOracleAlters.Size = new System.Drawing.Size(182, 17);
            this.cbRemoveOracleAlters.TabIndex = 5;
            this.cbRemoveOracleAlters.Text = "Удалить альтеры  (файлы .tab)";
            this.cbRemoveOracleAlters.UseVisualStyleBackColor = true;
            // 
            // cbRemoveOracleIndexes
            // 
            this.cbRemoveOracleIndexes.AutoSize = true;
            this.cbRemoveOracleIndexes.Checked = true;
            this.cbRemoveOracleIndexes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRemoveOracleIndexes.Location = new System.Drawing.Point(7, 53);
            this.cbRemoveOracleIndexes.Name = "cbRemoveOracleIndexes";
            this.cbRemoveOracleIndexes.Size = new System.Drawing.Size(180, 17);
            this.cbRemoveOracleIndexes.TabIndex = 4;
            this.cbRemoveOracleIndexes.Text = "Удалить индексы (файлы .tab)";
            this.cbRemoveOracleIndexes.UseVisualStyleBackColor = true;
            // 
            // cbOracleCreateInstallFile
            // 
            this.cbOracleCreateInstallFile.AutoSize = true;
            this.cbOracleCreateInstallFile.Checked = true;
            this.cbOracleCreateInstallFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOracleCreateInstallFile.Location = new System.Drawing.Point(7, 189);
            this.cbOracleCreateInstallFile.Name = "cbOracleCreateInstallFile";
            this.cbOracleCreateInstallFile.Size = new System.Drawing.Size(152, 17);
            this.cbOracleCreateInstallFile.TabIndex = 3;
            this.cbOracleCreateInstallFile.Text = "Создать файл \"install.sql\"";
            this.cbOracleCreateInstallFile.UseVisualStyleBackColor = true;
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
            this.cbRemoveOraclePartition.Size = new System.Drawing.Size(183, 17);
            this.cbRemoveOraclePartition.TabIndex = 0;
            this.cbRemoveOraclePartition.Text = "Удалить партиции (файлы .tab)";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Маски файлов для отбора";
            // 
            // tbFilesToDirMasks
            // 
            this.tbFilesToDirMasks.Location = new System.Drawing.Point(6, 23);
            this.tbFilesToDirMasks.Multiline = true;
            this.tbFilesToDirMasks.Name = "tbFilesToDirMasks";
            this.tbFilesToDirMasks.Size = new System.Drawing.Size(444, 390);
            this.tbFilesToDirMasks.TabIndex = 0;
            this.tbFilesToDirMasks.Text = "*.fnc\r\n*.pck;*.spc;*.bdy\r\n*.prc\r\n*.seq\r\n*.syn\r\n*.tab\r\n*.tps;*.typ\r\n*.trg\r\n*.vw;*." +
    "mvw";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(971, 419);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "ZIP";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbUnzip);
            this.groupBox1.Controls.Add(this.rbZip);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rbUnzip
            // 
            this.rbUnzip.AutoSize = true;
            this.rbUnzip.Checked = true;
            this.rbUnzip.Location = new System.Drawing.Point(6, 53);
            this.rbUnzip.Name = "rbUnzip";
            this.rbUnzip.Size = new System.Drawing.Size(240, 17);
            this.rbUnzip.TabIndex = 1;
            this.rbUnzip.TabStop = true;
            this.rbUnzip.Text = "Расжать из zip-строки содержимое файла";
            this.rbUnzip.UseVisualStyleBackColor = true;
            // 
            // rbZip
            // 
            this.rbZip.AutoSize = true;
            this.rbZip.Location = new System.Drawing.Point(7, 20);
            this.rbZip.Name = "rbZip";
            this.rbZip.Size = new System.Drawing.Size(221, 17);
            this.rbZip.TabIndex = 0;
            this.rbZip.Text = "Сжать в zip-строку содержимое файла";
            this.rbZip.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tbxRemoveDoublesMask);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.cbRemoveIntermediateDoubles);
            this.tabPage3.Controls.Add(this.cbMergeTextFiles);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(971, 419);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Разное";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Шаблон поиска:";
            // 
            // cbRemoveIntermediateDoubles
            // 
            this.cbRemoveIntermediateDoubles.AutoSize = true;
            this.cbRemoveIntermediateDoubles.Location = new System.Drawing.Point(14, 38);
            this.cbRemoveIntermediateDoubles.Name = "cbRemoveIntermediateDoubles";
            this.cbRemoveIntermediateDoubles.Size = new System.Drawing.Size(226, 17);
            this.cbRemoveIntermediateDoubles.TabIndex = 2;
            this.cbRemoveIntermediateDoubles.Text = "Удалить промежуточные дубли файлов";
            this.cbRemoveIntermediateDoubles.UseVisualStyleBackColor = true;
            // 
            // cbMergeTextFiles
            // 
            this.cbMergeTextFiles.AutoSize = true;
            this.cbMergeTextFiles.Location = new System.Drawing.Point(14, 15);
            this.cbMergeTextFiles.Name = "cbMergeTextFiles";
            this.cbMergeTextFiles.Size = new System.Drawing.Size(266, 17);
            this.cbMergeTextFiles.TabIndex = 1;
            this.cbMergeTextFiles.Text = "Объединить текстовые файлы из папки в один";
            this.cbMergeTextFiles.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.cbxGetDBGitGrantes);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.tbOutOracleGitDir);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(971, 419);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Oracle Git";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // cbxGetDBGitGrantes
            // 
            this.cbxGetDBGitGrantes.AutoSize = true;
            this.cbxGetDBGitGrantes.Location = new System.Drawing.Point(9, 59);
            this.cbxGetDBGitGrantes.Name = "cbxGetDBGitGrantes";
            this.cbxGetDBGitGrantes.Size = new System.Drawing.Size(206, 17);
            this.cbxGetDBGitGrantes.TabIndex = 4;
            this.cbxGetDBGitGrantes.Text = "Вытащить гранты из структуры БД";
            this.cbxGetDBGitGrantes.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Папка с результатом:";
            // 
            // tbOutOracleGitDir
            // 
            this.tbOutOracleGitDir.Location = new System.Drawing.Point(143, 15);
            this.tbOutOracleGitDir.Name = "tbOutOracleGitDir";
            this.tbOutOracleGitDir.Size = new System.Drawing.Size(819, 20);
            this.tbOutOracleGitDir.TabIndex = 2;
            this.tbOutOracleGitDir.Text = "e:\\tmp\\2023-12-20\\1\\only_text_test_res\\";
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
            // tbxRemoveDoublesMask
            // 
            this.tbxRemoveDoublesMask.Location = new System.Drawing.Point(106, 61);
            this.tbxRemoveDoublesMask.Name = "tbxRemoveDoublesMask";
            this.tbxRemoveDoublesMask.Size = new System.Drawing.Size(813, 20);
            this.tbxRemoveDoublesMask.TabIndex = 6;
            this.tbxRemoveDoublesMask.Text = "Report_Прослеживаемость. Статистика";
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
            this.tabPage4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
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
        private System.Windows.Forms.CheckBox cbOracleCreateInstallFile;
        private System.Windows.Forms.CheckBox cbRemoveOracleIndexes;
        private System.Windows.Forms.CheckBox cbRemoveOracleAlters;
        private System.Windows.Forms.CheckBox cbTrimOracleTableNames;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFilesToDirDirs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFilesToDirMasks;
        private System.Windows.Forms.CheckBox cbTrimOracleTableColNames;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbUnzip;
        private System.Windows.Forms.RadioButton rbZip;
        private System.Windows.Forms.CheckBox cbUpperColNamesInComments;
        private System.Windows.Forms.CheckBox cbUpperFirstLetterInComments;
        private System.Windows.Forms.CheckBox cbMergeTextFiles;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.CheckBox cbxGetDBGitGrantes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbOutOracleGitDir;
        private System.Windows.Forms.CheckBox cbRemoveIntermediateDoubles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxRemoveDoublesMask;
    }
}

