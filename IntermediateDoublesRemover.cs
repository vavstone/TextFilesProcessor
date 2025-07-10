using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using OfficeOpenXml;

namespace TextFilesProcessor
{
    public static class IntermediateDoublesRemover
    {
        public static void Process(string sourceFolder, string targetFolder)
        {
            ExcelPackage.License.SetNonCommercialOrganization("My Noncommercial organization");

            // Создание целевой папки при необходимости
            if (!Directory.Exists(targetFolder))
            {
                Directory.CreateDirectory(targetFolder);
            }

            try
            {
                // Получение и сортировка XLSX-файлов по дате создания
                var files = new DirectoryInfo(sourceFolder)
                    .GetFiles("*.xlsx")
                    .OrderBy(f => f.CreationTime)
                    .ToList();

                if (files.Count == 0)
                {
                    MessageBox.Show("В исходной папке не найдено XLSX-файлов.");
                    return;
                }

                // Группировка файлов по последовательным наборам
                var groups = new List<FileGroup>();
                var currentGroup = new FileGroup(files[0]);

                for (int i = 1; i < files.Count; i++)
                {
                    if (ExcelComparer.FilesEqual(currentGroup.FirstFile, files[i]))
                    {
                        currentGroup.AddFile(files[i]);
                    }
                    else
                    {
                        groups.Add(currentGroup);
                        currentGroup = new FileGroup(files[i]);
                    }
                }
                groups.Add(currentGroup);

                // Копирование файлов в целевую папку
                foreach (var group in groups)
                {
                    group.CopyFirstAndLast(targetFolder);
                }

                //MessageBox.Show($"Обработано: {files.Count} файлов, создано {groups.Sum(g => g.FileCount)} групп");
                //MessageBox.Show("Копирование завершено успешно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }


    class FileGroup
    {
        public FileInfo FirstFile { get; }
        public FileInfo LastFile { get; private set; }
        public int FileCount { get; private set; } = 1;

        public FileGroup(FileInfo file)
        {
            FirstFile = file;
            LastFile = file;
        }

        public void AddFile(FileInfo file)
        {
            LastFile = file;
            FileCount++;
        }

        public void CopyFirstAndLast(string targetFolder)
        {
            CopyFile(FirstFile, targetFolder);
            if (FileCount > 1)
            {
                CopyFile(LastFile, targetFolder);
            }
        }

        private void CopyFile(FileInfo file, string targetFolder)
        {
            string destPath = Path.Combine(targetFolder, file.Name);
            if (!File.Exists(destPath))
            {
                file.CopyTo(destPath);
            }
        }
    }

    static class ExcelComparer
    {
        public static bool FilesEqual(FileInfo file1, FileInfo file2)
        {
            try
            {
                using (var package1 = new ExcelPackage(file1))
                {
                    using (var package2 = new ExcelPackage(file2))
                    {
                        var workbook1 = package1.Workbook;
                        var workbook2 = package2.Workbook;

                        if (workbook1.Worksheets.Count != workbook2.Worksheets.Count)
                            return false;

                        for (int sheetIndex = 0; sheetIndex < workbook1.Worksheets.Count; sheetIndex++)
                        {
                            var sheet1 = workbook1.Worksheets[sheetIndex];
                            var sheet2 = workbook2.Worksheets[sheetIndex];

                            if (sheet1.Name != sheet2.Name)
                                return false;

                            if (!SheetsEqual(sheet1, sheet2))
                                return false;
                        }

                        return true;
                    }
                }



                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private static bool SheetsEqual(ExcelWorksheet sheet1, ExcelWorksheet sheet2)
        {
            var dimension1 = sheet1.Dimension;
            var dimension2 = sheet2.Dimension;

            if (dimension1 == null && dimension2 == null)
                return true;
            if (dimension1 == null || dimension2 == null)
                return false;

            if (dimension1.Start.Row != dimension2.Start.Row ||
                dimension1.Start.Column != dimension2.Start.Column ||
                dimension1.End.Row != dimension2.End.Row ||
                dimension1.End.Column != dimension2.End.Column)
            {
                return false;
            }

            for (int row = dimension1.Start.Row; row <= dimension1.End.Row; row++)
            {
                for (int col = dimension1.Start.Column; col <= dimension1.End.Column; col++)
                {
                    var cell1 = sheet1.Cells[row, col];
                    var cell2 = sheet2.Cells[row, col];

                    // Проверка на ошибки в ячейках
                    bool isError1 = IsCellError(cell1);
                    bool isError2 = IsCellError(cell2);

                    if (isError1 || isError2)
                    {
                        if (isError1 != isError2 || cell1.Text != cell2.Text)
                            return false;
                        continue;
                    }

                    // Сравнение значений
                    if (!ObjectsEqual(cell1.Value, cell2.Value))
                        return false;
                }
            }

            return true;
        }

        private static bool IsCellError(ExcelRange cell)
        {
            return cell.Value == null ? false : ExcelErrorValue.Values.IsErrorValue(cell.Value.ToString());
        }

        private static bool ObjectsEqual(object obj1, object obj2)
        {
            if (obj1 == null && obj2 == null)
                return true;
            if (obj1 == null || obj2 == null)
                return false;

            if (obj1 is double d1 && obj2 is double d2)
                return Math.Abs(d1 - d2) < double.Epsilon;

            if (obj1 is float f1 && obj2 is float f2)
                return Math.Abs(f1 - f2) < float.Epsilon;

            if (obj1 is decimal dec1 && obj2 is decimal dec2)
                return dec1 == dec2;

            if (obj1 is DateTime dt1 && obj2 is DateTime dt2)
                return dt1.Equals(dt2);

            if (obj1 is string s1 && obj2 is string s2)
                return s1 == s2;

            if (obj1 is bool b1 && obj2 is bool b2)
                return b1 == b2;

            return obj1.Equals(obj2);
        }
    }
}

