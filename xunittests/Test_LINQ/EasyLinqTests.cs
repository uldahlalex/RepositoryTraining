namespace xunittests.Test_LINQ;

public class LinqExercisesTests
{
    private readonly IEasyLinqExercises _exercises = new EasyLinqExercises();


    [Fact]
    public void TestGetAllOddNumbers()
    {
        // Arrange
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Act
        var result = _exercises.GetAllOddNumbers(numbers);

        // Assert
        Assert.Equal(result, (new List<int> { 1, 3, 5, 7, 9 }));
    }

    [Fact]
    public void TestGetAverage()
    {
        // Arrange
        var numbers = new List<int> { 1, 2, 3, 4, 5 };

        // Act
        var result = _exercises.GetAverage(numbers);

        // Assert
        Assert.Equal(3, result, 0.001); // third parameter is a delta that allows for floating point inaccuracies
    }

    // Test for Exercise 2
    [Fact]
    public void TestGetAverage2()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        var result = _exercises.GetAverage(numbers);
        Assert.Equal(3, result);
    }

    // Test for Exercise 3
    [Fact]
    public void TestGetFirstThreeNumbers()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        var result = _exercises.GetFirstThreeNumbers(numbers);
        Assert.Equal(result, (new List<int> { 1, 2, 3 }));
    }

    // Test for Exercise 4
    [Fact]
    public void TestGetLastNumber()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        var result = _exercises.GetLastNumber(numbers);
        Assert.Equal(5, result);
    }

    // Test for Exercise 5
    [Fact]
    public void TestGetHelloMessages()
    {
        var names = new List<string> { "Alice", "Bob", "Charlie" };
        var result = _exercises.GetHelloMessages(names);
        Assert.Equal(result, (new List<string> { "Hello, Alice", "Hello, Bob", "Hello, Charlie" }));
    }

    // Test for Exercise 6
    [Fact]
    public void TestCountElements()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        var result = _exercises.CountElements(numbers);
        Assert.Equal(5, result);
    }

    // Test for Exercise 7
    [Fact]
    public void TestGetDoubledNumbers()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        var result = _exercises.GetDoubledNumbers(numbers);
        Assert.Equal(result, (new List<int> { 2, 4, 6, 8, 10 }));
    }

    // Test for Exercise 8
    [Fact]
    public void TestConvertToUpper()
    {
        var words = new List<string> { "apple", "banana", "cherry" };
        var result = _exercises.ConvertToUpper(words);
        Assert.Equal(result, (new List<string> { "APPLE", "BANANA", "CHERRY" }));
    }

    // Test for Exercise 9
    [Fact]
    public void TestIsNumberInList()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        Assert.True(_exercises.IsNumberInList(numbers, 3));
        Assert.False(_exercises.IsNumberInList(numbers, 6));
    }

    // Test for Exercise 10
    [Fact]
    public void TestGetDistinctNumbers()
    {
        var numbers = new List<int> { 1, 1, 2, 2, 3, 3 };
        var result = _exercises.GetDistinctNumbers(numbers);
        Assert.Equal(result, (new List<int> { 1, 2, 3 }));
    }
}