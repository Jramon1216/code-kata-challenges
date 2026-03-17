namespace c_sharp_kata.Solutions;

using System.ComponentModel.Design;
using System.Linq;

public class GettingToKnowLINQSolution
{
    public static int Sum(int[] integers)
    {
        int sum = integers.Sum(i => i);

        return sum;
    }

    public static int CountChar(char[] chars, char charToCount)
    {
        var occurences = (from c in chars where c == charToCount select c).Count();
        return occurences;
    }

    public static int[] CalculateSquares(int start, int end)
    {
        return [.. from n in Enumerable.Range(start, end - start + 1) select n * n];
    }
}
