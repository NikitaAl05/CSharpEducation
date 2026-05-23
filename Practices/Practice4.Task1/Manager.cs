namespace Practice4.Task1;

class Manager : Employee
{
    public int TeamSize;

    public Manager(string name, decimal salary, int teamSize) : base(name, salary)
    {
        TeamSize = teamSize;
    }

    public override decimal CalculateBonus()
    {
        if (TeamSize > 5)
        {
            return Salary * (0.2m + 0.05m);
        }
        return Salary * 0.2m;
    }
}