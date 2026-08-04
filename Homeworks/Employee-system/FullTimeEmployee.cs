namespace Employee_system;

internal sealed class FullTimeEmployee : Employee
{
    public override string Name { get; set; }
    public override decimal BaseSalary { get; set; }

    internal FullTimeEmployee(string name, decimal baseSalary)
    {
        this.Name = name;
        this.BaseSalary = baseSalary;
    }

    internal override decimal CalculateSalary()
    {
        return BaseSalary;
    }
    
    public override string ToString()
    {
        return $"Полный день | Имя: {Name} | Зарплата: {CalculateSalary()} руб.";
    }
}