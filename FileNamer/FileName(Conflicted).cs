using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileNamer
{
    public class FileName
    {
        public string Name;
        public string Path;

        public FileName( string path, string name)
        {
            Name = name;
            Path = path;
        }

        public string FullName { get { return GetFilePath(Path, Name); } }


        public static string GetFilePath(string folderPath, string fileName)
        {
            string filePath = folderPath + "\\" + fileName;
            return filePath;
        }

    }
}
