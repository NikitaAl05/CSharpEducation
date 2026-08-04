namespace Employee_system;

internal interface  IEmployeeManager<T> where T: Employee
{
    void Add(T employee);
    T Get(int id);
    void Update(T employee);    
    void Delete(int id);
}