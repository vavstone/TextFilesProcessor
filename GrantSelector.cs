using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TextFilesProcessor
{
    public static class GrantSelector
    {
        public static void Process(string sourceRoot, string targetDir)
        {
            try
            {
                // Создаем целевую папку, если не существует
                EnsureDirectoryExists(targetDir);

                // Шаг 0: Обработка исходной папки с подпапками (в памяти)
                var intermediateData = ProcessStep0(sourceRoot);

                // Шаг 1: Обработка данных в памяти
                ProcessStep1(intermediateData, targetDir);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        static void EnsureDirectoryExists(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        static Dictionary<string, List<string>> ProcessStep0(string sourceRoot)
        {
            // Проверка исходной папки
            if (!Directory.Exists(sourceRoot))
                throw new DirectoryNotFoundException("Исходная папка не существует");

            // Получение всех подпапок первого уровня
            string[] subdirectories = Directory.GetDirectories(sourceRoot);
            var pattern = new Regex(@"grant\s+.+?\sto\s+([a-zA-Z0-9_]+)(?:\s+with\s+grant\s+option)?\s*;", RegexOptions.IgnoreCase);

            // Имя исходной папки (для формирования имен)
            string sourceFolderName = new DirectoryInfo(sourceRoot).Name;

            // Словарь для хранения промежуточных данных
            var intermediateData = new Dictionary<string, List<string>>();

            foreach (string subdir in subdirectories)
            {
                // Получаем имя подпапки
                string subdirName = new DirectoryInfo(subdir).Name;

                // Формируем ключ для данных
                string dataKey = $"{sourceFolderName}_{subdirName}";

                // Список для найденных строк
                var matchedLines = new List<string>();

                // Обрабатываем все файлы в подпапке (не только .txt)
                string[] files = Directory.GetFiles(subdir);
                foreach (string file in files)
                {
                    try
                    {
                        // Читаем все строки файла (независимо от расширения)
                        string[] lines = File.ReadAllLines(file);
                        foreach (string line in lines)
                        {
                            if (!string.IsNullOrWhiteSpace(line) && pattern.IsMatch(line))
                            {
                                matchedLines.Add(line);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Пропускаем файлы, которые не удалось прочитать
                        MessageBox.Show($"Ошибка при чтении файла {file}: {ex.Message}");
                    }
                }

                // Сохраняем данные только если есть строки
                if (matchedLines.Count > 0)
                {
                    intermediateData[dataKey] = matchedLines;
                }
            }

            return intermediateData;
        }

        static void ProcessStep1(Dictionary<string, List<string>> intermediateData, string targetDir)
        {
            var pattern = new Regex(@"grant\s+.+?\sto\s+([a-zA-Z0-9_]+)(?:\s+with\s+grant\s+option)?\s*;", RegexOptions.IgnoreCase);

            foreach (var dataItem in intermediateData)
            {
                string fileName = dataItem.Key;
                var lines = dataItem.Value
                    .Where(line => !string.IsNullOrWhiteSpace(line))
                    .ToArray();

                // Пропускаем пустые наборы данных
                if (lines.Length == 0)
                {
                    continue;
                }

                var keywordLines = new Dictionary<string, HashSet<string>>();
                var otherLines = new List<string>();

                foreach (string line in lines)
                {
                    Match match = pattern.Match(line);
                    if (match.Success)
                    {
                        string keyword = match.Groups[1].Value;

                        if (!keywordLines.ContainsKey(keyword))
                            keywordLines[keyword] = new HashSet<string>();

                        keywordLines[keyword].Add(line);
                    }
                    else
                    {
                        otherLines.Add(line);
                    }
                }

                // Проверяем, есть ли что-то для записи
                bool hasContent = keywordLines.Any(kvp => kvp.Value.Count > 0) || otherLines.Count > 0;
                if (!hasContent)
                {
                    continue;
                }

                // Формируем имя выходного файла
                string outputFile = Path.Combine(targetDir, $"{fileName}.txt");

                // Записываем данные в файл
                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    // Записываем блоки для ключевых слов
                    foreach (var kvp in keywordLines.OrderBy(k => k.Key))
                    {
                        if (kvp.Value.Count > 0)
                        {
                            // Заголовок блока
                            writer.WriteLine($"-------------------------------{kvp.Key}----------------------------------------");

                            // Строки блока
                            foreach (string line in kvp.Value)
                            {
                                writer.WriteLine(line);
                            }

                            // Пустая строка после блока
                            writer.WriteLine();
                        }
                    }

                    // Записываем блок для неподходящих строк (если есть)
                    if (otherLines.Count > 0)
                    {
                        writer.WriteLine($"-------------------------------OTHER----------------------------------------");
                        foreach (string line in otherLines)
                        {
                            writer.WriteLine(line);
                        }
                        writer.WriteLine();
                    }
                }
            }
        }
    }
}
