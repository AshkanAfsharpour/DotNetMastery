using System.Collections.Concurrent;

public class ConcurrentStackWrapper<T>
{
    private readonly ConcurrentStack<T> _stack;

    public ConcurrentStackWrapper()
    {
        _stack = new ConcurrentStack<T>();
    }

    public void Push(T item)
    {
        _stack.Push(item);
    }

    public T Pop()
    {
        if (_stack.TryPop(out var result))
        {
            return result;
        }
        throw new InvalidOperationException("Stack is empty");
    }

    public T Peek()
    {
        if (_stack.TryPeek(out var result))
        {
            return result;
        }
        throw new InvalidOperationException("Stack is empty");
    }

    public bool IsEmpty()
    {
        return _stack.IsEmpty;
    }
}