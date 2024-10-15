[TestFixture]
public class ArrayStackTests
{
    private ArrayStack<int> _stack;

    [SetUp]
    public void Setup()
    {
        _stack = new ArrayStack<int>(5);
    }

    [Test]
    public void Push_ShouldAddItemToStack()
    {
        // Act
        _stack.Push(10);

        // Assert
        _stack.Peek().Should().Be(10);
    }

    [Test]
    public void Pop_ShouldRemoveItemFromStack()
    {
        // Arrange
        _stack.Push(20);

        // Act
        var result = _stack.Pop();

        // Assert
        result.Should().Be(20);
        _stack.IsEmpty().Should().BeTrue();
    }

    [Test]
    public void Peek_ShouldReturnTopItemWithoutRemovingIt()
    {
        // Arrange
        _stack.Push(30);
        _stack.Push(40);

        // Act
        var result = _stack.Peek();

        // Assert
        result.Should().Be(40);
        _stack.IsEmpty().Should().BeFalse();
    }

    [Test]
    public void IsEmpty_ShouldReturnTrue_WhenStackIsEmpty()
    {
        // Act & Assert
        _stack.IsEmpty().Should().BeTrue();
    }

    [Test]
    public void IsEmpty_ShouldReturnFalse_WhenStackIsNotEmpty()
    {
        // Arrange
        _stack.Push(50);

        // Act & Assert
        _stack.IsEmpty().Should().BeFalse();
    }

    [Test]
    public void Pop_ShouldThrowException_WhenStackIsEmpty()
    {
        // Act & Assert
        _stack.Invoking(s => s.Pop())
            .Should().Throw<InvalidOperationException>()
            .WithMessage("Stack is empty");
    }

    [Test]
    public void Push_ShouldThrowException_WhenStackOverflows()
    {
        // Arrange
        _stack.Push(1);
        _stack.Push(2);
        _stack.Push(3);
        _stack.Push(4);
        _stack.Push(5);

        // Act & Assert
        _stack.Invoking(s => s.Push(6))
            .Should().Throw<StackOverflowException>();
    }
}