public class StackWrapper<T>
{
    private readonly Stack<T> _stack;

    public StackWrapper()
    {
        _stack = new Stack<T>();
    }

    public void Push(T item)
    {
        _stack.Push(item);
    }

    public T Pop()
    {
        if (_stack.Count == 0) throw new InvalidOperationException("Stack is empty");

        return _stack.Pop();
    }

    public T Peek()
    {
        if (_stack.Count == 0) throw new InvalidOperationException("Stack is empty");

        return _stack.Peek();
    }

    public bool IsEmpty()
    {
        return _stack.Count == 0;
    }
}