namespace Practice2.Task20;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int[,] arr = CreateArray();
        
        PrintArray(arr);
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            int max = arr[i,0];
            int min = arr[i,0];
            
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] > max)
                {
                    max = arr[i, j];
                }
        
                if (arr[i, j] < min)
                {
                    min = arr[i, j];
                }
            }
            int result = max - min;
            Console.WriteLine($"Max: {max}, Min: {min}, Result: {result}");
        }
    }
    public static void PrintArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
    public static int[,] CreateArray()
    {
        Random random = new Random();
        int[,] arr =  new int[3, 3];

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = random.Next(1, 101);
            }
        }
        return arr;
    }
}