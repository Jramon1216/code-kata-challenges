using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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

       //! There is no need to put the lengths of the arrays into their own list
       //! just use Length property directly
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
        
        //! arrayOfArrays can be sorted using linq
        //! think about using linq before considering using list methods
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
        
        if(arrayOfArrays == null || arrayOfArrays.Length == 0) return 0;
        
        var emptyArrays = arrayOfArrays.Count(arr => arr == null || arr.Length == 0);
        if (emptyArrays > 0) return 0;

        // Gauss formula method: expected count = max - min + 1
        int max = arrayOfArrays[0].Length;
        int min = arrayOfArrays[0].Length;
        int expected = 0;
        int actual = 0;

        foreach (var array in arrayOfArrays) // find range of array lengths
        {
            if (array.Length > max) max = array.Length;
            if (array.Length < min) min = array.Length;
        }

        // calculate the expects sum of consecuitve integers from
        // min to max
        for(int i = min; i <= max; i++)
        {
            expected += i;
        }

        // calculate the some of array lengths in the original array
        foreach(var array in arrayOfArrays)
        {   
            actual += array.Length;
        }

        // return difference
        return expected - actual;
    }

    public static int GetLengthOfMissingArray3(object[][] arrayOfArrays)
    {
        // Check if the input array is empty
        if (arrayOfArrays == null || arrayOfArrays.Length == 0) return 0;

        // Hashset of lengths for fast lookup
        HashSet<int> lengths = new HashSet<int>();

        // Smallest length in the array
        int? min = arrayOfArrays[0]?.Length;

        // Largest length in the array 
        int? max = arrayOfArrays[0]?.Length; 

        foreach(var array in arrayOfArrays){
            
            // Check if array is valid
            if(array == null || array.Length == 0) return 0;

            if(array.Length > max) max = array.Length;
            if(array.Length < min) min = array.Length;
            
            lengths.Add(array.Length);
        }

        for(int i = (int)min; i <= max; i++)
        {
            if(!lengths.Contains(i)) return i;
        }

        return 0;
    }
}


