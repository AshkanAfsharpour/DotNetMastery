[TestFixture]
public class LinkedListStackTests
{
    private LinkedListStack<int> _stack;

    [SetUp]
    public void Setup()
    {
        _stack = new LinkedListStack<int>();
    }

    [Test]
    public void Push_ShouldAddItemToStack()
    {
        _stack.Push(10);
        _stack.Peek().Should().Be(10);
    }

    [Test]
    public void Pop_ShouldRemoveItemFromStack()
    {
        _stack.Push(20);
        var result = _stack.Pop();
        result.Should().Be(20);
        _stack.IsEmpty().Should().BeTrue();
    }

    [Test]
    public void Peek_ShouldReturnTopItemWithoutRemovingIt()
    {
        _stack.Push(30);
        _stack.Push(40);
        var result = _stack.Peek();
        result.Should().Be(40);
        _stack.IsEmpty().Should().BeFalse();
    }

    [Test]
    public void IsEmpty_ShouldReturnTrue_WhenStackIsEmpty()
    {
        _stack.IsEmpty().Should().BeTrue();
    }

    [Test]
    public void IsEmpty_ShouldReturnFalse_WhenStackIsNotEmpty()
    {
        _stack.Push(50);
        _stack.IsEmpty().Should().BeFalse();
    }

    [Test]
    public void Pop_ShouldThrowException_WhenStackIsEmpty()
    {
        _stack.Invoking(s => s.Pop())
            .Should().Throw<InvalidOperationException>()
            .WithMessage("Stack is empty");
    }
}