namespace Employee_system;

internal class EmployeeManager<T> : IEmployeeManager<T> where T : Employee
{
    private readonly List<T> employees = new List<T>();
    
    public void Add(T employee)
    {
        employees.Add(employee);
    }

    public T? Get(string name)
    {
        return employees.Find(employee => employee.Name == name);
    }

    public void Update(T employee)
    {
        int index = employees.FindIndex(e => e.Name == employee.Name);
        if (index != -1)
        {
            employees[index] = employee;
        }
    }
}
