using static c_sharp_kata.Solutions.GetLengthOfMissingArraySolution;
using static System.Console;
namespace c_sharp_kata;

public class Program
{
    public static void Main(string[] args)
    {
        WriteLine(GetLengthOfMissingArray3(
        new object[][] { 
                new object[] { 1, 2 }, 
                new object[] { 4, 5, 1, 1 }, 
                new object[] { 1 }, 
                new object[] { 5, 6, 7, 8, 9 } }));
         }
}
