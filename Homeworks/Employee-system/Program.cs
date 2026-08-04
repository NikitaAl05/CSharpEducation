namespace Employee_system;

class Program
{
    static void Main(string[] args)
    {
        EmployeeManager employeeManager = new EmployeeManager(); ;
        
        bool isRunning = true;
        
        while (isRunning)
        {
            Console.Clear();
            Console.WriteLine("--- Система учета сотрудников ---");
            Console.WriteLine("1 — Показать всех сотрудников");
            Console.WriteLine("2 — Найти сотрудника по ID");
            Console.WriteLine("3 — Добавить нового сотрудника");
            Console.WriteLine("4 — Обновить данные сотрудника");
            Console.WriteLine("5 — Удалить (уволить) сотрудника");
            Console.WriteLine("6 — Посчитать общую зарплатную ведомость");
            Console.WriteLine("0 — Выйти из программы");
            Console.WriteLine("---------------------------------------------");    
            Console.Write($"__ > ");
            
            string choice = Console.ReadLine().ToString();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("--- Список всех сотрудников ---");
                    employeeManager.GetAllEmployees();
                    break;

                case "2":
                    Console.WriteLine("--- Поиск сотрудника ---");
                    FindEmployeeUI(employeeManager);
                    break;

                case "3":
                    Console.WriteLine("--- Добавление сотрудника ---");
                    AddNewEmployeeUI(employeeManager);
                    break;

                case "4":
                    Console.WriteLine("--- Обновление данных ---");
                    UpdateEmployeeUI(employeeManager);
                    break;

                case "5":
                    Console.WriteLine("--- Удаление сотрудника ---");
                    DeleteEmployeeUI(employeeManager);
                    break;

                case "6":
                    Console.WriteLine("--- Зарплатная ведомость ---");
                    decimal totalPayroll = employeeManager.CalculateTotalPayroll();
                    Console.WriteLine($"Общая сумма выплат всем сотрудникам: {totalPayroll:N2} руб.");
                    break;

                case "0":
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
    private static void FindEmployeeUI(EmployeeManager manager)
    {
        Console.Write("Введите ID сотрудникa > ");
        string idInput = Console.ReadLine().ToString();
            
        if (!int.TryParse(idInput, out int id))
        {
            Console.WriteLine("Ошибка: ID должен быть целым числом!");
            return;
        }
        
        Employee? emp = manager.GetEmployeeById(id);
        if (emp != null)
        {
            Console.WriteLine(emp.ToString());
        }
    }
    
    private static void AddNewEmployeeUI(EmployeeManager manager)
    {
        Console.WriteLine("Выберите тип сотрудника:");
        Console.WriteLine("1 — Полная ствака (Full-time)");
        Console.WriteLine("2 — Полставки (Part-time)");
        Console.WriteLine("3 — Почасовая оплата (Hourly)");
        Console.WriteLine("4 — Руководитель (Executive)");
        Console.Write("Ваш выбор: ");

        string typeChoice = Console.ReadLine()!;

        Console.Write("Введите имя: ");
        string firstName = Console.ReadLine()!;

        if (string.IsNullOrWhiteSpace(firstName))
        {
            Console.WriteLine("Ошибка: Имя не может быть пустым!");
            return;
        }

        Console.Write("Введите фамилию: ");
        string lastName = Console.ReadLine()!;

        if (string.IsNullOrWhiteSpace(lastName))
        {
            Console.WriteLine("Ошибка: Фамилия не может быть пустой!");
            return;
        }

        Console.Write("Введите должность: ");
        string position = Console.ReadLine()!;

        Employee? newEmployee = null;

        switch (typeChoice)
        {
            case "1":
                Console.Write("Введите месячный оклад: ");
                if (!decimal.TryParse(Console.ReadLine(), out decimal monthlySalary))
                {
                    Console.WriteLine("Ошибка: Некорректный размер оклада!");
                    return;
                }
                newEmployee = new FullTimeEmployee(firstName, lastName, position, monthlySalary);
                break;

            case "2":
                Console.Write("Введите базовый оклад: ");
                if (!decimal.TryParse(Console.ReadLine(), out decimal baseSalary))
                {
                    Console.WriteLine("Ошибка: Некорректный оклад!");
                    return;
                }

                Console.Write("Введите ставку (например, 0,5): ");
                if (!double.TryParse(Console.ReadLine(), out double rate))
                {
                    Console.WriteLine("Ошибка: Некорректная ставка!");
                    return;
                }

                newEmployee = new PartTimeEmployee(firstName, lastName, position, baseSalary, rate);
                break;

            case "3":
                Console.Write("Введите ставку в час: ");
                if (!decimal.TryParse(Console.ReadLine(), out decimal hourlySalary))
                {
                    Console.WriteLine("Ошибка: Некорректная ставка!");
                    return;
                }

                Console.Write("Введите отработанные часы: ");
                if (!int.TryParse(Console.ReadLine(), out int hours))
                {
                    Console.WriteLine("Ошибка: Количество часов должно быть целым числом!");
                    return;
                }

                newEmployee = new HourlyEmployee(firstName, lastName, position, hourlySalary, hours);
                break;

            case "4":
                Console.Write("Введите базовый оклад: ");
                if (!decimal.TryParse(Console.ReadLine(), out decimal execBase))
                {
                    Console.WriteLine("Ошибка: Некорректный оклад!");
                    return;
                }

                Console.Write("Введите премию за руководство: ");
                if (!decimal.TryParse(Console.ReadLine(), out decimal bonus))
                {
                    Console.WriteLine("Ошибка: Некорректная премия!");
                    return;
                }

                newEmployee = new ExecutiveEmployee(firstName, lastName, position, execBase, bonus);
                break;

            default:
                Console.WriteLine("Ошибка: Что-то не то ты выбрал");
                return;
        }

        manager.AddEmployee(newEmployee);
        Console.WriteLine("\nСотрудник успешно добавлен!");
    }
    private static void UpdateEmployeeUI(EmployeeManager manager)
    {
        Console.Write("Введите ID сотрудника для обновления: ");

        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("Ошибка: ID должен быть целым числом!");
            return;
        }

        Employee? existing = manager.GetEmployeeById(id);

        if (existing == null)
        {
            return;
        }

        Console.WriteLine($"\nОбновление данных для {existing.FirstName} {existing.LastName}:");
        Console.Write("Введите новое имя: ");
        string firstName = Console.ReadLine()!;

        Console.Write("Введите новую фамилию: ");
        string lastName = Console.ReadLine()!;

        Console.Write("Введите новую должность: ");
        string position = Console.ReadLine()!;

        Employee updatedEmployee;

        if (existing is FullTimeEmployee)
        {
            Console.Write("Введите новый оклад: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal salary))
            {
                Console.WriteLine("Ошибка: Некорректный оклад!");
                return;
            }
            updatedEmployee = new FullTimeEmployee(firstName, lastName, position, salary);
        }
        else if (existing is PartTimeEmployee)
        {
            Console.Write("Введите новый базовый оклад: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal baseSalary))
            {
                Console.WriteLine("Ошибка: Некорректный оклад!");
                return;
            }

            Console.Write("Введите новую ставку: ");
            if (!double.TryParse(Console.ReadLine(), out double rate))
            {
                Console.WriteLine("Ошибка: Некорректная ставка!");
                return;
            }

            updatedEmployee = new PartTimeEmployee(firstName, lastName, position, baseSalary, rate);
        }
        else if (existing is HourlyEmployee)
        {
            Console.Write("Введите новую часовую ставку: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal hourlySalary))
            {
                Console.WriteLine("Ошибка: Некорректная ставка!");
                return;
            }

            Console.Write("Введите отработанные часы: ");
            if (!int.TryParse(Console.ReadLine(), out int hours))
            {
                Console.WriteLine("Ошибка: Некорректные часы!");
                return;
            }

            updatedEmployee = new HourlyEmployee(firstName, lastName, position, hourlySalary, hours);
        }
        else
        {
            Console.Write("Введите новый оклад: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal baseSalary))
            {
                Console.WriteLine("Ошибка: Некорректный оклад!");
                return;
            }

            Console.Write("Введите новую премию: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal bonus))
            {
                Console.WriteLine("Ошибка: Некорректная премия!");
                return;
            }

            updatedEmployee = new ExecutiveEmployee(firstName, lastName, position, baseSalary, bonus);
        }

        manager.UpdateEmployee(id, updatedEmployee);
    }
    private static void DeleteEmployeeUI(EmployeeManager manager)
    {
        Console.Write("Введите ID сотрудника для удаления: ");

        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("Ошибка: ID должен быть целым числом!");
            return;
        }

        manager.DeleteEmployee(id);
    }
    
}