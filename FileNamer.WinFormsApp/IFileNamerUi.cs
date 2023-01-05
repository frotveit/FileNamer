

using FileNamer.Service.DataTypes;

namespace FileNamer.WinFormsApp
{
    public interface IFileNamerUi
    {
        void UpdateFileList(List<FileInformation> fileInfoList);
    }
}
