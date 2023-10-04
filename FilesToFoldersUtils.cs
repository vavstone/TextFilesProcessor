using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFilesProcessor
{
    public static class FilesToFoldersUtils
    {
        public static void MoveFilesToDirsByMask(string dirWithFiles, Dictionary<string,string> mapping)
        {
            foreach (var mask in mapping.Keys)
            {
                var maskArr = mask.Split( new []{';'}, StringSplitOptions.RemoveEmptyEntries);
                var newDirName = Path.Combine(dirWithFiles, mapping[mask]);
                if (!Directory.Exists(newDirName))
                    Directory.CreateDirectory(newDirName);
                foreach (var maskEl in maskArr)
                {
                    var files = Directory.GetFiles(dirWithFiles, maskEl);
                    if (files.Any())
                    {
                        foreach (var file in files)
                        {
                            var newFileName = Path.Combine(newDirName, Path.GetFileName(file));
                            File.Move(file, newFileName);
                        }
                    }
                }
                
            }
        }
    }
}
