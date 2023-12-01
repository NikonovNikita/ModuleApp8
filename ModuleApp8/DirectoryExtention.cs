namespace ModuleApp8
{
    internal static class DirectoryExtention
    {
        public static long DirSize(DirectoryInfo directoryInfo)
        {
            long size = 0;
            FileInfo[] fileinfo = directoryInfo.GetFiles();
            foreach(FileInfo fi in fileinfo)
            {
                size += fi.Length;
            }
            DirectoryInfo[] dirInfo = directoryInfo.GetDirectories();
            foreach(DirectoryInfo di in dirInfo)
            {
                size += DirSize(di);
            }
            return size;
        }
        public static void WriteFileInfo(DirectoryInfo rootFolder)
        {
            Console.WriteLine();
            Console.WriteLine("Файлы:__________________________________");
            Console.WriteLine();
            foreach(var file in rootFolder.GetFiles())
            {
                Console.WriteLine(file.Name + $" {file.Length} байт");
            }
        }
    }
}
