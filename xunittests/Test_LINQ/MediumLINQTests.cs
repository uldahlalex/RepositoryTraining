


using gettingstarted;

public class MediumLinqExercisesTests
{
    private readonly IMediumLinqExercises _exercises = new MediumLinqExercises();

    [Fact]
    public void TestCountVowels()
    {
        string text = "Hello, World!";
        int result = _exercises.CountVowels(text);
        Assert.Equal(3, result);
    }

    [Fact]
    public void TestGetNumbersInRange_IncludesNumbers()
    {
        // Arrange
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Act
        var result = _exercises.GetNumbersInRange(numbers, 2, 5);

        // Assert
        Assert.Equal(result, (new List<int> { 3, 4, 5, 6 }));
    }

    [Fact]
    public void TestGetNumbersInRange_DoesNotIncludeNumbers()
    {
        // Arrange
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Act
        var result = _exercises.GetNumbersInRange(numbers, 10, 15);

        // Assert
        Assert.Equal(result, new List<int>());
    }

    [Fact]
    public void TestGetNumbersInRange_IncludesAllNumbers()
    {
        // Arrange
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Act
        var result = _exercises.GetNumbersInRange(numbers, 0, 9);

        // Assert
        Assert.Equal(result, (numbers));
    }

    [Fact]
    public void TestGetNumbersInRange_EmptyInputList()
    {
        // Arrange
        var numbers = new List<int>();

        // Act
        var result = _exercises.GetNumbersInRange(numbers, 0, 9);

        // Assert
        Assert.Equal(result, new List<int>());
    }


    [Fact]
    public void TestGetSumOfSquares()
    {
        // Arrange
        var numbers = new List<int> { 1, 2, 3 };

        // Act
        int result = _exercises.GetSumOfSquares(numbers);

        // Assert
        Assert.Equal(14, result);
    }

    [Fact]
    public void TestGetWordsLongerThanN()
    {
        // Arrange
        var words = new List<string> { "apple", "banana", "cherry", "kiwi", "lime" };

        // Act
        var result = _exercises.GetWordsLongerThanN(words, 4);

        // Assert
        Assert.Equal(result, (new List<string> { "apple", "banana", "cherry" }));
    }

    [Fact]
    public void TestGetDistinctWords()
    {
        // Arrange
        string text = "apple apple banana cherry banana";

        // Act
        var result = _exercises.GetDistinctWords(text);

        // Assert
        Assert.Equal(result, (new List<string> { "apple", "banana", "cherry" }));
    }

    [Fact]
    public void TestAnyWordStartsWithA()
    {
        // Arrange
        var words = new List<string> { "apple", "banana", "cherry" };

        // Act
        bool result = _exercises.AnyWordStartsWithA(words);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void TestGetNumberDivisibleBy3Or5()
    {
        var expected = new int[] { 3, 15, 27, 25 };
        var result = _exercises.GetNumbersDivisibleBy3Or5(new List<int>() { 1, 3, 15, -26, 27, 25 });
        Assert.Equal(result, expected);
    }

    [Fact]
    public void TestGetWordsSortedByLength()
    {
        var expected = new List<string>() { "a", "asd", "bbbbb" };
        var actual = _exercises.GetWordsSortedByLength("a asd bbbbb");
        Assert.Equal(expected, actual);
    }


    [Fact]
    public void TestGetSquaredNumbersSorted()
    {
        // Arrange
        var numbers = new List<int> { 5, 2, 1, 4, 3 };

        // Act
        var result = _exercises.GetSquaredNumbersSorted(numbers);

        // Assert
        Assert.Equal(result, (new List<int> { 1, 4, 9, 16, 25 }));
    }

    [Fact]
    public void TestCountUniqueCharacters()
    {
        // Arrange
        string text = "apple";

        // Act
        int result = _exercises.CountUniqueCharacters(text);

        // Assert
        Assert.Equal(4, result);
    }

    [Fact]
    public void TestGetWordFrequencies()
    {
        // Arrange
        string text = "apple apple banana";

        // Act
        var result = _exercises.GetWordFrequencies(text);

        // Assert
        Assert.Equal(result, (new Dictionary<string, int> { { "apple", 2 }, { "banana", 1 } }));
    }

    [Fact]
    public void TestGetLongestString()
    {
        // Arrange
        var strings = new List<string> { "apples", "banana", "cherries" };

        // Act
        string result = _exercises.GetLongestString(strings);

        // Assert
        Assert.Equal("cherries", result);
    }
}