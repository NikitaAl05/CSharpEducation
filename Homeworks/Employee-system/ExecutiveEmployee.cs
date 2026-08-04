namespace Employee_system;

internal sealed class ExecutiveEmployee : Employee
{
    internal decimal BaseSalary { get; set; }
    
    internal decimal ExecutiveBonus { get; set; }
    internal ExecutiveEmployee(string firstName, string lastName, string position,  decimal baseSalary, decimal executiveBonus) 
        : base(firstName, lastName, position) 
    { this.BaseSalary = baseSalary; this.ExecutiveBonus = executiveBonus; }

    internal override decimal CalculateSalary()
    {
        return ExecutiveBonus + BaseSalary;
    }

    internal override string ToString() => $"[ID: {Id}] {FirstName} {LastName} | Должность: {Position} | Зарплата: {CalculateSalary():N2} руб.";
}