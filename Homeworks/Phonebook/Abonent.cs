namespace Phonebook;

public class Abonent
{
    public string PhoneNumber { get; set; }
    public string Name { get; set; }

    public Abonent(string name, string phoneNumber)
    {
        Name = name;
        PhoneNumber = phoneNumber;
    }
}