namespace Employee_system;

internal class EmployeeNotFoundException : Exception
{
    public EmployeeNotFoundException(string message) : base(message)
    {
        
    }
}