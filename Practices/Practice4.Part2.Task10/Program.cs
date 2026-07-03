namespace Practice4.Part2.Task10;

class Program
{
    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        
        Console.WriteLine("Stack: " + stack);
        Console.WriteLine("Пследний элимент: " + stack.Peek());
        Console.WriteLine("Удалили последний элимент: " + stack.Pop());
        
        Console.WriteLine("Stack: " + stack);
        
        
        
        Stack<string> stack2 = new Stack<string>();
        
        stack2.Push("Dog");
        stack2.Push("Cat");
        stack2.Push("Cow");
        stack2.Push("Dinosaur");
        
        Console.WriteLine("Stack: " + stack2);
        Console.WriteLine("Пследний элимент: " + stack2.Peek());
        Console.WriteLine("Удалили последний элимент: " + stack2.Pop());
        
        Console.WriteLine("Stack: " + stack2);
    }
}