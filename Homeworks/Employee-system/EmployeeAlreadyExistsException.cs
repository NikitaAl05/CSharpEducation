namespace Employee_system;

internal class EmployeeAlreadyExistsException : Exception
{
    public EmployeeAlreadyExistsException(string message) : base(message)
    {
        
    }
}