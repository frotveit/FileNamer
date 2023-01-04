namespace FileNamer.Service.DataTypes
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
