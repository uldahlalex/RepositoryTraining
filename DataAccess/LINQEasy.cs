
public class EasyLinqExercises : IEasyLinqExercises
{
    // Exercise 1: Return all odd numbers from the given list.
    public List<int> GetAllOddNumbers(List<int> numbers)
    {
        throw new NotImplementedException();
    }

    // Exercise 2: Return the average of all numbers from the given list.
    public double GetAverage(List<int> numbers)
    {
        throw new NotImplementedException();
    }

    // Exercise 3: Return the first 3 numbers from the given list.
    public List<int> GetFirstThreeNumbers(List<int> numbers)
    {
        throw new NotImplementedException();
    }

    // Exercise 4: Return the last number from the given list.
    public int GetLastNumber(List<int> numbers)
    {
        throw new NotImplementedException();
    }

    // Exercise 5: Return the string "Hello, [name]" for each name in the given list.
    public List<string> GetHelloMessages(List<string> names)
    {
        throw new NotImplementedException();
    }

    // Exercise 6: Return the number of elements in the given list.
    public int CountElements(List<int> numbers)
    {
        throw new NotImplementedException();
    }

    // Exercise 7: Return a list of numbers multiplied by 2.
    public List<int> GetDoubledNumbers(List<int> numbers)
    {
        throw new NotImplementedException();
    }

    // Exercise 8: Return a list of strings converted to uppercase.
    public List<string> ConvertToUpper(List<string> words)
    {
        throw new NotImplementedException();
    }

    // Exercise 9: Return true if the given number exists in the list, false otherwise.
    public bool IsNumberInList(List<int> numbers, int number)
    {
        throw new NotImplementedException();
    }

    // Exercise 10: Return a list of distinct numbers from the given list.
    public List<int> GetDistinctNumbers(List<int> numbers)
    {
        throw new NotImplementedException();
    }
}

public interface IEasyLinqExercises
{
    List<int> GetAllOddNumbers(List<int> numbers);
    double GetAverage(List<int> numbers);
    List<int> GetFirstThreeNumbers(List<int> numbers);
    int GetLastNumber(List<int> numbers);
    List<string> GetHelloMessages(List<string> names);
    int CountElements(List<int> numbers);
    List<int> GetDoubledNumbers(List<int> numbers);
    List<string> ConvertToUpper(List<string> words);
    bool IsNumberInList(List<int> numbers, int number);
    List<int> GetDistinctNumbers(List<int> numbers);
}
