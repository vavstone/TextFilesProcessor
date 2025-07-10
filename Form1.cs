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
                        bool needRewrite = false;
                        var fileExtension = Path.GetExtension(file);
                        var isTabExtension = fileExtension.ToUpper() == ".TAB";
                        var fileText = FilesUtils.GetText(file, inputFilesEncoding);
                        if (cbRemoveOraclePartition.Checked && isTabExtension)
                        {
                            fileText = fileText.RemoveOraclePartitions();
                            needRewrite = true;
                        }

                        if (cbRemoveOracleGrants.Checked)
                        {
                            fileText = fileText.RemoveOracleGrants();
                            needRewrite = true;
                        }

                        if (cbRemoveOracleIndexes.Checked && isTabExtension)
                        {
                            fileText = fileText.RemoveOracleIndexes();
                            needRewrite = true;
                        }

                        if (cbRemoveOracleAlters.Checked && isTabExtension)
                        {
                            fileText = fileText.RemoveOracleAlter();
                            needRewrite = true;
                        }

                        if (cbTrimOracleTableNames.Checked && isTabExtension)
                        {
                            fileText = fileText.TrimTo27OracleTableNames(5, '#');
                            needRewrite = true;
                        }

                        if (cbTrimOracleTableColNames.Checked && isTabExtension)
                        {
                            fileText = fileText.TrimTo27OracleTableColumnNames(5, '#');
                            needRewrite = true;
                        }

                        if (cbUpperColNamesInComments.Checked)
                        {
                            fileText = fileText.UpperColNamesInComments();
                            needRewrite = true;
                        }

                        if (cbUpperFirstLetterInComments.Checked)
                        {
                            fileText = fileText.UpperFirstLetterInComments();
                            needRewrite = true;
                        }

                        if (needRewrite)
                            FilesUtils.SaveText(file, fileText, outputFilesEncoding);
                    }

                    if (cbOracleCreateInstallFile.Checked)
                    {
                        var installFileContent =
                            OracleUtils.GetInstallFileContent(dir);
                        FilesUtils.SaveText(OracleUtils.GetInstallFileName(dir), installFileContent,
                            outputFilesEncoding);
                    }
                }

            }
            else if (selectedTab == 1)
            {
                var dirs = FilesUtils.GetDirsWithFilesInParentDir(tbDir.Text);
                var settings = GetFilesToDirSettings();
                foreach (var dir in dirs)
                {
                    FilesToFoldersUtils.MoveFilesToDirsByMask(dir, settings);
                }
            }
            //ZIP
            else if (selectedTab == 2)
            {
                var isZip = rbZip.Checked;
                var filePostfix = isZip ? "_zipped" : "_unzipped";
                var dirs = FilesUtils.GetDirsWithFilesInParentDir(tbDir.Text);
                foreach (var dir in dirs)
                {
                    foreach (var file in FilesUtils.GetFilesNamesInDir(dir))
                    {
                        var fileOnlyName = Path.GetFileNameWithoutExtension(file);
                        var fileOnlyPath = Path.GetDirectoryName(file);
                        var fileExt = Path.GetExtension(file);
                        var newFileOnlyName = fileOnlyName + filePostfix;
                        var newFileFullName = Path.Combine(fileOnlyPath, newFileOnlyName + fileExt);
                        var fileContent = FilesUtils.GetText(file, null);
                        var newFileContent = "";
                        if (!isZip)
                            newFileContent = ZipHelper.DecompressString(fileContent);
                        else
                            newFileContent = ZipHelper.CompressString(fileContent);
                        FilesUtils.SaveText(newFileFullName, newFileContent, null);

                    }
                }
            }
            //Other
            else if (selectedTab == 3)
            {
                if (cbMergeTextFiles.Checked)
                {
                    var inputFilesEncoding = cbxInputEncoding.Text;
                    var outputFilesEncoding = cbxOutputEncoding.Text;
                    var dirs2 = FilesUtils.GetDirsWithFilesInParentDir(tbDir.Text);
                    var resText = new StringBuilder();
                    foreach (var dir in dirs2)
                    {
                        foreach (var file in FilesUtils.GetFilesNamesInDir(dir))
                        {
                            var fileText = FilesUtils.GetText(file, inputFilesEncoding);
                            resText.Append(fileText);
                        }
                    }
                    var newFileName = FilesUtils.GetUniqueTxtFileName(tbDir.Text);
                        FilesUtils.SaveText(Path.Combine(tbDir.Text,newFileName), resText.ToString(), outputFilesEncoding);
                }
                if (cbRemoveIntermediateDoubles.Checked)
                {
                    IntermediateDoublesRemover.Process(tbDir.Text, tbTab3Result.Text);
                }
            }
            //Oracle Git обработка 
            else if (selectedTab == 4)
            {
                if (cbxGetDBGitGrantes.Checked)
                {
                    GrantSelector.Process(tbDir.Text, tbOutOracleGitDir.Text);
                }
            }
            MessageBox.Show("Готово!");

            Dictionary<string, string> GetFilesToDirSettings()
            {
                var res = new Dictionary<string, string>();
                var masks = tbFilesToDirMasks.Text.Split('\r');
                var dirs = tbFilesToDirDirs.Text.Split('\r');
                for (var i = 0; i < masks.Length; i++)
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
}
