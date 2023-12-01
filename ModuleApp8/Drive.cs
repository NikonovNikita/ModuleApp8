namespace ModuleApp8
{
    internal class Drive
    {
        public Drive(string name, long totalSpace, long freeSpace)
        {
            Name = name;
            TotalSpace = totalSpace;
            FreeSpace = freeSpace;
        }
        public string Name { get; }
        public long TotalSpace { get; }
        public long FreeSpace { get; }
        Dictionary<string, Folder> Folders = new Dictionary<string, Folder>();
        public void CreateFolder(string name)
        {
            Folders.Add(name, new Folder());
        }
    }
}
