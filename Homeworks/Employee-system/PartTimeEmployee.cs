namespace Employee_system;

internal sealed class PartTimeEmployee : Employee 
{
    internal decimal BaseSalary { get; set; }
    internal double Rate { get; set; }
    internal PartTimeEmployee(string firstName, string lastName, string position, decimal baseSalary ,double rate)
        : base(firstName, lastName, position)
    { this.BaseSalary = baseSalary; this.Rate = rate; }

    internal override decimal CalculateSalary()
    {
        return BaseSalary * (decimal)Rate;
    }

    internal override string ToString() => $"[ID: {Id}] {FirstName} {LastName} | Должность: {Position} | Зарплата: {CalculateSalary():N2} руб.";

}