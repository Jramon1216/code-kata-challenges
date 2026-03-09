namespace c_sharp_kata.Solutions;

/*
    Group by commas - https://www.codewars.com/kata/5274e122fc75c0943d000148

    Finish the solution so that it takes an input n (integer) and returns a string that is the decimal representation of the number grouped by commas after every 3 digits.

        1         ->           "1"
        10        ->          "10"
        100       ->         "100"
        1000      ->       "1,000"
        10000     ->      "10,000"
        100000    ->     "100,000"
        1000000   ->   "1,000,000"
        35235235  ->  "35,235,235"
*/

public class GroupByCommasSolution()
{
    public static string GroupByCommas(int n)
    {
        // Attempt without using .Format() method
        
        // Base case
        if (n >= 0 && n < 1000) return n.ToString();

        bool isNegative = n < 0;
        string numString = isNegative ? n.ToString().Remove(0, 1) : n.ToString();
        int len = numString.Length;
        int count = 0;

        for (int i = len; i >= 0; i--)
        {
            count++;

            if (count == 4)
            {
                numString = numString.Insert(i, ",");
                count = 0;
                i++;
            }
        }

        if (numString[0].Equals(',')) numString = numString[1..];

        //* isNegative then add '-' back to the string
        if (isNegative) return numString.Insert(0, "-");

        return numString;
    }
}
