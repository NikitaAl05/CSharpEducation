namespace Practice3.Part2.Task3;

public class Person
{
    private string name;
    private int age;

    public int Age
    {
        get => age;
        set { age = value; }
    }

    public string Name
    {
        get => name;
        set { name = value; }
    }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void PersonInfo()
    {
        Console.WriteLine($"Имя: {Name}, Возсрат: {Age}");
    } 



}