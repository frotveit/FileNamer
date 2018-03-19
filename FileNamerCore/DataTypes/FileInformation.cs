using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileNamerCore.DataTypes
{
    public class FileInformation
    {
        public string Name;
        public string Path;
        public DateTime CreationTime;
        public DateTime ChangedTime;

        public FileInformation() { }

        public FileInformation(FileInfo info)
        {
            Name = info.Name;
            CreationTime = info.CreationTime;
            ChangedTime = info.LastWriteTime;
        }


    }
}
