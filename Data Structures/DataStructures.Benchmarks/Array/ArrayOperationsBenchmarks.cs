[MemoryDiagnoser]
public class ArrayOperationsBenchmark
{
    private ArrayOperations<int> _arrayOps;

    [GlobalSetup]
    public void Setup()
    {
        _arrayOps = new ArrayOperations<int>(10000);
    }

    [Benchmark]
    public void AddBenchmark()
    {
        for (int i = 0; i < 10000; i++)
        {
            _arrayOps.Add(i);
        }
    }

    [Benchmark]
    public void GetBenchmark()
    {
        for (int i = 0; i < 10000; i++)
        {
            _arrayOps.Get(i % _arrayOps.Count);
        }
    }

    [Benchmark]
    public void UpdateBenchmark()
    {
        for (int i = 0; i < 10000; i++)
        {
            _arrayOps.Update(i % _arrayOps.Count, i);
        }
    }

    [Benchmark]
    public void RemoveAtBenchmark()
    {
        for (int i = 0; i < 10000; i++)
        {
            _arrayOps.Add(i);
        }

        for (int i = 9999; i >= 0; i--)
        {
            _arrayOps.RemoveAt(i);
        }
    }
}