namespace Employee_system;

class Program
{
    static void Main(string[] args)
    {
        IEmployeeManager<Employee> employeeManager = new EmployeeManager<Employee>();
        bool isRunning = true;

        while (isRunning)
        {
            Console.Clear();
            Console.WriteLine("--- Система учета сотрудников ---");
            Console.WriteLine("1. Добавить полного сотрудника");
            Console.WriteLine("2. Добавить частичного сотрудника");
            Console.WriteLine("3. Получить информацию о сотруднике");
            Console.WriteLine("4. Обновить данные сотрудника");
            Console.WriteLine("5. Выйти");
            Console.Write("Выберите действие: ");

            string choice = Console.ReadLine() ?? "";
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    AddFullTimeEmployeeUI(employeeManager);
                    break;

                case "2":
                    AddPartTimeEmployeeUI(employeeManager);
                    break;

                case "3":
                    GetEmployeeInfoUI(employeeManager);
                    break;

                case "4":
                    UpdateEmployeeUI(employeeManager);
                    break;

                case "5":
                    isRunning = false;
                    Console.WriteLine("Завершение работы программы...");
                    continue;

                default:
                    Console.WriteLine("Ошибка: Некорректный пункт меню!");
                    break;
            }

            Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить...");
            Console.ReadKey();
        }
    }

    private static void AddFullTimeEmployeeUI(IEmployeeManager<Employee> manager)
    {
        Console.WriteLine("--- Добавить полного сотрудника ---");
        Console.Write("Введите имя: ");
        string name = Console.ReadLine() ?? "";
        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Ошибка: Имя не может быть пустым!");
            return;
        }

        Console.Write("Введите фиксированную зарплату: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal baseSalary))
        {
            Console.WriteLine("Ошибка: Некорректный размер зарплаты!");
            return;
        }

        manager.Add(new FullTimeEmployee(name, baseSalary));
        Console.WriteLine("Сотрудник успешно добавлен.");
    }

    private static void AddPartTimeEmployeeUI(IEmployeeManager<Employee> manager)
    {
        Console.WriteLine("--- Добавить частичного сотрудника ---");
        Console.Write("Введите имя: ");
        string name = Console.ReadLine() ?? "";
        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Ошибка: Имя не может быть пустым!");
            return;
        }

        Console.Write("Введите ставку за час: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal baseSalary))
        {
            Console.WriteLine("Ошибка: Некорректная ставка!");
            return;
        }

        Console.Write("Введите отработанные часы: ");
        if (!int.TryParse(Console.ReadLine(), out int hoursWorked))
        {
            Console.WriteLine("Ошибка: Часы должны быть целым числом!");
            return;
        }

        manager.Add(new PartTimeEmployee(name, baseSalary, hoursWorked));
        Console.WriteLine("Сотрудник успешно добавлен.");
    }

    private static void GetEmployeeInfoUI(IEmployeeManager<Employee> manager)
    {
        Console.WriteLine("--- Получить информацию о сотруднике ---");
        Console.Write("Введите имя сотрудника: ");
        string name = Console.ReadLine() ?? "";

        Employee? employee = manager.Get(name);
        if (employee == null)
        {
            Console.WriteLine("Сотрудник с таким именем не найден.");
            return;
        }

        Console.WriteLine(employee.ToString());
    }

    private static void UpdateEmployeeUI(IEmployeeManager<Employee> manager)
    {
        Console.WriteLine("--- Обновить данные сотрудника ---");
        Console.Write("Введите имя сотрудника для обновления: ");
        string name = Console.ReadLine() ?? "";

        Employee? existing = manager.Get(name);
        if (existing == null)
        {
            Console.WriteLine("Сотрудник с таким именем не найден.");
            return;
        }

        if (existing is FullTimeEmployee)
        {
            Console.Write("Введите новую фиксированную зарплату: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal newSalary))
            {
                Console.WriteLine("Ошибка: Некорректный размер зарплаты!");
                return;
            }
            manager.Update(new FullTimeEmployee(name, newSalary));
        }
        else if (existing is PartTimeEmployee)
        {
            Console.Write("Введите новую ставку в час: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal newSalary))
            {
                Console.WriteLine("Ошибка: Некорректная ставка!");
                return;
            }

            Console.Write("Введите новое количество отработанных часов: ");
            if (!int.TryParse(Console.ReadLine(), out int newHours))
            {
                Console.WriteLine("Ошибка: Часы должны быть целым числом!");
                return;
            }

            manager.Update(new PartTimeEmployee(name, newSalary, newHours));
        }

        Console.WriteLine("Данные сотрудника успешно обновлены.");
    }
}