namespace FileNamer.Service.DataTypes
{
    public class FileInformation
    {
        public string Name { get; set; }

        public string Path { get; set; }

        public DateTime CreationTime { get; set; }

        public DateTime ChangedTime { get; set; }

        public FileInformation() { }

        public FileInformation(FileInfo info)
        {
            Name = info.Name;
            CreationTime = info.CreationTime;
            ChangedTime = info.LastWriteTime;
        }

    }
}
