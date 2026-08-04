namespace Employee_system;

internal class EmployeeManager<T> : IEmployeeManager<T> where T : Employee
{
    private readonly List<T> employees = new List<T>();
    
    public void Add(T employee)
    {
        if (employees.Any(e => e.Id == employee.Id))
        {
            throw new EmployeeAlreadyExistsException($"Сотрудник с Id {employee.Id} уже существует.");            
        }
        employees.Add(employee);
    }

    public T Get(int id)
    {
        T? employee = employees.Find(e => e.Id == id);

        if (employee == null)
        {
            throw new EmployeeNotFoundException($"Сотрудник с ID {id} не найден.");
        }
        return employee;
    }

    public void Update(T employee)
    {
        int index = employees.FindIndex(e => e.Name == employee.Name);
        if (index == -1)
        {
            throw new EmployeeNotFoundException($"Сотрудник с ID {employee.Id} не найден для обновления.");
        }
        employees[index] = employee;
    }
    
    public void Delete(int id)
    {
        int index = employees.FindIndex(e => e.Id == id);
        if (index == -1)
        {
            throw new EmployeeNotFoundException($"Сотрудник с ID {id} не найден для удаления.");
        }
        employees.RemoveAt(index);
    }
}
