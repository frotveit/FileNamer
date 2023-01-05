using FileNamer.Service.Interfaces;
using FileNamer.Service.DataTypes;

namespace FileNamer.Service
{
    public class FileRenamer
    {
        private readonly IFileWrapper _fileWrapper;
        public FileRenamer(IFileWrapper fileWrapper)
        {
            _fileWrapper = fileWrapper;
        }


        public void RenameFilesInFolder(string folderPath, string oldPrefix, string newPrefix)
        {
            if (folderPath == String.Empty) return;
            if (oldPrefix == String.Empty && newPrefix == String.Empty) return;

            List<string> fileList = _fileWrapper.GetFolderFiles(folderPath);

            RenameSelectedFilesInFolder(folderPath, oldPrefix, newPrefix, fileList);
        }

        
        public void RenameSelectedFilesInFolder(string folderPath, string oldPrefix, string newPrefix, List<string> fileList)
        {
            if (folderPath == String.Empty) return;
            if (oldPrefix == String.Empty && newPrefix == String.Empty) return;
            if (fileList.Count == 0) return;

            foreach (string oldFileName in fileList)
            {
                FileName oldFile = new FileName(folderPath, oldFileName);
                //string oldFileName = oldFilePath.Substring(folderPath.Length + 1);

                if (oldPrefix == String.Empty || oldFileName.StartsWith(oldPrefix))
                {
                    string newFileName = newPrefix + oldFileName.Substring(oldPrefix.Length);
                    FileName newFile = new FileName(folderPath, newFileName);

                    _fileWrapper.RenameFile(oldFile, newFile);
                }
            }
        }
    }
}
