namespace Practice3.Task2;

class Student
{
    private string name = "Nikita";
    private int age = 2;
    private int average;
    public int Average
    {
        get => average;
        set
        {
            if (value >= 0 && value <= 5)
            {
                average = value;
            }
        }
    }
    public override string ToString() => $"name: {name}, age: {age}. average: {Average}";
    
}