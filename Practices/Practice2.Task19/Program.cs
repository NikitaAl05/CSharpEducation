namespace Practice2.Task19;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = CreateArray();
        PrintMaxMinArray(arr);
    }
    public static void PrintMaxMinArray(int[] arr)
    {
        int max = int.MinValue;
        int min = int.MaxValue;
        
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }

            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        int result = max - min;
        Console.WriteLine($"Длинна массива: {arr.Length}");
        Console.WriteLine($"Max: {max}, Min: {min}, Result: {result}");
    }
    public static int[] CreateArray()
    {
        Random random = new Random();
        int[] arr = new int[random.Next(1, 101)];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(1, 101);
        }
        
        return arr;
    }
}