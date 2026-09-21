namespace c_sharp_kata.Solutions;
using System;

/*
Sum of odd numbers - https://www.codewars.com/kata/55fd2d567d94ac3bc9000064/train

Given the triangle of consecutive odd numbers:

               1
            3     5
         7     9    11
       13    15    17    19
    21    23    25    27    29
...


Calculate the sum of the numbers in the nth row of this triangle (starting at index 1) e.g.: (Input --> Output)

1 -->  1
2 --> 3 + 5 = 8

*/

public class RowSumOddNumbersSolution
{
    public static object RowSumOddNumbers (long n)
    {
        /*
            * 2 for loops, one to iterate by row then another to get the odd numbers of that row
            
            *LOOP 1*
                Iterate through rows to find the starting number for that row
            
            *LOOP 2*
                Create row of odd numbers and use parameter to know when you've reached the end of the row
            
        */

        if(n == 1) return 1; 

        int num = 1;
        int multiplier = 2;

        for(int rowNumber=2; rowNumber <= n; rowNumber++)
        {
            num += multiplier;
            multiplier += 2;
        }

        //! calculation is wrong, seems to be overshooting. Need to review how sum and num is being added 
        //TODO: Debug for loop
        int sum = num;
        for(int i=0; i < n; i++)
        {
            num += 2;
            sum += num;
        }
        
        return sum;

    }
}