namespace Practice2.Task9;

class Program
{
    static void Main(string[] args)
    {
        var str = Arrays(5);
        PrintArray(str);
    }
    public static int[] Arrays(int a)
    {
        int[] arr = new int[a + 1];
        for (int i = 0; i <= a; i++)
        {
            arr[i] = i;
        }
        return arr;
    }
    public static void PrintArray(int[] arr)
    {
        foreach (var a in arr)
        {
            Console.Write($"{a} ");
        }
    }
}