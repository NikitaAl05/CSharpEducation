namespace Practice4.Task1;

public class Employee
{
    public string Name;
    public decimal Salary;
    
    public Employee(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
    }

    public virtual decimal CalculateBonus()
    {
        return Salary * 0.1m;
    }
}