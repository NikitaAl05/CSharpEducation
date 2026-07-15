namespace Practice.Task1.Interface;

class Program
{
    static void Main(string[] args)
    {

    }
}


// public interface IStorage<T>
// {
//     int Count { get; }
//     
//     T GetObject(int index);
//     
//     void PutObject(T obj);
// }
//
// public class Chest<T> : IStorage<T>
// {
//     private readonly List<T> _items = new List<T>();
//     
//     public int Count => _items.Count;
//     
//     public T GetObject(int index)
//     {
//         if (index >= 0 && index < _items.Count)
//         return _items[index];
//     }
//
//     public void PutObject(T obj)
//     {
//         _items.Add(obj);
//     }
//     
// }
//
