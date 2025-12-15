using System;

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
    public static void  GetLengthOfMissingArray(object[][] arrayOfArrays)
    {
        /*
            - sort the arrays by length
            - have a counter equal to the array with the lowest length (first array in list)
            - if the length of the current list is not equal to the counter then return the counter
        */
        List<int> lengths = [];

        foreach(var array in arrayOfArrays)
        {
            lengths.Add(array.Length());
        }

        // TODO: sort lengths list

    }
}