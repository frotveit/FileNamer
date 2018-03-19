using FileNamerCore.DataTypes;
using System.Collections.Generic;
using System.IO;

namespace FileNamerCore.Interfaces
{
    public interface IFileWrapper
    {
        List<string> GetFolderFiles(string folderPath);
        List<string> GetFileList(string folderPath);
        List<FileInformation> GetFileInformationList(string folderPath);
        IEnumerable<FileInfo> GetFilesInfo(string folderPath);
        void RenameFile(FileName oldFile, FileName newFile);
    }
}
