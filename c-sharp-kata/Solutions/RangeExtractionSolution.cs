namespace c_sharp_kata.Solutions;
using System.Collections.Generic;

/*
    Range Extraction - https://www.codewars.com/kata/51ba717bb08c1cd60f00002f

    A format for expressing an ordered list of integers is to use a comma separated list of either

    individual integers
    or a range of integers denoted by the starting integer separated from the end integer in the range by a dash, '-'. The range includes all integers in the interval including both endpoints. It is not considered a range unless it spans at least 3 numbers. For example "12,13,15-17"

    Complete the solution so that it takes a list of integers in increasing order and returns a correctly formatted string in the range format.

    Example:

    solution([-10, -9, -8, -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20]);
   
    returns "-10--8,-6,-3-1,3-5,7-11,14,15,17-20"

*/

public class RangeExtractionSolution()
{
    public static string Extract(int[] args)
    {
        // Attempt using two pointer method

        //Base Case
        if(args.Length == 1) return args[0].ToString();

        List<string> res = [];

        int p1 = 0, 
            p2 = 0,
            count = 0;


        while(p2 <= args.Length)
        {

            if (p2 < args.Length && args[p2] >= args[p1] && args[p2] == args[p1] + count)
            // Check if next number is greater that the previous but only by one
            {
                p2++;
                count++;
            }
            else
            {
                if (count >= 3)
                // if there are 3 or more consecutive numbers then create range
                {
                    res.Add($"{args[p1]}-{args[p2 - 1]}");
                    p1 = p2; // reset pointers to start again 
                    count = 0;

                } 
                else if (p1 < args.Length)
                // account for out of range exception when approaching end of array
                {
                    
                    
                        res.Add(args[p1].ToString());
                        p2 = p1;
                        count = 0;
                        p1++;
                        p2++;     
                    
                } else
                {
                    p2++;
                }

            }
        }

        return string.Join("," , res);
    }
}