namespace Practice2.Task11;

class Program
{
    static void Main(string[] args)
    {
        int lenght = Convert.ToInt32(args[0]);
        int index = Convert.ToInt32(args[1]);
        int[] arr = new int[lenght + 1];

        for (int i = 0; i <= lenght; i++)
        {
            arr[i] = index;
        }

        foreach (var a in arr)
        {
            Console.Write($"{a} ");
        }
    }
}