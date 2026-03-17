namespace c_sharp_kata.Solutions;
using System.Linq;

/*
Getting to know LINQ - https://www.codewars.com/kata/581d2647b2d02e33be000094/


In .NET the Language Integrated Query (LINQ) component adds several helpful methods that can be used with enumerables.

The goal of this Kata is to practice some scenarios where LINQ can be used to replace loops.

Replace each loop in the code with a LINQ expression. The validation will fail if the words 'for' or 'while' occurs anywhere in the code (even in comments).

*/
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
