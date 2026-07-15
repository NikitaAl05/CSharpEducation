using Practice4.Task2;

namespace Practice.Task2.Exceptions;

class Program
{
    static void Main(string[] args)
    {
        ConsoleLogger logger = new ConsoleLogger();
        Console.WriteLine("--- Тест 1: Обычный счет ---");
        RegularAccount regAccount = new RegularAccount(logger);

        try
        {
            regAccount.Deposit(1000);
            Console.WriteLine($"Пополняем баланс на [1000 руб.]\nБаланс: {regAccount.Balance} руб.");

            regAccount.Withdraw(400);
            Console.WriteLine($"Снимаем с баланса [400 руб.]\nБаланс: {regAccount.Balance} руб.");

            Console.WriteLine("\nПробуем снять [1000 руб.] (ожидаем ошибку)...");
            regAccount.Withdraw(1000);
        }
        catch (BankAccountException ex)
        {
            Console.WriteLine($"[КРЯ] {ex.Message}");
        }
        
        Console.WriteLine("\n----------------------------------------\n");
        
        Console.WriteLine("--- Тест 2: Проверка некорректной суммы ---");
        try
        {
            Console.WriteLine("Пробуем пополнить баланс на [-50 руб.]..");
            regAccount.Deposit(-50);
        }
        catch (BankAccountException ex)
        {
            Console.WriteLine($"[КРЯ] {ex.Message}");
        }

        Console.WriteLine("\n----------------------------------------\n");
        
        Console.WriteLine("--- Тест 3: Накопительный счет ---");
        SavingsAccount saveAccount = new SavingsAccount(logger);
        
        try
        {
            saveAccount.Deposit(5000);
            Console.WriteLine($"Пополняем баланс на [5000 руб.].\nБаланс: {saveAccount.Balance} руб.");

            
            Console.WriteLine("\nПытаемся снять деньги первый раз [500 руб.]...");
            saveAccount.Withdraw(500);
            Console.WriteLine($"Снимаем с баланса [500 руб.]\nБаланс: {saveAccount.Balance} руб.");
            
            Console.WriteLine("\nПытаемся снять деньги второй раз сразу же [300 руб.]...");
            saveAccount.Withdraw(300);
        }
        catch (BankAccountException ex) 
        {
            Console.WriteLine($"[КРЯ] {ex.Message}");
        }

        Console.WriteLine("\n--- ГОТОВО ---");
        Console.ReadLine(); 
    }
}

public abstract class BankAccount
{
    
    protected readonly ConsoleLogger _logger;
    public BankAccount(ConsoleLogger logger)
    {
        _logger = logger;
    }
    public decimal Balance { get; set; }
    
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            _logger.Error("Попытка пополнения на некорректную сумму.");
            throw new InvalidAmountException("Ошибка: Сумма пополнения должна быть больше нуля.");
        }
        Balance += amount;
        _logger.Info($"Баланс успешно пополнен на {amount} руб.");
    }

    public virtual void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            _logger.Error("Попытка снятия некорректной суммы.");
            throw new InvalidAmountException("Ошибка: Сумма снятия должна быть больше нуля.");
        }

        if (amount > Balance)
        {
            _logger.Error($"Недостаточно средств для снятия {amount} руб.");
            throw new InsufficientFundsException($"Ошибка: Недостаточно средств. Баланс: {Balance} руб.");
        }
        Balance -= amount;
        _logger.Info($"Успешно снято {amount} руб.");
    }
}

public class RegularAccount : BankAccount
{
    public RegularAccount(ConsoleLogger logger) : base(logger) { }
}

public class SavingsAccount : BankAccount
{ 
    private DateTime _lastWithdrawalDate = DateTime.MinValue;
    public SavingsAccount(ConsoleLogger logger) : base(logger) { }
    public override void Withdraw(decimal amount)
    {
        if (DateTime.Now < _lastWithdrawalDate.AddMonths(1))
        {
            _logger.Error("Попытка снятия, количесвтой снятий в месяц ограничено.");
            throw new WithdrawalLimitExceededException("Ошибка: Нельзя снимать деньги чаще, чем раз в месяц!\n" +
                                                       $"Последний раз деньги снимались: {_lastWithdrawalDate}");
        }
        _lastWithdrawalDate = DateTime.Now;
        base.Withdraw(amount);
    }
}

public class BankAccountException : Exception
{
    public BankAccountException(string message) : base(message) { }
}
public class InvalidAmountException : BankAccountException
{
    public InvalidAmountException(string message) : base(message) { }
}
public class WithdrawalLimitExceededException : BankAccountException
{
    public WithdrawalLimitExceededException(string message) : base(message) { }
}
public class InsufficientFundsException : BankAccountException
{
    public InsufficientFundsException(string message) : base(message) { }
}