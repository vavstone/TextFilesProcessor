using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilesProcessor
{
    public static class FilesUtils
    {
        public static List<string> GetFilesNamesInDir(string dir)
        {
            return Directory.GetFiles(dir).ToList();
        }

        public static string GetText(string fileName, string inputFilesEncoding)
        {
            if (inputFilesEncoding== "Windows 1251")
                return File.ReadAllText(fileName, Encoding.GetEncoding(1251));
            else
                return File.ReadAllText(fileName);
        }

        public static void SaveText(string fileName, string text, string outputFilesEncoding)
        {
            if (outputFilesEncoding == "Windows 1251")
                File.WriteAllText(fileName, text, Encoding.GetEncoding(1251));
            else
                File.WriteAllText(fileName, text);
        }

        public static List<string> GetDirsWithFilesInParentDir(string parentDir)
        {
            //List<string> result  = new List<string>();
            return Directory.GetDirectories(parentDir, "*", SearchOption.AllDirectories).
                Where(c=>Directory.GetFiles(c).Length!=0).ToList();
            
        }

    }
}
