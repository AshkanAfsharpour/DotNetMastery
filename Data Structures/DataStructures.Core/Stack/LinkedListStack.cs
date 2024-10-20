public class LinkedListStack<T> : IStack<T>
{
    private Node<T> _top;

    private class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    public LinkedListStack()
    {
        _top = null;
    }

    public void Push(T item)
    {
        var newNode = new Node<T>(item);
        newNode.Next = _top;
        _top = newNode;
    }

    public T Pop()
    {
        if (_top == null) throw new InvalidOperationException("Stack is empty");

        var data = _top.Data;
        _top = _top.Next;
        return data;
    }

    public T Peek()
    {
        if (_top == null) throw new InvalidOperationException("Stack is empty");

        return _top.Data;
    }

    public bool IsEmpty()
    {
        return _top == null;
    }
}