using FileNamer.Service.DataTypes;

namespace FileNamer.Service.Interfaces
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
