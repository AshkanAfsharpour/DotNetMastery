[MemoryDiagnoser]
public class LinkedListStackBenchmark
{
    private LinkedListStack<int> _stack;

    [GlobalSetup]
    public void Setup()
    {
        _stack = new LinkedListStack<int>();
    }

    [Benchmark]
    public void PushBenchmark()
    {
        for (int i = 0; i < 10000; i++)
        {
            _stack.Push(i);
        }
    }

    [Benchmark]
    public void PopBenchmark()
    {
        for (int i = 0; i < 10000; i++)
        {
            _stack.Push(i);
        }

        for (int i = 0; i < 10000; i++)
        {
            _stack.Pop();
        }
    }

    [Benchmark]
    public void PeekBenchmark()
    {
        _stack.Push(1);

        for (int i = 0; i < 10000; i++)
        {
            _stack.Peek();
        }
    }

    [Benchmark]
    public void IsEmptyBenchmark()
    {
        for (int i = 0; i < 10000; i++)
        {
            _stack.IsEmpty();
        }
    }
}