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
            Console.WriteLine("5. Удалить сотрудника");
            Console.WriteLine("6. Выйти");
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
                    DeleteEmployeeUI(employeeManager);
                    break;

                case "6":
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
        
        Console.Write("Введите ID: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("Ошибка: ID должен быть целым числом!");
            return;
        }
        
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

        try
        {
            manager.Add(new FullTimeEmployee(name, baseSalary) { Id = id });
            Console.WriteLine("Сотрудник успешно добавлен.");
        }
        catch (EmployeeAlreadyExistsException ex)
        {
            Console.WriteLine($"Ошибка добавления: {ex.Message}");
        }
    }

    private static void AddPartTimeEmployeeUI(IEmployeeManager<Employee> manager)
    {
        Console.WriteLine("--- Добавить частичного сотрудника ---");
        
        Console.Write("Введите ID: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("Ошибка: ID должен быть целым числом!");
            return;
        }
        
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

        try
        {
            manager.Add(new PartTimeEmployee(name, baseSalary, hoursWorked) { Id = id });
            Console.WriteLine("Сотрудник успешно добавлен.");
        }
        catch (EmployeeAlreadyExistsException ex)
        {
            Console.WriteLine($"Ошибка добавления: {ex.Message}");
        }
    }

    private static void GetEmployeeInfoUI(IEmployeeManager<Employee> manager)
    {
        Console.WriteLine("--- Получить информацию о сотруднике ---");
        
        Console.Write("Введите ID сотрудника: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("Ошибка: ID должен быть целым числом!");
            return;
        }
        
        try
        {
            Employee employee = manager.Get(id);
            Console.WriteLine(employee.ToString());
        }
        catch (EmployeeNotFoundException ex)
        {
            Console.WriteLine($"Ошибка поиска: {ex.Message}");
        }
    }

    private static void UpdateEmployeeUI(IEmployeeManager<Employee> manager)
    {
        Console.WriteLine("--- Обновить данные сотрудника ---");
        
        Console.Write("Введите ID сотрудника для обновления: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("Ошибка: ID должен быть целым числом!");
            return;
        }
        
        try
        {
            Employee existing = manager.Get(id);

            if (existing is FullTimeEmployee)
            {
                Console.Write("Введите новое имя: ");
                string name = Console.ReadLine() ?? "";

                Console.Write("Введите новую фиксированную зарплату: ");
                if (!decimal.TryParse(Console.ReadLine(), out decimal newSalary))
                {
                    Console.WriteLine("Ошибка: Некорректный размер зарплаты!");
                    return;
                }

                manager.Update(new FullTimeEmployee(name, newSalary) { Id = id });
            }
            else if (existing is PartTimeEmployee)
            {
                Console.Write("Введите новое имя: ");
                string name = Console.ReadLine() ?? "";

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

                manager.Update(new PartTimeEmployee(name, newSalary, newHours) { Id = id });
            }

            Console.WriteLine("Данные сотрудника успешно обновлены.");
        }
        catch (EmployeeNotFoundException ex)
        {
            Console.WriteLine($"Ошибка обновления: {ex.Message}");
        }
    }
    
    private static void DeleteEmployeeUI(IEmployeeManager<Employee> manager)
    {
        Console.WriteLine("--- Удалить сотрудника ---");
        
        Console.Write("Введите ID сотрудника для удаления: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("Ошибка: ID должен быть целым числом!");
            return;
        }

        try
        {
            manager.Delete(id);
            Console.WriteLine("Сотрудник успешно удален.");
        }
        catch (EmployeeNotFoundException ex)
        {
            Console.WriteLine($"Ошибка удаления: {ex.Message}");
        }
    }
}