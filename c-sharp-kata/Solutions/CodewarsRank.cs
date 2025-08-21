namespace c_sharp_kata.Solutions;

/*
 Codewars style ranking system - https://www.codewars.com/kata/51fda2d95d6efda45e00004e

 Write a class called User that is used to calculate the amount that a user will progress through a ranking system similar to the one Codewars uses. 
*/

public class KataUser
{
    public int rank;
    public int progress;

    public KataUser()
    {
        rank = -8; // User starts at rank -8
        progress = 0; ; // Progress starts at 0

    }

    public void IncProgress(int actRank)
    {
        // REQUIREMENTS
            // when progress == 100 then rank++
            // if progress > 100 then progress =  progress - 100
            // when rank == -1 then rank += 2  (skip zero)
            // maxRank = 8
            // if rank < -8 or rank > 8 then ERROR
            // when actRank == rank then progress += 3
            // when actRank == rank-- then progress++
            // when actRank < rank-- then continue
            // when actRank > rank then progress += 10 * (actRank - rank) * (actRank - rank)

    }
}