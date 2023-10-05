using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFilesProcessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btExecute_Click(object sender, EventArgs e)
        {
            var selectedTab = tabPanelOperations.SelectedIndex;
            if (selectedTab == 0)
            {
                var inputFilesEncoding = cbxInputEncoding.Text;
                var outputFilesEncoding = cbxOutputEncoding.Text;
                var dirs = FilesUtils.GetDirsWithFilesInParentDir(tbDir.Text);
                foreach (var dir in dirs)
                {
                    foreach (var file in FilesUtils.GetFilesNamesInDir(dir))
                    {
                        var fileExtension = Path.GetExtension(file);
                        var isTabExtension = fileExtension.ToUpper() == ".TAB";
                        var fileText = FilesUtils.GetText(file, inputFilesEncoding);
                        if (cbRemoveOraclePartition.Checked && isTabExtension)
                            fileText = fileText.RemoveOraclePartitions();
                        if (cbRemoveOracleGrants.Checked)
                            fileText = fileText.RemoveOracleGrants();
                        if (cbRemoveOracleIndexes.Checked && isTabExtension)
                            fileText = fileText.RemoveOracleIndexes();
                        if (cbRemoveOracleAlters.Checked && isTabExtension)
                            fileText = fileText.RemoveOracleAlter();
                        if (cbTrimOracleTableNames.Checked && isTabExtension)
                            fileText = fileText.TrimTo27OracleTableNames(5, '#');
                        FilesUtils.SaveText(file, fileText, outputFilesEncoding);
                    }

                    if (cbRemoveOracleCreateInstallFile.Checked)
                    {
                        var installFileContent =
                            OracleUtils.GetInstallFileContent(FilesUtils.GetFilesNamesInDir(dir));
                        FilesUtils.SaveText(OracleUtils.GetInstallFileName(dir), installFileContent,
                            outputFilesEncoding);
                    }
                }
                
            }
            else if (selectedTab==1)
            {
                var dirs = FilesUtils.GetDirsWithFilesInParentDir(tbDir.Text);
                var settings = GetFilesToDirSettings();
                foreach (var dir in dirs)
                {
                    FilesToFoldersUtils.MoveFilesToDirsByMask(dir, settings);
                }
            }

            MessageBox.Show("Готово!");
        }

        Dictionary<string, string> GetFilesToDirSettings()
        {
            var res = new Dictionary<string, string>();
            var masks = tbFilesToDirMasks.Text.Split('\r');
            var dirs = tbFilesToDirDirs.Text.Split('\r');
            for (var i=0;i<masks.Length;i++)
            {
                var mask = masks[i].Trim();
                if (dirs.Length > i)
                {
                    var dir = dirs[i].Trim();
                    res[mask.Trim()] = dir;
                }
            }
            return res;
        }
    }
}
