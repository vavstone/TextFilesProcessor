using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TextFilesProcessor
{
    public static class OracleUtils
    {
        private static int maxObjectNameLength = 27;
        public static string RemoveOraclePartitions(this string text)
        {
            if (text == null)
                return null;
            string tmpText = text;
            var indexOfPartionBy = tmpText.IndexOf("partition by");
            if (indexOfPartionBy > -1)
            {
                var indexOfSemicolon = tmpText.IndexOf(";", indexOfPartionBy);
                if (indexOfSemicolon > -1)
                {
                    tmpText = tmpText.Substring(0, indexOfPartionBy) + tmpText.Substring(indexOfSemicolon);
                }
            }
            return tmpText;
        }

        public static string RemoveOracleGrants(this string text)
        {
            return text.RemoveFromSymbolsToSemicolon("grant ");
        }

        public static string RemoveOracleNologgingLocal(this string text)
        {
            if (text == null)
                return null;
            string tmpText = text;
            while (true)
            {
                var indexOfNologgingLocal = tmpText.IndexOf(Environment.NewLine + "  nologging  local");
                if (indexOfNologgingLocal > -1)
                {
                    var indexOfSemicolon = tmpText.IndexOf(";", indexOfNologgingLocal);
                    if (indexOfSemicolon > -1)
                    {
                        tmpText = tmpText.Substring(0, indexOfNologgingLocal) + tmpText.Substring(indexOfSemicolon);
                    }
                }
                else
                {
                    break;
                }
            }
            return tmpText;
        }

        public static string RemoveOracleIndexes(this string text)
        {
            return text.RemoveFromSymbolsToSemicolon("create index ");
        }

        public static string RemoveOracleAlter(this string text)
        {
            return text.RemoveFromSymbolsToSemicolon("alter table ");
        }

        /// <summary>
        /// Перевод в верхний регистр названий полей в скрипте создания комментов, например "comment on column BUF_TRF_R018_RKT.enforcepay  is 'Взыскано';" -> "comment on column BUF_TRF_R018_RKT.ENFORCEPAY  is 'Взыскано'";
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string UpperColNamesInComments(this string text)
        {
            if (text == null)
                return null;
            StringBuilder tmpText = new StringBuilder();
            var startSymbols = "comment on column ";
            var strIs = " is ";
            using (var reader = new StringReader(text))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var newLine = line;
                    if (line.StartsWith(startSymbols))
                    {
                        var indexOfComma = line.IndexOf(".");
                        if (indexOfComma > -1)
                        {
                            var indexOfStrIs = line.IndexOf(strIs);
                            if (indexOfStrIs > -1)
                            {
                                newLine =
                                    line.Substring(0, indexOfComma + 1) +
                                    line.Substring(indexOfComma + 1, indexOfStrIs - indexOfComma - 1).ToUpper() +
                                    line.Substring(indexOfStrIs);
                            }
                        }
                    }
                    tmpText.AppendLine(newLine);
                }
            }
            return tmpText.ToString();
        }

        /// <summary>
        /// Перевод в верхний регистр первой буквы в скрипте создания комментов, например "comment on column BUF_TRF_R018_RKT.G07 is 'номер ДТ';" -> "comment on column BUF_TRF_R018_RKT.G07 is 'Номер ДТ';";
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string UpperFirstLetterInComments(this string text)
        {
            if (text == null)
                return null;
            StringBuilder tmpText = new StringBuilder();
            var startSymbols = "comment on ";
            var strIs = " is '";
            using (var reader = new StringReader(text))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var newLine = line;
                    if (line.StartsWith(startSymbols))
                    {
                        var indexOfstrIs = line.IndexOf(strIs);
                        if (indexOfstrIs > -1)
                        {
                            
                                newLine =
                                    line.Substring(0, indexOfstrIs + strIs.Length) +
                                    line.Substring(indexOfstrIs + strIs.Length, 1).ToUpper() +
                                    line.Substring(indexOfstrIs + strIs.Length + 1);
                            
                        }
                    }
                    tmpText.AppendLine(newLine);
                }
            }
            return tmpText.ToString();
        }


        /// <summary>
        /// Удаление последовательностей символов, начинающихся с новой строки и завершающихся точкой с запятой
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static string RemoveFromSymbolsToSemicolon(this string text, string startSymbols)
        {
            if (text == null)
                return null;
            string tmpText = text;
            while (true)
            {
                var indexOfStart = tmpText.IndexOf(Environment.NewLine + startSymbols);
                if (indexOfStart > -1)
                {
                    var indexOfSemicolon = tmpText.IndexOf(";", indexOfStart);
                    if (indexOfSemicolon > -1)
                    {
                        tmpText = tmpText.Substring(0, indexOfStart) + tmpText.Substring(indexOfSemicolon + 1);
                    }
                }
                else
                {
                    break;
                }
            }
            return tmpText;
        }

        public static string GetInstallFileContent(string dir)
        {
            var filesToExecute = FilesUtils.GetFilesNamesInDir(dir);
            string template =
                @"spool install.log
DEFINE RootPath = '{0}'
{1}
prompt Done
spool off";
            string add = "";
            foreach (var file in filesToExecute)
            {
                var fileName = Path.GetFileName(file);
                add += "prompt Executing " + fileName + Environment.NewLine;
                add += "@@&&RootPath\\" + fileName + Environment.NewLine;
            }
            return string.Format(template, dir.TrimEnd('\\'), add);
        }

        public static string GetInstallFileName(string dir)
        {
            return Path.Combine(dir, "install.sql");
        }

        public static string TrimTo27OracleTableNames(this string text, int startPosToReplace, char replaceSymbol)
        {
            if (text == null)
                return null;
            var startString = "create table ";
            var indexOfCreateTable = text.IndexOf(startString);
            if (indexOfCreateTable < 0)
            {
                startString = "create global temporary table ";
            }
            indexOfCreateTable = text.IndexOf(startString);
            if (indexOfCreateTable > -1)
            {
                var indexOfBracket = text.IndexOf("(", indexOfCreateTable);
                if (indexOfBracket > -1)
                {
                    var strLength = indexOfBracket - indexOfCreateTable - startString.Length;
                    var tableName = text.Substring(indexOfCreateTable+ startString.Length, strLength).Trim();
                    if (tableName.Length > maxObjectNameLength)
                    {
                        var newTableName = GetNewObjectName(tableName, startPosToReplace, replaceSymbol);
                        return text.Replace(tableName, newTableName);
                    }
                }
            }
            return text;
        }

        public static string TrimTo27OracleTableColumnNames(this string text, int startPosToReplace, char replaceSymbol)
        {
            if (text == null)
                return null;
            var colNamesToReplace = new Dictionary<string, string>();
            var startString = "create table ";
            var indexOfCreateTable = text.IndexOf(startString);
            if (indexOfCreateTable < 0)
            {
                startString = "create global temporary table ";
            }
            indexOfCreateTable = text.IndexOf(startString);
            if (indexOfCreateTable > -1)
            {
                var indexOfBracket = text.IndexOf("(", indexOfCreateTable);
                if (indexOfBracket > -1)
                {
                    var indexOfSemicolon = text.IndexOf(";", indexOfBracket);
                    var indexOfNewString = indexOfBracket;
                    while (true)
                    {
                        indexOfNewString = text.IndexOf(Environment.NewLine, indexOfNewString+1);
                        if (indexOfNewString > -1 && indexOfNewString< indexOfSemicolon-5)
                        {
                            var indexOfType =
                                FindNearestStringIndex(text, new List<string> {"NUMBER","DATE","VARCHAR2", "TIMESTAMP" }, indexOfNewString);
                            if (indexOfType > -1)
                            {
                                var colname = text.Substring(indexOfNewString, indexOfType - indexOfNewString).Trim();
                                if (colname.Length > maxObjectNameLength)
                                {
                                    var newColName = GetNewObjectName(colname, startPosToReplace, replaceSymbol);
                                    colNamesToReplace[colname] = newColName;
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                    }

                }
            }

            var newText = text;
            foreach (var colName in colNamesToReplace.Keys)
            {
                var newColName = colNamesToReplace[colName];
                newText = newText.Replace(" " + colName + " ", " " + newColName + " ");
                newText = newText.Replace("." + colName + Environment.NewLine, "." + newColName + Environment.NewLine);
            }
            return newText;
        }

        static string GetNewObjectName(string tableName,int startPosToReplace, char replaceSymbol)
        {
            if (tableName.Length <= maxObjectNameLength) return tableName;
            var diff = tableName.Length - maxObjectNameLength;
            var newTableName = tableName.Substring(0, startPosToReplace) +
                               replaceSymbol +
                               tableName.Substring(startPosToReplace + 1 + diff);
            return newTableName;
        }

        static int FindNearestStringIndex(string sourceText, List<string> stringsToFind, int startPosToFind)
        {
            var minIndex = -1;
            foreach (var str in stringsToFind)
            {
                var curIndex = sourceText.IndexOf(str, startPosToFind);
                if (curIndex!=-1 && (minIndex == -1 || curIndex < minIndex))
                    minIndex = curIndex;
            }
            return minIndex;
        }
    }
}
