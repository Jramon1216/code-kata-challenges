namespace c_sharp_kata.Solutions;
using System.Collections.Generic;
/*
    Greed Is Good - https://www.codewars.com/kata/5270d0d18625160ada0000e4

    Greed is a dice game played with five six-sided dice. Your mission, should you choose to accept it, is to score a throw according to these rules. You will always be given an array with five six-sided dice values.

    Three 1's => 1000 points
    Three 6's =>  600 points
    Three 5's =>  500 points
    Three 4's =>  400 points
    Three 3's =>  300 points
    Three 2's =>  200 points
    One   1   =>  100 points
    One   5   =>   50 point

    Each of 5 dice can only be counted once in each roll. For example, a given "5" can only count as part of a triplet (contributing to the 500 points) or as a single 50 points, but not both in the same roll.

    Example scoring

    Throw       Score
    ---------   ------------------
    5 1 3 4 1   250:  50 (for the 5) + 2 * 100 (for the 1s)
    1 1 1 3 1   1100: 1000 (for three 1s) + 100 (for the other 1)
    2 4 4 5 4   450:  400 (for three 4s) + 50 (for the 5)
*/

public class GreedIsGoodSolution
{
    public static int Score(int[] dice)
    {
        // * Maybe count the occurences of each and use that to get the score

        // TODO: replace GetValue method with TryGetValue method
        // * Figure out what happens to the remaning values if one or five is greater than three
        // * if a value is greater than 3 then subtract 3 from value and add remaming score


        Dictionary<int, int> cache = new()
        {
            {1,0},
            {2,0},
            {3,0},
            {4,0},
            {5,0},
            {6,0}
        };

        foreach(int number in dice)
        {
            if (dice.Contains(number))
            {
                int value = 0;
                dice.GetValue(number, value);
                value++;
            }
        }

        return 0;
    }
}