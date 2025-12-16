using System.Collections.Generic;
using System.Diagnostics;
namespace c_sharp_kata.Solutions;

/*
    Length of missing array - https://www.codewars.com/kata/57b6f5aadb5b3d0ae3000611/

    You get an array of arrays.
    If you sort the arrays by their length, you will see, that their length-values are consecutive.
    But one array is missing!


    You have to write a method, that return the length of the missing array.

    Example:
    [[1, 2], [4, 5, 1, 1], [1], [5, 6, 7, 8, 9]] --> 3


    If the array of arrays is null/nil or empty, the method should return 0.

    When an array in the array is null or empty, the method should return 0 too!
    There will always be a missing element and its length will be always between the given arrays. 
*/

public class GetLengthOfMissingArraySolution
{
    public static int GetLengthOfMissingArray(object[][] arrayOfArrays)
    {
        /*
            - sort the arrays by length
            - have a counter equal to the array with the lowest length (first array in list)
            - if the length of the current list is not equal to the counter then return the counter
        */

        if(arrayOfArrays == null || arrayOfArrays.Length == 0) return 0;

        List<int> lengths = [];

        foreach (object[] array in arrayOfArrays)
        {
            if (array == null || array.Length == 0)
            {
                return 0;
            }
            else
            {
                lengths.Add(array.Length);
            }
        }
        
        lengths.Sort();
        int counter = lengths[0];

        foreach(var l in lengths)
        {
            if(l != counter)
            {
                return counter;
            } 
            else
            {
                counter++;
            }
        }

        return 0;
    }

    public static int GetLengthOfMissingArray2(object[][] arrayOfArrays)
    {
        /*
            ? What's the minimum length?
            ? What's the minimum length?
            ? How many arrays do you have?
            ? If the lengths were consecutive with nothing missing, how many arrays should you have?
            
            * That difference should tell you what's mising
        */
    }
}