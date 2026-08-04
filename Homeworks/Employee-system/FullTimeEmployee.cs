namespace Employee_system;

internal sealed class FullTimeEmployee : Employee
{
    internal decimal MonthlySalary { get; set; }    

    internal FullTimeEmployee(string firstName, string lastName, string position, decimal montlySalary)
        : base(firstName, lastName, position) { this.MonthlySalary = montlySalary; }

    internal override decimal CalculateSalary()
    {
        return MonthlySalary;
    }

    internal override string ToString() => $"[ID: {Id}] {FirstName} {LastName} | Должность: {Position} | Зарплата: {CalculateSalary():N2} руб.";

}