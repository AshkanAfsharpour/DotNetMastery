public class ArrayOperations<T>
{
    private T[] _array;
    private int _count;

    public ArrayOperations(int size)
    {
        _array = new T[size];
        _count = 0;
    }

    public int Count => _count;

    public void Add(T value)
    {
        if (_count == _array.Length)
            throw new InvalidOperationException("Array is full");
        _array[_count++] = value;
    }

    public void Update(int index, T value)
    {
        if (index < 0 || index >= _count)
            throw new IndexOutOfRangeException("Invalid index");
        _array[index] = value;
    }

    public T Get(int index)
    {
        if (index < 0 || index >= _count)
            throw new IndexOutOfRangeException("Invalid index");
        return _array[index];
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= _count)
            throw new IndexOutOfRangeException("Invalid index");

        for (int i = index; i < _count - 1; i++)
        {
            _array[i] = _array[i + 1];
        }

        _count--;
    }

    public void Print()
    {
        for (int i = 0; i < _count; i++)
        {
            Console.Write(_array[i] + " ");
        }
        Console.WriteLine();
    }
}