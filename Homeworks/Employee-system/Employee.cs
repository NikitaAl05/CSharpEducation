namespace Employee_system;

internal abstract class Employee
{
    internal int Id { get; set; }
    
    internal string FirstName { get; set; }
    internal string LastName { get; set; }
    internal string Position { get; set; }

    internal Employee(string firstName, string lastName, string position)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Position = position;
    }
    
    internal abstract decimal CalculateSalary();
    internal abstract string ToString(); 
}