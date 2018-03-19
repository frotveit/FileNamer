

using System.IO;
using System.Collections.Generic;
using FileNamerCore.DataTypes;
using FileNamerCore.Interfaces;

namespace FileNamerCore
{  


    /// <summary>
    /// Wrapper for file system 
    /// </summary>
    public class FileWrapper : IFileWrapper
    {
        public List<string> GetFolderFiles(string folderPath)
        {
            string[] files = Directory.GetFiles(folderPath);
            List<string> fileList = new List<string>();
            foreach (string filePath in files)
            {
                string fileName = filePath.Substring(folderPath.Length + 1);
                fileList.Add(fileName);
            }
            return fileList;
        }

        public List<string> GetFileList(string folderPath)
        {
            DirectoryInfo folder = new DirectoryInfo(folderPath);

            List<string> fileList = new List<string>();

            if (!folder.Exists)
                return fileList;

            foreach (FileInfo file in folder.GetFiles())
                fileList.Add(file.Name);

            return fileList;
        }

        public List<FileInformation> GetFileInformationList(string folderPath)
        {
            DirectoryInfo folder = new DirectoryInfo(folderPath);

            List<FileInformation> fileList = new List<FileInformation>();

            if (!folder.Exists)
                return fileList;

            foreach (FileInfo file in folder.GetFiles())
            {
                var info = new FileInformation(file);
                info.Path = folderPath;
                fileList.Add(info);
            }
            return fileList;
        }

        public IEnumerable<FileInfo> GetFilesInfo(string folderPath)
        {
            DirectoryInfo folder = new DirectoryInfo(folderPath);
            FileInfo[] files = folder.GetFiles();
            return files;
        }

        public void RenameFile(FileName oldFile, FileName newFile)
        {
            FileInfo file = new FileInfo(oldFile.FullName);

            // Skip hidden files and thumbs file
            if ((file.Attributes & FileAttributes.Hidden) == 0
                && oldFile.Name != "Thumbs.db")
            {

                File.Move(oldFile.FullName, newFile.FullName);
            }
        }

    }
}
