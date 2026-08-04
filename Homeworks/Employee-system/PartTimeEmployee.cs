namespace Employee_system;

internal sealed class PartTimeEmployee : Employee 
{
    public override string Name { get; set; }
    public override decimal BaseSalary { get; set; }
    public int HoursWorked { get; set; }

    internal PartTimeEmployee(string name, decimal baseSalary , int hoursWorked)
    {
        this.BaseSalary = baseSalary;
        this.Name = name;
        this.HoursWorked = hoursWorked;
    }
    
    internal override decimal CalculateSalary()
    {
        return BaseSalary * HoursWorked;
    }
    
    public override string ToString()
    {
        return $"Частичная занятость | Имя: {Name} | Часов: {HoursWorked} | Зарплата: {CalculateSalary()} руб.";
    }
    
}