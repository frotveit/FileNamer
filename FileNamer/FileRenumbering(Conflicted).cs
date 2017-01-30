using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileNamer
{
    public enum SortDateType
    {
        Created,
        LastChanged
    }

    public class FileRenumbering
    {
        private IFileWrapper _fileWrapper;
        public FileRenumbering(IFileWrapper fileWrapper)
        {
            _fileWrapper = fileWrapper;
        }


        public DateTime GetSortDate(FileInfo file, SortDateType sortDate)
        {
            switch (sortDate)
            {
                case SortDateType.Created:
                    return file.CreationTime;
                case SortDateType.LastChanged:
                    return file.LastWriteTime;
            }

            return file.CreationTime;
        }

                
        public void RenumberFolder( string folderPath , bool useDatePrefix, 
            string commonFileName, bool useExistingFileName, int removePrefixLength, SortDateType sortDateType)
        {
            SortedList<DateTime, FileInfo> sortedFiles = GetFilesSortedByDate(folderPath, sortDateType);

            int count = 0;
            foreach (KeyValuePair<DateTime, FileInfo> fileCont in sortedFiles)
            {
                FileInfo file = fileCont.Value;
                string oldFileName = file.Name;
                FileName oldFile = new FileName(folderPath, oldFileName);

                DateTime date = GetSortDate(file, sortDateType);
                string newFileName = GetNewFileNameForRenumber(useDatePrefix, commonFileName, useExistingFileName, removePrefixLength, ++count, oldFileName, date);
                FileName newFile = new FileName(folderPath, newFileName);

                // Skip hidden files and thumbs file
                if ((file.Attributes & FileAttributes.Hidden) == 0
                    && oldFileName != "Thumbs.db")
                {
                    File.Move(oldFile.FullName, newFile.FullName);
                }
            }
        }

        private SortedList<DateTime, FileInfo> GetFilesSortedByDate(string folderPath, SortDateType sortDateType)
        {
            IEnumerable<FileInfo> files = _fileWrapper.GetFilesInfo(folderPath);

            SortedList<DateTime, FileInfo> sortedFiles = new SortedList<DateTime, FileInfo>();
            foreach (FileInfo file in files)
            {
                sortedFiles.Add(GetSortDate(file, sortDateType), file);
            }
            return sortedFiles;
        }



        public static string GetNewFileNameForRenumber(bool useDatePrefix, string commonFileName, bool useExistingFileName, int removePrefixLength, int count, string oldFileName, DateTime date)
        {
            string datePrefix = "";
            if (useDatePrefix)
                datePrefix = GetFormattedDate(date) + "_";

            string countPrefix = count.ToString("D3");
            string newFileNamePart = commonFileName;
            if (newFileNamePart.Length > 0)
                newFileNamePart = "_" + newFileNamePart;
            string reuseFileName = oldFileName.Substring(removePrefixLength);
            if (!useExistingFileName)
                reuseFileName = oldFileName.Substring(oldFileName.LastIndexOf("."));
            string newFileName = datePrefix + countPrefix + newFileNamePart + reuseFileName;
            return newFileName;
        }

        public static string GetFormattedDate(DateTime date)
        {
            return date.Year.ToString("D4") + "-" + date.Month.ToString("D2") + "-" + date.Day.ToString("D2");
        }

    }
}
