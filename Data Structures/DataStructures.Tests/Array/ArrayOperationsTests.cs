[TestFixture]
public class ArrayOperationsTests
{
    private ArrayOperations<int> _arrayOps;

    [SetUp]
    public void Setup()
    {
        _arrayOps = new ArrayOperations<int>(5);
    }

    [Test]
    public void Add_ShouldAddValueToArray()
    {
        _arrayOps.Add(10);
        _arrayOps.Get(0).Should().Be(10);
    }

    [Test]
    public void Update_ShouldUpdateValueAtSpecifiedIndex()
    {
        _arrayOps.Add(20);
        _arrayOps.Update(0, 50);
        _arrayOps.Get(0).Should().Be(50);
    }

    [Test]
    public void Get_ShouldReturnCorrectValue()
    {
        _arrayOps.Add(30);
        _arrayOps.Get(0).Should().Be(30);
    }

    [Test]
    public void RemoveAt_ShouldRemoveElementAtSpecifiedIndex()
    {
        _arrayOps.Add(40);
        _arrayOps.Add(50);
        _arrayOps.RemoveAt(0);
        _arrayOps.Get(0).Should().Be(50);
    }

    [Test]
    public void Add_ShouldThrowException_WhenArrayIsFull()
    {
        _arrayOps.Add(1);
        _arrayOps.Add(2);
        _arrayOps.Add(3);
        _arrayOps.Add(4);
        _arrayOps.Add(5);

        _arrayOps.Invoking(a => a.Add(6)).Should().Throw<InvalidOperationException>()
            .WithMessage("Array is full");
    }
}