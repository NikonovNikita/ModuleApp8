namespace ModuleApp8
{
    internal class BinaryExperiment
    {
        const string SettingsFileName = "Settings.cfg";

        public static void WriteValues()
        {
            using (BinaryWriter writer = new(File.Open(SettingsFileName, FileMode.Create)))
            {
                writer.Write(20.666F);
                writer.Write(@"Тестовая строка");
                writer.Write(55);
                writer.Write(false);
            }
        }
        public static void ReadValues()
        {
            float FloatValue;
            string StringValue;
            int IntValue;
            bool BooleanValue;

            if (File.Exists(SettingsFileName))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(SettingsFileName, FileMode.Open)))
                {
                    FloatValue = reader.ReadSingle();
                    StringValue = reader.ReadString();
                    IntValue = reader.ReadInt32();
                    BooleanValue = reader.ReadBoolean();
                }
                Console.WriteLine("Из файла считано:");

                Console.WriteLine("Дробь: " + FloatValue);
                Console.WriteLine("Строка: " + StringValue);
                Console.WriteLine("Целое: " + IntValue);
                Console.WriteLine("Булево значение " + BooleanValue);
            }
        }

    }
}
