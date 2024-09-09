/*
Task: Implement all the methods. All of them can be completed using LINQ.
Basic conditionals and loops can also do the job.
Success criteria: All tests passing.
Learing objective: Being able to write medium difficulty algorithms.
Additional help: I put guided solutions in the ./Solutions directory.
*/


namespace gettingstarted;


public class MediumLinqExercises : IMediumLinqExercises
{
    public int CountVowels(string text)
    {
        throw new NotImplementedException();
    }

    public List<int> GetNumbersInRange(List<int> numbers, int start, int end)
    {
        throw new NotImplementedException();
    }

    public int GetSumOfSquares(List<int> numbers)
    {
        throw new NotImplementedException();
    }

    public List<string> GetWordsLongerThanN(List<string> words, int n)
    {
        throw new NotImplementedException();
    }

    public List<string> GetDistinctWords(string text)
    {
        throw new NotImplementedException();
    }

    public bool AnyWordStartsWithA(List<string> words)
    {
        throw new NotImplementedException();
    }

    public List<int> GetNumbersDivisibleBy3Or5(List<int> numbers)
    {
        throw new NotImplementedException();
    }

    public List<string> GetWordsSortedByLength(string text)
    {
        throw new NotImplementedException();
    }

    public List<int> GetSquaredNumbersSorted(List<int> numbers)
    {
        throw new NotImplementedException();
    }

    public int CountUniqueCharacters(string text)
    {
        throw new NotImplementedException();
    }

    public Dictionary<string, int> GetWordFrequencies(string text)
    {
        throw new NotImplementedException();
    }

    public string GetLongestString(List<string> strings)
    {
        throw new NotImplementedException();
    }
}

public interface IMediumLinqExercises
{
    int CountVowels(string text);
    List<int> GetNumbersInRange(List<int> numbers, int startIndex, int endIndex);

    // Return the sum of squares of all numbers in the list
    int GetSumOfSquares(List<int> numbers);

    // Return a list of all words longer than n characters
    List<string> GetWordsLongerThanN(List<string> words, int n);

    // Return a list of all distinct words in a string (split by spaces)
    List<string> GetDistinctWords(string text);

    // Return true if any word in a list starts with the letter 'a', false otherwise
    bool AnyWordStartsWithA(List<string> words);

    // Return a list of all numbers in the list that are divisible by 3 or 5
    List<int> GetNumbersDivisibleBy3Or5(List<int> numbers);

    // Return a sorted list of all words in a string, sorted by length (split by spaces)
    List<string> GetWordsSortedByLength(string text);

    // Return a list of all numbers in the list squared, sorted in ascending order
    List<int> GetSquaredNumbersSorted(List<int> numbers);

    // Return the count of all unique characters in a string
    int CountUniqueCharacters(string text);

    // Return a dictionary of all unique words in a string with their frequencies (split by spaces)
    Dictionary<string, int> GetWordFrequencies(string text);

    // Return the longest string in a list of strings
    string GetLongestString(List<string> strings);
}
