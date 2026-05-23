namespace Phonebook;

class Program
{
    static void Main(string[] args)
    {
        Phonebook.Instance.LoadFromFile();
        Phonebook phonebook = Phonebook.Instance;
        while (true)
        {
            Console.Clear();
            
            Console.WriteLine("1 - Добавить\n" +
                              "2 - Найти\n" +
                              "3 - Удалить\n" +
                              "4 - Выход");
            
            if (char.TryParse(Console.ReadLine(), out char choice))
            {
                if (choice == '1')
                {
                    Console.Clear();
                    Console.Write("Имя: ");
                    string name = Console.ReadLine();
                    Console.Write("Номер: ");
                    string phone = Console.ReadLine();
                    phonebook.AddAbonent(name, phone);
                    
                    Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
                    Console.ReadKey();
                }
                else if (choice == '2')
                {
                    Console.Clear();
                    Console.WriteLine("1 - Получить номер телефона по имени\n" +
                                      "2 - Получить имя по номеру телефона");
                    if (char.TryParse(Console.ReadLine(), out char ch))
                    {
                        if (ch == '1')
                        {
                            Console.Write("Имя: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("\n[Результат]: " + phonebook.GetPhoneNumberByName(name));
                        }
                        else if (ch == '2')
                        {
                            Console.Write("Номер телефона: ");
                            string phone = Console.ReadLine();
                            Console.WriteLine("\n[Результат]: " + phonebook.GetNameByPhoneNumber(phone));
                        }
                        
                        Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
                        Console.ReadKey();
                    }
                }
                else if (choice == '3')
                {
                    Console.Clear();
                    Console.WriteLine("1 - Удалить по имени\n" +
                                      "2 - Удалить по номеру телефона");
                    if (char.TryParse(Console.ReadLine(), out char ch))
                    {
                        if (ch == '1')
                        {
                            Console.Write("Имя: ");
                            string name = Console.ReadLine();
                            Console.WriteLine();
                            phonebook.DeleteAbonentByName(name);
                        }
                        else if (ch == '2')
                        {
                            Console.Write("Номер телефона: ");
                            string phone = Console.ReadLine();
                            Console.WriteLine();
                            phonebook.DeleteAbonentByPhoneNumber(phone);
                        }
                        
                        Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
                        Console.ReadKey();
                    }
                }
                else if (choice == '4')
                {
                    Phonebook.Instance.SaveToFile();
                    break;
                }
            }
        }
    }
}