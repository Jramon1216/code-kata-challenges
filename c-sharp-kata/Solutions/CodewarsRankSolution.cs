namespace c_sharp_kata.Solutions;

/*
 Codewars style ranking system - https://www.codewars.com/kata/51fda2d95d6efda45e00004e

 Write a class called User that is used to calculate the amount that a user will progress through a ranking system similar to the one Codewars uses. 
*/

// REQUIREMENTS
// when rank == -1 then rank += 2  (skip zero)

public class KataUser
{
    public int rank { get; private set; }
    public int progress { get; private set; }

     static readonly int maxRank = 8;
     static readonly int minRank = -8;
    public KataUser()
    {
        rank = -8; // User starts at rank -8
        progress = 0; ; // Progress starts at 0

    }

    public void IncProgress(int actRank)
    {
        int n = rank - 1;

        // if rank < -8 or rank > 8 then ERROR
        if (rank < minRank || rank > maxRank)
        {
            throw new ArgumentException("ERROR: Rank value out of bounds.");
        }

        if (progress == 100)
        {
            rank++;
        }

        // when actRank == rank then progress += 3
        if (actRank == rank)
        {
            progress += 3;
        }
        // when actRank == rank-- then progress++
        else if (actRank == n)
        {
            progress++;
        }
        // when actRank < rank-- then continue
        else if (actRank < n)
        {
            return;
        }
        // when actRank > rank then progress += 10 * (actRank - rank) * (actRank - rank)
        else if (actRank > rank)
        {
            progress += 10 * (actRank - rank) * (actRank - rank);
        }

        if (progress > 100)
        {
            while (progress > 100)
            {
                progress -= 100;
                rank++;
            }
        }
        
        if (rank == 0)
        {
            rank++;
        }

    }
}