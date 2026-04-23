namespace Practice2.Task18;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = {1, -2, 3, -4, -5, 6, 7, -8, 9};
        int count;
        
        Console.Write("Массив: ");
        WriteArray(arr);
        removeNegatives(arr, out count);
        
        Console.Write("\nИзмененный массив: ");
        WriteArray(arr);
        Console.WriteLine($"\nКол-во удаленных символов: {count}");
    }
    public static void WriteArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write($"{item} ");
        }
    }
    public static void removeNegatives(int[] arr, out int count)
    {
        count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                count++;
                arr[i] = -arr[i];
            }
        }
        
    }
}