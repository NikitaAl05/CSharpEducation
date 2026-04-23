namespace Practice2.Task10;

class Program
{
    static void Main(string[] args)
    {
        int lenght = Convert.ToInt32(args[0]);
        int[] arr = new int[lenght + 1];

        for (int i = 0; i <= lenght; i++)
        {
            arr[i] = i;
        }

        foreach (var a in arr)
        {
            Console.Write($"{a} ");
        }
    }
}