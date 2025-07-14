using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using OfficeOpenXml;

namespace TextFilesProcessor
{
    public static class IntermediateDoublesRemoverOld
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


    class FileGroupOld
    {
        public FileInfo FirstFile { get; }
        public FileInfo LastFile { get; private set; }
        public int FileCount { get; private set; } = 1;

        public FileGroupOld(FileInfo file)
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
}

