namespace Practice2.Task14;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = Arraye(5);
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i;
        }

        foreach (var a in arr)
        {
            Console.Write($"{a} ");
        }
    }
    public static int[] Arraye(int a)
    {
        int[] arr = new int[a];
        return arr;
    }
}