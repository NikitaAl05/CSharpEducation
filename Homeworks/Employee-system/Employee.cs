namespace Employee_system;

internal abstract class Employee
{ 
    public int Id { get; set; }
    public abstract string Name { get; set; }
    public abstract decimal BaseSalary { get; set; }
    
    internal abstract decimal CalculateSalary();
}