public class ArrayStack<T> : IStack<T>
{
    private T[] items;
    private int top;

    public ArrayStack(int capacity)
    {
        items = new T[capacity];
        top = -1;
    }

    public void Push(T item)
    {
        if (top == items.Length - 1) throw new StackOverflowException();
        items[++top] = item;
    }

    public T Pop()
    {
        if (IsEmpty()) throw new InvalidOperationException("Stack is empty");
        return items[top--];
    }

    public T Peek()
    {
        if (IsEmpty()) throw new InvalidOperationException("Stack is empty");
        return items[top];
    }

    public bool IsEmpty() => top == -1;
}