namespace Practice4.Part2.Task10;

public class Stack<T>
{
    private List<T> _list = new List<T>();
    public void Push(T item)
    {
        _list.Add(item);
    }

    public T Pop()
    {
        if (_list.Count == 0)
        { throw new InvalidOperationException("Стек пуст!"); }
        T pop = _list[_list.Count - 1];
        _list.RemoveAt(_list.Count - 1);
        return pop;
        
    }

    public T Peek()
    {
        return _list[_list.Count - 1];
    }
    
    public override string ToString()
    {
        return string.Join(" -> ", _list);
    }
}