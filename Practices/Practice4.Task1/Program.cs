namespace Practice4.Task1;

using Practice4.Task2;

class Program
{
    static void Main(string[] args)
    {
        ILogger consoleLogger = new ConsoleLogger();
        ILogger fileLogger = new FileLogger("employees_log.txt");
        
        consoleLogger.Info("Старт программы.");
        fileLogger.Info("Приложение запущено.");
        
        List<Employee> employees = new List<Employee>();
        
        employees.Add(new Employee("Employee", 1200));
        employees.Add(new Manager("Manager", 1500, 10));
        employees.Add(new Contractor("Contractor", 1000, 1000));

        foreach (var emp in employees)
        {
            if (emp is Contractor contractor)
            {
                consoleLogger.Debug($"{contractor.Name} - Бонус: {contractor.CalculateBonus(10)}");
                fileLogger.Debug($"{contractor.Name} - Бонус: {contractor.CalculateBonus(10)}");
            }else 
            {
                consoleLogger.Debug($"{emp.Name} - Бонус: {emp.CalculateBonus()}");
                fileLogger.Debug($"{emp.Name} - Бонус: {emp.CalculateBonus()}");
            }
        }
        
        consoleLogger.Info("Бонусы посчитаны!");
        fileLogger.Info("Конец работы.");
    }
}