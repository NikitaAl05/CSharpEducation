namespace Practice4.Part._2Task12;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> inventory = new Dictionary<string, int>();
        
        inventory.Add("Яблоко", 5);
        inventory.Add("Зелье лечения", 3);
        inventory.Add("Золотая монета", 150);

        Console.WriteLine($"Инвентарь: " + inventory);

        if (inventory.ContainsKey("Яблоко"))
        {
            Console.WriteLine("Яблоки есть в инвентаре!");
        }
        
        if (inventory.ContainsKey("Гнилые Яблоки"))
        {
            Console.WriteLine("Гнилые Яблоки отсутсвуют в инвентаре!");
        }

        if (inventory.TryGetValue("Яблоко", out int appleCount))
        {
            Console.WriteLine($"Количество яблок в рюкзаке: {appleCount}");
        }
    }
}

public class Dictionary<TKey,  TValue>
{
    private System.Collections.Generic.Dictionary<TKey, TValue> _dictionary = new();
    
    public void Add(TKey key, TValue value) => _dictionary.Add(key, value);
    public bool Remove(TKey key) => _dictionary.Remove(key);
    public bool ContainsKey(TKey key) => _dictionary.ContainsKey(key);
    public bool TryGetValue(TKey key, out TValue value) => _dictionary.TryGetValue(key, out value);
    
    public override string ToString() => string.Join(",", _dictionary);
    
}