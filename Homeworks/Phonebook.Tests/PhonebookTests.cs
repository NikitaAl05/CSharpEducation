namespace Phonebook.Tests;

using System.IO;
using Xunit;

public class PhonebookTests
{
    private Phonebook GetCleanPhonebook()
    {
        Phonebook phonebook = Phonebook.Instance;
        phonebook.Clear();
        return phonebook;
    }

    [Fact]
    public void AddAbonent_ShouldAddAbonentSuccessfully()
    {
        var phonebook = GetCleanPhonebook();
        phonebook.AddAbonent("Никита", "89935266356");

        Assert.Equal("89935266356", phonebook.GetPhoneNumberByName("Никита"));
    }

    [Fact]
    public void GetNameByPhoneNumber_WhenNotFound_ShouldReturnErrorMessage()
    {
        var phonebook = GetCleanPhonebook();

        Assert.Equal("Абонент не найден!", phonebook.GetNameByPhoneNumber("000000"));
    }

    [Fact]
    public void DeleteAbonentByName_ShouldRemoveAbonent()
    {
        var phonebook = GetCleanPhonebook();
        phonebook.AddAbonent("Ви", "89112223344");

        phonebook.DeleteAbonentByName("Ви");

        Assert.Equal("Номер не найден!", phonebook.GetPhoneNumberByName("Ви"));
    }

    [Fact]
    public void DeleteAbonentByPhoneNumber_ShouldRemoveAbonent()
    {
        var phonebook = GetCleanPhonebook();
        phonebook.AddAbonent("Павел", "89223334455");

        phonebook.DeleteAbonentByPhoneNumber("89223334455");

        Assert.Equal("Абонент не найден!", phonebook.GetNameByPhoneNumber("89223334455"));
    }

    [Fact]
    public void SaveAndLoadFromFile_ShouldRestoreData()
    {
        var phonebook = GetCleanPhonebook();
        phonebook.AddAbonent("Тест", "12345");

        phonebook.SaveToFile();
        phonebook.Clear();
        phonebook.LoadFromFile();

        Assert.Equal("12345", phonebook.GetPhoneNumberByName("Тест"));

        if (File.Exists("phonebook.txt"))
        {
            File.Delete("phonebook.txt");
        }
    }
}