namespace ModuleApp8
{
    internal class FileWriter
    {
        public static void Start()
        {
            string tempFile = Path.GetTempFileName();
            var fileInfo = new FileInfo(tempFile);
            using (StreamWriter sw = fileInfo.CreateText())
            {
                sw.WriteLine("Игорь");
                sw.WriteLine("Андрей");
                sw.WriteLine("Витюша");
            }
            using (StreamWriter sw = fileInfo.AppendText())
            {
                sw.WriteLine(DateTime.Now);
            }
            using (StreamReader sr = fileInfo.OpenText())
            {
                string str;
                while((str = sr.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                }
            }
            try
            {
                string tempFile2 = Path.GetTempFileName();
                var fileInfo2 = new FileInfo(tempFile2);
                fileInfo2.Delete();
                fileInfo.CopyTo(tempFile2);
                Console.WriteLine($"{tempFile} скопирован в файл {tempFile2}");
                fileInfo.Delete();
                Console.WriteLine($"{tempFile} удален");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex}");
            }
        }
    }
}
