namespace Employee_system;

internal sealed class EmployeeManager
{
    private readonly Dictionary<int, Employee> employees = new Dictionary<int, Employee>();
    internal int nextId = 0;
    
    internal void AddEmployee(Employee employee)
    {
        employee.Id = nextId;
        employees.Add(nextId, employee);
        nextId++;
    }

    internal Employee? GetEmployeeById(int id)
    {
        if (employees.TryGetValue(id, out var employee))
        {
            return employee;
        }
        
        Console.WriteLine($"Сотрудник с ID {id} не найден!");
        return null;
    }
    
    internal void GetAllEmployees()
    {
        if (employees.Count == 0)
        {
            Console.WriteLine("Список сотрудников пуст.");
            return;
        }
        
        foreach (var employee in employees.Values)
        {
            Console.WriteLine(employee.ToString());
        }
    }

    internal void UpdateEmployee(int id, Employee employee)
    {
        if (employees.ContainsKey(id))
        {
            employee.Id = id;
            employees[id] = employee;
            Console.WriteLine($"Данные сотрудника с ID {id} успешно обновлены.");
        }
        else
        {
            Console.WriteLine($"Ошибка: Сотрудник с ID {id} не найден.");
        }
        
    }

    internal void DeleteEmployee(int id)
    {
        if (employees.Remove(id))
        {
            Console.WriteLine($"Сотрудник с ID {id} уволен/удален.");
        }
        else
        {
            Console.WriteLine($"Сотрудник с ID {id} не найден.");
        }
    }

    internal decimal CalculateTotalPayroll()
    {
        decimal totalSalary = 0;
        foreach (var employee in employees.Values)
        {
            totalSalary += employee.CalculateSalary();
        }
        
        return totalSalary;
    }
}