﻿

using System.Collections.Generic;
using FileNamer.Service.DataTypes;

namespace FileNamer.FormApp
{
    public interface IFileNamerUi
    {
        void UpdateFileList(List<FileInformation> fileInfoList);
    }
}
