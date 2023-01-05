

using System.Collections.Generic;
using FileNamer.Service;
using FileNamer.Service.DataTypes;
using FileNamer.Service.Interfaces;

namespace FileNamer.WinFormsApp
{
    public class FileNamer
    {
        public FileNamer(IFileNamerUi ui)
        {
            _ui = ui;
            _fileWrapper = new FileWrapper();
            _fileRenamer = new FileRenamer(new FileWrapper());
            _fileRenumbering = new FileRenumbering(new FileWrapper());
        }

        private readonly IFileNamerUi _ui;
        private readonly IFileWrapper _fileWrapper;
        private readonly FileRenamer _fileRenamer;
        private readonly FileRenumbering _fileRenumbering;

        public void RenumberFolder(string folderPath, bool useDatePrefix, string fileName,
            bool useExistingFileName, int removePrefixLength, SortDateType sortDateType)
        {
            if (folderPath == null || folderPath == "")
                return;

            _fileRenumbering.RenumberFolder(folderPath, useDatePrefix, fileName, useExistingFileName, removePrefixLength, sortDateType);

            UpdateFileList(folderPath);
        }

        public void Rename(string folderPath, string oldPrefix, string newPrefix)
        {
            _fileRenamer.RenameFilesInFolder(folderPath, oldPrefix, newPrefix);
            UpdateFileList(folderPath);
        }


        public void RenameSelected(string folderPath, string oldPrefix, string newPrefix, List<string> fileList)
        {
            _fileRenamer.RenameSelectedFilesInFolder(folderPath, oldPrefix, newPrefix, fileList);
            UpdateFileList(folderPath);
        }

        public void UpdateFileList(string folderPath)
        {            
            List<FileInformation> fileInfoList = _fileWrapper.GetFileInformationList(folderPath);
            _ui.UpdateFileList(fileInfoList);
        }

    }
}
