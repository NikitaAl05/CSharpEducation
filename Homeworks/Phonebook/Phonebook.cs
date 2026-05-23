namespace Phonebook;
using System.IO;
public sealed class Phonebook
{
    private List<Abonent> abonents = new List<Abonent>();
    
    private static readonly Phonebook _instance = new Phonebook();
    private Phonebook()
    {
        
    }
    
    public static Phonebook Instance => _instance;

    public void AddAbonent(string name, string phoneNumber)
    {
        foreach (var a in abonents)
        {
            if (a.Name == name)
            {
                Console.WriteLine($"Ошибка: {name} уже есть в списке!");
                return;
            }

            if (a.PhoneNumber == phoneNumber)
            {
                Console.WriteLine($"Ошибка: {phoneNumber} уже есть в списке!");
                return;
            }
        }
        
        Abonent abonent = new Abonent(name, phoneNumber);
        abonents.Add(abonent);
    }

    public string GetPhoneNumberByName(string name)
    {
        foreach (var a in abonents)
        {
            if (a.Name == name)
            {
                return a.PhoneNumber;
            }
        }

        return "Номер не найден!";
    }

    public string GetNameByPhoneNumber(string phoneNumber)
    {
        foreach (var a in abonents)
        {
            if (a.PhoneNumber == phoneNumber)
            {
                return a.Name;
            }
        }

        return "Абонент не найден!";
    }

    public void DeleteAbonentByPhoneNumber(string phoneNumber)
    {
        bool isDeleted = false;
        foreach (var a in abonents)
        {
            if (a.PhoneNumber == phoneNumber)
            {
                abonents.Remove(a);
                isDeleted = true;
                Console.WriteLine($"Абонет по номеру телефона [{phoneNumber}] удален!");
                return;
            }
        }
        if (!isDeleted) {Console.WriteLine($"Абонет c таким номером телефона [{phoneNumber}] не найден!"); }
    }

    public void DeleteAbonentByName(string name)
    {
        bool isDeleted = false;
        foreach (var a in abonents)
        {
            if (a.Name == name)
            {
                abonents.Remove(a);
                isDeleted = true;
                Console.WriteLine($"Абонет по имени [{name}] удален!");
                return;
            }
        }
        if (!isDeleted) {Console.WriteLine($"Абонет c именем [{name}] не найден!");}
    }
    
    public void SaveToFile()
    {
        using (StreamWriter sw = new StreamWriter("phonebook.txt"))
        {
            foreach (var a in abonents)
            {
                sw.WriteLine($"{a.Name}|{a.PhoneNumber}");
            }
        }
    }

    public void LoadFromFile()
    {
        if (File.Exists("phonebook.txt"))
        {
            using (StreamReader sr = new StreamReader("phonebook.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    Abonent abonent = new Abonent(parts[0], parts[1]);
                    abonents.Add(abonent);
                }
            }
        }
    }
}