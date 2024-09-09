/*
The exercises in here are regarded as being "extra", since they are vastly
more difficult than the previous two.

Task: Implement all the methods. All of them can be completed using LINQ.
Basic conditionals and loops can also do the job.
Success criteria: All tests passing.
Learing objective: Being able to write harder algorithms.
Additional help: I put guided solutions in the ./Solutions directory.
*/



public class HardLinqExercises : IHardLinqExercises
{
    public List<string> GetAnagrams(string word, List<string> words)
    {
        throw new NotImplementedException();
    }

    public List<int> GetLongestIncreasingSequence(List<int> numbers)
    {
        throw new NotImplementedException();
    }
}

public interface IHardLinqExercises
{
    List<string> GetAnagrams(string word, List<string> words);
    List<int> GetLongestIncreasingSequence(List<int> numbers);
}
