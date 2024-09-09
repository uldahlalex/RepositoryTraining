public class HardLinqTests
{
    private readonly IHardLinqExercises _exercises = new HardLinqExercises();

    [Fact]
    public void TestGetAnagrams()
    {
        // Arrange
        string word = "post";
        var words = new List<string> { "stop", "tops", "spot", "posts", "hello", "world" };

        // Act
        var result = _exercises.GetAnagrams(word, words);

        // Assert
        Assert.Equal(result, (new List<string> { "stop", "tops", "spot" }));
    }

    [Fact]
    public void TestGetLongestIncreasingSequence()
    {
        // Arrange
        var numbers = new List<int> { 1, 2, 3, 1, 2, 3, 4, 1, 2 };

        // Act
        var result = _exercises.GetLongestIncreasingSequence(numbers);

        // Assert
        Assert.Equal(result, (new List<int> { 1, 2, 3, 4 }));
    }
}