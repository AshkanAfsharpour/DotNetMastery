public class QueueStack<T> : IStack<T>
{
    private Queue<T> _queue;

    public QueueStack()
    {
        _queue = new Queue<T>();
    }

    public void Push(T item)
    {
        var tempQueue = new Queue<T>();
        tempQueue.Enqueue(item);

        while (_queue.Count > 0)
        {
            tempQueue.Enqueue(_queue.Dequeue());
        }

        _queue = tempQueue;
    }

    public T Pop()
    {
        if (_queue.Count == 0) throw new InvalidOperationException("Stack is empty");

        return _queue.Dequeue();
    }

    public T Peek()
    {
        if (_queue.Count == 0) throw new InvalidOperationException("Stack is empty");

        return _queue.Peek();
    }

    public bool IsEmpty() => _queue.Count == 0;
}