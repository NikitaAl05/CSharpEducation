namespace Employee_system;

internal sealed class HourlyEmployee : Employee
{
    internal decimal HourlySalary { get; set; }
    
    internal int HoursWorked { get; set; }
    
    internal HourlyEmployee(string firstName, string lastName, string position, decimal hourlySalary, int hoursWorked)
        : base(firstName, lastName, position)
    { this.HourlySalary = hourlySalary; this.HoursWorked = hoursWorked; }

    internal override decimal CalculateSalary()
    {
        return HourlySalary * HoursWorked;
    }

    internal override string ToString() => $"[ID: {Id}] {FirstName} {LastName} | Должность: {Position} | Зарплата: {CalculateSalary():N2} руб.";

}