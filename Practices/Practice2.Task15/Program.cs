namespace Practice2.Task15;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[] {1, 2, 3, 4, 5};
        int[] reverseArray = Arraye(arr);
        foreach (int i in reverseArray)
        {
            Console.Write($"{i} ");
        }
    }
    public static int[] Arraye(int[] arr)
    {
        for (int i = 0; i < arr.Length / 2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[arr.Length - 1 - i];
            arr[arr.Length - 1 - i] = temp;
        }
        
        return arr;
    }
}