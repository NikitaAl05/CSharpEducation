namespace Practice2.Task12;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Рамзер массива: ");   
        int lenght = Convert.ToInt32(Console.ReadLine());
        string[] array = new string[lenght];
        
        for (int i = 0; i < lenght; i++)
        {
            Console.Write("Введите слово: ");
            array[i] = Console.ReadLine();
        }
        
        foreach (var a in array)
        {
            Console.Write($"{a} ");
        }
    }
}