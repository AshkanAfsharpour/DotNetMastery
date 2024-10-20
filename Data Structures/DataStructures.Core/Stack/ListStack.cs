public class ListStack<T> : IStack<T>
{
    private List<T> _stack;

    public ListStack()
    {
        _stack = new List<T>();
    }

    public void Push(T item)
    {
        _stack.Add(item);
    }

    public T Pop()
    {
        if (_stack.Count == 0) throw new InvalidOperationException("Stack is empty");

        var item = _stack[^1];
        _stack.RemoveAt(_stack.Count - 1);
        return item;
    }

    public T Peek()
    {
        if (_stack.Count == 0) throw new InvalidOperationException("Stack is empty");

        return _stack[^1];
    }

    public bool IsEmpty()
    {
        return _stack.Count == 0;
    }
}
