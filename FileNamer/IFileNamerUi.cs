

using System.Collections.Generic;
using FileNamerCore.DataTypes;

namespace FileNamer
{
    public interface IFileNamerUi
    {
        void UpdateFileList(List<FileInformation> fileInfoList);
    }
}
