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
    public static object Score(int[] dice) // First attempt 
    {

        //  TODO: Create a private list for triple values then replace numbers in switch case with list indexes

        // * Try caching occurences then using LINQ to filter out zeros then iterate 
        // * through each occurence after filtering out zeros
        int finalScore = 0;

        Dictionary<int, int> occurrences = new()
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
            occurrences.TryGetValue(number, out int value);
            value++;
            occurrences[number] = value;

            switch (number)
            {
                case 1:
                    finalScore += 100;

                    if(occurrences[number] == 3)
                    {
                        finalScore -= 300;
                        finalScore += 1000;
                    }
                    break;
                case 2:
                    if (occurrences[number] == 3)
                    {
                        finalScore += 200;
                    }
                    break;
                case 3:
                if (occurrences[number] == 3)
                    {
                       finalScore += 300; 
                    }
                    break;
                case 4:
                if (occurrences[number] == 3)
                {
                    finalScore += 400;
                }
                    break;
                case 5:
                finalScore += 50;

                if (occurrences[number] == 3)
                {
                    finalScore -= 150;
                    finalScore += 500;
                }
                    break;
                case 6:
                if (occurrences[number] == 3)
                {
                    finalScore += 600;
                }
                    break;
                default:
                    break;
            }
        }

        return finalScore;
            }
        }
