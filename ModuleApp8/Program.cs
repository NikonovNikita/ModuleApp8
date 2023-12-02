using ModuleApp8;
using System.Runtime.Serialization.Formatters.Binary;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("Имя: ");
        string userName = Console.ReadLine();
        Console.Write("Тел: ");
        var phoneNumber = long.Parse(Console.ReadLine());
        Console.Write("eMail: ");
        string eMail = Console.ReadLine();
        var cont = new Contact(userName, phoneNumber, eMail);
        Console.WriteLine("Объект создан");

        BinaryFormatter formatter = new();

        using(var fs = new FileStream("contact.dat", FileMode.OpenOrCreate))
        {
            formatter.Serialize(fs, cont);
            Console.WriteLine("Объект сериализован");
        }
        using(var fs = new FileStream("contact.dat", FileMode.OpenOrCreate))
        {
            var desCont = (Contact)formatter.Deserialize(fs);
            Console.WriteLine("Объект десериализован");
            Console.WriteLine($"Имя: {desCont.Name}, номер: {desCont.PhoneNumber}, емайл: {desCont.Email}");

        }
    }


}
