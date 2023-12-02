namespace ModuleApp8
{
    internal class BinaryExperiment
    {
        readonly string path = @"\Users\Никонов\OneDrive\Рабочий стол\BinaryFile.bin";
        
        public void ReadValues()
        {
            if (File.Exists(path))
            {
                string ValueString;
                using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
                {
                    ValueString = reader.ReadString();
                    Console.WriteLine("Из файла считано:");
                    Console.WriteLine(ValueString);
                }
            }
            else { Console.WriteLine("Неверный путь? Или шо"); }
        }
        public void WriteValues()
        {
            using(BinaryWriter writer =  new BinaryWriter(File.Open(path, FileMode.Open)))
            {
                writer.Write($"Файл изменен {DateTime.Now} на компьютере с ОС {Environment.OSVersion}");
            }
        }

    }
}
