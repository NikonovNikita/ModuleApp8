using ModuleApp8;

namespace DirectoryManager
{
    class Program
    {
        static void Main(string[] args)
        {
            GetCatalogs();
            Method();
        }
        
        static void Method()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach(DriveInfo drive in drives)
            {
                WriteDriveInfo(drive);
                DirectoryInfo root = drive.RootDirectory;
                var folders = root.GetDirectories();
                DirectoryExtention.WriteFileInfo(root);
                WriteFolderInfo(folders);
                
                Console.WriteLine();
                Console.WriteLine();
            }

        }
        public static void WriteDriveInfo(DriveInfo drive)
        {
            Console.WriteLine($"Название: {drive.Name}");
            Console.WriteLine($"Тип: {drive.DriveType}");
            if (drive.IsReady)
            {
                Console.WriteLine($"Объем: {drive.TotalSize}");
                Console.WriteLine($"Свободно: {drive.TotalFreeSpace}");
                Console.WriteLine($"Метка: {drive.VolumeLabel}");
            }
        }
        public static void WriteFolderInfo(DirectoryInfo[] folders)
        {
            Console.WriteLine();
            Console.WriteLine("Папки: ");
            Console.WriteLine();
            foreach (var folder in folders)
            {
                try
                {
                    Console.WriteLine(folder.Name + $" {DirectoryExtention.DirSize(folder)} байт");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(folder.Name + $" Не удалось рассчитать размер {ex.Message}");
                }
            }
        }
        
        static void GetCatalogs()
        {
            string filePath = @"C:\Users\Никонов\source\repos\ModuleApp8\ModuleApp8\Program.cs";
            using(StreamReader sr = File.OpenText(filePath))
            {
                string str;
                while((str = sr.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}
