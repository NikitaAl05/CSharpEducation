namespace Practice2.Task13;

class Program
{
    static void Main(string[] args)
    {
        int[,] arr = Arraye(3, 3);
        PrintArray(arr);
    }
    public static int[,] Arraye(int a, int b)
    {
        Random ra = new Random();
        int[,] arr = new int[a, b];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = ra.Next(0, 101);
            }
        }
        return arr;
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
}