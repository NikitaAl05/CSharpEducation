namespace Practice3.Task9;

class Student
{
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Anonymize(Student s)
    {
        s.Name = "Аноним";
    }

    public string GetInfo()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}