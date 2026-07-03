namespace Practice4.Task3;

public class Parrot : Animal, IFlyable
{
    public string Color;

    public Parrot(string name, int age, string color) : base(name, age)
    {
        this.Color = color;
    }
    
    public new string MakeSound() => "Parrot is talking";

    public string MakeSound(string words)
    {
        return words;
    }

    public string Fly() => "Parrot is flying";
}