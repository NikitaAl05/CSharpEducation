namespace Practice4.Task1;

class Contractor : Employee
{
    public decimal HourlyRate;
    
    public Contractor(string name, decimal salary, decimal hourlyRate) : base(name, salary)
    {
        HourlyRate = hourlyRate;
    }

    public new decimal CalculateBonus()
    {
        return 0m;
    }

    public decimal CalculateBonus(int hoursWorked)
    {
        return HourlyRate * hoursWorked;
    }
}